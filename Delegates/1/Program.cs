using System;

namespace _1
{
    class Program
    {
        public delegate double MyDelegate(int a, int b, int c);

        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = 15;

            MyDelegate myDelegate = (a, b, c) => (a + b + c) / 3;
            Console.WriteLine(myDelegate(a,b,c));

            Console.ReadLine();
        }
    }
}
