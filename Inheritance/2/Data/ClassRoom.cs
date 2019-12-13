using System;
using System.Collections.Generic;
using System.Text;

namespace _2.Data
{
    class ClassRoom
    {
        Pupil[] pupils;
        public ClassRoom(params Pupil[] pupils)
        {
            this.pupils = pupils;
        }
        public void Show()
        {
            foreach (var item in pupils)
            {
                item.Study();
                item.Read();
                item.Write();
                item.Relax();
                Console.WriteLine();
            }
        }
    }

}
