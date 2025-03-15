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


public partial class Default7 : System.Web.UI.Page
{
    OleDbConnection c;
    OleDbCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        c = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Documents and Settings/administrator/My Documents/db2.mdb");


    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        c.Open();
        cmd = new OleDbCommand("select * from login_t",c);

        OleDbDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            if ((Login1.UserName == dr[0].ToString()) && (Login1.Password == dr[1].ToString()))
            {
                Response.Write("<script>alert ('Welcome')</script>");
            }
            else
            {
                Response.Write("<script>alert ('Invalid User')</script>");
            }
        }
        c.Close();

    }
}
