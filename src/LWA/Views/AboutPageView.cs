﻿using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LoveWindowsAgain
{
    public partial class AboutPageView : UserControl
    {
        public AboutPageView()
        {
            InitializeComponent();
            SetStyle();
        }

        // Some UI nicety
        private void SetStyle()
        {
            BackColor =
            _lblAppName.BackColor =
            _lblAssembly.BackColor =
            _lblWith.BackColor =
            _lblHeartFillEmoji.BackColor =
            _lblDev.BackColor =
              Color.FromArgb(245, 241, 249);

            btnBack.Text = "\uE72B";
            _lblAssembly.Text = "LowaApp-Version " + Program.GetCurrentVersionTostring();
            _lblHeartFillEmoji.Text = "\uEB52";
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<MainForm>().Single();
            mainForm.pnlForm.Controls.Clear();
            if (mainForm.INavPage != null) mainForm.pnlForm.Controls.Add(mainForm.INavPage);
        }

        private void lblAppMediaGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => Process.Start(HelperTool.Utils.Uri.URL_GITREPO);

        private void lblAppMediaTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => Process.Start(HelperTool.Utils.Uri.URL_TWITTER);

        private void lblAppMediaPayPal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => Process.Start(HelperTool.Utils.Uri.URL_DONATE);

        private void btnAppMediaTweetIntent_Click(object sender, System.EventArgs e)
             => Process.Start(HelperTool.Utils.TweetIntent);
    }
}