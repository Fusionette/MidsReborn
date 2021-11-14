namespace Mids_Reborn.UIv2.v2Controls
{
    partial class PowerListCombo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctlCombo1 = new mrbControls.ctlCombo();
            this.ctlPowerList1 = new mrbControls.ctlPowerList();
            this.ctlOutlinedLabel1 = new mrbControls.ctlOutlinedLabel();
            this.SuspendLayout();
            // 
            // ctlCombo1
            // 
            this.ctlCombo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlCombo1.BackColor = System.Drawing.Color.White;
            this.ctlCombo1.ComboType = mrbControls.ctlCombo.ComboBoxType.Archetype;
            this.ctlCombo1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ctlCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlCombo1.FormattingEnabled = true;
            this.ctlCombo1.HighlightColor = System.Drawing.Color.Empty;
            this.ctlCombo1.Location = new System.Drawing.Point(3, 25);
            this.ctlCombo1.Name = "ctlCombo1";
            this.ctlCombo1.Size = new System.Drawing.Size(144, 21);
            this.ctlCombo1.TabIndex = 0;
            // 
            // ctlPowerList1
            // 
            this.ctlPowerList1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlPowerList1.BackColor = System.Drawing.Color.Transparent;
            this.ctlPowerList1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctlPowerList1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ctlPowerList1.FormattingEnabled = true;
            this.ctlPowerList1.Location = new System.Drawing.Point(3, 52);
            this.ctlPowerList1.Name = "ctlPowerList1";
            this.ctlPowerList1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.ctlPowerList1.SelectionColor = System.Drawing.Color.Empty;
            this.ctlPowerList1.Size = new System.Drawing.Size(144, 91);
            this.ctlPowerList1.TabIndex = 1;
            // 
            // ctlOutlinedLabel1
            // 
            this.ctlOutlinedLabel1.AutoSize = true;
            this.ctlOutlinedLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ctlOutlinedLabel1.ForeColor = System.Drawing.Color.White;
            this.ctlOutlinedLabel1.Location = new System.Drawing.Point(3, 9);
            this.ctlOutlinedLabel1.Name = "ctlOutlinedLabel1";
            this.ctlOutlinedLabel1.OutlineForeColor = System.Drawing.Color.Black;
            this.ctlOutlinedLabel1.OutlineWidth = 2F;
            this.ctlOutlinedLabel1.Size = new System.Drawing.Size(89, 13);
            this.ctlOutlinedLabel1.TabIndex = 2;
            this.ctlOutlinedLabel1.Text = "ctlOutlinedLabel1";
            this.ctlOutlinedLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PowerListCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctlOutlinedLabel1);
            this.Controls.Add(this.ctlPowerList1);
            this.Controls.Add(this.ctlCombo1);
            this.Name = "PowerListCombo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mrbControls.ctlCombo ctlCombo1;
        private mrbControls.ctlPowerList ctlPowerList1;
        private mrbControls.ctlOutlinedLabel ctlOutlinedLabel1;
    }
}
