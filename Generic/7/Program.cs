using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList arr = new MyArrayList();

            for (int i = 1; i <= 9; i++)
            {
                arr.Add(i);
            }

            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i]);
            }

            arr.Reverse();
            Console.WriteLine();

            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i]);
            }

            Console.ReadLine();
        }
    }


    class MyArrayList
    {
        private object[] array;

        public MyArrayList()
        {
            array = new object[0];
        }

        public int Add(object item)
        {
            object[] newArray = new object[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[array.Length] = item;
            array = newArray;
            return array.Length - 1;
        }

        public object this[int index]
        {
            get
            {
                return array[index];
            }
        }

        public int IndexOf(object value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Reverse()
        {
            object[] tempArr = new object[array.Length];
            for (int i = array.Length - 1, j = 0 ; j < array.Length; i--, j++)
            {
                tempArr[j] = array[i];
            }
            array = tempArr;
        }
        public int Count
        {
            get 
            {
                return array.Length;
            }
        }

        public void Clear()
        {
            array = new object[0];
        }

        public bool Contains(object item) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
