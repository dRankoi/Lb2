using System;
using System.Collections.Generic;
using System.Text;

namespace _2._8
{
    class Invoice
    {
        public int Account { get; }
        public string Customer { get; }
        public string Provider { get; }
        private string article;
        private int quantity;

        public Invoice(int account, string customer, string provider, string article, int quantity)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
            this.article = article;
            this.quantity = quantity;
        }
        public double CalculateWithTax()
        {
            double price = 0d;

            switch (article)
            {
                case "1":
                    price = 10d;
                    break;
                case "2":
                    price = 50d;
                    break;
                case "3":
                    price = 200d;
                    break;
            }
            return price * quantity / 0.79d;
        }
        public double CalculateWithoutTax()
        {
            double price = 0d;

            switch (article)
            {
                case "1":
                    price = 10d;
                    break;
                case "2":
                    price = 50d;
                    break;
                case "3":
                    price = 200d;
                    break;
            }
            return price * quantity / 1d;
        }
    }
}
