using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
                                                                                            
namespace DataSample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection cn;
        SqlDataAdapter da;
        SqlCommandBuilder cmb;
        DataSet ds;
        DataTable dt;
        int recno;
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                cn = new SqlConnection("Data Source=SERVER;Initial Catalog=ssidb1;User ID=sa");
                da = new SqlDataAdapter("select * from emp", cn);
                cmb = new SqlCommandBuilder(da);
                
                ds = new DataSet();

                da.Fill(ds, "emp");

                dt = ds.Tables["emp"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = dt.NewRow();

                dr[0] = textBox1.Text;
                dr[1] = textBox2.Text;
                dr[2] = textBox3.Text;

                dt.Rows.Add(dr);

                da.Update(ds, "emp");
                MessageBox.Show("Row Created");
            }
            catch
            {
                MessageBox.Show("error");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow[] dr;
            dr=dt.Select("empno=" + textBox1.Text);

            if (dr.Length > 0)
            {
                dr[0][1] = textBox2.Text;
                dr[0][2] = textBox3.Text;

                da.Update(ds, "emp");
                MessageBox.Show("Record Updated");
            }
            else
                MessageBox.Show("Record Not Found");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow[] dr;
            dr = dt.Select("empno=" + textBox1.Text);

            if (dr.Length > 0)
            {
                dr[0].Delete();
                da.Update(ds, "emp");

                recno = 0;
                display(ref recno);
                
                MessageBox.Show("Record Deleted");

            }
            else
                MessageBox.Show("Record Not Found");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            recno = 0;
            display(ref recno);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            recno ++;
            display(ref recno);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            recno--;
            display(ref recno);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            recno = dt.Rows.Count - 1;
            display(ref recno);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Text = ds.GetXml();
        }

        
        private void display(ref int rno)
        {
            if (rno < 0)
                rno = 0;
            if (rno >= dt.Rows.Count)
                rno = dt.Rows.Count - 1;
            if (dt.Rows.Count > 0)
            {
                textBox1.Text = dt.Rows[rno]["empno"].ToString();
                textBox2.Text = dt.Rows[rno][1].ToString();
                textBox3.Text = dt.Rows[rno][2].ToString();
            }
            else
                MessageBox.Show("No Records");

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

 
    }
}