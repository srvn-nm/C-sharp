using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCarClass
{
    internal class Peraid : Car
    {
        public override void move()
        {
            Console.WriteLine("Peraid is trying to move!");
        }
    }
}
