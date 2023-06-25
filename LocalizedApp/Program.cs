using System.Configuration;
using System.Globalization;

namespace LocalizedApp
{
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

            var appConfigValue = ConfigurationManager.AppSettings["DefaultCulture"];
            CultureInfo culture = new CultureInfo(appConfigValue);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            ApplicationConfiguration.Initialize();
            Application.Run(new FMain());
        }
    }
}