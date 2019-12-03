using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Введите число {i+1}:");
                a += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("среднее арифметическое " + a / 5);

            Console.ReadLine();
        }
    }
}
