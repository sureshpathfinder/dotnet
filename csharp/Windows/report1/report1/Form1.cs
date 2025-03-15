using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
namespace report1
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlDataAdapter da;
        SqlCommandBuilder cmb;
        DataSet ds;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             ReportDocument r= new ReportDocument();
            r.Load("D:/bsuresh/program/DOT NET/CS1/Windows/report1/report1/CrystalReport1.rpt");
            crystalReportViewer1.ReportSource = r;
            crystalReportViewer1.Refresh();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection
                ("Data Source=SERVER;Initial Catalog=ssidb1;User ID=sa");
            da = new SqlDataAdapter("select * from emp where eno="+textBox1.Text, cn);
            cmb = new SqlCommandBuilder(da);

            ds = new DataSet();

            da.Fill(ds, "emp");

            CrystalReport2 cr = new CrystalReport2();
            cr.SetDataSource(ds.Tables["emp"]);
            crystalReportViewer2.ReportSource = cr;
            crystalReportViewer2.Refresh();

           
        }
    }
}