using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminDeleteSkills : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["ID"]);
        DataSetTableAdapters.SkillsTBLTableAdapter dt = new DataSetTableAdapters.SkillsTBLTableAdapter();
        dt.DeleteQuery(Convert.ToInt16(x));
        Response.Redirect("AdminSkills.Aspx");
    }
}