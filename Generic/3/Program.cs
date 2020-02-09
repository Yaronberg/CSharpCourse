using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {

            var dictionary = new MyDictionary<string, double>(5);

            for (int i = 0; i < dictionary.Lenght - 1; i++)
            {
                dictionary.Add(i, "Рост", 150+i );
            }

            for (int i = 0; i < dictionary.Lenght - 1; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.WriteLine(dictionary[1]);

            Console.WriteLine(dictionary.Lenght);

            Console.ReadKey();
        }

    }
    class MyDictionary<TKey, TValue>
    {
        private TKey[] key;
        private TValue[] value;
        private readonly int lenght;

        public int Lenght
        {
            get
            {
                return lenght;
            }
        }

        public MyDictionary(int size)
        {
            key = new TKey[size - 1];
            value = new TValue[size - 1];
            lenght = size;
        }

        public (TKey key, TValue value) this[int i]
        {
            get
            {
                return (key[i], value[i]);
            }
        }

        public void Add(int i, TKey k, TValue v)
        {
            key[i] = k;
            value[i] = v;
        }

    }
}
