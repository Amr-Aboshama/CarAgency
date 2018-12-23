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
	public partial class ViewCallRecords : MetroForm
	{
		Controller controllerObj;

		public ViewCallRecords()
		{
			InitializeComponent();

			controllerObj = new Controller();

			DataTable dt = controllerObj.selectRecords();

			dataGridView1.DataSource = dt;

			dataGridView1.Columns["notes"].Visible = false;
		}

		private void ViewCallRecords_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			metroTextBox1.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
		}

        private void ViewCallRecords_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
