using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class ExerciseFive
    {
        int time = 122144441;
        public int getYears() {
            int years = time / 31536000;
            return years;
        }
      
        public double getDays()
        {
            double days = (time % 31536000) / 86400;
            return days;
        }
        public int getHours()
        {
            int hours = (time % 86400) / 3600; 
            return hours;
        }
        public int getMinutes()
        {
            int minutes = (time % 3600) / 60;
            return minutes; 
        }
    }
}
