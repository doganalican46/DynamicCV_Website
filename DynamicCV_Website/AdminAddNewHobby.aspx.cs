using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminAddNewHobby : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnSaveSkills_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.SkillsTBLTableAdapter dt = new DataSetTableAdapters.SkillsTBLTableAdapter();
        dt.InsertQuery(txtHobby.Text);
        Response.Redirect("AdminSkills.Aspx");
    }
}