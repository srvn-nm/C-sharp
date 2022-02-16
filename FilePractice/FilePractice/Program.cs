using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"../../../myFile.txt");
            Console.WriteLine("Reading the whole file using this method : \n"+sr.ReadToEnd());
        }
    }
}
