﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using mrbBase;
using mrbBase.Base.Master_Classes;
using WK.Libraries.BetterFolderBrowserNS;

namespace Mids_Reborn.Forms.OptionsMenuItems.DbEditor
{
    public partial class frmDBConvert : Form
    {
        private FrmMain2 _myParent;
        private string SourcePath { get; set; }
        private string DestinationPath { get; set; }
        private List<string> SourceFiles { get; set; }
        private List<string> DestinationFiles { get; set; }


        public frmDBConvert(ref FrmMain2 iParent)
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
            Load += On_Load;
            InitializeComponent();
            _myParent = iParent;
            SourcePath = MidsContext.Config.SourceDataPath;
            DestinationPath = MidsContext.Config.ConversionDataPath;
            SourceFiles = new List<string>();
            DestinationFiles = new List<string>();
        }

        private void On_Load(object sender, EventArgs e)
        {
            Text = @"Database Converter";
            sourceFolder.Text = SourcePath;
            destinationFolder.Text = DestinationPath;
            CenterToParent();
        }

        private void srcBrowse_Click(object sender, EventArgs e)
        {
            using var sourceDialog = new BetterFolderBrowser
            {
                Multiselect = false,
                RootFolder = Path.Combine(Files.GetAssemblyLoc(), Files.RoamingFolder),
                Title = @"Select the source location of the database files you wish to convert"
            };
            if (sourceDialog.ShowDialog(this) == DialogResult.OK)
            {
                SourcePath = sourceDialog.SelectedPath;
                sourceFolder.Text = SourcePath;
                MidsContext.Config.SourceDataPath = SourcePath;
            }
        }

        private void destBrowse_Click(object sender, EventArgs e)
        {
            using var destinationDialog = new BetterFolderBrowser
            {
                Multiselect = false,
                RootFolder = Path.Combine(Files.GetAssemblyLoc(), Files.RoamingFolder),
                Title = @"Select the destination for the new database files"
            };
            if (destinationDialog.ShowDialog(this) == DialogResult.OK)
            {
                DestinationPath = destinationDialog.SelectedPath;
                destinationFolder.Text = DestinationPath;
                MidsContext.Config.ConversionDataPath = DestinationPath;
            }
        }

