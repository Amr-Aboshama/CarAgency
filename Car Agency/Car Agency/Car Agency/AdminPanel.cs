using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Car_Agency
{
	public partial class AdminPanel : MetroForm
	{
		public AdminPanel()
		{
			InitializeComponent();
		}

		private void AdminPanel_Load(object sender, EventArgs e)
		{

		}

		private void metroTile1_Click(object sender, EventArgs e)
		{
            addUser form = new addUser();
			form.Show(this);
			this.Hide();
		}

		private void metroTile4_Click(object sender, EventArgs e)
		{
			viewUser form = new viewUser();
			form.Show(this);
			this.Hide();
		}

		private void metroTile2_Click(object sender, EventArgs e)
		{
			addEmployee form = new addEmployee();
			form.Show(this);
			this.Hide();
		}

		private void metroTile6_Click(object sender, EventArgs e)
		{
			viewEmployee form = new viewEmployee();
			form.Show(this);
			this.Hide();
		}

		private void metroTile3_Click(object sender, EventArgs e)
		{
			ViewCurrencies form = new ViewCurrencies();
			form.Show(this);
			this.Hide();
		}

		private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
		{
			Owner.Show();
		}
	}
}
