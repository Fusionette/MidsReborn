using System.Diagnostics;
using MidsReborn.Base.Base.Master_Classes;
using MidsReborn.Forms;

namespace MidsReborn
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzczMTM1QDMxMzgyZTM0MmUzME9URGZHeHFrdFFwZlhxQnZITjlreGZGek96bldQRGpPSmFDd3VWQ1lBaUU9");
            ApplicationConfiguration.Initialize();
            MidsContext.AssertVersioning();
            if (Debugger.IsAttached || Process.GetCurrentProcess().ProcessName.ToLowerInvariant().Contains("devenv"))
            {
                using frmMain f = new frmMain();
                //using Form1 f = new Form1();
                Application.Run(f);
            }
            else
            {
                try
                {
                    using frmMain f = new frmMain();
                    //using Form1 f1 = new Form1();
                    Application.Run(f);
                }
                catch (Exception ex)
                {
                    var exTarget = ex;
                    while (exTarget?.InnerException != null)
                    {
                        exTarget = ex.InnerException;
                    }

                    if (exTarget != null)
                    {
                        // Zed: add extra info here.
                        var args = Environment.GetCommandLineArgs();
                        if (args.Skip(1).Contains("-debug"))
                        {
                            MessageBox.Show(
                                $"Error: {exTarget.Message}\r\nException type: {exTarget.GetType().Name}\r\nStack Trace:\r\n{exTarget.StackTrace}",
                                $"Error [Debug mode] [Mids Reborn v{Application.ProductVersion}]", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show($"Error: {exTarget.Message}\r\n{exTarget.StackTrace}",
                                exTarget.GetType().Name,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        throw;
                    }
                }
            }
        }
    }
}