using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimall
{
    internal class Eagle: Animal
    {
        public int FlyHeight { get; set; }
        public void Fly()
        {
            Console.WriteLine(name + "is flying at" +FlyHeight);
        }
    }
}
