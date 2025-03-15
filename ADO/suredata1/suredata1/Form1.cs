using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
namespace suredata1
{
    public partial class Form1 : Form
    {
        
        SqlConnection c;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            c = new SqlConnection("Data Source=SUNETHRA\\ARASU;Initial Catalog=ado;Integrated Security=True");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Open();
            cmd = new SqlCommand("insert into emp values(" + textBox1.Text + ",'" + textBox2.Text + "'," + textBox3.Text + ")", c);

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
            cmd = new SqlCommand("select * from emp", c);
            dr = cmd.ExecuteReader();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["eid"].ToString());
                listBox2.Items.Add(dr[1].ToString());
                listBox3.Items.Add(dr[2].ToString());
            }
            c.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.Open();
            cmd = new SqlCommand("select count(ename) from emp", c);
            Object o = cmd.ExecuteScalar();
            MessageBox.Show("Total employee=" + o.ToString());
            c.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           // string xm = ConfigurationSettings.AppSettings["x"].ToString();
            //MessageBox.Show(xm);
        }

        


    }
}