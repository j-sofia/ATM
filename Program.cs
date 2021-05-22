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

        /// <summary>
        /// Rounds a decimal number DOWN (floor) to the nearest place
        /// </summary>
        /// <param name="num">Decimal number to round</param>
        /// <param name="decimalPlaces">How many places to round to</param>
        public static decimal RoundDown(decimal num, int decimalPlaces)
        {
            Decimal power;
            try
            {
                power = Convert.ToDecimal(Math.Pow(10, decimalPlaces));
                return Math.Floor(num * power) / power;
            }
            catch (Exception)
            {
                return Math.Round(num, decimalPlaces);
            }

        }
    }
}
