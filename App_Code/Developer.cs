using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for Developer
/// </summary>
namespace DAL
{
    public class Developer
    {
        public static string _cnnString = "server=us-cdbr-azure-east-b.cloudapp.net;database=simpledb13;uid=b43371f6ed282f;pwd=spring2013";
        public static DataTable getAllDevelopers()
        {
            MySql.Data.MySqlClient.MySqlConnection mycon =
                    new MySqlConnection(_cnnString);
            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM developer", _cnnString);
                DataSet ds = new DataSet("developer");
                adp.Fill(ds, "developer");
                return ds.Tables["developer"];
            }
            catch (MySqlException ex)
            {
                throw (ex);
            }
        }

        public static void InsertDeveloper(string DevUserName, string DevPassword)
        {
            using (MySql.Data.MySqlClient.MySqlConnection mycon =
                    new MySqlConnection(_cnnString))
            {
                MySqlCommand commie = new MySqlCommand();
                MySqlDataAdapter adp = new MySqlDataAdapter(commie);
                commie.CommandText = "insert into developer (Developer_UserName,Developer_Password) values (@DevUserName, @DevPassword)";
                // Set the command type
                commie.CommandType = CommandType.Text;
                commie.Connection = mycon;
                // Set the text
                commie.Parameters.AddWithValue("@DevUserName", DevUserName);
                commie.Parameters.AddWithValue("@DevPassword", DevPassword);
                mycon.Open();
                commie.ExecuteNonQuery();
            }

        }
    }
}