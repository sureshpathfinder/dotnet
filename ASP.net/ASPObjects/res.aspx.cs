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

public partial class res : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Byte[] b = new Byte[4];
        b[0] = 68;
        b[1] = 65;
        b[2] = 66;
        b[3] = 67;

       // Response.Buffer = true;

      //Response.ContentType = "application/msword";
      // Response.ContentType = "text/plain";


        Response.Write("<h2>Buffer Output is " + Response.BufferOutput);
        Response.Write("<h2>Expire  : " + Response.Expires);
        Response.Write("<h2>Expires Absolute  : " + Response.ExpiresAbsolute);
        Response.Write("<h2>Is Client Connected : " + Response.IsClientConnected);
        
        
        Response.WriteFile("File1.txt");
        Response.BinaryWrite(b);
        Response.Flush();
        Response.Write("hello");
      //  Response.Clear();
        Response.Write("Welcome");
     // Response.End();
        Response.Write("End of Page");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("sample.aspx");
    }
}
