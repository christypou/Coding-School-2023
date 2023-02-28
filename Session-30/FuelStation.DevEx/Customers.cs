using DevExpress.XtraSpreadsheet.TileLayout;
using FuelStation.Web.Blazor.Shared.Customer;
using FuelStation.Web.Blazor.Shared.Item;
using System.ComponentModel;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace FuelStation.DevEx
{
    public partial class Customers : Form
    {
        private readonly HttpClient client;
        string uri = "https://localhost:7199/customer";
        public Customers()
        {
            InitializeComponent();
            client = new HttpClient();
        }
        private async void Customers_Load(object sender, EventArgs e)
        {
            await PopulateDataGridView();
        }

        private async Task PopulateDataGridView()
        {
            var data = await getCustomers();
            BindingList<CustomerListDto> customers = new BindingList<CustomerListDto>(data);
            grdCustomers.DataSource = new BindingSource() { DataSource = data };
        }

        private async Task editCustomer(CustomerListDto editedCustomer)
        {
            var response = await client.PutAsJsonAsync(uri, editedCustomer);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Customer Editted!", "Success Message");
            }
            else
            {
                MessageBox.Show("Something went wrong.", "Alert Message");
                await PopulateDataGridView();
            }
        }
        private async Task createCustomer(CustomerListDto customerToAdd)
        {
            var response = await client.PostAsJsonAsync(uri, customerToAdd);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Customer Added!", "Success Message");
            }
            else
            {
                MessageBox.Show("Something went wrong.", "Alert Message");
                await PopulateDataGridView();
            }
        }
        private async Task<List<CustomerListDto>> getCustomers()
        {
            var response = await client.GetAsync(uri);
            var data = await response.Content.ReadAsAsync<List<CustomerListDto>>();
            return data;
        }
        private async void grvCustomers_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {

            if (grvCustomers.GetFocusedRow != null)
            {
                CustomerListDto? editedCustomer = grvCustomers.GetFocusedRow() as CustomerListDto;
                List<CustomerListDto> customers = await getCustomers();
                foreach (var customer in customers)
                {
                    if ((customer.CardNumber == editedCustomer.CardNumber) && (customer.Id != editedCustomer.Id))
                    {
                        grvCustomers.ClearColumnErrors();
                        e.Valid = false;
                        grvCustomers.SetColumnError(colCardNumber, "Card Number already exists");
                        return;
                    }
                }
                if (editedCustomer == null)
                {
                    grvCustomers.ClearColumnErrors();
                    e.Valid = false;
                    return;
                }
                else if (editedCustomer.CardNumber==null)
                {
                    grvCustomers.ClearColumnErrors();
                    e.Valid = false;
                    grvCustomers.SetColumnError(colCardNumber, "Card Number cannot be empty");
                    return;
                }
                else if (!editedCustomer.CardNumber.StartsWith("A"))
                {
                    grvCustomers.ClearColumnErrors();
                    e.Valid = false;
                    grvCustomers.SetColumnError(colCardNumber, "Card Number must start with A");
                    return;
                }
                else if (editedCustomer.Name == null)
                {
                    grvCustomers.ClearColumnErrors();
                    e.Valid = false;
                    grvCustomers.SetColumnError(colName, "Name can not be empty");
                    return;
                }
                else if (editedCustomer.Surname == null)
                {
                    grvCustomers.ClearColumnErrors();
                    e.Valid = false;
                    grvCustomers.SetColumnError(colSurname, "Surname can not be empty");
                    return;
                }
                else if (Regex.IsMatch(editedCustomer.Surname, @"\d"))
                {
                    grvCustomers.ClearColumnErrors();
                    e.Valid = false;
                    grvCustomers.SetColumnError(colSurname, "Surname can not contain numbers");
                    return;
                }
                else if (Regex.IsMatch(editedCustomer.Name, @"\d"))
                {
                    grvCustomers.ClearColumnErrors();
                    e.Valid = false;
                    grvCustomers.SetColumnError(colName, "Name can not contain numbers");
                    return;
                }
                else
                {
                    grvCustomers.ClearColumnErrors();
                }

                if (editedCustomer.Id == 0)
                {
                    await createCustomer(editedCustomer);
                }
                else
                {
                    await editCustomer(editedCustomer);
                }
            }
        }
        private async void grvCustomers_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            CustomerListDto? deletedCustomer = grvCustomers.GetRow(e.RowHandle) as CustomerListDto;
            await deleteCustomer(deletedCustomer.Id);
        }
        private async Task deleteCustomer(int id)
        {
            var response = await client.DeleteAsync(uri + "/" + id);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Customer Deleted!", "Success Message");
            }
            else
            {
                MessageBox.Show("Cannot delete this customer.");
                await PopulateDataGridView();
            }
        }

        private void btnToIndex_Click(object sender, EventArgs e)
        {
            Index indexForm = new();
            this.Hide();
            indexForm.ShowDialog();
            this.Close();
        }

        private async void grvCustomers_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            CustomerListDto? editedCustomer = grvCustomers.GetFocusedRow() as CustomerListDto;
            if ((editedCustomer.Name == null) || (editedCustomer.Surname == null) || (editedCustomer.CardNumber == null))
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
