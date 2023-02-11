namespace CarServiceCenterWeb.Mvc.Models.Car
{
    public class CarEditDto
    {
        public int Id { get; set; }
        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string CarRegistrationNumber { get; set; } = null!;
    }
}
