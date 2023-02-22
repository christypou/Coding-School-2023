using FuelStation.Web.Blazor.Shared.Item;
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
	public partial class Items : Form
	{
		public Items()
		{
			InitializeComponent();
		}

		private void Items_Load(object sender, EventArgs e)
		{
			PopulateDataGridView();
		}
		private async Task PopulateDataGridView()
		{
			using (HttpClient client = new HttpClient())
			{
				var response = await client.GetAsync("https://localhost:7199/item");
				var data = await response.Content.ReadAsAsync<List<ItemListDto>>();

				BindingList<ItemListDto> items = new BindingList<ItemListDto>(data);
				grdItems.DataSource = new BindingSource() { DataSource = data };

			}
		}
		private async Task editItem(ItemListDto editedItem)
		{
			using (HttpClient client = new HttpClient())
			{
				var myContent = JsonConvert.SerializeObject(editedItem);
				var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
				var byteContent = new ByteArrayContent(buffer);
				byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

				var response = await client.PutAsync("https://localhost:7199/item", byteContent);
				if (response.IsSuccessStatusCode)
				{
					PopulateDataGridView();
				}
			}

		}
		private async Task createItem(ItemListDto itemToAdd)
		{
			using (HttpClient client = new HttpClient())
			{
				var myContent = JsonConvert.SerializeObject(itemToAdd);
				var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
				var byteContent = new ByteArrayContent(buffer);
				byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

				var response = await client.PostAsync("https://localhost:7199/item", byteContent);
				if (response.IsSuccessStatusCode)
				{
					PopulateDataGridView();
				}
			}
		}

		private void grvItems_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
		{
			ItemListDto editedItem = grvItems.GetFocusedRow() as ItemListDto;
			if (editedItem == null)
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


			if (editedItem.Id == 0)
			{
				createItem(editedItem);
			}
			else
			{
				editItem(editedItem);

			}
		}
		private async Task deleteItem(int id)
		{
			using (HttpClient client = new HttpClient())
			{
				var uri = "https://localhost:7199/item/" + id;
				var response = await client.DeleteAsync(uri);
				if (response.IsSuccessStatusCode)
				{
					// add something
				}
			}
		}

		private void grvItems_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
		{
			ItemListDto deletedItem = grvItems.GetRow(e.RowHandle) as ItemListDto;
			deleteItem(deletedItem.Id);
		}
	}
}
