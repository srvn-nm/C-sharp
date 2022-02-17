using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    if (input == "e")
                    {
                        Console.WriteLine("Goodbye! ^-^");
                        break;
                    }
                    int number = int.Parse(input);
                    Console.WriteLine(number*2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            Console.WriteLine("Program is ended!\nSee you soon! ^-^");
        }
    }
}
