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

        public User (String Name, String Welcome_message, decimal Balance)
        {
            name = Name;
            welcome_message = Welcome_message;
            balance = Balance;
        }

        public bool deposit(decimal amount)
        {
            if (amount <= 0)  return false;

            try
            {
                balance += amount;
            } catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool withdraw(decimal amount)
        {
            if (amount <= 0 || balance - amount < 0) return false;

            try
            {
                balance -= amount;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
