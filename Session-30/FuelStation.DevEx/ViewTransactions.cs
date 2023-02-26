using FuelStation.Model;
using FuelStation.Web.Blazor.Shared.Customer;
using FuelStation.Web.Blazor.Shared.Employee;
using FuelStation.Web.Blazor.Shared.Item;
using FuelStation.Web.Blazor.Shared.Transaction;
using FuelStation.Web.Blazor.Shared.TransactionLine;
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
        public int createLineTransaction;
        public ViewTransactions()
		{
			InitializeComponent();
			grdTransactions.EmbeddedNavigator.Buttons.Append.Visible = false;
			grdTransactionLines.EmbeddedNavigator.Buttons.Append.Visible = false;
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
					updateTransactions();
				}
			}

		}

		private void grvTransactions_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
		{
			TransactionListDto editedTransaction = grvTransactions.GetFocusedRow() as TransactionListDto;

			editTransaction(editedTransaction);
			
		}

	
		private async Task deleteTransaction(int id)
		{
			using (HttpClient client = new HttpClient())
			{
				var uri = "https://localhost:7199/transaction/" + id;
				var response = await client.DeleteAsync(uri);
				if (response.IsSuccessStatusCode)
				{
					updateTransactions();
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
			}
		}

		private void grvTransactions_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
		{
			TransactionListDto deletedTransaction = grvTransactions.GetRow(e.RowHandle) as TransactionListDto;
			deleteTransaction(deletedTransaction.Id);
		}

		private void grvTransactions_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			TransactionListDto chosenTransaction = grvTransactions.GetRow(e.RowHandle) as TransactionListDto;
            createLineTransaction = chosenTransaction.Id;
            PopulateTransactionLines(chosenTransaction);
		}

		private async Task PopulateTransactionLines(TransactionListDto chosenTransaction)
		{
			using (HttpClient client = new HttpClient())
			{
				var response = await client.GetAsync("https://localhost:7199/transactionLine");
				var dataTransactionLine = await response.Content.ReadAsAsync<List<TransactionLineListDto>>();
				response = await client.GetAsync("https://localhost:7199/item");
				var dataItem = await response.Content.ReadAsAsync<List<ItemListDto>>();
				List<TransactionLineListDto> linesForTransactions = new List<TransactionLineListDto>();
				foreach(var item in dataTransactionLine) {
					if (item.TransactionId == chosenTransaction.Id)
					{
						linesForTransactions.Add(item);
					}
				}
				
				BindingList<TransactionLineListDto> transactionLines = new BindingList<TransactionLineListDto>(linesForTransactions);
				grdTransactionLines.DataSource = new BindingSource() { DataSource = transactionLines };


				BindingList<ItemListDto> items = new BindingList<ItemListDto>(dataItem);
				repItems.DataSource = new BindingSource() { DataSource = items };
				repItems.DisplayMember = "Code";
				repItems.ValueMember = "Id";

				

			}
		}

		private void grvTransactionLines_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
		{
			TransactionLineListDto editedTransactionLine = grvTransactionLines.GetFocusedRow() as TransactionLineListDto;

			editTransactionLine(editedTransactionLine);
		}

		private void grvTransactionLines_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
		{
			TransactionLineListDto deletedTransactionLine = grvTransactionLines.GetRow(e.RowHandle) as TransactionLineListDto;
			deleteTransactionLine(deletedTransactionLine.Id);
		}
		private async Task deleteTransactionLine(int id)
		{
			using (HttpClient client = new HttpClient())
			{
				var uri = "https://localhost:7199/transactionLine/" + id;
				var response = await client.DeleteAsync(uri);
				if (response.IsSuccessStatusCode)
				{
					updateTransactionLines();
				}

			}
		}
		private async Task updateTransactionLines()
		{
			using (HttpClient client = new HttpClient())
			{
				var response = await client.GetAsync("https://localhost:7199/transactionLines");
				var dataTransactionLine = await response.Content.ReadAsAsync<List<TransactionLineListDto>>();
				BindingList<TransactionLineListDto> transactionLines = new BindingList<TransactionLineListDto>(dataTransactionLine);
				grdTransactionLines.DataSource = new BindingSource() { DataSource = transactionLines };
			}
		}

		private async Task editTransactionLine(TransactionLineListDto editedTransactionLine)
		{
			using (HttpClient client = new HttpClient())
			{
				var myContent = JsonConvert.SerializeObject(editedTransactionLine);
				var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
				var byteContent = new ByteArrayContent(buffer);
				byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

				var response = await client.PutAsync("https://localhost:7199/transactionLine", byteContent);
				if (response.IsSuccessStatusCode)
				{
					updateTransactionLines();
				}
			}

		}
	}
}		
