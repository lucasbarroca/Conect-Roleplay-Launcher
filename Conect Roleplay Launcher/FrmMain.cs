using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;

namespace Conect_Roleplay_Launcher
{
    public partial class FrmMain : Form
    {
        private string LauncherUrl = "http://fivem.conectroleplay.com.br/launcher";

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // FrmMain
            FormClosing += FrmMain_FormClosing;
            MouseDown += FrmMain_MouseDown;

            // btClose
            btClose.MouseEnter += BtClose_MouseEnter;
            btClose.MouseLeave += BtClose_MouseLeave;
            btClose.MouseDown += BtClose_MouseDown;
            btClose.MouseUp += BtClose_MouseUp;
            btClose.Click += BtClose_Click;

            // btDiscord
            btDiscord.MouseEnter += btDiscord_MouseEnter;
            btDiscord.MouseLeave += btDiscord_MouseLeave;
            btDiscord.MouseDown += btDiscord_MouseDown;
            btDiscord.MouseUp += btDiscord_MouseUp;
            btDiscord.Click += BtDiscord_Click;

            // btFacebook
            btFacebook.MouseEnter += btFacebook_MouseEnter;
            btFacebook.MouseLeave += btFacebook_MouseLeave;
            btFacebook.MouseDown += btFacebook_MouseDown;
            btFacebook.MouseUp += btFacebook_MouseUp;
            btFacebook.Click += BtFacebook_Click;

            // btPlay
            btPlay.MouseEnter += btPlay_MouseEnter;
            btPlay.MouseLeave += btPlay_MouseLeave;
            btPlay.MouseDown += btPlay_MouseDown;
            btPlay.MouseUp += btPlay_MouseUp;
            btPlay.Click += BtPlay_Click;

            // Load news img
            try
            {
                pbNews.Load(LauncherUrl + "/launcher_news.png");
            }
            catch { pbNews.Image = null; }

            // Load news URL
            try
            {
                var webRequest = WebRequest.Create(LauncherUrl + "/launcher_url.txt");

                using (var response = webRequest.GetResponse())
                using (var content = response.GetResponseStream())
                using (var reader = new StreamReader(content))
                {
                    
                    NewsUrl = reader.ReadToEnd();
                    
                    if (NewsUrl.Trim().Length > 0)
                    {
                        pbNews.Cursor = Cursors.Hand;
                    }
                }
            }
            catch { }
        }

        private string NewsUrl = "";

        private void pbNews_Click(object sender, EventArgs e)
        {
            if (NewsUrl.Trim().Length > 0)
            {
                OpenUrl(NewsUrl);
            }
        }

