using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mids_Reborn.UIv2.v2Controls
{
    public partial class PowerListBox : ListBox
    {
        public PowerListBox()
        {
            InitializeComponent();
        }

        // Scrollbars
        private const int WM_KILLFOCUS = 0x8;
        private const int WM_VSCROLL = 0x115;
        private const int WM_HSCROLL = 0x114;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg != WM_KILLFOCUS &&
                (m.Msg == WM_HSCROLL || m.Msg == WM_VSCROLL))
                Invalidate();
            base.WndProc(ref m);
        }
    }
}
