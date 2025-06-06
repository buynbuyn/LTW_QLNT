namespace QLNT
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            fLogin loginForm = new fLogin();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new fMain());
            }
        }
    }
}