        private void BtPlay_Click(object sender, EventArgs e)
        {
            OpenTeamSpeak();
            OpenFiveM();
            this.Close();
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtDiscord_Click(object sender, EventArgs e)
        {
            OpenDiscord();
        }

        private void BtFacebook_Click(object sender, EventArgs e)
        {
            OpenFacebook();
        }

        #region "Close Button"
        bool btClose_hovered = false;
        bool btClose_clicked = false;

        private void BtClose_MouseLeave(object sender, EventArgs e)
        {
            if (btClose_hovered)
            {
                btClose.Image = Properties.Resources.btClose;
                btClose_hovered = false;
            }
        }

        private void BtClose_MouseEnter(object sender, EventArgs e)
        {
            if (!btClose_hovered)
            {
                btClose.Image = Properties.Resources.btClose_h;
                btClose_hovered = true;
            }
        }

        private void BtClose_MouseDown(object sender, MouseEventArgs e)
        {
            if (!btClose_clicked)
            {
                btClose.Image = Properties.Resources.btClose_c;
                btClose_clicked = true;
            }
        }

        private void BtClose_MouseUp(object sender, MouseEventArgs e)
        {
            if (btClose_clicked)
            {
                btClose.Image = Properties.Resources.btClose;
                btClose_clicked = false;
            }
        }
        #endregion

        #region "Discord Button"
        bool btDiscord_hovered = false;
        bool btDiscord_clicked = false;

        private void btDiscord_MouseLeave(object sender, EventArgs e)
        {
            if (btDiscord_hovered)
            {
                btDiscord.Image = Properties.Resources.btDiscord;
                btDiscord_hovered = false;
            }
        }

        private void btDiscord_MouseEnter(object sender, EventArgs e)
        {
            if (!btDiscord_hovered)
            {
                btDiscord.Image = Properties.Resources.btDiscord_h;
                btDiscord_hovered = true;
            }
        }

        private void btDiscord_MouseDown(object sender, MouseEventArgs e)
        {
            if (!btDiscord_clicked)
            {
                btDiscord.Image = Properties.Resources.btDiscord_c;
                btDiscord_clicked = true;
            }
        }

        private void btDiscord_MouseUp(object sender, MouseEventArgs e)
        {
            if (btDiscord_clicked)
            {
                btDiscord.Image = Properties.Resources.btDiscord;
                btDiscord_clicked = false;
            }
        }
        #endregion

        #region "Facebook Button"
        bool btFacebook_hovered = false;
        bool btFacebook_clicked = false;

        private void btFacebook_MouseLeave(object sender, EventArgs e)
        {
            if (btFacebook_hovered)
            {
                btFacebook.Image = Properties.Resources.btFacebook;
                btFacebook_hovered = false;
            }
        }

        private void btFacebook_MouseEnter(object sender, EventArgs e)
        {
            if (!btFacebook_hovered)
            {
                btFacebook.Image = Properties.Resources.btFacebook_h;
                btFacebook_hovered = true;
            }
        }

        private void btFacebook_MouseDown(object sender, MouseEventArgs e)
        {
            if (!btFacebook_clicked)
            {
                btFacebook.Image = Properties.Resources.btFacebook_c;
                btFacebook_clicked = true;
            }
        }

        private void btFacebook_MouseUp(object sender, MouseEventArgs e)
        {
            if (btFacebook_clicked)
            {
                btFacebook.Image = Properties.Resources.btFacebook;
                btFacebook_clicked = false;
            }
        }
        #endregion

        #region "Play Button"
        bool btPlay_hovered = false;
        bool btPlay_clicked = false;

        private void btPlay_MouseLeave(object sender, EventArgs e)
        {
            if (btPlay_hovered)
            {
                btPlay.Image = Properties.Resources.btPlay;
                btPlay_hovered = false;
            }
        }

        private void btPlay_MouseEnter(object sender, EventArgs e)
        {
            if (!btPlay_hovered)
            {
                btPlay.Image = Properties.Resources.btPlay_h;
                btPlay_hovered = true;
            }
        }

        private void btPlay_MouseDown(object sender, MouseEventArgs e)
        {
            if (!btPlay_clicked)
            {
                btPlay.Image = Properties.Resources.btPlay_c;
                btPlay_clicked = true;
            }
        }

        private void btPlay_MouseUp(object sender, MouseEventArgs e)
        {
            if (btPlay_clicked)
            {
                btPlay.Image = Properties.Resources.btPlay;
                btPlay_clicked = false;
            }
        }
        #endregion

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void OpenFiveM()
        {
            Interaction.Shell("Explorer.exe fivem://connect/fivem.conectroleplay.com.br");
        }

        private void OpenTeamSpeak()
        {
            Interaction.Shell("Explorer.exe ts3server://ConectRoleplay.ts3games.top");
        }
        
        private void OpenDiscord()
        {
            OpenUrl("https://discord.gg/HjsatCg");
        }

        private void OpenFacebook()
        {
            OpenUrl("https://www.facebook.com/conectroleplay");
        }

        private void OpenUrl(string url)
        {
            Process.Start(url);
        }
    }
}
