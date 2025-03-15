using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_ctrl1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  button1.Click += button1_Click;
        }

        void button1_Click(object sender, EventArgs e)
        {
            
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //printDialog1.ShowDialog();
        //    MessageBox.Show( "Welcome");
        // }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String Course = comboBox1.SelectedItem.ToString();
            String gender="";
            if(radioButton1.Checked)
                gender="Male";
            else if(radioButton2.Checked)
                gender = "Female";
            String lan="";
            if (checkBox1.Checked)
                lan += checkBox1.Text+"   ";
            if (checkBox2.Checked)
                lan += checkBox2.Text+"   ";
            if (checkBox3.Checked)
                lan += checkBox3.Text+"   ";

            listBox1.Items.Add(name+"   "+Course+"  "+ gender +"  "+lan);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Text = comboBox1.SelectedIndex.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i=listBox1.Items.Count;
            listBox1.Items.RemoveAt(i-1);
            
        }
    }
}