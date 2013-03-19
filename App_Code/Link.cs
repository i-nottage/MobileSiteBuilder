using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for Link
/// </summary>
namespace DAL
{
    public class Link
    {
        public static string _cnnString = "server=us-cdbr-azure-east-b.cloudapp.net;database=simpledb13;uid=b43371f6ed282f;pwd=spring2013";
        public static DataTable getAllLinks()
        {
            MySql.Data.MySqlClient.MySqlConnection mycon =
                    new MySqlConnection(_cnnString);
            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM link", _cnnString);
                DataSet ds = new DataSet("link");
                adp.Fill(ds, "link");
                return ds.Tables["link"];
            }
            catch (MySqlException ex)
            {
                throw (ex);
            }
        }

        public static void InsertLink(string LinkValue, string LinkHref, int LinkPageID, int LinkWidth, int LinkHeight, int LinkX, int LinkY, string LinkBackground, string LinkColor, string LinkFontWeight, string LinkAlign)
        {
            using (MySql.Data.MySqlClient.MySqlConnection mycon =
                    new MySqlConnection(_cnnString))
            {
                MySqlCommand commie = new MySqlCommand();
                MySqlDataAdapter adp = new MySqlDataAdapter(commie);
                commie.CommandText = "insert into link (Link_Value,Link_Href,Link_PageID,Link_Width,Link_Height,Link_X,Link_Y,Link_Background,Link_Color,Link_FontWeight,Link_Align)"
                        + "values (@LinkValue, @LinkHref, @LinkPageID,@LinkWidth,@LinkHeight,@LinkX,@LinkY,@LinkBackground,@LinkColor,@LinkFontWeight,@LinkAlign)";
                // Set the command type
                commie.CommandType = CommandType.Text;
                commie.Connection = mycon;
                // Set the text
                commie.Parameters.AddWithValue("@LinkValue", LinkValue);
                commie.Parameters.AddWithValue("@LinkHref", LinkHref);
                commie.Parameters.AddWithValue("@LinkPageID", LinkPageID);
                commie.Parameters.AddWithValue("@LinkWidth", LinkWidth);
                commie.Parameters.AddWithValue("@LinkHeight", LinkHeight);
                commie.Parameters.AddWithValue("@LinkX", LinkX);
                commie.Parameters.AddWithValue("@LinkY", LinkY);
                commie.Parameters.AddWithValue("@LinkBackground", LinkBackground);
                commie.Parameters.AddWithValue("@LinkColor", LinkColor);
                commie.Parameters.AddWithValue("@LinkFontWeight", LinkFontWeight);
                commie.Parameters.AddWithValue("@LinkAlign", LinkAlign);
                mycon.Open();
                commie.ExecuteNonQuery();
            }

        }
    }
}