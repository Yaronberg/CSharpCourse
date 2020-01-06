using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class TXTHandler : AbstractHandler
    {
        const string format = ".txt";
        public override void Open(string path, string name) => Console.WriteLine("Open " + name + format + " in " + path);
        public override void Create(string path, string name) => Console.WriteLine("Created " + name + format + " in " + path); 
        public override void Change(string path, string name) => Console.WriteLine("Changed "+ name + format + " in " + path);
        public override void Save(string path, string name) => Console.WriteLine("Saved "+ name + format + " in " + path);
    }
}
