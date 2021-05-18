using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    static class Program
    {
        public static List<User> Users { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Users = new List<User>();
            Users.Add(new User("admin", "Welcome, admin. Log out to go to the admin panel.", 0));
            Users.Add(new User("Bob", "Hey Bob, what's up my man?", 1000000));

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginScreen());
        }
    }
}
