using LibCarService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibCarService.ServiceTask;

namespace Session_11 {
    public partial class DummyCarMech : CarServiceCenter {

        public DummyCarMech() {
            PopulateCustomers();
            PopulateManagers();
            PopulateCars();
            PopulateEngineers();
            PopulateServiceTasks();
            Transaction();
            TransactionLine();
        }


        public void PopulateCustomers() {
            Customer customer1 = new Customer();
            customer1.Name = "Chris";
            customer1.Surname = "Typou";
            customer1.Phone = "6948192491";
            customer1.TIN = "123456789";
            Customers.Add(customer1);

            Customer customer2 = new Customer();
            customer2.Name = "Nick";
            customer2.Surname = "Pappas";
            customer2.Phone = "69284820582";
            customer2.TIN = "8575896865";
            Customers.Add(customer2);
        }

        public void PopulateManagers() {
            Manager manager1 = new Manager();
            manager1.Name = "Jack";
            manager1.Surname = "Daniels";
            manager1.SalaryPerMonth = 2500;
            Managers.Add(manager1);

            Manager manager2 = new Manager();
            manager2.Name = "Johnie";
            manager2.Surname = "Walker";
            manager2.SalaryPerMonth = 2200;
            Managers.Add(manager2);
        }

        public void PopulateServiceTasks() {
            ServiceTask serviceTask1 = new ServiceTask();
            serviceTask1.Code = ServiceTask.CodeEnum.BrokenWindow;
            ServiceTasks.Add(serviceTask1);

            ServiceTask serviceTask2 = new ServiceTask();
            serviceTask1.Code = ServiceTask.CodeEnum.TireChange;
            ServiceTasks.Add(serviceTask2);

            serviceTask1.UpdateInfo(serviceTask1.Code);
            serviceTask2.UpdateInfo(serviceTask2.Code);
        }

        public void PopulateCars() {
            Car car1 = new Car();
            car1.Brand = "Ford";
            car1.Model = "Focus";
            car1.CarRegistrationNumber = "AI78839";
            Cars.Add(car1);

            Car car2 = new Car();
            car2.Brand = "Audi";
            car2.Model = "A4";
            car2.CarRegistrationNumber = "PI78542";
            Cars.Add(car2);
        }

        public void PopulateEngineers() {
            Engineer engineer1 = new Engineer();
            engineer1.Surname = "Nikou";
            engineer1.Name = "Nikos";
            engineer1.ManagerID = Managers[0].ID;
            engineer1.SalaryPerMonth = 1000;
            Engineers.Add(engineer1);

            Engineer engineer2 = new Engineer();
            engineer2.Surname = "Xariton";
            engineer2.Name = "Giotis";
            engineer2.ManagerID = Managers[0].ID;
            engineer2.SalaryPerMonth = 1100;
            Engineers.Add(engineer2);

        }

        //Guid customerID, Guid managerID, Guid carID ->transaction parameters
        public void Transaction() {
            Transaction transaction1 = new Transaction();
            transaction1.Date = DateTime.Now;
            transaction1.CustomerID = Customers[0].ID;
            transaction1.ManagerID = Managers[0].ID;
            transaction1.CarID = Cars[0].ID;
            transaction1.TotalPrice = 91;

            Transactions.Add(transaction1);

            Transaction transaction2 = new Transaction();
            transaction2.Date = DateTime.Now;
            transaction2.CustomerID = Customers[1].ID;
            transaction2.ManagerID = Managers[1].ID;
            transaction2.CarID = Cars[1].ID;
            transaction2.TotalPrice = 0;

            Transactions.Add(transaction2);

        }

        //Guid transactionID, Guid engineerID, Guid serviceTaskID, decimal hours
        public void TransactionLine() {
            TransactionLine transactionLine1 = new TransactionLine();
            transactionLine1.TransactionID = Transactions[0].ID;
            transactionLine1.Hours = ServiceTasks[0].Hours;
            transactionLine1.PricePerHour = 45.5M;
            transactionLine1.EngineerID = Engineers[0].ID;
            transactionLine1.ServiceTaskID = ServiceTasks[0].ID;
            TransactionLines.Add(transactionLine1);

            TransactionLine transactionLine2 = new TransactionLine();
            transactionLine2.TransactionID = Transactions[0].ID;
            transactionLine2.Hours = ServiceTasks[1].Hours;
            transactionLine2.PricePerHour = 45.5M;
            transactionLine2.EngineerID = Engineers[0].ID;
            transactionLine2.ServiceTaskID = ServiceTasks[1].ID;
            TransactionLines.Add(transactionLine2);

            Transactions[0].Lines.Add(transactionLine1);
            Transactions[0].Lines.Add(transactionLine2);
            //Transactions[0].Lines = new List<TransactionLine>();
            //Transactions[0].Lines.
            //Transactions[0].Lines.Add(transactionLine1);
            //Transactions[0].Lines.Add(transactionLine2);
        }

        public void CreateMonthlyLedger() {
            
            DateTime date = DateTime.Now;
            MonthlyLedger monthlyLedger1 = new MonthlyLedger(date);
            //monthlyLedger1.Income
            //monthlyLedger1.Expenses    
            //monthlyLedger1.Total

        }
        
    }
}
