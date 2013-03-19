using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for Text
/// </summary>
namespace DAL
{
    public class Text
    {
        public static string _cnnString = "server=us-cdbr-azure-east-b.cloudapp.net;database=simpledb13;uid=b43371f6ed282f;pwd=spring2013";
        public static DataTable getAllText()
        {
            MySql.Data.MySqlClient.MySqlConnection mycon =
                    new MySqlConnection(_cnnString);
            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM text", _cnnString);
                DataSet ds = new DataSet("text");
                adp.Fill(ds, "text");
                return ds.Tables["text"];
            }
            catch (MySqlException ex)
            {
                throw (ex);
            }
        }

        public static void InsertText(string TextValue, int TextPageID, string TextWidth, string TextHeight, int TextX, int TextY, string TextBackground, string TextColor, string TextFontWeight, string TextAlign)
        {
            using (MySql.Data.MySqlClient.MySqlConnection mycon =
                    new MySqlConnection(_cnnString))
            {
                MySqlCommand commie = new MySqlCommand();
                MySqlDataAdapter adp = new MySqlDataAdapter(commie);
                commie.CommandText = "insert into link (Text_Value,Text_PageID,Text_Width,Text_Height,Text_X,Text_Y,Text_Background,Text_Color,Text_FontWeight,Text_Align)"
                        + "values (@TextValue, @TextPageID,@TextWidth,@TextHeight,@TextX,@TextY,@TextBackground,@TextColor,@TextFontWeight,@TextAlign)";
                // Set the command type
                commie.CommandType = CommandType.Text;
                commie.Connection = mycon;
                // Set the text
                commie.Parameters.AddWithValue("@TextValue", TextValue);
                commie.Parameters.AddWithValue("@TextPageID", TextPageID);
                commie.Parameters.AddWithValue("@TextWidth", TextWidth);
                commie.Parameters.AddWithValue("@TextHeight", TextHeight);
                commie.Parameters.AddWithValue("@TextX", TextX);
                commie.Parameters.AddWithValue("@TextY", TextY);
                commie.Parameters.AddWithValue("@TextBackground", TextBackground);
                commie.Parameters.AddWithValue("@TextColor", TextColor);
                commie.Parameters.AddWithValue("@TextFontWeight", TextFontWeight);
                commie.Parameters.AddWithValue("@TextAlign", TextAlign);
                mycon.Open();
                commie.ExecuteNonQuery();
            }

        }
    }
}