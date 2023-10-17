using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class About : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {


            DataSetTableAdapters.AboutTableAdapter dt = new DataSetTableAdapters.AboutTableAdapter();
            TextBox1.Text = dt.AboutList()[0].Name;
            TextBox2.Text = dt.AboutList()[0].Surname;
            TextBox3.Text = dt.AboutList()[0].Address;
            TextBox4.Text = dt.AboutList()[0].Mail;
            TextBox5.Text = dt.AboutList()[0].Phone;
            TextBox6.Text = dt.AboutList()[0].About;
            TextBox7.Text = dt.AboutList()[0].Photo;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.AboutTableAdapter dt1 = new DataSetTableAdapters.AboutTableAdapter();
        dt1.UpdateQuery(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text);
        Response.Redirect("Default.Aspx");
    }
}