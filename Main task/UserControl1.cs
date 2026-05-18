using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_task
{
    public partial class UserControl1 : UserControl
    { 
        private BindingList<Product> _inventoryList = new BindingList<Product>();
        private BindingSource _bindingSource = new BindingSource();
        string filePath = "./Book.csv";
        public UserControl1()
        {
            InitializeComponent();
        }

        public class product
        {
            public string Name;
            public string Brand;
            public decimal Price;
            public int ID;

            public product(int ID, string Name, string Brand, decimal Price)
            {
                this.ID = ID;
                this.Name = Name;
                this.Brand = Brand;
                this.Price = Price;
            }
        }



        private void UserControl1_Load(object sender, EventArgs e)
        {
            var tempData = InventoryService.LoadFromCSV(filePath);
            _inventoryList.Clear();

            foreach (var item in tempData)
            {
                _inventoryList.Add(item);
            }

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = _inventoryList;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void cocheckout_Click(object sender, EventArgs e)
        {
            
        }

    

        private void coaddproducts_Click(object sender, EventArgs e)
        {
            


            int.TryParse(coIDtb.Text, out int id);
            string name = conametb.Text;
            string brand = cobrandtb.Text;
            decimal.TryParse(copricetb.Text, out decimal price);
            int.TryParse(coquantitytb.Text, out int quantity);

            Product newProduct = new Product(id, name, brand, price, quantity);

            _inventoryList.Add(newProduct);
            dataGridView1.DataSource = _inventoryList;



        }

        private void cocheckout_Click_1(object sender, EventArgs e)
        {

        }
    }
}