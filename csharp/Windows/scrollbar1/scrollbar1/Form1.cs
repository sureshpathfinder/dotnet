using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace scrollbar1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(hScrollBar1.Value,hScrollBar2.Value,hScrollBar3.Value);
            label1.Text = hScrollBar1.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = hScrollBar1.Value.ToString();
            label2.Text = trackBar1.Value.ToString();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = "Scroll vallue h1 : " + hScrollBar1.Value + "  h2 :  " + hScrollBar2.Value + "  h3 :  "+hScrollBar3.Value;
              label1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }
    }
}