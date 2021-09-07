using ScreenDimmer.Forms;
using ScreenDimmer.Models;

namespace ScreenDimmer.Services
{
    public class SettingsService
    {
        SettingsForm settingsForm;

        public SettingsService()
        {
            SettingsForm.Settings = new Settings
            {
                IgnorePrimary = true,
                IgnoreFullscreen = false,
            };
        }

        public void Show()
        {
            if (settingsForm != null) { settingsForm.Dispose(); }

            settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        public void Dispose()
        {
            settingsForm.Hide();
            settingsForm.Dispose();
        }
    }
}
