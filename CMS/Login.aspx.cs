using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace CMS
{
    public partial class Login1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                Response.Redirect("Signup.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            SqlDataAdapter adpt = new SqlDataAdapter("Select Username, Password from Employee where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'", @"Data Source=USAMA-PC\SQLEXPRESS;Initial Catalog=CMS;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            
            if (dt.Rows.Count > 0)
            {
                Session["Username"] = TextBox1.Text.Trim();
                Response.Redirect("Signup.aspx");

            }
            else
            {
                //Response.Redirect("Login.aspx");
                Response.Write("<script>alert('Employee ID/Password not entered or Incorrect Password/Employee ID');</script>");
                //LabelError.Text = "Invalid User Credentials";
            }

            


        }
    }
}