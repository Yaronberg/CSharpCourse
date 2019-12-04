using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();

            Console.WriteLine("Введите страну");
            address.Country = Console.ReadLine();
            Console.WriteLine("Введите город");
            address.City = Console.ReadLine();
            Console.WriteLine("Введите название улицы");
            address.Street = Console.ReadLine();
            Console.WriteLine("Введите номер дома");
            address.House = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер квартиры");
            address.Apartment = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите индекс");
            address.Index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Вы ввели такие данные:\n" +
                            $"Страна - {address.Country}\n" +
                            $"Город - {address.City}\n" +
                            $"Улица - {address.Street}\n" +
                            $"Дом - {address.House}\n" +
                            $"Квартира - {address.Apartment}\n" +
                            $"Индекс - {address.Index}\n");


            Console.ReadLine();
        }
    }
}
