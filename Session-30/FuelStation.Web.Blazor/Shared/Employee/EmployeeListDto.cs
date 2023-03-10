using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared.Employee
{
	public class EmployeeListDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public DateTime HireDateStart { get; set; }
		public DateTime HireDateEnd { get; set; }
		public decimal SalaryPerMonth { get; set; }
		public EmployeeType EmployeeType { get; set; }
	}
}
