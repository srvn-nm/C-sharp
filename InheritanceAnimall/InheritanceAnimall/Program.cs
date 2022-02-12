using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eagle eagle = new Eagle();
            Tiger tiger = new Tiger();
            eagle.name = "Chip";
            eagle.weight = 20;
            eagle.FlyHeight = 100;
            eagle.age = 10;
            eagle.Eat();
            eagle.Sleep();
            eagle.Fly();
            tiger.name = "Rajah";
            tiger.weight = 200;
            tiger.age = 15;
            tiger.Eat();
            tiger.Sleep();
            tiger.Hunt();
        }
    }
}
