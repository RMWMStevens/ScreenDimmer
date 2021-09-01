using ScreenDimmer.Models;
using System;
using System.Windows.Forms;

namespace ScreenDimmer.Forms
{
    public partial class SettingsForm : Form
    {
        public static Settings Settings { get; set; }

        public SettingsForm()
        {
            InitializeComponent();

            IgnorePrimaryCb.Checked = Settings.IgnorePrimary;
            IgnoreFullscreenCb.Checked = Settings.IgnoreFullscreen;
        }

        private void IgnorePrimaryCb_CheckedChanged(object sender, EventArgs e)
        {
            Settings.IgnorePrimary = IgnorePrimaryCb.Checked;
        }

        private void IgnoreFullscreenCb_CheckedChanged(object sender, EventArgs e)
        {
            Settings.IgnoreFullscreen = IgnoreFullscreenCb.Checked;
        }
    }
}
