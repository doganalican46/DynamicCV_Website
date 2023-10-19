using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminDeleteExperience : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request.QueryString["ID"]);

        DataSetTableAdapters.ExperiencesTableAdapter dt = new DataSetTableAdapters.ExperiencesTableAdapter();
        dt.DeleteQuery(Convert.ToInt16(id));
        Response.Redirect("AdminExperience.Aspx");
    }
}