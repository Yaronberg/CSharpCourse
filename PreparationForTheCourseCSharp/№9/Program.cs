using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            double EUR_USD = 1.085;
            double USD_EUR = 1 / EUR_USD; 
            double UAH_USD = 24.0;
            double UAH_EUR = UAH_USD * EUR_USD;

            do
            {
                Console.WriteLine("Выберете валюту, 1 - USD, 2 - EUR, 3 - UAH, 0 - Заново, Любой другой символ - Выход");
                var select = Console.ReadLine();

                if (select == "0" )
                    continue;
                else if (select.GetType() == typeof(string))
                    break;

                Console.WriteLine("Введите сумму");
                int sum = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case "1":
                            Console.WriteLine($"UAH = {sum * UAH_USD}\nEUR = {sum * USD_EUR}\n");
                            break;
                    case "2":
                            Console.WriteLine($"UAH = {sum * UAH_EUR}\nUSD = {sum * EUR_USD}\n");
                            break;
                    case "3":
                            Console.WriteLine($"UAH = {sum / UAH_USD}\nEUR = {sum / UAH_EUR}\n");
                            break;
                    default:
                        Console.WriteLine("Вы ввели некорректное значение! Попробуйте еще");
                        break;
                }
            } while (true) ;
        }
    }
}
