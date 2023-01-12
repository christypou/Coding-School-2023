using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class ExerciseOne
    {

        public String GetMessage()
        {
            string name = "Chris";
            string message = "Hello" + " " + name;
            return message;
        }

    }
}
