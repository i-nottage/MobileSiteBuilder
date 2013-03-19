using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    private MySqlDataReader reader;
    private string results;

    protected void Page_Load(object sender, EventArgs e)
    {
        
        Bind();
    }

    private void Bind()
    {
        try
        {
            string _cnnString =
            "Server=us-cdbr-azure-east-b.cloudapp.net;Database=simpledb13;Uid=b43371f6ed282f;Pwd = spring2013;";
                 
            MySqlConnection cnx = new MySqlConnection(_cnnString);
            cnx.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string cmdText = "SELECT Administrator_ID, Administrator_UserName, Administrator_Password FROM administrator";
            MySqlCommand cmd = new MySqlCommand(cmdText, cnx);

            // Create the dataset
            DataSet ds = new DataSet();
            adapter.SelectCommand = cmd;
            adapter.Fill(ds);
            reader = cmd.ExecuteReader();
            AdminRepeater.DataSource = reader;
            AdminRepeater.DataBind();
            reader.Close();
            cnx.Close();


        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }
    }
}
