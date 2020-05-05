using System;
using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;

namespace Value_Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var Person = (1, "Mehedi", 21017);
            Console.WriteLine(Person.Item1);
            //types of declaring a value tuple 
            (int id, string name, int batch) person1 = (2, "Hissj", 2017);
            var person2 = (Id: 3, name: "Hasan", batch: 1010198);
            ValueTasParameter((5, "Shimanto", 2017));

            
        }
        static void ValueTasParameter((int, string, int) person)
        {
            Console.WriteLine($"Id = {person.Item1}");
            Console.WriteLine($"Name = {person.Item2}");
            Console.WriteLine($"Batch = {person.Item3}");
        }

        static (int, string, int) ReturnValueTuple()
        {
            return (6, "Azad", 201189);
        }
    }
}
