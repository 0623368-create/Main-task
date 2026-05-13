using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Main_task
{
   
    internal static class InventoryService
    {
        public static List<Product> LoadFromCSV(string filePath)
        {
            List<Product> products = new List<Product>();
            if (!File.Exists(filePath)) return products;

            var lines = File.ReadAllLines(filePath).Skip(1);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                // Now checking for exactly 4 columns as per new header
                if (parts.Length >= 4)
                {
                    try
                    {
                        string Brand = parts[0];
                      
                        string Name = parts[1];

                        decimal Price = decimal.Parse(parts[2]); // / 100m;
                        int ID = int.Parse(parts[3]);
                        // default quantity is 0
                        int Quantity = 0;

                        products.Add(new Product(ID, Name, Brand, Price, Quantity));
                    }
                    catch
                    {
                        // Skips rows with formatting errors
                    }
                }
            }
            return products;
        }

        public static void SaveToCSV(string filePath, List<Product> products)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Match header exactly
                writer.WriteLine("Brand,Name,Price,ID,Quantity");

                foreach (var p in products)
                {
                    // Converts price back to cents for storage and includes quantity
                    string line = $"{p.PBrand},{p.PName},{p.PPrice* 100},{p.PID},{p.PQuantity}";
                    writer.WriteLine(line);
                }
            }
        }
    }
}
//67

//67