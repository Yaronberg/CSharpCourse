using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количестко километров которое вы проехали");
            int km = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Сколько минут простоя у вас было?");
            int min = Int32.Parse(Console.ReadLine());
            int result;

            if (km <= 5)
            {
                result = 20 + min;
            }
            else
            {
                result = (km - 5) * 3 + 20 + min;
            }

            Console.WriteLine($"Итого к оплате: {result}");

            Console.ReadLine();
        }
    }
}
