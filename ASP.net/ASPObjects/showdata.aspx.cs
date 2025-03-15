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


using System.Data.OleDb;
public partial class showdata : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Request.ServerVariables["request_method"] == "GET")

        if (Request.RequestType == "GET")
        {
            Label1.Text = "From Get <br>User name is " + Request.QueryString["usr"];
            Label1.Text += "Password is " + Request.QueryString["pwd"];
        }
        else
        {
            Label1.Text = "From Post <br> User name is " + Request.Form["usr"];
            Label1.Text += "Password is " + Request.Form["pwd"];
        }

        Label1.Text += "<br>" + Request.ServerVariables["request_method"] + "<br>";
        Label1.Text += Request.ServerVariables["remote_addr"] + "<br>";
        Label1.Text +="RequestType : " + Request.RequestType;
        Label1.Text +="<br>Total Bytes :" + Request.TotalBytes;
        Label1.Text +="<br>Machine Name : " + Request.UserHostName;
        Label1.Text +="<br> File Path : " + Request.FilePath;

        Label1.Text += "<br> Browser Name: " + Request.Browser.Browser + " <br>";
        Label1.Text +="Browser Version : " + Request.Browser.Version + " <br>";
        Label1.Text += "Browser Os : " + Request.Browser.Win16+ " <br>";
        Label1.Text +="VBScript Supported : " + Request.Browser.VBScript + " <br>";
        Label1.Text +="Tables Supported : " + Request.Browser.Tables + " <br>";
        Label1.Text +="JavaScript Supported : " + Request.Browser.JavaScript + " <br>";

        Label1.Text += "<table border='2'>";

        foreach (string v in Request.ServerVariables)
            Label1.Text += "<tr><td>" + v + "<td>" + Request.ServerVariables[v];

            Label1.Text = Label1.Text + "</table>";
    }
}
