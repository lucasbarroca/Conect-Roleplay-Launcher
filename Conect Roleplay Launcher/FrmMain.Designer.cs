namespace Conect_Roleplay_Launcher
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btClose = new System.Windows.Forms.PictureBox();
            this.btPlay = new System.Windows.Forms.PictureBox();
            this.btDiscord = new System.Windows.Forms.PictureBox();
            this.btFacebook = new System.Windows.Forms.PictureBox();
            this.pbNews = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDiscord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNews)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-15, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.Image = global::Conect_Roleplay_Launcher.Properties.Resources.btClose;
            this.btClose.Location = new System.Drawing.Point(805, 73);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(33, 33);
            this.btClose.TabIndex = 5;
            this.btClose.TabStop = false;
            // 
            // btPlay
            // 
            this.btPlay.BackColor = System.Drawing.Color.Transparent;
            this.btPlay.Image = global::Conect_Roleplay_Launcher.Properties.Resources.btPlay;
            this.btPlay.Location = new System.Drawing.Point(347, 491);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(240, 70);
            this.btPlay.TabIndex = 6;
            this.btPlay.TabStop = false;
            // 
            // btDiscord
            // 
            this.btDiscord.BackColor = System.Drawing.Color.Transparent;
            this.btDiscord.Image = global::Conect_Roleplay_Launcher.Properties.Resources.btDiscord;
            this.btDiscord.Location = new System.Drawing.Point(73, 141);
            this.btDiscord.Name = "btDiscord";
            this.btDiscord.Size = new System.Drawing.Size(50, 50);
            this.btDiscord.TabIndex = 7;
            this.btDiscord.TabStop = false;
            // 
            // btFacebook
            // 
            this.btFacebook.BackColor = System.Drawing.Color.Transparent;
            this.btFacebook.Image = global::Conect_Roleplay_Launcher.Properties.Resources.btFacebook;
            this.btFacebook.Location = new System.Drawing.Point(139, 141);
            this.btFacebook.Name = "btFacebook";
            this.btFacebook.Size = new System.Drawing.Size(50, 50);
            this.btFacebook.TabIndex = 8;
            this.btFacebook.TabStop = false;
            // 
            // pbNews
            // 
            this.pbNews.BackColor = System.Drawing.Color.Transparent;
            this.pbNews.BackgroundImage = global::Conect_Roleplay_Launcher.Properties.Resources.launcher_news_template;
            this.pbNews.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbNews.Location = new System.Drawing.Point(449, 156);
            this.pbNews.Name = "pbNews";
            this.pbNews.Size = new System.Drawing.Size(360, 225);
            this.pbNews.TabIndex = 9;
            this.pbNews.TabStop = false;
            this.pbNews.Click += new System.EventHandler(this.pbNews_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(217)))));
            this.BackgroundImage = global::Conect_Roleplay_Launcher.Properties.Resources.launcher;
            this.ClientSize = new System.Drawing.Size(898, 586);
            this.Controls.Add(this.pbNews);
            this.Controls.Add(this.btFacebook);
            this.Controls.Add(this.btDiscord);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::Conect_Roleplay_Launcher.Properties.Resources.icon;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conect Roleplay Launcher";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(217)))));
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDiscord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNews)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btClose;
        private System.Windows.Forms.PictureBox btPlay;
        private System.Windows.Forms.PictureBox btDiscord;
        private System.Windows.Forms.PictureBox btFacebook;
        private System.Windows.Forms.PictureBox pbNews;
    }
}

