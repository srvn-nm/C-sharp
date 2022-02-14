using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndqueuePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Console.WriteLine("**************\nQueue Count:");
            Console.WriteLine(queue.Count);
            Console.WriteLine("**************\nQueue First Declaration:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************\nQueue After First Dequeue:");
            int dequeued = queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************\nQueue After Second Dequeue:");
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************");
            Console.WriteLine("**************\nStack First Declaration:");
            Stack<string> stack = new Stack<string>();
            stack.Push("Sarvin");
            stack.Push("Nami");
            stack.Push("Abtin");
            stack.Push("Zandi");
            stack.Push("Nazanin");
            stack.Push("Mozhgan");
            stack.Push("Bahram");
            stack.Push("Timsar");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************\nStack First Pop:");
            string poped = stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************\nStack Second Pop:");
            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************");
        }
    }
}
