using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarServiceCenterWeb.Mvc.Models.TransactionLines
{
    public class TransactionLinesDetailsDto
    {
        public int Id { get; set; }
        public decimal Hours { get; set; }
        public decimal PricePerHour { get; set; }
        public decimal Price { get; set; }
        public int TransactionId { get; set; }
        public int ServiceTaskId { get; set; }
        public int EngineerId { get; set; }
        public string EngineerName { get; set; }
        public DateTime Date { get; set; }
        public string ServiceTaskName { get; set; }
        public List<SelectListItem> Transaction { get; } = new List<SelectListItem>();
        public List<SelectListItem> ServiceTask { get; } = new List<SelectListItem>();
        public List<SelectListItem> Engineer { get; } = new List<SelectListItem>();
    }
}
