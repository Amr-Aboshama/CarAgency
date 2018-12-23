namespace Car_Agency
{
    partial class AvailableCars
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.brandCombobox = new MetroFramework.Controls.MetroComboBox();
            this.TypeCombobox = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.CatCombobox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Category = new MetroFramework.Controls.MetroLabel();
            this.SpecsTextbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.ModelTextbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.PriceTextbox = new MetroFramework.Controls.MetroTextBox();
            this.Currencylabel = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // brandCombobox
            // 
            this.brandCombobox.FormattingEnabled = true;
            this.brandCombobox.ItemHeight = 23;
            this.brandCombobox.Location = new System.Drawing.Point(17, 84);
            this.brandCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brandCombobox.Name = "brandCombobox";
            this.brandCombobox.Size = new System.Drawing.Size(150, 29);
            this.brandCombobox.Style = MetroFramework.MetroColorStyle.Red;
            this.brandCombobox.TabIndex = 0;
            this.brandCombobox.UseSelectable = true;
            this.brandCombobox.SelectedIndexChanged += new System.EventHandler(this.brandCombobox_SelectedIndexChanged);
            // 
            // TypeCombobox
            // 
            this.TypeCombobox.FormattingEnabled = true;
            this.TypeCombobox.ItemHeight = 23;
            this.TypeCombobox.Location = new System.Drawing.Point(228, 84);
            this.TypeCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TypeCombobox.Name = "TypeCombobox";
            this.TypeCombobox.Size = new System.Drawing.Size(150, 29);
            this.TypeCombobox.Style = MetroFramework.MetroColorStyle.Red;
            this.TypeCombobox.TabIndex = 1;
            this.TypeCombobox.UseSelectable = true;
            this.TypeCombobox.SelectedIndexChanged += new System.EventHandler(this.TypeCombobox_SelectedIndexChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(262, 491);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(96, 24);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Reserve";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // CatCombobox
            // 
            this.CatCombobox.FormattingEnabled = true;
            this.CatCombobox.ItemHeight = 23;
            this.CatCombobox.Location = new System.Drawing.Point(435, 84);
            this.CatCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CatCombobox.Name = "CatCombobox";
            this.CatCombobox.Size = new System.Drawing.Size(150, 29);
            this.CatCombobox.Style = MetroFramework.MetroColorStyle.Red;
            this.CatCombobox.TabIndex = 4;
            this.CatCombobox.UseSelectable = true;
            this.CatCombobox.SelectedIndexChanged += new System.EventHandler(this.CatCombobox_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 58);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Brand";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(228, 58);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Type";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(435, 58);
            this.Category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(64, 19);
            this.Category.Style = MetroFramework.MetroColorStyle.Red;
            this.Category.TabIndex = 7;
            this.Category.Text = "Category";
            // 
            // SpecsTextbox
            // 
            // 
            // 
            // 
            this.SpecsTextbox.CustomButton.Image = null;
            this.SpecsTextbox.CustomButton.Location = new System.Drawing.Point(-22, 2);
            this.SpecsTextbox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SpecsTextbox.CustomButton.Name = "";
            this.SpecsTextbox.CustomButton.Size = new System.Drawing.Size(179, 194);
            this.SpecsTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SpecsTextbox.CustomButton.TabIndex = 1;
            this.SpecsTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SpecsTextbox.CustomButton.UseSelectable = true;
            this.SpecsTextbox.CustomButton.Visible = false;
            this.SpecsTextbox.Lines = new string[0];
            this.SpecsTextbox.Location = new System.Drawing.Point(17, 218);
            this.SpecsTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SpecsTextbox.MaxLength = 32767;
            this.SpecsTextbox.Name = "SpecsTextbox";
            this.SpecsTextbox.PasswordChar = '\0';
            this.SpecsTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SpecsTextbox.SelectedText = "";
            this.SpecsTextbox.SelectionLength = 0;
            this.SpecsTextbox.SelectionStart = 0;
            this.SpecsTextbox.ShortcutsEnabled = true;
            this.SpecsTextbox.Size = new System.Drawing.Size(213, 244);
            this.SpecsTextbox.Style = MetroFramework.MetroColorStyle.Red;
            this.SpecsTextbox.TabIndex = 8;
            this.SpecsTextbox.UseSelectable = true;
            this.SpecsTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SpecsTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 190);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(87, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Specifications";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(17, 129);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(47, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Model";
            // 
            // ModelTextbox
            // 
            // 
            // 
            // 
            this.ModelTextbox.CustomButton.Image = null;
            this.ModelTextbox.CustomButton.Location = new System.Drawing.Point(95, 2);
            this.ModelTextbox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModelTextbox.CustomButton.Name = "";
            this.ModelTextbox.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.ModelTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ModelTextbox.CustomButton.TabIndex = 1;
            this.ModelTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ModelTextbox.CustomButton.UseSelectable = true;
            this.ModelTextbox.CustomButton.Visible = false;
            this.ModelTextbox.Lines = new string[0];
            this.ModelTextbox.Location = new System.Drawing.Point(17, 153);
            this.ModelTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModelTextbox.MaxLength = 32767;
            this.ModelTextbox.Name = "ModelTextbox";
            this.ModelTextbox.PasswordChar = '\0';
            this.ModelTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ModelTextbox.SelectedText = "";
            this.ModelTextbox.SelectionLength = 0;
            this.ModelTextbox.SelectionStart = 0;
            this.ModelTextbox.ShortcutsEnabled = true;
            this.ModelTextbox.Size = new System.Drawing.Size(149, 24);
            this.ModelTextbox.Style = MetroFramework.MetroColorStyle.Red;
            this.ModelTextbox.TabIndex = 11;
            this.ModelTextbox.UseSelectable = true;
            this.ModelTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ModelTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(228, 129);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(121, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Primary Cash Price";
            // 
            // PriceTextbox
            // 
            // 
            // 
            // 
            this.PriceTextbox.CustomButton.Image = null;
            this.PriceTextbox.CustomButton.Location = new System.Drawing.Point(95, 2);
            this.PriceTextbox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PriceTextbox.CustomButton.Name = "";
            this.PriceTextbox.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.PriceTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PriceTextbox.CustomButton.TabIndex = 1;
            this.PriceTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PriceTextbox.CustomButton.UseSelectable = true;
            this.PriceTextbox.CustomButton.Visible = false;
            this.PriceTextbox.Lines = new string[0];
            this.PriceTextbox.Location = new System.Drawing.Point(228, 155);
            this.PriceTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PriceTextbox.MaxLength = 32767;
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.PasswordChar = '\0';
            this.PriceTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PriceTextbox.SelectedText = "";
            this.PriceTextbox.SelectionLength = 0;
            this.PriceTextbox.SelectionStart = 0;
            this.PriceTextbox.ShortcutsEnabled = true;
            this.PriceTextbox.Size = new System.Drawing.Size(149, 24);
            this.PriceTextbox.Style = MetroFramework.MetroColorStyle.Red;
            this.PriceTextbox.TabIndex = 13;
            this.PriceTextbox.UseSelectable = true;
            this.PriceTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PriceTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Currencylabel
            // 
            this.Currencylabel.AutoSize = true;
            this.Currencylabel.Location = new System.Drawing.Point(400, 155);
            this.Currencylabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Currencylabel.Name = "Currencylabel";
            this.Currencylabel.Size = new System.Drawing.Size(61, 19);
            this.Currencylabel.Style = MetroFramework.MetroColorStyle.Red;
            this.Currencylabel.TabIndex = 14;
            this.Currencylabel.Text = "Currency";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(262, 218);
            this.metroGrid1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(321, 244);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroGrid1.TabIndex = 15;
            // 
            // AvailableCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 534);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.Currencylabel);
            this.Controls.Add(this.PriceTextbox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.ModelTextbox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.SpecsTextbox);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CatCombobox);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.TypeCombobox);
            this.Controls.Add(this.brandCombobox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AvailableCars";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Available Cars";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AvailableCars_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox brandCombobox;
        private MetroFramework.Controls.MetroComboBox TypeCombobox;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox CatCombobox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel Category;
        private MetroFramework.Controls.MetroTextBox SpecsTextbox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox ModelTextbox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox PriceTextbox;
        private MetroFramework.Controls.MetroLabel Currencylabel;
        private MetroFramework.Controls.MetroGrid metroGrid1;
    }
}