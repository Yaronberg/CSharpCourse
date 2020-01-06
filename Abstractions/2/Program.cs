using System;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            bool endApp = false;
            Console.WriteLine("Пример ввода комманд: \n play \n record \n " +
                "stop recording \n stop playing\n");

            while (!endApp)
            {
                var line = Console.ReadLine().Split(" ");

                switch (line.First().ToUpper())
                {
                    case "PLAY":
                        player.Play();
                        break;
                    case "STOP":
                        player.Stop(line[1]);
                        break;
                    case "RECORD":
                        player.Record();
                        break;
                    case "PAUSE":
                        player.Pause();
                        break;
                    case "EXIT":
                        endApp = true;
                        break;
                    default:
                        Empty();
                        break;
                }
            }
        }
        static void Empty()
        {
            Console.WriteLine("Неправильный ввод");
        }
    }
}
