using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    internal class Plane : Moving
    {
        public void moving()
        {
            Console.WriteLine("The plane is trying to reach the moon!");
        }
    }
}
