using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminAwards : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.AwardsTableAdapter dt = new DataSetTableAdapters.AwardsTableAdapter();
        Repeater1.DataSource = dt.AwardList();
        Repeater1.DataBind();
    }
}