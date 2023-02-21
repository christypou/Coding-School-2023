using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.WinForms
{
	public partial class ManagerForm : Form
	{
		public ManagerForm()
		{
			InitializeComponent();
		}

		private void btnToCustomers_Click(object sender, EventArgs e)
		{
			CustomersForm customersForm = new();
			customersForm.ShowDialog();
		}

		private void btnToItems_Click(object sender, EventArgs e)
		{
			ItemsForm itemsForm = new();
			itemsForm.ShowDialog();
		}
	}
}
