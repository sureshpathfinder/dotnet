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

public partial class display : System.Web.UI.Page
{
    SqlConnection cn;
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection("server=Server;database=sample;user id=sa");
        da = new SqlDataAdapter("select * from Products", cn);
        SqlCommandBuilder cmb = new SqlCommandBuilder(da);
        ds = new DataSet();

        da.Fill(ds, "Products");

        if (!Page.IsPostBack)
            bind();
    }

    void bind()
    {
        GridView1.DataSource = ds.Tables["Products"];
        GridView1.DataBind();
    }


    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox1.Text = ds.Tables["Products"].Rows[GridView1.SelectedIndex][0].ToString();
        TextBox2.Text = ds.Tables["Products"].Rows[GridView1.SelectedIndex][1].ToString();
        TextBox3.Text = ds.Tables["Products"].Rows[GridView1.SelectedIndex][2].ToString();
        TextBox4.Text = ds.Tables["Products"].Rows[GridView1.SelectedIndex][3].ToString();
    }
    protected void GridView1_RowEdit(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        bind();
    }

    protected void GridView1_RowEditCancel(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        bind();
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //ds.Tables["Products"].Rows[e.RowIndex][1] = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
        //ds.Tables["Products"].Rows[e.RowIndex][2] = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text;
        //ds.Tables["Products"].Rows[e.RowIndex][3] = ((TextBox)GridView1.Rows[e.RowIndex].Cells[6].Controls[0]).Text;


        ds.Tables["Products"].Rows[e.RowIndex][1] = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtPname")).Text;
        ds.Tables["Products"].Rows[e.RowIndex][2] = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtPrice")).Text;

        da.Update(ds, "Products");

        GridView1.EditIndex = -1;
        bind();
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        ds.Tables["Products"].Rows[e.RowIndex].Delete();
        da.Update(ds, "Products");

        bind();
    }
}
