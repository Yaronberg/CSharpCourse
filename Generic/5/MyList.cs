using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
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
        public void Clear()
        {
            data = new T[0];
        }

    }
}
