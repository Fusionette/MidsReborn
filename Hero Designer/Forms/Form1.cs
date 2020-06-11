using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.VisualStyles;
using Base;
using Base.Data_Classes;
using Base.Display;
using Base.Master_Classes;
using FontAwesome.Sharp;
using Hero_Designer.Forms;
using Hero_Designer.My;
using midsControls;

namespace Hero_Designer.Forms
{
    public partial class Form1 : Form
    {
        private readonly int _panelWidth;
        private bool PanelHidden { get; set; }
        public Form1()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint|ControlStyles.OptimizedDoubleBuffer|ControlStyles.ResizeRedraw, true);
            InitializeComponent();
            SlidePanel.Width = 50;
            _panelWidth = 50;
            PanelHidden = true;
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Fill_Grids();
        }

        private void MenuSlideTimer_Tick(object sender, EventArgs e)
        {
            if (PanelHidden)
            {
                SlidePanel.Width += 10;
                MenuGrip.Left += 0;
                if (SlidePanel.Width < _panelWidth) return;
                menuSlideTimer.Stop();
                PanelHidden = false;
                Refresh();
            }
            else
            {
                SlidePanel.Width -= 10;
                MenuGrip.Left -= 0;
                if (SlidePanel.Width > 0) return;
                menuSlideTimer.Stop();
                PanelHidden = true;
                Refresh();
            }
        }

        private void ButtonMouse_Enter(object sender, EventArgs e)
        {
            IconButton ib = (IconButton) sender;
            ib.IconColor = Color.DodgerBlue;
            ib.FlatAppearance.MouseOverBackColor = Color.FromArgb(170,0,0,0);
            ib.FlatAppearance.MouseDownBackColor = Color.FromArgb(170, 0, 0, 0);
        }

        private void ButtonMouse_Leave(object sender, EventArgs e)
        {
            IconButton ib = (IconButton)sender;
            ib.IconColor = Color.White;
            ib.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 0, 0, 0);
            ib.FlatAppearance.MouseDownBackColor = Color.FromArgb(170, 0, 0, 0);
        }

        private void MenuGrip_Enter(object sender, EventArgs e)
        {
            IconButton ib = (IconButton)sender;
            ib.IconColor = Color.DodgerBlue;
            ib.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ib.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void MenuGrip_Leave(object sender, EventArgs e)
        {
            IconButton ib = (IconButton)sender;
            ib.IconColor = Color.White;
            ib.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ib.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            switch (WindowState)
            {
                case FormWindowState.Normal:
                    WindowState = FormWindowState.Maximized;
                    break;
                case FormWindowState.Maximized:
                    WindowState = FormWindowState.Normal;
                    break;
                case FormWindowState.Minimized:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MenuGrip_Click(object sender, EventArgs e)
        {
            menuSlideTimer.Start();
        }

        private int _movX;
        private int _movY;
        private bool _isMoving;

        private void Move_OnMouseDown(object sender, MouseEventArgs e)
        {
            // Assign this method to mouse_Down event of Form or Panel,whatever you want
            _isMoving = true;
            _movX = e.X;
            _movY = e.Y;
        }

        private void Move_OnMouseMove(object sender, MouseEventArgs e)
        {
            // Assign this method to Mouse_Move event of that Form or Panel
            if (_isMoving)
            {
                this.SetDesktopLocation(MousePosition.X - _movX, MousePosition.Y - _movY);
            }
        }

        private void Move_OnMouseUp(object sender, MouseEventArgs e)
        {
            // Assign this method to Mouse_Up event of Form or Panel.
            _isMoving = false;
        }

        private void PowerButton_PaintSlot(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using Pen pen = new Pen(Color.White, 1);
            //Rectangle rectangle = new Rectangle(point, 20, 30, 30);
            //g.DrawEllipse(pen, rectangle);
        }

        private void Fill_Grids()
        {
            var powerCol = 4;
            var powerRow = 6;
            var inherentRow = 8;
            PowerTable.ColumnStyles.Clear();
            PowerTable.RowStyles.Clear();
            //PowerTable.AutoSize = true;
            PowerTable.BackColor = Color.Transparent;
            PowerTable.Padding = new Padding(0,10, 0,10);
            for (var column = 0; column < powerCol; column++)
            {
                PowerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / powerCol));
                for (var row = 0; row < powerRow; row++)
                {
                    PowerTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 52.5f));
                    PowerTable.SuspendLayout();
                    PowerTable.Controls.Add(new Button {Image = new Bitmap("Images\\pslot2.png"), FlatStyle = FlatStyle.Flat, FlatAppearance = { BorderSize = 0, MouseOverBackColor = Color.Transparent, MouseDownBackColor = Color.Transparent}, Size = new Size(190,32), BackColor = Color.Transparent}, column, row);
                    PowerTable.ResumeLayout();
                }
            }

            InherentTable.ColumnStyles.Clear();
            InherentTable.RowStyles.Clear();
            //InherentTable.AutoSize = true;
            InherentTable.BackColor = Color.Transparent;
            InherentTable.Padding = new Padding(0, 10, 0, 10);
            for (var column = 0; column < powerCol; column++)
            {
                InherentTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / powerCol));
                for (var row = 0; row < inherentRow; row++)
                {
                    InherentTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 52.5f));
                    InherentTable.SuspendLayout();
                    InherentTable.Controls.Add(new Button { Image = new Bitmap("Images\\pslot2.png"), FlatStyle = FlatStyle.Flat, FlatAppearance = { BorderSize = 0, MouseOverBackColor = Color.Transparent, MouseDownBackColor = Color.Transparent }, Size = new Size(190, 32), BackColor = Color.Transparent }, column, row);
                    InherentTable.ResumeLayout();
                }
            }
        }
    }
}
