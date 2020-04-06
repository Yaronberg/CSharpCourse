using System;
using System.Diagnostics;
using System.Threading;

namespace sync
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(3000);
            Console.WriteLine("Let's get the fibonacci numbers sync");

            var watch = new Stopwatch();

            int fib1 = 38;
            int fib2 = 39;
            int fib3 = 40;

            int count = 10;
            for (int i = 0; i < count; i++)
            {
                watch.Start();

                FibonachiSync(fib1, fib2, fib3);

                watch.Stop();

                Console.WriteLine();
            }

            var avg = ((watch.ElapsedMilliseconds / 100.0) / count).ToString() + " ms";
            Console.WriteLine("Sync: " + avg);

            Console.ReadLine();
        }

        static void FibonachiSync(int fib1, int fib2, int fib3)
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