        private async void convertBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SourcePath) && !string.IsNullOrWhiteSpace(DestinationPath))
            {
                await ConvertDatabase();
            }
        }

        private async void ResetData(string path)
        {
            DatabaseAPI.LoadDatabaseVersion(path);
            DatabaseAPI.Database.AttribMods = new Modifiers();
            if (!DatabaseAPI.Database.AttribMods.Load(path)) { }

            if (!DatabaseAPI.LoadLevelsDatabase(path))
            {
                MessageBox.Show(@"Unable to proceed, failed to load leveling data! We suggest you re-download the application from https://github.com/LoadedCamel/MidsReborn/releases.", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            if (!DatabaseAPI.LoadMainDatabase(path))
            {
                MessageBox.Show(@"There was an error reading the database. Aborting!", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            if (!DatabaseAPI.LoadMaths(path))
            {
                Application.Exit();
            }

            if (!DatabaseAPI.LoadEffectIdsDatabase(path))
            {
                Application.Exit();
            }

            if (!DatabaseAPI.LoadEnhancementClasses(path))
            {
                Application.Exit();
            }

            DatabaseAPI.LoadEnhancementDb(path);
            DatabaseAPI.LoadOrigins(path);
            DatabaseAPI.LoadSetTypeStrings(path);

            DatabaseAPI.LoadSalvage(path);
            DatabaseAPI.LoadRecipes(path);
            var taskArray = new Task[9];
            taskArray[0] = Task.Run(I9Gfx.LoadOriginImages);
            taskArray[1] = Task.Run(I9Gfx.LoadArchetypeImages);
            taskArray[2] = Task.Run(I9Gfx.LoadPowersetImages);
            taskArray[3] = Task.Run(I9Gfx.LoadEnhancements);
            taskArray[4] = Task.Run(I9Gfx.LoadSets);
            taskArray[5] = Task.Run(I9Gfx.LoadBorders);
            taskArray[6] = Task.Run(I9Gfx.LoadSetTypes);
            taskArray[7] = Task.Run(I9Gfx.LoadEnhTypes);
            taskArray[8] = Task.Run(I9Gfx.LoadClasses);
            Task.WaitAll(taskArray);

            MidsContext.Config.Export.LoadCodes(Files.SelectDataFileLoad(Files.MxdbFileBbCodeUpdate, path));
            DatabaseAPI.MatchAllIDs();
            DatabaseAPI.AssignSetBonusIndexes();
            DatabaseAPI.AssignRecipeIDs();
            await Task.Delay(1000);
            statusText.Items.Add("Conversion complete. You can now select your database from the configuration options.");
        }

        private async Task ConvertDatabase()
        {
            SourceFiles = Directory.GetFiles(SourcePath, "*.mhd").ToList();
            var filePath = SourcePath;
            statusText.Items.Add("Initializing Source Data...");
            await Task.Delay(500);
            statusText.Items.Add("Initialization complete.");
            statusText.TopIndex = statusText.Items.Count - 1;
            await Task.Delay(500);
            statusText.Items.Add("Begin loading data from source for conversion...");
            statusText.TopIndex = statusText.Items.Count - 1;
            await Task.Delay(500);
            Console.WriteLine(filePath);
            statusText.Items.Add("Loading attribute modifier data...");
            statusText.TopIndex = statusText.Items.Count - 1;
            DatabaseAPI.Database.AttribMods = new Modifiers();
            if (DatabaseAPI.Database.AttribMods.Load(filePath)){ }

            await Task.Delay(500);
            statusText.Items.Add("Loading leveling data...");
            statusText.TopIndex = statusText.Items.Count - 1;
            if (DatabaseAPI.LoadLevelsDatabase(Files.FDefaultPath)) { }

            await Task.Delay(500);
            statusText.Items.Add("Loading data from main database...");
            statusText.TopIndex = statusText.Items.Count - 1;
            if (DatabaseAPI.LoadMainDatabase(filePath, true)) { }
            if (DatabaseAPI.LoadMaths(filePath)) { }

            await Task.Delay(500);
            statusText.Items.Add("Loading data from enhancement database...");
            statusText.TopIndex = statusText.Items.Count - 1;
            if (DatabaseAPI.LoadEnhancementClasses(filePath)) { }
            DatabaseAPI.LoadEnhancementDb(filePath, true);
            DatabaseAPI.LoadOrigins(filePath);
            DatabaseAPI.LoadSetTypeStrings(filePath);

            await Task.Delay(500);
            statusText.Items.Add("Loading salvage data...");
            DatabaseAPI.LoadSalvage(filePath);
            await Task.Delay(500);
            statusText.Items.Add("Loading recipe data...");
            DatabaseAPI.LoadRecipes(filePath, true);

            var taskArray = new Task[9];
            taskArray[0] = Task.Run(I9Gfx.LoadOriginImages);
            taskArray[1] = Task.Run(I9Gfx.LoadArchetypeImages);
            taskArray[2] = Task.Run(I9Gfx.LoadPowersetImages);
            taskArray[3] = Task.Run(I9Gfx.LoadEnhancements);
            taskArray[4] = Task.Run(I9Gfx.LoadSets);
            taskArray[5] = Task.Run(I9Gfx.LoadBorders);
            taskArray[6] = Task.Run(I9Gfx.LoadSetTypes);
            taskArray[7] = Task.Run(I9Gfx.LoadEnhTypes);
            taskArray[8] = Task.Run(I9Gfx.LoadClasses);
            Task.WaitAll(taskArray);

            await Task.Delay(500);
            statusText.Items.Add("Loading codes data...");
            MidsContext.Config.Export.LoadCodes(Files.SelectDataFileLoad(Files.MxdbFileBbCodeUpdate, filePath));
            DatabaseAPI.MatchAllIDs();
            DatabaseAPI.AssignSetBonusIndexes();
            DatabaseAPI.AssignRecipeIDs();
            statusText.Items.Add("Finished loading data from source.");
            statusText.TopIndex = statusText.Items.Count - 1;
            await Task.Delay(1500);
            statusText.Items.Clear();
            statusText.Items.Add("Starting conversion process...");
            await Task.Delay(500);
            foreach (var power in DatabaseAPI.Database.Power) power.BaseRechargeTime = power.RechargeTime;
            Array.Sort(DatabaseAPI.Database.Power);
            var serializer = Serializer.GetSerializer();
            statusText.Items.Add("Assigning static indexes...");
            DatabaseAPI.AssignStaticIndexValues(serializer, false);
            DatabaseAPI.MatchAllIDs();
            await Task.Delay(500);
            statusText.Items.Add("Converting data from main database...");
            DatabaseAPI.SaveMainDatabase(serializer, MidsContext.Config.ConversionDataPath);
            await Task.Delay(500);
            statusText.Items.Add("Replicating data from non-conversion items...");
            File.Copy(Files.SelectDataFileLoad(Files.MxdbFileEClasses, MidsContext.Config.SourceDataPath), Files.SelectDataFileSave(Files.MxdbFileEClasses, MidsContext.Config.ConversionDataPath), true);
            File.Copy(Files.SelectDataFileLoad(Files.MxdbFileOrigins, MidsContext.Config.SourceDataPath), Files.SelectDataFileSave(Files.MxdbFileOrigins, MidsContext.Config.ConversionDataPath), true);
            File.Copy(Files.SelectDataFileLoad(Files.MxdbFileOverrides, MidsContext.Config.SourceDataPath), Files.SelectDataFileSave(Files.MxdbFileOverrides, MidsContext.Config.ConversionDataPath), true);
            File.Copy(Files.SelectDataFileLoad(Files.MxdbFileMaths, MidsContext.Config.SourceDataPath), Files.SelectDataFileSave(Files.MxdbFileMaths, MidsContext.Config.ConversionDataPath), true);
            File.Copy(Files.SelectDataFileLoad(Files.MxdbFileSetTypes, MidsContext.Config.SourceDataPath), Files.SelectDataFileSave(Files.MxdbFileSetTypes, MidsContext.Config.ConversionDataPath), true);
            File.Copy(Files.SelectDataFileLoad(Files.MxdbFileGraphics, MidsContext.Config.SourceDataPath), Files.SelectDataFileSave(Files.MxdbFileGraphics, MidsContext.Config.ConversionDataPath), true);
            File.Copy(Files.SelectDataFileLoad(Files.MxdbFileNLevels, Files.FDefaultPath), Files.SelectDataFileSave(Files.MxdbFileNLevels, MidsContext.Config.ConversionDataPath), true);
            File.Copy(Files.SelectDataFileLoad(Files.MxdbFileRLevels, Files.FDefaultPath), Files.SelectDataFileSave(Files.MxdbFileRLevels, MidsContext.Config.ConversionDataPath), true);
            await Task.Delay(500);
            statusText.Items.Add("Converting data from attribute modifiers...");
            DatabaseAPI.Database.AttribMods?.Store(serializer, MidsContext.Config.ConversionDataPath);
            await Task.Delay(500);
            statusText.Items.Add("Generating global modifiers...");
            DatabaseAPI.SaveEffectIdsDatabase(MidsContext.Config.ConversionDataPath);
            await Task.Delay(500);
            statusText.Items.Add("Converting salvage data...");
            DatabaseAPI.AssignRecipeIDs();
            DatabaseAPI.SaveSalvage(serializer, MidsContext.Config.ConversionDataPath);
            await Task.Delay(500);
            statusText.Items.Add("Converting recipe data...");
            DatabaseAPI.SaveRecipes(serializer, MidsContext.Config.ConversionDataPath);
            await Task.Delay(500);
            statusText.Items.Add("Converting data from enhancement database...");
            DatabaseAPI.SaveEnhancementDb(serializer, MidsContext.Config.ConversionDataPath);
            await Task.Delay(500);
            statusText.Items.Add("Performing final cleanup...");
            await Task.Delay(500);
            ResetData(MidsContext.Config.DataPath);
        }
    }
}
