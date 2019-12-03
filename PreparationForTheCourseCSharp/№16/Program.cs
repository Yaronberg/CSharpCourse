using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"Введите пароль:");
                if (Console.ReadLine() == "root")
                    break;
                else
                    Console.WriteLine("Введен неверный пароль");
            }

            Console.ReadLine();
        }
    }
}
