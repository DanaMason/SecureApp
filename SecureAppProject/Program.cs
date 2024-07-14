using System.Security.Cryptography;
using System.Security.Cryptography.Xml;

namespace SecureAppProject
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
            ApplicationConfiguration.Initialize();
            Application.Run(new PasswordCollection());
        }
    }
}

// Now must do things like establish a sign up user thing for creating Username-Password combinations, as well as
// Multi-factor authentication, 