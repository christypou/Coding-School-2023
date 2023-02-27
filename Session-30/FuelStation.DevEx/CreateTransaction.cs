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

        private void btnToIndex_Click(object sender, EventArgs e)
        {
            Index indexForm = new();
            this.Hide();
            indexForm.ShowDialog();
            this.Close();
        }

        private void CreateTransaction_Load(object sender, EventArgs e)
        {
			label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = this.ClientSize.Height / 5;
            btnCreateTransaction.Left = (this.ClientSize.Width - btnCreateTransaction.Width) / 2;
			btnCreateTransaction.Top = 2 * this.ClientSize.Height / 4;
            txtCardNumber.Top =  this.ClientSize.Height/3;
            txtCardNumber.Left = (this.ClientSize.Width - txtCardNumber.Width) / 2;

			label1.Anchor = AnchorStyles.None;
            btnCreateTransaction.Anchor = AnchorStyles.None;
			txtCardNumber.Anchor = AnchorStyles.None;
        }
    }
}
