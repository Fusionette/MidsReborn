using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using midsControls;

namespace Hero_Designer.Forms
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuSlideTimer = new System.Windows.Forms.Timer(this.components);
            this.BGImage = new System.Windows.Forms.PictureBox();
            this.TopPanel = new midsControls.ctlPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ExitPanel = new midsControls.ctlPanel();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.SlidePanel = new midsControls.ctlPanel();
            this.MenuGrip = new FontAwesome.Sharp.IconButton();
            this.MainPanel = new midsControls.ctlPanel();
            this.ctlPowerList2 = new midsControls.ctlPowerList();
            this.ctlPowerList1 = new midsControls.ctlPowerList();
            this.ctlCombo4 = new midsControls.ctlCombo();
            this.label6 = new System.Windows.Forms.Label();
            this.ctlCombo3 = new midsControls.ctlCombo();
            this.label5 = new System.Windows.Forms.Label();
            this.ctlCombo2 = new midsControls.ctlCombo();
            this.label4 = new System.Windows.Forms.Label();
            this.ctlCombo1 = new midsControls.ctlCombo();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ctlPanel2 = new midsControls.ctlPanel();
            this.InherentTable = new midsControls.ctlTablePanel();
            this.ctlPanel1 = new midsControls.ctlPanel();
            this.PowerTable = new midsControls.ctlTablePanel();
            this.label7 = new System.Windows.Forms.Label();
            this.ctlCombo5 = new midsControls.ctlCombo();
            this.ctlPowerList3 = new midsControls.ctlPowerList();
            this.label8 = new System.Windows.Forms.Label();
            this.ctlCombo6 = new midsControls.ctlCombo();
            this.ctlPowerList4 = new midsControls.ctlPowerList();
            this.label9 = new System.Windows.Forms.Label();
            this.ctlCombo7 = new midsControls.ctlCombo();
            this.ctlPowerList5 = new midsControls.ctlPowerList();
            this.label10 = new System.Windows.Forms.Label();
            this.ctlCombo8 = new midsControls.ctlCombo();
            this.ctlPowerList6 = new midsControls.ctlPowerList();
            this.label11 = new System.Windows.Forms.Label();
            this.ctlCombo9 = new midsControls.ctlCombo();
            this.ctlPowerList7 = new midsControls.ctlPowerList();
            ((System.ComponentModel.ISupportInitialize)(this.BGImage)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.ExitPanel.SuspendLayout();
            this.SlidePanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ctlPanel2.SuspendLayout();
            this.ctlPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSlideTimer
            // 
            this.menuSlideTimer.Interval = 1;
            this.menuSlideTimer.Tick += new System.EventHandler(this.MenuSlideTimer_Tick);
            // 
            // BGImage
            // 
            this.BGImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BGImage.BackgroundImage")));
            this.BGImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BGImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BGImage.Location = new System.Drawing.Point(0, 0);
            this.BGImage.Name = "BGImage";
            this.BGImage.Size = new System.Drawing.Size(1375, 850);
            this.BGImage.TabIndex = 0;
            this.BGImage.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.button1);
            this.TopPanel.Controls.Add(this.ExitPanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1375, 41);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_OnMouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_OnMouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_OnMouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(47, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mids Reborn : Hero Designer";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Hero_Designer.Resources.reborn_wicon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(9, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ExitPanel
            // 
            this.ExitPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitPanel.Controls.Add(this.MinimizeButton);
            this.ExitPanel.Controls.Add(this.CloseButton);
            this.ExitPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitPanel.Location = new System.Drawing.Point(1312, 0);
            this.ExitPanel.Name = "ExitPanel";
            this.ExitPanel.Size = new System.Drawing.Size(63, 41);
            this.ExitPanel.TabIndex = 0;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeButton.IconColor = System.Drawing.Color.White;
            this.MinimizeButton.IconSize = 32;
            this.MinimizeButton.Location = new System.Drawing.Point(3, 10);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Rotation = 0D;
            this.MinimizeButton.Size = new System.Drawing.Size(23, 23);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.ButtonMouse_Enter);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.ButtonMouse_Leave);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.CloseButton.IconColor = System.Drawing.Color.White;
            this.CloseButton.IconSize = 32;
            this.CloseButton.Location = new System.Drawing.Point(32, 10);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Rotation = 0D;
            this.CloseButton.Size = new System.Drawing.Size(23, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.ButtonMouse_Enter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.ButtonMouse_Leave);
            // 
            // SlidePanel
            // 
            this.SlidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SlidePanel.Controls.Add(this.MenuGrip);
            this.SlidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidePanel.Location = new System.Drawing.Point(0, 41);
            this.SlidePanel.Name = "SlidePanel";
            this.SlidePanel.Size = new System.Drawing.Size(50, 809);
            this.SlidePanel.TabIndex = 2;
            // 
            // MenuGrip
            // 
            this.MenuGrip.BackColor = System.Drawing.Color.Transparent;
            this.MenuGrip.FlatAppearance.BorderSize = 0;
            this.MenuGrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuGrip.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.MenuGrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuGrip.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.MenuGrip.IconColor = System.Drawing.Color.White;
            this.MenuGrip.IconSize = 32;
            this.MenuGrip.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuGrip.Location = new System.Drawing.Point(9, 6);
            this.MenuGrip.Name = "MenuGrip";
            this.MenuGrip.Rotation = 0D;
            this.MenuGrip.Size = new System.Drawing.Size(35, 38);
            this.MenuGrip.TabIndex = 0;
            this.MenuGrip.UseVisualStyleBackColor = false;
            this.MenuGrip.Click += new System.EventHandler(this.MenuGrip_Click);
            this.MenuGrip.MouseEnter += new System.EventHandler(this.MenuGrip_Enter);
            this.MenuGrip.MouseLeave += new System.EventHandler(this.MenuGrip_Leave);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MainPanel.Controls.Add(this.ctlPowerList7);
            this.MainPanel.Controls.Add(this.ctlCombo9);
            this.MainPanel.Controls.Add(this.label11);
            this.MainPanel.Controls.Add(this.ctlPowerList6);
            this.MainPanel.Controls.Add(this.ctlCombo8);
            this.MainPanel.Controls.Add(this.label10);
            this.MainPanel.Controls.Add(this.ctlPowerList5);
            this.MainPanel.Controls.Add(this.ctlCombo7);
            this.MainPanel.Controls.Add(this.label9);
            this.MainPanel.Controls.Add(this.ctlPowerList4);
            this.MainPanel.Controls.Add(this.ctlCombo6);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Controls.Add(this.ctlPowerList3);
            this.MainPanel.Controls.Add(this.ctlCombo5);
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.ctlPowerList2);
            this.MainPanel.Controls.Add(this.ctlPowerList1);
            this.MainPanel.Controls.Add(this.ctlCombo4);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.ctlCombo3);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.ctlCombo2);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.ctlCombo1);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.textBox1);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.pictureBox2);
            this.MainPanel.Controls.Add(this.ctlPanel2);
            this.MainPanel.Controls.Add(this.ctlPanel1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(50, 41);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1325, 809);
            this.MainPanel.TabIndex = 3;
            // 
            // ctlPowerList2
            // 
            this.ctlPowerList2.BackColor = System.Drawing.Color.Transparent;
            this.ctlPowerList2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctlPowerList2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ctlPowerList2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlPowerList2.ForeColor = System.Drawing.Color.White;
            this.ctlPowerList2.FormattingEnabled = true;
            this.ctlPowerList2.Items.AddRange(new object[] {
            "Sec Power 1",
            "Sec Power 2",
            "Sec Power 3",
            "Sec Power 4",
            "Sec Power 5",
            "Sec Power 6",
            "Sec Power 7",
            "Sec Power 8",
            "Sec Power 9"});
            this.ctlPowerList2.Location = new System.Drawing.Point(194, 171);
            this.ctlPowerList2.Name = "ctlPowerList2";
            this.ctlPowerList2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.ctlPowerList2.SelectionColor = System.Drawing.Color.Empty;
            this.ctlPowerList2.Size = new System.Drawing.Size(160, 117);
            this.ctlPowerList2.TabIndex = 18;
            // 
            // ctlPowerList1
            // 
            this.ctlPowerList1.BackColor = System.Drawing.Color.Transparent;
            this.ctlPowerList1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctlPowerList1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ctlPowerList1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlPowerList1.ForeColor = System.Drawing.Color.White;
            this.ctlPowerList1.FormattingEnabled = true;
            this.ctlPowerList1.Items.AddRange(new object[] {
            "Pri Power 1",
            "Pri Power 2",
            "Pri Power 3",
            "Pri Power 4",
            "Pri Power 5",
            "Pri Power 6",
            "Pri Power 7",
            "Pri Power 8",
            "Pri Power 9"});
            this.ctlPowerList1.Location = new System.Drawing.Point(10, 171);
            this.ctlPowerList1.Name = "ctlPowerList1";
            this.ctlPowerList1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.ctlPowerList1.SelectionColor = System.Drawing.Color.Empty;
            this.ctlPowerList1.Size = new System.Drawing.Size(160, 130);
            this.ctlPowerList1.TabIndex = 17;
            // 
            // ctlCombo4
            // 
            this.ctlCombo4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ctlCombo4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlCombo4.FormattingEnabled = true;
            this.ctlCombo4.ImageList = null;
            this.ctlCombo4.Location = new System.Drawing.Point(194, 142);
            this.ctlCombo4.Name = "ctlCombo4";
            this.ctlCombo4.Size = new System.Drawing.Size(160, 23);
            this.ctlCombo4.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(209, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Secondary Power Set";
            // 
            // ctlCombo3
            // 
            this.ctlCombo3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ctlCombo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlCombo3.FormattingEnabled = true;
            this.ctlCombo3.ImageList = null;
            this.ctlCombo3.Location = new System.Drawing.Point(10, 142);
            this.ctlCombo3.Name = "ctlCombo3";
            this.ctlCombo3.Size = new System.Drawing.Size(160, 23);
            this.ctlCombo3.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Primary Power Set";
            // 
            // ctlCombo2
            // 
            this.ctlCombo2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ctlCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlCombo2.FormattingEnabled = true;
            this.ctlCombo2.ImageList = null;
            this.ctlCombo2.Location = new System.Drawing.Point(109, 72);
            this.ctlCombo2.Name = "ctlCombo2";
            this.ctlCombo2.Size = new System.Drawing.Size(177, 23);
            this.ctlCombo2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Origin:";
            // 
            // ctlCombo1
            // 
            this.ctlCombo1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ctlCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlCombo1.FormattingEnabled = true;
            this.ctlCombo1.ImageList = null;
            this.ctlCombo1.Location = new System.Drawing.Point(109, 42);
            this.ctlCombo1.Name = "ctlCombo1";
            this.ctlCombo1.Size = new System.Drawing.Size(177, 23);
            this.ctlCombo1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Archetype:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(535, 331);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(780, 5);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // ctlPanel2
            // 
            this.ctlPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ctlPanel2.Controls.Add(this.InherentTable);
            this.ctlPanel2.Location = new System.Drawing.Point(535, 342);
            this.ctlPanel2.Name = "ctlPanel2";
            this.ctlPanel2.Size = new System.Drawing.Size(778, 455);
            this.ctlPanel2.TabIndex = 4;
            // 
            // InherentTable
            // 
            this.InherentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InherentTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InherentTable.Location = new System.Drawing.Point(0, 0);
            this.InherentTable.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.InherentTable.Name = "InherentTable";
            this.InherentTable.Size = new System.Drawing.Size(778, 455);
            this.InherentTable.TabIndex = 2;
            // 
            // ctlPanel1
            // 
            this.ctlPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ctlPanel1.Controls.Add(this.PowerTable);
            this.ctlPanel1.Location = new System.Drawing.Point(535, 6);
            this.ctlPanel1.Name = "ctlPanel1";
            this.ctlPanel1.Size = new System.Drawing.Size(778, 319);
            this.ctlPanel1.TabIndex = 3;
            // 
            // PowerTable
            // 
            this.PowerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PowerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PowerTable.Location = new System.Drawing.Point(0, 0);
            this.PowerTable.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.PowerTable.Name = "PowerTable";
            this.PowerTable.Size = new System.Drawing.Size(778, 319);
            this.PowerTable.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(434, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Pool 1";
            // 
            // ctlCombo5
            // 
            this.ctlCombo5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ctlCombo5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlCombo5.FormattingEnabled = true;
            this.ctlCombo5.ImageList = null;
            this.ctlCombo5.Location = new System.Drawing.Point(383, 142);
            this.ctlCombo5.Name = "ctlCombo5";
            this.ctlCombo5.Size = new System.Drawing.Size(146, 23);
            this.ctlCombo5.TabIndex = 20;
            // 
            // ctlPowerList3
            // 
            this.ctlPowerList3.BackColor = System.Drawing.Color.Transparent;
            this.ctlPowerList3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctlPowerList3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ctlPowerList3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlPowerList3.ForeColor = System.Drawing.Color.White;
            this.ctlPowerList3.FormattingEnabled = true;
            this.ctlPowerList3.Items.AddRange(new object[] {
            "Pool Power 1",
            "Pool Power 2",
            "Pool Power 3",
            "Pool Power 4",
            "Pool Power 5"});
            this.ctlPowerList3.Location = new System.Drawing.Point(383, 171);
            this.ctlPowerList3.Name = "ctlPowerList3";
            this.ctlPowerList3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.ctlPowerList3.SelectionColor = System.Drawing.Color.Empty;
            this.ctlPowerList3.Size = new System.Drawing.Size(146, 78);
            this.ctlPowerList3.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(434, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Pool 2";
            // 
            // ctlCombo6
            // 
            this.ctlCombo6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ctlCombo6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlCombo6.FormattingEnabled = true;
            this.ctlCombo6.ImageList = null;
            this.ctlCombo6.Location = new System.Drawing.Point(383, 268);
            this.ctlCombo6.Name = "ctlCombo6";
            this.ctlCombo6.Size = new System.Drawing.Size(146, 23);
            this.ctlCombo6.TabIndex = 23;
            // 
            // ctlPowerList4
            // 
            this.ctlPowerList4.BackColor = System.Drawing.Color.Transparent;
            this.ctlPowerList4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctlPowerList4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ctlPowerList4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlPowerList4.ForeColor = System.Drawing.Color.White;
            this.ctlPowerList4.FormattingEnabled = true;
            this.ctlPowerList4.Items.AddRange(new object[] {
            "Pool Power 1",
            "Pool Power 2",
            "Pool Power 3",
            "Pool Power 4",
            "Pool Power 5"});
            this.ctlPowerList4.Location = new System.Drawing.Point(383, 297);
            this.ctlPowerList4.Name = "ctlPowerList4";
            this.ctlPowerList4.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.ctlPowerList4.SelectionColor = System.Drawing.Color.Empty;
            this.ctlPowerList4.Size = new System.Drawing.Size(146, 78);
            this.ctlPowerList4.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(434, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Pool 3";
            // 
            // ctlCombo7
            // 
            this.ctlCombo7.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ctlCombo7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlCombo7.FormattingEnabled = true;
            this.ctlCombo7.ImageList = null;
            this.ctlCombo7.Location = new System.Drawing.Point(383, 394);
            this.ctlCombo7.Name = "ctlCombo7";
            this.ctlCombo7.Size = new System.Drawing.Size(146, 23);
            this.ctlCombo7.TabIndex = 26;
            // 
            // ctlPowerList5
            // 
            this.ctlPowerList5.BackColor = System.Drawing.Color.Transparent;
            this.ctlPowerList5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctlPowerList5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ctlPowerList5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlPowerList5.ForeColor = System.Drawing.Color.White;
            this.ctlPowerList5.FormattingEnabled = true;
            this.ctlPowerList5.Items.AddRange(new object[] {
            "Pool Power 1",
            "Pool Power 2",
            "Pool Power 3",
            "Pool Power 4",
            "Pool Power 5"});
            this.ctlPowerList5.Location = new System.Drawing.Point(383, 423);
            this.ctlPowerList5.Name = "ctlPowerList5";
            this.ctlPowerList5.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.ctlPowerList5.SelectionColor = System.Drawing.Color.Empty;
            this.ctlPowerList5.Size = new System.Drawing.Size(146, 78);
            this.ctlPowerList5.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(434, 504);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Pool 4";
            // 
            // ctlCombo8
            // 
            this.ctlCombo8.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ctlCombo8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlCombo8.FormattingEnabled = true;
            this.ctlCombo8.ImageList = null;
            this.ctlCombo8.Location = new System.Drawing.Point(383, 520);
            this.ctlCombo8.Name = "ctlCombo8";
            this.ctlCombo8.Size = new System.Drawing.Size(146, 23);
            this.ctlCombo8.TabIndex = 29;
            // 
            // ctlPowerList6
            // 
            this.ctlPowerList6.BackColor = System.Drawing.Color.Transparent;
            this.ctlPowerList6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctlPowerList6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ctlPowerList6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlPowerList6.ForeColor = System.Drawing.Color.White;
            this.ctlPowerList6.FormattingEnabled = true;
            this.ctlPowerList6.Items.AddRange(new object[] {
            "Pool Power 1",
            "Pool Power 2",
            "Pool Power 3",
            "Pool Power 4",
            "Pool Power 5"});
            this.ctlPowerList6.Location = new System.Drawing.Point(383, 549);
            this.ctlPowerList6.Name = "ctlPowerList6";
            this.ctlPowerList6.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.ctlPowerList6.SelectionColor = System.Drawing.Color.Empty;
            this.ctlPowerList6.Size = new System.Drawing.Size(146, 78);
            this.ctlPowerList6.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(425, 630);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Epic Pool";
            // 
            // ctlCombo9
            // 
            this.ctlCombo9.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ctlCombo9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlCombo9.FormattingEnabled = true;
            this.ctlCombo9.ImageList = null;
            this.ctlCombo9.Location = new System.Drawing.Point(383, 646);
            this.ctlCombo9.Name = "ctlCombo9";
            this.ctlCombo9.Size = new System.Drawing.Size(146, 23);
            this.ctlCombo9.TabIndex = 32;
            // 
            // ctlPowerList7
            // 
            this.ctlPowerList7.BackColor = System.Drawing.Color.Transparent;
            this.ctlPowerList7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctlPowerList7.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ctlPowerList7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlPowerList7.ForeColor = System.Drawing.Color.White;
            this.ctlPowerList7.FormattingEnabled = true;
            this.ctlPowerList7.Items.AddRange(new object[] {
            "Pool Power 1",
            "Pool Power 2",
            "Pool Power 3",
            "Pool Power 4",
            "Pool Power 5"});
            this.ctlPowerList7.Location = new System.Drawing.Point(383, 675);
            this.ctlPowerList7.Name = "ctlPowerList7";
            this.ctlPowerList7.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.ctlPowerList7.SelectionColor = System.Drawing.Color.Empty;
            this.ctlPowerList7.Size = new System.Drawing.Size(146, 78);
            this.ctlPowerList7.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1375, 850);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SlidePanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BGImage);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mids` Reborn : Hero Designer";
            ((System.ComponentModel.ISupportInitialize)(this.BGImage)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ExitPanel.ResumeLayout(false);
            this.SlidePanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ctlPanel2.ResumeLayout(false);
            this.ctlPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer menuSlideTimer;
        private PictureBox BGImage;
        private ctlPanel TopPanel;
        private ctlPanel ExitPanel;
        private ctlPanel SlidePanel;
        private ctlPanel MainPanel;
        private FontAwesome.Sharp.IconButton CloseButton;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private FontAwesome.Sharp.IconButton MenuGrip;
        private ctlTablePanel InherentTable;
        private ctlTablePanel PowerTable;
        private ctlPanel ctlPanel1;
        private ctlPanel ctlPanel2;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ctlCombo ctlCombo1;
        private Label label3;
        private ctlCombo ctlCombo2;
        private Label label4;
        private ctlCombo ctlCombo4;
        private Label label6;
        private ctlCombo ctlCombo3;
        private Label label5;
        private ctlPowerList ctlPowerList2;
        private ctlPowerList ctlPowerList1;
        private Label label9;
        private ctlPowerList ctlPowerList4;
        private ctlCombo ctlCombo6;
        private Label label8;
        private ctlPowerList ctlPowerList3;
        private ctlCombo ctlCombo5;
        private Label label7;
        private ctlPowerList ctlPowerList6;
        private ctlCombo ctlCombo8;
        private Label label10;
        private ctlPowerList ctlPowerList5;
        private ctlCombo ctlCombo7;
        private ctlPowerList ctlPowerList7;
        private ctlCombo ctlCombo9;
        private Label label11;
    }
}