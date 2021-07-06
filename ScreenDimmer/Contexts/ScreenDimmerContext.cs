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
            trayIconService.TrayIcon.MouseClick += NotifyIcon_MouseClick;
            trayIconService.SetContextMenu(Exit);
        }

        private void NotifyIcon_MouseClick(object sender, EventArgs e)
        {
            screenService.ToggleDimming();
        }

        void Exit(object sender, EventArgs e)
        {
            trayIconService.TrayIcon.Visible = false;
            trayIconService.TrayIcon.Dispose();
            Application.Exit();
        }
    }
}
