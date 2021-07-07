using ScreenDimmer.Forms;
using System;

namespace ScreenDimmer.Services
{
    public class SettingsService
    {
        SettingsForm settingsForm;

        public void Show()
        {
            if (settingsForm == null) { settingsForm = new SettingsForm(); }

            settingsForm.Show();
        }

        public void Dispose()
        {
            settingsForm.Hide();
            settingsForm.Dispose();
        }
    }
}
