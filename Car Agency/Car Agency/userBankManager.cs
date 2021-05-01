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
	public partial class userBankManager : MetroForm
	{
		public userBankManager()
		{
			InitializeComponent();
		}

		private void BankManager_Load(object sender, EventArgs e)
		{

		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			addTransactionToBank form = new addTransactionToBank();
			form.Show(this);
			this.Hide();
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{
			viewBank form = new viewBank();
			form.Show(this);
			this.Hide();
		}

		private void metroButton3_Click(object sender, EventArgs e)
		{
			ViewSalesAndPurchases form = new ViewSalesAndPurchases();
			form.Show(this);
			this.Hide();
		}

		private void userBankManager_FormClosed(object sender, FormClosedEventArgs e)
		{
			Owner.Show();
		}
	}
}
