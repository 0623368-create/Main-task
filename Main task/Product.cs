using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_task
{
    internal class Product
    {
        public int PID { get; set; }
        public string PName { get; set; }
        public string PBrand { get; set; }
        public decimal PPrice { get; set; }
        public int PQuantity { get; set; }

        public Product(int id, string name, string brand, decimal price, int quantity)
        {
            id = PID;
            name = PName;
            brand = PBrand;
            price = PPrice;
            quantity = PQuantity;
            PID = id;
            PName = name;
            PBrand = brand;
            PPrice = price;
            PQuantity = quantity;
        }

    }
}