using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Data
{
    class Title
    {
        public string NameTitle { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Название - " + NameTitle);
            Console.ResetColor();
        }

    }
}
