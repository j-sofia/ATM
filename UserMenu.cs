using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class UserMenu : Form
    {
        User user;

        public UserMenu(User User)
        {
            user = User;
            InitializeComponent();
            this.rboxAmount.Select(0, (rboxAmount.Text = "$").Length);
            this.rboxAmount.SelectionProtected = true;
            this.rboxAmount.AppendText(System.Environment.NewLine);

            this.Set_Welcome();
            this.Set_Balance();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            this.ActiveControl = rboxAmount;
        }

        private void Set_Welcome()
        {
            if (String.IsNullOrWhiteSpace(user.welcome_message))
            {
                this.lblWelcome.Text = "Welcome, " + user.name + ".";
            }
            else
            {
                this.lblWelcome.Text = user.welcome_message;
            }
        }

        /// <summary>
        /// Sets the event text, example "Deposited $10.00."
        /// </summary>
        /// <param name="eve">String to display</param>
        private void Set_Event(String eve)
        {
            this.lblEvent.Text = eve;
        }

        /// <summary>
        /// Sets the balance text box to user.balance
        /// </summary>
        private void Set_Balance()
        {
            this.boxBal.Text = "$" + user.balance.ToString("0.00");
        }

        /// <summary>
        /// Rounds a decimal number DOWN (floor) to the nearest place
        /// </summary>
        /// <param name="num">Decimal number to round</param>
        /// <param name="decimalPlaces">How many places to round to</param>
        private static decimal RoundDown(decimal num, int decimalPlaces)
        {
            Decimal power;
            try
            {
                power = Convert.ToDecimal(Math.Pow(10, decimalPlaces));
                return Math.Floor(num * power) / power;
            } catch (Exception)
            {
                return Math.Round(num, decimalPlaces);
            }
            
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            decimal amount;
            try
            {
                amount = RoundDown(decimal.Parse(rboxAmount.Text.Remove(0, 1)), 2);
            }
            catch (Exception exception)
            {
                if (exception is OverflowException)
                {
                    Set_Event("Get real, you're not that rich.");
                }
                else if (exception is FormatException)
                {
                    Set_Event("What is " + rboxAmount.Text + "?");
                }
                return;
            }

            if (amount > 0 && user.deposit(amount))
            {
                Set_Balance();
                Set_Event("Deposited $" + amount.ToString("0.00"));
            } else
            {
                Set_Event("Can't deposit " + rboxAmount.Text);
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal amount;
            try
            {
                amount = RoundDown(decimal.Parse(rboxAmount.Text.Remove(0, 1)), 2);
            }
            catch (Exception exception)
            {
                if (exception is OverflowException)
                {
                    Set_Event("What are you trying to go bankrupt?");
                }
                else if (exception is FormatException)
                {
                    Set_Event("What is " + rboxAmount.Text + "?");
                }
                return;
            }

            if (amount > 0 && user.withdraw(amount))
            {
                Set_Balance();
                Set_Event("Withdrew $" + amount.ToString("0.00"));
            }
            else
            {
                Set_Event("Can't withdraw " + rboxAmount.Text);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var m = new LoginScreen();
            m.Show();
            this.Hide();
        }
    }
}
