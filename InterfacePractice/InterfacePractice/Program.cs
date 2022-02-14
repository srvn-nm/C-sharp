using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.moving();
            Plane plane = new Plane();
            plane.moving();
        }
    }
}
