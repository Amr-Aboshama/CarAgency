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
    public partial class showPanel : MetroForm
    {
        Controller controllerObj;
        string Username;
        public showPanel()
        {
            InitializeComponent();
            controllerObj = new Controller();
            Username = Login.LoginUsername;
        }

        private void showPrivileges_Load(object sender, EventArgs e)
        {
            if(Username == "admin")
            {
                adminPanelButton.Visible = true;
                DataTable dt = controllerObj.getAllJobs();
                for (int i = 0; i < dt.Rows.Count; ++i)
                    if (dt.Rows[i][0].ToString() == "--All--")
                    {
                        dt.Rows.RemoveAt(i);
                        return;
                    }
            }
            else
            {
                privileges.DataSource = controllerObj.getUserPrivileges(Username);
                privileges.DisplayMember = privileges.ValueMember = "JobName";
                privileges.SelectedValue = "";
            }
        }

        private void showPropertiesButton_Click(object sender, EventArgs e)
        {
            if (privileges.SelectedValue == null)
            {
                MessageBox.Show("Please Select a Privilege");
                return;
            }
            Hide();
            if (privileges.SelectedValue.ToString() == "Bank Manager")
            {
                userBankManager BM = new userBankManager();
                BM.Show(this);
            }
            else if (privileges.SelectedValue.ToString() == "Credit Manager")
            {
                userCreditManager CM = new userCreditManager();
                CM.Show(this);
            }
            else if (privileges.SelectedValue.ToString() == "Inventory Manager")
            {
                userInventoryManager IM = new userInventoryManager();
                IM.Show(this);
            }
            else if (privileges.SelectedValue.ToString() == "Sales Manager")
            {
                userSalesMan SM = new userSalesMan();
                SM.Show(this);
            }
            else if (privileges.SelectedValue.ToString() == "Treasury Manager")
            {
                userTreasuryManager TM = new userTreasuryManager();
                TM.Show(this);
            }
        }

        private void showPrivileges_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void adminPanelButton_Click(object sender, EventArgs e)
        {
            AdminPanel AP = new AdminPanel();
            Hide();
            AP.Show(this);
        }
    }
}