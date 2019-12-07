using System;
using System.Collections.Generic;
using System.Text;

namespace _7
{
    class Employee
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        readonly double tax = 0.85;
        readonly double bonus = 4; // %
        public double paidTax;
        public double salary ;
        public Employee(string Name, string SurName)
        {
            this.Name = Name;
            this.SurName = SurName;
        }
        public void Salary(string position, int experience)
        {
            switch (position.ToLower())
            {
                case "junior":
                    salary = 600;
                    break;
                case "middle":
                    salary = 1300;
                    break;
                case "senior":
                    salary = 2100;
                    break;
                case "teamlead":
                    salary = 2500;
                    break;
                case "manager":
                    salary = 2000;
                    break;

                default:
                    Console.WriteLine("такой дожности нет");
                    break;
            }

            this.salary += BonusForExperience(salary, experience);

            PayTaxes(salary);

            Console.WriteLine($"Имя работника: {Name}\n" +
                $"Фамилия работника: {SurName}\n" +
                $"Должность: {position}\n" +
                $"Оклад: {salary}\n" +
                $"Налоговый сбор: {paidTax:#.##}\n" +
                $"Оклад после уплаты налогов {salary - paidTax}");
        }
        private double BonusForExperience(double Salary, int experience)
        {
            return salary * (experience * (bonus/100));
        }
        private double PayTaxes(double salary)
        {
            this.paidTax = salary - (salary * tax);
            return salary - paidTax;
        }
    }
}
