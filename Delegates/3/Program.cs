using System;

namespace _3
{
    class Program
    {
        public delegate int randIntDelegate();
        public delegate double AvgMyDelegate(randIntDelegate[] ArrayDelegates);

        static Random rand = new Random();
        //static int Random() => rand.Next(1, 50); 
        static int Random() 
        {
            int r = rand.Next(1, 5);
            Console.WriteLine(r);
            return r;
        }
        static void Main(string[] args)
        {
            int a = 5;

            var ArrDelegates = new randIntDelegate[a];

            for (int i = 0; i < ArrDelegates.Length; i++)
            {
                ArrDelegates[i] = new randIntDelegate(Random);
            }

            AvgMyDelegate avgdel = delegate(randIntDelegate[] ArrDel) 
            {
                double avg = 0;
                foreach (var del in ArrDel)
                {
                    avg += del();
                }
                return avg / ArrDel.Length;
            };

            Console.WriteLine(avgdel(ArrDelegates));
            Console.ReadLine();
        }      
    }
}
