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
    public partial class showPrivileges : MetroForm
    {
        Controller controllerObj;
        string Username;
        public showPrivileges(string User)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Username = User;
        }

        private void showPrivileges_Load(object sender, EventArgs e)
        {
            privileges.DataSource = controllerObj.getUserPrivileges(Username);
            privileges.DisplayMember = privileges.ValueMember = "JobName";
            privileges.SelectedValue = "";
        }

        private void showPropertiesButton_Click(object sender, EventArgs e)
        {
            if (privileges.SelectedValue == null)
            {
                MessageBox.Show("Please Select a Privilege");
                return;
            }
            /*
             * // To Open the proper window for a privilege
            switch(privileges.SelectedValue.ToString())
            {
                
            }
            */
        }

        private void showPrivileges_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}