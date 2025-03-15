using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient ;
namespace DataSample
{
    public partial class Form6 : Form
    {

        private SqlConnection cnEmp;
        private SqlDataAdapter daEmp;
        private SqlCommand cmdSelEmp;
        private SqlCommand cmdUpEmp;
        private DataSet dsEmp;

        public Form6()
        {
            InitializeComponent();
            //Connection
            cnEmp = new SqlConnection ("server=Server;user id=sa;database=sample");
            //  select command
            cmdSelEmp = new SqlCommand();
            cmdSelEmp.Connection = cnEmp;
            cmdSelEmp.CommandType = CommandType.StoredProcedure;
            cmdSelEmp.CommandText = "GetEmployees";

            //Update Command
            cmdUpEmp = new SqlCommand();
            cmdUpEmp.Connection = cnEmp;
            cmdUpEmp.CommandType = CommandType.StoredProcedure;
            cmdUpEmp.CommandText = "UpdateEmployee";

            //(@eid int,@sal numeric(10,2))

            //Update command parameters
            cmdUpEmp.Parameters.Add("@eid", SqlDbType.Int ,4 ,"empno");
            cmdUpEmp.Parameters.Add("@sal", SqlDbType.Decimal, 10, "sal");

            //DataApapter
            daEmp = new SqlDataAdapter();
            daEmp.SelectCommand = cmdSelEmp;
            daEmp.UpdateCommand  = cmdUpEmp;
            //Dataset
            dsEmp = new DataSet();
            daEmp.Fill(dsEmp);
        }
         private void Form6_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dsEmp;
            dataGridView1.DataMember = dsEmp.Tables[0].TableName ;
            dataGridView1.Refresh();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow []dr=dsEmp.Tables[0].Select("empno=" + textBox1.Text);

            dr[0]["sal"]=textBox2.Text ;

            daEmp.Update (dsEmp );
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dsEmp.Tables[0].Rows[e.RowIndex]["empno"].ToString ();
            textBox2.Text = dsEmp.Tables[0].Rows[e.RowIndex]["sal"].ToString ();
        }
    }
}