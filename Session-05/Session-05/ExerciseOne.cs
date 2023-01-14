using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ExerciseOne
    {
        public String convertName(String name)
        {
            char[] array = name.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
