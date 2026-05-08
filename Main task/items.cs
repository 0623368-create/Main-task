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
    public partial class items : UserControl
    {
        private BindingList<Product> _inventoryList = new BindingList<Product>();
        private BindingSource _bindingSource = new BindingSource();

        string filePath = "H:/Programming/Main task/Main task/Book.csv";

        public items()
        {
            InitializeComponent();
        }

        private void items_Load(object sender, EventArgs e)
        {

            var tempData = InventoryService.LoadFromCSV(filePath);

            _inventoryList.Clear();
            foreach (var item in tempData)
            {
                _inventoryList.Add(item);
            }

            dataGridView1.DataSource = _inventoryList;
        }
        
        

    }

}
