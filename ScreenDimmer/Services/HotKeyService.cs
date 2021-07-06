using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ScreenDimmer.Services
{
    public class HotKeyService : Form /* Credit: https://stackoverflow.com/questions/15413172/capture-a-keyboard-keypress-in-the-background */
    {
        int hotKeyId = 1;

        public event EventHandler HotKeyPressed;

        public void Register()
        {
            // Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            // Compute the addition of each combination of the keys you want to be pressed
            // ALT+CTRL = 1 + 2 = 3 , CTRL+SHIFT = 2 + 4 = 6...
            RegisterHotKey(this.Handle, hotKeyId, 6, (int)Keys.F12);
        }

        public void Unregister()
        {
            UnregisterHotKey(this.Handle, hotKeyId);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == hotKeyId)
            {
                // Hotkey triggered
                this.HotKeyPressed(this, null);
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
