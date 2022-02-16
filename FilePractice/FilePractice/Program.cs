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
            StreamReader sr = new StreamReader(@"../../../TestFile.txt");
            //Console.WriteLine("Reading the whole file using this method : \n"+sr.ReadToEnd());
            //Console.WriteLine("**************************************");
            //Console.WriteLine("Reading one line of the file using this method : \n" + sr.ReadLine());
            List<String> list = new List<String>();
            while (!sr.EndOfStream)
            {
                list.Add(sr.ReadLine());
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("The "+(i+1)+" line of the file : "+list[i]);
                Console.WriteLine("**************************************");
            }
            StreamWriter sw = new StreamWriter(@"../../../NewFile.txt");
            //sw.WriteLine("This file has been created by the streamwriter");
            foreach(String s in list)
            {
                sw.WriteLine(s);
            }
            sw.Close();
            StreamReader sr2 = new StreamReader(@"../../../NewFile.txt");
            Console.WriteLine("Reading the whole file using this method : \n" + sr2.ReadToEnd());
            sr.Close();
            sr2.Close();
        }
    }
}
