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
    public partial class ViewCheques : MetroForm
    {
        Controller controllerObj = new Controller();
        public ViewCheques(int? installmentID = null)
        {
            InitializeComponent();
            ChequesGrid.DataSource = controllerObj.SelectCheques(installmentID);
        }

        private void ViewCheques_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
