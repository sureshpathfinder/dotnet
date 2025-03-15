using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.OleDb;

namespace DataSample
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            try{
            da = new OleDbDataAdapter("select * from cust", "provider=microsoft.jet.oledb.4.0;data source=e:\\mydb.mdb");
              
            cmb = new OleDbCommandBuilder(da);
            ds = new DataSet();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        OleDbDataAdapter da;
        OleDbCommandBuilder cmb;
        DataSet ds;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                da.Fill(ds, "cust");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "cust";
                dataGridView1.Refresh();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet myds = (DataSet)dataGridView1.DataSource;

                da.Update(myds, "cust");
                MessageBox.Show ("Updated");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}