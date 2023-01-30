using System;
using LibCarService;
using LibSerializer;

namespace Session_11 {
    public partial class LoginForm : Form {

        public LoginForm() {
            InitializeComponent();
        }

        public void LoginForm_Load(object sender, EventArgs e) {

        }

        public void btnCustomer_Click(object sender, EventArgs e) {
            CustomerForm customerForm = new();
            customerForm.ShowDialog();
        }

        public void btnManager_Click(object sender, EventArgs e) {
            ManagerForm managerForm = new();
            managerForm.ShowDialog();
        }

        public void btnEngineer_Click(object sender, EventArgs e) {
            EngineerForm engineerForm = new();
            engineerForm.ShowDialog();
        }

    }
}