using System.Configuration;
using System.Globalization;

namespace LocalizaedApp2
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

            var cultureString = ConfigurationManager.AppSettings["DefaultLanguage"];
            if (string.IsNullOrEmpty(cultureString))
                cultureString = "en-GB";

            var culture = CultureInfo.GetCultureInfo(cultureString);

            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            ApplicationConfiguration.Initialize();
            Application.Run(new FMain());
        }
    }
}