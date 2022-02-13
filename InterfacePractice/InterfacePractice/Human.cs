using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    internal class Human : Moving
    {
        public void moving()
        {
            Console.WriteLine("Human is walking to the moon. ^-^");
        }
    }
}
