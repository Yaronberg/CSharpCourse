using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    interface IPlayable
    {
        public void Play();
        public void Pause();
        public void Stop(string action);

    }
}
