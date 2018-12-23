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
    public partial class ViewInstallment : MetroForm
    {
        Controller controllerObj = new Controller();
        public ViewInstallment()
        {
            InitializeComponent();
            InstallmentsGrid.DataSource = controllerObj.SelectAllInstallments();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int? installmentID = null;
            if (InstallmentsGrid.SelectedRows.Count == 0)
                return;
            if (InstallmentsGrid.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select only one row");
                return;
            }

            installmentID = Convert.ToInt32(InstallmentsGrid.SelectedRows[0].Cells["Installment ID"].Value);

            new ViewCheques(installmentID).Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            int? saleID = null;
            if (InstallmentsGrid.SelectedRows.Count == 0)
                return;
            if (InstallmentsGrid.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select only one row");
                return;
            }

            saleID = Convert.ToInt32(InstallmentsGrid.SelectedRows[0].Cells["Sale ID"].Value);

            //new SPDetails(true, saleID).Show();
        }
    }
}
