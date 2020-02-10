using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    interface ICarCollection
    {
        public void Add(string nameCar, DateTime year);
        public string this[int index] { get; }
        public int Count();
        public void RemoveAll();

    }
}
