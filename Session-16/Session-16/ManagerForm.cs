using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Office.Utils;
using DevExpress.Utils;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
using System.Windows.Controls;
using System.Windows.Forms;
using static LibCarService.ServiceTask;
using GridView = DevExpress.XtraGrid.Views.Grid.GridView;
using Transaction = LibCarService.Transaction;

namespace Session_11 {
    public partial class ManagerForm : Form {

        CarServiceCenter carServiceCenter;
        //Settings formSettings;
        public ManagerForm() {
            InitializeComponent();

        }

        private void ManagerForm_Load(object sender, EventArgs e) {
            carServiceCenter = new CarServiceCenter();
            //carServiceCenter.Settings = new Settings();
            //carServiceCenter.Settings.PricePerHour = 45.5M;
            SetFormGrids();
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

        }
        private void SetFormGrids() {
            BindingList<Manager> managers = new BindingList<Manager>(carServiceCenter.Managers);
            grdManagers.DataSource = new BindingSource() { DataSource = managers };
            
            BindingList<Engineer> engineers = new BindingList<Engineer>(carServiceCenter.Engineers);
            grdEngineers.DataSource = new BindingSource() { DataSource = engineers };

            repManagers.DataSource = new BindingSource() { DataSource = managers };
            repManagers.DisplayMember = "Name";
            repManagers.ValueMember = "ID";
            repManagersView.Assign(grdManagers.MainView, false);

            BindingList<ServiceTask> serviceTasks = new BindingList<ServiceTask>(carServiceCenter.ServiceTasks);
            grdServiceTasks.DataSource = new BindingSource() { DataSource = serviceTasks };

            BindingList<LibCarService.Transaction> transactions = new BindingList<LibCarService.Transaction>(carServiceCenter.Transactions);
            grdTransactions.DataSource = new BindingSource() { DataSource = transactions };

            BindingList<Car> cars = new BindingList<Car>(carServiceCenter.Cars);
            repCars.DataSource = new BindingSource() { DataSource = cars };
            repCars.DisplayMember = "Model";
            repCars.ValueMember = "ID";

            BindingList<Customer> customers = new BindingList<Customer>(carServiceCenter.Customers);
            repCustomers.DataSource = new BindingSource() { DataSource = customers };
            repCustomers.DisplayMember = "Surname";
            repCustomers.ValueMember = "ID";
            
            

            repManagers2.DataSource = new BindingSource() { DataSource = managers };
            repManagers2.DisplayMember = "Surname";
            repManagers2.ValueMember = "ID";
            gridView2.Assign(grdManagers.MainView, false);

            
        }


