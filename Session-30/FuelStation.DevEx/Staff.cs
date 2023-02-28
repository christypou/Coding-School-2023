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
    public partial class Staff : Form
    {
        public Staff()
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

        private void btnToItems_Click(object sender, EventArgs e)
        {
            Items itemsForm = new();
            this.Hide();
            itemsForm.ShowDialog();
            this.Close();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = (this.ClientSize.Height - label1.Height / 2) / 8;
            btnToItems.Top = this.ClientSize.Height / 2;
            btnToItems.Left = (this.ClientSize.Width - btnToItems.Width) / 2;

            label1.Anchor = AnchorStyles.None;
            btnToItems.Anchor = AnchorStyles.None;
        }
    }
}
