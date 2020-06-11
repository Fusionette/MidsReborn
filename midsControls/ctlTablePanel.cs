using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midsControls
{
    public partial class ctlTablePanel : TableLayoutPanel
    {
        public ctlTablePanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint|ControlStyles.OptimizedDoubleBuffer|ControlStyles.ResizeRedraw|ControlStyles.ContainerControl,true);
            InitializeComponent();
        }
    }
}
