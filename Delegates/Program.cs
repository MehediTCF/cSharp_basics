using System;

namespace Delegates
{
    //Declaring a delegate
    public delegate void myDelegate(string msg);
    class Program
    {
        static void Main(string[] args)
        {
            //set target method
            myDelegate del = ClassA.MethodA;
            //invoke delegate
            del("Hello World");

            del = ClassB.MethodB;
            //by passing delegate type parameter
            delegateMethod(del);

            //function with delegate type parameter
            static void delegateMethod(myDelegate del)
            {
                del("Hi There");
            }
            


        }
    }


}
