using System;

namespace MultiDelegate
{
    public delegate void myDelegate(string msg);
    class Program
    { 
        static void Main(string[] args)
        {
            myDelegate del1 = ClassA.MethodA;
            myDelegate del2 = ClassB.MethodB;
            Console.WriteLine("Adding both");
            myDelegate del = del1 + del2;
            del("Hello World");
            Console.WriteLine("Deleting del2");
            del = del1 - del2;
            del("Hello World");
            myDelegate del3 = (string msg) => Console.WriteLine("Hi");
            Console.WriteLine("Adding del3");
            del += del3;
            del("Hello World");
        }
    }
}
