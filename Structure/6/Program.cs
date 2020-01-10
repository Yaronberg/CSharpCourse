using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Accauntant accauntant = new Accauntant();

            if ( accauntant.AskForBonus(Post.Developer, 180))
            {
                Console.WriteLine("Вы заслужили премию!");
            }
            else
            {
                Console.WriteLine("Надо больше работать!");
            }
        }
    }
    enum Post
    {
        Developer = 160,
        Manager = 150,
        Cleaner = 30,
        TechSupport = 80
    }
    class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if ( (int)worker < hours)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
