using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateSite : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CreateSiteButton_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            DAL.SiteDT test = new DAL.SiteDT();
            test = DAL.Site.getSiteByName(SiteNameTextBox.Text, 1);
            if (test.SiteName == null)
            {
                try
                {
                    // Insert Site Name in using Stored Procedure
                    DAL.Site.InsertSite(SiteNameTextBox.Text, 1);
                    SuccessLabel.Text = "Site created successfully!";
                    SiteNameTextBox.Text = "";
                }
                catch (Exception ex)
                {
                    SuccessLabel.Text = ex.Message;
                }
                // Reset Page
            }
            else
            {
                SuccessLabel.Text = "Site Name already in use. Try another name.";
                SiteNameTextBox.Text = "";
                
            }
        }
    }
}