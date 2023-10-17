using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.AboutTableAdapter dt = new DataSetTableAdapters.AboutTableAdapter();
        Repeater1.DataSource = dt.AboutList();
        Repeater1.DataBind();

        DataSetTableAdapters.ExperiencesTableAdapter dt2 = new DataSetTableAdapters.ExperiencesTableAdapter();
        Repeater2.DataSource = dt2.ExperienceList();
        Repeater2.DataBind();

        DataSetTableAdapters.EducationsTableAdapter dt3 = new DataSetTableAdapters.EducationsTableAdapter();
        Repeater3.DataSource = dt3.EducationList();
        Repeater3.DataBind();

        DataSetTableAdapters.SkillsTBLTableAdapter dt4 = new DataSetTableAdapters.SkillsTBLTableAdapter();
        Repeater4.DataSource = dt4.SkillList();
        Repeater4.DataBind();


        DataSetTableAdapters.HobbiesTableAdapter dt5 = new DataSetTableAdapters.HobbiesTableAdapter();
        Repeater5.DataSource = dt5.HobbyList();
        Repeater5.DataBind();

        DataSetTableAdapters.AwardsTableAdapter dt6 = new DataSetTableAdapters.AwardsTableAdapter();
        Repeater6.DataSource = dt6.AwardList();
        Repeater6.DataBind();
    }
}