using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class ActionRequest:Action
    {
        public String Input { get; set; }
        public ActionEnum Action { get; set; }

        public ActionRequest(Guid RequestId, ActionEnum action, string text):base(RequestId){
            //RequestId= Guid.NewGuid();
            Input = text;
            Action = action;
        }

        
    }
}
