using System;
using System.Collections;
using System.Collections.Generic;

namespace Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Hi");
            ht.Add(2, "Hi");
            ht.Add(3, "Hi");
            ht.Add(5, "Hi");
            Console.WriteLine(ht.Count);

            Hashtable ht1 = new Hashtable()
            {
                {1, 4 },
                {2, 5 },
                {3, 6 }
            };
            Console.WriteLine(ht1.Count);
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Mehedi");
            dict.Add(2, "Mehedi");
            dict.Add(3, "Mehedi");
            Hashtable ht3 = new Hashtable(dict);
            Console.WriteLine(ht1[1]);

            //accessing hashtable 
            foreach(DictionaryEntry item in ht1)
            {
                Console.WriteLine("Key: {0} Value: {1}", item.Key, item.Value);
            }
            Console.WriteLine("Accessing Hashtable by key");

            foreach(var key in ht1.Keys)
            {
                Console.WriteLine("Key: {0} Value: {1}", key, ht1[key]);

            }

        }
    }
}
