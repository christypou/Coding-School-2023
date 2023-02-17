using Session_30.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_30
{
	public class Transaction
	{
		public Transaction(PaymentMethod paymentMethod ) { 
			Date= DateTime.Now;
			PaymentMethod = paymentMethod;
			TotalValue = 0;

			TransactionLines = new List<TransactionLine>();
		}

		public int Id { get; set; }
		public DateTime Date { get; set; }
		public PaymentMethod PaymentMethod { get; set; }
		public decimal TotalValue { get; set; }
		
		public int CustomerId { get; set; }
		public Customer Customer { get; set; } = null!;

		public int EmployeeId { get; set; }
		public Employee Employee { get; set; } = null!;

		public List<TransactionLine> TransactionLines { get; set; }
	}
}
