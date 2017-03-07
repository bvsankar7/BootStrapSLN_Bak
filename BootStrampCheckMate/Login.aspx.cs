using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BootStrampCheckMate
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void AuthenticateUser(string username, string password)
        {
            // ConfigurationManager class is in System.Configuration namespace
            string CS = ConfigurationManager.ConnectionStrings["myDBConn"].ConnectionString;
            // SqlConnection is in System.Data.SqlClient namespace
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Sp_AuthenticateUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Formsauthentication is in system.web.security
                string encryptedpassword = FormsAuthentication.HashPasswordForStoringInConfigFile(tbPass.Text, "SHA1");

                //sqlparameter is in System.Data namespace
                SqlParameter paramUsername = new SqlParameter("@UserName", username);
                SqlParameter paramPassword = new SqlParameter("@Password", encryptedpassword);

                cmd.Parameters.Add(paramUsername);
                cmd.Parameters.Add(paramPassword);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {


                    int RetryAttempts = Convert.ToInt32(rdr["RetryAtempts"]);
                    if (Convert.ToBoolean(rdr["AccountLocked"]))
                    {
                        lblmsg.Text = "Account locked. Please contact administrator";
                        lblmsg.ForeColor = System.Drawing.Color.Orange;
                    }
                    else if (RetryAttempts > 0)
                    {
                        int AttemptsLeft = (4 - RetryAttempts);
                        lblmsg.Text = "Invalid user name and/or password. " +
                            AttemptsLeft.ToString() + "attempt(s) left";
                        lblmsg.ForeColor = System.Drawing.Color.Red;
                    }
                    else if (Convert.ToBoolean(rdr["Authenticated"]))
                    {
                        FormsAuthentication.RedirectFromLoginPage(tbUname.Text, rbRem.Checked);
                    }

                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUname.Text == "" || tbPass.Text == "")
            {
                lblmsg.Text = "Please Fill All Text Boxes";
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                AuthenticateUser(tbUname.Text, tbPass.Text);
            }
        }

        protected void LnkRegbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registration/RegistrationPage.aspx");
        }

        protected void ResetPasswd_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registration/ResetPassword.aspx");
        }
    }
}