using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialRecresive
{
    internal class Program
    {
        static long Factorial(long number)
        {
            if (number < 0)
            {
                return 0;
            }
            else if (number == 1 || number == 0)
            {
                return 1;
            }
            else { return number*Factorial(number-1); }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number you want to see it's factorial here or e to exit : ");
            string input = Console.ReadLine();
            while (true)
            {
                if (input.All(char.IsDigit))
                {
                    long resault = Factorial(long.Parse(input));
                    if(resault == 0)
                    {
                        Console.WriteLine("wrong input try again : ");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(resault+"\n***********************");
                    }
                }
                else if(input == "e")
                {
                    break;
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
