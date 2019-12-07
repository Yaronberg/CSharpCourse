using System;
using System.Collections.Generic;
using System.Text;

namespace _6
{
    class Converter
    {
        public double USD { set; get; }
        public double EUR { get; set; }
        public double RUB { get; set; }
        public Converter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }
        public void ConvertTo ()
        {
            Console.WriteLine("Введите сумму которую хотите конвертировать в другие валюты");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите валюту которую хотите конвертировать в гривны (USD, EUR, RUB) или наоброт");
            switch (Console.ReadLine().ToUpper())
            {
                case "USD":
                    Console.WriteLine($"UAH = {sum * USD}");
                    break;
                case "EUR":
                    Console.WriteLine($"UAH = {sum * EUR}");
                    break;
                case "RUB":
                    Console.WriteLine($"UAH = {sum * RUB}");
                    break;
                case "UAH":
                    Console.WriteLine($"{sum}UAH = {sum / USD} USD");
                    Console.WriteLine($"{sum}UAH = {sum / EUR} EUR");
                    Console.WriteLine($"{sum}UAH = {sum / RUB} RUB");
                    break;
                default:
                    Console.WriteLine("Вы ввели некорректное значение! Попробуйте еще");
                    break;
            }
        }
    }
}
