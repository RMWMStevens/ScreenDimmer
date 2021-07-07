using ScreenDimmer.Services;
using System;
using System.Windows.Forms;

namespace ScreenDimmer.Contexts
{
    public class ScreenDimmerContext : ApplicationContext
    {
        readonly TrayIconService trayService;
        readonly DimService dimService;
        readonly HotKeyService hotkeyService;
        readonly SettingsService settingsService;

        public ScreenDimmerContext()
        {
            trayService = new TrayIconService();
            dimService = new DimService();
            (hotkeyService = new HotKeyService()).Register();
            settingsService = new SettingsService();

            trayService.SetContextMenu(ShowSettings, Exit);
            trayService.SetMouseClickEvent(TrayIconClicked);

            hotkeyService.HotKeyPressed += HotKeyPressed;
        }

        private void HotKeyPressed(object sender, EventArgs e)
        {
            dimService.Toggle();
        }

        private void TrayIconClicked(object sender, EventArgs e)
        {
            dimService.Toggle();
        }

        private void ShowSettings(object sender, EventArgs e)
        {
            settingsService.Show();
        }

        void Exit(object sender, EventArgs e)
        {
            settingsService.Dispose();
            hotkeyService.Unregister();
            trayService.RemoveIconFromTray();
            Application.Exit();
        }
    }
}
