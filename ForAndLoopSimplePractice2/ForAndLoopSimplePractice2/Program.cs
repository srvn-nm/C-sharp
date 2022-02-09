using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAndLoopSimplePractice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your number here : ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int multi = 1;
            //for (int i = 1; i <= number; i++)
            //{
            //    sum += i;
            //    multi *= i;
            //}
            int i = 1;
            while (i <= number)
            {
                sum += i;
                multi *= i;
                i++;
            }
            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("Multiplication : " + multi);
        }
    }
}
