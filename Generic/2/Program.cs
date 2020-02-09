using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<double> myList = new MyList<double>();

            myList.Add(1.2);
            myList.Add(3.4);

            Console.WriteLine(myList.Count);
            Console.WriteLine(myList[2]);

            Console.ReadLine();
        }
    }
    class MyList<T>
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
            get { return data[index-1]; }
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
