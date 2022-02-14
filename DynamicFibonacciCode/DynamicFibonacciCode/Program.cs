using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFibonacciCode
{
    internal class Program
    {
        static long Fibo(long number)
        {
            long[] vs = new long[number];
            if (number == 1 || number == 2)
            {
                return 1;
            }
            else if (number > 2)
            {
                vs[0] = 1;
                vs[1] = 1;
                for (int i = 2; i < number; i++)
                {
                    vs[i] = vs[i - 1] + vs[i - 2];
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
            Console.WriteLine("Enter the index you want or e to end the program: ");
            string input = Console.ReadLine();
            while (input != "e")
            {
                if (Fibo(long.Parse(input)) == 0)
                {
                    Console.WriteLine("input invalid");
                }
                else
                {
                    Console.WriteLine(Fibo(long.Parse(input)));
                }
                Console.WriteLine("Enter the index you want or e to end the program: ");
                input = Console.ReadLine();
            }
            Console.WriteLine("Goodbye ^-^");
        }
    }
}
