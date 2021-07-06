using ScreenDimmer.Forms;
using ScreenDimmer.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScreenDimmer.Contexts
{
    public class ScreenDimmerContext : ApplicationContext
    {
        readonly NotifyIcon trayIcon;
        readonly Screen[] screens;
        readonly List<DimForm> dimForms;

        public ScreenDimmerContext()
        {
            trayIcon = new NotifyIcon
            {
                Icon = Resources.ScreenDimmerTrayIcon,
                ContextMenu = new ContextMenu(new MenuItem[] {
                    new MenuItem("Exit", Exit)
                }),
                Visible = true,
                Text = "ScreenDimmer - Save your eyes!",
            };
            trayIcon.MouseClick += trayIcon_MouseClick;

            screens = Screen.AllScreens;
            dimForms = new List<DimForm>();
        }

        private void trayIcon_MouseClick(object sender, EventArgs e)
        {
            ToggleDimming();
        }

        void ToggleDimming()
        {
            if (dimForms.Count > 0) { DisableDimming(); }
            else { EnableDimming(); }
        }

        void EnableDimming()
        {
            foreach (var screen in screens)
            {
                if (screen.Primary) { continue; }
                var dimForm = new DimForm(screen);
                dimForm.Show();
                dimForms.Add(dimForm);
            }
        }

        void DisableDimming()
        {
            foreach (var dimForm in dimForms)
            {
                dimForm.Close();
            }
            dimForms.Clear();
        }

        void Exit(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            trayIcon.Dispose();
            Application.Exit();
        }
    }
}
