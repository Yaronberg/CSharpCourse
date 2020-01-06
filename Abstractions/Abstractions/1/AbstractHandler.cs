using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    abstract class AbstractHandler 
    {
        public abstract void Open(string path, string name);
        public abstract void Create(string path, string name);
        public abstract void Change(string path, string name);
        public abstract void Save(string path, string name);
    }
}
