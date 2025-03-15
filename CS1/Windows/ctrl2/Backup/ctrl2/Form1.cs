using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace ctrl2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome", "hello");

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            helpProvider1.SetHelpString(textBox1, "Enter TextBox value");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox2, "Enter only no");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text=="") 
                  errorProvider1.SetError(textBox1, "user id should not empty");
            //if (textBox2.Text == "") 
            //      errorProvider1.SetError(textBox2, "pwdshould not empty");
      
        }
    }
}