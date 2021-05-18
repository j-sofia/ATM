using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace ATM
{
    public partial class LoginScreen : Form
    {
        /// <summary>
        /// Converts a list of Users into a DataTable which stores their names
        /// </summary>
        /// <param name="userlist">List of Users</param>
        /// <returns>A DataTable of names</returns>
        private static DataTable ConvertToDatatable(List<User> userlist)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("name");
            foreach (var user in userlist)
            {
                var row = dt.NewRow();
                row["name"] = user.name;
                dt.Rows.Add(row);
            }
            return dt;
        }

        public LoginScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds a user to the list and updates the datagridview
        /// </summary>
        /// <param name="user">User to add to the list</param>
        private void AddUser(User user)
        {
            Program.Users.Add(user);
            dataUsers.DataSource = ConvertToDatatable(Program.Users);
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            dataUsers.DataSource = ConvertToDatatable(Program.Users);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = boxName.Text;
            String welcome_message = boxWelcome.Text;
            decimal default_balance = 0;

            if (String.IsNullOrWhiteSpace(name))
            {
                lblEvent.Text = "Enter a name.";
                return;
            }

            foreach (var existingUser in Program.Users)
            {
                if (existingUser.name == name)
                {
                    lblEvent.Text = "That name is taken.";
                    return;
                }
            }

            AddUser(new User(name, welcome_message, default_balance));
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int rowindex = dataUsers.CurrentCell.RowIndex;
            int columnindex = 0;

            String selectedName = dataUsers.Rows[rowindex].Cells[columnindex].Value.ToString();
            
            //Find the selected name in the user list
            foreach (var existingUser in Program.Users)
            {
                if (existingUser.name == selectedName)
                {
                    //Open a new UserMenu for the user
                    var th = new Thread(() => Application.Run(new UserMenu(existingUser)));
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();

                    this.Close();
                    return;
                }
            }
        }
    }
}
