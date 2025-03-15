using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace thread1
{
    public partial class Form1 : Form
    {
        Form1 f;
        
        Thread t;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            f=new
            t = new Thread(new ThreadStart(this.disp));
            t.Name = "t";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.Suspend();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t.Resume();
        }

            public String disp()
            {

                for (int i = 0; i < 10; i++)
                {
                   return Thread.CurrentThread.Name + "  " + i + "  ";
                }

            }
        
    }
}