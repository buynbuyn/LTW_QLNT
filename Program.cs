using System.Runtime.InteropServices;

namespace QLNT
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [STAThread]
        static void Main()
        {
            // Bật cửa sổ Console
            AllocConsole();

            ApplicationConfiguration.Initialize();

            fLogin loginForm = new fLogin();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new fMain());
            }
        }
    }
}