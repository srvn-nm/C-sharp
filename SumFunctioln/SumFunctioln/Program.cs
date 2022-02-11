using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFunctioln
{
    internal class Program
    {
        public static double Sum(double num1,double num2, double num3)
        {
            return num1 + num2 + num3;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter your numbers here : ");
            //double num1 = double.Parse(Console.ReadLine());
            //double num2 = double.Parse(Console.ReadLine());
            //double num3 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Sum of given numbers : "+Sum(num1,num2,num3));
            Console.WriteLine("Sum of given numbers : " + Sum(3.1, 3.2, 3));
            Console.WriteLine("Sum of given numbers : " + Sum(1,3.5,6.1));
            Console.WriteLine("Sum of given numbers : " + Sum(11, 13.5, 16.1));
        }
    }
}
