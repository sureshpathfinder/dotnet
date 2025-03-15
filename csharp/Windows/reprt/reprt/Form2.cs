using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace reprt
{
    public partial class Form2 : Form
    {
        SqlConnection c = new SqlConnection("Data Source=MARUTHI;Initial Catalog=sam;Integrated Security=True");
        DataSet ds = new DataSet();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            SqlDataAdapter cmd = new SqlDataAdapter("select * from emp where eid=" + textBox1.Text, c);
            cmd.Fill(ds, "emp");

            CrystalReport2 c1 = new CrystalReport2();
            c1.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = c1;
            crystalReportViewer1.Refresh();

        }
    }
}
