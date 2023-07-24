namespace IcoCraft
{
    // Delegates go here
    public delegate void CraftHandler(string pngPath, string craftedIconName);

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainFrame());
        }
    }
}