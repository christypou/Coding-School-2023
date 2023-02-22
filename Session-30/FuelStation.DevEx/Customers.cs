using DevExpress.Emf;
using DevExpress.XtraGrid.Views.Grid;
using FuelStation.Web.Blazor.Shared.Customer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FuelStation.DevEx
{
	public partial class Customers : Form
	{
		public Customers()
		{
			InitializeComponent();
			
		}

		private void Customers_Load(object sender, EventArgs e)
		{
			PopulateDataGridView();
		}

		private async Task PopulateDataGridView()
		{
			using (HttpClient client = new HttpClient())
			{
				var response = await client.GetAsync("https://localhost:7199/customer");
				var data = await response.Content.ReadAsAsync<List<CustomerListDto>>();

				BindingList<CustomerListDto> customers = new BindingList<CustomerListDto>(data);
				grdCustomers.DataSource = new BindingSource() { DataSource = data };
				
			}
		}

	

		private void grvCustomers_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			
		}

		private async Task editCustomer(CustomerListDto editedCustomer)
		{
			using (HttpClient client = new HttpClient())
			{
				var myContent = JsonConvert.SerializeObject(editedCustomer);
				var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
				var byteContent = new ByteArrayContent(buffer);
				byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

				var response = await client.PutAsync("https://localhost:7199/customer", byteContent);
				if(response.IsSuccessStatusCode)
				{
					PopulateDataGridView();
				}
			}

		}



		private async Task createCustomer(CustomerListDto customerToAdd)
		{
			using (HttpClient client = new HttpClient())
			{
				var myContent = JsonConvert.SerializeObject(customerToAdd);
				var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
				var byteContent = new ByteArrayContent(buffer);
				byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

				var response = await client.PostAsync("https://localhost:7199/customer", byteContent);
				if (response.IsSuccessStatusCode)
				{
					PopulateDataGridView();
				}
			}
		}

		private void grvCustomers_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
		{
			CustomerListDto editedCustomer = grvCustomers.GetFocusedRow() as CustomerListDto;
			if (editedCustomer == null)
			{
				e.Valid = false;
				return;
			}else if (!editedCustomer.CardNumber.StartsWith("A"))
			{
				e.Valid = false;
				grvCustomers.SetColumnError(colCardNumber, "Card Number must start with A");
				return;
			}
		

			if (editedCustomer.Id == 0)
			{
				createCustomer(editedCustomer);
			}
			else
			{
				editCustomer(editedCustomer);
				
			}
		}

		private void grvCustomers_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
		{
			CustomerListDto deletedCustomer = grvCustomers.GetRow(e.RowHandle) as CustomerListDto;
			deleteCustomer(deletedCustomer.Id);

		}
		private async Task deleteCustomer(int id)
		{
			using (HttpClient client = new HttpClient())
			{
				var uri = "https://localhost:7199/customer/" + id;
				var response = await client.DeleteAsync(uri);
				if (response.IsSuccessStatusCode)
				{
					// add something
				}
			}
		}
	}
}
