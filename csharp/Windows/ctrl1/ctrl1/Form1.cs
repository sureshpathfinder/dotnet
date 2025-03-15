using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ctrl1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Good Morning";

            int s1,s2;
            s1 = int.Parse(textBox1.Text);
            s2 =int.Parse( textBox2.Text);
            textBox3.Text =( s1 + s2).ToString();

            if (radioButton1.Checked)
            {
                richTextBox1.Text = "male";
            }
            else if (radioButton2.Checked)
            {
                richTextBox1.Text = "female";
            }

            


         
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("D:/bsuresh/personals/7 wonders/img12.jpg");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

    }
}