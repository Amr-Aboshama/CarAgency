namespace Car_Agency
{
    partial class userCreditManager
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
			this.metroTile2 = new MetroFramework.Controls.MetroTile();
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			this.SuspendLayout();
			// 
			// metroTile2
			// 
			this.metroTile2.ActiveControl = null;
			this.metroTile2.Location = new System.Drawing.Point(30, 139);
			this.metroTile2.Name = "metroTile2";
			this.metroTile2.Size = new System.Drawing.Size(568, 56);
			this.metroTile2.Style = MetroFramework.MetroColorStyle.Red;
			this.metroTile2.TabIndex = 3;
			this.metroTile2.Text = "Purchase Cheques";
			this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile2.UseSelectable = true;
			// 
			// metroTile1
			// 
			this.metroTile1.ActiveControl = null;
			this.metroTile1.Location = new System.Drawing.Point(30, 77);
			this.metroTile1.Name = "metroTile1";
			this.metroTile1.Size = new System.Drawing.Size(568, 56);
			this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
			this.metroTile1.TabIndex = 2;
			this.metroTile1.Text = "View Installments";
			this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile1.UseSelectable = true;
			// 
			// userCreditManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(628, 218);
			this.Controls.Add(this.metroTile2);
			this.Controls.Add(this.metroTile1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "userCreditManager";
			this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "Credit Manager";
			this.Load += new System.EventHandler(this.userCreditManager_Load);
			this.ResumeLayout(false);

        }

		#endregion

		private MetroFramework.Controls.MetroTile metroTile2;
		private MetroFramework.Controls.MetroTile metroTile1;
	}
}