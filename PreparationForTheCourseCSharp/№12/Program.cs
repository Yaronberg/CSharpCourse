using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Просмотр точных квадратов натуральных чисел до числа :");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i * i < num)
            {
                Console.WriteLine(i * i++);
            }

            Console.ReadLine();
        }
    }
}
