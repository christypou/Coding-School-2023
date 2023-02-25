using DevExpress.XtraEditors;
using FuelStation.Model;
using FuelStation.Web.Blazor.Shared.Customer;
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

namespace FuelStation.DevEx
{
	public partial class CreateTransaction : Form
	{
		public CreateTransaction()
		{
			InitializeComponent();
		}

		private void btnCreateTransaction_Click(object sender, EventArgs e)
		{
			string cardNumber = txtCardNumber.Text;
			checkCustomerCard(cardNumber);
		}

		private async Task checkCustomerCard(string card)
		{
			using (HttpClient client = new HttpClient())
			{
				var response = await client.GetAsync("https://localhost:7199/customer");
				var dataCustomer = await response.Content.ReadAsAsync<List<CustomerListDto>>();
				foreach (var cust in dataCustomer)
				{
					if (card == cust.CardNumber)
					{
						DialogResult result2 = XtraMessageBox.Show("Found");
						CreateTransactionForCustomer form = new CreateTransactionForCustomer(cust);
						form.ShowDialog();
						return;
					}
				}
				DialogResult result = XtraMessageBox.Show("Customer not found. Do you want to create a new customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					Customers customerForm = new Customers();
					customerForm.Show();
				}
			}

		}


	}
}
