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

		int empID;

		public CallRecords()
		{
			InitializeComponent();

			controllerObj = new Controller();

			DataTable dt = controllerObj.selectCustomers();
			metroComboBox1.DisplayMember = "CustName";
			metroComboBox1.ValueMember = "CustNatID";

			empID = controllerObj.getEmpIDbyUser(Login.userName);
		}

		private void CallRecords_Load(object sender, EventArgs e)
		{

		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			if (controllerObj.addCallRecord(Convert.ToInt32(metroComboBox1.ValueMember), empID, metroTextBox1.Text) != 0)
				MessageBox.Show("Record Added Successfully!");
			else
				MessageBox.Show("Record Not Added!");
		}
	}
}
