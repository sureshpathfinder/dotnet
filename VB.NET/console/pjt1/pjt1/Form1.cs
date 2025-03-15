using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace pjt1
{
    public partial class Form1 : Form
    {
        SqlConnection s = null;
        SqlCommand cmd = null;
        public Form1()
        {
            InitializeComponent();
            s = new SqlConnection("Data Source=SERVER;Initial Catalog=sample;User ID=sa");
        }

        private void button1_Click(object sender, EventArgs e)
        {
             cmd = new SqlCommand("select * from emp ", s);
            s.Open();
            SqlDataReader dr=cmd.ExecuteReader();
          
            while (dr.Read())
            {
                listBox1.Items.Add(dr[0].ToString() + "  " + dr[1].ToString() + "  " + dr[2].ToString());
            }
            s.Close();
        }

        
    }
}