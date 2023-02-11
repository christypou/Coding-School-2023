﻿namespace CarServiceCenter.Model
{
    public class Customer
    {
        public Customer(string name, string surname, string phone, string tin)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            Tin = tin;

            Transactions = new List<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Tin { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}
//public class CustomerCreateDto
//{
//    public int Id { get; set; } 
//    public string Name { get; set; } = null!;
//    public string Surname { get; set; } = null!;
//    public string Phone { get; set; } = null!;
//    public string Tin { get; set; } = null!;
//}