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
    public partial class AddInstallment : MetroForm
    {
        private int saleID;
        private int installmentID;
        private bool installmentInserted = false;

        Controller controllerObj = new Controller();

        public AddInstallment(int rsaleID)
        {
            InitializeComponent();
            saleID = rsaleID;
            installmentID = controllerObj.getLastInstallmentID()+1;
            CurrencyComboBox.DataSource = controllerObj.SelecAllCurrency();
            CurrencyComboBox.DisplayMember = CurrencyComboBox.ValueMember = "CurrCode";
            FactorTextBox.Text = "1";
        }

        private void metroButton1_Click(object sender, EventArgs e) //add cheque
        {
            if (installmentInserted == false)
                if (!InsertInstallment())
                    return;
            new AddCheque(installmentID).Show(this);
            Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e) //finish
        {
            if (installmentInserted == false)
                if(!InsertInstallment())
                    return;
            MessageBox.Show("Installment inserted successfully");
            this.Close();
            
        }

        private bool InsertInstallment()
        {
            decimal SubmittedPrice;
            if (!decimal.TryParse(SubmittedPriceTextBox.Text, out SubmittedPrice))
            {
                MessageBox.Show("Please enter a valid value into \"Submitted Price\" field");
                return false;
            }
            decimal PriceOfOneInstallment;
            if (!decimal.TryParse(PriceOfOneInstallmentTextBox.Text, out PriceOfOneInstallment))
            {
                MessageBox.Show("Please enter a valid value into \"Price of one installment\" field");
                return false;
            }
            string Currency = CurrencyComboBox.SelectedValue.ToString();
            if(Currency == "")
            {
                MessageBox.Show("Please enter a valid value into \"Currency\" field");
                return false;
            }
            decimal Factor;
            if (!decimal.TryParse(FactorTextBox.Text, out Factor))
            {
                MessageBox.Show("Please enter a valid value into \"Factor\" field");
                return false;
            }
            string ArchivePlace = ArchivePlaceTextBox.Text;
            int DrawerNum;
            if (!int.TryParse(DrawerNumberTextBox.Text, out DrawerNum) && DrawerNumberTextBox.Text!="")
            {
                MessageBox.Show("Please enter a valid value into \"DrawerNum\" field");
                return false;
            }
            int r;
            if(DrawerNumberTextBox.Text!="")
                r = controllerObj.insertInstallment(SubmittedPrice, PriceOfOneInstallment, Currency, saleID, Factor, ArchivePlace, DrawerNum);
            else
                r = controllerObj.insertInstallment(SubmittedPrice, PriceOfOneInstallment, Currency, saleID, Factor, ArchivePlace, null);
            if (r == 0)
            {
                MessageBox.Show("An Error occured while inserting the installment");
                return false;
            }
            installmentInserted = true;
            return true;
        }

        private void AddInstallment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
