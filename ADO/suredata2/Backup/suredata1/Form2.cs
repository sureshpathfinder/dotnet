using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace suredata1
{
    public partial class Form2 : Form
    {
        SqlConnection cn;
        SqlDataAdapter da;
        SqlCommandBuilder cmb;
        DataSet ds;
        DataTable dt;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();

            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;

            dt.Rows.Add(dr);

            da.Update(ds, "emp");
            MessageBox.Show("Row Created");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection
               ("Data Source=SERVER;Initial Catalog=college;User ID=sa");
            da = new SqlDataAdapter("select * from emp", cn);
            cmb = new SqlCommandBuilder(da);

            ds = new DataSet();

            da.Fill(ds, "emp");

            dt = ds.Tables["emp"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow[] dr;
            dr = dt.Select("eid=" + textBox1.Text);

            if (dr.Length > 0)
            {
                dr[0].Delete();
                da.Update(ds, "emp");
                MessageBox.Show("Record Deleted");
            }
            else
                MessageBox.Show("Record Not Found");
           
        }

        

       
    }
}