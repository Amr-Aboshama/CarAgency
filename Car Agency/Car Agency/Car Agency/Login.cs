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
    public partial class Login : MetroForm
    {
        Controller controllerObj;
        public Login()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!controllerObj.isUserMatchPassword(username.Text, password.Text))
            {
                MessageBox.Show("Username and Password are not matching");
                password.Clear();
                return;
            }
            showPanel Pr = new showPanel(username.Text);
            Pr.Show(this);
            username.Clear();
            password.Clear();
            Hide();
        }
    }
}
