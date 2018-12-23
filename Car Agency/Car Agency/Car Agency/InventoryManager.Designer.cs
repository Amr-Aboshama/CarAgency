namespace Car_Agency
{
	partial class InventoryManager
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
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// metroButton2
			// 
			this.metroButton2.Location = new System.Drawing.Point(23, 128);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(565, 59);
			this.metroButton2.TabIndex = 10;
			this.metroButton2.Text = "Add New Car to Store";
			this.metroButton2.UseSelectable = true;
			this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(23, 63);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(565, 59);
			this.metroButton1.TabIndex = 9;
			this.metroButton1.Text = "View Purchased Cars";
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// InventoryManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(608, 210);
			this.Controls.Add(this.metroButton2);
			this.Controls.Add(this.metroButton1);
			this.Name = "InventoryManager";
			this.Text = "InventoryManager";
			this.Load += new System.EventHandler(this.InventoryManager_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroButton metroButton2;
		private MetroFramework.Controls.MetroButton metroButton1;
	}
}