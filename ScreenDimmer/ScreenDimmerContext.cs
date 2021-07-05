using ScreenDimmer.Properties;
using System;
using System.Windows.Forms;

namespace ScreenDimmer
{
    public class ScreenDimmerContext : ApplicationContext
    {
        private readonly NotifyIcon trayIcon;

        public ScreenDimmerContext()
        {
            trayIcon = new NotifyIcon
            {
                Icon = Resources.ScreenDimmerTrayIcon,
                ContextMenu = new ContextMenu(new MenuItem[] {
                    new MenuItem("Exit", Exit)
                }),
                Visible = true
            };
        }

        void Exit(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Application.Exit();
        }
    }
}
