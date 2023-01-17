using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class ActionResponse
    {
        public Guid ResponseID { get; set; }
        public string Output { get; set; }
        public int Output2 { get; set; }
        public Guid RequestID { get; set; }
        public ActionResponse() { }
        public ActionResponse(String text,Guid Id) { 
            ResponseID = Guid.NewGuid();
            Output = text;
            RequestID = Id;
        }
        public ActionResponse(int number, Guid Id)
        {
            ResponseID = Guid.NewGuid();
            Output2 = number;
            RequestID = Id;
        }

    }
}
