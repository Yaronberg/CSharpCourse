using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList<int>();

            myList.Add(100);
            myList.Add(200);

            var myListArr = myList.GetArray();

            foreach (var item in myListArr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
    static class MyListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] newArr = new T[list.Count];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = list[i];
            }
            return newArr;
        }
    }
    class MyList<T> : IMyList<T>
    {
        T[] data;

        public MyList()
        {
            data = new T[0];
        }

        public int Count
        {
            get { return data.Length; }
        }

        public T this[int index]
        {
            get { return data[index]; }
        }
        public void Add(T item)
        {
            T[] newData = new T[data.Length + 1];
            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = data[i];
            }
            newData[data.Length] = item;
            data = newData;
        }
    }
}
