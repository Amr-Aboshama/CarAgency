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
	public partial class SPDetails : MetroForm
	{
		Controller controllerObj;

		string job;

		bool isSale;
		int id;
        decimal eID;


        public SPDetails(bool isSale, int id)
		{
			InitializeComponent();

			controllerObj = new Controller();

			this.isSale = isSale;
			this.id = id;

			if (!isSale)
			{
				this.Text = "Purchase Details";
				groupBox3.Text = "Supplier";
			}

			bool state = controllerObj.isApproved(isSale, id);

			if (state)
			{
				metroButton1.Enabled = false;
				metroButton1.Hide();

				metroButton2.Enabled = false;
				metroButton2.Hide();
			}

			eID = controllerObj.getEmpIDByUser(Login.LoginUsername);

			job = controllerObj.getEmpJob(eID);

			
			 if (String.Equals(job, "Treasury Manager", StringComparison.OrdinalIgnoreCase))
			{
				DataTable dt = controllerObj.getTreasuries(2);
				metroComboBox1.DataSource = dt;
				metroComboBox1.ValueMember = "TreasuryID";
				metroComboBox1.DisplayMember = "Name";
			}
			else if (String.Equals(job, "Bank Manager", StringComparison.OrdinalIgnoreCase))
			{
				DataTable dt = controllerObj.getTreasuries(1);
				metroComboBox1.DataSource = dt;
				metroComboBox1.ValueMember = "TreasuryID";
				metroComboBox1.DisplayMember = "Name";
			}
			
		}

		private void SPDetails_Load(object sender, EventArgs e)
		{
			DataTable[] dt;

			if (!isSale)
			{
				groupBox4.Text = "Employee";
				groupBox5.Visible = false;

				dt = controllerObj.selectPurchaseInfo(id);

				dataGridView1.DataSource = dt[0];
				dataGridView2.DataSource = dt[1];
				dataGridView3.DataSource = dt[2];
				dataGridView4.DataSource = dt[3];
			}
			else
			{
				dt = controllerObj.selectSaleInfo(id);

				dataGridView1.DataSource = dt[0];
				dataGridView2.DataSource = dt[1];
				dataGridView3.DataSource = dt[2];
				dataGridView4.DataSource = dt[3];
				dataGridView5.DataSource = dt[4];
			}
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{
			if (controllerObj.addTransaction(eID,(int)metroComboBox1.SelectedValue) != 0)
			{
				MessageBox.Show("Transaction Added Successfully");
			}
			else
			{
				MessageBox.Show("Transaction Not Added!");
			}
		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			controllerObj.deleteSaleorPurchase(isSale, id);
			this.Close();
		}

        private void SPDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
