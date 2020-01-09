using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();

            myClass.change = "no changed";
            myStruct.change = "no changed";

            ClassTaker(myClass);
            StruсtTaker(myStruct); //передача структуры как локальной копии
            //изменений myStruct в метода Main не будет 

            Console.WriteLine(myClass.change); //changed
            Console.WriteLine(myStruct.change); //no changed

        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed";
        }
        static void StruсtTaker(MyStruct myStruct)
        {
            myStruct.change = "changed";
        }
        class MyClass
        {
            public string change;

        }
        struct MyStruct
        {
            public string change;
        }
    }
}
