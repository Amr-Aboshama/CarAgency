namespace Car_Agency
{
    partial class viewEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.searchJob = new MetroFramework.Controls.MetroComboBox();
            this.employee = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.natID = new MetroFramework.Controls.MetroTextBox();
            this.name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.address = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.salary = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.job = new MetroFramework.Controls.MetroComboBox();
            this.EditMode = new MetroFramework.Controls.MetroButton();
            this.Apply = new MetroFramework.Controls.MetroButton();
            this.RemoveEmployee = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Search By Job:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(20, 150);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(118, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Choose Employee:";
            // 
            // searchJob
            // 
            this.searchJob.FormattingEnabled = true;
            this.searchJob.ItemHeight = 23;
            this.searchJob.Location = new System.Drawing.Point(163, 100);
            this.searchJob.Name = "searchJob";
            this.searchJob.Size = new System.Drawing.Size(165, 29);
            this.searchJob.Style = MetroFramework.MetroColorStyle.Red;
            this.searchJob.TabIndex = 2;
            this.searchJob.UseSelectable = true;
            this.searchJob.SelectedIndexChanged += new System.EventHandler(this.searchJob_SelectedIndexChanged);
            // 
            // employee
            // 
            this.employee.FormattingEnabled = true;
            this.employee.ItemHeight = 23;
            this.employee.Location = new System.Drawing.Point(163, 150);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(165, 29);
            this.employee.Style = MetroFramework.MetroColorStyle.Red;
            this.employee.TabIndex = 3;
            this.employee.UseSelectable = true;
            this.employee.SelectedIndexChanged += new System.EventHandler(this.employee_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(20, 200);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "National ID:";
            this.metroLabel3.Visible = false;
            // 
            // natID
            // 
            // 
            // 
            // 
            this.natID.CustomButton.Image = null;
            this.natID.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.natID.CustomButton.Name = "";
            this.natID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.natID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.natID.CustomButton.TabIndex = 1;
            this.natID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.natID.CustomButton.UseSelectable = true;
            this.natID.CustomButton.Visible = false;
            this.natID.Lines = new string[0];
            this.natID.Location = new System.Drawing.Point(163, 200);
            this.natID.MaxLength = 32767;
            this.natID.Name = "natID";
            this.natID.PasswordChar = '\0';
            this.natID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.natID.SelectedText = "";
            this.natID.SelectionLength = 0;
            this.natID.SelectionStart = 0;
            this.natID.ShortcutsEnabled = true;
            this.natID.Size = new System.Drawing.Size(165, 23);
            this.natID.Style = MetroFramework.MetroColorStyle.Red;
            this.natID.TabIndex = 5;
            this.natID.UseSelectable = true;
            this.natID.Visible = false;
            this.natID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.natID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // name
            // 
            // 
            // 
            // 
            this.name.CustomButton.Image = null;
            this.name.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.name.CustomButton.Name = "";
            this.name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.name.CustomButton.TabIndex = 1;
            this.name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.name.CustomButton.UseSelectable = true;
            this.name.CustomButton.Visible = false;
            this.name.Lines = new string[0];
            this.name.Location = new System.Drawing.Point(163, 250);
            this.name.MaxLength = 32767;
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name.SelectedText = "";
            this.name.SelectionLength = 0;
            this.name.SelectionStart = 0;
            this.name.ShortcutsEnabled = true;
            this.name.Size = new System.Drawing.Size(165, 23);
            this.name.Style = MetroFramework.MetroColorStyle.Red;
            this.name.TabIndex = 7;
            this.name.UseSelectable = true;
            this.name.Visible = false;
            this.name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(20, 250);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Name:";
            this.metroLabel4.Visible = false;
            // 
            // address
            // 
            // 
            // 
            // 
            this.address.CustomButton.Image = null;
            this.address.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.address.CustomButton.Name = "";
            this.address.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.address.CustomButton.TabIndex = 1;
            this.address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.address.CustomButton.UseSelectable = true;
            this.address.CustomButton.Visible = false;
            this.address.Lines = new string[0];
            this.address.Location = new System.Drawing.Point(163, 300);
            this.address.MaxLength = 32767;
            this.address.Name = "address";
            this.address.PasswordChar = '\0';
            this.address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.address.SelectedText = "";
            this.address.SelectionLength = 0;
            this.address.SelectionStart = 0;
            this.address.ShortcutsEnabled = true;
            this.address.Size = new System.Drawing.Size(165, 23);
            this.address.Style = MetroFramework.MetroColorStyle.Red;
            this.address.TabIndex = 9;
            this.address.UseSelectable = true;
            this.address.Visible = false;
            this.address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(20, 300);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Address:";
            this.metroLabel5.Visible = false;
            // 
            // salary
            // 
            // 
            // 
            // 
            this.salary.CustomButton.Image = null;
            this.salary.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.salary.CustomButton.Name = "";
            this.salary.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.salary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.salary.CustomButton.TabIndex = 1;
            this.salary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salary.CustomButton.UseSelectable = true;
            this.salary.CustomButton.Visible = false;
            this.salary.Lines = new string[0];
            this.salary.Location = new System.Drawing.Point(163, 350);
            this.salary.MaxLength = 32767;
            this.salary.Name = "salary";
            this.salary.PasswordChar = '\0';
            this.salary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.salary.SelectedText = "";
            this.salary.SelectionLength = 0;
            this.salary.SelectionStart = 0;
            this.salary.ShortcutsEnabled = true;
            this.salary.Size = new System.Drawing.Size(165, 23);
            this.salary.Style = MetroFramework.MetroColorStyle.Red;
            this.salary.TabIndex = 11;
            this.salary.UseSelectable = true;
            this.salary.Visible = false;
            this.salary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.salary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(20, 350);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(48, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Salary:";
            this.metroLabel6.Visible = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(20, 400);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(33, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Job:";
            this.metroLabel7.Visible = false;
            // 
            // job
            // 
            this.job.FormattingEnabled = true;
            this.job.ItemHeight = 23;
            this.job.Location = new System.Drawing.Point(163, 400);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(165, 29);
            this.job.Style = MetroFramework.MetroColorStyle.Red;
            this.job.TabIndex = 13;
            this.job.UseSelectable = true;
            this.job.Visible = false;
            // 
            // EditMode
            // 
            this.EditMode.Location = new System.Drawing.Point(350, 250);
            this.EditMode.Name = "EditMode";
            this.EditMode.Size = new System.Drawing.Size(144, 23);
            this.EditMode.Style = MetroFramework.MetroColorStyle.Red;
            this.EditMode.TabIndex = 15;
            this.EditMode.Text = "Change to Edit Mode";
            this.EditMode.UseSelectable = true;
            this.EditMode.Visible = false;
            this.EditMode.Click += new System.EventHandler(this.EditMode_Click);
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(350, 300);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(144, 23);
            this.Apply.Style = MetroFramework.MetroColorStyle.Red;
            this.Apply.TabIndex = 16;
            this.Apply.Text = "Apply Changes";
            this.Apply.UseSelectable = true;
            this.Apply.Visible = false;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // RemoveEmployee
            // 
            this.RemoveEmployee.Location = new System.Drawing.Point(350, 381);
            this.RemoveEmployee.Name = "RemoveEmployee";
            this.RemoveEmployee.Size = new System.Drawing.Size(144, 23);
            this.RemoveEmployee.Style = MetroFramework.MetroColorStyle.Red;
            this.RemoveEmployee.TabIndex = 17;
            this.RemoveEmployee.Text = "Remove Employee";
            this.RemoveEmployee.UseSelectable = true;
            this.RemoveEmployee.Visible = false;
            this.RemoveEmployee.Click += new System.EventHandler(this.RemoveEmployee_Click);
            // 
            // viewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 447);
            this.Controls.Add(this.RemoveEmployee);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.EditMode);
            this.Controls.Add(this.job);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.address);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.name);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.natID);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.searchJob);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "viewEmployee";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "View/Edit Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox searchJob;
        private MetroFramework.Controls.MetroComboBox employee;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox natID;
        private MetroFramework.Controls.MetroTextBox name;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox address;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox salary;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox job;
        private MetroFramework.Controls.MetroButton EditMode;
        private MetroFramework.Controls.MetroButton Apply;
        private MetroFramework.Controls.MetroButton RemoveEmployee;
    }
}