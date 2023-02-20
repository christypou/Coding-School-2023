using FuelStation.Model;
using FuelStation.Web.Blazor.Client.Pages;
using FuelStation.Web.Blazor.Client.Shared.Customer;
using FuelStation.Web.Blazor.Server.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net;
using System.Text;
using System.Net.Http;
using Nancy.Json;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FuelStation.WinForms
{
	public partial class CustomersForm : Form
	{
		public CustomersForm()
		{
			InitializeComponent();
			
		}

		private async Task PopulateDataGridView()
		{
			using (HttpClient client = new HttpClient())				
			{
				var response = await client.GetAsync("https://localhost:7199/customer");
				var data = await response.Content.ReadAsAsync<IEnumerable<CustomerListDto>>();
			
				grvCustomers.DataSource = data;

				CustomerBs.DataSource = data;
				//customerBindingSource1.DataSource = petShop.Customers;
				


			}
	



		}

		private void CustomersForm_Load(object sender, EventArgs e)
		{
			this.PopulateDataGridView();
		}

		private void btnSaveCustomer_Click(object sender, EventArgs e)
		{
			CustomerEditDto newcustomer = new CustomerEditDto();
			CustomerBs.Add(newcustomer);
			addCustomer(CustomerBs);


		}

		private async Task addCustomer(BindingSource CustomerBs)
		{
			string json = JsonConvert.SerializeObject(CustomerBs.DataSource);
			HttpClient httpClient = new HttpClient();
			httpClient.BaseAddress = new Uri("https://localhost:7199");
			HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/customer");
			request.Content = new StringContent(json, Encoding.UTF8, "application/json");
			HttpResponseMessage response = await httpClient.SendAsync(request);
		}
	}
}

	


