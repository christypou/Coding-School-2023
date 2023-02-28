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
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        private void btnBackToIndex_Click(object sender, EventArgs e)
        {
            Home indexForm = new();
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

        private void btnToCreateTransaction_Click(object sender, EventArgs e)
        {
            CreateTransaction newTransactionForm = new();
            this.Hide();
            newTransactionForm.ShowDialog();
            this.Close();
        }

        private void btnToViewTransactions_Click(object sender, EventArgs e)
        {
            History transactionsForm = new();
            this.Hide();
            transactionsForm.ShowDialog();
            this.Close();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = (this.ClientSize.Height - label1.Height / 2) / 8;
            btnToCreateTransaction.Left = (this.ClientSize.Width - btnToCreateTransaction.Width) / 3;
            btnToCreateTransaction.Top = this.ClientSize.Height / 2;
            btnToCustomers.Top = this.ClientSize.Height / 2;
            btnToCustomers.Left = ((this.ClientSize.Width - btnToCustomers.Width) * 2) / 3;
            btnToViewTransactions.Top = 2 * this.ClientSize.Height / 3;
            btnToViewTransactions.Left = (this.ClientSize.Width - btnToViewTransactions.Width) / 2;
            //btnBackToIndex.Top = this.ClientSize.Height - (2 * btnBackToIndex.Height);
            //btnBackToIndex.Left = this.ClientSize.Width/9;

            label1.Anchor = AnchorStyles.None;
            btnToCreateTransaction.Anchor = AnchorStyles.None;
            btnToCustomers.Anchor = AnchorStyles.None;
            btnToViewTransactions.Anchor = AnchorStyles.None;
            //btnBackToIndex.Anchor = AnchorStyles.None;
        }
    }
}
