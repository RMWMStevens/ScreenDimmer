using ScreenDimmer.Forms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScreenDimmer.Services
{
    public class ScreenService
    {
        readonly Screen[] screens;
        readonly List<DimForm> dimForms;

        public ScreenService()
        {
            screens = Screen.AllScreens;
            dimForms = new List<DimForm>();
        }

        public void ToggleDimming()
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
    }
}
