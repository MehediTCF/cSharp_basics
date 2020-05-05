using System;
using System.Collections;

namespace Stack_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("Hi");
            stack.Push(1);
            stack.Push(3);
            stack.Push("Hoo");
            stack.Push(7);
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            //Queue
            Console.WriteLine("Queue");
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Console.WriteLine(queue.Dequeue());

            foreach(var it in queue)
            {
                Console.WriteLine(it);
            }
            //or



        }
    }
}
