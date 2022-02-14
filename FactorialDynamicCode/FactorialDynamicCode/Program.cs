using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialDynamicCode
{
    internal class Program
    {
        static long Factorial(long number)
        {
            long[] vs = new long[number];
            vs[0] = 1;
            for (int i = 1; i < vs.Length; i++)
            {
                vs[i] = vs[i-1]*i;
            }
            return vs[number-1];
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please type the number you want to see it's factorial here or e to exit : ");
                string input = Console.ReadLine();
                if (input == "e")
                {
                    Console.WriteLine("Goodbye ^-^");
                    break;
                }
                else if (input.All(char.IsDigit))
                {
                    Console.WriteLine(Factorial(long.Parse(input)) + "\n*****************");
                    Console.WriteLine("Please type the number you want to see it's factorial here or e to exit : ");
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("wrong input try again : ");
                    input = Console.ReadLine();
                }
            }
        }
    }
}
