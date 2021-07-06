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
                Text = "ScreenDimmer - Save your eyes!"
            };

            screens = Screen.AllScreens;
            dimForms = new List<DimForm>();
            EnableDimming();
        }

        void EnableDimming()
        {
            foreach(var screen in screens)
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
