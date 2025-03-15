using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name =textBox1.Text;
            int rno=Convert.ToInt32(textBox2.Text);
            int marks =Convert.ToInt32(textBox3.Text);


            SqlConnection conn = new SqlConnection("Data Source=MARUTHI;Initial Catalog=sam;Integrated Security=True");

            SqlCommand comm = new SqlCommand("insert into student values(" + "'" + name + "'" + "," + rno + "," + marks + ")",conn);

            conn.Open();

            int i=comm.ExecuteNonQuery();

            if (i == 1)
            {

                MessageBox.Show("Data inserted");
            }

            conn.Close();












        }

        private void button2_Click(object sender, EventArgs e)
        {


           // string name = textBox1.Text;
            int rno = Convert.ToInt32(textBox2.Text);
           int marks = Convert.ToInt32(textBox3.Text);


            SqlConnection conn = new SqlConnection("Data Source=MARUTHI;Initial Catalog=sam;Integrated Security=True");

            SqlCommand comm = new SqlCommand("update  student set marks="+marks+"where rollno="+rno, conn);

            conn.Open();

            int i = comm.ExecuteNonQuery();

            if (i == 1)
            {

                MessageBox.Show("Data Updated");
            }

            conn.Close();






        }

        private void button3_Click(object sender, EventArgs e)
        {

            // string name = textBox1.Text;
            int rno = Convert.ToInt32(textBox2.Text);
           // int marks = Convert.ToInt32(textBox3.Text);


            SqlConnection conn = new SqlConnection("Data Source=MARUTHI;Initial Catalog=sam;Integrated Security=True");

            SqlCommand comm = new SqlCommand("Delete  student  where rollno=" + rno, conn);

            conn.Open();

            int i = comm.ExecuteNonQuery();

            if (i == 1)
            {

                MessageBox.Show("Data Deleted");
            }

            conn.Close();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {



            // string name = textBox1.Text;
            int rno = Convert.ToInt32(textBox2.Text);
            // int marks = Convert.ToInt32(textBox3.Text);


            SqlConnection conn = new SqlConnection("Data Source=MARUTHI;Initial Catalog=sam;Integrated Security=True");

            SqlCommand comm = new SqlCommand("Select * from  student  where rollno=" + rno, conn);

            conn.Open();




            SqlDataReader dr = comm.ExecuteReader();


            if (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
                textBox3.Text = dr["marks"].ToString();

            }

           

            conn.Close();
        }
    }
}
