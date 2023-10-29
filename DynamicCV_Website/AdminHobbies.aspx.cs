using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminHobbies : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.HobbiesTableAdapter dt = new DataSetTableAdapters.HobbiesTableAdapter();
        Repeater1.DataSource = dt.HobbyList();
        Repeater1.DataBind();
    }
}