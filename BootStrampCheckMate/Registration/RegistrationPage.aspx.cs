using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security;
using System.Web.Security;

namespace BootStrampCheckMate.Registration
{
    public partial class RegistrationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSignup_Click(object sender, EventArgs e)
        {
            if (tbPhone.Text == "")
            {
                lblmsg.Text = "Please fill all the fields..";
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                if (Page.IsValid)
                {
                    string cs = ConfigurationManager.ConnectionStrings["myDBConn"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        SqlCommand cmd = new SqlCommand("Sp_RegisterUser", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        string EncriptedPass = FormsAuthentication.HashPasswordForStoringInConfigFile(tbPass.Text, "SHA1");
                        string EncriptedPass1 = FormsAuthentication.HashPasswordForStoringInConfigFile(tbCpass.Text, "SHA1");

                        SqlParameter uname = new SqlParameter("@FirstName", tbFname.Text);
                        SqlParameter lname = new SqlParameter("@LastName", tbLname.Text);
                        SqlParameter pass = new SqlParameter("@Password", EncriptedPass);
                        SqlParameter cpass = new SqlParameter("@ConfPassword", EncriptedPass1);
                        SqlParameter ph = new SqlParameter("@Phone", tbPhone.Text);
                        SqlParameter email = new SqlParameter("@Email", tbEmail.Text);
                        string gender;
                        if (rbMale.Checked == true)
                        {

                            gender = rbMale.Text;
                        }
                        else
                        {
                            gender = rbFmale.Text;
                        }
                        SqlParameter gnd = new SqlParameter("@Gender", gender.ToString());
                        cmd.Parameters.Add(uname);
                        cmd.Parameters.Add(lname);
                        cmd.Parameters.Add(pass);
                        cmd.Parameters.Add(cpass);
                        cmd.Parameters.Add(ph);
                        cmd.Parameters.Add(email);
                        cmd.Parameters.Add(gnd);

                        con.Open();
                        int ReturnCode = (int)cmd.ExecuteScalar();
                        if (ReturnCode == -1)
                        {
                            lblmsg.Text = "User Name already In Use, Please Choose Another User Name";
                        }
                        else
                        {
                            Response.Redirect("~/Login.aspx");
                        }
                    }
                }
            }
        }
    }
}