using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.DevEx
{
    public partial class Managers : Form
    {
        public Managers()
        {
            InitializeComponent();
        }

        private void btnBackToIndex_Click(object sender, EventArgs e)
        {
            Index indexForm = new();
            this.Hide();
            indexForm.ShowDialog();
            this.Close();
        }

        private void btnToCustomers_Click(object sender, EventArgs e)
        {
            Customers customerForm = new();
            this.Hide();
            customerForm.ShowDialog();
            this.Close();
        }

        private void Managers_Load(object sender, EventArgs e)
        {

        }

        private void btnToItems_Click(object sender, EventArgs e)
        {
            Items itemForm = new();
            this.Hide();
            itemForm.ShowDialog();
            this.Close();
        }

        private void btnToCreateTransaction_Click(object sender, EventArgs e)
        {
            CreateTransaction newTransactionForm = new();
            this.Hide();
            newTransactionForm.ShowDialog();
            this.Close();
        }

        private void btnToViewTransactions_Click(object sender, EventArgs e)
        {
            ViewTransactions transactionsForm = new();
            this.Hide();
            transactionsForm.ShowDialog();
            this.Close();
        }
    }
}
