using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopAndCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int condition = 0;
            while (condition < 10)
            {
                Console.WriteLine("Please enter what we need for calculating : ");
                int num1 = int.Parse(Console.ReadLine());
                String exe = Console.ReadLine();
                int num2 = int.Parse(Console.ReadLine());
                if (exe == "+")
                {
                    Console.WriteLine("ans : " + (num2 + num1));
                }
                else if (exe == "-")
                {
                    Console.WriteLine("ans : " + (num1 - num2));
                }
                else if (exe == "*")
                {
                    Console.WriteLine("ans : " + (num2 * num1));
                }
                else if (exe == "/")
                {
                    Console.WriteLine("ans : " + (num1 / num2));
                }
                condition++;
            }
            Console.WriteLine("Your turn is over!\nGoodBye ^-^");
        }
    }
}
