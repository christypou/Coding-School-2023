using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Schedule
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int ProfessorId { get; set; }
        public DateTime Callendar { get; set; }

        public Schedule()
        {

        }
        public Schedule(int id)
        {
            Id = id;
        }
        public Schedule(int id, int courseId)
        {
            Id = id;
            CourseId = courseId;
        }
        public Schedule(int id, int courseId,int professorId)
        {
            Id = id;
            CourseId = courseId;
            ProfessorId= professorId;
        }

        public Schedule(int id, int courseId, int professorId, DateTime callendar) 
        {
            Id = id;
            CourseId = courseId;
            ProfessorId=professorId;
            Callendar = callendar;
        }
    }
    

}
