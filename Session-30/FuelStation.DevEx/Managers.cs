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
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = (this.ClientSize.Height - label1.Height / 2) / 8;
            btnToCreateTransaction.Left = (this.ClientSize.Width - btnToCreateTransaction.Width) / 3;
            btnToCreateTransaction.Top = this.ClientSize.Height / 2;
            btnToItems.Top = this.ClientSize.Height / 2;
            btnToItems.Left = (this.ClientSize.Width - btnToViewTransactions.Width) / 2;
            btnToCustomers.Top = this.ClientSize.Height / 2;
            btnToCustomers.Left = ((this.ClientSize.Width - btnToCustomers.Width) * 2) / 3;
            btnToViewTransactions.Top = 2 * this.ClientSize.Height / 3;
            btnToViewTransactions.Left = (this.ClientSize.Width - btnToViewTransactions.Width) / 2;

            label1.Anchor = AnchorStyles.None;
            btnToCreateTransaction.Anchor = AnchorStyles.None;
            btnToCustomers.Anchor = AnchorStyles.None;
            btnToViewTransactions.Anchor = AnchorStyles.None;
            btnToItems.Anchor = AnchorStyles.None;
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
