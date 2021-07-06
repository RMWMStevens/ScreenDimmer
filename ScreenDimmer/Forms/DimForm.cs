using System.Drawing;
using System.Windows.Forms;

namespace ScreenDimmer.Forms
{
    public partial class DimForm : Form
    {
        public DimForm(Screen screen)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(screen.Bounds.X, screen.Bounds.Y);
            Size = new Size(screen.Bounds.Width, screen.Bounds.Height);
        }
    }
}
