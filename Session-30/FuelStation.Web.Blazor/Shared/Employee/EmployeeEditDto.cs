using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared.Employee
{
	public class EmployeeEditDto
	{
		public int Id { get; set; }
		[Required]
		[MaxLength(50, ErrorMessage = "Name must have max length 50 letters.")]
		[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid Name. Can't contain numbers.")]
		public string Name { get; set; }
		[Required]
		[MaxLength(100, ErrorMessage = "Surname must have max length 100 letters.")]
		[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid Surname. Can't contain numbers.")]
		public string Surname { get; set; }
		[Required]
		public DateTime HireDateStart { get; set; }
		[Required]
		public DateTime HireDateEnd { get; set; }
		[Required]
		[Range(1,9999)]
		public decimal SalaryPerMonth { get; set; }
		[Required] 
		[Range(1,3)]
		public EmployeeType EmployeeType { get; set; }
	}
}
