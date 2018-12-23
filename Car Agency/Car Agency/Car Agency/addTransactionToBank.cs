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
        public addTransactionToBank()
        {
            InitializeComponent();
            controllerObj = new Controller();
            priv = controllerObj.getPriv(Login.LoginUsername); // get Privilage
            empId = controllerObj.getEmpIDByUser(Login.LoginUsername);   // get Employee Id

            DataTable dt = controllerObj.getTreasuries(1);
            metroComboBox1.DataSource = dt;
            metroComboBox1.DisplayMember = "Name";
            metroComboBox1.ValueMember = "TreasuryID";
            metroComboBox1.SelectedValue = 0;
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

            if (metroComboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please Select a Bank");
                return;
            }

            // Operationtype = 0 -> Withdraw [-ve price], 1-> Deposit
            if (!metroRadioButton1.Checked) price *= -1;

            treasuryId = Convert.ToInt32(metroComboBox1.SelectedValue);

            try
            {
                controllerObj.AddOtherTransaction(empId, treasuryId, price, metroTextBox2.Text.ToString());
                metroTextBox1.Clear();
                metroTextBox2.Clear();
                metroRadioButton1.Checked = metroRadioButton2.Checked = false;
                metroComboBox1.SelectedValue = 0;
                MessageBox.Show("Transaction Added Successfully");
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
            
        }
    }
}
