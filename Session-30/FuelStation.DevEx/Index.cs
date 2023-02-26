﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.DevEx
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            btnToManagers.Left = (this.ClientSize.Width - btnToManagers.Width) / 3;
            btnToManagers.Top = (2 * this.ClientSize.Width) / 3;
            btnToStaff.Left = (this.ClientSize.Width - btnToStaff.Width) / 2;
            btnToStaff.Top = (2 * this.ClientSize.Width) / 3;
            btnToCashier.Left = ((this.ClientSize.Width - btnToCashier.Width) *2) / 3;
            btnToCashier.Top = (2 * this.ClientSize.Width) / 3;

            // Anchor the buttons to the form
            btnToManagers.Anchor = AnchorStyles.None;
            btnToStaff.Anchor = AnchorStyles.None;
            btnToCashier.Anchor = AnchorStyles.None;
        }

        private void btnToManagers_Click(object sender, EventArgs e)
        {
            Managers managerForm = new();
            this.Hide();
            managerForm.ShowDialog();
            this.Close();
        }

        private void btnToStaff_Click(object sender, EventArgs e)
        {
            Staff staffForm = new();
            this.Hide();
            staffForm.ShowDialog();
            this.Close();
        }

        private void btnToCashier_Click(object sender, EventArgs e)
        {
            Cashier cashierForm = new();
            this.Hide();
            cashierForm.ShowDialog();
            this.Close();
        }

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
