using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared
{
	public class MonthlyLedgerDto
	{
		
			public int Year { get; set; }
			public int Month { get; set; }
			public Decimal Income { get; set; }
			public Decimal Expenses { get; set; }
			public Decimal Total { get; set; }
			public MonthlyLedgerDto(DateTime date)
			{
				Year = date.Year;
				Month = date.Month;
			}

			public void UpdateLedger(decimal income, decimal expenses)
			{
				Income = income;
				Expenses = expenses;
				Total = income - expenses;
			}
		
	}
}
