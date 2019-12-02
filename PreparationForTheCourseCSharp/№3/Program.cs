using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int var = Convert.ToInt32(Console.ReadLine());
            if (var == 1 || var == 2 || var == 12)
            {
                Console.WriteLine("Зима");
            }
            else if (var == 3 || var == 4 || var == 5)
            {
                Console.WriteLine("Весна");
            }
            else if (var == 6 || var == 7 || var == 8)
            {
                Console.WriteLine("Лето");
            }
            else if (var == 9 || var == 10 || var == 11)
            {
                Console.WriteLine("Осень");
            }
            else
            {
                Console.WriteLine("На этой планете такого месяца нет");
            }

            Console.ReadKey();
        }
    }
}
