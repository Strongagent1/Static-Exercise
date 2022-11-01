using StaticExercise;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    static class TempConverter
    {
        public static double FahrenheitToCelsius(double fTemp)
        {
            return (fTemp - 32) * 5 / 9;
        }
        public static double CelsiusToFahrenheit(double cTemp)
        {
            return (cTemp * 9) / 5 + 32;
        }
    }
}
    
