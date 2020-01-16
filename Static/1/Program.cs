using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Calc.Sum(2, 4);

            Console.WriteLine(Calc.history);

            int b = Calc.Multiply(121, 2);

            Console.WriteLine(Calc.history);


            Console.ReadLine();
        }
    }

    static class Calc
    {
        public static string history;
        public static int Sum(int a, int b) 
        {
            int c = a + b;
            history += $"{a} + {b} = {c}\n";
            return c;
        }
        public static int Subtract(int a, int b)
        {
            int c = a - b;
            history += $"{a} - {b} = {c}\n";
            return c;
        }
        public static int Multiply(int a, int b)
        {
            int c = a * b;
            history += $"{a} * {b} = {c}\n";
            return c; ;
        }
        public static int Divide(int a, int b)
        {
            int c = a / b;
            history += $"{a} / {b} = {c}\n";
            return c;
        }
    }
}
