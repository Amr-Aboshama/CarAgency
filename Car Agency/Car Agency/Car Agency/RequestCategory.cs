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
    public partial class RequestCategory : MetroForm
    {
        private string user;
        private int id;
        private string customer;
        Controller controllerObj;
        public RequestCategory()
        {
            InitializeComponent();
            controllerObj = new Controller();
            user = Login.LoginUsername;
            BrandmetroComboBox.ValueMember = "Brand";
            BrandmetroComboBox.DisplayMember = "Brand";
            BrandmetroComboBox.DataSource = controllerObj.SelectBrands();
            BrandmetroComboBox.SelectedValue = -1;

            CustmetroComboBox.ValueMember = "CustNatID";
            CustmetroComboBox.DisplayMember = "Name";
            CustmetroComboBox.DataSource = controllerObj.SelectCustomers();
            CustmetroComboBox.SelectedValue = -1;
            CustmetroComboBox.Enabled = false;
        }

        //view more info of the selected category
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Category v = new Category(Convert.ToString(listBox1.SelectedValue));
            v.Show(this);
            Hide();
        }

        //insert new requested category 
        private void InsertMetroButton_Click(object sender, EventArgs e)
        {
            // 1 for salesman
            Category v = new Category("");
            v.Show(this);
            Hide();
        }

        //enable or disable customerComboBox 
        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked == true)
                CustmetroComboBox.Enabled = true;
            else
                CustmetroComboBox.Enabled = false;
        }

        //request category
        private void RequestMetroButton_Click(object sender, EventArgs e)
        {
            id = controllerObj.GetNewRequestID();
            if (metroCheckBox1.Checked == false)
                customer = "";
            if (CustmetroComboBox.SelectedValue == null && metroCheckBox1.Checked == true)
            {
                MessageBox.Show("Select a cutomer first");
                return;
            }
            else
                customer = Convert.ToString(CustmetroComboBox.SelectedValue);
            int check = controllerObj.RequestCategory(Convert.ToString(listBox1.SelectedValue),customer, metroTextBox1.Text, id);
            if (check == 0)
                MessageBox.Show("falied");
            else
                MessageBox.Show("Request Succeeded");
        }

        //load types into typecombobox of the selected brand
        private void BrandmetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypemetroComboBox.ValueMember = "Type";
            TypemetroComboBox.DisplayMember = "Type";
            TypemetroComboBox.DataSource = controllerObj.SelectTypes(Convert.ToString(BrandmetroComboBox.SelectedValue));
            TypemetroComboBox.SelectedValue = -1;
        }

        //load categories into the listbox of the selected brand/type
        private void TypemetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.ValueMember = "CatName";
            listBox1.DisplayMember = "CatName";
            listBox1.DataSource = controllerObj.SelectCategories(Convert.ToString(BrandmetroComboBox.SelectedValue), Convert.ToString(TypemetroComboBox.SelectedValue));
        }

        private void RequestCategory_Activated(object sender, EventArgs e)
        {
            BrandmetroComboBox.ValueMember = "Brand";
            BrandmetroComboBox.DisplayMember = "Brand";
            BrandmetroComboBox.DataSource = controllerObj.SelectBrands();
            BrandmetroComboBox.SelectedValue = -1;
        }

        private void RequestCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
