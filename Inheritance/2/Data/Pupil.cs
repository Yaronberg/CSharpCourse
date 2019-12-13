using System;
using System.Collections.Generic;
using System.Text;

namespace _2.Data
{
    abstract class Pupil
    {
        public string name { get; }
        public Pupil(string name)
        {
            this.name = name;
        }
        public virtual void Study() { }
        public virtual void Read() { }
        public virtual void Write() { }
        public virtual void Relax() { }
    }

}
