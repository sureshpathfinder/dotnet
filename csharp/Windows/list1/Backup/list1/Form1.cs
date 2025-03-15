using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace list1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String str;
            label1.Text = "";
            foreach (Object s in listBox1.SelectedItems)
            {
                str= s as String;
                label1.Text+=str+"\n";
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = comboBox1.SelectedItem.ToString();
        }
    }
}