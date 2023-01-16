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

        public University() { }
        public University(Student[] student)
        {
            Student = student;
        }

        public University(Student[] student, Courses[] course, Grade[] grades)
        {
            Student = student;
            Course = course;
            Grades = grades;
        }
        public University(Student[] student, Courses[] course, Grade[] grades, Schedule[] scheduleCourse)
        {
            Student = student;
            Course = course;
            Grades = grades;
            ScheduleCourse = scheduleCourse;
        }

        public University(int id, string name, int yearsInService):base(id, name, yearsInService)
        {

        }
        public University(int id, string name):base(id, name) { }
        public University(int id):base(id) { }
        public University(int id, string name, int yearsInService, Student[] student):base(id,name, yearsInService)
        {
            Student = student;   
        }
        public University(int id, string name, int yearsInService, Student[] student, Courses[] course) : base(id, name, yearsInService)
        {
            Student = student;
            Course = course;
        }
        public University(int id, string name, int yearsInService, Student[] student, Courses[] course, Grade[] grades) : base(id, name, yearsInService)
        {
            Student = student;
            Course = course;
            Grades = grades;
        }
        public University(int id, string name, int yearsInService, Student[] student, Courses[] course, Grade[] grades, Schedule[] scheduleCourse) : base(id, name, yearsInService)
        {
            Student = student;
            Course = course;
            Grades = grades;
            ScheduleCourse = scheduleCourse;
        }
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
