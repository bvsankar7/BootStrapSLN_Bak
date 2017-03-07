using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System;

namespace BootStrampCheckMate
{
    public partial class ItemCreation : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myDBConn"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                display();
                string cmd = "select PROD_SUB_CAT_ID,PROD_SUB_CAT_TYPE from PRODUCT_SUB_CATEGORY";
                SqlDataAdapter adpt = new SqlDataAdapter(cmd,con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                DDL_Category.DataSource = dt;
                DDL_Category.DataBind();
                DDL_Category.DataTextField = "PROD_SUB_CAT_TYPE";
                DDL_Category.DataValueField = "PROD_SUB_CAT_ID";
                
                DDL_Category.DataBind();
                DDL_Category.Items.Insert(0, new ListItem("--Select--", "0"));
                con.Close();
                con.Dispose();
            }
        }


        protected void btn_Ord_create_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "")
            {
                lblmsg.Text = "You must fill all of the fields..";
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
            else
            {

                con.Open();
                string t1=TextBox6.Text = "500";
                string t2=TextBox7.Text = "200";
                string t3=TextBox8.Text = "10,999";

                SqlCommand cmd = new SqlCommand("[USp_ChkMt_ItemCreation]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pno = new SqlParameter("@ProductNo", TextBox1.Text);
                SqlParameter pname = new SqlParameter("@Name", TextBox2.Text);
                SqlParameter qty = new SqlParameter("@Quantity", TextBox3.Text);
                SqlParameter rate = new SqlParameter("@Rate", TextBox4.Text);
                SqlParameter catgory = new SqlParameter("@CategoryType", DDL_Category.SelectedItem.ToString());

                SqlParameter color = new SqlParameter("@Color", TextBox5.Text);
                SqlParameter sftystock = new SqlParameter("@SafetyStockLevel", t1);
                SqlParameter Rpoint = new SqlParameter("@ReorderPoint", t2);
                SqlParameter Scost = new SqlParameter("@StandardCost", t3);
                SqlParameter size = new SqlParameter("@Size", TextBox9.Text);
                SqlParameter wt = new SqlParameter("@Weight", TextBox10.Text);
                SqlParameter clas = new SqlParameter("@Class", TextBox11.Text);
                SqlParameter Desc = new SqlParameter("@Description", TextBox12.Text);


                cmd.Parameters.Add(pno);
                cmd.Parameters.Add(pname);
                cmd.Parameters.Add(qty);
                cmd.Parameters.Add(rate);
                cmd.Parameters.Add(catgory);
                cmd.Parameters.Add(color);
                cmd.Parameters.Add(sftystock);
                cmd.Parameters.Add(Rpoint);
                cmd.Parameters.Add(Scost);
                cmd.Parameters.Add(size);
                cmd.Parameters.Add(wt);
                cmd.Parameters.Add(clas);
                cmd.Parameters.Add(Desc);

                int ReturnCode = (int)cmd.ExecuteScalar();
                if (ReturnCode == -1)
                {
                    lblmsg.Text = "Product Name is already In Use, Please Choose Another One";
                    lblmsg.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblmsg.Text = "Records Successfully Inserted";
                    lblmsg.ForeColor = System.Drawing.Color.Green; ;
                }
                con.Close();
                display();
                ClearFields();
            }
        }
        public void ClearFields()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            //DDL_Category.Text = "";
        }

        public void CheckAllAttempts()
        {

        }
        public void display()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("Select ProductNum,Name,Color,Class,Quantity,Rate,Description from ChkMt_Products as O inner join ChkMt_ProductDetails OD on O.ProductId=OD.ProductDetail_Id", con);
            DataTable dt = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            ada.Fill(dt);
            grd_orders.DataSource = dt;
            grd_orders.DataBind();
            con.Close();
        }

        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            //LinkButton btn = (LinkButton)sender;
            //con.Open();
            //SqlCommand cmd = new SqlCommand("Select OrderNo,Description,ItemName,Quantity,Rate from Orders as O inner join OrderDetails OD on O.OrderId=OD.OrderItemId where OrderNo='"+btn+"'", con);
            //DataTable dt = new DataTable();
            //SqlDataAdapter ada = new SqlDataAdapter(cmd);
            //ada.Fill(dt);
            //if (dt.Rows.Count >= 0)
            //{
            //    TextBox1.Text = dt.Rows[0]["OrderNo"].ToString();
            //    TextBox5.Text = dt.Rows[1]["Description"].ToString();
            //    TextBox2.Text = dt.Rows[2]["ItemName"].ToString();
            //    TextBox3.Text = dt.Rows[3]["Quantity"].ToString();
            //    TextBox4.Text = dt.Rows[4]["Rate"].ToString();
            //}
            //con.Close();

            GridViewRow row = grd_orders.SelectedRow;
            TextBox1.Text = row.Cells[0].Text;
            TextBox2.Text = row.Cells[1].Text;
            TextBox5.Text = row.Cells[2].Text;
            TextBox11.Text = row.Cells[3].Text;
            TextBox3.Text = row.Cells[4].Text;
            TextBox4.Text = row.Cells[5].Text;
            TextBox12.Text = row.Cells[6].Text;
            //TextBox1.Text = (row.FindControl("lblOrderNo") as Label).Text;
        }

        protected void btn_Ord_Update_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "")
            {
                lblmsg.Text = "You must fill all of the fields..";
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[USp_ChkMt_ItemUpdation]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pno = new SqlParameter("@ProductNo", TextBox1.Text);
                SqlParameter pname = new SqlParameter("@Name", TextBox2.Text);
                SqlParameter qty = new SqlParameter("@Quantity", TextBox3.Text);
                SqlParameter rate = new SqlParameter("@Rate", TextBox4.Text);
                SqlParameter catgory = new SqlParameter("@CategoryType", DDL_Category.SelectedItem.ToString());

                SqlParameter color = new SqlParameter("@Color", TextBox5.Text);
                SqlParameter sftystock = new SqlParameter("@SafetyStockLevel", TextBox6.Text);
                SqlParameter Rpoint = new SqlParameter("@ReorderPoint", TextBox7.Text);
                SqlParameter Scost = new SqlParameter("@StandardCost", TextBox8.Text);
                SqlParameter size = new SqlParameter("@Size", TextBox9.Text);
                SqlParameter wt = new SqlParameter("@Weight", TextBox10.Text);
                SqlParameter clas = new SqlParameter("@Class", TextBox11.Text);
                SqlParameter Desc = new SqlParameter("@Description", TextBox12.Text);
                cmd.Parameters.Add(pno);
                cmd.Parameters.Add(pname);
                cmd.Parameters.Add(qty);
                cmd.Parameters.Add(rate);
                cmd.Parameters.Add(catgory);
                cmd.Parameters.Add(color);
                cmd.Parameters.Add(sftystock);
                cmd.Parameters.Add(Rpoint);
                cmd.Parameters.Add(Scost);
                cmd.Parameters.Add(size);
                cmd.Parameters.Add(wt);
                cmd.Parameters.Add(clas);
                cmd.Parameters.Add(Desc);
                int ReturnCode = (int)cmd.ExecuteScalar();
                if (ReturnCode == -1)
                {
                    lblmsg.Text = "There is No Orders On this number..";
                    lblmsg.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblmsg.Text = "Records Successfully Updated";
                    lblmsg.ForeColor = System.Drawing.Color.Green;
                }
                con.Close();
                display();
                ClearFields();
            }
        }

        protected void btn_Ord_Delete_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "")
            {
                lblmsg.Text = "You must fill all of the fields..";
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("USp_ChkMt_ItemDeletion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter uname = new SqlParameter("@ProductNo", TextBox1.Text);
                cmd.Parameters.Add(uname);
                int ReturnCode = (int)cmd.ExecuteScalar();
                if (ReturnCode == -1)
                {
                    lblmsg.Text = "No Recordes on this orderId for deletion..";
                    lblmsg.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblmsg.Text = "Records Successfully Deleted";
                    lblmsg.ForeColor = System.Drawing.Color.Green;
                }
                con.Close();
                display();
                ClearFields();
            }

        }
    }
}