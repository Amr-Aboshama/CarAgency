namespace Car_Agency
{
    partial class AddJob
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
            this.JobNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // JobNameTextBox
            // 
            // 
            // 
            // 
            this.JobNameTextBox.CustomButton.Image = null;
            this.JobNameTextBox.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.JobNameTextBox.CustomButton.Name = "";
            this.JobNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.JobNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.JobNameTextBox.CustomButton.TabIndex = 1;
            this.JobNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.JobNameTextBox.CustomButton.UseSelectable = true;
            this.JobNameTextBox.CustomButton.Visible = false;
            this.JobNameTextBox.Lines = new string[0];
            this.JobNameTextBox.Location = new System.Drawing.Point(137, 100);
            this.JobNameTextBox.MaxLength = 32767;
            this.JobNameTextBox.Name = "JobNameTextBox";
            this.JobNameTextBox.PasswordChar = '\0';
            this.JobNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.JobNameTextBox.SelectedText = "";
            this.JobNameTextBox.SelectionLength = 0;
            this.JobNameTextBox.SelectionStart = 0;
            this.JobNameTextBox.ShortcutsEnabled = true;
            this.JobNameTextBox.Size = new System.Drawing.Size(171, 23);
            this.JobNameTextBox.Style = MetroFramework.MetroColorStyle.Red;
            this.JobNameTextBox.TabIndex = 0;
            this.JobNameTextBox.UseSelectable = true;
            this.JobNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.JobNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(48, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Job Name";
            // 
            // metroButton1
            // 
            this.metroButton1.AutoSize = true;
            this.metroButton1.Location = new System.Drawing.Point(137, 168);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(83, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Add";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // AddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 226);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.JobNameTextBox);
            this.Name = "AddJob";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Add Job";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddJob_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox JobNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}