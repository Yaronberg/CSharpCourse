using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Ivan", "Apple");
            invoice.AddOrder("iPhone 11", 3);
            invoice.Order();

            Console.ReadLine();
        }
    }
}
