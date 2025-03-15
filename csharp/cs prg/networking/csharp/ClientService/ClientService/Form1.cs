using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmcas.Service we = new cmcas.Service();
            MessageBox.Show(we.HelloWorld());
            MessageBox.Show(we.GetCurrency(textBox1.Text));
        }
    }
}
