using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminUpdateExperience : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["ID"]);
        txtID.Enabled = false;
        txtID.Text = x.ToString();


        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.ExperiencesTableAdapter dt = new DataSetTableAdapters.ExperiencesTableAdapter();
            txtTittle.Text = dt.GetExperience(Convert.ToInt16(x))[0].Tittle;
            txtSubtittle.Text = dt.GetExperience(Convert.ToInt16(x))[0].Subtittle;
            txtDescription.Text = dt.GetExperience(Convert.ToInt16(x))[0].Description;
            txtDate.Text = dt.GetExperience(Convert.ToInt16(x))[0].Date;
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.ExperiencesTableAdapter dt = new DataSetTableAdapters.ExperiencesTableAdapter();
        dt.UpdateQuery(txtTittle.Text, txtSubtittle.Text, txtDescription.Text, txtDate.Text, Convert.ToInt16(txtID.Text));
        Response.Redirect("AdminExperience.Aspx");
    }
}