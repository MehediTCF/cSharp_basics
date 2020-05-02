using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //by creating instance by 'new', it calls default constructor
            Employee e = new Employee();
            Console.WriteLine(e.Id);
            //now it doesnt call default constructor
            Employee em;
            em.Id = 1;
            Console.WriteLine(em.Id);
        }
    }
    struct Employee {
        public int Id;
        public string name;
        public int batch;
        //struct cannot have parameterless constructor, except static constructor
        public Employee(int idd, string nme, int btch)
        {
            Id = idd;
            name = nme;
            batch = btch;

        }
    }

}
