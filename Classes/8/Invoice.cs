using System;
using System.Collections.Generic;
using System.Text;

namespace _8
{
    class Invoice
    {
        readonly int account;
        public int Account { get => account; }
        readonly string customer;
        public string Сustomer { get => customer; }
        readonly string provider;
        public string Provider { get => provider; }
        
        private string article;
        private int quantity;
        private double tax = 0.22;
        private double price = 250;
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public void AddOrder(string article, int quantity)
        {
            this.article = article;
            this.quantity = quantity;
        }
        private double CostWithTax()
        {
            return quantity * price + (quantity * price * tax);
        }
        public void Order()
        {
            Console.WriteLine($"{customer} заказал: {article} - в количестве {quantity} шт.");
            Console.WriteLine($"Стоимость заказа без НДС = {quantity * price}");
            Console.WriteLine($"Стоимость заказа с НДС = {CostWithTax()}");
        }
    }
}
