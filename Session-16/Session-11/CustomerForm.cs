using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
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
using static LibCarService.ServiceTask;

namespace Session_11
{
    public partial class CustomerForm : Form
    {

        CarServiceCenter carServiceCenter;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {


        }

        public void CustomerForm_Load_1(object sender, EventArgs e)
        {
            carServiceCenter = new CarServiceCenter();
            PrintDataToGrid();

        }

        private void PopulateCarCenter()
        {

            carServiceCenter = new CarServiceCenter();
            DummyCarMech data = new();
            carServiceCenter.Customers = data.Customers;
            carServiceCenter.Cars = data.Cars;
            carServiceCenter.Managers = data.Managers;
            carServiceCenter.Engineers = data.Engineers;
            carServiceCenter.ServiceTasks = data.ServiceTasks;
            carServiceCenter.Transactions = data.Transactions;
            carServiceCenter.TransactionLines = data.TransactionLines;


            PrintDataToGrid();

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            Serializer serializer = new Serializer();
            serializer.SerializeToFile(carServiceCenter, "carServiceCenter.json");

            MessageBox.Show("Data Saved!");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            string fileName = "carServiceCenter.json";

            Serializer serializer = new Serializer();

            if (File.Exists(fileName))
            {
                carServiceCenter = serializer.Deserialize<CarServiceCenter>("carServiceCenter.json");
                if (carServiceCenter != null)
                {
                    PrintDataToGrid();
                }
                else
                {
                    MessageBox.Show("File is empty");
                }
            }
            else
            {
                MessageBox.Show("File not Found");
            }
        }

        public void PrintDataToGrid()
        {
            BindingList<Customer> customers = new BindingList<Customer>(carServiceCenter.Customers);
            grdCustomers.DataSource = new BindingSource() { DataSource = customers };

            BindingList<Car> cars = new BindingList<Car>(carServiceCenter.Cars);
            grdCars.DataSource = new BindingSource() { DataSource = cars };

            BindingList<ServiceTask> serviceTasks = new BindingList<ServiceTask>(carServiceCenter.ServiceTasks);
            grdServiceTasks.DataSource = new BindingSource() { DataSource = serviceTasks };
        }

        private void grvServiceTasks_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Caption == "Code")
            {
                //MessageBox.Show(e.Value.ToString());

                switch (e.Value)
                {
                    case CodeEnum.OilChange:
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Description", "Change the oils");
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Hours", 1.5M);
                        break;
                    case CodeEnum.TireChange:
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Description", "Change the tire");
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Hours", 2.5M);
                        break;
                    case CodeEnum.BrokenWindow:
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Description", "Fix the broken window");
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Hours", 1.25M);
                        break;
                    case CodeEnum.EngineChange:
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Description", "Change the engine");
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Hours", 5M);
                        break;
                    case CodeEnum.MirrorReplacement:
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Description", "Replace the mirror");
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Hours", 0.5M);
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            PopulateCarCenter();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void grvCustomers_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridColumn name = view.Columns["Name"];
            GridColumn surname = view.Columns["Surname"];
            GridColumn phone = view.Columns["Phone"];
            GridColumn tin = view.Columns["TIN"];
            string colName = (string)view.GetRowCellValue(e.RowHandle, name);
            string ColSurname = (string)view.GetRowCellValue(e.RowHandle, surname);
            string Colphone = (string)view.GetRowCellValue(e.RowHandle, phone);
            string Coltin = (string)view.GetRowCellValue(e.RowHandle, tin);

            if (colName == null || ColSurname == null || Colphone == null || Coltin == null)
            {
                e.Valid = false;
                btnSend.Enabled = false;
                MessageBox.Show("Add all customer fields");
            }
            if (e.Valid)
            {
                btnSend.Enabled = true;
            }
        }

        private void gcvCars_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridColumn model = view.Columns["Model"];
            GridColumn brand = view.Columns["Brand"];
            GridColumn registration = view.Columns["CarRegistrationNumber"];
            string colModel = (string)view.GetRowCellValue(e.RowHandle, model);
            string ColBrand = (string)view.GetRowCellValue(e.RowHandle, brand);
            string ColRegistration = (string)view.GetRowCellValue(e.RowHandle, registration);

            if (colModel == null || ColBrand == null || ColRegistration == null )
            {
                e.Valid = false;
                btnSend.Enabled = false;
                MessageBox.Show("Add all car fields");
            }
            if (e.Valid)
            {
                btnSend.Enabled = true;
            }
        }

        private void grvServiceTasks_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridColumn code = view.Columns["Code"];
            GridColumn description = view.Columns["Description"];
            GridColumn hours = view.Columns["Hours"];
            var colModel = view.GetRowCellValue(e.RowHandle, code);
            string ColBrand = (string)view.GetRowCellValue(e.RowHandle, description);
            var ColRegistration = view.GetRowCellValue(e.RowHandle, hours);

            if (code == null || description== null || hours== null)
            {
                e.Valid = false;
                btnSend.Enabled = false;
                MessageBox.Show("Add all service fields");
            }
            if (e.Valid)
            {
                btnSend.Enabled = true;
            }
        }
    }
}