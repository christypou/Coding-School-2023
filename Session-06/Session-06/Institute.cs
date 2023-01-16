using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Institute
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int YearsInService { get; set; }

        public Institute() { 
        }
        public Institute(int id)
        {

        }
        public Institute(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Institute(int id, string name, int yearsInService)
        {
            Id = id;
            Name = name;
            YearsInService = yearsInService;
        }

        public void GetName()
        {

        }
        public void SetName(string name)
        {

        }
    }
}
