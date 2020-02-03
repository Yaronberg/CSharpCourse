using System;

namespace _2
{
    class Program
    {
        public delegate double MyDelegate(int a, int b);
        static void Main(string[] args)
        {
            MyDelegate myDelegate;

            int a = 5;
            int b = 10;
            string calc = Convert.ToString(Console.ReadLine());

            myDelegate = calc switch
            {
                "+" => (x, y) => (x + y),
                "-" => (x, y) => (x - y),
                "*" => (x, y) => (x * y),
                "/" => (x, y) => ( y != 0 ? ((double) x / y) : -1 ),
                _ => throw new ArgumentException(message: "invalid value"),
            };

            Console.WriteLine(myDelegate(a, b));

            Console.ReadKey();
        }


    }
}
