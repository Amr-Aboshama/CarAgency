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
	public partial class TreasuryManager : MetroForm
	{
		public TreasuryManager()
		{
			InitializeComponent();
		}

		private void TreasuryManager_Load(object sender, EventArgs e)
		{

		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			AddTransactionSafe from = new AddTransactionSafe();
			form.Show();
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{
			SafeStatus from = new SafeStatus();
			form.Show();
		}

		private void metroButton5_Click(object sender, EventArgs e)
		{
			ViewSuppliers form = new ViewSuppliers();
			form.Show();
		}

		private void metroButton4_Click(object sender, EventArgs e)
		{
			AddSupplier form = new AddSupplier();
			form.Show();
		}

		private void metroButton3_Click(object sender, EventArgs e)
		{
			ViewSalesAndPurchases form = new ViewSalesAndPurchases();
			form.Show();
		}
	}
}
