﻿using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;

namespace MidsReborn.Updater
{
    public partial class UpdateForm : Form
    {
        private BackgroundWorker _updateWorker;
        private FastZipEvents _updateEvents;

        private string UpdatePath { get; set; }
        private string VersionText { get; set; }
        private int ParentPid { get; set; }

        private static Uri UpdateFile { get; set; }
        private static string PackedUpdate { get; set; }

        public UpdateForm(string[] args)
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            UpdatePath = args[0];
            VersionText = args[1];
            ParentPid = int.Parse(args[2]);
            Shown += OnShown;
            InitializeComponent();
        }

        private void OnShown(object sender, EventArgs e)
        {
            Begin_Update();
        }

        private void Begin_Update()
        {
            var client = new WebClient();
            circularProgressBar1.Text = @"Downloading";
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
            var lastSeg = new Uri(UpdatePath).Segments.Last();
            UpdateFile = new Uri($"{UpdatePath.Replace(lastSeg, $"{VersionText}.mru")}");
            PackedUpdate = $"{Application.StartupPath}\\{VersionText}.mru";
            client.DownloadFileAsync(UpdateFile, PackedUpdate);
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                circularProgressBar1.Text = @"Please Wait";
                Task.Delay(2000);
                BeginInstall(true);
            });
        }

        private void BeginInstall(bool completed)
        {
            if (completed) InstallUpdate();
        }

        private void InstallUpdate()
        {
            circularProgressBar1.Text = @"Installing";
            UnpackUpdate();
        }
        
        private void UnpackUpdate()
        {
            _updateWorker = new BackgroundWorker();
            _updateWorker.DoWork += UpdateWorker_DoWork;
            _updateWorker.RunWorkerCompleted += UpdateWorker_RunWorkerCompleted;
            _updateWorker.RunWorkerAsync();
        }

        private void UpdateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            _updateEvents = new FastZipEvents();
            _updateEvents.Progress += Report_Progress;
            var updFile = new FastZip();
            Process.GetProcessById(ParentPid).Kill();
            Process.GetProcessById(ParentPid).WaitForExit();
            updFile.ExtractZip(PackedUpdate, Application.StartupPath, null);
        }

        private void Report_Progress(object sender, ProgressEventArgs e)
        {
            _updateWorker.ReportProgress(Convert.ToInt32(e.PercentComplete));
        }

        private void UpdateWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            circularProgressBar1.Text = @"Complete";
            File.Delete(PackedUpdate);
            Task.Delay(2000);
            circularProgressBar1.Text = @"Relaunching";
            Process.Start($"{Application.StartupPath}\\MidsReborn.exe");
            Application.Exit();
        }
    }
}
