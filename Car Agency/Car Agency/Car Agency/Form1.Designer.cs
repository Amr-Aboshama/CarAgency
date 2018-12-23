namespace Car_Agency
{
    partial class Form1
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
            this.MaxSalaryLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.EmpNumLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.salaryLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.carLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(482, 158);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(110, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Maximum Salary";
            // 
            // MaxSalaryLabel
            // 
            this.MaxSalaryLabel.AutoSize = true;
            this.MaxSalaryLabel.Location = new System.Drawing.Point(667, 158);
            this.MaxSalaryLabel.Name = "MaxSalaryLabel";
            this.MaxSalaryLabel.Size = new System.Drawing.Size(110, 20);
            this.MaxSalaryLabel.TabIndex = 1;
            this.MaxSalaryLabel.Text = "Maximum Salary";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(152, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Number Of Employees";
            // 
            // EmpNumLabel
            // 
            this.EmpNumLabel.AutoSize = true;
            this.EmpNumLabel.Location = new System.Drawing.Point(253, 90);
            this.EmpNumLabel.Name = "EmpNumLabel";
            this.EmpNumLabel.Size = new System.Drawing.Size(152, 20);
            this.EmpNumLabel.TabIndex = 3;
            this.EmpNumLabel.Text = "Number Of Employees";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 158);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Sum Of Salary";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(253, 158);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(45, 20);
            this.salaryLabel.TabIndex = 5;
            this.salaryLabel.Text = "salary";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(14, 235);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(170, 20);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Number Of Available Cars";
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Location = new System.Drawing.Point(253, 235);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(170, 20);
            this.carLabel.TabIndex = 7;
            this.carLabel.Text = "Number Of Available Cars";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.carLabel);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.EmpNumLabel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.MaxSalaryLabel);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel MaxSalaryLabel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel EmpNumLabel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel salaryLabel;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel carLabel;
    }
}