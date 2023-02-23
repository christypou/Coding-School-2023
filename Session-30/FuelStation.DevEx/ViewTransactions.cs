using FuelStation.Web.Blazor.Client.Shared.Customer;
using FuelStation.Web.Blazor.Shared.Employee;
using FuelStation.Web.Blazor.Shared.Transaction;
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
	public partial class ViewTransactions : Form
	{
		public ViewTransactions()
		{
			InitializeComponent();
		}

		private void ViewTransactions_Load(object sender, EventArgs e)
		{
			PopulateDataGridView();
		}
		private async Task PopulateDataGridView()
		{
			using (HttpClient client = new HttpClient())
			{
				var response = await client.GetAsync("https://localhost:7199/transaction");
				var dataTransaction = await response.Content.ReadAsAsync<List<TransactionListDto>>();
				response = await client.GetAsync("https://localhost:7199/customer");
				var dataCustomer = await response.Content.ReadAsAsync<List<CustomerListDto>>();
				response = await client.GetAsync("https://localhost:7199/employee");
				var dataEmployee = await response.Content.ReadAsAsync<List<EmployeeListDto>>();


				BindingList<TransactionListDto> transactions = new BindingList<TransactionListDto>(dataTransaction);
				grdTransactions.DataSource = new BindingSource() { DataSource = transactions };

				BindingList<EmployeeListDto> employees = new BindingList<EmployeeListDto>(dataEmployee);
				repEmployees.DataSource = new BindingSource() { DataSource = employees };
				repEmployees.DisplayMember = "Name";
				repEmployees.ValueMember = "Id";

				BindingList<CustomerListDto> customers = new BindingList<CustomerListDto>(dataCustomer);
				repCustomers.DataSource = new BindingSource() { DataSource = customers };
				repCustomers.DisplayMember = "Name";
				repCustomers.ValueMember = "Id";

			}
		}

		private async Task editTransaction(TransactionListDto editedTransaction)
		{
			using (HttpClient client = new HttpClient())
			{
				var myContent = JsonConvert.SerializeObject(editedTransaction);
				var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
				var byteContent = new ByteArrayContent(buffer);
				byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

				var response = await client.PutAsync("https://localhost:7199/transaction", byteContent);
				if (response.IsSuccessStatusCode)
				{
					PopulateDataGridView();
				}
			}

		}

		private void grvTransactions_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
		{
			TransactionListDto editedTransaction = grvTransactions.GetFocusedRow() as TransactionListDto;
			if (editedTransaction == null)
			{
				e.Valid = false;
				return;
			}
			editTransaction(editedTransaction);
		}

		private void btnDeleteTransaction_Click(object sender, EventArgs e)
		{
			TransactionListDto transactiontoDelete = (TransactionListDto)grvTransactions.GetFocusedRow();
			deleteTransaction(transactiontoDelete.Id);

			updateTransactions();
		}
		private async Task deleteTransaction(int id)
		{
			using (HttpClient client = new HttpClient())
			{
				var uri = "https://localhost:7199/transaction/" + id;
				var response = await client.DeleteAsync(uri);
				if (response.IsSuccessStatusCode)
				{
					// add something
				}
				
			}
		}

		private async Task updateTransactions()
		{
			using (HttpClient client = new HttpClient())
			{
				var response = await client.GetAsync("https://localhost:7199/transaction");
				var dataTransaction = await response.Content.ReadAsAsync<List<TransactionListDto>>();
				BindingList<TransactionListDto> transactions = new BindingList<TransactionListDto>(dataTransaction);
				grdTransactions.DataSource = new BindingSource() { DataSource = transactions };
				grdTransactions.RefreshDataSource();
			}
		}
	}
}		
