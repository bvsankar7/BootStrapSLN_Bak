using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BootStrampCheckMate
{
    public partial class SubCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string cmd = "select PROD_CAT_ID,PROD_CAT_TYPE from PRODUCT_CATEGORY";
                SqlDataAdapter adpt = new SqlDataAdapter(cmd, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                DDl_Product_Category.DataSource = dt;
                DDl_Product_Category.DataBind();
                DDl_Product_Category.DataTextField = "PROD_CAT_TYPE";
                DDl_Product_Category.DataValueField = "PROD_CAT_ID";
                DDl_Product_Category.DataBind();
                DDl_Product_Category.Items.Insert(0, new ListItem("--Select Category--", "0"));
                con.Close();
                con.Dispose();
            }
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myDBConn"].ConnectionString);
        protected void btn_subCategory_Click(object sender, EventArgs e)
        {
            if (DDl_Product_Category.SelectedItem.Text == "--Select Category--" || txt_subcategory.Text == "")
            {
                lblmsg.Text = "You Must Provide Correct Details";
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[USp_SubCategoryCreation]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pno = new SqlParameter("@SubCategoryName", txt_subcategory.Text);
                SqlParameter pn2 = new SqlParameter("@PRODCATTYPE",DDl_Product_Category.SelectedItem.ToString());
                cmd.Parameters.Add(pno);
                cmd.Parameters.Add(pn2);
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