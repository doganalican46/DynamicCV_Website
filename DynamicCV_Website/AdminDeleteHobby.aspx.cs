using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminDeleteHobby : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["ID"]);
        DataSetTableAdapters.HobbiesTableAdapter dt = new DataSetTableAdapters.HobbiesTableAdapter();
        dt.DeleteQuery(Convert.ToInt16(x));
        Response.Redirect("AdminHobbies.Aspx");
    }
}