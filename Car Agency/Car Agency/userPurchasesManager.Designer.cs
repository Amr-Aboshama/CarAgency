﻿namespace Car_Agency
{
	partial class userPurchasesManager
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
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			this.metroTile2 = new MetroFramework.Controls.MetroTile();
			this.metroTile3 = new MetroFramework.Controls.MetroTile();
			this.metroTile4 = new MetroFramework.Controls.MetroTile();
			this.SuspendLayout();
			// 
			// metroTile1
			// 
			this.metroTile1.ActiveControl = null;
			this.metroTile1.Location = new System.Drawing.Point(23, 63);
			this.metroTile1.Name = "metroTile1";
			this.metroTile1.Size = new System.Drawing.Size(568, 56);
			this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
			this.metroTile1.TabIndex = 0;
			this.metroTile1.Text = "View Suppliers";
			this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile1.UseSelectable = true;
			this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
			// 
			// metroTile2
			// 
			this.metroTile2.ActiveControl = null;
			this.metroTile2.Location = new System.Drawing.Point(23, 125);
			this.metroTile2.Name = "metroTile2";
			this.metroTile2.Size = new System.Drawing.Size(568, 56);
			this.metroTile2.Style = MetroFramework.MetroColorStyle.Red;
			this.metroTile2.TabIndex = 1;
			this.metroTile2.Text = "Purchase New Car";
			this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile2.UseSelectable = true;
			this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
			// 
			// metroTile3
			// 
			this.metroTile3.ActiveControl = null;
			this.metroTile3.Location = new System.Drawing.Point(23, 249);
			this.metroTile3.Name = "metroTile3";
			this.metroTile3.Size = new System.Drawing.Size(568, 56);
			this.metroTile3.Style = MetroFramework.MetroColorStyle.Red;
			this.metroTile3.TabIndex = 3;
			this.metroTile3.Text = "View Available Cars";
			this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile3.UseSelectable = true;
			this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
			// 
			// metroTile4
			// 
			this.metroTile4.ActiveControl = null;
			this.metroTile4.Location = new System.Drawing.Point(23, 187);
			this.metroTile4.Name = "metroTile4";
			this.metroTile4.Size = new System.Drawing.Size(568, 56);
			this.metroTile4.Style = MetroFramework.MetroColorStyle.Red;
			this.metroTile4.TabIndex = 2;
			this.metroTile4.Text = "View Categories";
			this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile4.UseSelectable = true;
			this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
			// 
			// userPurchasesManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(614, 328);
			this.Controls.Add(this.metroTile3);
			this.Controls.Add(this.metroTile4);
			this.Controls.Add(this.metroTile2);
			this.Controls.Add(this.metroTile1);
			this.Name = "userPurchasesManager";
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "Purchases Manager";
			this.Theme = MetroFramework.MetroThemeStyle.Default;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.userPurchasesManager_FormClosed);
			this.Load += new System.EventHandler(this.userPurchasesManaher_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTile metroTile1;
		private MetroFramework.Controls.MetroTile metroTile2;
		private MetroFramework.Controls.MetroTile metroTile3;
		private MetroFramework.Controls.MetroTile metroTile4;
	}
}