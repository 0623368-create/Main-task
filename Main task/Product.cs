using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_task
{
    internal class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(int id, string name, string brand, decimal price, int quantity)
        {
            ID = id;
            Name = name;
            Brand = brand;
            Price = price;
            Quantity = quantity;
        }

    }
}