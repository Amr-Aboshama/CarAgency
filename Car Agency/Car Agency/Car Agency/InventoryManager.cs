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
    public partial class InventoryManager : MetroForm
    {
        Controller controllerObj;
        public InventoryManager()
        {
            InitializeComponent();
            controllerObj = new Controller();

            //cars in stores
            metroGrid1.ReadOnly = true;
            metroGrid1.DataSource = controllerObj.SelectCarsInStores();

            //cars not in store
            metroGrid2.ReadOnly = true;
            metroGrid2.DataSource = controllerObj.SelectCarsNotInStore();

            metroComboBox1.DisplayMember = "Name";
            metroComboBox1.ValueMember = "StoreID";
            metroComboBox1.DataSource = controllerObj.SelectStores();
            metroComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //add car to the selected store
        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = metroGrid2.SelectedRows;
            if (rows[0].Cells["ChasisID"].Value == null)
            {
                MessageBox.Show("Select a car first");
                return;
            }

            string carID = (string)rows[0].Cells["ChasisID"].Value;
            int check = controllerObj.InsertCarIntoStore(carID, Convert.ToString(metroComboBox1.SelectedValue));
            if (check == 0)
                MessageBox.Show("Failed");
            else
            {
                MessageBox.Show("Succeeded");
                //update datagridview 1 & 2
                metroGrid1.DataSource = controllerObj.SelectCarsInStores();
                metroGrid2.DataSource = controllerObj.SelectCarsNotInStore();
            }
        }
    }
}
