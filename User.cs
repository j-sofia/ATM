using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class User
    {
        public String name { get; set; }
        public String welcome_message { get; set; }
        public decimal balance { get; set; }

        public const int OK = 0;
        public const int ERROR = 1;

        public User(String Name, String Welcome_message, decimal Balance)
        {
            name = Name;
            welcome_message = Welcome_message;
            balance = Balance;
        }

        public int deposit(decimal amount)
        {
            try
            {
                amount = Program.RoundDown(amount, 2);
            }
            catch (Exception)
            {
                return ERROR;
            }
            if (amount < 0) return ERROR;
            balance += amount;
            return OK;
        }

        public int withdraw(decimal amount)
        {
            try
            {
                amount = Program.RoundDown(amount, 2);
            }
            catch (Exception)
            {
                return ERROR;
            }
            if (amount < 0) return ERROR;
            balance -= amount;
            return OK;
        }
    }
}
