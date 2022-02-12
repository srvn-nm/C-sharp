using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangleClass
{
    internal class Triangle
    {
        public double Height { get; set; }
        private double Base { get; set; }
        public Triangle(double b)
        {
            Base = b;
        }
        public double Area()
        {
            return Height*0.5*Base;
        }
        public static void Name()
        {
            Console.WriteLine("Triangle");
        }
    }
}
