using System;
using System.Collections.Generic;
using System.Text;

namespace _2.Data.Pupils
{
    class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name)
        {
        }
        public override void Study()
        {
            Console.WriteLine($"{name} study 2/5");
        }
        public override void Read()
        {
            Console.WriteLine($"{name} Read 3/5");
        }
        public override void Write()
        {
            Console.WriteLine($"{name} Write 3/5");
        }
        public override void Relax()
        {
            Console.WriteLine($"{name} Relax 5/5");
        }
    }

}
