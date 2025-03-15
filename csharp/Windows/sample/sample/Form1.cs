using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sample
{
    public partial class Form1 : Form
    {
        ArrayList a = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            a.Add("Sunil");
            a.Add("Dinesh");
            a.Add("Arun");
            //listBox1.DataSource = a;
            foreach (string c in a)
                listBox1.Items.Add(c);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(textBox2.Text);
        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = "";
            label3.Text= comboBox1.SelectedItem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            foreach(object o in listBox1.SelectedItems)
                label2.Text+="\n"+o.ToString();
        }

        //private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    label3.Text = "";
        //    label3.Text = listBox1.SelectedItem.ToString();
        //}
    }
}