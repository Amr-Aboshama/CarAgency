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
    //to do images,,,,,nat it decimal or not
    public partial class Customers : MetroForm
    {
        private int k = 1;
        Controller controllerObj;
        public Customers()
        {
            //7war el view customer el mafrod tb2a enabled l user mo3ayan
            InitializeComponent();
            controllerObj = new Controller();

            //load phonebook
            CustmetroComboBox.ValueMember = "CustNatID";
            CustmetroComboBox.DisplayMember = "Name";
            CustmetroComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustmetroComboBox.DataSource = controllerObj.SelectCustomers();
            CustmetroComboBox.SelectedValue = -1;

            //load customer combobox (view customers)
            metroComboBox1.DisplayMember = "Name";
            metroComboBox1.ValueMember = "CustNatID";
            metroComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            metroComboBox1.DataSource = controllerObj.SelectCustomers();
            metroComboBox1.SelectedValue = -1;                    

            metroGrid1.ReadOnly = true;
           
          

        }

        //Add cutomer 
        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            string id = metroTextBox2.Text;
            if( id.Length != 14 || id[0] == '0' || (!(id.All(char.IsDigit))) )
            {
                MessageBox.Show("Insert a valid National ID");
                return;
            }
            int check = controllerObj.InsertCustomer(metroTextBox1.Text, Convert.ToDecimal(metroTextBox2.Text), metroTextBox3.Text, metroTextBox5.Text, metroTextBox6.Text, metroTextBox7.Text);
            if (check == 0)
            {
                MessageBox.Show("Inavild Data");
            }
            else
            {
                MessageBox.Show("Succeeded");
                UpdatePhonebook();
                UpdateViewCustomer();
            }
        }

        //as2al azbat el shakl on update azay??????????????????????????????
        //update customer
        private void metroButton3_Click(object sender, EventArgs e)
        {
            string newname = "";
            if (NameTextBox.Text != "")
                newname = NameTextBox.Text;
            int check = controllerObj.UpdateCustomer(Convert.ToDecimal(CustNatID.Text), newname, address.Text, email.Text, cmpname.Text, cmpaddress.Text, Convert.ToDecimal(credit.Text));
            if (check == 0)
            {
                MessageBox.Show("Invalid Data");
            }
            else
            {
                MessageBox.Show("Succeeded");
                NameTextBox.Text = "";
                address.Text = "";
                email.Text = "";
                credit.Text = "";
                cmpaddress.Text = "";
                cmpname.Text = "";
                CustNatID.Text = "";
                UpdatePhonebook();
                UpdateViewCustomer();
            }
        }

        //view selected customer's data
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(k == 1)
            {
                k++;
                return;
            }
            

            DataTable dt = controllerObj.SelectCustomerByID(Convert.ToDecimal(metroComboBox1.SelectedValue));
            if (dt == null)
                return;
            DataRow customer = dt.Rows[0];
            if (customer == null)
                return;
            address.Text = (string)customer["CustAddress"];
            email.Text = (string)customer["Email"];
            credit.Text = customer["Credit"].ToString();
            cmpname.Text = (string)customer["CompName"];
            cmpaddress.Text = (string)customer["CompAddress"];
            CustNatID.Text = (metroComboBox1.SelectedValue).ToString();
            CustNatID.Enabled = false;

            ViewCustMode(1); //read only mode
        }

        //update phonebook customerCombobox after (insert/update)
        private void UpdatePhonebook()
        {
            CustmetroComboBox.ValueMember = "CustNatID";
            CustmetroComboBox.DisplayMember = "Name";
            CustmetroComboBox.DataSource = controllerObj.SelectCustomers();
            CustmetroComboBox.SelectedValue = -1;
        }

        //update (view cutomer)form cutomerCombobox after(insert/delete)
        private void UpdateViewCustomer()
        {
            k = 1;
            metroComboBox1.DisplayMember = "Name";
            metroComboBox1.ValueMember = "CustNatID";
            metroComboBox1.DataSource = controllerObj.SelectCustomers();
            metroComboBox1.SelectedValue = -1;
        }

        //load customer's phonenumber into datagrid
        private void CustmetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroGrid1.DataSource = controllerObj.SelectCustomerPhoneNumbers(Convert.ToDecimal(CustmetroComboBox.SelectedValue));
        }

        //insert new phone number(phonebook)
        private void InsertmetroButton2_Click(object sender, EventArgs e)
        {
            if (PhonemetroTextBox4.Text != "")
            {
                int check = controllerObj.InsertCustPhoneNum(PhonemetroTextBox4.Text, Convert.ToDecimal(CustmetroComboBox.SelectedValue));
                if (check == 0)
                {
                    MessageBox.Show("Invalid Data");
                }
                else
                {
                    MessageBox.Show("Succeeded");
                    metroGrid1.DataSource = controllerObj.SelectCustomerPhoneNumbers(Convert.ToDecimal(CustmetroComboBox.SelectedValue));
                    metroGrid1.Update();
                    PhonemetroTextBox4.Text = null;
                }
            }
            else
                MessageBox.Show("Insert a phone number first");
        }

        //delete the selected phone number
        private void DeletemetroButton2_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = metroGrid1.SelectedRows;
            
            string phone = (string)rows[0].Cells["Phone"].Value;
            if (phone != null)
            {
                int check = controllerObj.DeleteCustPhoneNum(phone, Convert.ToDecimal(CustmetroComboBox.SelectedValue));
                if (check == 0)
                {
                    MessageBox.Show("Falied");
                }
                else
                {
                    MessageBox.Show("Succeeded");
                    metroGrid1.DataSource = controllerObj.SelectCustomerPhoneNumbers(Convert.ToDecimal(CustmetroComboBox.SelectedValue));
                    metroGrid1.Update();
                }
            }
            else
                MessageBox.Show("Select a phone number first");
        }
        
        private void ViewCustMode(int i)
        {
            if(i == 0) //edit mode
            {
                NameTextBox.Enabled = true;
                CustNatID.Enabled = true;
                address.Enabled = true;
                email.Enabled = true;
                credit.Enabled = true;
                cmpname.Enabled = true;
                cmpaddress.Enabled = true;
               
            }
            else //read only mode
            {
                NameTextBox.Enabled = false;
                CustNatID.Enabled = false;
                address.Enabled = false;
                email.Enabled = false;
                credit.Enabled = false;
                cmpname.Enabled = false;
                cmpaddress.Enabled = false;
            }
        }

        //enable edit mode
        private void EditModeButton_Click(object sender, EventArgs e)
        {
            ViewCustMode(0);
        }

        
    }
}
