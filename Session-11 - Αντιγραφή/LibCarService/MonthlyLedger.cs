using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService 
{
    public class MonthlyLedger
    {
        public int Year { get; set; }

        public int Month { get; set; }

        public decimal Income { get; set; }

        public decimal Expenses { get; set; }

        public decimal Total { get; set; }

        // TODO: implement Update() method to update the monthly ledger
        public MonthlyLedger(DateTime date) {
            Year = date.Year;
            Month = date.Month;
        }

        public void UpdateLedger(decimal income, decimal expenses) {
            Income = income;
            Expenses = expenses;
            Total = income - expenses;
        }
    }
}

