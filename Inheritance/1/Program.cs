using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new BlueColor();
            printer.Print("Синий цвет");
            printer = new Printer();
            ((Printer)printer).Print("Базовый цвет");

            Console.WriteLine();
        }
    }
}
