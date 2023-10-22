using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminAddEducation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSaveEducation_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.EducationsTableAdapter dt = new DataSetTableAdapters.EducationsTableAdapter();
        dt.InsertQuery(txtTittle.Text,txtSubtittle.Text,txtDescription.Text,txtGpa.Text,txtDate.Text);
        Response.Redirect("AdminEducations.Aspx");
    }
}