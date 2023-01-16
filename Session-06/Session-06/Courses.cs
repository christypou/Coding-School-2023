using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Courses
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Subject { get; set; }

        public Courses()
        {

        }
        public Courses(int id)
        {
            Id = id;
        }
        public Courses(int id, string code)
        {
            Id = id;
            Code = code;
        }
        public Courses(int id, string code, string subject)
        {
            Id = id;
            Code = code;
            Subject = subject;
        }
    }
}
