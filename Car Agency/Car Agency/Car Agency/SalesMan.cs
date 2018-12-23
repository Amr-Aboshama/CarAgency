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
    public partial class SalesMan : MetroForm
    {
        private string user;
        Controller controllerObj;
        public SalesMan(string username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            user = username;
        }

        //customers form
        private void CustTile_Click(object sender, EventArgs e)
        {
            Customers c = new Customers();
            c.Show();
        }

        //available cars form
        private void CarsTile_Click(object sender, EventArgs e)
        {
            AvailableCars a = new AvailableCars();
            a.Show();
        }

        //request car
        private void ReqTile_Click(object sender, EventArgs e)
        {
            RequestCategory r = new RequestCategory(user);
            r.Show();
        }

        //view category
        private void CatmetroTile1_Click(object sender, EventArgs e)
        {
            ViewCategory w = new ViewCategory(user);
            w.Show();
        }
    }
}
