using System;
using System.Windows.Forms;

namespace DesktopApp
{
    static class Program
    {
        public static bool userAuthentication = true;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
            Application.Run(new Loginform());

            if (userAuthentication)
            {
                Application.Run(new MainWindows());
            }

        }
    }
}
