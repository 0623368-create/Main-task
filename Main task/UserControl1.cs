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
        public UserControl1()
        {
            InitializeComponent();
        }

        public class product
        {
            public string proname;
            public string probrand;
            public decimal proprice;
            public int proID;

            public product(int proID, string proname, string probrand, decimal proprice)
            {
                this.proID = proID;
                this.proname = proname;
                this.probrand = probrand;
                this.proprice = proprice;
            }
        }



        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void coaddproducts_Click(object sender, EventArgs e)
        {

            int.TryParse(cobrandtb.Text, out int proID);

        //    if false
          //      {

       //         }

            string proname = conametb.Text;
            string probrand = cobrandtb.Text;
            decimal.TryParse(copricetb.Text, out decimal proprice);

        //    if false
      //          {

       //         }


            product newProduct = new product(proID, proname, probrand, proprice);
            dataGridView1.Add(newProduct);


        }

        private void cocheckout_Click(object sender, EventArgs e)
        {

        }

    }
}
