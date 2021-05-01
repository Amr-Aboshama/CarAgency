namespace Car_Agency
{
	partial class userBankManager
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
			this.metroTile4 = new MetroFramework.Controls.MetroTile();
			this.metroTile2 = new MetroFramework.Controls.MetroTile();
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			this.SuspendLayout();
			// 
			// metroTile4
			// 
			this.metroTile4.ActiveControl = null;
			this.metroTile4.Location = new System.Drawing.Point(23, 187);
			this.metroTile4.Name = "metroTile4";
			this.metroTile4.Size = new System.Drawing.Size(565, 56);
			this.metroTile4.Style = MetroFramework.MetroColorStyle.Red;
			this.metroTile4.TabIndex = 11;
			this.metroTile4.Text = "Sales And Purchases";
			this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile4.UseSelectable = true;
			this.metroTile4.Click += new System.EventHandler(this.metroButton3_Click);
			// 
			// metroTile2
			// 
			this.metroTile2.ActiveControl = null;
			this.metroTile2.Location = new System.Drawing.Point(23, 125);
			this.metroTile2.Name = "metroTile2";
			this.metroTile2.Size = new System.Drawing.Size(565, 56);
			this.metroTile2.Style = MetroFramework.MetroColorStyle.Red;
			this.metroTile2.TabIndex = 10;
			this.metroTile2.Text = "Bank Accounts Status";
			this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile2.UseSelectable = true;
			this.metroTile2.Click += new System.EventHandler(this.metroButton2_Click);
			// 
			// metroTile1
			// 
			this.metroTile1.ActiveControl = null;
			this.metroTile1.Location = new System.Drawing.Point(23, 63);
			this.metroTile1.Name = "metroTile1";
			this.metroTile1.Size = new System.Drawing.Size(565, 56);
			this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
			this.metroTile1.TabIndex = 9;
			this.metroTile1.Text = "Add Transaction";
			this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile1.UseSelectable = true;
			this.metroTile1.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// userBankManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 266);
			this.Controls.Add(this.metroTile4);
			this.Controls.Add(this.metroTile2);
			this.Controls.Add(this.metroTile1);
			this.Name = "userBankManager";
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "Bank Manager";
			this.Theme = MetroFramework.MetroThemeStyle.Default;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.userBankManager_FormClosed);
			this.Load += new System.EventHandler(this.BankManager_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private MetroFramework.Controls.MetroTile metroTile4;
		private MetroFramework.Controls.MetroTile metroTile2;
		private MetroFramework.Controls.MetroTile metroTile1;
	}
}