using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate;

            int a = 5;
            int b = 10;
            string calc = Convert.ToString(Console.ReadLine());

            //MyDelegate Add = (a, b) => (a + b);

            myDelegate = calc switch
            {
                "+" => (x, y) => (x + y),
                "-" => (x, y) => (x - y),
                "*" => (x, y) => (x * y),
                "/" => (x, y) => ( y != 0 ? ((double) x / y) : -1 ),
                _ => throw new ArgumentException(message: "invalid enum value"),
            };

            Console.WriteLine(myDelegate(a, b));

            Console.ReadKey();
        }

        public delegate double MyDelegate(int a, int b);
    }
}
