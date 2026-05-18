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

        string filePath = "./Book.csv";

        public items()
        {
            InitializeComponent();
        }

        private void items_Load(object sender, EventArgs e)
        {

            var tempData = InventoryService.LoadFromCSV(filePath);

            _inventoryList.Clear();



            dataGridView1.DataSource = _inventoryList;
        }
    }

    



}
