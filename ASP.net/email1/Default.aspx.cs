using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using  System.Net.Mail;
using  System.Web.Mail;



public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

        mail.From = new MailAddress("ssistudent100@gmail.com");
        mail.To.Add("fdsfd");
        mail.Subject = "dhfsgd";
        mail.Body ="fdsfds";

        SmtpServer.Port = 587;
        SmtpServer.Credentials = new System.Net.NetworkCredential("ssistudent100", "9500195280");

        SmtpServer.EnableSsl = true;

        SmtpServer.Send(mail);
        Response.Write("Message Sent");


        
    }
}
