﻿using ScreenDimmer.Properties;
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
                Visible = true,
                Text = "ScreenDimmer - Save your eyes!"
            };
        }

        void Exit(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            trayIcon.Dispose();
            Application.Exit();
        }
    }
}
