﻿using DevExpress.XtraGrid.Columns;
using FuelStation.Model;
using FuelStation.Model.Enums;
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
        decimal quantity = 0;
        bool itemFuel = false;
        List<EmployeeListDto> dataEmployee = new();
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
        private void grvTransactions_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            TransactionListDto editedTransaction = grvTransactions.GetFocusedRow() as TransactionListDto;
            if (editedTransaction == null)
            {
                e.Valid = false;
                return;
            }
            else if ((int)editedTransaction.PaymentMethod == 0)
            {
                e.Valid = false;
                grvTransactions.SetColumnError(colPaymentMethod, "Add Payment Method");
                return;
            }
            else if (editedTransaction.EmployeeId == 0)
            {
                e.Valid = false;
                grvTransactions.SetColumnError(colEmployee, "Add Employee");
                return;
            }else
            {
                grvTransactionLines.ClearColumnErrors();
            }
            editTransaction(editedTransaction);

        }
        private void grvTransactions_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            TransactionListDto deletedTransaction = grvTransactions.GetRow(e.RowHandle) as TransactionListDto;
            deleteTransaction(deletedTransaction.Id);
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
				var allEmployees = await response.Content.ReadAsAsync<List<EmployeeListDto>>();
                foreach (var employee in allEmployees)
                {
                    if ((employee.HireDateEnd > DateTime.Now) && (employee.HireDateStart < DateTime.Now))
                    {
                        dataEmployee.Add(employee);
                    }
                }
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

        private void grvTransactionLines_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
		{
			TransactionLineListDto editedTransactionLine = grvTransactionLines.GetFocusedRow() as TransactionLineListDto;
            if (editedTransactionLine == null)
            {
                e.Valid = false;
                return;
            }
            else if (editedTransactionLine.ItemId == 0)
            {
                e.Valid = false;
                grvTransactionLines.SetColumnError(colItems, "Choose an Item");
                return;
            }
            else if ((editedTransactionLine.Quantity <= 0) || (editedTransactionLine.Quantity > 99999))
            {
                e.Valid = false;
                grvTransactionLines.SetColumnError(colQuantity, "Quantity must be between 0.1 & 99.999");
                grvTransactionLines.SetRowCellValue(e.RowHandle, "Quantity", 0);
                grvTransactionLines.SetRowCellValue(e.RowHandle, "NetValue", 0);
                grvTransactionLines.SetRowCellValue(e.RowHandle, "TotalValue", 0);
                grvTransactionLines.SetRowCellValue(e.RowHandle, "DiscountPercent", 0);
                grvTransactionLines.SetRowCellValue(e.RowHandle, "DiscountValue", 0);
                grvTransactionLines.SetRowCellValue(e.RowHandle, "ItemPrice", 0);
                return;
            }
            else
            {
                grvTransactionLines.ClearColumnErrors();
            }
            editTransactionLine(editedTransactionLine);
		}

		private void grvTransactionLines_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
		{
			TransactionLineListDto deletedTransactionLine = grvTransactionLines.GetRow(e.RowHandle) as TransactionLineListDto;
			deleteTransactionLine(deletedTransactionLine.Id);
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

        private async void grvTransactionLines_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            decimal netValue = 0;
            decimal discountValue = 0;
            decimal totalValue = 0;
            //decimal transactionTotal = 0;
            quantity = 0;
            if (e.Column.Caption == "Item")
            {
                ItemListDto chosenItem = await getItemAsync((int)e.Value);
                grvTransactionLines.SetRowCellValue(e.RowHandle, "ItemPrice", chosenItem.Price);
                if ((int)chosenItem.ItemType == 1)
                {
                    itemFuel = true;
                }
                else { itemFuel = false; }
            }
            if (e.Column.Caption == "Quantity")
            {
                if (e.Value.ToString() == "")
                {
                    quantity = 0;
                }
                else
                {
                    quantity = decimal.Parse(e.Value.ToString());
                }
            }
            decimal itemPrice = (decimal)grvTransactionLines.GetRowCellValue(e.RowHandle, "ItemPrice");
            netValue = itemPrice * quantity;
            grvTransactionLines.SetRowCellValue(e.RowHandle, "NetValue", netValue);
            if (itemFuel && netValue >= 20)
            {
                grvTransactionLines.SetRowCellValue(e.RowHandle, "DiscountPercent", 10);
                discountValue = (decimal)0.1 * netValue;
                grvTransactionLines.SetRowCellValue(e.RowHandle, "DiscountValue", discountValue);
                totalValue = (decimal)0.9 * netValue;
                grvTransactionLines.SetRowCellValue(e.RowHandle, "TotalValue", totalValue);
            }
            else
            {
                grvTransactionLines.SetRowCellValue(e.RowHandle, "DiscountPercent", 0);
                grvTransactionLines.SetRowCellValue(e.RowHandle, "DiscountValue", 0);
                totalValue = netValue;
                grvTransactionLines.SetRowCellValue(e.RowHandle, "TotalValue", totalValue);
            }
        }
        private async Task<ItemListDto> getItemAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7199/item/" + id);
                string responseContent = await response.Content.ReadAsStringAsync();
                ItemListDto dataItem = JsonConvert.DeserializeObject<ItemListDto>(responseContent);
                return dataItem;
            }
        }

        private void btnUpdateTotal_Click(object sender, EventArgs e)
        {
            decimal transactionTotal = 0;
            GridColumn columnTotal = grvTransactionLines.Columns["TotalValue"];
            for (int i = 0; i < grvTransactionLines.RowCount; i++)
            {
                object value = grvTransactionLines.GetRowCellValue(i, columnTotal);
                if (value != null)
                {
                    transactionTotal += (decimal)value;
                }
            }
            //int transactionId = (int)grvTransactionLines.GetRowCellValue(e.RowHandle, "TransactionId");
            int rowHandle = grvTransactions.LocateByValue("Id", createLineTransaction);
            grvTransactions.SetRowCellValue(rowHandle, "TotalValue", transactionTotal);
            if (transactionTotal > 50)
            {
                grvTransactions.SetRowCellValue(rowHandle, "PaymentMethod", PaymentMethod.Cash);
                grvTransactions.Columns["PaymentMethod"].OptionsColumn.ReadOnly = true;
                grvTransactions.SetRowCellValue(rowHandle, "PaymentMethod", "Read-only Value");
            }
            else
            {
                grvTransactions.Columns["PaymentMethod"].OptionsColumn.ReadOnly = false;
                grvTransactions.SetRowCellValue(rowHandle, "PaymentMethod", "New Value");
            }
            int rowHandleTransaction = grvTransactions.LocateByValue("Id", createLineTransaction);
            TransactionListDto transactionToSave = grvTransactions.GetRow(rowHandleTransaction) as TransactionListDto;
            editTransaction(transactionToSave);
        }

        private void btnToIndex_Click(object sender, EventArgs e)
        {
            Index indexForm = new();
            this.Hide();
            indexForm.ShowDialog();
            this.Close();
        }
    }
}		
