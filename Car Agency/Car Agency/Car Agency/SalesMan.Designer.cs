namespace Car_Agency
{
    partial class SalesMan
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
            this.CustTile = new MetroFramework.Controls.MetroTile();
            this.CarsTile = new MetroFramework.Controls.MetroTile();
            this.ReqTile = new MetroFramework.Controls.MetroTile();
            this.CatmetroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // CustTile
            // 
            this.CustTile.ActiveControl = null;
            this.CustTile.BackColor = System.Drawing.Color.White;
            this.CustTile.ForeColor = System.Drawing.Color.White;
            this.CustTile.Location = new System.Drawing.Point(48, 114);
            this.CustTile.Name = "CustTile";
            this.CustTile.Size = new System.Drawing.Size(202, 100);
            this.CustTile.TabIndex = 0;
            this.CustTile.Text = "Customers";
            this.CustTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CustTile.UseSelectable = true;
            this.CustTile.Click += new System.EventHandler(this.CustTile_Click);
            // 
            // CarsTile
            // 
            this.CarsTile.ActiveControl = null;
            this.CarsTile.BackColor = System.Drawing.Color.White;
            this.CarsTile.ForeColor = System.Drawing.Color.White;
            this.CarsTile.Location = new System.Drawing.Point(296, 114);
            this.CarsTile.Name = "CarsTile";
            this.CarsTile.Size = new System.Drawing.Size(202, 100);
            this.CarsTile.TabIndex = 1;
            this.CarsTile.Text = "Available Cars";
            this.CarsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CarsTile.UseSelectable = true;
            this.CarsTile.Click += new System.EventHandler(this.CarsTile_Click);
            // 
            // ReqTile
            // 
            this.ReqTile.ActiveControl = null;
            this.ReqTile.BackColor = System.Drawing.Color.White;
            this.ReqTile.ForeColor = System.Drawing.Color.White;
            this.ReqTile.Location = new System.Drawing.Point(48, 254);
            this.ReqTile.Name = "ReqTile";
            this.ReqTile.Size = new System.Drawing.Size(202, 100);
            this.ReqTile.TabIndex = 2;
            this.ReqTile.Text = "Request Car";
            this.ReqTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReqTile.UseSelectable = true;
            this.ReqTile.Click += new System.EventHandler(this.ReqTile_Click);
            // 
            // CatmetroTile1
            // 
            this.CatmetroTile1.ActiveControl = null;
            this.CatmetroTile1.BackColor = System.Drawing.Color.White;
            this.CatmetroTile1.ForeColor = System.Drawing.Color.White;
            this.CatmetroTile1.Location = new System.Drawing.Point(296, 254);
            this.CatmetroTile1.Name = "CatmetroTile1";
            this.CatmetroTile1.Size = new System.Drawing.Size(202, 100);
            this.CatmetroTile1.TabIndex = 3;
            this.CatmetroTile1.Text = "View Categories";
            this.CatmetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CatmetroTile1.UseSelectable = true;
            this.CatmetroTile1.Click += new System.EventHandler(this.CatmetroTile1_Click);
            // 
            // SalesMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 427);
            this.Controls.Add(this.CatmetroTile1);
            this.Controls.Add(this.ReqTile);
            this.Controls.Add(this.CarsTile);
            this.Controls.Add(this.CustTile);
            this.Name = "SalesMan";
            this.Text = "Salesman";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile CustTile;
        private MetroFramework.Controls.MetroTile CarsTile;
        private MetroFramework.Controls.MetroTile ReqTile;
        private MetroFramework.Controls.MetroTile CatmetroTile1;
    }
}