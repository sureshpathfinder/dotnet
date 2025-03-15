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
            foreach (string c in a)
            {
                //MessageBox.Show(c);
                listBox1.Items.Add(c);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox2.Text);
            MessageBox.Show("data added");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "";
            label2.Text += listBox1.SelectedItem.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = "";
            label3.Text += comboBox1.SelectedIndex.ToString();
        }
    }
}