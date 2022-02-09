using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to see It's square: ");
            Console.WriteLine(Math.Pow((double.Parse(Console.ReadLine())),2));
        }
    }
}
