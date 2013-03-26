using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateDeveloper : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void RegisterButton_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            try
            {
                DAL.Developer.InsertDeveloper(UserNameTextBox.Text, ConfirmPasswordTextBox.Text);
                SuccessLabel.Text = "Your account was created successfully!";
            }
            catch (Exception ex)
            {
                SuccessLabel.Text = ex.Message;
            }
            UserNameTextBox.Text = "";
            PasswordTextBox.Text = "";
            ConfirmPasswordTextBox.Text = "";
        }
    }
}