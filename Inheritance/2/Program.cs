using _2.Data;
using _2.Data.Pupils;
using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil Egor = new ExcelentPupil("Egor");
            Pupil Ivan = new GoodPupil("Ivan");
            Pupil Alex = new BadPupil("Alex");
            Pupil Vika = new BadPupil("Vika");

            ClassRoom classRoom = new ClassRoom(Alex, Vika, Ivan);
            classRoom.Show();

            Console.ReadKey();
        }
    }
}
