using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for Page
/// </summary>
namespace DAL
{
    public class Page
    {
        public static string _cnnString = "server=us-cdbr-azure-east-b.cloudapp.net;database=simpledb13;uid=b43371f6ed282f;pwd=spring2013";
        public static DataTable getAllPages()
        {
            MySql.Data.MySqlClient.MySqlConnection mycon =
                    new MySqlConnection(_cnnString);
            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM page", _cnnString);
                DataSet ds = new DataSet("page");
                adp.Fill(ds, "page");
                return ds.Tables["page"];
            }
            catch (MySqlException ex)
            {
                throw (ex);
            }
        }

        public static void InsertPage(int SiteID, string PageTitle, string PageBackground)
        {
            using (MySql.Data.MySqlClient.MySqlConnection mycon =
                    new MySqlConnection(_cnnString))
            {
                MySqlCommand commie = new MySqlCommand();
                MySqlDataAdapter adp = new MySqlDataAdapter(commie);
                commie.CommandText = "insert into page (Page_SiteID,Page_Title,Page_Background) values (@SiteID,@PageTitle, @PageBackground)";
                // Set the command type
                commie.CommandType = CommandType.Text;
                commie.Connection = mycon;
                // Set the text
                commie.Parameters.AddWithValue("@SiteID", SiteID);
                commie.Parameters.AddWithValue("@PageTitle", PageTitle);
                commie.Parameters.AddWithValue("@PageBackground", PageBackground);
                mycon.Open();
                commie.ExecuteNonQuery();
            }

        }
    }
}