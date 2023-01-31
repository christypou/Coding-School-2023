using LibCarService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Session_11 {
    public class CarServiceCenter {

        public List<Manager> Managers { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Car> Cars { get; set; }
        public List<ServiceTask> ServiceTasks { get; set; }
        public List<Engineer> Engineers { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }
        public List<MonthlyLedger> MonthlyLedger { get; set; }
        public Settings Settings { get; set; }


        public CarServiceCenter() {
            Managers = new List<Manager>();
            Customers = new List<Customer>();
            Cars = new List<Car>();
            ServiceTasks = new List<ServiceTask>();
            Engineers = new List<Engineer>();
            Transactions = new List<Transaction>();
            TransactionLines = new List<TransactionLine>();
        }


        // Methods / Business
        public void CreateTransaction(Customer customer, Car car, Manager manager) {
            // basic info
            Transaction transaction = new Transaction();
            transaction.Date = DateTime.Now.Date;
            transaction.CustomerID = customer.ID;
            transaction.CarID = car.ID;
            transaction.ManagerID = manager.ID;

            Transactions.Add(transaction);
        }

        public void AddServiceTask(ServiceTask serviceTask) {
            int engineersSum = Engineers.Count;

            List<Transaction> transactionsToday = Transactions.FindAll(c => c.Date.Date == DateTime.Today).ToList();
            // Engineer count check
            int tasksToday = 0;
            foreach(Transaction transaction in transactionsToday) {
                tasksToday += transaction.Lines.Count;
            } 

            // Maximum Daily Workload check
            // read today's tasks, can't be more than 8 hrs
            int maxDailyWorkload = Engineers.Count * 8;
            decimal todaysWorkload = 0;
            foreach(Transaction transaction in transactionsToday) {
                foreach(TransactionLine line in transaction.Lines) {
                    todaysWorkload += line.Hours;
                }
            }

            if (todaysWorkload + serviceTask.Hours > maxDailyWorkload) {
                // backlog: fail because of hours
            }
            else if (tasksToday >= engineersSum) {
                // backlog: fail because of engineers
            }
            else {
                ServiceTasks.Add(serviceTask);
            }
            // by @danielyor <3

        }

        public bool DailyTasksAvailability() {
            int engineersSum = Engineers.Count;

            List<Transaction> transactionsToday = Transactions.FindAll(c => c.Date.Date == DateTime.Today).ToList();
            // Engineer count check
            int tasksToday = 0;
            foreach (Transaction transaction in transactionsToday) {
                tasksToday += transaction.Lines.Count;
            }

            bool checkBool = tasksToday < engineersSum;

            return checkBool;

        }

        public bool WorkLoadAvailability(decimal taskHours) {
            List<Transaction> transactionsToday = Transactions.FindAll(c => c.Date.Date == DateTime.Today).ToList();
            int maxDailyWorkload = Engineers.Count * 8;
            decimal todaysWorkload = 0;
            foreach (Transaction transaction in transactionsToday) {
                foreach (TransactionLine line in transaction.Lines) {
                    todaysWorkload += line.Hours;
                }
            }
            bool checkBool = (todaysWorkload + taskHours <= maxDailyWorkload);

            return checkBool;
        }

        // method: calc expenses
        public decimal CalculateMonthlyExpenses() {
            decimal expensesSum = 0;
            foreach(Engineer engineer in Engineers) {
                expensesSum += engineer.SalaryPerMonth;
            }
            foreach(Manager manager in Managers) {
                expensesSum += manager.SalaryPerMonth;
            }

            return expensesSum;

        }

        // method: calc incomes
        public decimal CalculateMonthlyIncome(DateTime date) {
            int month = date.Month;
            int year = date.Year;
            decimal incomeSum = 0;

            List<Transaction> transactionsThisMonth = Transactions.FindAll(c => c.Date.Month == month).FindAll(c => c.Date.Year == year).ToList();

            foreach(Transaction transaction in transactionsThisMonth) {
                incomeSum += transaction.TotalPrice;
            }

            return incomeSum;
        }

        public decimal CalcPrice(decimal hours, decimal pricePerHour) {

            return hours * pricePerHour;
        }

    }
}
