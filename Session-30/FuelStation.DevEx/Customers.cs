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
				//CustomerBs.DataSource = data;
				//grvCustomers.DataSource = CustomerBs;
				//grvCustomers.AutoGenerateColumns = false;
				//customerBindingSource1.DataSource = petShop.Customers;
			}
		}

		private void grvCustomers_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			//var x = sender;
		}

		private void grvCustomers_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{

			int rowHandle = e.RowHandle;
			CustomerListDto editedCustomer = (CustomerListDto) grvCustomers.GetRow(rowHandle);
			//GridView view = sender as GridView;
			//CustomerEditDto rec = view.GetRow(e.RowHandle) as CustomerEditDto;
			editCustomer(editedCustomer);

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
					var x = 4;
				}
			}

		}
	}
}
