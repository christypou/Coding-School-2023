using FuelStation.Model;
using FuelStation.Web.Blazor.Server.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FuelStation.WinForms
{
	public partial class CustomersForm : Form
	{
		public CustomersForm()
		{
			InitializeComponent();
		}

		private void CustomersForm_Load(object sender, EventArgs e)
		{
			SetControllers();
			
		}
	

		void SetControllers()
		{
			customerbs.DataSource = GetCust();
			grvCustomers.DataSource = customerbs;
			//bsCustomers.DataSource =
			//grvCustomers.DataSource = bsCustomers;

		}
	}
}
