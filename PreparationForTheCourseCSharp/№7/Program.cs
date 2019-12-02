using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввидете натуральное число");
            int a = Int32.Parse(Console.ReadLine());
            bool result = true;
            if (a > 1)
            {
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        result = false;
                        Console.WriteLine("Число не простое");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не натуральное число");
            }

            if (result)
            {
                Console.WriteLine("Число простое");
            }

            Console.ReadLine();
        }
    }
}
