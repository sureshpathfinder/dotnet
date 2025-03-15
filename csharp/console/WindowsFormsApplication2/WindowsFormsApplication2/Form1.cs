using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            toolTip1.Show("ToolTip Control",button1);
            
        }

        private void mousemove(object sender, EventArgs e)
        {


            toolTip1.Show("ToolTip Control", checkBox1);

        }





    }
}
