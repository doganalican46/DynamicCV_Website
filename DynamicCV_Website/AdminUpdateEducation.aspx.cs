using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminUpdateEducation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["ID"]);
        txtID.Enabled = false;
        txtID.Text = x.ToString();


        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.EducationsTableAdapter dt = new DataSetTableAdapters.EducationsTableAdapter();
            txtTittle.Text = dt.GetEducation(Convert.ToInt16(x))[0].Tittle;
            txtSubtittle.Text = dt.GetEducation(Convert.ToInt16(x))[0].Subtittle;
            txtDescription.Text = dt.GetEducation(Convert.ToInt16(x))[0].Description;
            txtGpa.Text = dt.GetEducation(Convert.ToInt16(x))[0].GPA;
            txtDate.Text = dt.GetEducation(Convert.ToInt16(x))[0].Date;
        }
    }


    protected void btnUpdate_Click1(object sender, EventArgs e)
    {
        DataSetTableAdapters.EducationsTableAdapter dt = new DataSetTableAdapters.EducationsTableAdapter();
        dt.UpdateQuery(txtTittle.Text, txtSubtittle.Text, txtDescription.Text, txtGpa.Text, txtDate.Text, Convert.ToInt16(txtID.Text));
        Response.Redirect("AdminEducations.Aspx");
    }
}