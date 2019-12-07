using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            user.Login = "Aloha";
            user.Name = "Ivan";
            user.SurName = "Key";
            user.Age = 22;

            Console.WriteLine(user.Login + " " + user.Name + " " + user.SurName + " " + user.Age + " " + user.Date);
            
            Console.ReadLine();
        }
    }
}
