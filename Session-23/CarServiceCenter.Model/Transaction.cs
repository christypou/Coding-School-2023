namespace CarServiceCenter.Model
{
    public class Transaction
    {
        public Transaction()
        {
            Date = DateTime.Now;
            TotalPrice = 0;

            TransactionLines = new List<TransactionLine>();
        }
        public Transaction(DateTime date)
        {
            Date= date;
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public int ManagerId { get; set; }
        public Manager Manager { get; set; } = null!;

        public int CarId { get; set; }
        public Car Car { get; set; } = null!;

        public List<TransactionLine> TransactionLines { get; set; }
    }
}
