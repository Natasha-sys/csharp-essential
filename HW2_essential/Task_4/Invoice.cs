using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Invoice
    {
        public readonly int account;
        public readonly string customer;
        public readonly string provider;

        private string article;
        private int quantity;

        public Invoice(int account, string customer, string provider, string article, int quantity)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;

        }
        public double Calculate(bool withVAT)
        {
            double price;
            switch (article)
            {
                case "product 1":
                    price = 34.5;
                    break;
                case "product 2":
                    price = 300;
                    break;

                default:
                    price = 0;
                    break;

            }
            if (withVAT)
            { return price * quantity * 1.2; }
            else
            { return price * quantity; }

        }
    }
}
