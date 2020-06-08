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
            SlidePanel.Width = 0;
            _panelWidth = 200;
            PanelHidden = true;
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
    }
}
