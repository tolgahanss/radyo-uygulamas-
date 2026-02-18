namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblVolumeIcon = new System.Windows.Forms.Label();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();

            // ── Form ──────────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 340);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.BackColor = System.Drawing.Color.FromArgb(10, 10, 25);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panelControls);

            // ── lblTitle ──────────────────────────────────────────────────────
            this.lblTitle.AutoSize = false;
            this.lblTitle.Location = new System.Drawing.Point(0, 28);
            this.lblTitle.Size = new System.Drawing.Size(520, 52);
            this.lblTitle.Text = "🎤 TÜRKÇE RAP RADYO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;

            // ── lblSubtitle ───────────────────────────────────────────────────
            this.lblSubtitle.AutoSize = false;
            this.lblSubtitle.Location = new System.Drawing.Point(0, 82);
            this.lblSubtitle.Size = new System.Drawing.Size(520, 26);
            this.lblSubtitle.Text = "";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(160, 140, 200);
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;

            // ── lblStatus ─────────────────────────────────────────────────────
            this.lblStatus.AutoSize = false;
            this.lblStatus.Location = new System.Drawing.Point(0, 112);
            this.lblStatus.Size = new System.Drawing.Size(520, 30);
            this.lblStatus.Text = "⏸  Durduruldu";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(180, 180, 200);
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;

            // ── panelControls ─────────────────────────────────────────────────
            this.panelControls.Location = new System.Drawing.Point(60, 158);
            this.panelControls.Size = new System.Drawing.Size(400, 148);
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(30, 255, 255, 255);
            this.panelControls.Controls.Add(this.btnPlayPause);
            this.panelControls.Controls.Add(this.btnStop);
            this.panelControls.Controls.Add(this.lblVolumeIcon);
            this.panelControls.Controls.Add(this.trackBarVolume);
            this.panelControls.Controls.Add(this.lblVolume);

            // ── btnPlayPause ──────────────────────────────────────────────────
            this.btnPlayPause.Location = new System.Drawing.Point(90, 18);
            this.btnPlayPause.Size = new System.Drawing.Size(90, 90);
            this.btnPlayPause.Text = "▶";
            this.btnPlayPause.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.btnPlayPause.ForeColor = System.Drawing.Color.White;
            this.btnPlayPause.BackColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.FlatAppearance.BorderSize = 0;
            this.btnPlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);

            // ── btnStop ───────────────────────────────────────────────────────
            this.btnStop.Location = new System.Drawing.Point(220, 18);
            this.btnStop.Size = new System.Drawing.Size(90, 90);
            this.btnStop.Text = "⏹";
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(60, 60, 80);
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);

            // ── lblVolumeIcon ─────────────────────────────────────────────────
            this.lblVolumeIcon.AutoSize = true;
            this.lblVolumeIcon.Location = new System.Drawing.Point(8, 118);
            this.lblVolumeIcon.Text = "🔊";
            this.lblVolumeIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblVolumeIcon.ForeColor = System.Drawing.Color.White;
            this.lblVolumeIcon.BackColor = System.Drawing.Color.Transparent;

            // ── trackBarVolume ────────────────────────────────────────────────
            this.trackBarVolume.Location = new System.Drawing.Point(38, 114);
            this.trackBarVolume.Size = new System.Drawing.Size(270, 30);
            this.trackBarVolume.Minimum = 0;
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Value = 70;
            this.trackBarVolume.TickFrequency = 10;
            this.trackBarVolume.BackColor = System.Drawing.Color.FromArgb(20, 20, 40);
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);

            // ── lblVolume ─────────────────────────────────────────────────────
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(316, 118);
            this.lblVolume.Text = "🔊 70%";
            this.lblVolume.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVolume.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.lblVolume.BackColor = System.Drawing.Color.Transparent;

            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblVolumeIcon;
    }
}
