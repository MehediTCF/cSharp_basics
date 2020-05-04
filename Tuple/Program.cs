using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = Tuple.Create(1, "Steve", "Jobs");
            Console.WriteLine(person.Item1); // returns 1
            Console.WriteLine(person.Item2); // returns "Steve"
            Console.WriteLine(person.Item3); // returns "Jobs"
        }
    }
}
