using DevExpress.XtraGrid.Columns;
using DevExpress.XtraSpreadsheet.TileLayout;
using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Web.Blazor.Shared.Customer;
using FuelStation.Web.Blazor.Shared.Employee;
using FuelStation.Web.Blazor.Shared.Item;
using FuelStation.Web.Blazor.Shared.Transaction;
using FuelStation.Web.Blazor.Shared.TransactionLine;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Headers;

namespace FuelStation.DevEx
{
    public partial class History : Form
    {
        private readonly HttpClient client;
        string uriTransaction = "https://localhost:7199/transaction";
        string uriTransactionLine = "https://localhost:7199/transactionLine";
        string uriEmployee = "https://localhost:7199/employee";
        string uriItem = "https://localhost:7199/item";
        string uriCustomer = "https://localhost:7199/customer";
        public int createLineTransaction;
        decimal quantity = 0;
        bool itemFuel = false;
        bool flag=false;
        List<EmployeeListDto> dataEmployee = new();
        public History()
        {
            InitializeComponent();
            client = new HttpClient();
            grdTransactions.EmbeddedNavigator.Buttons.Append.Visible = false;
            grdTransactionLines.EmbeddedNavigator.Buttons.Append.Visible = false;
        }

        private async void ViewTransactions_Load(object sender, EventArgs e)
        {
            await PopulateDataGridView();
        }
        private async Task<List<EmployeeListDto>> getEmployees()
        {
            var response = await client.GetAsync(uriEmployee);
            var data = await response.Content.ReadAsAsync<List<EmployeeListDto>>();
            return data;
        }
        private async Task<List<TransactionListDto>> getTransactions()
        {
            var response = await client.GetAsync(uriTransaction);
            var data = await response.Content.ReadAsAsync<List<TransactionListDto>>();
            return data;
        }
        private async Task<List<ItemListDto>> getItems()
        {
            var response = await client.GetAsync(uriItem);
            var data = await response.Content.ReadAsAsync<List<ItemListDto>>();
            return data;
        }
        private async Task<List<TransactionLineListDto>> getTransactionLines()
        {
            var response = await client.GetAsync(uriTransactionLine);
            var data = await response.Content.ReadAsAsync<List<TransactionLineListDto>>();
            return data;
        }
        private async Task<List<CustomerListDto>> getCustomers()
        {
            var response = await client.GetAsync(uriCustomer);
            var data = await response.Content.ReadAsAsync<List<CustomerListDto>>();
            return data;
        }
		private async Task<TransactionListDto> getTransaction(int id)
		{
			var response = await client.GetAsync(uriTransaction + "/" + id);
			var data = await response.Content.ReadAsAsync<TransactionListDto>();
			return data;
		}

