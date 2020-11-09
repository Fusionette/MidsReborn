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
        private readonly string _path = $"{Application.StartupPath}\\Images\\OriginAT";
        public List<string> Alignment = new List<string> { "Hero", "Vigilante", "Villain", "Rogue" };
        public List<Color> ListSelectionColor = new List<Color> { Color.DodgerBlue, Color.Goldenrod, Color.Red, Color.Silver };

        bool GetPlayableClasses(Archetype a) => a.Playable;
        private frmLoading _frmLoading;
        private bool Loading { get; set; }

        Lazy<ComboBoxT<Archetype>> CbtAT => new Lazy<ComboBoxT<Archetype>>(() => new ComboBoxT<Archetype>(cbAT));

        private readonly int _panelWidth;
        private bool PanelHidden { get; set; }
        public Form1()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint|ControlStyles.OptimizedDoubleBuffer|ControlStyles.ResizeRedraw, true);
            ConfigData.Initialize(MyApplication.GetSerializer());
            Load += Form1_Load;
            InitializeComponent();
            menuPanel.Width = 0;
            _panelWidth = 350;
            PanelHidden = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loading = true;
            try
            {
                if (MidsContext.Config.I9.DefaultIOLevel == 27)
                {
                    MidsContext.Config.I9.DefaultIOLevel = 49;
                }

                using frmLoading iFrm = new frmLoading();
                _frmLoading = iFrm;
                _frmLoading.Show();
                if (!this.IsInDesignMode() && !MidsContext.Config.IsInitialized)
                {
                    MidsContext.Config.CheckForUpdates = false;
                    MidsContext.Config.DefaultSaveFolderOverride = null;
                    MidsContext.Config.CreateDefaultSaveFolder();
                    MidsContext.Config.IsInitialized = true;
                }
                MainModule.MidsController.LoadData(ref _frmLoading);
                _frmLoading?.SetMessage("Setting up UI...");
                Show();
                _frmLoading.Hide();
                _frmLoading.Close();
                Refresh();
                Loading = false;
                FillArchetypeCombo();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}\r\n\n{exception.StackTrace}");
            }
            Loading = false;
        }

        private void MenuSlideTimer_Tick(object sender, EventArgs e)
        {
            if (PanelHidden)
            {
                menuPanel.Width += 10;
                MenuGrip.Left += 0;
                if (menuPanel.Width < _panelWidth) return;
                menuSlideTimer.Stop();
                PanelHidden = false;
                Refresh();
            }
            else
            {
                menuPanel.Width -= 10;
                MenuGrip.Left -= 0;
                if (menuPanel.Width > 0) return;
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
            //Add confirmation of save event?
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

        private void Fill_Combos()
        {
            //fill archetypes

        }
        private void FillOriginCombo()
        {
            var pathList = new List<string>
            {
                $"{_path}\\Magic.png",
                $"{_path}\\Mutation.png",
                $"{_path}\\Natural.png",
                $"{_path}\\Science.png",
                $"{_path}\\Technology.png"
            };
            ImageList imageList = new ImageList
            {
                ImageSize = new Size(16, 16)
            };
            foreach (var imgPath in pathList)
            {
                imageList.Images.Add(Image.FromFile(imgPath));
                //comboBox2.Items.Add(Path.GetFileNameWithoutExtension(imgPath));
                var imgOriginName = Path.GetFileNameWithoutExtension(imgPath);
                try
                {
                    var originIndex = DatabaseAPI.GetOriginIDByName(imgOriginName);
                    var origin = DatabaseAPI.Database.Origins[originIndex];
                    cbOrigin.Items.Add(origin.Name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}\r\n\n{ex.StackTrace}");
                }
            }
            cbOrigin.ImageList = imageList;
            cbOrigin.SelectedIndex = 0;
        }

        private void FillArchetypeCombo()
        {
            var cbAT = new ComboBoxT<Archetype>(this.cbAT);
            var pathList = new List<string>
            {
                $"{_path}\\Class_Blaster.png",
                $"{_path}\\Class_Controller.png",
                $"{_path}\\Class_Defender.png",
                $"{_path}\\Class_Scrapper.png",
                $"{_path}\\Class_Tanker.png",
                $"{_path}\\Class_Peacebringer.png",
                $"{_path}\\Class_Warshade.png",
                $"{_path}\\Class_Brute.png",
                $"{_path}\\Class_Corruptor.png",
                $"{_path}\\Class_Dominator.png",
                $"{_path}\\Class_Mastermind.png",
                $"{_path}\\Class_Sentinel.png",
                $"{_path}\\Class_Stalker.png",
                $"{_path}\\Class_Arachnos_Soldier.png",
                $"{_path}\\Class_Arachnos_Widow.png"
            };
            ImageList imageList = new ImageList
            {
                ImageSize = new Size(16, 16)
            };
            foreach (var imgPath in pathList)
            {
                imageList.Images.Add(Image.FromFile(imgPath));
                var imgAtName = Path.GetFileNameWithoutExtension(imgPath.Replace("Class_", "").Replace("_", " "));
                try
                {
                    Archetype[] all = Array.FindAll(DatabaseAPI.Database.Classes, GetPlayableClasses);
                    if (ComboCheckAT(all))
                    {
                        cbAT.BeginUpdate();
                        cbAT.Clear();
                        cbAT.AddRange(all);
                        cbAT.EndUpdate();
                    }

                    if (cbAT.SelectedItem == null)
                    {
                        cbAT.SelectedItem = MidsContext.Character.Archetype;
                    }
                    //else if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(cbAT.SelectedItem, null, "Idx", new object[0], null, (System.Type[])null, null), MidsContext.Character.Archetype.Idx, false))
                    else if (cbAT.SelectedItem.Idx != MidsContext.Character.Archetype.Idx)
                    {
                        cbAT.SelectedItem = MidsContext.Character.Archetype;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}\r\n\n{ex.StackTrace}");
                }
            }
            //cbAT.ImageList = imageList;
            //cbAT.SelectedIndex = 0;
        }

        bool ComboCheckAT(Archetype[] playableClasses)
        {
            var cbtAT = CbtAT.Value;
            if (cbtAT.Count != playableClasses.Length)
            {
                return true;
            }

            int num = playableClasses.Length - 1;
            for (int index = 0; index <= num; ++index)
            {
                if (cbtAT[index].Idx != playableClasses[index].Idx)
                    return true;
            }

            return false;
        }

        public void FillPowerCombos()
        {
            try
            {
                /*foreach (var set in DatabaseAPI.Database.Powersets)
                {
                    MessageBox.Show(set.DisplayName);
                }*/
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}\r\n\n{e.StackTrace}");
            }
        }

        private void cbAT_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbAT.SelectedIndex;
            if (index < 0) return;
            var selText = cbAT.GetItemText(cbAT.SelectedItem);
        }

        private void cbOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctlCombo comboBox = (ctlCombo)sender;
            var index = comboBox.SelectedIndex;
            if (index < 0) return;
            var selText = cbOrigin.GetItemText(cbOrigin.SelectedItem);
            if (selText != null)
            {
                MidsContext.Character.Archetype = DatabaseAPI.GetArchetypeByName(selText);
            }
        }
        /*private void Fill_Grids()
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
        }*/
    }
}
