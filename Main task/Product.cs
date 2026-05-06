using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_task
{
    internal class Product
    {
        public int proID { get; set; }
        public string proname { get; set; }
        public string probrand { get; set; }
        public decimal proprice { get; set; }
        public int proquantity { get; set; }

        public Product(int id, string name, string brand, decimal price, int quantity)
        {
            proID = id;
            proname = name;
            probrand = brand;
            proprice = price;
            proquantity = quantity;
        }

    }
}