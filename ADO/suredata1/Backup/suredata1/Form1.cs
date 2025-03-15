using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace suredata1
{
    public partial class Form1 : Form
    {
        
        OleDbConnection c;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public Form1()
        {
            c = new OleDbConnection("Provider=SQLOLEDB;Data Source=SERVER;User ID=sa;Initial Catalog=college");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Open();
            cmd = new OleDbCommand("insert into emp values(" + textBox1.Text + ",'" + textBox2.Text + "'," + textBox3.Text + ")", c);

            int a = cmd.ExecuteNonQuery();
            if (a == 0)
                MessageBox.Show("Data Inserted Error");
            else
                MessageBox.Show("Data Inserted");
            c.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Open();
            cmd = new OleDbCommand("select * from emp", c);
            dr = cmd.ExecuteReader();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            while (dr.Read())
            {
                listBox1.Items.Add(dr[0].ToString());
                listBox2.Items.Add(dr[1].ToString());
                listBox3.Items.Add(dr[2].ToString());
            }
            c.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.Open();
            cmd = new OleDbCommand("select count(ename) from emp", c);
            Object o = cmd.ExecuteScalar();
            MessageBox.Show("Total employee=" + o.ToString());
            c.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



    }
}