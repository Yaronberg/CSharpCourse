using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        private readonly DateTime date = DateTime.Now;
        public DateTime Date { get => date; }
    }
}
