using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Base.Master_Classes;
using Hero_Designer.Forms;

namespace Hero_Designer
{
    static class Program
    {
        [DllImport("Shcore.dll")]
        static extern int SetProcessDpiAwareness(int PROCESS_DPI_AWARENESS);
        private enum DpiAwareness
        {
            None = 0,
            SystemAware = 1,
            PerMonitorAware = 2
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetProcessDpiAwareness((int)DpiAwareness.PerMonitorAware);
            try
            {
                MidsContext.AssertVersioning();
                //Application.Run(new frmMain());
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                var exTarget = ex;
                while (exTarget?.InnerException != null)
                {
                    exTarget = ex.InnerException;
                }

                if (exTarget != null)
                    MessageBox.Show(exTarget.Message, exTarget.GetType().Name);
                throw;
            }
        }
    }
}
