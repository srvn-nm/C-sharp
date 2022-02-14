using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAndStack
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
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************\nStack First Pop:");
            int poped = stack.Pop();
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
