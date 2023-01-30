namespace LibCarService 
{
    public class Car
    {
        public Guid ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CarRegistrationNumber { get; set; }

        public Car()
        {
            ID = Guid.NewGuid();
        }
    }
}