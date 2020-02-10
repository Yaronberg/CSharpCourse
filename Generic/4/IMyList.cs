using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    interface IMyList<T>
    {
        void Add(T item);
        public T this[int index] { get; }
        int Count { get; }
    }
}
