using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    interface IMyDictionary<TKey, TValue>
    {
        
        void Add(TKey k, TValue v);
        
        TValue this[TKey i] { get; } 
        int Count { get;}

    }
}
