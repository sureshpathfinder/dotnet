using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace suredata
{
    public partial class Form1 : Form
    {
        OleDbConnection c;
       
        OleDbCommand cmd;
        OleDbDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ssidb1DataSet.emp' table. You can move, or remove it, as needed.
            this.empTableAdapter.Fill(this.ssidb1DataSet.emp);
          //  c = new OleDbConnection("Data Source=SERVER;Initial Catalog=ssidb1;User ID=sa");
            //c = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;"+"Data Source=C:\\Documents and Settings\\administrator\\My Documents\\db1.mdb");
            c = new OleDbConnection("Provider=SQLOLEDB;Data Source=SERVER;Persist Security Info=True;User ID=sa;Initial Catalog=ssidb1");
          
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("select * from emp", c);
            
            c.Open();
            dr = cmd.ExecuteReader();
            listBox1.Items.Clear();
            while(dr.Read())
            {
                String s1,s2,s3;
                s1=dr["eno"].ToString();
                s2=dr[1].ToString();
                s3=dr[2].ToString();
                listBox1.Items.Add(s1+"  "+s2+"  "+s3);
            }
            c.Close();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Object o;
            cmd = new OleDbCommand("select Count(Age) from emp", c);
            c.Open();
            o = cmd.ExecuteScalar();
            MessageBox.Show("Total salary=" + o.ToString());          
            c.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String s1, s2, s3;
            s1 = textBox1.Text;
            s2 = textBox2.Text;
            s3 = textBox3.Text;
            cmd = new OleDbCommand("insert into emp values("+s1+",'"+s2+"',"+s3+")", c);
            c.Open();
            int i= cmd.ExecuteNonQuery();
            if(i==0)
                MessageBox.Show("Data Inserted Error");
            else
                MessageBox.Show("Data Inserted ");
            c.Close();

        }

        }
}