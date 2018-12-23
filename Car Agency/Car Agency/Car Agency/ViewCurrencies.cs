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
	public partial class ViewCurrencies : MetroForm
	{
		Controller controllerObj;

		DataTable currency;

		public ViewCurrencies()
		{
			InitializeComponent();

			controllerObj = new Controller();
		}

		private void ViewCurrencies_Load(object sender, EventArgs e)
		{
			update();
		}

		private void update()
		{
			currency = controllerObj.selectAllCurrencies();
			dataGridView1.DataSource = currency;
		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			decimal price;
			if (metroTextBox1.Text.Length > 3 || !decimal.TryParse(metroTextBox2.Text, out price))
			{
				MessageBox.Show("Error: Enter Correct Values!\nCode should be 3 characters long");
			}
			else
			{
				if (controllerObj.addCurrency(metroTextBox1.Text, price)==0)
				{
					MessageBox.Show("Error: Currency Not Added!");
				}
				else
				{
					MessageBox.Show("Currency Added Successfully!");
					update();
				}
			}
			metroTextBox1.Clear();
			metroTextBox2.Clear();
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{
			string code = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);

			if (controllerObj.removeCurrency(code) == 0)
			{
				MessageBox.Show("Error: Currency Not Removed!");
			}
			else
			{
				MessageBox.Show("Currency Removed Successfully!");
				update();
			}
		}

        private void ViewCurrencies_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
