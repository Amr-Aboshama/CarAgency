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
	public partial class ViewSalesAndPurchases : MetroForm
	{
		Controller controllerObj;
		
		DataTable sales;
		DataTable purchases;

		public ViewSalesAndPurchases()
		{
			InitializeComponent();

			controllerObj = new Controller();
		}

		private void ViewSalesAndPurchases_Load(object sender, EventArgs e)
		{
			updateSales();
			updatePurchases();
		}

		private void updateSales()
		{
			sales = controllerObj.selectSales(metroCheckBox1.Checked);

			dataGridView1.DataSource = sales;

			dataGridView1.Columns["key"].Visible = false;
		}

		private void updatePurchases()
		{
			purchases = controllerObj.selectPurchases(metroCheckBox2.Checked);

			dataGridView2.DataSource = purchases;

			dataGridView2.Columns["key"].Visible = false;
		}

		private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			updateSales();
		}

		private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			updatePurchases();
		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			if (dataGridView1.Rows.Count > 0)
			{
				SPDetails form = new SPDetails(true, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
				form.Show(this);
                Hide();
			}
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{
			if (dataGridView2.Rows.Count > 0)
			{
				SPDetails form = new SPDetails(false, Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));
				form.Show(this);
                Hide();
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			metroButton1_Click(sender, e);
		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			metroButton2_Click(sender, e);
		}

        private void ViewSalesAndPurchases_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
