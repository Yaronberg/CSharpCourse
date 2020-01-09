using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день рождения в формате: дд/мм");
            string a = Console.ReadLine() + "/" +  DateTime.Now.Year;
            DateTime birth = DateTime.Parse(a);

            int days;
            if (birth >= DateTime.Today)
            {
                days = (birth - DateTime.Today).Days;
            }
            else
            {
                days = (birth.AddYears(1) - DateTime.Today).Days;
            }
            Console.WriteLine(days + " дней осталось до вашего дня рождения");

            Console.ReadLine();
        }

    }
}
