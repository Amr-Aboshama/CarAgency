namespace Car_Agency
{
    partial class viewUser
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
            this.EditMode = new MetroFramework.Controls.MetroButton();
            this.Apply = new MetroFramework.Controls.MetroButton();
            this.RemoveUser = new MetroFramework.Controls.MetroButton();
            this.privileges = new MetroFramework.Controls.MetroListView();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.repassword = new MetroFramework.Controls.MetroTextBox();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.username = new MetroFramework.Controls.MetroComboBox();
            this.employee = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.inputUsername = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // EditMode
            // 
            this.EditMode.Location = new System.Drawing.Point(64, 342);
            this.EditMode.Name = "EditMode";
            this.EditMode.Size = new System.Drawing.Size(130, 23);
            this.EditMode.Style = MetroFramework.MetroColorStyle.Red;
            this.EditMode.TabIndex = 29;
            this.EditMode.Text = "Change to Edit Mode";
            this.EditMode.UseSelectable = true;
            this.EditMode.Visible = false;
            this.EditMode.Click += new System.EventHandler(this.EditMode_Click);
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(200, 342);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(130, 23);
            this.Apply.Style = MetroFramework.MetroColorStyle.Red;
            this.Apply.TabIndex = 30;
            this.Apply.Text = "Apply Changes";
            this.Apply.UseSelectable = true;
            this.Apply.Visible = false;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // RemoveUser
            // 
            this.RemoveUser.Location = new System.Drawing.Point(336, 342);
            this.RemoveUser.Name = "RemoveUser";
            this.RemoveUser.Size = new System.Drawing.Size(130, 23);
            this.RemoveUser.Style = MetroFramework.MetroColorStyle.Red;
            this.RemoveUser.TabIndex = 31;
            this.RemoveUser.Text = "Remove User";
            this.RemoveUser.UseSelectable = true;
            this.RemoveUser.Visible = false;
            this.RemoveUser.Click += new System.EventHandler(this.RemoveUser_Click);
            // 
            // privileges
            // 
            this.privileges.CheckBoxes = true;
            this.privileges.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.privileges.FullRowSelect = true;
            this.privileges.Location = new System.Drawing.Point(347, 174);
            this.privileges.Name = "privileges";
            this.privileges.OwnerDraw = true;
            this.privileges.Size = new System.Drawing.Size(159, 155);
            this.privileges.Style = MetroFramework.MetroColorStyle.Red;
            this.privileges.TabIndex = 41;
            this.privileges.TileSize = new System.Drawing.Size(138, 25);
            this.privileges.UseCompatibleStateImageBehavior = false;
            this.privileges.UseSelectable = true;
            this.privileges.UseStyleColors = true;
            this.privileges.View = System.Windows.Forms.View.List;
            this.privileges.Visible = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(347, 150);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel5.TabIndex = 39;
            this.metroLabel5.Text = "Privileges";
            this.metroLabel5.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(27, 300);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(118, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel4.TabIndex = 38;
            this.metroLabel4.Text = "Choose Employee:";
            this.metroLabel4.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(27, 250);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(118, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel3.TabIndex = 37;
            this.metroLabel3.Text = "Re-Type Password:";
            this.metroLabel3.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 200);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 36;
            this.metroLabel2.Text = "Password:";
            this.metroLabel2.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(119, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "Choose Username:";
            // 
            // repassword
            // 
            // 
            // 
            // 
            this.repassword.CustomButton.Image = null;
            this.repassword.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.repassword.CustomButton.Name = "";
            this.repassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.repassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.repassword.CustomButton.TabIndex = 1;
            this.repassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.repassword.CustomButton.UseSelectable = true;
            this.repassword.CustomButton.Visible = false;
            this.repassword.Lines = new string[0];
            this.repassword.Location = new System.Drawing.Point(147, 250);
            this.repassword.MaxLength = 32767;
            this.repassword.Name = "repassword";
            this.repassword.PasswordChar = '●';
            this.repassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.repassword.SelectedText = "";
            this.repassword.SelectionLength = 0;
            this.repassword.SelectionStart = 0;
            this.repassword.ShortcutsEnabled = true;
            this.repassword.Size = new System.Drawing.Size(165, 23);
            this.repassword.Style = MetroFramework.MetroColorStyle.Red;
            this.repassword.TabIndex = 34;
            this.repassword.UseSelectable = true;
            this.repassword.UseSystemPasswordChar = true;
            this.repassword.Visible = false;
            this.repassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.repassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // password
            // 
            // 
            // 
            // 
            this.password.CustomButton.Image = null;
            this.password.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.password.CustomButton.Name = "";
            this.password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.CustomButton.TabIndex = 1;
            this.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.CustomButton.UseSelectable = true;
            this.password.CustomButton.Visible = false;
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(147, 200);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.ShortcutsEnabled = true;
            this.password.Size = new System.Drawing.Size(165, 23);
            this.password.Style = MetroFramework.MetroColorStyle.Red;
            this.password.TabIndex = 33;
            this.password.UseSelectable = true;
            this.password.UseSystemPasswordChar = true;
            this.password.Visible = false;
            this.password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // username
            // 
            this.username.FormattingEnabled = true;
            this.username.ItemHeight = 23;
            this.username.Location = new System.Drawing.Point(147, 100);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(165, 29);
            this.username.Style = MetroFramework.MetroColorStyle.Red;
            this.username.TabIndex = 42;
            this.username.UseSelectable = true;
            this.username.SelectedIndexChanged += new System.EventHandler(this.username_SelectedIndexChanged);
            // 
            // employee
            // 
            this.employee.FormattingEnabled = true;
            this.employee.ItemHeight = 23;
            this.employee.Location = new System.Drawing.Point(147, 300);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(165, 29);
            this.employee.Style = MetroFramework.MetroColorStyle.Red;
            this.employee.TabIndex = 40;
            this.employee.UseSelectable = true;
            this.employee.Visible = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(27, 150);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(71, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel6.TabIndex = 43;
            this.metroLabel6.Text = "Username:";
            // 
            // inputUsername
            // 
            // 
            // 
            // 
            this.inputUsername.CustomButton.Image = null;
            this.inputUsername.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.inputUsername.CustomButton.Name = "";
            this.inputUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.inputUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputUsername.CustomButton.TabIndex = 1;
            this.inputUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputUsername.CustomButton.UseSelectable = true;
            this.inputUsername.CustomButton.Visible = false;
            this.inputUsername.Lines = new string[0];
            this.inputUsername.Location = new System.Drawing.Point(147, 150);
            this.inputUsername.MaxLength = 32767;
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.PasswordChar = '\0';
            this.inputUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputUsername.SelectedText = "";
            this.inputUsername.SelectionLength = 0;
            this.inputUsername.SelectionStart = 0;
            this.inputUsername.ShortcutsEnabled = true;
            this.inputUsername.Size = new System.Drawing.Size(165, 23);
            this.inputUsername.Style = MetroFramework.MetroColorStyle.Red;
            this.inputUsername.TabIndex = 44;
            this.inputUsername.UseSelectable = true;
            this.inputUsername.Visible = false;
            this.inputUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inputUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // viewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 379);
            this.Controls.Add(this.inputUsername);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.username);
            this.Controls.Add(this.privileges);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.repassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.RemoveUser);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.EditMode);
            this.Name = "viewUser";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "View/Edit User";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.viewUser_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton EditMode;
        private MetroFramework.Controls.MetroButton Apply;
        private MetroFramework.Controls.MetroButton RemoveUser;
        private MetroFramework.Controls.MetroListView privileges;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox repassword;
        private MetroFramework.Controls.MetroTextBox password;
        private MetroFramework.Controls.MetroComboBox username;
        private MetroFramework.Controls.MetroComboBox employee;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox inputUsername;
    }
}