		private async void grvTransactions_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            TransactionListDto? editedTransaction = grvTransactions.GetFocusedRow() as TransactionListDto;
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
            }
            else if ((editedTransaction.TotalValue >= 50) && (editedTransaction.PaymentMethod == PaymentMethod.CreditCard))
            {
                grvTransactionLines.ClearColumnErrors();
                MessageBox.Show("Order over  50. Cannot pay with card!");
                grvTransactions.SetRowCellValue(e.RowHandle, colPaymentMethod, PaymentMethod.Cash);
                return;
            }
            else
            {
                grvTransactionLines.ClearColumnErrors();
            }
            await editTransaction(editedTransaction);

        }
        private async void grvTransactions_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            TransactionListDto? deletedTransaction = grvTransactions.GetRow(e.RowHandle) as TransactionListDto;
            await deleteTransaction(deletedTransaction.Id);
        }
        private async Task PopulateDataGridView()
        {
            dataEmployee = new();
            var dataTransaction = await getTransactions();
            var dataCustomer = await getCustomers();
            var allEmployees = await getEmployees();
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

        private async Task editTransaction(TransactionListDto editedTransaction)
        {
            var response = await client.PutAsJsonAsync(uriTransaction, editedTransaction);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Transaction Editted!", "Success Message");
            }
            else
            {
                MessageBox.Show("Something went wrong.", "Alert Message");
                await PopulateDataGridView();
            }
        }
        private async Task deleteTransaction(int id)
        {
            var response = await client.DeleteAsync(uriTransaction + "/" + id);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Transaction Deleted!", "Success Message");
            }
            else
            {
                MessageBox.Show("Cannot delete this transaction.");
                await PopulateDataGridView();
            }
        }
        private async void grvTransactions_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            TransactionListDto? chosenTransaction = grvTransactions.GetRow(e.RowHandle) as TransactionListDto;
            createLineTransaction = chosenTransaction.Id;
            await PopulateTransactionLines(chosenTransaction);
        }

        private async Task PopulateTransactionLines(TransactionListDto chosenTransaction)
        {
            var dataTransactionLine = await getTransactionLines();
            var dataItem = await getItems();
            List<TransactionLineListDto> linesForTransactions = new List<TransactionLineListDto>();
            foreach (var item in dataTransactionLine)
            {
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

        private async Task deleteTransactionLine(int id)
        {
            var response = await client.DeleteAsync(uriTransactionLine + "/" + id);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Transaction Line Deleted!", "Success Message");
            }
            else
            {
                MessageBox.Show("Cannot delete this customer.");
                await PopulateTransactionLines(createLineTransaction);
            }
        }
        private async Task PopulateTransactionLines(int chosenTransaction)
        {
            var dataTransactionLine = await getTransactionLines();
            var dataItem = await getItems();
            List<TransactionLineListDto> linesForTransactions = new List<TransactionLineListDto>();
            foreach (var item in dataTransactionLine)
            {
                if (item.TransactionId == chosenTransaction)
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
        private async void grvTransactionLines_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
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
            await editTransactionLine(editedTransactionLine);
        }
        private async void grvTransactionLines_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            TransactionLineListDto? deletedTransactionLine = grvTransactionLines.GetRow(e.RowHandle) as TransactionLineListDto;
            await deleteTransactionLine(deletedTransactionLine.Id);
        }
        private async Task editTransactionLine(TransactionLineListDto editedTransactionLine)
        {
            var response = await client.PutAsJsonAsync(uriTransactionLine, editedTransactionLine);
            if (response.IsSuccessStatusCode)
            {
                if (!flag)
                {
                    MessageBox.Show("Transaction Line Editted!", "Success Message");
                }
                await PopulateTransactionLines(createLineTransaction);
                flag = false;
            }
            else
            {
                MessageBox.Show("Something went wrong.", "Alert Message");
                await PopulateTransactionLines(createLineTransaction);
            }
        }
        private async void grvTransactionLines_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
			grvTransactionLines.ClearColumnErrors();
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
					var trans = await getTransaction(createLineTransaction);
					foreach (var item in trans.TransactionLines)
					{
						if (item.ItemType == ItemType.Fuel)
						{
							flag = true;
							MessageBox.Show("Cannot add a second fuel");
							await PopulateTransactionLines(createLineTransaction);
							return;
						}
					}
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
            var response = await client.GetAsync(uriItem + "/" + id);
            string responseContent = await response.Content.ReadAsStringAsync();
            ItemListDto dataItem = JsonConvert.DeserializeObject<ItemListDto>(responseContent);
            return dataItem;
        }

        private async void btnUpdateTotal_Click(object sender, EventArgs e)
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
            int rowHandle = grvTransactions.LocateByValue("Id", createLineTransaction);
            grvTransactions.SetRowCellValue(rowHandle, "TotalValue", transactionTotal);
            if (transactionTotal > 50)
            {
                grvTransactions.SetRowCellValue(rowHandle, "PaymentMethod", PaymentMethod.Cash);
            }
            int rowHandleTransaction = grvTransactions.LocateByValue("Id", createLineTransaction);
            TransactionListDto? transactionToSave = grvTransactions.GetRow(rowHandleTransaction) as TransactionListDto;
            await editTransaction(transactionToSave);
        }
        private void btnToIndex_Click(object sender, EventArgs e)
        {
            Home indexForm = new();
            this.Hide();
            indexForm.ShowDialog();
            this.Close();
        }

        private void btnCreateTransaction_Click(object sender, EventArgs e)
        {
            CreateTransaction newTransactionForm = new();
            this.Hide();
            newTransactionForm.ShowDialog();
            this.Close();
        }

		private void grvTransactions_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			grvTransactions.ClearColumnErrors();
		}
	}
}
