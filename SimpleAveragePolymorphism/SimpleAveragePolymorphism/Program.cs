using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAveragePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AverageCalculator.Ave(2,3));
            Console.WriteLine(AverageCalculator.Ave(2, 3,4));
            Console.WriteLine(AverageCalculator.Ave(2, 3, 4,5));
        }
    }
}
