using System.Drawing;
using System.Windows.Forms;

namespace ScreenDimmer.Forms
{
    public partial class DimForm : Form
    {
        /* 
            Credit hiding ScreenDimmer windows from Alt-Tab:
            https://github.com/zingmars/ScreenBlank
        */
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        public DimForm(Screen screen)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(screen.Bounds.X, screen.Bounds.Y);
            Size = new Size(screen.Bounds.Width, screen.Bounds.Height);
            ShowInTaskbar = false;
        }
    }
}
