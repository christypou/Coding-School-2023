﻿namespace CarServiceCenterWeb.Mvc.Models.ServiceTask
{
    public class ServiceTaskDetailsDto
    {
        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Hours { get; set; }
    }
}