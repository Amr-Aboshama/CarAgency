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
    public partial class viewEmployee : MetroForm
    {
        Controller controllerObj;
        string defaultJob = "--All--";
        bool init;
        public viewEmployee()
        {
            InitializeComponent();
            controllerObj = new Controller();
            load();
        }
        public void load()
        {
            init = true;


            try
            {
                searchJob.DataSource = controllerObj.getAllJobs();
                searchJob.ValueMember = searchJob.DisplayMember = "Name";
                searchJob.SelectedValue = defaultJob;

                employee.DataSource = controllerObj.getAllEmployees();
                employee.DisplayMember = "Name";
                employee.ValueMember = "EmpNatID";
                employee.SelectedValue = 0;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return;
            }
            
            metroLabel3.Visible = metroLabel4.Visible = metroLabel5.Visible = metroLabel6.Visible = 
                metroLabel7.Visible = false;

            natID.Visible = name.Visible = address.Visible = salary.Visible = job.Visible = false;

            EditMode.Visible = Apply.Visible = RemoveEmployee.Visible = false;


            init = false;
        }
        

        private void searchJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (init) return;
            try
            {
                // if All Selected Load All Employee, otherwise, Load Employees in Specified with Jobs
                init = true;
                if ((string)searchJob.SelectedValue == defaultJob)
                    employee.DataSource = controllerObj.getAllEmployees();
                else
                    employee.DataSource = controllerObj.getEmpByJob((string)searchJob.SelectedValue);
                employee.DisplayMember = "Name";
                employee.ValueMember = "EmpNatID";
                employee.SelectedValue = 0;
                init = false;

                metroLabel3.Visible = metroLabel4.Visible =
                    metroLabel5.Visible = metroLabel6.Visible = metroLabel7.Visible = false;

                natID.Visible = name.Visible = address.Visible = salary.Visible = job.Visible = false;

                EditMode.Visible = Apply.Visible = RemoveEmployee.Visible = false;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (init) return;
            metroLabel3.Visible = metroLabel4.Visible = 
                metroLabel5.Visible = metroLabel6.Visible = metroLabel7.Visible = true;

            natID.Visible = name.Visible = address.Visible = salary.Visible = job.Visible = true;

            EditMode.Visible = Apply.Visible = RemoveEmployee.Visible = true;

            natID.Enabled = name.Enabled = address.Enabled = salary.Enabled = job.Enabled = false;

            Apply.Enabled = false;

            DataTable dt = controllerObj.getAllJobs();

            // Remove --All-- Job
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                if (dt.Rows[i][0].ToString() == "--All--")
                {
                    dt.Rows.RemoveAt(i);
                    break;
                }
            }
            
            job.DataSource = dt;
            job.DisplayMember = job.ValueMember = "Name";

            dt = controllerObj.getEmpData((decimal)employee.SelectedValue);

            natID.Text = dt.Rows[0][0].ToString();
            name.Text = dt.Rows[0][1].ToString();
            address.Text = dt.Rows[0][2].ToString();
            job.SelectedValue = dt.Rows[0][3].ToString();
            salary.Text = dt.Rows[0][4].ToString();
        }

        private void EditMode_Click(object sender, EventArgs e)
        {
            // Enable to Edit
            natID.Enabled = name.Enabled = address.Enabled = salary.Enabled = job.Enabled = true;
            Apply.Enabled = true;
        }

        private void RemoveEmployee_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to remove Employee with National ID: " + employee.SelectedValue.ToString()
                + " Permenantly?\n\t( It may affect removing some Users )", "Confirmation Message", MessageBoxButtons.YesNo).ToString() == "No") return;
            try
            {
                controllerObj.removeEmployee((decimal)employee.SelectedValue);
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
                return;
            }
            load();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            bool invalid;
            decimal empID, sal;
            // Check for the missed data
            if (natID.Text.Length == 0 || name.Text.Length == 0 || address.Text.Length == 0
                || salary.Text.Length == 0)
            {
                MessageBox.Show("Please fill the missing data");
                return;
            }

            // Check for National ID Validiation
            invalid = false;
            foreach (char s in natID.Text)
                invalid |= (s < '0' || s > '9');

            if (invalid || natID.Text.Length != 14 || natID.Text[0] == '0')
            {
                MessageBox.Show("Please enter a valid National ID containg only 14 digits");
                return;
            }

            if(decimal.Parse(natID.Text) != (decimal)employee.SelectedValue && controllerObj.isEmployeeExists(decimal.Parse(natID.Text)))
            {
                MessageBox.Show("This Employee National ID Exists Already");
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

            decimal.TryParse(natID.Text, out empID);

            try
            {
                controllerObj.UpdateEmployee((decimal)employee.SelectedValue, empID, name.Text, address.Text, sal, job.SelectedValue.ToString());
                MessageBox.Show("User Updated Successfully");
                load();
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void viewEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
