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
    public partial class PurchaseCar : MetroForm
    {
        Controller controllerObj = new Controller();

        public PurchaseCar()
        {
            InitializeComponent();
            CurrencyComboBox.DataSource = controllerObj.SelecAllCurrency();
            CurrencyComboBox.ValueMember = CurrencyComboBox.DisplayMember = "CurrCode";
            SupplierComboBox.DataSource = controllerObj.SelectSuppliers();
            SupplierComboBox.DisplayMember = "Name";
            SupplierComboBox.ValueMember = "SupID";
            CategoryNameComboBox.DataSource = controllerObj.SelectCategoriesNames();
            CategoryNameComboBox.ValueMember = CategoryNameComboBox.DisplayMember = "CatName";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string ChassisID, MotorNum, Color, CatName;
            ChassisID = ChassisIDTextBox.Text;
            if(ChassisID=="")
            {
                MessageBox.Show("Please enter a value into \"Chassis Number\"");
                return;
            }
            if(controllerObj.SelectCarByChassis(ChassisID)!=null)
            {
                MessageBox.Show("This Chassis Number was enterd before, please enter a new value");
                return;
            }
            if(ChassisID.Length>20)
            {
                MessageBox.Show("The maximum length of the \"Chassis Number\" is 20");
                return;
            }
            MotorNum = MotorNumberTextBox.Text;
            if (MotorNum == "")
            {
                MessageBox.Show("Please enter a value into \"Motor Number\"");
                return;
            }
            if (controllerObj.SelectCarByMotor(MotorNum) != null)
            {
                MessageBox.Show("This Motor Number was enterd before, please enter a new value");
                return;
            }
            if (MotorNum.Length > 20)
            {
                MessageBox.Show("The maximum length of the \"Motor Number\" is 20");
                return;
            }
            Color = ColorTextBox.Text;
            if(Color == "")
            {
                MessageBox.Show("Please enter a value into \"Color\"");
                return;
            }
            if (Color.Length > 20)
            {
                MessageBox.Show("The maximum length of the \"Color Number\" is 20");
                return;
            }
            CatName = CategoryNameComboBox.SelectedValue.ToString();
            

            if (!decimal.TryParse(PriceTextBox.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid value into \"Price\" field");
                return;
            }
            price = Math.Abs(price);
            string Currency = CurrencyComboBox.SelectedValue.ToString();
            int SupID = Convert.ToInt32(SupplierComboBox.SelectedValue);

            int r1 = controllerObj.InsertCar(ChassisID, MotorNum, Color, CatName);
            int r2 = controllerObj.InsertPurchase(ChassisID, price, Currency, SupID);
            if (r1 > 0 && r2 > 0)
                MessageBox.Show("The car is purchased successfully");
            else if(r1==0)
                MessageBox.Show("An error occured while inserting the Car");
            else
            {
                MessageBox.Show("An error occured while inserting the Purchase");
                controllerObj.DeleteCar(ChassisID);
            }
        }
    }
}
