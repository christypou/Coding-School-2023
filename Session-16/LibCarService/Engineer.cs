using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService 
{
    public class Engineer : Person
    {
        public Guid ManagerID { get; set; }
        // Since the Expenses and the Total in the Monthly Ledger are decimal... It`s better to have decimal SalaryPerMonth
        public decimal SalaryPerMonth { get; set; }
        public Engineer() : base()
        {
            
        }
    }
}
