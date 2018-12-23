using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Security.Cryptography;

namespace Car_Agency
{
    public partial class addUser : MetroForm
    {
        Controller controllerObj;
        public addUser()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void addUser_Load(object sender, EventArgs e)
        {
            string defaultJob = "--All--";
            privileges.Clear();
            DataTable dt = controllerObj.getAllJobs();
            foreach (DataRow R in dt.Rows)
                if (R[0].ToString() != defaultJob)
                    privileges.Items.Add(R[0].ToString());


            dt = controllerObj.getAllEmployees();
            employee.DataSource = dt;
            employee.DisplayMember = "Name";
            employee.ValueMember = "EmpNatID";
            employee.SelectedValue = 0;

            privileges.Refresh();
            employee.Refresh();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {

            bool charflag = false;

            // Check for Missed Data
            if(username.Text.Length==0 || password.Text.Length==0 || repassword.Text.Length==0)
            {
                MessageBox.Show("Please Fill the missing data!");
                return;
            }

            // Check username validiation (only digits,alphabetical characters and _)
            foreach (char s in username.Text)
            {
                if ((s < 'a' || s > 'z') && (s < '0' || s > '9') && s != '_')
                {
                    MessageBox.Show("Please enter a valid Username contains only (a~z,0~9,_)");
                    return;
                }
                if ((s >= 'a' && s <= 'z') || (s >= 'A' && s <= 'Z')) charflag = true;
            }

            // Check for Username having at least a alphabetical character
            if (!charflag)
            {
                MessageBox.Show("Username must have at least one alphabetical character");
                return;
            }

            // Check if username exists
            if (controllerObj.isUsernameExists(username.Text))
            {
                MessageBox.Show("This Username exists already!");
                return;
            }

            // Check for passwords mismatch
            if (password.Text!=repassword.Text)
            {
                MessageBox.Show("Passwords are not matching!");
                password.Clear();
                repassword.Clear();
                return;
            }

            // Check for selecting an employee
            if (employee.SelectedValue == null)
            {
                MessageBox.Show("Please Select an Employee");
                return;
            }


            // Check for selected privileges
            if (privileges.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please Choose at least a privilege for the user");
                return;
            }

            // Check password size must be >= 6
            if (password.Text.Length < 6)
            {
                MessageBox.Show("Please insert a password with at least 6 characters");
                return;
            }

            try
            {
                // Add user
                controllerObj.addUser(username.Text, password.Text, (decimal)employee.SelectedValue);

                // get Checked Privileges
                List<string> checkedItems = privileges.CheckedItems.Cast<ListViewItem>().Select(item => item.Text).ToList();
            
                DataTable dt = controllerObj.getAllJobs();
                foreach(DataRow R in dt.Rows)
                {
                    if (checkedItems.Contains(R[0]))
                    {
                        try
                        {
                            // Add User Privileges
                            controllerObj.addUserPriv(username.Text, (string)R[0]);
                        }
                        catch(Exception E2)
                        {
                            MessageBox.Show(E2.Message);
                            return;
                        }
                    }
                }
                password.Clear();
                repassword.Clear();
                username.Clear();
                employee.SelectedValue = 0;
                foreach (ListViewItem i in privileges.CheckedItems)
                    i.Checked = false;
            }
            catch(Exception E1)
            {
                MessageBox.Show(E1.Message);
                return;
            }
            MessageBox.Show("User added Successfully!");
        }

        private void addUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
