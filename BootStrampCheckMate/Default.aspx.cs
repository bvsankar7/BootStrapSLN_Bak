using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BootStrampCheckMate
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadImages();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fileName = FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Model/") + fileName);
            }                    
            Response.Redirect("~/Default.aspx");
        }

        private void LoadImages()
        {
            foreach (string strfile in Directory.GetFiles(Server.MapPath("~/Model")))
            {
                Label lbl = new Label();
                lbl.Text = "hello Image";
                lbl.ForeColor = System.Drawing.Color.Green;
                lbl.Style.Add("padding", "5px");
                ImageButton imageButton = new ImageButton();
                FileInfo fi = new FileInfo(strfile);
                imageButton.ImageUrl = "~/Model/" + fi.Name;
                imageButton.Height = Unit.Pixel(100);
                imageButton.Style.Add("padding", "5px");
                imageButton.Width = Unit.Pixel(100);
                imageButton.Click += new ImageClickEventHandler(imageButton_Click);
                
                imageButton.Controls.Add(lbl);
                Panel1.Controls.Add(imageButton);
            }
        }

        protected void imageButton_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("WebForm2.aspx?ImageURL=" +
                ((ImageButton)sender).ImageUrl);
        }
    }

}