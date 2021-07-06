using ScreenDimmer.Services;
using System;
using System.Windows.Forms;

namespace ScreenDimmer.Contexts
{
    public class ScreenDimmerContext : ApplicationContext
    {
        readonly TrayIconService trayIconService;
        readonly ScreenService screenService;

        public ScreenDimmerContext()
        {
            trayIconService = new TrayIconService();
            screenService = new ScreenService();

            trayIconService.SetContextMenu(Exit);
            trayIconService.SetMouseClickEvent(NotifyIcon_MouseClick);
        }

        private void NotifyIcon_MouseClick(object sender, EventArgs e)
        {
            screenService.ToggleDimming();
        }

        void Exit(object sender, EventArgs e)
        {
            trayIconService.RemoveIconFromTray();
            Application.Exit();
        }
    }
}
