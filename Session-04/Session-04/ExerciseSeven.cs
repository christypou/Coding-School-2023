using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class ExerciseSeven
    {
        double celcius = 30.5;

        public double getKelvin() {
            
            double kelvin = celcius + 273.15;
            return kelvin;
        }

        public double getFahrenheit()
        {
            double fahrenheit =  celcius * (9.0 / 5.0) + 32;
            return fahrenheit;


        }
    }
}
