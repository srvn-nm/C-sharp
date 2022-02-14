using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> dict = new Dictionary<string,int>();
            dict["Sarvin"] = 6;
            dict["Nami"] = 4;
            dict["Abtin"] = 5;
            dict["Zandi"] = 5;
            Console.WriteLine("The value of key 'Sarvin' : "+dict["Sarvin"]);
            Console.WriteLine("The value of key 'Abtin' : " + dict["Abtin"]);
        }
    }
}
