using LibCarService;
using LibSerializer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11 {
    public partial class EngineerForm : Form {
        CarServiceCenter carServiceCenter;
        public EngineerForm() {
            InitializeComponent();
        }

        private void EngineerForm_Load(object sender, EventArgs e) {
            carServiceCenter = new CarServiceCenter();
            SetGridProperties();
        }

        private void PopulateCarCenter() {

            carServiceCenter = new CarServiceCenter();
            DummyCarMech data = new();
            carServiceCenter.Customers = data.Customers;
            carServiceCenter.Cars = data.Cars;
            carServiceCenter.Managers = data.Managers;
            carServiceCenter.Engineers = data.Engineers;
            carServiceCenter.ServiceTasks = data.ServiceTasks;
            carServiceCenter.Transactions = data.Transactions;
            carServiceCenter.TransactionLines = data.TransactionLines;


            SetGridProperties();

        }
        private void SetGridProperties()
        {
            DummyCarMech data = new();

           
            BindingList<Engineer> engineers = new BindingList<Engineer>(carServiceCenter.Engineers);
            grdEngineers.DataSource = new BindingSource() { DataSource = engineers };
            BindingList<ServiceTask> serviceTasks = new BindingList<ServiceTask>(carServiceCenter.ServiceTasks);
            //grdServiceTasks.DataSource = new BindingSource() { DataSource = serviceTasks };
            
            repTasks.DataSource = new BindingSource() { DataSource = serviceTasks };
            //repTasks.DisplayMember = "Description";
            //repTasks.ValueMember = "ID";
        }
        

        private void textBoxServiceTaskTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e) {
            string fileName = "carServiceCenter.json";

            Serializer serializer = new Serializer();

            if (File.Exists(fileName)) {
                carServiceCenter = serializer.Deserialize<CarServiceCenter>("carServiceCenter.json");
                if (carServiceCenter != null) {
                    SetGridProperties();
                }
                else {
                    MessageBox.Show("File is empty");
                }
            }
            else {
                MessageBox.Show("File not Found");
            }
        }

        private void btnPopulate_Click(object sender, EventArgs e) {
            PopulateCarCenter();
            SetGridProperties();
        }

        private void grdServiceTasks_Click(object sender, EventArgs e)
        {

        }
    }
}
