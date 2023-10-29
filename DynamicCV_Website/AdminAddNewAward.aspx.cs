using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminAddNewAward : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSaveAward_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.AwardsTableAdapter dt = new DataSetTableAdapters.AwardsTableAdapter();
        dt.InsertQuery(txtAward.Text);
        Response.Redirect("AdminAwards.Aspx");
    }
}