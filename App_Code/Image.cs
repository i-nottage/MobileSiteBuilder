using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for Image
/// </summary>
namespace DAL
{
    public class Image
    {
        public static string _cnnString = "server=us-cdbr-azure-east-b.cloudapp.net;database=simpledb13;uid=b43371f6ed282f;pwd=spring2013";
        public static DataTable getAllImages()
        {
            MySql.Data.MySqlClient.MySqlConnection mycon =
                    new MySqlConnection(_cnnString);
            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM image", _cnnString);
                DataSet ds = new DataSet("image");
                adp.Fill(ds, "image");
                return ds.Tables["image"];
            }
            catch (MySqlException ex)
            {
                throw (ex);
            }
        }

        public static void InsertImage(string ImageFile, int ImagePageID, string ImageWidth, string ImageHeight, int ImageX, int ImageY, string ImageAlt)
        {
            using (MySql.Data.MySqlClient.MySqlConnection mycon =
                    new MySqlConnection(_cnnString))
            {
                MySqlCommand commie = new MySqlCommand();
                MySqlDataAdapter adp = new MySqlDataAdapter(commie);
                commie.CommandText = "insert into image (Image_File,Image_PageID,Image_Width,Image_Height,Image_X,Image_Y,Image_Alt)"
                        + "values (@ImageFile, @ImagePageID,@ImageWidth,@ImageHeight,@ImageX,@ImageY,@ImageAlt)";
                // Set the command type
                commie.CommandType = CommandType.Text;
                commie.Connection = mycon;
                // Set the text
                commie.Parameters.AddWithValue("@ImageFile", ImageFile);
                commie.Parameters.AddWithValue("@ImagePageID", ImagePageID);
                commie.Parameters.AddWithValue("@ImageWidth", ImageWidth);
                commie.Parameters.AddWithValue("@ImageHeight", ImageHeight);
                commie.Parameters.AddWithValue("@ImageX", ImageX);
                commie.Parameters.AddWithValue("@ImageY", ImageY);
                commie.Parameters.AddWithValue("@ImageAlt", ImageAlt);
                mycon.Open();
                commie.ExecuteNonQuery();
            }

        }
    }
}