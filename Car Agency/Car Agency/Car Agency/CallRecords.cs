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
	public partial class CallRecords : MetroForm
	{
		Controller controllerObj;

		decimal empID;

		public CallRecords()
		{
			InitializeComponent();

			controllerObj = new Controller();

			DataTable dt = controllerObj.SelectAllCustomer();
			metroComboBox1.DisplayMember = "CustName";
			metroComboBox1.ValueMember = "CustNatID";

			empID = controllerObj.getEmpIDByUser(Login.LoginUsername);
		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			if (controllerObj.addCallRecord(Convert.ToInt32(metroComboBox1.ValueMember), empID, metroTextBox1.Text) != 0)
				MessageBox.Show("Record Added Successfully!");
			else
				MessageBox.Show("Record Not Added!");
		}

        private void CallRecords_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
