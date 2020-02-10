using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            var carsPark = new CarCollection<string>();

            carsPark.AddCar("Чебурек", new DateTime(1999, 6, 6));
            carsPark.AddCar("Мерседес", new DateTime(2004, 2, 4));

            Console.WriteLine( carsPark[1]);

            carsPark.RemoveAll();

            Console.WriteLine(carsPark[1]);

            Console.ReadLine();
        }
    }
    class CarCollection<T> : MyList<T> 
    {
        
        private MyList<string> carName;
        private MyList<DateTime> carYear;

        public CarCollection()
        {
            carName = new MyList<string>();
            carYear = new MyList<DateTime>();
        }

        public void AddCar(string name, DateTime year)
        {
            carName.Add(name);
            carYear.Add(year);
        }

        public new string this[int index]
        {
            get
            {
                if (index < carName.Count)
                    return carName[index] + " " + carYear[index].Year + " г";
                return "В списке нет машины под таким номером!";
            }
        }

        public new int Count
        {
            get
            {
                return carName.Count;
            }
        }

        public void RemoveAll()
        {
            carName.Clear();
            carYear.Clear();
        }

    }

}
