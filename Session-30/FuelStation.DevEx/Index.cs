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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void btnToManagers_Click(object sender, EventArgs e)
        {
            Managers managerForm = new();
            this.Hide();
            managerForm.ShowDialog();
            this.Close();
        }

        private void btnToStaff_Click(object sender, EventArgs e)
        {
            Staff staffForm = new();
            this.Hide();
            staffForm.ShowDialog();
            this.Close();
        }

        private void btnToCashier_Click(object sender, EventArgs e)
        {
            Cashier cashierForm = new();
            this.Hide();
            cashierForm.ShowDialog();
            this.Close();
        }
    }
}
