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
	public partial class AdminPanel : MetroForm
	{
		public AdminPanel()
		{
			InitializeComponent();
		}

		private void AdminPanel_Load(object sender, EventArgs e)
		{

		}

		private void metroTile1_Click(object sender, EventArgs e)
		{
            addUser form = new addUser();
            Hide();
            form.Show(this);
		}

		private void metroTile4_Click(object sender, EventArgs e)
		{
			viewUser form = new viewUser();
			form.Show(this);
			this.Hide();
		}

		private void metroTile2_Click(object sender, EventArgs e)
		{
			addEmployee form = new addEmployee();
			form.Show(this);
			this.Hide();
		}

		private void metroTile6_Click(object sender, EventArgs e)
		{
			viewEmployee form = new viewEmployee();
			form.Show(this);
			this.Hide();
		}

		private void metroTile3_Click(object sender, EventArgs e)
		{
			ViewCurrencies form = new ViewCurrencies();
			form.Show(this);
			this.Hide();
		}

		private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
		{
			Owner.Show();
		}

        private void metroTile10_Click(object sender, EventArgs e)
        {
            userBankManager form = new userBankManager();
            form.Show(this);
            this.Hide();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            userCreditManager form = new userCreditManager();
            form.Show(this);
            this.Hide();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            userInventoryManager form = new userInventoryManager();
            form.Show(this);
            this.Hide();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            userSalesMan form = new userSalesMan();
            form.Show(this);
            this.Hide();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            userTreasuryManager form = new userTreasuryManager();
            form.Show(this);
            this.Hide();
        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            ViewAllEmployees form = new ViewAllEmployees();
            form.Show(this);
            this.Hide();
        }

        private void metroTile13_Click(object sender, EventArgs e)
        {
            ViewAllUsers form = new ViewAllUsers();
            form.Show(this);
            this.Hide();
        }

        private void metroTile14_Click(object sender, EventArgs e)
        {
            ViewAllCars form = new ViewAllCars();
            form.Show(this);
            Hide();
        }

        private void metroTile12_Click(object sender, EventArgs e)
        {
            Statistics form = new Statistics();
            form.Show(this);
            this.Hide();
        }

        private void metroTile15_Click(object sender, EventArgs e)
        {
            userPurchasesManager PM = new userPurchasesManager();
            PM.Show(this);
            Hide();
        }
    }
}
