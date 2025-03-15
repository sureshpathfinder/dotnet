using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.OracleClient;
namespace DataSample
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        OracleConnection cn;
        OracleDataAdapter da;
        DataSet ds;
        private void Form8_Load(object sender, EventArgs e)
        {
            cn = new OracleConnection("data source=dbmain_sivaji;user id=scott;password=tiger");
            da = new OracleDataAdapter("select * from emp", cn);
            ds = new DataSet();

            da.Fill(ds, "emp");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "emp";
            dataGridView1.Refresh();

            textBox1.Text = ds.GetXml();
        }
    }
}