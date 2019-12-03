using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rand = rnd.Next(1, 147);

            while (true)
            {
                Console.WriteLine("Введите число");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a > rand)
                    Console.WriteLine("Меньше");
                if (a < rand)
                    Console.WriteLine("Больше");
                if (a == rand)
                {
                    Console.WriteLine("Вы угадали!");
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
