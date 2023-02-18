using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model
{
	public class TransactionLine
	{

		public TransactionLine(decimal quantity, decimal itemPrice, decimal netValue,
			decimal discountPercent, decimal discountValue, decimal totalValue)
		{
			Quantity = quantity;
			ItemPrice = itemPrice;
			NetValue = quantity * itemPrice;
			DiscountPercent = discountPercent;
			DiscountValue = discountPercent * netValue;
			TotalValue = NetValue - DiscountValue;

		}

		public int Id { get; set; }
		public decimal Quantity { get; set; }
		public decimal ItemPrice { get; set; }
		public decimal NetValue { get; set; }
		public decimal DiscountPercent { get; set; }
		public decimal DiscountValue { get; set; }
		public decimal TotalValue { get; set; }

		public int TransactionId { get; set; }
		public Transaction Transaction { get; set; } = null!;

		public int ItemId { get; set; }
		public Item Item { get; set; } = null!;

	}
}
