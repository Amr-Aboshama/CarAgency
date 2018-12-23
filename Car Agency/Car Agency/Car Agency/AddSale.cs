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
    public partial class AddSale : MetroForm
    {
        Controller controllerObj;

        int carID;

        public AddSale(int carID)
        {
            InitializeComponent();

            controllerObj = new Controller();

            this.carID = carID;
        }

        private void AddSale_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.selectAllCurrencies();

            metroComboBox3.DataSource = dt;
            metroComboBox3.DisplayMember = "CurrCode";
            metroComboBox3.ValueMember = "CurrCode";

            dt = controllerObj.selectCustomers();

            metroComboBox2.DataSource = dt;
            metroComboBox2.DisplayMember = "Name";
            metroComboBox2.ValueMember = "custNatID";

            //metroTextBox6.Text = selectCustomer(carID);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            UInt32 gNatID;

            if (String.IsNullOrWhiteSpace(metroTextBox5.Text) || 
                (metroRadioButton1.Checked && metroRadioButton2.Checked) || 
                String.IsNullOrWhiteSpace(metroTextBox2.Text) || 
                UInt32.TryParse(metroTextBox2.Text, out gNatID))
            {
                MessageBox.Show("Enter All Values Correctly!");
            }
            else
            {
                //controllerObj.addSale(carID, metroRadioButton1.Checked, metroTextBox5.Text, metroComboBox3.ValueMember, 
                    //metroComboBox2.ValueMember, gNatID, metroTextBox1.Text, metroTextBox3.Text, metroTextBox4.Text);
            }

        }
    }
}
