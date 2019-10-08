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
    public partial class Signup : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=USAMA-PC\SQLEXPRESS;Initial Catalog=CMS;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Employee VALUES(@Name, @F_Name, @CNIC, @Contact, @Role, @Username, @Password)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@F_Name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@CNIC", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Contact", TextBox4.Text);
            cmd.Parameters.AddWithValue("@Role", TextBox5.Text);
            cmd.Parameters.AddWithValue("@Username", TextBox6.Text);
            cmd.Parameters.AddWithValue("@Password", TextBox7.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            
            Label1.Text ="New Employee Account created ";
        }
    }
}