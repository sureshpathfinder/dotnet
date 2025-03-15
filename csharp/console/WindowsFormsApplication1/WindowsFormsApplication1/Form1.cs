using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary1;


namespace WindowsFormsApplication1
{

    delegate void calc(int a,int b);


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text = "Hello world \n welcome";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             int i=Convert.ToInt32(textBox1.Text);
             int j=Convert.ToInt32(textBox2.Text);



             calc c = new calc(add);
             c +=sub;
             c += mul;
             c += div;
             c.Invoke(i,j);




        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("MouseHover");
        }


        public void add(int a, int b)
        {
            textBox3.Text = Convert.ToString(a + b);

        }

        public void sub(int a, int b)
        {
            textBox4.Text = Convert.ToString(a - b);

        }
        public void mul(int a, int b)
        {
            textBox5.Text = Convert.ToString(a * b);

        }
        public void div(int a, int b)
        {
            textBox6.Text = Convert.ToString(a / b);

        }

    }
}
