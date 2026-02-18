using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private WindowsMediaPlayer _player;
        private bool _isPlaying = false;
        private const string StreamUrl = "https://stream.xradio.com.tr:8770/stream";

        public Form1()
        {
            InitializeComponent();
            InitializePlayer();
        }

        private void InitializePlayer()
        {
            _player = new WindowsMediaPlayer();
            _player.settings.autoStart = false;
            _player.settings.volume = (int)trackBarVolume.Value;
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (_isPlaying)
            {
                _player.controls.stop();
                _isPlaying = false;
                btnPlayPause.Text = "▶";
                lblStatus.Text = "⏸  Durduruldu";
                btnPlayPause.BackColor = Color.FromArgb(80, 80, 100);
            }
            else
            {
                _player.URL = StreamUrl;
                _player.controls.play();
                _isPlaying = true;
                btnPlayPause.Text = "⏸";
                lblStatus.Text = "🔴  Canlı Yayın Dinleniyor...";
                btnPlayPause.BackColor = Color.FromArgb(200, 50, 50);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _player.controls.stop();
            _isPlaying = false;
            btnPlayPause.Text = "▶";
            lblStatus.Text = "⏹  Durduruldu";
            btnPlayPause.BackColor = Color.FromArgb(80, 80, 100);
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            _player.settings.volume = (int)trackBarVolume.Value;
            lblVolume.Text = $"🔊 {(int)trackBarVolume.Value}%";
        }

        // Gradient arka plan çiz
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(
                ClientRectangle,
                Color.FromArgb(10, 10, 25),
                Color.FromArgb(40, 10, 60),
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _player?.controls.stop();
            base.OnFormClosing(e);
        }
    }
}
