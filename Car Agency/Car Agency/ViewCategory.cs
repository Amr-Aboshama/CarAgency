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
    public partial class ViewCategory : MetroForm
    {
        private string user;
        Controller controllerObj;
        public ViewCategory()
        {
            InitializeComponent();
            controllerObj = new Controller();
            user = Login.LoginUsername;
            BrandComboBox.ValueMember = "Brand";
            BrandComboBox.DisplayMember = "Brand";
            BrandComboBox.DataSource = controllerObj.SelectBrands();
            BrandComboBox.SelectedValue = -1;
            //BrandComboBox.Text = "--Select--";                            /msh radya ttktb m3rfsh leh
        }

        private void UpdateBrandComboBox()
        {
            BrandComboBox.ValueMember = "Brand";
            BrandComboBox.DisplayMember = "Brand";
            BrandComboBox.DataSource = controllerObj.SelectBrands();
            BrandComboBox.Update();
            BrandComboBox.SelectedValue = -1;
          //  BrandComboBox.dText = "--Select--";
        }

        //load types into typecombobox of the selected brand
        private void BrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeComboBox.ValueMember = "Type";
            TypeComboBox.DisplayMember = "Type";
            TypeComboBox.DataSource = controllerObj.SelectTypes(Convert.ToString(BrandComboBox.SelectedValue));
            TypeComboBox.SelectedValue = -1;
            //  TypeComboBox.Text = "--Select--";
        }

        //load more info about a specific category
        private void CatlistBox_DoubleClick(object sender, EventArgs e)
        {
          
            Category categoryFrom = new Category(Convert.ToString(CatlistBox.SelectedValue));
            categoryFrom.Show(this);
            Hide();
        }

        //insert new category
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Category categoryFrom = new Category("");
            categoryFrom.Show(this);
            Hide();
        }

        //update data after inserting new category (refrsh button)
        private void metroButton2_Click(object sender, EventArgs e)
        {
            UpdateBrandComboBox();
        }

        //load categories of the selected brand/type
        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatlistBox.DisplayMember = "CatName";
            CatlistBox.ValueMember = "CatName";
            CatlistBox.DataSource = controllerObj.SelectCategories(Convert.ToString(BrandComboBox.SelectedValue), Convert.ToString(TypeComboBox.SelectedValue));
        }

        private void ViewCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
