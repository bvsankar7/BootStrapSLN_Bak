using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BootStrampCheckMate
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myDBConn"].ConnectionString);
        protected void btn_Category_Click(object sender, EventArgs e)
        {
            if (txt_category.Text == "")
            {
                lblmsg.Text = "Field Must Not Be Empty";
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[USp_CategoryCreation]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pno = new SqlParameter("@CategoryName", txt_category.Text);
                cmd.Parameters.Add(pno);
                int ReturnCode = (int)cmd.ExecuteScalar();
                if (ReturnCode == -1)
                {
                    lblmsg.Text = "CategoryName already In Use, Please Choose Another One";
                    lblmsg.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblmsg.Text = "Records Successfully Inserted";
                    lblmsg.ForeColor = System.Drawing.Color.Green; ;
                }
                con.Close();
                con.Dispose();
            }
        }
    }
}