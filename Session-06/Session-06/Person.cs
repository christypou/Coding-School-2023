using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public Person() { 
        
        }
        public Person(int id)
        {
            Id = id;
        }
        public Person(int id, string name)
        {
            Id = id;
            Name= name;
        }
        public Person(int id, string? name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public void GetName()
        {
            
        }
        public void SetName(string name)
        {

        }
    }
}
