using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сделайте ставку \nЕсли выпадают значения от 1 до 5, то вы " +
                  "проиграли. Если выпадают значения от 6 до 8, то получаете " + 
                  "свою ставку обратно. Если выпало от 9 до 11, вы получаете " + 
                  "двойную ставку, а если выпало 12 - ставку умноженную на 10.");

            int bet = Int32.Parse(Console.ReadLine());
            Random rnd = new Random();
            int cube = rnd.Next(1, 13);

            Console.WriteLine($"Выпало {cube}");

            if (cube >= 1 & cube <= 5)
            {
                Console.WriteLine($"Вы проиграли {bet}"); ;
            }
            else if (cube >= 6 & cube <= 8)
            {
                Console.WriteLine($"Вы отыграли свою ставку в {bet}");
            }
            else if (cube >= 9 & cube <= 11)
            {
                Console.WriteLine($"Вы выиграли {bet * 2}");
            }
            else
            {
                Console.WriteLine($"Вам круто повезло, Вы выиграли {bet * 10}");
            }

            Console.ReadKey();
        }
    }
}
