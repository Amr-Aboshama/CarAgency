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
    public partial class AddJob : MetroForm
    {
        private Controller controllerObj = new Controller();
        public AddJob()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string name = JobNameTextBox.Text;
            if(name == "")
            {
                MessageBox.Show("Please enter a Job Name");
                return;
            }
            foreach(char c in name)
            {
                if(!((c>='A' && c<='Z') || (c>='a' && c<='z') || c==' ' ))
                {
                    MessageBox.Show("A name can contain only English letters or a space");
                    return;
                }
            }
            if (controllerObj.InsertJob(name) > 0)
                MessageBox.Show("The Job was inserted successfully");
            else
                MessageBox.Show("An Error occured while inserting the job");
        }
    }
}
