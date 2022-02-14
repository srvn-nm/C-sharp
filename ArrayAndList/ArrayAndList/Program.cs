using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> list = new List<int>();
            int Sum = 0;
            int Multi = 1;
            for (int i = 1; i < 11; i++)
            {
                list.Add(i);
            }
            for (int i = 0; i < list.Count; i++)
            {
                Multi *= list[i];

            }
            foreach (int i in vs)
            {
                Sum += i;
            }
            Console.WriteLine("The sum of numbers in array : "+Sum+"\nThe multiple of numbers in list : "+Multi);
        }
    }
}
