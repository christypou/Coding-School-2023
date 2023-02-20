using FuelStation.Model.Enums;
using FuelStation.Web.Blazor.Shared.TransactionLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared.Transaction
{
	public class TransactionEditDto
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public PaymentMethod PaymentMethod { get; set; }
		public decimal TotalValue { get; set; }

		public int CustomerId { get; set; }

		public int EmployeeId { get; set; }
		public List<TransactionLineListDto> TransactionLines { get; set; } = new();

	}
}
