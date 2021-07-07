using ScreenDimmer.Properties;
using System;
using System.Windows.Forms;

namespace ScreenDimmer.Services
{
    public class TrayIconService
    {
        readonly NotifyIcon trayIcon;

        public TrayIconService()
        {
            trayIcon = new NotifyIcon
            {
                Icon = Resources.ScreenDimmerTrayIcon,
                Visible = true,
                Text = "ScreenDimmer - Click to dim secondary screens",
            };
        }

        public void SetContextMenu(EventHandler settingsHandler, EventHandler exitHandler)
        {
            trayIcon.ContextMenu = new ContextMenu(new MenuItem[]
            {
                new MenuItem("Settings", settingsHandler),
                new MenuItem("Exit", exitHandler)
            });
        }

        public void SetMouseClickEvent(EventHandler clickHandler)
        {
            trayIcon.DoubleClick += clickHandler;
        }

        public void RemoveIconFromTray()
        {
            trayIcon.Visible = false;
            trayIcon.Dispose();
        }
    }
}
