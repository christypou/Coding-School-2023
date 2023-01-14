using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ExerciseThree
    {
        public void findPrimes(int j)
        {
              
                int a = 0;
                for (int i = 1; i <= j; i++)
                {
                    if (j % i == 0)
                    {
                        a++;
                    }
                }
                
                if (a == 2)
                {
                    Console.WriteLine(j);
                    
                }
                
            }
          
        

    }
}
