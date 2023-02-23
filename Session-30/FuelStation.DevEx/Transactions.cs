﻿using DevExpress.Pdf.Native.BouncyCastle.Asn1.X509;
using DevExpress.XtraEditors;
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
	public partial class Transactions : Form
	{
		public Transactions()
		{
			InitializeComponent();
		}

		private void Transactions_Load(object sender, EventArgs e)
		{
			PopulateDataGridView();
			grdTransactions.Visible = false;
			
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
		private async Task createTransaction(TransactionListDto transactionToAdd)
		{
			using (HttpClient client = new HttpClient())
			{
				var myContent = JsonConvert.SerializeObject(transactionToAdd);
				var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
				var byteContent = new ByteArrayContent(buffer);
				byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

				var response = await client.PostAsync("https://localhost:7199/transaction", byteContent);
				if (response.IsSuccessStatusCode)
				{
					PopulateDataGridView();
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
					// add something
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
			//else if (!editedCustomer.CardNumber.StartsWith("A"))
			//{
			//	e.Valid = false;
			//	grvCustomers.SetColumnError(colCardNumber, "Card Number must start with A");
			//	return;
			//}


			if (editedTransaction.Id == 0)
			{
				createTransaction(editedTransaction);
			}
			else
			{
				editTransaction(editedTransaction);

			}
		}

		private void grvTransactions_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
		{
			TransactionListDto deletedTransaction = grvTransactions.GetRow(e.RowHandle) as TransactionListDto;
			deleteTransaction(deletedTransaction.Id);
		}

		private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			//buttonEdit1.Properties.NullText = "card";
			//string cardNumber = buttonEdit1.EditValue.ToString();


		}

		private async Task checkCustomerCard(string card)
		{

			using (HttpClient client = new HttpClient())
			{
				var response = await client.GetAsync("https://localhost:7199/customer");
				var dataCustomer = await response.Content.ReadAsAsync<List<CustomerListDto>>();
				foreach(var cust in dataCustomer)
				{
					if(card == cust.CardNumber)
					{
						XtraMessageBox.Show("Found"+cust.Name);
						grdTransactions.Visible= true;
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

		private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
		{

		}

		private void grdTransactions_Click(object sender, EventArgs e)
		{

		}

		private void grdTransactionLines_Click(object sender, EventArgs e)
		{

		}

		private void btnCardNumber_Click(object sender, EventArgs e)
		{
			string cardNumber = txtCardNumber.Text;
			checkCustomerCard(cardNumber);
		}
	}
}
