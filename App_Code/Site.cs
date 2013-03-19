using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for Site
/// </summary>
namespace DAL
{
    public class Site
    {
        public static string _cnnString = "server=us-cdbr-azure-east-b.cloudapp.net;database=simpledb13;uid=b43371f6ed282f;pwd=spring2013";
        public static DataTable getAllSites()
        {
            MySql.Data.MySqlClient.MySqlConnection mycon =
                    new MySqlConnection(_cnnString);
            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM site", _cnnString);
                DataSet ds = new DataSet("site");
                adp.Fill(ds, "site");
                return ds.Tables["site"];
            }
            catch (MySqlException ex)
            {
                throw (ex);
            }
        }

        public static SiteDT getSiteByName(string SiteName, int DevID)
        {
            DAL.SiteDT ds = new DAL.SiteDT();

            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT Site_ID,Site_Name,Site_DeveloperID FROM site where Site_Name LIKE @SiteName AND Site_DeveloperID = @DevID", _cnnString);
            adp.SelectCommand.Parameters.AddWithValue("@SiteName", SiteName + "%");
            adp.SelectCommand.Parameters.AddWithValue("@DevID", DevID);
            adp.SelectCommand.Connection.Open();
            MySqlDataReader dr;
            dr = adp.SelectCommand.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ds.SiteID = (int)dr["Site_ID"];
                    ds.SiteName = dr["Site_Name"].ToString();
                    ds.DeveloperID = (int)dr["Site_DeveloperID"];
                }
                //Close the connections
                dr.Close();
                adp.SelectCommand.Connection.Close();
            }

            return ds;
        }

        public static void InsertSite(string SiteName, int SiteDevID)
        {
            using (MySql.Data.MySqlClient.MySqlConnection mycon =
                    new MySqlConnection(_cnnString))
            {
                MySqlCommand commie = new MySqlCommand();
                MySqlDataAdapter adp = new MySqlDataAdapter(commie);
                commie.CommandText = "insert into site (Site_Name,Site_DeveloperID) values (@SiteName, @SiteDevID)";
                // Set the command type
                commie.CommandType = CommandType.Text;
                commie.Connection = mycon;
                // Set the text
                commie.Parameters.AddWithValue("@SiteName", SiteName);
                commie.Parameters.AddWithValue("@SiteDevID", SiteDevID);
                mycon.Open();
                commie.ExecuteNonQuery();
            }

        }
    }
}