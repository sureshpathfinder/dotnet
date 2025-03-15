using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace scrollbar1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            helpProvider1.SetHelpString(textBox1, "enter user name");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            helpProvider1.SetHelpString(textBox2, "enter user name");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox1.Text)
                errorProvider1.SetError(textBox2, "Password should not equal");
           
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Enter the username", textBox1);
        }

        private void sam(object sender, MouseEventArgs e)
        {
            toolTip2.Show("Click here",button1);
        }
    }
}
