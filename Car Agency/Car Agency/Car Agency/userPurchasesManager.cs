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
	public partial class userPurchasesManager : MetroForm
	{
		public userPurchasesManager()
		{
			InitializeComponent();
		}

		private void userPurchasesManaher_Load(object sender, EventArgs e)
		{

		}

		private void metroTile1_Click(object sender, EventArgs e)
		{
			ViewSuppliers form = new ViewSuppliers();
			form.Show(this);
			this.Hide();
		}

		private void metroTile2_Click(object sender, EventArgs e)
		{
			purchaseCar form = new purchaseCar();
			form.Show(this);
			this.Hide();
		}

		private void metroTile4_Click(object sender, EventArgs e)
		{
			viewCategory form = new viewCategory();
			form.Show(this);
			this.Hide();
		}

		private void metroTile3_Click(object sender, EventArgs e)
		{
			AvailableCars form = new AvailableCars();
			form.Show(this);
			this.Hide();
		}

		private void userPurchasesManager_FormClosed(object sender, FormClosedEventArgs e)
		{
			Owner.Show();
		}
	}
}
