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
    public partial class viewBank : MetroForm
    {
        Controller controllerObj;
        public viewBank()
        {
            InitializeComponent();
            controllerObj = new Controller();
            BalanceGrid.DataSource = controllerObj.viewBankBalance();
            TransactionsGrid.DataSource = controllerObj.viewBankTransactions();
        }

        private void viewBank_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
