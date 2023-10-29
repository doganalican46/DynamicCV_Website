using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminDeleteAward : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["ID"]);
        DataSetTableAdapters.AwardsTableAdapter dt = new DataSetTableAdapters.AwardsTableAdapter();
        dt.DeleteQuery(Convert.ToInt16(x));
        Response.Redirect("AdminAwards.Aspx");
    }
}