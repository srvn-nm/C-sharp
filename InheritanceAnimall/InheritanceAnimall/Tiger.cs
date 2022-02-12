using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimall
{
    internal class Tiger:Animal
    {
        public int HuntSpeed { get; set; }
        public void Hunt()
        {
            Console.WriteLine(name + " is hunting with " +HuntSpeed + " speed.");
        }
    }
}
