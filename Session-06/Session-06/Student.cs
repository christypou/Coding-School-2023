using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Student : Person
    {
        public int RegistrationNumber { get; set; }
        public Courses Courses { get; set; }

        public Student() { }
        public Student(int registrationNumber, Courses courses)
        {
            RegistrationNumber = registrationNumber;
            Courses = courses;
        }
        public Student(int registrationNumber)
        {
            RegistrationNumber = registrationNumber;
        }
        
        public Student(int id, string name): base(id,name) { 
        }
        public Student(int id,string name, int age): base(id,name,age) { 
            
        }
        public Student(int id, string name, int age, int registrationNumber) : base(id, name, age)
        {
            RegistrationNumber = registrationNumber;
        }
        public Student(int id, string name, int age,int registrationNumber, Courses courses) : base(id, name, age)
        {
            RegistrationNumber = registrationNumber;
            Courses= courses;
        }

        public void Attend(Courses course, DateTime datetime)
        {

        }
        public void WriteExam(Courses course, DateTime datetime)
        {

        }
    }
}
