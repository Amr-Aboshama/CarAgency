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
    public partial class userCreditManager : MetroForm
    {
        public userCreditManager()
        {
            InitializeComponent();
        }
        
	
        private void userCreditManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ViewInstallment VI = new ViewInstallment();
            VI.Show(this);
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ViewCheques VC = new ViewCheques();
            VC.Show(this);
            this.Hide();
        }
    }
}
