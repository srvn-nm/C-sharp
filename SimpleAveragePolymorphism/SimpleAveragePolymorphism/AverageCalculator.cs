using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAveragePolymorphism
{
    internal class AverageCalculator
    {
        public static double Ave(double a,double b)
        {
            return ((a+b)/2);
        }
        public static double Ave(double a, double b, double c)
        {
            return ((a + b+c) / 3);
        }
        public static double Ave(double a, double b, double c, double d)
        {
            return ((a + b + c+d) / 4);
        }
    }
}
