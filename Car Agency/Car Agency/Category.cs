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
    //to do primary price only admin
    public partial class Category : MetroForm
    {
        private string CatName;
        private string GetCatName { get { return CatName; } }

        private string Username;
        private string GetUsername { get { return Username; } }

        Controller controllerObj;
        public Category(string catName)
        {
            InitializeComponent();
            CatName = catName;
            Username = Login.LoginUsername;
            controllerObj = new Controller();

            //update mode
            if(catName != "")
            {
                DataRow dr = controllerObj.SelectCategoryInfo(catName).Rows[0];
                CatTextBox.Text = catName;
                BrandTextBox.Text = (string)dr["Brand"];
                TypeTextBox.Text = (string)dr["Type"];
                ModelTextBox.Text = (string)dr["Model"];
                SpecsTextBox.Text = (string)dr["Specs"];
                PriceTextBox.Text = dr["PrimaryChashPrice"].ToString();

                CurrComboBox.DataSource = controllerObj.SelecAllCurrency();
                CurrComboBox.ValueMember = "CurrCode";
                CurrComboBox.SelectedValue = dr["Currency"];
                CurrComboBox.Refresh();
                metroButton1.Text = "Edit";
                metroButton2.Visible = true;
           
                SetMode(1);
            }
            else //insert mode
            {
                CurrComboBox.DataSource = controllerObj.SelecAllCurrency();
                CurrComboBox.ValueMember = "CurrCode";
                CurrComboBox.DisplayMember = "CurrCode";
                metroButton1.Text = "Insert";
                metroButton2.Visible = false;
            }

           
        }

        //insert new category or update existing one
        private void metroButton1_Click(object sender, EventArgs e)
        {
            int check;
            //7war en el currency referenced from currencyTable mbwz el donya
            if (GetCatName == "")
            {
                Decimal i = 0;
                if (PriceTextBox.Text != "")
                    i = Decimal.Parse(PriceTextBox.Text);
                check = controllerObj.InsertCategory(CatTextBox.Text, BrandTextBox.Text, TypeTextBox.Text, ModelTextBox.Text, SpecsTextBox.Text, i, Convert.ToString(CurrComboBox.SelectedValue));
                if (check == 0)
                {
                    MessageBox.Show("Insert Failed");
                }
                else
                {
                    MessageBox.Show("Insert Succeeded");
                    
                    CatTextBox.Text = null;
                    BrandTextBox.Text = null;
                    TypeTextBox.Text = null;
                    ModelTextBox.Text = null;
                    SpecsTextBox.Text = null;
                    PriceTextBox.Text = null;
                }
            }
            else
            {
                check = controllerObj.UpdateCategory(GetCatName,CatTextBox.Text, BrandTextBox.Text, TypeTextBox.Text, ModelTextBox.Text, SpecsTextBox.Text, Decimal.Parse(PriceTextBox.Text), Convert.ToString(CurrComboBox.SelectedValue));
                if (check == 0)
                {
                    MessageBox.Show("Edit Failed");
                }
                else
                {
                    MessageBox.Show("Edit Succeeded");
                }
            }
        }

        private void SetMode(int i)
        {
            if(i == 0) //edit mode
            {
                CatTextBox.Enabled = true;
                BrandTextBox.Enabled = true;
                TypeTextBox.Enabled = true;
                ModelTextBox.Enabled = true;
                SpecsTextBox.Enabled = true;  ///////hwa da
                CurrComboBox.Enabled = true;
                if (GetUsername != "admin")
                    PriceTextBox.Enabled = false;
                else
                    PriceTextBox.Enabled = true;

            }
            else //read only mode
            {
                CatTextBox.Enabled = false;
                BrandTextBox.Enabled = false;
                TypeTextBox.Enabled = false;
                ModelTextBox.Enabled = false;
                SpecsTextBox.Enabled = false;   /////da

                PriceTextBox.Enabled = false;
                CurrComboBox.Enabled = false;
            }
            
        }

        //enable edit mode
        private void metroButton2_Click(object sender, EventArgs e)
        {
            SetMode(0);
        }

        private void Category_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
