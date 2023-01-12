using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class ExerciseSix
    {
        TimeSpan diff = TimeSpan.FromSeconds(122144441);
        public int getYears()
        {
            int years = diff.Days / 365;
            return years;
        }
        public int getDays()
        {
            int days = ((diff.Days - (diff.Days / 365) * 365) - ((diff.Days - (diff.Days / 365) * 365) / 30) * 30) + (30 * ((diff.Days - (diff.Days / 365) * 365) / 30));
            return days;
        }
        public int getHours()
        {
            int hours = diff.Hours;
            return hours;
        }
        public int getMinutes()
        {
            int minutes = diff.Minutes;
            return minutes;
        }

    }




}
