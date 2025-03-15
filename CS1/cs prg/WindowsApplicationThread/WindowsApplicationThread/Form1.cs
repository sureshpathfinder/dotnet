using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Threading;

namespace WindowsApplicationThread
{
    public partial class Form1 : Form
    {
        Thread t1, t2;
        
        public Form1()
        {
            InitializeComponent();
        
           t1 = new Thread(new ThreadStart(A));
           t2 = new Thread(new ThreadStart(B));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
        }
        int i, j;
        string tname1,tname2;
        
        public void A()
        {
            tname1 = Thread.CurrentThread.Name;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " : A " + i);
               //error//listBox1.Items.Add (Thread.CurrentThread.Name + " : A " + i);
                 AccessConTrolA();
                Thread.Sleep(1000);
            }
        }

        public void B()
        {
           tname2 = Thread.CurrentThread.Name;
            for (j = 1; j <= 20; j++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " : B " + j.ToString());
                //listBox1.Items.Add (Thread.CurrentThread.Name + " : B " + i.ToString());
                AccessConTrolB();
                Thread.Sleep(500);
            }
        }
        
        void AccessConTrolA()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(AccessConTrolA));
            else
                listBox1.Items.Add(tname1 + " : A " + i);
        }
        
        void AccessConTrolB()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(AccessConTrolB));
            else
                listBox1.Items.Add(tname2 + " : B " + j);
        }
        

        private void button1_Click(object sender, System.EventArgs e)
        {
            t1.Name = "First Thread";
            t2.Name = "Second Thread";

            t2.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            t1.Suspend();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            t2.Suspend();
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            try
            {
                t1.Resume();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            try
            {
                t2.Resume();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            t1.Abort();
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            t2.Abort();
       }
    }
}