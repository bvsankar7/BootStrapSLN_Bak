using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;
using System.Net.Mail;
using System.Text;
using System.Net;
using System.Net.Mime;

namespace BootStrampCheckMate.Registration
{
    public partial class ResetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnResetPassword_Click(object sender, EventArgs e)
        {

            //string CS = ConfigurationManager.ConnectionStrings["myDBConn"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(CS))
            //{
            //    SqlCommand cmd = new SqlCommand("spResetPassword", con);
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    SqlParameter paramUsername = new SqlParameter("@UserName", txtUserName.Text);

            //    cmd.Parameters.Add(paramUsername);

            //    con.Open();
            //    SqlDataReader rdr = cmd.ExecuteReader();
            //    while (rdr.Read())
            //    {
            //        if (Convert.ToBoolean(rdr["ReturnCode"]))
            //        {
            //            SendPasswordResetEmail(rdr["Email"].ToString(), txtUserName.Text, rdr["UniqueId"].ToString());
            //            lblMessage.Text = "An email with instructions to reset your password is sent to your registered email";
            //            lblMessage.ForeColor = System.Drawing.Color.Green;
            //        }
            //        else
            //        {
            //            lblMessage.ForeColor = System.Drawing.Color.Red;
            //            lblMessage.Text = "Username not found!";
            //        }
            //    }
            //}


            string CS = ConfigurationManager.ConnectionStrings["myDBConn"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spResetPassword", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramUsername = new SqlParameter("@UserName", txtUserName.Text);

                cmd.Parameters.Add(paramUsername);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (Convert.ToBoolean(rdr["ReturnCode"]))
                    {
                        SendPasswordResetEmail(rdr["Email"].ToString(), txtUserName.Text, rdr["UniqueId"].ToString());
                        lblMessage.Text = "An email with instructions to reset your password is sent to your registered email";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                        lblMessage.Text = "Username not found!";
                    }
                }
            }
        }
        private void SendPasswordResetEmail(string toMail, string UserName, string UniqueId)
        {
            //// MailMessage class is present is System.Net.Mail namespace

            //MailMessage mailMessage = new MailMessage("YourEmail@gmail.com", ToEmail);

            //// StringBuilder class is present in System.Text namespace
            //StringBuilder sbEmailBody = new StringBuilder();
            //sbEmailBody.Append("Dear " + UserName + ",<br/><br/>");
            //sbEmailBody.Append("Please click on the following link to reset your password");
            //sbEmailBody.Append("<br/>"); sbEmailBody.Append("http://localhost/BootStrampCheckMate/Registration/ChangePassword.aspx?uid=" + UniqueId);
            //sbEmailBody.Append("<br/><br/>");
            //sbEmailBody.Append("<b><h2>CHECKMATE TEAM SOLUTIONS<h2></b>");

            //mailMessage.IsBodyHtml = true;

            //mailMessage.Body = sbEmailBody.ToString();
            //mailMessage.Subject = "Reset Your Password";
            //SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            //smtpClient.Credentials = new System.Net.NetworkCredential()
            //{
            //    UserName = "sankarboreddy@gmail.com",
            //    Password = "Cvkksps@1234567"
            //};

            //smtpClient.EnableSsl = true;
            //smtpClient.Send(mailMessage);


            #region Actual Sending Mails
            
            // Gmail Address from where you send the mail
            var fromAddress = "CheckMateWebIndia@gmail.com";
            // any address where the email will be sending

            var toAddress = txtEmail.Text.ToString();
            string file=@"D:\BulkData\Backup\MARTDB_backup_2017_02_20_103355_8356769.bak";
            //Password of your gmail address
            const string fromPassword = "Chkmt@web507";
            // Passing the values and make a email formate to display
            string subject = "Reset Your Password";

            string body = "Dear  " + UserName + "\n\n";
            body += "Please click on the following link to reset your password" + "\n";
            body += "http://localhost/CheckMate/Registration/ChangePassword.aspx?uid=" + UniqueId + "\n\n";

            Attachment data = new Attachment(file, MediaTypeNames.Application.Octet);

            // Add time stamp information for the file.
            ContentDisposition disposition = data.ContentDisposition;
            disposition.CreationDate = System.IO.File.GetCreationTime(file);
            disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
            disposition.ReadDate = System.IO.File.GetLastAccessTime(file);

            // Add the file attachment to this e-mail message.
            body += data;
            body += new Attachment(@"D:\BulkData\Backup\MARTDB_backup_2017_02_20_103355_8356769.bak")+"\n\n\n";

            body += " \n" + "CHECKMATE TEAM SOLUTIONS";
            var smtp = new System.Net.Mail.SmtpClient();
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
                smtp.Timeout = 20000;
            }
            // Passing values to smtp object
            smtp.Send(fromAddress, toAddress, subject, body); 
            #endregion
        }
    }
}