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
    public partial class AddCheque : MetroForm
    {
        private int? installmentID;
        private Controller controllerObj = new Controller();

        public AddCheque(int? rInstallmentID = null)
        {
            InitializeComponent();
            installmentID = rInstallmentID;
            if (installmentID != null)
            {
                DataTable dt = controllerObj.SelectInstallment(installmentID.Value);
                if (dt != null)
                {
                    int? saleID = dt.Rows[0]["SaleID"] as int?;
                    decimal price = (dt.Rows[0]["PriceOfOneInstallment"] as decimal?).Value;
                    ForOnMeGroupBox.Enabled = false;
                    ForMeRadioButton.Checked = true;
                    CustomerComboBox.DataSource = controllerObj.SelectCustomer(saleID.Value);
                    CustomerComboBox.ValueMember = "CustNatID";
                    CustomerComboBox.DisplayMember = "Name";
                    CustomerComboBox.Enabled = false;
                    PriceTextBox.Text = price.ToString();
                    PriceTextBox.Enabled = false;
                    CurrencyComboBox.DataSource = dt;
                    CurrencyComboBox.ValueMember = CurrencyComboBox.DisplayMember = "Currency";
                    CurrencyComboBox.Enabled = false;
                }
            }
            else
            {
                CurrencyComboBox.DataSource = controllerObj.SelecAllCurrency();
                CurrencyComboBox.ValueMember = CurrencyComboBox.DisplayMember = "CurrCode";
                CustomerComboBox.DataSource = controllerObj.SelectCutomers();
                CustomerComboBox.ValueMember = "CustNatID";
                CustomerComboBox.DisplayMember = "Name";
            }
        }

        private void metroButton1_Click(object sender, EventArgs e) //finish
        {
            string ChequeID = ChequeIDTextBox.Text;
            if(ChequeID == "")
            {
                MessageBox.Show("Please enter a valid value into \"Cheque ID\" field");
                return;
            }
            decimal price;
            if (!decimal.TryParse(PriceTextBox.Text, out price))
            {
                MessageBox.Show("Please enter a valid value into \"Price\" field");
                return;
            }
            if(ForMeRadioButton.Checked==OnMeRadioButton.Checked) //they are both not checked
            {
                MessageBox.Show("Please specify if the cheque is \"for you\" or \"On you\"");
                return;
            }
            else if (OnMeRadioButton.Checked == true)
                price = -price;
            string Currency = CurrencyComboBox.SelectedValue.ToString();
            if (Currency == "")
            {
                MessageBox.Show("Please enter a valid value into \"Currency\" field");
                return;
            }
            ulong CustID;
            if (!ulong.TryParse(CustomerComboBox.SelectedValue.ToString(), out CustID))
            {
                MessageBox.Show("Please specify the customer");
                return;
            }
            string CustomerBank = CustomerBankTextBox.Text;
            if (CustomerBank == "")
            {
                MessageBox.Show("Please enter a valid value into \"Customer Bank\" field");
                return;
            }
            DateTime DueDate = DueDateDateTime.Value;
            decimal DelayPenalty;
            if (!decimal.TryParse(DelayPenaltyTextBox.Text, out DelayPenalty))
            {
                MessageBox.Show("Please enter a valid value into \"Delay Penalty\" field");
                return;
            }
            string Notes = NotesTextBox.Text;
            int r = controllerObj.insertCheque(ChequeID, price, Currency, CustID, CustomerBank, DueDate, DelayPenalty, Notes, installmentID);
            if (r == 0)
                MessageBox.Show("An error occured while inserting the cheque");
            else
            {
                MessageBox.Show("the cheque inserted successfully");
                this.Close();
            }
        }
    }
}
