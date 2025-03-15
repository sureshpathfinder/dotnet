using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient ;

namespace DataSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection cn;
        private SqlCommand cmd1,cmd2,cmd3;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("server=Server;database=sample;user id=sa");
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd1 = new SqlCommand("select * from emp", cn);

            SqlDataReader dr=cmd1.ExecuteReader();

            listBox1.Items.Clear();
            
            while (dr.Read())
                listBox1.Items.Add(dr[0].ToString() + " : " + dr[1].ToString() + " : " + dr["sal"].ToString());

            dr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            Object c;
            cmd2 = new SqlCommand("select count(*) from emp", cn);

            c=cmd2.ExecuteScalar();

            MessageBox.Show(c.ToString ());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql="insert into emp values(" + textBox1.Text + ",'" +textBox2.Text + "'," + textBox3.Text + ")";
            
            MessageBox.Show (sql);
            
            cmd3=new SqlCommand(sql,cn);
            
            cmd3.ExecuteNonQuery();
        }

        private void Form1_Disposed(object sender, EventArgs e)
        {
            cn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}