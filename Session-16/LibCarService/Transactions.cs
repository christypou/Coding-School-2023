using Session_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService
{
    public class Transactions
    {
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public Guid CustomerID { get; set; }
        public Guid CarID { get; set; }
        public Guid ManagerID { get; set; }
        public decimal TotalPrice { get; set; }
        public List<TransactionLine> Lines { get; set; } = new List<TransactionLine>();

        //Relations
        public Customer Customer { get; set; }
        public Car Car { get; set; }
        public Manager Manager { get; set; }
        public CarServiceCenter CarServiceCenter { get; set; }
        public Transactions()
        {
            ID = Guid.NewGuid();
        }


        public void AddTransactionLine(ServiceTask serviceTask, Engineer engineer, decimal pricePerHr) {
            TransactionLine newLine = new TransactionLine();
            newLine.TransactionID = ID;
            newLine.ServiceTaskID = serviceTask.ID;
            newLine.EngineerID = engineer.ID;
            newLine.Hours = serviceTask.Hours;
            newLine.PricePerHour = pricePerHr;
            newLine.Price = newLine.Hours * newLine.PricePerHour;

            Lines.Add(newLine);
            UpdateTotalPrice();
        }

        public void UpdateTotalPrice() {
            TotalPrice = 0;
            foreach(TransactionLine line in Lines) {
                TotalPrice += line.Price;
            }
        }


    }
}
