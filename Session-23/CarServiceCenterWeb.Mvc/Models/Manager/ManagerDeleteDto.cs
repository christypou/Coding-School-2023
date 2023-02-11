namespace CarServiceCenterWeb.Mvc.Models.Manager
{
    public class ManagerDeleteDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int SalaryPerMonth { get; set; }
    }
}
