﻿using ScreenDimmer.Contexts;
using System;
using System.Windows.Forms;

namespace ScreenDimmer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ScreenDimmerContext());
        }
    }
}
