using FuelStation.Web.Blazor.Shared.Customer;
using FuelStation.Web.Blazor.Shared.Item;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Headers;

namespace FuelStation.DevEx
{
    public partial class Items : Form
    {
        private readonly HttpClient client;
        string uri = "https://localhost:7199/item";
        public Items()
        {
            InitializeComponent();
            client = new HttpClient();
        }
        private async void Items_Load(object sender, EventArgs e)
        {
            await PopulateDataGridView();
        }
        private async Task<List<ItemListDto>> getItems()
        {
            var response = await client.GetAsync(uri);
            var data = await response.Content.ReadAsAsync<List<ItemListDto>>();
            return data;
        }
        private async Task PopulateDataGridView()
        {
            var data = await getItems();
            BindingList<ItemListDto> items = new BindingList<ItemListDto>(data);
            grdItems.DataSource = new BindingSource() { DataSource = data };
        }
        private async Task editItem(ItemListDto editedItem)
        {
            var response = await client.PutAsJsonAsync(uri, editedItem);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Item Editted!", "Success Message");
            }
            else
            {
                MessageBox.Show("Something went wrong.", "Alert Message");
                await PopulateDataGridView();
            }
        }
        private async Task createItem(ItemListDto itemToAdd)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync(uri, itemToAdd);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Item Added!", "Success Message");
                }
                else
                {
                    MessageBox.Show("Something went wrong.", "Alert Message");
                    await PopulateDataGridView();
                }
            }
        }
        private async void grvItems_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (grvItems.GetFocusedRow != null)
            {
                ItemListDto? editedItem = grvItems.GetFocusedRow() as ItemListDto;
                List<ItemListDto> items = await getItems();
                foreach (var item in items)
                {
                    if ((item.Code == editedItem.Code) && (editedItem.Id!=item.Id))
                    {
                        grvItems.ClearColumnErrors();
                        e.Valid = false;
                        grvItems.SetColumnError(colCode, "Code already exists");
                        return;
                    }
                }
                if (editedItem == null)
                {
                    grvItems.ClearColumnErrors();
                    e.Valid = false;
                    return;
                }
                else if (editedItem.Code == null)
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
                    grvItems.SetColumnError(colDescription, "Description cannot be empty");
                    return;
                }
                else if (editedItem.ItemType == 0)
                {
                    grvItems.ClearColumnErrors();
                    e.Valid = false;
                    grvItems.SetColumnError(colItemType, "Type cannot be empty");
                    return;
                }
                else if ((editedItem.Price <= 0) || (editedItem.Price > 99999))
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
                    await createItem(editedItem);
                }
                else
                {
                    await editItem(editedItem);
                }
            }
        }
        private async Task deleteItem(int id)
        {
                var response = await client.DeleteAsync(uri+"/"+id);
                if (response.IsSuccessStatusCode)
                {
                MessageBox.Show("Item Deleted!", "Success Message");
            }
            else
            {
                MessageBox.Show("Cannot delete this item.");
                await PopulateDataGridView();
            }
        }
        private async void grvItems_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            ItemListDto? deletedItem = grvItems.GetRow(e.RowHandle) as ItemListDto;
            await deleteItem(deletedItem.Id);
        }
        private void btnToIndex_Click(object sender, EventArgs e)
        {
            Index indexForm = new();
            this.Hide();
            indexForm.ShowDialog();
            this.Close();
        }

        private async void grvItems_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            ItemListDto? editedItem = grvItems.GetFocusedRow() as ItemListDto;
            if ((editedItem.Code=="") || (editedItem.Description == "")|| (editedItem.ItemType == 0) || (editedItem.Price == 0))
            {
                var result = MessageBox.Show("Some cells are missing values. Discard Changes?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    await PopulateDataGridView();
                }
                else if (result == DialogResult.No)
                {
                    e.Allow = false;
                }
            }
        }
    }
}
