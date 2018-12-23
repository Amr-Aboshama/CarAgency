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
    public partial class CreditManager : MetroForm
    {
        public CreditManager()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            new ViewInstallment().Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            new ViewCheques().Show();
        }
    }
}
