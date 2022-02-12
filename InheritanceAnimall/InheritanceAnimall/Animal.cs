using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimall
{
    internal class Animal
    {
        public string name { get; set; }
        public int age { get; set; }
        public int weight { get; set; }
        public void Eat()
        {
            Console.WriteLine(name+" is eating!");
        }
        public void Sleep()
        {
            Console.WriteLine(name+" is sleeping!");
        }
    }
}
