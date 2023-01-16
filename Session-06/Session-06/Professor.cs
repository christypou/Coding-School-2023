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

        public Professor(int id) : base(id) { 
        }
        public Professor(int id, string name) : base(id, name)
        {

        }
        public Professor(int id, string name, int age) : base(id, name, age)
        {

        }
        public Professor(int id, string name, int age, string rank) : base(id, name, age)
        {
            Rank = rank;
        }
        public Professor(int id, string name, int age, string rank, Courses[] course) : base(id, name, age)
        {
            Rank = rank;
            Courses= course;
        }

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
