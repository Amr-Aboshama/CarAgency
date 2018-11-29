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
    public partial class addTransactionToBank : MetroForm
    {
        int priv,treasuryId;
        decimal empId;
        Controller controllerObj;
        public addTransactionToBank(string Username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            priv = controllerObj.getPriv(Username); // get Privilage
            empId = controllerObj.getEmpId(Username);   // get Employee Id

            DataTable dt = controllerObj.getTreasuries();
            metroComboBox1.DataSource = dt;
            metroComboBox1.DisplayMember = "Name";
            metroComboBox1.ValueMember = "TreasuryID";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            decimal price;
            if(!decimal.TryParse(metroTextBox1.Text,out price) || price<=0)
            {
                MessageBox.Show("Please enter a valid price");
                return;
            }
            if(metroRadioButton1.Checked == false && metroRadioButton2.Checked == false)
            {
                MessageBox.Show("Please check the operation type!");
                return;
            }
            if(metroTextBox2.Text.ToString().Length == 0)
            {
                MessageBox.Show("Please Enter a note for the operation!");
                return;
            }
            
            // Operationtype = 0 -> Withdraw, 1-> Deposit
            int opType = (metroRadioButton1.Checked == true) ? 1 : 0;

            treasuryId = Convert.ToInt32(metroComboBox1.SelectedValue);

            int done = controllerObj.addTransaction(empId, treasuryId, price, opType, metroTextBox2.Text.ToString());

            if (done == 0)
            {
                MessageBox.Show("There's some error happened at adding a transaction!");
            }
            else
            {
                MessageBox.Show("Transaction add sucessfully!");
                metroTextBox1.Clear();
                metroTextBox2.Clear();
            }
        }
    }
}
