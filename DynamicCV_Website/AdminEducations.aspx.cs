using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminEducations : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.EducationsTableAdapter dt = new DataSetTableAdapters.EducationsTableAdapter();
        Repeater1.DataSource=dt.EducationList();
        Repeater1.DataBind();
    }
}