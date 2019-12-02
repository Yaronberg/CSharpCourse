using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForTheCourseCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int integer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int integer2 = Convert.ToInt32(Console.ReadLine());
            if (integer1 == integer2)
            {
                Console.WriteLine("Числа равны");
            }
            else if (integer1 > integer2)
            {
                Console.WriteLine("Большее число: " + integer1);
            }
            else
            {
                Console.WriteLine("Большее число: " + integer2);
            }
            Console.ReadKey();
        }
    }
}
