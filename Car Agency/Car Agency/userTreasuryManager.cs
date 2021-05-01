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
	public partial class userTreasuryManager : MetroForm
	{
		public userTreasuryManager()
		{
			InitializeComponent();
		}

		private void TreasuryManager_Load(object sender, EventArgs e)
		{

		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			addTransactionToSafe form = new addTransactionToSafe();
			form.Show(this);
			this.Hide();
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{
			viewSafe form = new viewSafe();
			form.Show(this);
			this.Hide();
		}

		private void metroButton5_Click(object sender, EventArgs e)
		{
			ViewSuppliers form = new ViewSuppliers();
			form.Show(this);
			this.Hide();
		}

		private void metroButton4_Click(object sender, EventArgs e)
		{
			AddSupplier form = new AddSupplier();
			form.Show(this);
			this.Hide();
		}

		private void metroButton3_Click(object sender, EventArgs e)
		{
			ViewSalesAndPurchases form = new ViewSalesAndPurchases();
			form.Show(this);
			this.Hide();
		}

		private void userTreasuryManager_FormClosed(object sender, FormClosedEventArgs e)
		{
			Owner.Show();
		}
	}
}
