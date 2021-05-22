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

            this.Display_Welcome();
            this.Display_Balance();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            this.ActiveControl = rboxAmount;
        }

        private void Display_Welcome()
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
        private void Display_Event(String eve)
        {
            this.lblEvent.Text = eve;
        }

        /// <summary>
        /// Sets the balance text box to user.balance
        /// </summary>
        private void Display_Balance()
        {
            this.boxBal.Text = "$" + user.balance.ToString("0.00");
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            decimal amount;
            try
            {
                amount = decimal.Parse(rboxAmount.Text.Remove(0, 1));
            }
            catch (Exception exception)
            {
                if (exception is OverflowException)
                {
                    Display_Event("Where are you going to find that money?");
                }
                else if (exception is FormatException)
                {
                    Display_Event("What is " + rboxAmount.Text + "?");
                }
                return;
            }

            int retval = user.deposit(amount);
            if (retval == User.ERROR)
            {
                Display_Event("Can't deposit " + rboxAmount.Text);
            }
            if (retval == User.OK)
            {
                Display_Balance();
                Display_Event("Deposited $" + amount.ToString("0.00"));
            } else
            {
                Display_Event("Can't deposit " + rboxAmount.Text);
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal amount;
            try
            {
                amount = decimal.Parse(rboxAmount.Text.Remove(0, 1));
            }
            catch (Exception exception)
            {
                if (exception is OverflowException)
                {
                    Display_Event("Where are you going to find that money?");
                }
                else if (exception is FormatException)
                {
                    Display_Event("What is " + rboxAmount.Text + "?");
                }
                return;
            }

            int retval = user.deposit(amount);
            if (retval == User.ERROR)
            {
                Display_Event("Can't deposit " + rboxAmount.Text);
            }
            if (retval == User.OK)
            {
                Display_Balance();
                Display_Event("Deposited $" + amount.ToString("0.00"));
            }
            else
            {
                Display_Event("Can't deposit " + rboxAmount.Text);
            }


            decimal amount;
            try
            {
                amount = Program.RoundDown(decimal.Parse(rboxAmount.Text.Remove(0, 1)), 2);
            }
            catch (Exception exception)
            {
                if (exception is OverflowException)
                {
                    Display_Event("What are you trying to go bankrupt?");
                }
                else if (exception is FormatException)
                {
                    Display_Event("What is " + rboxAmount.Text + "?");
                }
                return;
            }

            if (amount > 0 && user.withdraw(amount))
            {
                Display_Balance();
                Display_Event("Withdrew $" + amount.ToString("0.00"));
            }
            else
            {
                Display_Event("Can't withdraw " + rboxAmount.Text);
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
