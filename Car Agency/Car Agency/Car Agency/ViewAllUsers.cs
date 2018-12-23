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
    public partial class ViewAllUsers : MetroForm
    {
        Controller controllerObj = new Controller();
        public ViewAllUsers()
        {
            InitializeComponent();
            UsersGrid.DataSource = controllerObj.SelectAllUsers();
        }

        private void ViewAllUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
