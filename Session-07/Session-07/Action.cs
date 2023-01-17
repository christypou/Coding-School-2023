using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class Action
    {
        public Guid RequestId { get; set; }

        public Action() {
        RequestId= Guid.NewGuid();
        }
        public Action(Guid requestId)
        {
            RequestId = requestId;
        }
    }
}
