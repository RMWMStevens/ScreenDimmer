using ScreenDimmer.Properties;
using System;
using System.Windows.Forms;

namespace ScreenDimmer.Services
{
    public class TrayIconService
    {
        readonly NotifyIcon trayIcon;
        public NotifyIcon TrayIcon { get { return trayIcon; } }

        public TrayIconService()
        {
            trayIcon = new NotifyIcon
            {
                Icon = Resources.ScreenDimmerTrayIcon,
                Visible = true,
                Text = "ScreenDimmer - Click to dim secondary screens",
            };
        }

        public void SetContextMenu(EventHandler exitHandler)
        {
            trayIcon.ContextMenu = new ContextMenu(new MenuItem[]
            {
                new MenuItem("Exit", exitHandler)
            });
        }
    }
}
