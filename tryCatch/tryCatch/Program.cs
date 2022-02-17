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
                    Console.WriteLine("Please enter your number here or e to exit : ");
                    string input = Console.ReadLine();
                    if (input == "e")
                    {
                        Console.WriteLine("Goodbye! ^-^");
                        break;
                    }
                    int number = int.Parse(input);
                    Console.WriteLine("Resault : " + number*2);
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
