using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Response.Write("<script>alert('Page is loaded')</script>");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label2.Visible=true;
        if ((TextBox1.Text == "ssi") &&(TextBox2.Text=="pwd"))
        {
            Label2.Text = "Welcome <b>"  + TextBox1.Text+" </b> <br>"+TextBox3.Text;
        }
        else
            Label2.Text = "Invalid Input";
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
            
    }
   



    protected void sam(object sender, CommandEventArgs e)
    {
        Response.Write("<script> alert('Clicked');</script>");
        Response.Write("<b>hello</b>");


    }

    
}
