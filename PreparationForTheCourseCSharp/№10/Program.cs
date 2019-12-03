using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine($"{a} * {i} = {a * i}");
            }

            Console.WriteLine("\nВведите число, чтобы узнать количиество разрядов в нем");
            Console.WriteLine(Console.ReadLine().Length);
            Console.ReadLine();
        }
    }
}
