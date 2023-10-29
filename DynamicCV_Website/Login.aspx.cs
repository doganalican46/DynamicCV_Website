using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Login : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=dynamicCV;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand com = new SqlCommand("select from Admins where Username=@P1 and Password=@P2",con);
        com.Parameters.AddWithValue("@P1", TextBox1.Text);
        com.Parameters.AddWithValue("@P2", TextBox2.Text);
        SqlDataReader dr = com.ExecuteReader();
        if (dr.Read())
        {
            Response.Redirect("AdminExperiences.Aspx");
        }
        else
        {
            Response.Write("Wrong password or username!");

        }
        con.Close();
    }
}