using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class University : Institute
    {
        public Student[] Student { get; set; }
        public Courses[] Course { get; set; }
        public Grade[] Grades { get; set; }
        public Schedule[] ScheduleCourse { get; set; }

        public void GetStudents()
        {

        }
        public void GetCourses()
        {

        }
        public void GetGrades()
        {

        }
        public void SetSchedule(int courseId, int professorId, DateTime datetime)
        {

        }

    }
}
