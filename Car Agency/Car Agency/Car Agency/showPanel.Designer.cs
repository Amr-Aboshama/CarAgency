namespace Car_Agency
{
    partial class showPanel
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
            this.privileges = new MetroFramework.Controls.MetroComboBox();
            this.showPropertiesButton = new MetroFramework.Controls.MetroButton();
            this.LogoutButton = new MetroFramework.Controls.MetroButton();
            this.adminPanelButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Privilege:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // privileges
            // 
            this.privileges.FormattingEnabled = true;
            this.privileges.ItemHeight = 23;
            this.privileges.Location = new System.Drawing.Point(90, 100);
            this.privileges.Name = "privileges";
            this.privileges.Size = new System.Drawing.Size(183, 29);
            this.privileges.Style = MetroFramework.MetroColorStyle.Silver;
            this.privileges.TabIndex = 1;
            this.privileges.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.privileges.UseSelectable = true;
            // 
            // showPropertiesButton
            // 
            this.showPropertiesButton.Location = new System.Drawing.Point(99, 155);
            this.showPropertiesButton.Name = "showPropertiesButton";
            this.showPropertiesButton.Size = new System.Drawing.Size(108, 23);
            this.showPropertiesButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.showPropertiesButton.TabIndex = 2;
            this.showPropertiesButton.Text = "Show Properties";
            this.showPropertiesButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.showPropertiesButton.UseSelectable = true;
            this.showPropertiesButton.Click += new System.EventHandler(this.showPropertiesButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(99, 187);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(108, 23);
            this.LogoutButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LogoutButton.UseSelectable = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // adminPanelButton
            // 
            this.adminPanelButton.Location = new System.Drawing.Point(99, 216);
            this.adminPanelButton.Name = "adminPanelButton";
            this.adminPanelButton.Size = new System.Drawing.Size(108, 23);
            this.adminPanelButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.adminPanelButton.TabIndex = 4;
            this.adminPanelButton.Text = "Admin Panel";
            this.adminPanelButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.adminPanelButton.UseSelectable = true;
            this.adminPanelButton.Visible = false;
            // 
            // showPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 269);
            this.Controls.Add(this.adminPanelButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.showPropertiesButton);
            this.Controls.Add(this.privileges);
            this.Controls.Add(this.metroLabel1);
            this.Name = "showPanel";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "User Panel";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.showPrivileges_FormClosed);
            this.Load += new System.EventHandler(this.showPrivileges_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox privileges;
        private MetroFramework.Controls.MetroButton showPropertiesButton;
        private MetroFramework.Controls.MetroButton LogoutButton;
        private MetroFramework.Controls.MetroButton adminPanelButton;
    }
}