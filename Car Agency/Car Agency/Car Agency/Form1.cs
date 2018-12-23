﻿using System;
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
    public partial class Form1 : MetroForm
    {
        Controller controllerObj;
        public Form1()
        {
            InitializeComponent();
            controllerObj = new Controller();

            MaxSalaryLabel.Text = controllerObj.MaxSalary().ToString();
            EmpNumLabel.Text = controllerObj.NumOfEmp().ToString();
            salaryLabel.Text = controllerObj.SumSalary().ToString();
            carLabel.Text = controllerObj.NumOfAvailableCars().ToString();
        }

       
    }
}
