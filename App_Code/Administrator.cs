using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

/// <summary>
/// Summary description for Administrator
/// </summary>

namespace DAL
{

    public class Administrator
    {
        //public static string _cnnString = ConfigurationManager.ConnectionStrings["simpledb13"].ToString();
        public static string _cnnString = "server=us-cdbr-azure-east-b.cloudapp.net;database=simpledb13;uid=b43371f6ed282f;pwd=spring2013";
        public static DataTable getAllAdministrators()
        {
            MySql.Data.MySqlClient.MySqlConnection mycon =
                    new MySqlConnection(_cnnString);
                try
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM administrator", _cnnString);
                    DataSet ds = new DataSet("administrator");
                    adp.Fill(ds, "administrator");
                    return ds.Tables["administrator"];
                }
                catch (MySqlException ex)
                {
                    throw (ex);
                }
        }

        public static void InsertAdministrator(string AdminUserName, string AdminPassword) {
            using (MySql.Data.MySqlClient.MySqlConnection mycon =
                    new MySqlConnection(_cnnString))
            {
                MySqlCommand commie = new MySqlCommand();
                MySqlDataAdapter adp = new MySqlDataAdapter(commie);
                commie.CommandText = "insert into administrator (Administrator_UserName,Administrator_Password) values (@AdminUserName, @AdminPassword)";
                // Set the command type
                commie.CommandType = CommandType.Text;
                commie.Connection = mycon;
                // Set the text
                commie.Parameters.AddWithValue("@AdminUserName", AdminUserName);
                commie.Parameters.AddWithValue("@AdminPassword", AdminPassword);
                mycon.Open();
                commie.ExecuteNonQuery();
            }

        }
    }
}