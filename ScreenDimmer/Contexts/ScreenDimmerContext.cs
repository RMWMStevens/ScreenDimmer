using ScreenDimmer.Helpers;
using ScreenDimmer.Services;
using System;
using System.Windows.Forms;

namespace ScreenDimmer.Contexts
{
    public class ScreenDimmerContext : ApplicationContext
    {
        readonly TrayIconService trayService;
        readonly ScreenService screenService;

        public ScreenDimmerContext()
        {
            trayService = new TrayIconService();
            screenService = new ScreenService();

            trayService.SetContextMenu(Exit);
            trayService.SetMouseClickEvent(NotifyIcon_MouseClick);

            KeyInterceptionHelper.Set();
        }

        private void NotifyIcon_MouseClick(object sender, EventArgs e)
        {
            screenService.ToggleDimming();
        }

        void Exit(object sender, EventArgs e)
        {
            KeyInterceptionHelper.Unset();
            trayService.RemoveIconFromTray();
            Application.Exit();
        }
    }
}
