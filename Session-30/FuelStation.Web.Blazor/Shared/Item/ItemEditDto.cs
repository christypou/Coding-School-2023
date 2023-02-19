using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared.Item
{
	public class ItemEditDto
	{
		public int Id { get; set; }
		[Required]
		[MaxLength(20, ErrorMessage = "Code must have max length 15 characters.")]
		public string Code { get; set; }
		[Required]
		[MaxLength(100, ErrorMessage = "Description must have max length 15 characters.")]
		public string Description { get; set; }
		[Range(1,3)]
		public ItemType ItemType { get; set; }
		[Range(1, 9999999)]
		public decimal Price { get; set; }
		[Range(1, 9999999)]
		public decimal Cost { get; set; }
	}
}
