using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Grade
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Grades { get; set; }

        public Grade()
        {
        }
        public Grade(int id)
        {
            Id= id;
        }
        public Grade(int id, int studentId, int courseId)
        {
            Id= id;
            StudentId= studentId;
            CourseId= courseId;
        }
        public Grade(int id, int studentId, int courseId, int grades) 
        {
            Id = id;
            StudentId = studentId;
            CourseId = courseId;
            Grades = grades;
        }

        public Grade(int id, int studentId)
        {
            Id = id;
            studentId = studentId;
        }

    }



}
