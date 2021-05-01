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
    public partial class addEmployee : MetroForm
    {
        
        Controller controllerObj;
        string defaultJob = "--All--";
        public addEmployee()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            bool invalid;
            decimal empID, sal;
            // Check for the missed data
            if (natID.Text.Length == 0 || name.Text.Length == 0 || address.Text.Length == 0
                || salary.Text.Length ==0)
            {
                MessageBox.Show("Please fill the missing data");
                return;
            }

            // Check for National ID Validiation
            invalid = false;
            foreach (char s in natID.Text)
                invalid |= (s < '0' || s > '9');

            if (invalid || natID.Text.Length != 14 || natID.Text[0]=='0')
            {
                MessageBox.Show("Please enter a valid National ID containg only 14 digits");
                return;
            }

            decimal.TryParse(natID.Text, out empID);

            if (controllerObj.isEmployeeExists(empID))
            {
                MessageBox.Show("This National ID already exists");
                return;
            }

            // Check for Name Validiation
            invalid = false;
            foreach (char s in name.Text)
                invalid |= !((s >= 'a' && s <= 'z') || (s >= 'A' && s <= 'Z') || s == ' ' || s == '_' || s == '-');

            if (invalid)
            {
                MessageBox.Show("Please Enter a valid name containing only (a~z,A~Z,-,_ and space)");
                return;
            }

            // Salary validiation
            if (!decimal.TryParse(salary.Text, out sal))
            {
                MessageBox.Show("Please enter a valid salary");
                return;
            }

            // Job selection validiation
            if (jobs.SelectedValue == null)
            {
                MessageBox.Show("Please choose a job");
                return;
            }

            try
            {
                // Add Employee to Database
                controllerObj.addEmployee(empID, name.Text, address.Text, sal, jobs.SelectedValue.ToString());
                MessageBox.Show("Employee Added Successfully");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void addEmployee_Load(object sender, EventArgs e)
        {
            // Load all Jobs
            DataTable dt = controllerObj.getAllJobs();
            for(int i=0; i<dt.Rows.Count; ++i)
                if(dt.Rows[i][0].ToString() == defaultJob)
                {
                    dt.Rows.RemoveAt(i);
                    break;
                }
            jobs.DataSource = dt;
            jobs.DisplayMember = jobs.ValueMember = "Name";
            jobs.SelectedValue = "";
            jobs.Refresh();
        }

        private void addEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
