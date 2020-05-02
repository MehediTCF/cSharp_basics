using System;

namespace StaticConstructor_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "Hasan", 16);
            Employee e2 = new Employee(2, "Mehedi", 16);
            e1.CallBill();
        }
    }

    struct Employee
    {
        public int Id;
        public string Name;
        public int Batch;
        static Employee()
        {
            Console.WriteLine("Static constructor called");

        }
        public Employee(int id, string name, int batch)
        {
            Id = id;
            Name = name;
            Batch = batch;
        }
        public void CallBill()
        {
            Console.WriteLine("Called Bill");
        }

    }
}
