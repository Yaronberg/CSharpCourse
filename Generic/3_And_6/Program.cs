using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();

            dictionary.Add(0, "Ноль");
            dictionary.Add(1, "Целковый");
            dictionary.Add(2, "чекушка");

            Console.WriteLine(dictionary.Count + " " + dictionary[2]);

            Console.ReadKey();
        }

    }
    class MyDictionary<TKey, TValue> : IMyDictionary<TKey, TValue>
    {
        private TKey[] key;
        private TValue[] value;

        public int Count
        {
            get
            {
                return key.Length;
            }
        }

        public MyDictionary()
        {
            key = new TKey[0];
            value = new TValue[0];
        }

        public TValue this[TKey index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i].Equals(index))
                    {
                        return value[i];
                    }
                }
                throw new System.Collections.Generic.KeyNotFoundException();
            }
        }

        public void Add(TKey k, TValue v)
        {
            TKey[] newKey = new TKey[key.Length + 1];
            TValue[] newValue = new TValue[value.Length + 1];

            for (int i = 0; i < key.Length - 1; i++)
            {
                newKey[i] = key[i];
                newValue[i] = value[i];
            }

            newKey[newKey.Length - 1] = k;
            newValue[newValue.Length - 1] = v;

            key = newKey;
            value = newValue;
        }

    }
}
