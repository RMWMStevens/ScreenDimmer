using ScreenDimmer.Forms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScreenDimmer.Services
{
    public class DimService
    {
        readonly Screen[] screens;
        readonly List<DimForm> dimForms;

        public DimService()
        {
            screens = Screen.AllScreens;
            dimForms = new List<DimForm>();
        }

        public void Toggle()
        {
            if (dimForms.Count > 0) { Disable(); }
            else { Enable(); }
        }

        void Enable()
        {
            foreach (var screen in screens)
            {
                if (SettingsForm.Settings.IgnorePrimary && screen.Primary) { continue; }

                var dimForm = new DimForm(screen);
                dimForm.Show();
                dimForms.Add(dimForm);
            }
        }

        void Disable()
        {
            foreach (var dimForm in dimForms)
            {
                dimForm.Close();
            }
            dimForms.Clear();
        }
    }
}
