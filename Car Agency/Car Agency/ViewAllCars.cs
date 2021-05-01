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
    public partial class ViewAllCars : MetroForm
    {
        Controller controllerObj = new Controller();
        public ViewAllCars()
        {
            InitializeComponent();
            CarsGrid.DataSource = controllerObj.SelectAllCars();
        }

        private void ViewAllCars_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
