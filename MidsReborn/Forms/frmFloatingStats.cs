using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Mids_Reborn.Forms
{
    public partial class frmFloatingStats : Form
    {
        private readonly FrmMain2 myOwner;

        public frmFloatingStats(FrmMain2 iOwner)
        {
            InitializeComponent();
            Load += frmFloatingStats_Load;
            Closed += frmFloatingStats_Closed;
            Name = nameof(frmFloatingStats);
            var componentResourceManager = new ComponentResourceManager(typeof(frmFloatingStats));
            Icon = Resources.reborn;
            myOwner = iOwner;
        }

        private void dvFloat_FloatChanged()
        {
            Close();
        }

        private void dvFloat_Load(object sender, EventArgs e)
        {
        }

        private void dvFloat_SizeChange(Size newSize, bool Compact)
        {
            ClientSize = newSize;
        }

        private void dvFloat_SlotFlip(int powerIndex)
        {
            myOwner.DataView_SlotFlip(powerIndex);
        }

        private void dvFloat_SlotUpdate()
        {
            myOwner.DataView_SlotUpdate();
        }

        private void dvFloat_TabChanged(int index)
        {
            myOwner.SetDataViewTab(index);
        }

        private void dvFloat_Unlock()
        {
            myOwner.UnlockFloatingStats();
        }

        private void frmFloatingStats_Closed(object sender, EventArgs e)
        {
            myOwner.ShowAnchoredDataView();
            Hide();
        }

        private void frmFloatingStats_Load(object sender, EventArgs e)
        {
            dvFloat.MoveDisable = true;
            dvFloat.SetScreenBounds(dvFloat.Bounds);
            dvFloat.SetLocation(dvFloat.Location, true);
        }
    }
}