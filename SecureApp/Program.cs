using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialAid
{
    internal static class Program
    {
        
        // Main function, simply declares a new User superclass and creates an instance of the User Form.

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            User user = new User();

            Application.Run(new UserForm(user));
        }
    }
}
