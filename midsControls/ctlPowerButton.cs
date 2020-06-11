using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midsControls
{
    public partial class ctlPowerButton : UserControl
    {
        public ctlPowerButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint|ControlStyles.OptimizedDoubleBuffer|ControlStyles.ResizeRedraw, true);
            InitializeComponent();
            Load += ctlPowerButton_Load;
        }

        private void ctlPowerButton_Load(object sender, EventArgs e)
        {
            PowerButton.MouseEnter += PowerButton_MouseEnter;
            PowerButton.MouseLeave += PowerButton_MouseLeave;
        }

        private void PowerButton_MouseEnter(object sender, EventArgs e)
        {
            PowerButton.ImageIndex = 1;
        }

        private void PowerButton_MouseLeave(object sender, EventArgs e)
        {
            PowerButton.ImageIndex = 0;
        }
    }
}
