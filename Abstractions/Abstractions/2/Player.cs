using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    class Player : IPlayable, IRecordable
    {
        bool playable = false;
        bool recordable = false;
        public void Play()
        {
            playable = true;
            Console.WriteLine("Проигрываение...");
        }
        public void Record()
        {
            recordable = true;
            Console.WriteLine("Идет запись...");
        }

        public void Pause()
        {
            if (playable)
            {
                Console.WriteLine("Проигрывание приостановлено.");
            }
            else if (recordable)
            {
                Console.WriteLine("Запись приостановлена.");
            }
            else
            {
                Console.WriteLine("Ошибка, в данный момент ничего не проигрываниется/записывается");
            }
        }

        public void Stop(string action)
        {
            if (action == "playing")
            {
                playable = false;
                Console.WriteLine("Проигрывание остановлено.");
            }
            else if (action == "recording")
            {
                Console.WriteLine("Запись приостановлена.");
            }
            else
            {
                Console.WriteLine("Ошибка, в данный момент ничего не проигрываниется/записывается");
            }
        }

    }
}
