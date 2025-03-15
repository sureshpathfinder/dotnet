using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace component1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Welcome");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Clicked";
            MessageBox.Show(textBox1.Text);
            MessageBox.Show(textBox1.ForeColor.ToString());
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Enter a String");
        }

      
    }
}y6