using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Ivan", "Shitman");

            employee.Salary("middle", 3);

            Console.ReadLine();
        }
    }
}
