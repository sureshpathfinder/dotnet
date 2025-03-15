using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace scrollbar1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s=textBox1.Text;
            switch (s)
            {
                case "http://google.com":
                    webBrowser1.Navigate(textBox1.Text);
                    break;
                case "http://gmail.com":
                    webBrowser1.Navigate(textBox1.Text);
                        break;
                default:
                    MessageBox.Show("Invalid");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("welcome", "Msg", MessageBoxButtons.YesNoCancel);
            
        }
    }
}
