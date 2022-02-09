using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAndWhileSimplePractice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your number: ");
            int range = int.Parse(Console.ReadLine());
            //for (int i = 0; i < range; i++)
            //{
            //    Console.WriteLine(i+1);
            //}
            int i = 0;
            while(i < range)
            {
                Console.WriteLine(i+1);
                i++;
            }
        }
    }
}
