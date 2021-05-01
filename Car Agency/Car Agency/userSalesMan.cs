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
    public partial class userSalesMan : MetroForm
    {
        private string user;
        Controller controllerObj;
        public userSalesMan()
        {
            InitializeComponent();
            controllerObj = new Controller();
            user = Login.LoginUsername;
        }

        //customers form
        private void CustTile_Click(object sender, EventArgs e)
        {
            Customers c = new Customers();
            c.Show(this);
			this.Hide();
        }

        //available cars form
        private void CarsTile_Click(object sender, EventArgs e)
        {
            AvailableCars a = new AvailableCars();
            a.Show(this);
			this.Hide();
        }

        //request car
        private void ReqTile_Click(object sender, EventArgs e)
        {
            RequestCategory r = new RequestCategory();
            r.Show(this);
			this.Hide();
        }

        //view category
        private void CatmetroTile1_Click(object sender, EventArgs e)
        {
            ViewCategory w = new ViewCategory();
            w.Show(this);
			this.Hide();
        }

		private void userSalesMan_Load(object sender, EventArgs e)
		{

		}

		private void userSalesMan_FormClosed(object sender, FormClosedEventArgs e)
		{
			Owner.Show();
		}
	}
}
