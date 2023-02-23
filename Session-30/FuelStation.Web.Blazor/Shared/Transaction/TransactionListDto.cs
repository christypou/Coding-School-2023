using FuelStation.Model.Enums;
using FuelStation.Web.Blazor.Shared.Customer;
using FuelStation.Web.Blazor.Shared.Employee;
using FuelStation.Web.Blazor.Shared.TransactionLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared.Transaction
{
	public class TransactionListDto
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public PaymentMethod PaymentMethod { get; set; }
		public decimal TotalValue { get; set; }

		public int CustomerId { get; set; }

		public int EmployeeId { get; set; }
		public string CustomerFullName { get; set; } = null!;
		public string EmployeeFullName { get; set; } = null!;
		public List<CustomerListDto> Customers { get; set; } = new();
		public List<EmployeeListDto> Employees { get; set; } = new();
		public List<TransactionLineListDto> TransactionLines { get; set; } = new();
	}
}
