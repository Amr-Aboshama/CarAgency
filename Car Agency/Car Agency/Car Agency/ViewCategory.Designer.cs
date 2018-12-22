namespace Car_Agency
{
    partial class ViewCategory
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
            this.BrandComboBox = new MetroFramework.Controls.MetroComboBox();
            this.TypeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.CatlistBox = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // BrandComboBox
            // 
            this.BrandComboBox.FormattingEnabled = true;
            this.BrandComboBox.ItemHeight = 24;
            this.BrandComboBox.Location = new System.Drawing.Point(37, 112);
            this.BrandComboBox.Name = "BrandComboBox";
            this.BrandComboBox.Size = new System.Drawing.Size(138, 30);
            this.BrandComboBox.TabIndex = 0;
            this.BrandComboBox.UseSelectable = true;
            this.BrandComboBox.SelectedIndexChanged += new System.EventHandler(this.BrandComboBox_SelectedIndexChanged);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.ItemHeight = 24;
            this.TypeComboBox.Location = new System.Drawing.Point(207, 112);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(149, 30);
            this.TypeComboBox.TabIndex = 1;
            this.TypeComboBox.UseSelectable = true;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // CatlistBox
            // 
            this.CatlistBox.FormattingEnabled = true;
            this.CatlistBox.ItemHeight = 16;
            this.CatlistBox.Location = new System.Drawing.Point(37, 160);
            this.CatlistBox.Name = "CatlistBox";
            this.CatlistBox.Size = new System.Drawing.Size(319, 180);
            this.CatlistBox.TabIndex = 2;
            this.CatlistBox.DoubleClick += new System.EventHandler(this.CatlistBox_DoubleClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 343);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(182, 20);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "*Double-click  for more info";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(37, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Brand";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(207, 80);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 20);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Type";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(76, 376);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Insert New";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(251, 376);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 8;
            this.metroButton2.Text = "Refresh";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // ViewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 441);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CatlistBox);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.BrandComboBox);
            this.Name = "ViewCategory";
            this.Text = "View Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox BrandComboBox;
        private MetroFramework.Controls.MetroComboBox TypeComboBox;
        private System.Windows.Forms.ListBox CatlistBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}