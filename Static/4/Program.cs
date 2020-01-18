using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World!";

            string subString = s.MySubstring(0, 4);
            Console.WriteLine(subString);

            int indexof = s.MyIndexOf("W");
            Console.WriteLine(indexof);

            string repl = s.MyReplace("World", "User");
            Console.WriteLine(repl);

            Console.ReadLine();
        }
    }
    public static class SortExtension
    {
        public static string MySubstring(this string str, int startIndex, int length)
        {
            string substr = default;
            for (int i = startIndex; i < length; i++)
            {
                substr += str[i];
            }
            return substr;
        }


        public static int MyIndexOf(this string str, string findStr)
        {

            if (str.Length == 0 || str.Length < findStr.Length) // -1 
            {
                return -1;
            }

            if (findStr.Length == 0) // 0
            {
                return 0;
            }

            for (int i = 0; i <= str.Length - findStr.Length; i++)
            {
                if (str.Substring(i, findStr.Length) == findStr)
                {
                    return i;
                }
            }

            return -1;
        }

        public static string MyReplace(this string str, string oldValue, string newValue)
        {
            string toRet = default;
            int strIndexOfOld;

            while ((strIndexOfOld = str.MyIndexOf(oldValue)) != -1)
            {
                string cutBefore = str.MySubstring(0, strIndexOfOld);
                toRet += cutBefore + newValue;

                int cutAt = cutBefore.Length + oldValue.Length;
                str = str.Substring(cutAt, str.Length - cutAt);
            }

            return toRet + str;
        }
    }
    
}
