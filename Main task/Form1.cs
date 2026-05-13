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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void comenu_Click(object sender, EventArgs e)
        {

            ShowScreen(new menuUS());

        }

        private void cocheckout_Click(object sender, EventArgs e)
        {
            ShowScreen(new UserControl1());

        }

        // This can be reused for showing any UserControl
        private void ShowScreen(UserControl newScreen)
        {
            // Find existing controls and dispose them to free memory
            foreach (Control ctrl in pnlContent.Controls)
            {
                ctrl.Dispose();
            }

            pnlContent.Controls.Clear(); // Clear the controls
            newScreen.Dock = DockStyle.Fill; // Set Dock to Fill
            pnlContent.Controls.Add(newScreen); // Add the UC to Pnl
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
        


        private void Form1_Load(object sender, EventArgs e)
        {
            ShowScreen(new menuUS());
        }

        private void coaboutus_Click(object sender, EventArgs e)
        {
            ShowScreen(new aboutususercontrol());
        }

        private void coitemsbtn_Click_1(object sender, EventArgs e)
        {
            ShowScreen(new UserControl_inventory());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //the the umm hte uhh user checkuout thing appears





    }
    }
