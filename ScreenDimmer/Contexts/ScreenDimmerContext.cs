using ScreenDimmer.Services;
using System;
using System.Windows.Forms;

namespace ScreenDimmer.Contexts
{
    public class ScreenDimmerContext : ApplicationContext
    {
        readonly TrayIconService trayService;
        readonly ScreenService screenService;
        readonly HotKeyService hotkeyService;

        public ScreenDimmerContext()
        {
            trayService = new TrayIconService();
            screenService = new ScreenService();
            (hotkeyService = new HotKeyService()).Register();

            trayService.SetContextMenu(Exit);
            trayService.SetMouseClickEvent(NotifyIconClicked);

            hotkeyService.HotKeyPressed += HotKeyPressed;
        }

        private void HotKeyPressed(object sender, EventArgs e)
        {
            Console.WriteLine("Key combination has been pressed");
            screenService.ToggleDimming();
        }

        private void NotifyIconClicked(object sender, EventArgs e)
        {
            screenService.ToggleDimming();
        }

        void Exit(object sender, EventArgs e)
        {
            hotkeyService.Unregister();
            trayService.RemoveIconFromTray();
            Application.Exit();
        }
    }
}
