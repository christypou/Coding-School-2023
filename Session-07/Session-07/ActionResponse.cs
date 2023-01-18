using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class ActionResponse:Action
    {
        public Guid ResponseID { get; set; }
        public string Output { get; set; }
        public int Output2 { get; set; }
        public ActionResponse() { }
        public ActionResponse(Guid Id, String text,Guid RequestId) :base(RequestId){ 
            ResponseID = Guid.NewGuid();
            Output = text;
            
        }
        

    }
}
