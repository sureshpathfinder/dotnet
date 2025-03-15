using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataSample
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet("xmldataset");

                ds.ReadXml("E:/menaka/New Folder/DataSample/DataSample/XMLFile1.xml");

                MessageBox.Show(ds.Tables["emp"].Columns[0].ColumnName);

                foreach (DataRow r in ds.Tables["emp"].Rows)
                    textBox1.Text += r[0].ToString() + "," + r[1].ToString() + "," + r[2].ToString() + (char)13 + (char)10;


                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "emp";
                dataGridView1.Refresh();

            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = (DataSet)dataGridView1.DataSource ;

            ds.WriteXml("E:/Menaka/New Folder/DataSample/DataSample/XMLFile1.xml");

            MessageBox.Show("Data Stored");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}