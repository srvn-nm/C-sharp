using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCarClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Samand();
            Car car2 = new Peraid();
            car1.move();
            car2.move();
        }
    }
}
