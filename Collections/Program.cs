using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arraylist
            ArrayList myList = new ArrayList();
            myList.Add(1);
            myList.Add("Hi");
            ArrayList myList2 = new ArrayList();
            myList2.Add("Hello");
            myList.AddRange(myList2);
            myList.Insert(1, 4);
            ArrayList myList3 = new ArrayList() { 10, 20, 30 };
            myList.InsertRange(3, myList3);
            for(int i=0; i<myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            Console.WriteLine(myList.Contains(10));
        }
    }
}
