using System;
using System.Diagnostics;
using System.Threading;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(3000);
            Console.WriteLine("Let's get the fibonacci numbers async");

            var watch = new Stopwatch();

            int fib1 = 32;
            int fib2 = 33;
            int fib3 = 34;

            int count = 10;
            for (int i = 0; i < count; i++)
            {
                watch.Start();

                FibonachiAsync2(fib1, fib2, fib3);

                watch.Stop();

                Console.WriteLine();
            }

            var avg = ((watch.ElapsedMilliseconds / 100.0) / count).ToString() + " ms";
            Console.WriteLine(avg);

            Console.ReadLine();
        }

        static void FibonachiAsync2(int fib1, int fib2, int fib3)
        {
            Console.WriteLine(Fibonachi(fib2));
            Console.WriteLine(Fibonachi(fib3));
            Console.WriteLine(Fibonachi(fib1));
        }

        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
    }
}
