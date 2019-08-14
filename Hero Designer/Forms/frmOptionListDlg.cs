
using System;
using System.Windows.Forms;

namespace Hero_Designer
{
    public partial class frmOptionListDlg : Form
    {
        Button Cancel_Button;
        CheckBox chkRemember;
        ComboBox cmbAction;
        Label lblDescript;

        Button OK_Button;
        TableLayoutPanel TableLayoutPanel1;

        internal bool? remember => chkRemember?.Checked;

        public frmOptionListDlg()
        {
            InitializeComponent();
            Name = nameof(frmOptionListDlg);
        }

        void Cancel_Button_Click(object sender, EventArgs e)

        {
            chkRemember.Checked = false;
            DialogResult = DialogResult.OK;
            Close();
        }

        void OK_Button_Click(object sender, EventArgs e)

        {
            DialogResult = (DialogResult)(cmbAction.SelectedIndex + 2);
            Close();
        }

        public static (DialogResult, bool? remember) ShowWithOptions(
          bool AllowRemember,
          int DefaultOption,
          string descript,
          params string[] OptionList)
        {
            var frm = new frmOptionListDlg();
            frm.chkRemember.Enabled = AllowRemember;
            frm.chkRemember.Visible = AllowRemember;
            frm.chkRemember.Checked = false;
            frm.lblDescript.Text = descript;
            frm.cmbAction.Items.Clear();
            frm.cmbAction.Items.AddRange(OptionList);
            if (DefaultOption < frm.cmbAction.Items.Count - 1)
                frm.cmbAction.SelectedIndex = DefaultOption;
            else
                frm.cmbAction.SelectedIndex = 0;
            var result = frm.ShowDialog();
            return (result, frm.remember);
        }
    }
}