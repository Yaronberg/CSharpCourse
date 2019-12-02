using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string voice = Console.ReadLine();
            if (voice == "мяу")
            {
                Console.WriteLine("Покорми кота, быстро!");
            }
            else if (voice == "гав")
            {
                Console.WriteLine("Погуляй с собакой, быстро!");
            }
            else
            {
                Console.WriteLine("Что ты такое?!");
            }
            Console.ReadKey();
        }

    }
}
