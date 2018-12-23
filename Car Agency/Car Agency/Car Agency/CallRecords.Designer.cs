namespace Car_Agency
{
	partial class CallRecords
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
			this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
			this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(23, 73);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(69, 20);
			this.metroLabel1.TabIndex = 1;
			this.metroLabel1.Text = "Customer";
			// 
			// metroComboBox1
			// 
			this.metroComboBox1.FormattingEnabled = true;
			this.metroComboBox1.ItemHeight = 24;
			this.metroComboBox1.Location = new System.Drawing.Point(116, 63);
			this.metroComboBox1.Name = "metroComboBox1";
			this.metroComboBox1.Size = new System.Drawing.Size(402, 30);
			this.metroComboBox1.TabIndex = 2;
			this.metroComboBox1.UseSelectable = true;
			// 
			// metroTextBox1
			// 
			// 
			// 
			// 
			this.metroTextBox1.CustomButton.Image = null;
			this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(76, 2);
			this.metroTextBox1.CustomButton.Name = "";
			this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(323, 323);
			this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroTextBox1.CustomButton.TabIndex = 1;
			this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroTextBox1.CustomButton.UseSelectable = true;
			this.metroTextBox1.CustomButton.Visible = false;
			this.metroTextBox1.Lines = new string[0];
			this.metroTextBox1.Location = new System.Drawing.Point(116, 99);
			this.metroTextBox1.MaxLength = 32767;
			this.metroTextBox1.Multiline = true;
			this.metroTextBox1.Name = "metroTextBox1";
			this.metroTextBox1.PasswordChar = '\0';
			this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.metroTextBox1.SelectedText = "";
			this.metroTextBox1.SelectionLength = 0;
			this.metroTextBox1.SelectionStart = 0;
			this.metroTextBox1.ShortcutsEnabled = true;
			this.metroTextBox1.Size = new System.Drawing.Size(402, 328);
			this.metroTextBox1.TabIndex = 3;
			this.metroTextBox1.UseSelectable = true;
			this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(23, 99);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(46, 20);
			this.metroLabel2.TabIndex = 4;
			this.metroLabel2.Text = "Notes";
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(393, 433);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(125, 34);
			this.metroButton1.TabIndex = 5;
			this.metroButton1.Text = "Add";
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// CallRecords
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 490);
			this.Controls.Add(this.metroButton1);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroTextBox1);
			this.Controls.Add(this.metroComboBox1);
			this.Controls.Add(this.metroLabel1);
			this.Name = "CallRecords";
			this.Text = "Call Records";
			this.Load += new System.EventHandler(this.CallRecords_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroComboBox metroComboBox1;
		private MetroFramework.Controls.MetroTextBox metroTextBox1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroButton metroButton1;
	}
}