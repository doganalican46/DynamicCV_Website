using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminExperience : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.ExperiencesTableAdapter dt = new DataSetTableAdapters.ExperiencesTableAdapter();
        Repeater1.DataSource = dt.ExperienceList();
        Repeater1.DataBind();
    }
}