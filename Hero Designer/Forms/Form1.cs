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
using System.Windows.Forms.VisualStyles;
using Base;
using Base.Data_Classes;
using Base.Display;
using Base.Master_Classes;
using Hero_Designer.Forms;
using Hero_Designer.My;
using midsControls;

namespace Hero_Designer.Forms
{
    public partial class Form1 : Form
    {
        public string path = $"{Directory.GetParent(Assembly.GetExecutingAssembly().Location)}\\Images\\OriginAT";
        public List<string> Alignment = new List<string> {"Hero", "Vigilante", "Villain", "Rogue"};
        public List<Color> ListSelectionColor = new List<Color> { Color.DodgerBlue, Color.Goldenrod, Color.Red, Color.Silver };

        bool GetPlayableClasses(Archetype a) => a.Playable;
        private frmLoading _frmLoading;
        private bool loading;

        Lazy<ComboBoxT<Archetype>> CbtAT => new Lazy<ComboBoxT<Archetype>>(() => new ComboBoxT<Archetype>(cbAT));

        public Form1()
        {
            SetStyle(ControlStyles.DoubleBuffer|ControlStyles.AllPaintingInWmPaint, true);
            ConfigData.Initialize(MyApplication.GetSerializer());
            Load += Form1_OnLoad;
            InitializeComponent();
        }

        private void Form1_OnLoad(object sender, EventArgs eventArgs)
        {
            loading = true;
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
                loading = false;
                FillArchetypeCombo();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}\r\n\n{exception.StackTrace}");
            }
            loading = false;
            //FillOriginCombo();
            //FillPowerCombos();
        }

        private void FillOriginCombo()
        {
            var pathList = new List<string>
            {
                $"{path}\\Magic.png",
                $"{path}\\Mutation.png",
                $"{path}\\Natural.png",
                $"{path}\\Science.png",
                $"{path}\\Technology.png"
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
                $"{path}\\Class_Blaster.png",
                $"{path}\\Class_Controller.png",
                $"{path}\\Class_Defender.png",
                $"{path}\\Class_Scrapper.png",
                $"{path}\\Class_Tanker.png",
                $"{path}\\Class_Peacebringer.png",
                $"{path}\\Class_Warshade.png",
                $"{path}\\Class_Brute.png",
                $"{path}\\Class_Corruptor.png",
                $"{path}\\Class_Dominator.png",
                $"{path}\\Class_Mastermind.png",
                $"{path}\\Class_Sentinel.png",
                $"{path}\\Class_Stalker.png",
                $"{path}\\Class_Arachnos_Soldier.png",
                $"{path}\\Class_Arachnos_Widow.png"
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
                        cbAT.SelectedItem = MidsContext.Character.Archetype;
                    //else if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(cbAT.SelectedItem, null, "Idx", new object[0], null, (System.Type[])null, null), MidsContext.Character.Archetype.Idx, false))
                    else if (cbAT.SelectedItem.Idx != MidsContext.Character.Archetype.Idx)
                        cbAT.SelectedItem = MidsContext.Character.Archetype;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbAT.SelectedIndex;
            if (index < 0) return;
            var selText = cbAT.GetItemText(cbAT.SelectedItem);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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

        private void alignment_clicked(object sender, EventArgs e)
        {
            try
            {
                var cIndex = button1.ImageIndex;
                if (cIndex < button1.ImageList.Images.Count - 1)
                {
                    cIndex++;
                    button1.ImageIndex = cIndex;
                    button2.Text = $@"{Alignment[cIndex]}";
                    button2.ImageIndex = cIndex;
                    Text = $@"Mids` Reborn : {Alignment[cIndex]} Designer";
                    foreach (CheckBox checkBox in Controls.OfType<CheckBox>())
                    {
                        checkBox.ImageIndex = cIndex;
                    }

                    ctlPowerList1.SelectionColor = ListSelectionColor[cIndex];
                    ctlPowerList1.Invalidate();
                }

                else
                {
                    cIndex = 0;
                    button1.ImageIndex = cIndex;
                    button2.Text = $@"{Alignment[cIndex]}";
                    button2.ImageIndex = cIndex;
                    Text = $@"Mids` Reborn : {Alignment[cIndex]} Designer";
                    foreach (CheckBox checkBox in Controls.OfType<CheckBox>())
                    {
                        checkBox.ImageIndex = cIndex;
                    }
                    ctlPowerList1.SelectionColor = ListSelectionColor[cIndex];
                    ctlPowerList1.Invalidate();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}\r\n\n{exception.StackTrace}");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
