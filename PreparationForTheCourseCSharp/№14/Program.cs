using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int rndom = rnd.Next(1, 100);
                Console.WriteLine($"Число {i + 1}:" + rndom);
                a += rndom;
            }
            Console.WriteLine("Cреднее арифметическое " + a / 5);

            Console.ReadLine();
        }
    }
}
