using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 13, 1, 55, 3 };

            arr.Sort();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            arr.Sort(false);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
    public static class SortExtension
    {
        public static int[] Sort(this int[] arr, bool direction = true)
        {
            if (direction)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    int temp;
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[i] < arr[j])
                        {
                            temp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = temp;
                        }
                    }
                }
            } 
            else
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    int temp;
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            temp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = temp;
                        }
                    }
                }
            }
            return arr;
        }
    }
    
}
