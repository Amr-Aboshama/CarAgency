namespace Car_Agency
{
    partial class RequestCategory
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.InsertMetroButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.RequestMetroButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.BrandmetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.TypemetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.CustmetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(23, 260);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 228);
            this.listBox1.TabIndex = 2;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 20);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Brand";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 152);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Type";
            // 
            // InsertMetroButton
            // 
            this.InsertMetroButton.Location = new System.Drawing.Point(590, 415);
            this.InsertMetroButton.Name = "InsertMetroButton";
            this.InsertMetroButton.Size = new System.Drawing.Size(96, 31);
            this.InsertMetroButton.TabIndex = 6;
            this.InsertMetroButton.Text = "Insert New Category";
            this.InsertMetroButton.UseSelectable = true;
            this.InsertMetroButton.Click += new System.EventHandler(this.InsertMetroButton_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 225);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 20);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Category";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(27, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(223, 223);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(316, 260);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(253, 228);
            this.metroTextBox1.TabIndex = 9;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(316, 225);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 20);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Notes";
            // 
            // RequestMetroButton
            // 
            this.RequestMetroButton.Location = new System.Drawing.Point(590, 452);
            this.RequestMetroButton.Name = "RequestMetroButton";
            this.RequestMetroButton.Size = new System.Drawing.Size(96, 31);
            this.RequestMetroButton.TabIndex = 11;
            this.RequestMetroButton.Text = "Request";
            this.RequestMetroButton.UseSelectable = true;
            this.RequestMetroButton.Click += new System.EventHandler(this.RequestMetroButton_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 499);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(178, 20);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "*Double-click for more info";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(316, 152);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 20);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Customers";
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(316, 115);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(155, 17);
            this.metroCheckBox1.TabIndex = 16;
            this.metroCheckBox1.Text = "For a certain customer";
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // BrandmetroComboBox
            // 
            this.BrandmetroComboBox.FormattingEnabled = true;
            this.BrandmetroComboBox.ItemHeight = 24;
            this.BrandmetroComboBox.Location = new System.Drawing.Point(23, 106);
            this.BrandmetroComboBox.Name = "BrandmetroComboBox";
            this.BrandmetroComboBox.Size = new System.Drawing.Size(253, 30);
            this.BrandmetroComboBox.TabIndex = 17;
            this.BrandmetroComboBox.UseSelectable = true;
            this.BrandmetroComboBox.SelectedIndexChanged += new System.EventHandler(this.BrandmetroComboBox_SelectedIndexChanged);
            // 
            // TypemetroComboBox
            // 
            this.TypemetroComboBox.FormattingEnabled = true;
            this.TypemetroComboBox.ItemHeight = 24;
            this.TypemetroComboBox.Location = new System.Drawing.Point(23, 175);
            this.TypemetroComboBox.Name = "TypemetroComboBox";
            this.TypemetroComboBox.Size = new System.Drawing.Size(253, 30);
            this.TypemetroComboBox.TabIndex = 18;
            this.TypemetroComboBox.UseSelectable = true;
            this.TypemetroComboBox.SelectedIndexChanged += new System.EventHandler(this.TypemetroComboBox_SelectedIndexChanged);
            // 
            // CustmetroComboBox
            // 
            this.CustmetroComboBox.FormattingEnabled = true;
            this.CustmetroComboBox.ItemHeight = 24;
            this.CustmetroComboBox.Location = new System.Drawing.Point(316, 175);
            this.CustmetroComboBox.Name = "CustmetroComboBox";
            this.CustmetroComboBox.Size = new System.Drawing.Size(253, 30);
            this.CustmetroComboBox.TabIndex = 19;
            this.CustmetroComboBox.UseSelectable = true;
            // 
            // RequestCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 539);
            this.Controls.Add(this.CustmetroComboBox);
            this.Controls.Add(this.TypemetroComboBox);
            this.Controls.Add(this.BrandmetroComboBox);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.RequestMetroButton);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.InsertMetroButton);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listBox1);
            this.Name = "RequestCategory";
            this.Text = "Request Category";
            this.Activated += new System.EventHandler(this.RequestCategory_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton InsertMetroButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton RequestMetroButton;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroComboBox BrandmetroComboBox;
        private MetroFramework.Controls.MetroComboBox TypemetroComboBox;
        private MetroFramework.Controls.MetroComboBox CustmetroComboBox;
    }
}