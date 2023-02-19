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
		[Required]
		[MaxLength(50, ErrorMessage = "Name must have max length 50 letters.")]
		[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid Name. Can't contain numbers.")]
		public string Name { get; set; }
		[Required]
		[MaxLength(100, ErrorMessage = "Surname must have max length 100 letters.")]
		[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid Surname. Can't contain numbers.")]
		public string Surname { get; set; }
		[RegularExpression(@"^[A]([0-9a-zA-Z])*$", ErrorMessage = "Invalid Card Number. Must start with A.")]
		[Required]
		[MaxLength(15, ErrorMessage = "Card Number must have max length 15 characters.")]
		public string CardNumber { get; set; }
	}
}
