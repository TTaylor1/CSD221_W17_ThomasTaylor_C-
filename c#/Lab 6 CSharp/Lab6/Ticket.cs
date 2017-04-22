using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Ticket : SaleableItem
    {
        private string description;
        private string client;
        private double price;


        public Double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Client
        {
            get { return client; }
            set { client = value; }
        }


        public Ticket()
        {
            this.description = Description;
            this.client = Client;
            this.price = Price;
        }

        public void sellCopy()
        {
            Console.WriteLine("Sell Copy");
        }

        public Double getPrice() { return price; }
    }
}
