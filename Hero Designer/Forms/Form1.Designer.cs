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
            this.ExitPanel = new midsControls.ctlPanel();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.MaximizeButton = new FontAwesome.Sharp.IconButton();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.SlidePanel = new midsControls.ctlPanel();
            this.BuildButton = new System.Windows.Forms.Button();
            this.LogoPanel = new midsControls.ctlPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPanel = new midsControls.ctlPanel();
            this.MenuGrip = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.BGImage)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.ExitPanel.SuspendLayout();
            this.SlidePanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSlideTimer
            // 
            this.menuSlideTimer.Interval = 10;
            this.menuSlideTimer.Tick += new System.EventHandler(this.MenuSlideTimer_Tick);
            // 
            // BGImage
            // 
            this.BGImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BGImage.BackgroundImage")));
            this.BGImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BGImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BGImage.Location = new System.Drawing.Point(0, 0);
            this.BGImage.Name = "BGImage";
            this.BGImage.Size = new System.Drawing.Size(1280, 720);
            this.BGImage.TabIndex = 0;
            this.BGImage.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TopPanel.Controls.Add(this.ExitPanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1280, 41);
            this.TopPanel.TabIndex = 1;
            // 
            // ExitPanel
            // 
            this.ExitPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitPanel.Controls.Add(this.MinimizeButton);
            this.ExitPanel.Controls.Add(this.MaximizeButton);
            this.ExitPanel.Controls.Add(this.CloseButton);
            this.ExitPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitPanel.Location = new System.Drawing.Point(1165, 0);
            this.ExitPanel.Name = "ExitPanel";
            this.ExitPanel.Size = new System.Drawing.Size(115, 41);
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
            this.MinimizeButton.Location = new System.Drawing.Point(25, 10);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Rotation = 0D;
            this.MinimizeButton.Size = new System.Drawing.Size(23, 23);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.ButtonMouse_Enter);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.ButtonMouse_Leave);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.MaximizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.MaximizeButton.IconColor = System.Drawing.Color.White;
            this.MaximizeButton.IconSize = 32;
            this.MaximizeButton.Location = new System.Drawing.Point(54, 10);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Rotation = 0D;
            this.MaximizeButton.Size = new System.Drawing.Size(23, 23);
            this.MaximizeButton.TabIndex = 1;
            this.MaximizeButton.UseVisualStyleBackColor = true;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            this.MaximizeButton.MouseEnter += new System.EventHandler(this.ButtonMouse_Enter);
            this.MaximizeButton.MouseLeave += new System.EventHandler(this.ButtonMouse_Leave);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.CloseButton.IconColor = System.Drawing.Color.White;
            this.CloseButton.IconSize = 32;
            this.CloseButton.Location = new System.Drawing.Point(83, 10);
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
            this.SlidePanel.Controls.Add(this.BuildButton);
            this.SlidePanel.Controls.Add(this.LogoPanel);
            this.SlidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidePanel.Location = new System.Drawing.Point(0, 41);
            this.SlidePanel.Name = "SlidePanel";
            this.SlidePanel.Size = new System.Drawing.Size(200, 679);
            this.SlidePanel.TabIndex = 2;
            // 
            // BuildButton
            // 
            this.BuildButton.BackColor = System.Drawing.Color.Transparent;
            this.BuildButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuildButton.FlatAppearance.BorderSize = 0;
            this.BuildButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuildButton.Font = new System.Drawing.Font("Noto Sans", 9.749999F, System.Drawing.FontStyle.Bold);
            this.BuildButton.ForeColor = System.Drawing.Color.White;
            this.BuildButton.Image = ((System.Drawing.Image)(resources.GetObject("BuildButton.Image")));
            this.BuildButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuildButton.Location = new System.Drawing.Point(0, 140);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(200, 60);
            this.BuildButton.TabIndex = 1;
            this.BuildButton.Text = "Build";
            this.BuildButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuildButton.UseVisualStyleBackColor = false;
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(200, 140);
            this.LogoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MainPanel.Controls.Add(this.MenuGrip);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(200, 41);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1080, 679);
            this.MainPanel.TabIndex = 3;
            // 
            // MenuGrip
            // 
            this.MenuGrip.BackColor = System.Drawing.Color.Transparent;
            this.MenuGrip.FlatAppearance.BorderSize = 0;
            this.MenuGrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuGrip.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.MenuGrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuGrip.IconChar = FontAwesome.Sharp.IconChar.GripLinesVertical;
            this.MenuGrip.IconColor = System.Drawing.Color.White;
            this.MenuGrip.IconSize = 48;
            this.MenuGrip.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MenuGrip.Location = new System.Drawing.Point(0, 340);
            this.MenuGrip.Name = "MenuGrip";
            this.MenuGrip.Rotation = 0D;
            this.MenuGrip.Size = new System.Drawing.Size(21, 48);
            this.MenuGrip.TabIndex = 0;
            this.MenuGrip.UseVisualStyleBackColor = false;
            this.MenuGrip.Click += new System.EventHandler(this.MenuGrip_Click);
            this.MenuGrip.MouseEnter += new System.EventHandler(this.MenuGrip_Enter);
            this.MenuGrip.MouseLeave += new System.EventHandler(this.MenuGrip_Leave);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
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
            this.ExitPanel.ResumeLayout(false);
            this.SlidePanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer menuSlideTimer;
        private PictureBox BGImage;
        private ctlPanel TopPanel;
        private ctlPanel ExitPanel;
        private ctlPanel SlidePanel;
        private Button BuildButton;
        private ctlPanel LogoPanel;
        private PictureBox pictureBox1;
        private ctlPanel MainPanel;
        private FontAwesome.Sharp.IconButton CloseButton;
        private FontAwesome.Sharp.IconButton MaximizeButton;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private FontAwesome.Sharp.IconButton MenuGrip;
    }
}