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
            if (number == 0)
            {
                return 1;
            }
            else if (number > 0)
            {
                long[] vs = new long[number];
                vs[0] = 1;
                for (int i = 1; i < number; i++)
                {
                    vs[i] = vs[i - 1] * (i + 1);
                }
                return vs[number - 1];
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please type the number you want to see it's factorial here or e to exit : ");
            string input = Console.ReadLine();
            while (true)
            {
                if (input == "e")
                {
                    Console.WriteLine("Goodbye ^-^");
                    break;
                }
                else if (input.All(char.IsDigit))
                {
                    long resault = Factorial(long.Parse(input));
                    if (resault == 0)
                    {
                        Console.WriteLine("wrong input try again : ");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(resault+"\n*****************");
                        Console.WriteLine("Please type the number you want to see it's factorial here or e to exit : ");
                        input = Console.ReadLine();
                    }
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
