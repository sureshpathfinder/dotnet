using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            cmd = new SqlCommand("insert into emp(eid,ename,salary) values(" + textBox1.Text + ",'" + textBox2.Text + "'," + textBox3.Text + ")", c);

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

        }

        private void button4_Click(object sender, EventArgs e)
        {
            c.Open();
            cmd = new SqlCommand("sam", c);
            cmd.CommandType = CommandType.StoredProcedure;

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

        private void button5_Click(object sender, EventArgs e)
        {
            c.Open();
            cmd = new SqlCommand("insr", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@eno",textBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@ename", textBox2.Text));
            cmd.Parameters.Add(new SqlParameter("@sal", textBox3.Text));
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

        private void button6_Click(object sender, EventArgs e)
        {
            c.Open();
            cmd = new SqlCommand("spemp", c);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@eno", textBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@ename", textBox2.Text));
            cmd.Parameters.Add(new SqlParameter("@sal", textBox3.Text));
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

        private void button7_Click(object sender, EventArgs e)
        {
            string s = listBox1.SelectedItem.ToString();
            c.Open();
            cmd = new SqlCommand("delete from emp where eid="+s,c);

            int a = cmd.ExecuteNonQuery();
            if (a == 0)
                MessageBox.Show("Data Deleted Error");
            else
                MessageBox.Show("Data Deleted ");
            c.Close();


        }

        



    }
}