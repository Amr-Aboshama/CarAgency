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
	public partial class BankManager : MetroForm
	{
		public BankManager()
		{
			InitializeComponent();
		}

		private void BankManager_Load(object sender, EventArgs e)
		{

		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			AddTransactionBank from = new AddTransactionBank();
			form.Show();
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{
			BanksStatus from = new BanksStatus();
			form.Show();
		}

		private void metroButton3_Click(object sender, EventArgs e)
		{
			ViewSalesAndPurchases form = new ViewSalesAndPurchases();
			form.Show();
		}
	}
}
