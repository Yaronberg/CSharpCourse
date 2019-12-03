using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 64; i += 4) 
                Console.WriteLine($"Гусей {i / 2} Кроликов {(64 - i) /4}");
            
            Console.ReadLine();
        }
    }
}

