using System.Security.Cryptography;
using System.Security.Cryptography.Xml;

namespace SecureAppProject
{
    internal static class Program
    {
        // Application to demonstrate common security measures that applications and software should demonstrate.
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}

// Error Handling, POTENTIALLY logging, development of app
// Looking into how to implement HTTPS and POTENTIALLY Website attack preventions is also worthwhile to look at.
// Having a problem where inputting two back to back users results in the first one entered being overwritten. 
// Additionally, Error when no file exists and you try signing up.
// Need bank account balance to be added for development of app.