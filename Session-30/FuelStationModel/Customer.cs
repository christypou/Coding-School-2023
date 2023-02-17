using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Session_30
{
	public class Customer : Person
	{
		public Customer(string name, string surname, string cardnumber)
		{
			Name = name;
			Surname = surname;
			CardNumber = cardnumber;
			
			
			Transactions = new List<Transaction>();

	}
		public string CardNumber { get; set; }


	//Relations
	public List<Transaction> Transactions { get; set; }
}
}
