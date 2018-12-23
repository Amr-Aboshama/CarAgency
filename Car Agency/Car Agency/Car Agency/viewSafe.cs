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
    public partial class viewSafe : MetroForm
    {
        Controller controllerObj;
        public viewSafe()
        {
            InitializeComponent();
            controllerObj = new Controller();
            BalanceGrid.DataSource = controllerObj.viewSafeBalance();
            TransactionsGrid.DataSource = controllerObj.viewSafeTransactions();
        }
    }
}
