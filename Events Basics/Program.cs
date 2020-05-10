using System;

namespace Events_Basics
{

    class Program
    {
        static void Main(string[] args)
        {
            ProcessLogic bl = new ProcessLogic();
            bl.ProcessCompleted += bl_Process;
            bl.StartProcess();
        }

        public static void bl_Process()
        {
            Console.WriteLine("Process Completed!");
        }
    }
}
