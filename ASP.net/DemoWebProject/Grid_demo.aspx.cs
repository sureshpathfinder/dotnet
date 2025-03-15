using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Data.SqlClient;
public partial class Default3 : System.Web.UI.Page
{
    DataSet DS;
    SqlDataAdapter MyAdapter;
    SqlConnection MyConnection;
    protected void Page_Load(object sender, EventArgs e)
    {
        MyConnection = new SqlConnection("Data Source=SUNETHRA\\ARASU;Initial Catalog=ado;Integrated Security=True");
        MyAdapter = new SqlDataAdapter("select * from emp", MyConnection);
        SqlCommandBuilder cmb = new SqlCommandBuilder(MyAdapter);

        DS = new DataSet();
        MyAdapter.Fill(DS, "emp");

        if (!IsPostBack)
            bind();
    }

    void bind()
    {
        GridView1.DataSource = DS.Tables["emp"].DefaultView;
        GridView1.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox1.Text = DS.Tables["emp"].Rows[GridView1.SelectedIndex][0].ToString();
        TextBox2.Text = DS.Tables["emp"].Rows[GridView1.SelectedIndex][1].ToString();
        TextBox3.Text = DS.Tables["emp"].Rows[GridView1.SelectedIndex][2].ToString();
    }

    protected void GridView1_Edit(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        bind();
    }

    protected void GridView1_Cancel(object sender,GridViewCancelEditEventArgs  e)
    {
        GridView1.EditIndex = -1;
        bind();
    }

    protected void GridView1_Update(object sender, GridViewUpdateEventArgs  e)
    {
        DS.Tables["emp"].Rows[e.RowIndex][1] = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TxtName")).Text;
        DS.Tables["emp"].Rows[e.RowIndex][2] = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TxtSal")).Text;

       // DS.Tables["emp"].Rows[e.RowIndex][1] = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
        //DS.Tables["emp"].Rows[e.RowIndex][2] = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text;

        MyAdapter.Update(DS, "emp");
        
        GridView1.EditIndex = -1;
        bind();
    }

    protected void GridView1_Delete(object sender, GridViewDeleteEventArgs e)
    {
        DS.Tables["emp"].Rows[e.RowIndex].Delete();

        MyAdapter.Update(DS, "emp");
                
        bind();
    }
}
