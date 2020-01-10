using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine("Введите цвет, где 1 = Белый, 2 = Синий, 3 = Красный, 4 = Зеленый ");
            int num = Convert.ToInt32(Console.ReadLine());

            Painter.Print(str, num);

            Console.ReadLine();
        }
    }
    enum Color
    {
        White = 1,
        Blue,
        Red,
        Green
    }
    static class Painter
    {

        public static void Print (string stroka, int color)
        {

            switch (color)
            {
                case (int)Color.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case (int)Color.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case (int)Color.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case (int)Color.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    break;
            }
            Console.WriteLine(stroka);

            Console.ResetColor();
        }
    }
}
