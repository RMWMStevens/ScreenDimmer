using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ScreenDimmer.Services
{
    /* 
        Credit for capturing key presses: 
        https://stackoverflow.com/questions/15413172/capture-a-keyboard-keypress-in-the-background
    */
    public class HotKeyService : Form
    {
        const int hotKeyId = 1;

        public event EventHandler HotKeyPressedEvent;

        public void Register(Keys keys = Keys.Decimal)
        {
            RegisterHotKey(
                Handle,
                hotKeyId,
                hotKeyId * 2,
                (int)keys);
        }

        public void Unregister()
        {
            UnregisterHotKey(this.Handle, hotKeyId);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == 1)
            {
                // Hotkey triggered
                HotKeyPressedEvent(this, null);
            }
            base.WndProc(ref m);
        }

        #region DllImport
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        #endregion DLL
    }
}
