using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace report1
{
    public partial class Form2 : Form
    {
        OdbcConnection c;
        OdbcDataAdapter da;
        DataSet ds = new DataSet();


        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            da = new OdbcDataAdapter("select * from emp where eid=" + textBox1.Text, c);
            da.Fill(ds, "emp");
            CrystalReport2 cr = new CrystalReport2();
            cr.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            c = new OdbcConnection("Dsn=comp");

        }
    }
}
