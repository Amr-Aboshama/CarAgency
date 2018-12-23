namespace Car_Agency
{
	partial class BankManager
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
			this.metroButton3 = new MetroFramework.Controls.MetroButton();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// metroButton3
			// 
			this.metroButton3.Location = new System.Drawing.Point(23, 193);
			this.metroButton3.Name = "metroButton3";
			this.metroButton3.Size = new System.Drawing.Size(565, 59);
			this.metroButton3.TabIndex = 8;
			this.metroButton3.Text = "Sales and Purchases";
			this.metroButton3.UseSelectable = true;
			this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
			// 
			// metroButton2
			// 
			this.metroButton2.Location = new System.Drawing.Point(23, 128);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(565, 59);
			this.metroButton2.TabIndex = 6;
			this.metroButton2.Text = "Bank Accounts Status";
			this.metroButton2.UseSelectable = true;
			this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(23, 63);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(565, 59);
			this.metroButton1.TabIndex = 5;
			this.metroButton1.Text = "Add Transaction";
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// BankManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 275);
			this.Controls.Add(this.metroButton3);
			this.Controls.Add(this.metroButton2);
			this.Controls.Add(this.metroButton1);
			this.Name = "BankManager";
			this.Text = "BankManager";
			this.Load += new System.EventHandler(this.BankManager_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private MetroFramework.Controls.MetroButton metroButton3;
		private MetroFramework.Controls.MetroButton metroButton2;
		private MetroFramework.Controls.MetroButton metroButton1;
	}
}