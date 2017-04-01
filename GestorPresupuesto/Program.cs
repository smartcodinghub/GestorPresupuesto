using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Diagnostics;
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
        static void Main()
        {
            if (ApplicationDeployment.IsNetworkDeployed && ApplicationDeployment.CurrentDeployment.IsFirstRun && IsUserAdministrator())
                RunNgen();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }

        [PrincipalPermission(SecurityAction.Demand, Role = @"BUILTIN\Administrators")]
        public static void RunNgen()
        {
            string appPath = Application.StartupPath;
            string winPath = Environment.GetEnvironmentVariable("WINDIR");

            Process proc = new Process();
            System.IO.Directory.SetCurrentDirectory(appPath);

            proc.EnableRaisingEvents = false;
            proc.StartInfo.CreateNoWindow = false;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            proc.StartInfo.FileName = winPath + @"\Microsoft.NET\Framework\v4.0.30319\ngen.exe";
            proc.StartInfo.Arguments = "install " + Application.ProductName + " /nologo /silent";

            proc.Start();
            proc.WaitForExit();
        }

        public static bool IsUserAdministrator()
        {
            bool isAdmin;

            using (WindowsIdentity user = WindowsIdentity.GetCurrent())
            {
                try
                {
                    WindowsPrincipal principal = new WindowsPrincipal(user);
                    isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
                }
                catch (Exception ex) { isAdmin = false; }
            }

            return isAdmin;
        }
    }
}
