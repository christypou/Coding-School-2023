using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ExerciseThree
    {
        public string findPrimes(int number)
        {
            StringBuilder sb = new StringBuilder();
            for (int j = 1; j <= number; j++)
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
                    sb.Append(j+" ");
                    //Console.WriteLine(j);

                }

            }
            string primes = sb.ToString();
            return primes;
            //Console.WriteLine(sb);
        }
        
    }
}
