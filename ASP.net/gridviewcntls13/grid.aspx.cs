using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Drawing;


public partial class grid : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=USER\SQLEXPRESS1;Integrated Security=True;Initial Catalog=ctl");


    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            Bindgdctl();
        }
    }
    protected void Bindgdctl()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("Select * from gdctl", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        if (ds.Tables[0].Rows.Count > 0)
        {
            gvDetails.DataSource = ds;
            gvDetails.DataBind();
        }
        else
        {
            ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
            gvDetails.DataSource = ds;
            gvDetails.DataBind();
            int columncount = gvDetails.Rows[0].Cells.Count;
            gvDetails.Rows[0].Cells.Clear();
            gvDetails.Rows[0].Cells.Add(new TableCell());
            gvDetails.Rows[0].Cells[0].ColumnSpan = columncount;
            gvDetails.Rows[0].Cells[0].Text = "No Records Found";
        }
        
    }
    protected void gvDetails_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvDetails.EditIndex = e.NewEditIndex;
        Bindgdctl();
    }
    protected void gvDetails_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {



        int userid = Convert.ToInt32(gvDetails.DataKeys[e.RowIndex].Value.ToString());
        string username = gvDetails.DataKeys[e.RowIndex].Values["UserName"].ToString();
        TextBox txtDesignation = (TextBox)gvDetails.Rows[e.RowIndex].FindControl("txtDesg");
        DropDownList txtdepartment = (DropDownList)gvDetails.Rows[e.RowIndex].FindControl("txtdepartment");
        //TextBox txtdepartment = (TextBox)gvDetails.Rows[e.RowIndex].FindControl("txtdepartment");
        DropDownList txtcity = (DropDownList)gvDetails.Rows[e.RowIndex].FindControl("txtcity");
        ////TextBox txtcity = (TextBox)gvDetails.Rows[e.RowIndex].FindControl("txtcity");
        //RadioButton RadioButton1 = (RadioButton)gvDetails.Rows[e.RowIndex].FindControl("RadioButton1");
        
   
            
        
        con.Open();
        SqlCommand cmd = new SqlCommand("update gdctl set City='" + txtcity.SelectedItem.Text + "',Department='" + txtdepartment.SelectedItem.Text + "',Designation='" + txtDesignation.Text + "' where Userid=" + userid, con);
        cmd.ExecuteNonQuery();
        con.Close();
        lblresult.ForeColor = Color.Green;
        lblresult.Text = username + " Details Updated successfully";
        gvDetails.EditIndex = -1;
        Bindgdctl();
    }
    
    protected void gvDetails_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvDetails.EditIndex = -1;
        Bindgdctl();
    }
    protected void gvDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int userid = Convert.ToInt32(gvDetails.DataKeys[e.RowIndex].Values["Userid"].ToString());
        string username = gvDetails.DataKeys[e.RowIndex].Values["UserName"].ToString();
        con.Open();
        SqlCommand cmd = new SqlCommand("delete from gdctl where Userid=" + userid, con);
        int result = cmd.ExecuteNonQuery();
        con.Close();
        if (result == 1)
        {
            Bindgdctl();
            lblresult.ForeColor = Color.Red;
            lblresult.Text = username + " details deleted successfully";
        }
    }
    protected void gvDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("AddNew"))
        {

       

            TextBox txtUsername = (TextBox)gvDetails.FooterRow.FindControl("txtftrusrname");
           
            TextBox txtDesignation = (TextBox)gvDetails.FooterRow.FindControl("txtftrDesignation");
            DropDownList txtdepartment = (DropDownList)gvDetails.FooterRow.FindControl("txtftrdepartment");
            DropDownList txtCity = (DropDownList)gvDetails.FooterRow.FindControl("txtftrcity");
            RadioButton RadioButton1 = (RadioButton)gvDetails.FooterRow.FindControl("RadioButton1");
          

            string gender;
            if (RadioButton1.Checked == true)
                gender = "Male";
            else
                gender = "Female";

                con.Open();
                SqlCommand cmd =
                new SqlCommand(
                "insert into gdctl(UserName,Designation,Department,City,gender) values('" + txtUsername.Text + "','" +
                 txtDesignation.Text + "','" + txtdepartment.SelectedItem.Text + "','" + txtCity.SelectedItem.Text + "','"+ gender +"')", con);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result == 1)
                {
                    Bindgdctl();
                    lblresult.ForeColor = Color.Green;
                    lblresult.Text = txtUsername.Text + " Details inserted successfully";
                }
                else
                {
                    lblresult.ForeColor = Color.Red;
                    lblresult.Text = txtUsername.Text + " Details not inserted";
                }
            }
        }
    
    
    
    protected void gvDetails_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

