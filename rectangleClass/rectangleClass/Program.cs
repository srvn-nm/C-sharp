using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle(3.5);
            t.Height = 3.5;
            Console.WriteLine("The area of the given numbers as the variables of a triangle : " + t.Area());
            Triangle.Name();
        }
    }
}
