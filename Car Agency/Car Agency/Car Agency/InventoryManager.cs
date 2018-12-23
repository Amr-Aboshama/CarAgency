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
	public partial class InventoryManager : MetroForm
	{
		public InventoryManager()
		{
			InitializeComponent();
		}

		private void InventoryManager_Load(object sender, EventArgs e)
		{

		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			viewPurchasedCars form = new viewPurchasedCars();
			form.Show();
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{
			addCartoStore form = new addCartoStore();
			form.Show();
		}
	}
}