        private void grvServiceTasks_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e) {
            if (e.Column.Caption == "Code") {
                //MessageBox.Show(e.Value.ToString());

                switch (e.Value) {
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
        

        private void repTransactionLinesViewBtn_Click(object sender, EventArgs e) {
            //Gets All Transaction Lines of a Transaction
            
            //List<TransactionLine> allTransactionLines = new List<TransactionLine>(carServiceCenter.TransactionLines);
            int row = grvTransactions.GetFocusedDataSourceRowIndex();
            Guid currentTranstactionID = (Guid)grvTransactions.GetRowCellValue(row, "ID");
            List<TransactionLine> currentTransactionLines = new List<TransactionLine>();
            //currentTransactionLines = allTransactionLines.FindAll(c =>c.TransactionID == currentTranstactionID).ToList();
            Transaction curremtTransaction = carServiceCenter.Transactions.Find(c => c.ID == currentTranstactionID);
            

            BindingList<TransactionLine> transactionLines = new BindingList<TransactionLine>(curremtTransaction.Lines);
            grdTransactionLines.DataSource = new BindingSource() { DataSource = transactionLines };



            BindingList<ServiceTask> serviceTasks = new BindingList<ServiceTask>(carServiceCenter.ServiceTasks);
            BindingList<Engineer> engineers = new BindingList<Engineer>(carServiceCenter.Engineers);


            repTransactionLinesTasks.DataSource = new BindingSource() { DataSource = serviceTasks };
            repTransactionLinesTasks.DisplayMember = "Code";
            repTransactionLinesTasks.ValueMember = "ID";


            repTransactionLineEngineers.DataSource = new BindingSource() { DataSource = engineers };
            repTransactionLineEngineers.DisplayMember = "Surname";
            repTransactionLineEngineers.ValueMember = "ID";



        }

        private void btnLoad_Click(object sender, EventArgs e) {
            string fileName = "carServiceCenter.json";

            Serializer serializer = new Serializer();

            if (File.Exists(fileName)) {
                carServiceCenter = serializer.Deserialize<CarServiceCenter>("carServiceCenter.json");
                if (carServiceCenter != null) {
                    SetFormGrids();
                }
                else {
                    MessageBox.Show("File is empty");
                }
            }
            else {
                MessageBox.Show("File not Found");
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(carServiceCenter, "carServiceCenter.json");

            MessageBox.Show("Data Saved!");
        }

        private void btnPopulate_Click(object sender, EventArgs e) {
            PopulateCarCenter();
            SetFormGrids();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            DateTime date = dateTimePicker1.Value;
            MonthlyLedger monthlyLedger = new MonthlyLedger(date);

            decimal monthIncome = carServiceCenter.CalculateMonthlyIncome(date);
            decimal monthExpenses = carServiceCenter.CalculateMonthlyExpenses();
            monthlyLedger.UpdateLedger(monthIncome, monthExpenses);
            List<MonthlyLedger>  monthlyLedgerList = new List<MonthlyLedger>();
            monthlyLedgerList.Add(monthlyLedger);

            grdMonthlyLedger.DataSource = monthlyLedgerList;

        }

        private void btnAddTransaction_Click(object sender, EventArgs e) {
            if(carServiceCenter == null) {
                MessageBox.Show("No data");
                return;
            }
            
            if (carServiceCenter.DailyTasksAvailability()) {
                grvTransactions.AddNewRow();
            }
            else {
                MessageBox.Show("No engineer available today");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            int year = 2016;
            int month = 1;

            int monthNow = DateTime.Now.Month;
            int yearNow = DateTime.Now.Year;

            decimal monthIncome;
            decimal monthExpenses;

            List<MonthlyLedger> monthlyLedgerList = new List<MonthlyLedger>();

            for (int i = year; i <= yearNow; i++) {

                for (int j = 1; j <= 12; j++) {
                    if(i == yearNow && j > monthNow) {
                        break; 
                    }
                    DateTime date = new DateTime(i, j, 1);
                    MonthlyLedger monthlyLedger = new MonthlyLedger(date);
                    monthIncome = carServiceCenter.CalculateMonthlyIncome(date);
                    monthExpenses = carServiceCenter.CalculateMonthlyExpenses();
                    monthlyLedger.UpdateLedger(monthIncome, monthExpenses);
                    monthlyLedgerList.Add(monthlyLedger);
                }
            }

            grdMonthlyLedger.DataSource = monthlyLedgerList;

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btnAddLine_Click(object sender, EventArgs e) {
            //GridColumn column = grvTransactionLines.Columns[0] as GridColumn;
            //column.OptionsColumn.ReadOnly = false;

            grvTransactionLines.AddNewRow();
        }

        private void gridView3_CellValueChanging(object sender, CellValueChangedEventArgs e) {
            //if (e.Column.Caption == "Code") {
            //    //MessageBox.Show(e.Value.ToString());
            //    decimal Hours;
            //    switch (e.Value) {
            //        case CodeEnum.OilChange:
            //            Hours = 1.5M;
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "Hours", Hours);
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "Price", carServiceCenter.CalcPrice(Hours, formSettings.PricePerHour));
            //            break;
            //        case CodeEnum.TireChange:
            //            Hours = 2.5M;
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "Hours", Hours);
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "Price", carServiceCenter.CalcPrice(Hours, formSettings.PricePerHour));
            //            break;
            //        case CodeEnum.BrokenWindow:
            //            Hours = 1.25M;
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "Hours", Hours);
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "Price", carServiceCenter.CalcPrice(Hours, formSettings.PricePerHour));
            //            break;
            //        case CodeEnum.EngineChange:
            //            Hours = 5M;
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "Hours", Hours);
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "Price", carServiceCenter.CalcPrice(Hours, formSettings.PricePerHour));
            //            break;
            //        case CodeEnum.MirrorReplacement:
            //            Hours = 0.5M;
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "Hours", Hours);
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "Price", carServiceCenter.CalcPrice(Hours, formSettings.PricePerHour));
            //            break;
            //        default:
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "PricePerHour", formSettings.PricePerHour);
            //            break;
            //    }



            //}
        }

        private void grvTransactionLines_CellValueChanging(object sender, CellValueChangedEventArgs e) {
            //if (e.Column.Caption == "Task") {
            //    //MessageBox.Show(e.Value.ToString());
            //    decimal Hours;
            //    decimal PricePerHour = 45.5M;
                
            //    switch (e.Value) {
            //        case CodeEnum.OilChange:
            //            Hours = 1.5M;
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "Hours", Hours);
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "Price", carServiceCenter.CalcPrice(Hours, PricePerHour));
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "PricePerHour", PricePerHour);
            //            break;
            //        case CodeEnum.TireChange:
            //            Hours = 2.5M;
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "Hours", Hours);
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "Price", carServiceCenter.CalcPrice(Hours, PricePerHour));
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "PricePerHour", PricePerHour);
            //            break;
            //        case CodeEnum.BrokenWindow:
            //            Hours = 1.25M;
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "Hours", Hours);
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "Price", carServiceCenter.CalcPrice(Hours, PricePerHour));
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "PricePerHour", PricePerHour);
            //            break;
            //        case CodeEnum.EngineChange:
            //            Hours = 5M;
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "Hours", Hours);
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "Price", carServiceCenter.CalcPrice(Hours, PricePerHour));
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "PricePerHour", PricePerHour);
            //            break;
            //        case CodeEnum.MirrorReplacement:
            //            Hours = 0.5M;
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "Hours", Hours);
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "Price", carServiceCenter.CalcPrice(Hours, PricePerHour));
            //            grvTransactionLines.SetRowCellValue(e.RowHandle, "PricePerHour", PricePerHour);
            //            break;
            //        default:
                        
            //            break;
            //    }
            //}



        }

        //private void grvTransactions_MouseDown(object sender, MouseEventArgs e) {
        //    GridView view = sender as GridView;
        //    GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
        //    DXMouseEventArgs.GetMouseArgs(e).Handled = view.ActiveEditor != null && view.FocusedRowHandle != hitInfo.RowHandle;
        //}

        //private void grdTransactions_ProcessGridKey(object sender, KeyEventArgs e) {
        //    GridControl grid = sender as GridControl;
        //    GridView view = grid.MainView as GridView;
        //    if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) {
        //        e.Handled = view.ActiveEditor != null;
        //    }
        //}
    }
}
