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
    public partial class addStore : MetroForm
    {
        Controller controllerObj;
        public addStore()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void addStore_Load(object sender, EventArgs e)
        {
            storeSupervisor.DataSource = controllerObj.getAllStoresSup();
            storeSupervisor.DisplayMember = "Name";
            storeSupervisor.ValueMember = "EmpNatID";
            storeSupervisor.SelectedValue = 0;
        }

        private void addStoreButton_Click(object sender, EventArgs e)
        {
            int cap;
            foreach(char c in name.Text)
                if((c<'a' && c>'z') && (c<'A' && c>'Z') && c!=' ')
                {
                    MessageBox.Show("Please insert a valid name containing only (a~z,A~z,space)");
                    return;
                }

            if(!int.TryParse(capacity.Text,out cap))
            {
                MessageBox.Show("Please enter a valid capacity");
                return;
            }

            if(storeSupervisor.SelectedValue==null)
            {
                MessageBox.Show("Please select a store Supervisor");
                return;
            }

            try
            {
                controllerObj.addStore(name.Text, address.Text, cap, (decimal)storeSupervisor.SelectedValue);
                MessageBox.Show("Store added Successfully");
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
