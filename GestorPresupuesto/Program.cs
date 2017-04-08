using GestorPresupuesto.Controller;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorPresupuesto
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            try
            {
                if ((ApplicationDeployment.IsNetworkDeployed && ApplicationDeployment.CurrentDeployment.IsFirstRun)
                    || (args != null && args.Contains("-ngen")))
                {
                    RunNgen();
                }
            }
            catch (Exception ex) { }

            /* Tasks */
            TelegramTask task = new TelegramTask();
            task.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }

        public static void RunNgen()
        {
            String appPath = Application.StartupPath;
            String winPath = Environment.GetEnvironmentVariable("WINDIR");

            Process proc = new Process();
            System.IO.Directory.SetCurrentDirectory(appPath);

            proc.EnableRaisingEvents = false;
            proc.StartInfo.CreateNoWindow = false;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.StartInfo.Verb = "runas";
            proc.StartInfo.UseShellExecute = true;

            proc.StartInfo.FileName = winPath + @"\Microsoft.NET\Framework\v4.0.30319\ngen.exe";
            proc.StartInfo.Arguments = "install " + Application.ProductName + ".exe /nologo /silent";

            proc.Start();
            proc.WaitForExit();
        }
    }
}
