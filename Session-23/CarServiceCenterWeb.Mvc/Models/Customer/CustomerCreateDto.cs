namespace CarServiceCenterWeb.Mvc.Models.Customer
{
    public class CustomerCreateDto
    {
        
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Tin { get; set; } = null!;
    }
}
