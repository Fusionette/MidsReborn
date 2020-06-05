using System;
using System.Drawing;
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator0 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsImport = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExportLong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExportDataLink = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsExportDiscord = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsUpdateCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLevelUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDynamic = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.AdvancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAdvDBEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.SlotsEnhancementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetAllIOsToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsIODefault = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsIOMin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsIOMax = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.SetAllEnhOriginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEnhToSO = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEnhToDO = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEnhToTO = new System.Windows.Forms.ToolStripMenuItem();
            this.SetAllRelativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEnhToPlus5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEnhToPlus4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEnhToPlus3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEnhToPlus2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEnhToPlus1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEnhToEven = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEnhToMinus1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEnhToMinus2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEnhToMinus3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEnhToNone = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.SlotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFlipAllEnh = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tsClearAllEnh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRemoveAllSlots = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAutoArrangeAllSlots = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsView2Col = new System.Windows.Forms.ToolStripMenuItem();
            this.tsView3Col = new System.Windows.Forms.ToolStripMenuItem();
            this.tsView4Col = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.tsViewIOLevels = new System.Windows.Forms.ToolStripMenuItem();
            this.tsViewRelative = new System.Windows.Forms.ToolStripMenuItem();
            this.tsViewSlotLevels = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.tsViewActualDamage_New = new System.Windows.Forms.ToolStripMenuItem();
            this.tsViewDPS_New = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsDPA = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsViewSets = new System.Windows.Forms.ToolStripMenuItem();
            this.tsViewGraphs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsViewSetCompare = new System.Windows.Forms.ToolStripMenuItem();
            this.tsViewData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsViewTotals = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.tsRecipeViewer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDPSCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSetFind = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.InGameRespecHelperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHelperShort = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHelperLong = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.tsHelperShort2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHelperLong2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAccoladesWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsIncarnateWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTemporaryPowersWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBugCrytilis = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHCMRBForum = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.tsKoFi = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.tsPatreon = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.tsGitHubCrytilis = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAdvFreshInstall = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAdvResetTips = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator24 = new System.Windows.Forms.ToolStripSeparator();
            this.lblHero = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.ctlPowerList1 = new midsControls.ctlPowerList();
            this.cbOrigin = new midsControls.ctlCombo();
            this.cbAT = new midsControls.ctlCombo();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctlCombo1 = new midsControls.ctlCombo();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ImportExportToolStripMenuItem,
            this.OptionsToolStripMenuItem,
            this.SlotsEnhancementsToolStripMenuItem,
            this.ViewToolStripMenuItem,
            this.WindowToolStripMenuItem,
            this.HelpSupportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFileNew,
            this.ToolStripSeparator0,
            this.tsFileOpen,
            this.tsFileSave,
            this.tsFileSaveAs,
            this.ToolStripSeparator1,
            this.tsFilePrint,
            this.tsFileQuit});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // tsFileNew
            // 
            this.tsFileNew.Name = "tsFileNew";
            this.tsFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsFileNew.Size = new System.Drawing.Size(179, 22);
            this.tsFileNew.Text = "&New / Clear";
            // 
            // ToolStripSeparator0
            // 
            this.ToolStripSeparator0.Name = "ToolStripSeparator0";
            this.ToolStripSeparator0.Size = new System.Drawing.Size(176, 6);
            // 
            // tsFileOpen
            // 
            this.tsFileOpen.Name = "tsFileOpen";
            this.tsFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsFileOpen.Size = new System.Drawing.Size(179, 22);
            this.tsFileOpen.Text = "&Open...";
            // 
            // tsFileSave
            // 
            this.tsFileSave.Name = "tsFileSave";
            this.tsFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsFileSave.Size = new System.Drawing.Size(179, 22);
            this.tsFileSave.Text = "&Save";
            // 
            // tsFileSaveAs
            // 
            this.tsFileSaveAs.Name = "tsFileSaveAs";
            this.tsFileSaveAs.Size = new System.Drawing.Size(179, 22);
            this.tsFileSaveAs.Text = "Save &As...";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // tsFilePrint
            // 
            this.tsFilePrint.Name = "tsFilePrint";
            this.tsFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsFilePrint.Size = new System.Drawing.Size(179, 22);
            this.tsFilePrint.Text = "&Print...";
            // 
            // tsFileQuit
            // 
            this.tsFileQuit.Name = "tsFileQuit";
            this.tsFileQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.tsFileQuit.Size = new System.Drawing.Size(179, 22);
            this.tsFileQuit.Text = "&Quit";
            // 
            // ImportExportToolStripMenuItem
            // 
            this.ImportExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsImport,
            this.ToolStripSeparator3,
            this.tsExport,
            this.tsExportLong,
            this.tsExportDataLink,
            this.ToolStripSeparator4,
            this.tsExportDiscord});
            this.ImportExportToolStripMenuItem.Name = "ImportExportToolStripMenuItem";
            this.ImportExportToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.ImportExportToolStripMenuItem.Text = "&Import/&Export";
            // 
            // tsImport
            // 
            this.tsImport.Name = "tsImport";
            this.tsImport.Size = new System.Drawing.Size(203, 22);
            this.tsImport.Text = "&Import from Forum Post";
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(200, 6);
            // 
            // tsExport
            // 
            this.tsExport.Name = "tsExport";
            this.tsExport.Size = new System.Drawing.Size(203, 22);
            this.tsExport.Text = "&Short Forum Export...";
            // 
            // tsExportLong
            // 
            this.tsExportLong.Name = "tsExportLong";
            this.tsExportLong.Size = new System.Drawing.Size(203, 22);
            this.tsExportLong.Text = "&Long Forum Export...";
            // 
            // tsExportDataLink
            // 
            this.tsExportDataLink.Name = "tsExportDataLink";
            this.tsExportDataLink.Size = new System.Drawing.Size(203, 22);
            this.tsExportDataLink.Text = "Export Data Link";
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(200, 6);
            // 
            // tsExportDiscord
            // 
            this.tsExportDiscord.Name = "tsExportDiscord";
            this.tsExportDiscord.Size = new System.Drawing.Size(203, 22);
            this.tsExportDiscord.Text = "Export to Discord";
            // 
            // OptionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsConfig,
            this.ToolStripSeparator5,
            this.tsUpdateCheck,
            this.ToolStripSeparator6,
            this.tsLevelUp,
            this.tsDynamic,
            this.ToolStripSeparator7,
            this.AdvancedToolStripMenuItem});
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.OptionsToolStripMenuItem.Text = "&Options";
            // 
            // tsConfig
            // 
            this.tsConfig.Name = "tsConfig";
            this.tsConfig.Size = new System.Drawing.Size(166, 22);
            this.tsConfig.Text = "&Configuration";
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(163, 6);
            // 
            // tsUpdateCheck
            // 
            this.tsUpdateCheck.Name = "tsUpdateCheck";
            this.tsUpdateCheck.Size = new System.Drawing.Size(166, 22);
            this.tsUpdateCheck.Text = "Check for &Update";
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(163, 6);
            // 
            // tsLevelUp
            // 
            this.tsLevelUp.Name = "tsLevelUp";
            this.tsLevelUp.Size = new System.Drawing.Size(166, 22);
            this.tsLevelUp.Text = "&Level-Up Mode";
            this.tsLevelUp.ToolTipText = "Alternate between placing powers and slots, just like levelling up in-game.";
            // 
            // tsDynamic
            // 
            this.tsDynamic.Name = "tsDynamic";
            this.tsDynamic.Size = new System.Drawing.Size(166, 22);
            this.tsDynamic.Text = "&Dynamic Mode";
            this.tsDynamic.ToolTipText = "Place powers and slots in any order.";
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(163, 6);
            // 
            // AdvancedToolStripMenuItem
            // 
            this.AdvancedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdvDBEdit});
            this.AdvancedToolStripMenuItem.Name = "AdvancedToolStripMenuItem";
            this.AdvancedToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.AdvancedToolStripMenuItem.Text = "&Advanced";
            // 
            // tsAdvDBEdit
            // 
            this.tsAdvDBEdit.Name = "tsAdvDBEdit";
            this.tsAdvDBEdit.Size = new System.Drawing.Size(156, 22);
            this.tsAdvDBEdit.Text = "&Database Editor";
            // 
            // SlotsEnhancementsToolStripMenuItem
            // 
            this.SlotsEnhancementsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetAllIOsToToolStripMenuItem,
            this.ToolStripSeparator9,
            this.SetAllEnhOriginsToolStripMenuItem,
            this.SetAllRelativeToolStripMenuItem,
            this.ToolStripSeparator10,
            this.SlotsToolStripMenuItem});
            this.SlotsEnhancementsToolStripMenuItem.Name = "SlotsEnhancementsToolStripMenuItem";
            this.SlotsEnhancementsToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.SlotsEnhancementsToolStripMenuItem.Text = "&Slots/Enhancements";
            // 
            // SetAllIOsToToolStripMenuItem
            // 
            this.SetAllIOsToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsIODefault,
            this.ToolStripSeparator8,
            this.tsIOMin,
            this.tsIOMax});
            this.SetAllIOsToToolStripMenuItem.Name = "SetAllIOsToToolStripMenuItem";
            this.SetAllIOsToToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.SetAllIOsToToolStripMenuItem.Text = "&Set all IOs to...";
            // 
            // tsIODefault
            // 
            this.tsIODefault.Name = "tsIODefault";
            this.tsIODefault.Size = new System.Drawing.Size(135, 22);
            this.tsIODefault.Text = "Default (35)";
            // 
            // ToolStripSeparator8
            // 
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new System.Drawing.Size(132, 6);
            // 
            // tsIOMin
            // 
            this.tsIOMin.Name = "tsIOMin";
            this.tsIOMin.Size = new System.Drawing.Size(135, 22);
            this.tsIOMin.Text = "Minimum";
            // 
            // tsIOMax
            // 
            this.tsIOMax.Name = "tsIOMax";
            this.tsIOMax.Size = new System.Drawing.Size(135, 22);
            this.tsIOMax.Text = "Maximum";
            // 
            // ToolStripSeparator9
            // 
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new System.Drawing.Size(242, 6);
            // 
            // SetAllEnhOriginsToolStripMenuItem
            // 
            this.SetAllEnhOriginsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEnhToSO,
            this.tsEnhToDO,
            this.tsEnhToTO});
            this.SetAllEnhOriginsToolStripMenuItem.Name = "SetAllEnhOriginsToolStripMenuItem";
            this.SetAllEnhOriginsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.SetAllEnhOriginsToolStripMenuItem.Text = "Set all Enhancement &Origins to...";
            // 
            // tsEnhToSO
            // 
            this.tsEnhToSO.Name = "tsEnhToSO";
            this.tsEnhToSO.Size = new System.Drawing.Size(142, 22);
            this.tsEnhToSO.Text = "Single Origin";
            // 
            // tsEnhToDO
            // 
            this.tsEnhToDO.Name = "tsEnhToDO";
            this.tsEnhToDO.Size = new System.Drawing.Size(142, 22);
            this.tsEnhToDO.Text = "Dual Origin";
            // 
            // tsEnhToTO
            // 
            this.tsEnhToTO.Name = "tsEnhToTO";
            this.tsEnhToTO.Size = new System.Drawing.Size(142, 22);
            this.tsEnhToTO.Text = "Training";
            // 
            // SetAllRelativeToolStripMenuItem
            // 
            this.SetAllRelativeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEnhToPlus5,
            this.tsEnhToPlus4,
            this.tsEnhToPlus3,
            this.tsEnhToPlus2,
            this.tsEnhToPlus1,
            this.tsEnhToEven,
            this.tsEnhToMinus1,
            this.tsEnhToMinus2,
            this.tsEnhToMinus3,
            this.tsEnhToNone});
            this.SetAllRelativeToolStripMenuItem.Name = "SetAllRelativeToolStripMenuItem";
            this.SetAllRelativeToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.SetAllRelativeToolStripMenuItem.Text = "Set all &Relative Levels to...";
            // 
            // tsEnhToPlus5
            // 
            this.tsEnhToPlus5.Name = "tsEnhToPlus5";
            this.tsEnhToPlus5.Size = new System.Drawing.Size(205, 22);
            this.tsEnhToPlus5.Text = "+5 Levels";
            // 
            // tsEnhToPlus4
            // 
            this.tsEnhToPlus4.Name = "tsEnhToPlus4";
            this.tsEnhToPlus4.Size = new System.Drawing.Size(205, 22);
            this.tsEnhToPlus4.Text = "+4 Levels";
            // 
            // tsEnhToPlus3
            // 
            this.tsEnhToPlus3.Name = "tsEnhToPlus3";
            this.tsEnhToPlus3.Size = new System.Drawing.Size(205, 22);
            this.tsEnhToPlus3.Text = "+3 Levels";
            // 
            // tsEnhToPlus2
            // 
            this.tsEnhToPlus2.Name = "tsEnhToPlus2";
            this.tsEnhToPlus2.Size = new System.Drawing.Size(205, 22);
            this.tsEnhToPlus2.Text = "+2 Levels";
            // 
            // tsEnhToPlus1
            // 
            this.tsEnhToPlus1.Name = "tsEnhToPlus1";
            this.tsEnhToPlus1.Size = new System.Drawing.Size(205, 22);
            this.tsEnhToPlus1.Text = "+1 Level";
            // 
            // tsEnhToEven
            // 
            this.tsEnhToEven.Name = "tsEnhToEven";
            this.tsEnhToEven.Size = new System.Drawing.Size(205, 22);
            this.tsEnhToEven.Text = "Even Level";
            // 
            // tsEnhToMinus1
            // 
            this.tsEnhToMinus1.Name = "tsEnhToMinus1";
            this.tsEnhToMinus1.Size = new System.Drawing.Size(205, 22);
            this.tsEnhToMinus1.Text = "-1 Level";
            // 
            // tsEnhToMinus2
            // 
            this.tsEnhToMinus2.Name = "tsEnhToMinus2";
            this.tsEnhToMinus2.Size = new System.Drawing.Size(205, 22);
            this.tsEnhToMinus2.Text = "-2 Levels";
            // 
            // tsEnhToMinus3
            // 
            this.tsEnhToMinus3.Name = "tsEnhToMinus3";
            this.tsEnhToMinus3.Size = new System.Drawing.Size(205, 22);
            this.tsEnhToMinus3.Text = "-3 Levels";
            // 
            // tsEnhToNone
            // 
            this.tsEnhToNone.Name = "tsEnhToNone";
            this.tsEnhToNone.Size = new System.Drawing.Size(205, 22);
            this.tsEnhToNone.Text = "None (Enh has no effect)";
            // 
            // ToolStripSeparator10
            // 
            this.ToolStripSeparator10.Name = "ToolStripSeparator10";
            this.ToolStripSeparator10.Size = new System.Drawing.Size(242, 6);
            // 
            // SlotsToolStripMenuItem
            // 
            this.SlotsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFlipAllEnh,
            this.ToolStripSeparator11,
            this.tsClearAllEnh,
            this.tsRemoveAllSlots,
            this.ToolStripSeparator12,
            this.tsAutoArrangeAllSlots});
            this.SlotsToolStripMenuItem.Name = "SlotsToolStripMenuItem";
            this.SlotsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.SlotsToolStripMenuItem.Text = "Slo&ts";
            // 
            // tsFlipAllEnh
            // 
            this.tsFlipAllEnh.Name = "tsFlipAllEnh";
            this.tsFlipAllEnh.Size = new System.Drawing.Size(199, 22);
            this.tsFlipAllEnh.Text = "Flip All to Alternate";
            // 
            // ToolStripSeparator11
            // 
            this.ToolStripSeparator11.Name = "ToolStripSeparator11";
            this.ToolStripSeparator11.Size = new System.Drawing.Size(196, 6);
            // 
            // tsClearAllEnh
            // 
            this.tsClearAllEnh.Name = "tsClearAllEnh";
            this.tsClearAllEnh.Size = new System.Drawing.Size(199, 22);
            this.tsClearAllEnh.Text = "Clear All Enhancements";
            // 
            // tsRemoveAllSlots
            // 
            this.tsRemoveAllSlots.Name = "tsRemoveAllSlots";
            this.tsRemoveAllSlots.Size = new System.Drawing.Size(199, 22);
            // 
            // ToolStripSeparator12
            // 
            this.ToolStripSeparator12.Name = "ToolStripSeparator12";
            this.ToolStripSeparator12.Size = new System.Drawing.Size(196, 6);
            // 
            // tsAutoArrangeAllSlots
            // 
            this.tsAutoArrangeAllSlots.Name = "tsAutoArrangeAllSlots";
            this.tsAutoArrangeAllSlots.Size = new System.Drawing.Size(199, 22);
            this.tsAutoArrangeAllSlots.Text = "&Auto-Arrange All Slots";
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsView2Col,
            this.tsView3Col,
            this.tsView4Col,
            this.ToolStripSeparator13,
            this.tsViewIOLevels,
            this.tsViewRelative,
            this.tsViewSlotLevels,
            this.ToolStripSeparator14,
            this.tsViewActualDamage_New,
            this.tsViewDPS_New,
            this.tlsDPA});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ViewToolStripMenuItem.Text = "&View";
            // 
            // tsView2Col
            // 
            this.tsView2Col.Name = "tsView2Col";
            this.tsView2Col.Size = new System.Drawing.Size(282, 22);
            this.tsView2Col.Text = "&2 Columns";
            // 
            // tsView3Col
            // 
            this.tsView3Col.Name = "tsView3Col";
            this.tsView3Col.Size = new System.Drawing.Size(282, 22);
            this.tsView3Col.Text = "&3 Columns";
            // 
            // tsView4Col
            // 
            this.tsView4Col.Name = "tsView4Col";
            this.tsView4Col.Size = new System.Drawing.Size(282, 22);
            this.tsView4Col.Text = "&4 Columns";
            // 
            // ToolStripSeparator13
            // 
            this.ToolStripSeparator13.Name = "ToolStripSeparator13";
            this.ToolStripSeparator13.Size = new System.Drawing.Size(279, 6);
            // 
            // tsViewIOLevels
            // 
            this.tsViewIOLevels.Name = "tsViewIOLevels";
            this.tsViewIOLevels.Size = new System.Drawing.Size(282, 22);
            this.tsViewIOLevels.Text = "Show &IO Levels";
            // 
            // tsViewRelative
            // 
            this.tsViewRelative.Name = "tsViewRelative";
            this.tsViewRelative.Size = new System.Drawing.Size(282, 22);
            this.tsViewRelative.Text = "Show &Enhancement Relative Levels";
            // 
            // tsViewSlotLevels
            // 
            this.tsViewSlotLevels.Name = "tsViewSlotLevels";
            this.tsViewSlotLevels.Size = new System.Drawing.Size(282, 22);
            this.tsViewSlotLevels.Text = "Show &Slot Placement Levels";
            // 
            // ToolStripSeparator14
            // 
            this.ToolStripSeparator14.Name = "ToolStripSeparator14";
            this.ToolStripSeparator14.Size = new System.Drawing.Size(279, 6);
            // 
            // tsViewActualDamage_New
            // 
            this.tsViewActualDamage_New.Name = "tsViewActualDamage_New";
            this.tsViewActualDamage_New.Size = new System.Drawing.Size(282, 22);
            this.tsViewActualDamage_New.Text = "Show Damage Per Activation (Level 50)";
            // 
            // tsViewDPS_New
            // 
            this.tsViewDPS_New.Name = "tsViewDPS_New";
            this.tsViewDPS_New.Size = new System.Drawing.Size(282, 22);
            this.tsViewDPS_New.Text = "Show Damage Per Second (Level 50)";
            // 
            // tlsDPA
            // 
            this.tlsDPA.Name = "tlsDPA";
            this.tlsDPA.Size = new System.Drawing.Size(282, 22);
            this.tlsDPA.Text = "Show Damage Per Animation (Level 50)";
            // 
            // WindowToolStripMenuItem
            // 
            this.WindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsViewSets,
            this.tsViewGraphs,
            this.tsViewSetCompare,
            this.tsViewData,
            this.tsViewTotals,
            this.ToolStripSeparator15,
            this.tsRecipeViewer,
            this.tsDPSCalc,
            this.ToolStripSeparator16,
            this.tsSetFind,
            this.ToolStripSeparator17,
            this.InGameRespecHelperToolStripMenuItem,
            this.tsAccoladesWindow,
            this.tsIncarnateWindow,
            this.tsTemporaryPowersWindow});
            this.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem";
            this.WindowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.WindowToolStripMenuItem.Text = "&Window";
            // 
            // tsViewSets
            // 
            this.tsViewSets.Name = "tsViewSets";
            this.tsViewSets.Size = new System.Drawing.Size(218, 22);
            this.tsViewSets.Text = "&Sets && Bonuses";
            // 
            // tsViewGraphs
            // 
            this.tsViewGraphs.Name = "tsViewGraphs";
            this.tsViewGraphs.Size = new System.Drawing.Size(218, 22);
            this.tsViewGraphs.Text = "Power &Graphs";
            // 
            // tsViewSetCompare
            // 
            this.tsViewSetCompare.Name = "tsViewSetCompare";
            this.tsViewSetCompare.Size = new System.Drawing.Size(218, 22);
            this.tsViewSetCompare.Text = "Powerset &Comparison";
            // 
            // tsViewData
            // 
            this.tsViewData.Name = "tsViewData";
            this.tsViewData.Size = new System.Drawing.Size(218, 22);
            this.tsViewData.Text = "&Data View";
            // 
            // tsViewTotals
            // 
            this.tsViewTotals.Name = "tsViewTotals";
            this.tsViewTotals.Size = new System.Drawing.Size(218, 22);
            this.tsViewTotals.Text = "Advanced &Totals";
            // 
            // ToolStripSeparator15
            // 
            this.ToolStripSeparator15.Name = "ToolStripSeparator15";
            this.ToolStripSeparator15.Size = new System.Drawing.Size(215, 6);
            // 
            // tsRecipeViewer
            // 
            this.tsRecipeViewer.Name = "tsRecipeViewer";
            this.tsRecipeViewer.Size = new System.Drawing.Size(218, 22);
            this.tsRecipeViewer.Text = "&Recipe Viewer";
            // 
            // tsDPSCalc
            // 
            this.tsDPSCalc.Name = "tsDPSCalc";
            this.tsDPSCalc.Size = new System.Drawing.Size(218, 22);
            this.tsDPSCalc.Text = "DPS Calculator (Beta)";
            // 
            // ToolStripSeparator16
            // 
            this.ToolStripSeparator16.Name = "ToolStripSeparator16";
            this.ToolStripSeparator16.Size = new System.Drawing.Size(215, 6);
            // 
            // tsSetFind
            // 
            this.tsSetFind.Name = "tsSetFind";
            this.tsSetFind.Size = new System.Drawing.Size(218, 22);
            this.tsSetFind.Text = "Set &Bonus Finder";
            // 
            // ToolStripSeparator17
            // 
            this.ToolStripSeparator17.Name = "ToolStripSeparator17";
            this.ToolStripSeparator17.Size = new System.Drawing.Size(215, 6);
            // 
            // InGameRespecHelperToolStripMenuItem
            // 
            this.InGameRespecHelperToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHelperShort,
            this.tsHelperLong,
            this.ToolStripSeparator18,
            this.tsHelperShort2,
            this.tsHelperLong2});
            this.InGameRespecHelperToolStripMenuItem.Name = "InGameRespecHelperToolStripMenuItem";
            this.InGameRespecHelperToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.InGameRespecHelperToolStripMenuItem.Text = "In-Game &Respec Helper";
            // 
            // tsHelperShort
            // 
            this.tsHelperShort.Name = "tsHelperShort";
            this.tsHelperShort.Size = new System.Drawing.Size(143, 22);
            this.tsHelperShort.Text = "Profile &Short";
            // 
            // tsHelperLong
            // 
            this.tsHelperLong.Name = "tsHelperLong";
            this.tsHelperLong.Size = new System.Drawing.Size(143, 22);
            this.tsHelperLong.Text = "Profile &Long";
            // 
            // ToolStripSeparator18
            // 
            this.ToolStripSeparator18.Name = "ToolStripSeparator18";
            this.ToolStripSeparator18.Size = new System.Drawing.Size(140, 6);
            // 
            // tsHelperShort2
            // 
            this.tsHelperShort2.Name = "tsHelperShort2";
            this.tsHelperShort2.Size = new System.Drawing.Size(143, 22);
            this.tsHelperShort2.Text = "History S&hort";
            // 
            // tsHelperLong2
            // 
            this.tsHelperLong2.Name = "tsHelperLong2";
            this.tsHelperLong2.Size = new System.Drawing.Size(143, 22);
            this.tsHelperLong2.Text = "History L&ong";
            // 
            // tsAccoladesWindow
            // 
            this.tsAccoladesWindow.Name = "tsAccoladesWindow";
            this.tsAccoladesWindow.Size = new System.Drawing.Size(218, 22);
            this.tsAccoladesWindow.Text = "Accolades Window";
            // 
            // tsIncarnateWindow
            // 
            this.tsIncarnateWindow.Name = "tsIncarnateWindow";
            this.tsIncarnateWindow.Size = new System.Drawing.Size(218, 22);
            this.tsIncarnateWindow.Text = "Incarnates Window";
            // 
            // tsTemporaryPowersWindow
            // 
            this.tsTemporaryPowersWindow.Name = "tsTemporaryPowersWindow";
            this.tsTemporaryPowersWindow.Size = new System.Drawing.Size(218, 22);
            this.tsTemporaryPowersWindow.Text = "Temporary Powers Window";
            // 
            // HelpSupportToolStripMenuItem
            // 
            this.HelpSupportToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.HelpSupportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHelp,
            this.ToolStripSeparator20,
            this.tsBugCrytilis,
            this.tsHCMRBForum,
            this.ToolStripSeparator21,
            this.tsKoFi,
            this.ToolStripSeparator22,
            this.tsPatreon,
            this.ToolStripSeparator23,
            this.tsGitHubCrytilis});
            this.HelpSupportToolStripMenuItem.Name = "HelpSupportToolStripMenuItem";
            this.HelpSupportToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HelpSupportToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.HelpSupportToolStripMenuItem.Text = "&Help && Support";
            // 
            // tsHelp
            // 
            this.tsHelp.Name = "tsHelp";
            this.tsHelp.Size = new System.Drawing.Size(266, 22);
            this.tsHelp.Text = "Get Help! (MRB Discord)";
            // 
            // ToolStripSeparator20
            // 
            this.ToolStripSeparator20.Name = "ToolStripSeparator20";
            this.ToolStripSeparator20.Size = new System.Drawing.Size(263, 6);
            // 
            // tsBugCrytilis
            // 
            this.tsBugCrytilis.Name = "tsBugCrytilis";
            this.tsBugCrytilis.Size = new System.Drawing.Size(266, 22);
            this.tsBugCrytilis.Text = "F&ile Bug Report";
            // 
            // tsHCMRBForum
            // 
            this.tsHCMRBForum.Name = "tsHCMRBForum";
            this.tsHCMRBForum.Size = new System.Drawing.Size(266, 22);
            this.tsHCMRBForum.Text = "Official Homecoming Forum Thread";
            // 
            // ToolStripSeparator21
            // 
            this.ToolStripSeparator21.Name = "ToolStripSeparator21";
            this.ToolStripSeparator21.Size = new System.Drawing.Size(263, 6);
            // 
            // tsKoFi
            // 
            this.tsKoFi.Name = "tsKoFi";
            this.tsKoFi.Size = new System.Drawing.Size(266, 22);
            this.tsKoFi.Text = "Support via Ko-Fi (Donate)";
            // 
            // ToolStripSeparator22
            // 
            this.ToolStripSeparator22.Name = "ToolStripSeparator22";
            this.ToolStripSeparator22.Size = new System.Drawing.Size(263, 6);
            // 
            // tsPatreon
            // 
            this.tsPatreon.Name = "tsPatreon";
            this.tsPatreon.Size = new System.Drawing.Size(266, 22);
            this.tsPatreon.Text = "Support via Patreon (Pledge)";
            // 
            // ToolStripSeparator23
            // 
            this.ToolStripSeparator23.Name = "ToolStripSeparator23";
            this.ToolStripSeparator23.Size = new System.Drawing.Size(263, 6);
            // 
            // tsGitHubCrytilis
            // 
            this.tsGitHubCrytilis.Name = "tsGitHubCrytilis";
            this.tsGitHubCrytilis.Size = new System.Drawing.Size(266, 22);
            this.tsGitHubCrytilis.Text = "MRB &GitHub";
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(57, 6);
            // 
            // tsAdvFreshInstall
            // 
            this.tsAdvFreshInstall.Name = "tsAdvFreshInstall";
            this.tsAdvFreshInstall.Size = new System.Drawing.Size(32, 19);
            // 
            // tsAdvResetTips
            // 
            this.tsAdvResetTips.Name = "tsAdvResetTips";
            this.tsAdvResetTips.Size = new System.Drawing.Size(32, 19);
            // 
            // ToolStripSeparator19
            // 
            this.ToolStripSeparator19.Name = "ToolStripSeparator19";
            this.ToolStripSeparator19.Size = new System.Drawing.Size(6, 6);
            // 
            // ToolStripSeparator24
            // 
            this.ToolStripSeparator24.Name = "ToolStripSeparator24";
            this.ToolStripSeparator24.Size = new System.Drawing.Size(6, 6);
            // 
            // lblHero
            // 
            this.lblHero.AutoSize = true;
            this.lblHero.BackColor = System.Drawing.Color.Transparent;
            this.lblHero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHero.ForeColor = System.Drawing.Color.White;
            this.lblHero.Location = new System.Drawing.Point(48, 34);
            this.lblHero.Name = "lblHero";
            this.lblHero.Size = new System.Drawing.Size(416, 19);
            this.lblHero.TabIndex = 1;
            this.lblHero.Text = "Name: Level 0 Origin Archetype (Primary / Secondary)";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Hero.png");
            this.imageList1.Images.SetKeyName(1, "Vigilante.png");
            this.imageList1.Images.SetKeyName(2, "Villain.png");
            this.imageList1.Images.SetKeyName(3, "Rogue.png");
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.FlatAppearance.BorderSize = 0;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.ImageIndex = 0;
            this.checkBox2.ImageList = this.imageList1;
            this.checkBox2.Location = new System.Drawing.Point(781, 27);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(115, 22);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Mode: PvE";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.FlatAppearance.BorderSize = 0;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.ImageIndex = 0;
            this.checkBox3.ImageList = this.imageList1;
            this.checkBox3.Location = new System.Drawing.Point(902, 27);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(115, 22);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Recipes: Off";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4.FlatAppearance.BorderSize = 0;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.ImageIndex = 0;
            this.checkBox4.ImageList = this.imageList1;
            this.checkBox4.Location = new System.Drawing.Point(1023, 27);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(115, 22);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Pop-Up: On";
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox5.BackColor = System.Drawing.Color.Transparent;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox5.FlatAppearance.BorderSize = 0;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.White;
            this.checkBox5.ImageIndex = 0;
            this.checkBox5.ImageList = this.imageList1;
            this.checkBox5.Location = new System.Drawing.Point(660, 55);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(115, 22);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "Pet Powers";
            this.checkBox5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox6.BackColor = System.Drawing.Color.Transparent;
            this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox6.FlatAppearance.BorderSize = 0;
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.ForeColor = System.Drawing.Color.White;
            this.checkBox6.ImageIndex = 0;
            this.checkBox6.ImageList = this.imageList1;
            this.checkBox6.Location = new System.Drawing.Point(781, 55);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(115, 22);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "Accolades: Off";
            this.checkBox6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox6.UseVisualStyleBackColor = false;
            // 
            // checkBox7
            // 
            this.checkBox7.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox7.BackColor = System.Drawing.Color.Transparent;
            this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox7.FlatAppearance.BorderSize = 0;
            this.checkBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.ForeColor = System.Drawing.Color.White;
            this.checkBox7.ImageIndex = 0;
            this.checkBox7.ImageList = this.imageList1;
            this.checkBox7.Location = new System.Drawing.Point(902, 55);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(115, 22);
            this.checkBox7.TabIndex = 8;
            this.checkBox7.Text = "Incarnates";
            this.checkBox7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox7.UseVisualStyleBackColor = false;
            // 
            // checkBox8
            // 
            this.checkBox8.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox8.BackColor = System.Drawing.Color.Transparent;
            this.checkBox8.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox8.FlatAppearance.BorderSize = 0;
            this.checkBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.ForeColor = System.Drawing.Color.White;
            this.checkBox8.ImageIndex = 0;
            this.checkBox8.ImageList = this.imageList1;
            this.checkBox8.Location = new System.Drawing.Point(1023, 55);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(115, 22);
            this.checkBox8.TabIndex = 9;
            this.checkBox8.Text = "Temp Powers: Off";
            this.checkBox8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox8.ThreeState = true;
            this.checkBox8.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 77);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Archetype:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 130);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Origin:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox9
            // 
            this.checkBox9.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox9.BackColor = System.Drawing.Color.Transparent;
            this.checkBox9.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox9.FlatAppearance.BorderSize = 0;
            this.checkBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.ForeColor = System.Drawing.Color.White;
            this.checkBox9.ImageIndex = 0;
            this.checkBox9.ImageList = this.imageList1;
            this.checkBox9.Location = new System.Drawing.Point(295, 71);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(115, 22);
            this.checkBox9.TabIndex = 16;
            this.checkBox9.Text = "Dynamic";
            this.checkBox9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox9.ThreeState = true;
            this.checkBox9.UseVisualStyleBackColor = false;
            // 
            // checkBox10
            // 
            this.checkBox10.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox10.BackColor = System.Drawing.Color.Transparent;
            this.checkBox10.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox10.FlatAppearance.BorderSize = 0;
            this.checkBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.ForeColor = System.Drawing.Color.White;
            this.checkBox10.ImageIndex = 0;
            this.checkBox10.ImageList = this.imageList1;
            this.checkBox10.Location = new System.Drawing.Point(416, 71);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(115, 22);
            this.checkBox10.TabIndex = 17;
            this.checkBox10.Text = "Power/Slot";
            this.checkBox10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox10.ThreeState = true;
            this.checkBox10.UseVisualStyleBackColor = false;
            // 
            // checkBox11
            // 
            this.checkBox11.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox11.BackColor = System.Drawing.Color.Transparent;
            this.checkBox11.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox11.FlatAppearance.BorderSize = 0;
            this.checkBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.ForeColor = System.Drawing.Color.White;
            this.checkBox11.ImageIndex = 0;
            this.checkBox11.ImageList = this.imageList1;
            this.checkBox11.Location = new System.Drawing.Point(295, 99);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(115, 22);
            this.checkBox11.TabIndex = 18;
            this.checkBox11.Text = "View Active Sets";
            this.checkBox11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox11.ThreeState = true;
            this.checkBox11.UseVisualStyleBackColor = false;
            // 
            // checkBox12
            // 
            this.checkBox12.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox12.BackColor = System.Drawing.Color.Transparent;
            this.checkBox12.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox12.FlatAppearance.BorderSize = 0;
            this.checkBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox12.ForeColor = System.Drawing.Color.White;
            this.checkBox12.ImageIndex = 0;
            this.checkBox12.ImageList = this.imageList1;
            this.checkBox12.Location = new System.Drawing.Point(416, 99);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(115, 22);
            this.checkBox12.TabIndex = 19;
            this.checkBox12.Text = "View Totals";
            this.checkBox12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox12.ThreeState = true;
            this.checkBox12.UseVisualStyleBackColor = false;
            // 
            // checkBox13
            // 
            this.checkBox13.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox13.BackColor = System.Drawing.Color.Transparent;
            this.checkBox13.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox13.FlatAppearance.BorderSize = 0;
            this.checkBox13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox13.ForeColor = System.Drawing.Color.White;
            this.checkBox13.ImageIndex = 0;
            this.checkBox13.ImageList = this.imageList1;
            this.checkBox13.Location = new System.Drawing.Point(295, 127);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(115, 22);
            this.checkBox13.TabIndex = 20;
            this.checkBox13.Text = "Slot Levels: Off";
            this.checkBox13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox13.ThreeState = true;
            this.checkBox13.UseVisualStyleBackColor = false;
            // 
            // checkBox14
            // 
            this.checkBox14.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox14.BackColor = System.Drawing.Color.Transparent;
            this.checkBox14.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox14.FlatAppearance.BorderSize = 0;
            this.checkBox14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox14.ForeColor = System.Drawing.Color.White;
            this.checkBox14.ImageIndex = 0;
            this.checkBox14.ImageList = this.imageList1;
            this.checkBox14.Location = new System.Drawing.Point(416, 127);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(115, 22);
            this.checkBox14.TabIndex = 21;
            this.checkBox14.Text = "67 Slots";
            this.checkBox14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox14.ThreeState = true;
            this.checkBox14.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList2;
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 22;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "24px-Tips_Hero_large.png");
            this.imageList2.Images.SetKeyName(1, "24px-Tips_Rogue_large.png");
            this.imageList2.Images.SetKeyName(2, "24px-Tips_Villain_large.png");
            this.imageList2.Images.SetKeyName(3, "24px-Tips_Vigilante_large.png");
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageIndex = 0;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(660, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 22);
            this.button2.TabIndex = 23;
            this.button2.Text = "Hero";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.alignment_clicked);
            // 
            // ctlPowerList1
            // 
            this.ctlPowerList1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctlPowerList1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ctlPowerList1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlPowerList1.ForeColor = System.Drawing.Color.White;
            this.ctlPowerList1.FormattingEnabled = true;
            this.ctlPowerList1.ItemHeight = 16;
            this.ctlPowerList1.Items.AddRange(new object[] {
            "Power #1",
            "Power #2",
            "Power #3",
            "Power #5",
            "Power #6",
            "Power #7",
            "Power #8",
            "Power #9"});
            this.ctlPowerList1.Location = new System.Drawing.Point(3, 3);
            this.ctlPowerList1.Name = "ctlPowerList1";
            this.ctlPowerList1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.ctlPowerList1.SelectionColor = System.Drawing.Color.DodgerBlue;
            this.ctlPowerList1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ctlPowerList1.Size = new System.Drawing.Size(148, 132);
            this.ctlPowerList1.TabIndex = 24;
            // 
            // cbOrigin
            // 
            this.cbOrigin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigin.FormattingEnabled = true;
            this.cbOrigin.ImageList = null;
            this.cbOrigin.Location = new System.Drawing.Point(94, 129);
            this.cbOrigin.Name = "cbOrigin";
            this.cbOrigin.Size = new System.Drawing.Size(183, 21);
            this.cbOrigin.TabIndex = 15;
            // 
            // cbAT
            // 
            this.cbAT.DisplayMember = "DisplayName";
            this.cbAT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAT.FormattingEnabled = true;
            this.cbAT.ImageList = null;
            this.cbAT.Location = new System.Drawing.Point(94, 102);
            this.cbAT.Name = "cbAT";
            this.cbAT.Size = new System.Drawing.Size(183, 21);
            this.cbAT.TabIndex = 13;
            this.cbAT.ValueMember = "Idx";
            this.cbAT.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.ctlPowerList1);
            this.panel1.Location = new System.Drawing.Point(44, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 142);
            this.panel1.TabIndex = 25;
            // 
            // ctlCombo1
            // 
            this.ctlCombo1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ctlCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlCombo1.FormattingEnabled = true;
            this.ctlCombo1.ImageList = null;
            this.ctlCombo1.Location = new System.Drawing.Point(42, 179);
            this.ctlCombo1.Name = "ctlCombo1";
            this.ctlCombo1.Size = new System.Drawing.Size(153, 21);
            this.ctlCombo1.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 675);
            this.Controls.Add(this.ctlCombo1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox14);
            this.Controls.Add(this.checkBox13);
            this.Controls.Add(this.checkBox12);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.cbOrigin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.lblHero);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mids` Reborn : Hero Designer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SlotsEnhancementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpSupportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsAdvDBEdit;
        private System.Windows.Forms.ToolStripMenuItem tsAdvFreshInstall;
        private System.Windows.Forms.ToolStripMenuItem tsAdvResetTips;
        private System.Windows.Forms.ToolStripMenuItem tsBugCrytilis;
        private System.Windows.Forms.ToolStripMenuItem tsClearAllEnh;
        private System.Windows.Forms.ToolStripMenuItem tsConfig;
        private System.Windows.Forms.ToolStripMenuItem tsKoFi;
        private System.Windows.Forms.ToolStripMenuItem tsPatreon;
        private System.Windows.Forms.ToolStripMenuItem tsDynamic;
        private System.Windows.Forms.ToolStripMenuItem tsEnhToDO;
        private System.Windows.Forms.ToolStripMenuItem tsEnhToEven;
        private System.Windows.Forms.ToolStripMenuItem tsEnhToMinus1;
        private System.Windows.Forms.ToolStripMenuItem tsEnhToMinus2;
        private System.Windows.Forms.ToolStripMenuItem tsEnhToMinus3;
        private System.Windows.Forms.ToolStripMenuItem tsEnhToNone;
        private System.Windows.Forms.ToolStripMenuItem tsEnhToPlus1;
        private System.Windows.Forms.ToolStripMenuItem tsEnhToPlus2;
        private System.Windows.Forms.ToolStripMenuItem tsEnhToPlus3;
        private System.Windows.Forms.ToolStripMenuItem tsEnhToPlus4;
        private System.Windows.Forms.ToolStripMenuItem tsEnhToPlus5;
        private System.Windows.Forms.ToolStripMenuItem tsEnhToSO;
        private System.Windows.Forms.ToolStripMenuItem tsEnhToTO;
        private System.Windows.Forms.ToolStripMenuItem tsExport;
        private System.Windows.Forms.ToolStripMenuItem tsExportDataLink;
        private System.Windows.Forms.ToolStripMenuItem tsExportDiscord;
        private System.Windows.Forms.ToolStripMenuItem tsExportLong;
        private System.Windows.Forms.ToolStripMenuItem tsFileNew;
        private System.Windows.Forms.ToolStripMenuItem tsFileOpen;
        private System.Windows.Forms.ToolStripMenuItem tsFilePrint;
        private System.Windows.Forms.ToolStripMenuItem tsFileQuit;
        private System.Windows.Forms.ToolStripMenuItem tsFileSave;
        private System.Windows.Forms.ToolStripMenuItem tsFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsFlipAllEnh;
        private System.Windows.Forms.ToolStripMenuItem tsHelp;
        private System.Windows.Forms.ToolStripMenuItem tsHelperLong;
        private System.Windows.Forms.ToolStripMenuItem tsHelperLong2;
        private System.Windows.Forms.ToolStripMenuItem tsHelperShort;
        private System.Windows.Forms.ToolStripMenuItem tsHelperShort2;
        private System.Windows.Forms.ToolStripMenuItem tsImport;
        private System.Windows.Forms.ToolStripMenuItem tsIODefault;
        private System.Windows.Forms.ToolStripMenuItem tsIOMax;
        private System.Windows.Forms.ToolStripMenuItem tsIOMin;
        private System.Windows.Forms.ToolStripMenuItem tsLevelUp;
        private System.Windows.Forms.ToolStripMenuItem tsRecipeViewer;
        private System.Windows.Forms.ToolStripMenuItem tsDPSCalc;
        private System.Windows.Forms.ToolStripMenuItem tsRemoveAllSlots;
        private System.Windows.Forms.ToolStripMenuItem tsSetFind;
        private System.Windows.Forms.ToolStripMenuItem tsHCMRBForum;
        private System.Windows.Forms.ToolStripMenuItem tsGitHubCrytilis;
        private System.Windows.Forms.ToolStripMenuItem tsUpdateCheck;
        private System.Windows.Forms.ToolStripMenuItem tsView2Col;
        private System.Windows.Forms.ToolStripMenuItem tsView3Col;
        private System.Windows.Forms.ToolStripMenuItem tsView4Col;
        private System.Windows.Forms.ToolStripMenuItem tsViewActualDamage_New;
        private System.Windows.Forms.ToolStripMenuItem tsViewData;
        private System.Windows.Forms.ToolStripMenuItem tsViewDPS_New;
        private System.Windows.Forms.ToolStripMenuItem tsViewGraphs;
        private System.Windows.Forms.ToolStripMenuItem tsViewIOLevels;
        private System.Windows.Forms.ToolStripMenuItem tsViewRelative;
        private System.Windows.Forms.ToolStripMenuItem tsViewSetCompare;
        private System.Windows.Forms.ToolStripMenuItem tsViewSets;
        private System.Windows.Forms.ToolStripMenuItem tsViewSlotLevels;
        private System.Windows.Forms.ToolStripMenuItem tsViewTotals;
        private System.Windows.Forms.ToolStripMenuItem tsAccoladesWindow;
        private System.Windows.Forms.ToolStripMenuItem AdvancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsAutoArrangeAllSlots;
        private System.Windows.Forms.ToolStripMenuItem tsIncarnateWindow;
        private System.Windows.Forms.ToolStripMenuItem InGameRespecHelperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetAllIOsToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SlotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsTemporaryPowersWindow;
        private System.Windows.Forms.ToolStripMenuItem tlsDPA;
        private System.Windows.Forms.ToolStripMenuItem SetAllEnhOriginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetAllRelativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator0;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator11;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator12;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator13;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator14;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator15;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator16;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator17;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator18;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator19;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator20;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator21;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator22;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator23;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator24;
        private System.Windows.Forms.Label lblHero;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private ctlCombo cbAT;
        private ctlCombo cbOrigin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button button2;
        private ctlPowerList ctlPowerList1;
        private System.Windows.Forms.Panel panel1;
        private ctlCombo ctlCombo1;
    }
}