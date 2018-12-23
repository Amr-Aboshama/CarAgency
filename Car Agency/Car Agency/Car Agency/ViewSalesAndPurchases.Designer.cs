namespace Car_Agency
{
	partial class ViewSalesAndPurchases
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
			this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
			this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
			this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.metroTabControl1.SuspendLayout();
			this.metroTabPage1.SuspendLayout();
			this.metroTabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// metroTabControl1
			// 
			this.metroTabControl1.Controls.Add(this.metroTabPage1);
			this.metroTabControl1.Controls.Add(this.metroTabPage2);
			this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
			this.metroTabControl1.Name = "metroTabControl1";
			this.metroTabControl1.SelectedIndex = 1;
			this.metroTabControl1.Size = new System.Drawing.Size(862, 463);
			this.metroTabControl1.TabIndex = 4;
			this.metroTabControl1.UseSelectable = true;
			// 
			// metroTabPage1
			// 
			this.metroTabPage1.Controls.Add(this.metroCheckBox1);
			this.metroTabPage1.Controls.Add(this.metroButton1);
			this.metroTabPage1.Controls.Add(this.dataGridView1);
			this.metroTabPage1.HorizontalScrollbarBarColor = true;
			this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.HorizontalScrollbarSize = 10;
			this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage1.Name = "metroTabPage1";
			this.metroTabPage1.Size = new System.Drawing.Size(854, 421);
			this.metroTabPage1.TabIndex = 0;
			this.metroTabPage1.Text = "Sales";
			this.metroTabPage1.VerticalScrollbarBarColor = true;
			this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.VerticalScrollbarSize = 10;
			// 
			// metroTabPage2
			// 
			this.metroTabPage2.Controls.Add(this.metroCheckBox2);
			this.metroTabPage2.Controls.Add(this.metroButton2);
			this.metroTabPage2.Controls.Add(this.dataGridView2);
			this.metroTabPage2.HorizontalScrollbarBarColor = true;
			this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.HorizontalScrollbarSize = 10;
			this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage2.Name = "metroTabPage2";
			this.metroTabPage2.Size = new System.Drawing.Size(854, 421);
			this.metroTabPage2.TabIndex = 1;
			this.metroTabPage2.Text = "Purchases";
			this.metroTabPage2.VerticalScrollbarBarColor = true;
			this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.VerticalScrollbarSize = 10;
			// 
			// metroCheckBox1
			// 
			this.metroCheckBox1.AutoSize = true;
			this.metroCheckBox1.ForeColor = System.Drawing.Color.Black;
			this.metroCheckBox1.Location = new System.Drawing.Point(727, 3);
			this.metroCheckBox1.Name = "metroCheckBox1";
			this.metroCheckBox1.Size = new System.Drawing.Size(101, 17);
			this.metroCheckBox1.TabIndex = 11;
			this.metroCheckBox1.Text = "Pending Only";
			this.metroCheckBox1.UseSelectable = true;
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(730, 390);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(121, 28);
			this.metroButton1.TabIndex = 11;
			this.metroButton1.Text = "Details";
			this.metroButton1.UseSelectable = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.NullValue = null;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(3, 26);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(848, 358);
			this.dataGridView1.TabIndex = 9;
			// 
			// metroCheckBox2
			// 
			this.metroCheckBox2.AutoSize = true;
			this.metroCheckBox2.ForeColor = System.Drawing.Color.Black;
			this.metroCheckBox2.Location = new System.Drawing.Point(727, 3);
			this.metroCheckBox2.Name = "metroCheckBox2";
			this.metroCheckBox2.Size = new System.Drawing.Size(101, 17);
			this.metroCheckBox2.TabIndex = 14;
			this.metroCheckBox2.Text = "Pending Only";
			this.metroCheckBox2.UseSelectable = true;
			// 
			// metroButton2
			// 
			this.metroButton2.Location = new System.Drawing.Point(730, 390);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(121, 28);
			this.metroButton2.TabIndex = 13;
			this.metroButton2.Text = "Details";
			this.metroButton2.UseSelectable = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AllowUserToOrderColumns = true;
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.NullValue = null;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(3, 26);
			this.dataGridView2.MultiSelect = false;
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView2.Size = new System.Drawing.Size(848, 358);
			this.dataGridView2.TabIndex = 12;
			// 
			// ViewSalesAndPurchases
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(908, 549);
			this.Controls.Add(this.metroTabControl1);
			this.Name = "ViewSalesAndPurchases";
			this.Text = "Sales And Purchases";
			this.Load += new System.EventHandler(this.ViewSalesAndPurchases_Load);
			this.metroTabControl1.ResumeLayout(false);
			this.metroTabPage1.ResumeLayout(false);
			this.metroTabPage1.PerformLayout();
			this.metroTabPage2.ResumeLayout(false);
			this.metroTabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTabControl metroTabControl1;
		private MetroFramework.Controls.MetroTabPage metroTabPage1;
		private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
		private MetroFramework.Controls.MetroButton metroButton1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private MetroFramework.Controls.MetroTabPage metroTabPage2;
		private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
		private MetroFramework.Controls.MetroButton metroButton2;
		private System.Windows.Forms.DataGridView dataGridView2;
	}
}