using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminSkills : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.SkillsTBLTableAdapter dt = new DataSetTableAdapters.SkillsTBLTableAdapter();
        Repeater1.DataSource = dt.SkillList();
        Repeater1.DataBind();
    }
}