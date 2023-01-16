using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Professor : Person
    {

        public string Rank { get; set; }
        public Courses[] Courses { get; set; }

        public void Teach(Courses course, DateTime time)
        {

        }
        public void SetGrade(int studentId, int courseId, int grade)
        {

        }
        public void GetName()
        {
            
        }
    }
}
