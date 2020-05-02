using System;

namespace MultiDelegateReturningValue
{
    public delegate int myDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            myDelegate del1 = ClassA.MethodA;
            myDelegate del2 = ClassB.MethodB;
            // last one to add will be called
            myDelegate del = del2 + del1;
            //last assigning target value will be called
            Console.WriteLine(del());
        }
    }
    class ClassA { 
        public static int MethodA()
        {
            return 100;
        }
    }

    class ClassB {
        public static int MethodB()
        {
            return 200;
        }
    }


}
