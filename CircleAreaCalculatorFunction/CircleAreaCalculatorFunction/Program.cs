using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaCalculatorFunction
{
    internal class Program
    {
        public static double Area(double radious)
        {
            return (Math.Pow(radious,2)*3.14);
        }
        public static double Perimeter(double radious)
        {
            return (2*radious*3.14);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radious you want : ");
            double radious = int.Parse(Console.ReadLine());
            Console.WriteLine("------Area : "+ Area(radious));
            Console.WriteLine("-Perimeter : "+Perimeter(radious));
        }
    }
}
