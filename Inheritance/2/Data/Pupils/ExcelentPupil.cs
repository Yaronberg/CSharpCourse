using System;
using System.Collections.Generic;
using System.Text;

namespace _2.Data.Pupils
{
    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name) : base(name)
        {
        }
        public override void Study()
        {
            Console.WriteLine($"{name} study 5/5");
        }
        public override void Read()
        {
            Console.WriteLine($"{name} Read 5/5");
        }
        public override void Write()
        {
            Console.WriteLine($"{name} Write 5/5");
        }
        public override void Relax()
        {
            Console.WriteLine($"{name} Relax 2/5");
        }
    }

}
