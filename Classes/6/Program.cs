using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(23.70, 26.0, 0.35);

            converter.ConvertTo();

            Console.ReadLine();
        }
    }
}
