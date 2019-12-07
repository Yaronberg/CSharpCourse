using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Data
{
    class Point
    {
        int x;
        int y;
        string name;
        public string Name { get => name; }
        public int X { get => x; }
        public int Y { get => y; }

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
}
