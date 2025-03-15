using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace progress1
{
    public partial class Form1 : Form
    {
        int i=1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             timer1.Enabled = true;
             label1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = i;
            i++;
            label1.Text = "Remaining  " + (100-i);
            if (i >= 100) 
                timer1.Stop();      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        
       
    }
}