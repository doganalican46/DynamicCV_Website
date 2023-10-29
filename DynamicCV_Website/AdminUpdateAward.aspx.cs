using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminUpdateAward : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.AwardsTableAdapter dt = new DataSetTableAdapters.AwardsTableAdapter();
        int x = Convert.ToInt16(Request.QueryString["ID"]);
        txtID.Text = x.ToString();

        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.AwardsTableAdapter dt1 = new DataSetTableAdapters.AwardsTableAdapter();

            txtAward.Text = dt1.GetAward(Convert.ToInt16(x))[0].Awards;

        }
    }

    protected void btnUpdateAward_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.AwardsTableAdapter dt = new DataSetTableAdapters.AwardsTableAdapter();
        dt.UpdateQuery(txtAward.Text, Convert.ToInt16(txtID.Text));
        Response.Redirect("AdminAwards.Aspx");
    }
}