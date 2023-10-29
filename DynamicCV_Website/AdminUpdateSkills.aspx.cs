using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminUpdateSkills : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        DataSetTableAdapters.SkillsTBLTableAdapter dt = new DataSetTableAdapters.SkillsTBLTableAdapter();
        int x = Convert.ToInt16(Request.QueryString["ID"]);
        txtID.Text = x.ToString();

        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.SkillsTBLTableAdapter dt1 = new DataSetTableAdapters.SkillsTBLTableAdapter();

            txtSkill.Text = dt1.GetSkills(Convert.ToInt16(x))[0].Skills;

        }
    }

    protected void btnUpdateSkills_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.SkillsTBLTableAdapter dt = new DataSetTableAdapters.SkillsTBLTableAdapter();
        dt.UpdateQuery(txtSkill.Text, Convert.ToInt16(txtID.Text));
        Response.Redirect("AdminHobbies.Aspx");
    }
}