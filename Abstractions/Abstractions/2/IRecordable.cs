using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    interface IRecordable
    {
        public void Record();
        public void Pause();
        public void Stop(string action);

    }
}
