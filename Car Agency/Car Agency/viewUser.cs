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

namespace Car_Agency
{
    public partial class viewUser : MetroForm
    {
        Controller controllerObj;
        bool init;
        string defaultJob = "--All--";
        public viewUser()
        {
            InitializeComponent();
            controllerObj = new Controller();
            load();
        }

        public void load()
        {
            // Active initialization state
            init = true;

            // Load all users
            DataTable dt = controllerObj.getAllUsers();
            username.DataSource = dt;
            username.DisplayMember = "Username";
            username.ValueMember = "Username";
            username.SelectedValue = 0;

            metroLabel2.Visible = false;
            metroLabel3.Visible = false;
            metroLabel4.Visible = false;
            metroLabel5.Visible = false;
            metroLabel6.Visible = false;
            EditMode.Visible = false;
            Apply.Visible = false;
            RemoveUser.Visible = false;
            inputUsername.Visible = false;
            password.Visible = false;
            repassword.Visible = false;
            employee.Visible = false;
            privileges.Visible = false;

            username.Refresh();

            // Inactive Initialization state
            init = false;
        }

        private void username_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If in active initialization state don't make any changes
            if (init) return;
            metroLabel2.Visible = metroLabel3.Visible = metroLabel4.Visible = metroLabel5.Visible = 
                metroLabel6.Visible = true;

            EditMode.Visible = Apply.Visible = RemoveUser.Visible = true;

            inputUsername.Visible = password.Visible = repassword.Visible = employee.Visible = 
                privileges.Visible = true;

            inputUsername.Enabled = password.Enabled = repassword.Enabled = employee.Enabled = 
                privileges.Enabled = false;

            Apply.Enabled = false;

            password.Clear();
            repassword.Clear();

            // Load Username
            inputUsername.Text = username.SelectedValue.ToString();

            // Load all Employees making the selected one is the user employee
            DataTable dt = controllerObj.getAllEmployees();
            employee.DataSource = dt;
            employee.DisplayMember = "Name";
            employee.ValueMember = "EmpNatID";
            employee.SelectedValue = controllerObj.getUserData(username.SelectedValue.ToString()).Rows[0][2];

            
            privileges.Clear();
            dt = controllerObj.getAllJobs();
            if (dt != null)
            {
                // Load all privileges
                foreach (DataRow R in dt.Rows)
                    if (R[0].ToString() != defaultJob)
                        privileges.Items.Add(R[0].ToString());


                // Check the current user privileges
                dt = controllerObj.getUserPrivileges(username.SelectedValue.ToString());
                foreach (DataRow R in dt.Rows)
                {
                    foreach (ListViewItem I in privileges.Items)
                        if (I.Text == R[0].ToString()) I.Checked = true;
                }
            }
        }

        private void RemoveUser_Click(object sender, EventArgs e)
        {
            // Check for removing user confirmation
            if (MessageBox.Show("Do you really want to remove User: " +username.SelectedValue.ToString()
                + " Permenantly?", "Confirmation Message", MessageBoxButtons.YesNo).ToString() == "No") return;
            try
            {
                // Remove User
                controllerObj.removeUser(username.SelectedValue.ToString());
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
            MessageBox.Show("User removed Successfully!");
            load();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            string user = username.SelectedValue.ToString();
            try
            {

                bool charflag = false;

                // Check for Missed Data
                if (inputUsername.Text.Length == 0)
                {
                    MessageBox.Show("Please Insert a username");
                    return;
                }

                // Check username validiation (only digits,alphabetical characters and _)
                foreach (char s in inputUsername.Text)
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

                // Check if the new username exists already
                if (user != inputUsername.Text && controllerObj.isUsernameExists(inputUsername.Text))
                {
                    MessageBox.Show("This username exists already");
                    return;
                }

                // Check for trying to change password
                if (password.Text.Length != 0 || repassword.Text.Length != 0)
                {
                    if (password.Text == repassword.Text)
                    {
                        // Check password size must be >= 6
                        if (password.Text.Length<6)
                        {
                            MessageBox.Show("Please insert a password with at least 6 characters");
                            return;
                        }
                        // valid password
                        controllerObj.setUserPassword(user, password.Text);
                    }
                        
                    else if (password.Text.Length == 0)
                    {
                        MessageBox.Show("Please Enter a Valid Password");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Passwords are not matching!");
                        return;
                    }
                }

                DataTable dt = controllerObj.getUserData(user);

                // Change Employee if new Employee is choosen
                if (employee.SelectedValue != dt.Rows[0][2])
                    controllerObj.setUserEmp(user, (decimal)employee.SelectedValue);

                dt = controllerObj.getUserPrivileges(user);
                // nL -> New Checked Privileges
                // oL -> Old Checked Privileges
                List<string> nL = privileges.CheckedItems.Cast<ListViewItem>().Select(item => item.Text).ToList();
                List<string> oL = dt.Rows.OfType<DataRow>().Select(rw => rw.Field<string>("JobName")).ToList();


                // Remove unchecked privileges
                foreach (string s in oL)
                    if (!nL.Contains(s)) controllerObj.removeUserPriv(user, s);

                // Add checked privileges
                foreach (string s in nL)
                    if (!oL.Contains(s)) controllerObj.addUserPriv(user, s);

                controllerObj.ChangeUsername(username.SelectedValue.ToString(), inputUsername.Text);

                MessageBox.Show("Changes Applied Successfully!");
                password.Clear();
                repassword.Clear();
                load();
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void EditMode_Click(object sender, EventArgs e)
        {
            // Enable Fields to user to edit
            inputUsername.Enabled = true;
            password.Enabled = true;
            repassword.Enabled = true;
            employee.Enabled = true;
            privileges.Enabled = true;
            Apply.Enabled = true;
        }

        private void viewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
