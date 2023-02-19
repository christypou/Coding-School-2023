using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared.Customer
{
	public class CustomerEditDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		[RegularExpression(@"^[A]([0-9a-zA-Z])*$", ErrorMessage = "Invalid Card Number. Must start with A.")]
		
		public string CardNumber { get; set; }
	}
}
