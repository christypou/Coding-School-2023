using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FuelStation.Model
{
	public class Employee : Person
	{
		public Employee(string name, string surname, DateTime hireDateStart,
			DateTime hireDateEnd, decimal salaryPerMonth, EmployeeType employeeType)
		{
			Name = name;
			Surname = surname;
			HireDateStart = hireDateStart;
			HireDateEnd = hireDateEnd;
			SalaryPerMonth = salaryPerMonth;
			EmployeeType = employeeType;

			Transactions = new List<Transaction>();
		}
		public DateTime HireDateStart { get; set; }
		public DateTime HireDateEnd { get; set; }
		public decimal SalaryPerMonth { get; set; }
		public EmployeeType EmployeeType { get; set; }

		public List<Transaction> Transactions { get; set; }
	}
}
