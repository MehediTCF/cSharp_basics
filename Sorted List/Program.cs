using System;
using System.Collections;

namespace Sorted_List
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add(1, "One");
            sl.Add(2, "Two");
            sl.Add(3, "Three");
            sl.Add(4, "Four");
            //it will give value by giving key
            Console.WriteLine(sl[1]);
            for(int i=0; i < sl.Count; i++)
            {
                Console.WriteLine("Key: {0} Value: {1}", sl.GetKey(i), sl.GetByIndex(i));
            }
            sl.Remove(3);
            sl.RemoveAt(0);
            //another system
            foreach(DictionaryEntry kvp in sl)
            {
                Console.WriteLine("{0} {1}", kvp.Key, kvp.Value);

            }
            Console.WriteLine(sl.Contains(7));
            Console.WriteLine(sl.ContainsValue("Four"));
        }
    }
}
