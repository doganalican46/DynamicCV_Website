using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminUpdateHobby : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.HobbiesTableAdapter dt = new DataSetTableAdapters.HobbiesTableAdapter();
        int x = Convert.ToInt16(Request.QueryString["ID"]);
        txtID.Text = x.ToString();

        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.HobbiesTableAdapter dt1 = new DataSetTableAdapters.HobbiesTableAdapter();

            txtHobby.Text = dt1.GetHobby(Convert.ToInt16(x))[0].Hobby;

        }
    }

    protected void btnUpdateHobby_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.HobbiesTableAdapter dt = new DataSetTableAdapters.HobbiesTableAdapter();
        dt.UpdateQuery(txtHobby.Text, Convert.ToInt16(txtID.Text));
        Response.Redirect("AdminHobbies.Aspx");
    }
}