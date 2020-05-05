using System;

namespace TupleBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Tuple.Create(1, "Mehedi", 2016);
            DisplayTuple(s);
            Console.WriteLine(ReturnTuple());
            //nested tuple
            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));

            Console.WriteLine(numbers.Item7);
            Console.WriteLine(numbers.Rest);
            //Rest will only be applicable when tuple elements is 8
            var anything = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);
            Console.WriteLine(anything.Rest);
        }
        //tuple as parameter
        static void DisplayTuple(Tuple<int, string, int> person)
        {
            Console.WriteLine($"ID = {person.Item1}");
            Console.WriteLine($"Name = {person.Item2}");
            Console.WriteLine($"Batch = {person.Item3}");

        }
        //tuple as return type
        static Tuple<int, string, int> ReturnTuple() {
            return Tuple.Create(2, "Hi", 2016);
        }

    }
}
