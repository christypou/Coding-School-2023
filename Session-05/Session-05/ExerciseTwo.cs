using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ExerciseTwo
    {
        public int GetSum(int num)
        {
             int sum= 0;
             for (int i = 1; i <= num; i++)
             {
                 sum += i;
             }
             
            return sum;
            
        }
        public int GetProduct(int num)
        {
             int product= 1;
             for (int i = 1; i <= num; i++)
             {
                 product *=  i;
             }
             
            return product;
            
        }
    }
}
