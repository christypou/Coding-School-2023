using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarServiceCenterWeb.Mvc.Models.Engineer
{
    public class EngineerCreateDto
    {
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int SalaryPerMonth { get; set; }
        public int ManagerID { get; set; }

        public List<SelectListItem> Manager { get; } = new List<SelectListItem>();
    }
}
