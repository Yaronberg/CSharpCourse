using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Data
{
    class Content
    {
        public string NameContent { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Содержание - " + NameContent);
            Console.ResetColor();
        }
}
}
