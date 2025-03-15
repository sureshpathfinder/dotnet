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
        sample s1;
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
            s = new sample();

            t = new Thread(new ThreadStart(s.disp));

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

        class sample
        {
            public String disp()
            {

                for (int i = 0; i < 10; i++)
                {
                   Console.WriteLine (Thread.CurrentThread.Name + "  " + i + "  ");
                }

            }
        }
    }
}