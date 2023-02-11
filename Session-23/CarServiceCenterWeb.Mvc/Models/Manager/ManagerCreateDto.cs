namespace CarServiceCenterWeb.Mvc.Models.Manager
{
    public class ManagerCreateDto
    {
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int SalaryPerMonth { get; set; }
    }
}
