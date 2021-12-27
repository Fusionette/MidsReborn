using System.ComponentModel;

namespace MidsReborn.Forms.OptionsMenuItems.DbEditor
{
    public partial class frmDBEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.udIssue = new System.Windows.Forms.NumericUpDown();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnEditEnh = new System.Windows.Forms.Button();
            this.btnEditIOSetPvE = new System.Windows.Forms.Button();
            this.lblCountSalvage = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblCountRecipe = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblCountFX = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.lblCountPwr = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.lblCountPS = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.lblCountIOSet = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.lblCountEnh = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.lblCountAT = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSalvage = new System.Windows.Forms.Button();
            this.btnRecipe = new System.Windows.Forms.Button();
            this.btnEditEntity = new System.Windows.Forms.Button();
            this.btnPSBrowse = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnFileReport = new System.Windows.Forms.Button();
            this.exportIndexes = new System.Windows.Forms.Button();
            this.btnExportJSON = new System.Windows.Forms.Button();
            this.btnJsonImporter = new System.Windows.Forms.Button();
            this.btnAttribModEdit = new System.Windows.Forms.Button();
            this.btnGCMIO = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDBConverter = new System.Windows.Forms.Button();
            this.udPageVol = new System.Windows.Forms.NumericUpDown();
            this.txtPageVol = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDBVer = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.udIssue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPageVol)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // udIssue
            // 
            this.udIssue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.udIssue.Location = new System.Drawing.Point(5, 33);
            this.udIssue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udIssue.Name = "udIssue";
            this.udIssue.Size = new System.Drawing.Size(194, 20);
            this.udIssue.TabIndex = 0;
            this.udIssue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udIssue.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.udIssue.ValueChanged += new System.EventHandler(this.udIssue_ValueChanged);
            this.udIssue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.udIssue_KeyPress);
            // 
            // Label1
            // 
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(5, 2);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(194, 26);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Issue Supported";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(611, 2);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(197, 26);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Database Date:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(611, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(197, 26);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "DD/MM/YYYY";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditEnh
            // 
            this.btnEditEnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditEnh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEnh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditEnh.Location = new System.Drawing.Point(665, 78);
            this.btnEditEnh.Name = "btnEditEnh";
            this.btnEditEnh.Size = new System.Drawing.Size(160, 44);
            this.btnEditEnh.TabIndex = 5;
            this.btnEditEnh.Text = "Enhancement Database Editor";
            this.btnEditEnh.UseVisualStyleBackColor = true;
            this.btnEditEnh.Click += new System.EventHandler(this.btnEditEnh_Click);
            // 
            // btnEditIOSetPvE
            // 
            this.btnEditIOSetPvE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditIOSetPvE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditIOSetPvE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditIOSetPvE.Location = new System.Drawing.Point(665, 127);
            this.btnEditIOSetPvE.Name = "btnEditIOSetPvE";
            this.btnEditIOSetPvE.Size = new System.Drawing.Size(160, 44);
            this.btnEditIOSetPvE.TabIndex = 6;
            this.btnEditIOSetPvE.Text = "Invention Set Editor";
            this.btnEditIOSetPvE.UseVisualStyleBackColor = true;
            this.btnEditIOSetPvE.Click += new System.EventHandler(this.btnEditIOSet_Click);
            // 
            // lblCountSalvage
            // 
            this.lblCountSalvage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountSalvage.Location = new System.Drawing.Point(712, 51);
            this.lblCountSalvage.Name = "lblCountSalvage";
            this.lblCountSalvage.Size = new System.Drawing.Size(96, 47);
            this.lblCountSalvage.TabIndex = 20;
            this.lblCountSalvage.Text = "Count";
            this.lblCountSalvage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            this.Label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(712, 2);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(96, 47);
            this.Label6.TabIndex = 19;
            this.Label6.Text = "Salvage";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountRecipe
            // 
            this.lblCountRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountRecipe.Location = new System.Drawing.Point(611, 51);
            this.lblCountRecipe.Name = "lblCountRecipe";
            this.lblCountRecipe.Size = new System.Drawing.Size(93, 47);
            this.lblCountRecipe.TabIndex = 18;
            this.lblCountRecipe.Text = "Count";
            this.lblCountRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            this.Label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(611, 2);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(93, 47);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "Recipes";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountFX
            // 
            this.lblCountFX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountFX.Location = new System.Drawing.Point(510, 51);
            this.lblCountFX.Name = "lblCountFX";
            this.lblCountFX.Size = new System.Drawing.Size(93, 47);
            this.lblCountFX.TabIndex = 16;
            this.lblCountFX.Text = "Count";
            this.lblCountFX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label15
            // 
            this.Label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(510, 2);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(93, 47);
            this.Label15.TabIndex = 15;
            this.Label15.Text = "Power Effects";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountPwr
            // 
            this.lblCountPwr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountPwr.Location = new System.Drawing.Point(409, 51);
            this.lblCountPwr.Name = "lblCountPwr";
            this.lblCountPwr.Size = new System.Drawing.Size(93, 47);
            this.lblCountPwr.TabIndex = 14;
            this.lblCountPwr.Text = "Count";
            this.lblCountPwr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label13
            // 
            this.Label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(409, 2);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(93, 47);
            this.Label13.TabIndex = 13;
            this.Label13.Text = "Powers";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountPS
            // 
            this.lblCountPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountPS.Location = new System.Drawing.Point(308, 51);
            this.lblCountPS.Name = "lblCountPS";
            this.lblCountPS.Size = new System.Drawing.Size(93, 47);
            this.lblCountPS.TabIndex = 12;
            this.lblCountPS.Text = "Count";
            this.lblCountPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label11
            // 
            this.Label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(308, 2);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(93, 47);
            this.Label11.TabIndex = 11;
            this.Label11.Text = "Powersets";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountIOSet
            // 
            this.lblCountIOSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountIOSet.Location = new System.Drawing.Point(207, 51);
            this.lblCountIOSet.Name = "lblCountIOSet";
            this.lblCountIOSet.Size = new System.Drawing.Size(93, 47);
            this.lblCountIOSet.TabIndex = 10;
            this.lblCountIOSet.Text = "Count";
            this.lblCountIOSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label9
            // 
            this.Label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(207, 2);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(93, 47);
            this.Label9.TabIndex = 9;
            this.Label9.Text = "Invention Sets";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountEnh
            // 
            this.lblCountEnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountEnh.Location = new System.Drawing.Point(106, 51);
            this.lblCountEnh.Name = "lblCountEnh";
            this.lblCountEnh.Size = new System.Drawing.Size(93, 47);
            this.lblCountEnh.TabIndex = 8;
            this.lblCountEnh.Text = "Count";
            this.lblCountEnh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label7
            // 
            this.Label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(106, 2);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(93, 47);
            this.Label7.TabIndex = 7;
            this.Label7.Text = "Enhancements";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountAT
            // 
            this.lblCountAT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountAT.Location = new System.Drawing.Point(5, 51);
            this.lblCountAT.Name = "lblCountAT";
            this.lblCountAT.Size = new System.Drawing.Size(93, 47);
            this.lblCountAT.TabIndex = 6;
            this.lblCountAT.Text = "Count";
            this.lblCountAT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(5, 2);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(93, 47);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Classes";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(708, 334);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 31);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSalvage
            // 
            this.btnSalvage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSalvage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvage.Location = new System.Drawing.Point(12, 178);
            this.btnSalvage.Name = "btnSalvage";
            this.btnSalvage.Size = new System.Drawing.Size(160, 44);
            this.btnSalvage.TabIndex = 14;
            this.btnSalvage.Text = "Salvage Editor";
            this.btnSalvage.UseVisualStyleBackColor = true;
            this.btnSalvage.Click += new System.EventHandler(this.btnSalvage_Click);
            // 
            // btnRecipe
            // 
            this.btnRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRecipe.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecipe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRecipe.Location = new System.Drawing.Point(665, 178);
            this.btnRecipe.Name = "btnRecipe";
            this.btnRecipe.Size = new System.Drawing.Size(160, 44);
            this.btnRecipe.TabIndex = 15;
            this.btnRecipe.Text = "Recipe Editor";
            this.btnRecipe.UseVisualStyleBackColor = true;
            this.btnRecipe.Click += new System.EventHandler(this.btnRecipe_Click);
            // 
            // btnEditEntity
            // 
            this.btnEditEntity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditEntity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEntity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditEntity.Location = new System.Drawing.Point(12, 128);
            this.btnEditEntity.Name = "btnEditEntity";
            this.btnEditEntity.Size = new System.Drawing.Size(160, 44);
            this.btnEditEntity.TabIndex = 17;
            this.btnEditEntity.Text = "Entity Editor";
            this.btnEditEntity.UseVisualStyleBackColor = true;
            this.btnEditEntity.Click += new System.EventHandler(this.btnEditEntity_Click);
            // 
            // btnPSBrowse
            // 
            this.btnPSBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPSBrowse.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSBrowse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPSBrowse.Location = new System.Drawing.Point(12, 78);
            this.btnPSBrowse.Name = "btnPSBrowse";
            this.btnPSBrowse.Size = new System.Drawing.Size(160, 44);
            this.btnPSBrowse.TabIndex = 18;
            this.btnPSBrowse.Text = "Power \r\nDatabase Editor";
            this.btnPSBrowse.UseVisualStyleBackColor = true;
            this.btnPSBrowse.Click += new System.EventHandler(this.btnPSBrowse_Click);
            // 
            // Label3
            // 
            this.Label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(409, 2);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(194, 26);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "Database Version";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFileReport
            // 
            this.btnFileReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFileReport.Enabled = false;
            this.btnFileReport.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFileReport.Location = new System.Drawing.Point(12, 334);
            this.btnFileReport.Name = "btnFileReport";
            this.btnFileReport.Size = new System.Drawing.Size(120, 31);
            this.btnFileReport.TabIndex = 23;
            this.btnFileReport.Text = "File Load Report";
            this.btnFileReport.UseVisualStyleBackColor = true;
            this.btnFileReport.Visible = false;
            this.btnFileReport.Click += new System.EventHandler(this.btnFileReport_Click);
            // 
            // exportIndexes
            // 
            this.exportIndexes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exportIndexes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportIndexes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exportIndexes.Location = new System.Drawing.Point(236, 228);
            this.exportIndexes.Name = "exportIndexes";
            this.exportIndexes.Size = new System.Drawing.Size(164, 24);
            this.exportIndexes.TabIndex = 24;
            this.exportIndexes.Text = "Export Power Indexes";
            this.exportIndexes.UseVisualStyleBackColor = true;
            this.exportIndexes.Visible = false;
            // 
            // btnExportJSON
            // 
            this.btnExportJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExportJSON.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportJSON.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExportJSON.Location = new System.Drawing.Point(434, 197);
            this.btnExportJSON.Name = "btnExportJSON";
            this.btnExportJSON.Size = new System.Drawing.Size(150, 24);
            this.btnExportJSON.TabIndex = 26;
            this.btnExportJSON.Text = "JSON Export";
            this.btnExportJSON.UseVisualStyleBackColor = true;
            this.btnExportJSON.Click += new System.EventHandler(this.btnExportJSON_Click);
            // 
            // btnJsonImporter
            // 
            this.btnJsonImporter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnJsonImporter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJsonImporter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnJsonImporter.Location = new System.Drawing.Point(256, 197);
            this.btnJsonImporter.Name = "btnJsonImporter";
            this.btnJsonImporter.Size = new System.Drawing.Size(150, 24);
            this.btnJsonImporter.TabIndex = 27;
            this.btnJsonImporter.Text = "JSON Importer";
            this.btnJsonImporter.UseVisualStyleBackColor = true;
            this.btnJsonImporter.Click += new System.EventHandler(this.btnJsonImporter_Click);
            // 
            // btnAttribModEdit
            // 
            this.btnAttribModEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAttribModEdit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttribModEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAttribModEdit.Location = new System.Drawing.Point(338, 77);
            this.btnAttribModEdit.Name = "btnAttribModEdit";
            this.btnAttribModEdit.Size = new System.Drawing.Size(164, 24);
            this.btnAttribModEdit.TabIndex = 28;
            this.btnAttribModEdit.Text = "AttribMods Editor";
            this.btnAttribModEdit.UseVisualStyleBackColor = true;
            this.btnAttribModEdit.Click += new System.EventHandler(this.btnAttribModEdit_Click);
            // 
            // btnGCMIO
            // 
            this.btnGCMIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGCMIO.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGCMIO.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGCMIO.Location = new System.Drawing.Point(338, 107);
            this.btnGCMIO.Name = "btnGCMIO";
            this.btnGCMIO.Size = new System.Drawing.Size(164, 24);
            this.btnGCMIO.TabIndex = 30;
            this.btnGCMIO.Text = "Global Chance Mod Editor";
            this.btnGCMIO.UseVisualStyleBackColor = true;
            this.btnGCMIO.Visible = false;
            this.btnGCMIO.Click += new System.EventHandler(this.btnGCMIO_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(338, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 24);
            this.button1.TabIndex = 31;
            this.button1.Text = "Restore Entities";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDBConverter
            // 
            this.btnDBConverter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDBConverter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBConverter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDBConverter.Location = new System.Drawing.Point(338, 167);
            this.btnDBConverter.Name = "btnDBConverter";
            this.btnDBConverter.Size = new System.Drawing.Size(164, 24);
            this.btnDBConverter.TabIndex = 32;
            this.btnDBConverter.Text = "Convert 2.x DB to 3.x";
            this.btnDBConverter.UseVisualStyleBackColor = true;
            this.btnDBConverter.Click += new System.EventHandler(this.btnDBConverter_Click);
            // 
            // udPageVol
            // 
            this.udPageVol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.udPageVol.Location = new System.Drawing.Point(207, 33);
            this.udPageVol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPageVol.Name = "udPageVol";
            this.udPageVol.Size = new System.Drawing.Size(194, 20);
            this.udPageVol.TabIndex = 33;
            this.udPageVol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udPageVol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPageVol.ValueChanged += new System.EventHandler(this.udPageVol_ValueChanged);
            this.udPageVol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.udPageVol_KeyPress);
            // 
            // txtPageVol
            // 
            this.txtPageVol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPageVol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPageVol.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPageVol.Location = new System.Drawing.Point(207, 2);
            this.txtPageVol.Name = "txtPageVol";
            this.txtPageVol.Size = new System.Drawing.Size(194, 26);
            this.txtPageVol.TabIndex = 35;
            this.txtPageVol.Text = "Page";
            this.txtPageVol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtPageVol.Click += new System.EventHandler(this.txtPageVol_Click);
            this.txtPageVol.MouseLeave += new System.EventHandler(this.txtPageVol_MouseLeave);
            this.txtPageVol.MouseHover += new System.EventHandler(this.txtPageVol_MouseHover);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.txtDBVer, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.udIssue, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.udPageVol, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPageVol, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDate, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Label3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.02041F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.97959F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(813, 58);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // txtDBVer
            // 
            this.txtDBVer.AutoSize = true;
            this.txtDBVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDBVer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBVer.Location = new System.Drawing.Point(409, 30);
            this.txtDBVer.Name = "txtDBVer";
            this.txtDBVer.Size = new System.Drawing.Size(194, 26);
            this.txtDBVer.TabIndex = 38;
            this.txtDBVer.Text = "2021.1205";
            this.txtDBVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblCountSalvage, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.Label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Label6, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCountAT, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCountRecipe, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.Label7, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Label4, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCountEnh, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCountFX, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.Label9, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Label15, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCountIOSet, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCountPwr, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.Label11, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Label13, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCountPS, 3, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 228);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(813, 100);
            this.tableLayoutPanel2.TabIndex = 38;
            // 
            // frmDBEdit
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(837, 373);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnDBConverter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAttribModEdit);
            this.Controls.Add(this.btnGCMIO);
            this.Controls.Add(this.btnJsonImporter);
            this.Controls.Add(this.btnExportJSON);
            this.Controls.Add(this.btnFileReport);
            this.Controls.Add(this.btnPSBrowse);
            this.Controls.Add(this.btnEditEntity);
            this.Controls.Add(this.btnRecipe);
            this.Controls.Add(this.btnSalvage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEditIOSetPvE);
            this.Controls.Add(this.btnEditEnh);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDBEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Database Editor";
            ((System.ComponentModel.ISupportInitialize)(this.udIssue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPageVol)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        System.Windows.Forms.NumericUpDown udIssue;
        #endregion

        private Button btnExportJSON;
        private Button btnJsonImporter;
        private Button btnGCMIO;
        private Button btnAttribModEdit;
        private Button button1;
        private Button btnDBConverter;
        private NumericUpDown udPageVol;
        private Label txtPageVol;
        private TableLayoutPanel tableLayoutPanel1;
        private Label txtDBVer;
        private TableLayoutPanel tableLayoutPanel2;
    }
}