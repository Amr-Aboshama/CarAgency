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
	public partial class AddSupplier : MetroForm
	{
		Controller controllerObj;

		public AddSupplier()
		{
			InitializeComponent();

			controllerObj = new Controller();
		}

		private void AddSuppliers_Load(object sender, EventArgs e)
		{

		}

		private void metroButton1_Click_1(object sender, EventArgs e)
		{
			UInt64 id;

			if (metroTextBox1.Text == "" || metroTextBox2.Text == "" || metroTextBox3.Text == "" || !UInt64.TryParse(metroTextBox2.Text, out id))
			{
				MessageBox.Show("Enter all values correcrtly");
				return;
			}

			int result = controllerObj.insertSupplier(metroTextBox1.Text, id, metroTextBox3.Text, metroTextBox5.Text, metroTextBox4.Text, metroTextBox6.Text);
			if (result != 0)
				MessageBox.Show("Supplier added successfully!");
			else
				MessageBox.Show("Error: Supplier was not added!");

			metroTextBox1.Clear();
			metroTextBox2.Clear();
			metroTextBox3.Clear();
			metroTextBox4.Clear();
			metroTextBox5.Clear();
			metroTextBox6.Clear();
		}

        private void AddSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
