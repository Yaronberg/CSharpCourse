using System;
using System.Collections.Generic;
using System.Text;

namespace _2.Data.Pupils
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name)
        {
        }
        public override void Study()
        {
            Console.WriteLine($"{name} study 4/5");
        }
        public override void Read()
        {
            Console.WriteLine($"{name} Read 4/5");
        }
        public override void Write()
        {
            Console.WriteLine($"{name} Write 3/5");
        }
        public override void Relax()
        {
            Console.WriteLine($"{name} Relax 4/5");
        }

    }
}
