using System;

namespace Delegates
{
    public delegate void myDelegate(string msg);
    class Program
    {
        static void Main(string[] args)
        {
            myDelegate del = ClassA.MethodA;
            del("Hello World");

            del = ClassB.MethodB;
            delegateMethod(del);

            static void delegateMethod(myDelegate del)
            {
                del("Hi There");
            }
            


        }
    }


}
