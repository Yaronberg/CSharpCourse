using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = MyClass<int>.FactoryMethod();
            Console.WriteLine(myClass);

            var myClass1 = MyClass<char>.FactoryMethod();
            Console.WriteLine(myClass1);

            Console.ReadLine();
        }
    }
    class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }
}
