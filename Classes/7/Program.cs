using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Ivan", "Switchman");

            employee.Salary("middle", 3); // должность, стаж в годах

            Console.ReadLine();
        }
    }
}
