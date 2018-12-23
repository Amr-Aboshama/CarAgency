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
    //to do reserve action
    public partial class AvailableCars : MetroForm
    {
        private int k = 1;
        Controller controllerObj; 
        public AvailableCars()
        {
            InitializeComponent();
            controllerObj = new Controller();

            ModelTextbox.Enabled = false;
            SpecsTextbox.Enabled = false;
            PriceTextbox.Enabled = false;
            metroGrid1.ReadOnly = true;

            //load available brands
            brandCombobox.ValueMember = "Brand";
            brandCombobox.DisplayMember = "Brand";
            brandCombobox.DataSource = controllerObj.SelectAvailableCarBrands();
            brandCombobox.SelectedValue = -1;
        }

        //load available car types of the selected brand
        private void brandCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (k == 1)
            {
                k++;
                return;
            }
            TypeCombobox.ValueMember = "Type";
            TypeCombobox.DisplayMember = "Type";
            TypeCombobox.DataSource = controllerObj.SelectAvailableCarTypes(Convert.ToString(brandCombobox.SelectedValue));
            TypeCombobox.SelectedValue = -1;
        }

        //reserve car
        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = metroGrid1.SelectedRows;
            if (rows[0].Cells["ChasisID"].Value == null)
            {
                MessageBox.Show("Select a car first");
                return;
            }

            int check = controllerObj.ReserveCar(Convert.ToString(rows[0].Cells["ChasisID"].Value), 2);
            if (check == 0)
                MessageBox.Show("Failed");
            else
            {
                MessageBox.Show("Reservation Succeeded");
                
                brandCombobox.ValueMember = "Brand";
                brandCombobox.DisplayMember = "Brand";
                brandCombobox.DataSource = controllerObj.SelectAvailableCarBrands();
                brandCombobox.SelectedValue = -1;
                k = 2;

                ModelTextbox.Text = "";
                SpecsTextbox.Text = "";
                PriceTextbox.Text = "";
                Currencylabel.Text = "Currency";
                metroGrid1.DataSource = null;

            }
        }

        //load available categories of the selected brand/type
        private void TypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (k == 2)
            {
                k++;
                return;
            }
            CatCombobox.ValueMember = "CatName";
            CatCombobox.DisplayMember = "CatName";
            CatCombobox.DataSource = controllerObj.SelectAvailableCarCategory(Convert.ToString(brandCombobox.SelectedValue), Convert.ToString(TypeCombobox.SelectedValue));
            CatCombobox.SelectedValue = -1;
        }

        //load car info of a specific category
        private void CatCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (k == 3)
            {
                k++;
                return;
            }
            DataTable dt = controllerObj.SelectAvailableCarInfo(Convert.ToString(CatCombobox.SelectedValue));
            if (dt == null)
                return;
            DataRow row = dt.Rows[0];
            SpecsTextbox.Text = (string)row["Specs"];
            ModelTextbox.Text = (string)row["Model"];
            PriceTextbox.Text = row["PrimaryChashPrice"].ToString();
            Currencylabel.Text = (string)row["Currency"];

            metroGrid1.DataSource = controllerObj.SelectAvailabeCars(Convert.ToString(CatCombobox.SelectedValue));
        } 

    }
}
