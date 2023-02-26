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
		private async Task<List<ItemListDto>> getItems()
		{
			using (HttpClient client = new HttpClient())
			{
				var response = await client.GetAsync("https://localhost:7199/item");
				var data = await response.Content.ReadAsAsync<List<ItemListDto>>();
				return data;
			}
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

		private async void grvItems_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
		{
			ItemListDto editedItem = grvItems.GetFocusedRow() as ItemListDto;
			List<ItemListDto> items = await getItems();
			foreach(var item in items)
			{
				if (item.Code == editedItem.Code)
				{
                    grvItems.ClearColumnErrors();
                    e.Valid = false;
                    grvItems.SetColumnError(colCode, "Code already exists");
                    return;
                }
			}
			if (editedItem == null)
			{
				e.Valid = false;
				return;
			}else if (editedItem.Code == null)
            {
                grvItems.ClearColumnErrors();
                e.Valid = false;
                grvItems.SetColumnError(colCode, "Code cannot be empty");
                return;
            }
            else if (editedItem.Description == null)
            {
                grvItems.ClearColumnErrors();
                e.Valid = false;
                grvItems.SetColumnError(colDescription, "Code cannot be empty");
                return;
            }
            else if (editedItem.ItemType == 0)
            {
                grvItems.ClearColumnErrors();
                e.Valid = false;
                grvItems.SetColumnError(colItemType, "Type cannot be empty");
                return;
            }
            else if ((editedItem.Price <= 0) || (editedItem.Price>99999))
            {
                grvItems.ClearColumnErrors();
                e.Valid = false;
                grvItems.SetColumnError(colPrice, "Price must be between 0.1 & 99.999");
                return;
            }
            else if ((editedItem.Cost <= 0) || (editedItem.Cost > 99999))
            {
                grvItems.ClearColumnErrors();
                e.Valid = false;
                grvItems.SetColumnError(colCost, "Cost must be between 0.1 & 99.999");
                return;
            }
            else
            {
                grvItems.ClearColumnErrors();
            }


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

        private void btnToIndex_Click(object sender, EventArgs e)
        {
            Index indexForm = new();
            this.Hide();
            indexForm.ShowDialog();
            this.Close();
        }
    }
}
