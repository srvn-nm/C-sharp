using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOrientedPractice
{
    class Person
    {
        Random rnd = new Random();
        private int Id;
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Person()
        {
            Id = rnd.Next(1000);
        }
        public void Introduce()
        {
            Console.WriteLine("Hi!\nMy name is "+Name+" "+LastName+" and I am "+Age+" year's old.\nYou can find my identity with my random ID code : "+Id+".\nGoodbye ^-^");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Sarvin";
            person.LastName = "Nami";
            person.Age = 20;
            person.Introduce();
        }
    }
}
