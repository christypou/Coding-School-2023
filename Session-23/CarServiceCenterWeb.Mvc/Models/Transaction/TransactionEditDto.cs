using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarServiceCenterWeb.Mvc.Models.Transaction
{
    public class TransactionEditDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public int ManagerId { get; set; }
        public int CarId { get; set; }
        public List<SelectListItem> Manager { get; } = new List<SelectListItem>();
        public List<SelectListItem> Customer { get; } = new List<SelectListItem>();
        public List<SelectListItem> Car { get; } = new List<SelectListItem>();
    }
}
