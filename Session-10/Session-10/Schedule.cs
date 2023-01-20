using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10
{
    public class Schedule
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }  
        public Guid ProfessorId { get; set; }
        public DateTime Callendar { get; set; }
    }
}
