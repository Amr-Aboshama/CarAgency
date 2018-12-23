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
	public partial class ViewSuppliers : MetroForm
	{
		Controller controllerObj;

		public ViewSuppliers()
		{
			InitializeComponent();

			controllerObj = new Controller();
		}

		private void AllSuppliers_Load(object sender, EventArgs e)
		{
			DataTable dt = controllerObj.selectAllSuppliers();
			dataGridView1.DataSource = dt;
		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			AddSupplier newSupplier = new AddSupplier();
			newSupplier.Show(this);
            Hide();
		}

        private void ViewSuppliers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
