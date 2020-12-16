using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using SE256_RazorFinal_MattG.Models;
using Microsoft.Extensions.Configuration;

namespace SE256_RazorFinal_MattG.Models
{
    public class SongDataAccessLayer
    {


        string connectionString;

        private readonly IConfiguration _configuration;

        public SongDataAccessLayer(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public void Create(SongModel Song)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Songs (Song_Title, Song_Artist, Song_PlayTime, Song_Rating, Song_Date,  Song_Owned, Artist_Email, Artist_Website) VALUES (@Song_Title, @Song_Artist, @Song_PlayTime, @Song_Rating, @Song_Date, @Song_Owned, @Artist_Email, @Artist_Website)";

                Song.Feedback = "";

                try
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.Text;


                        command.Parameters.AddWithValue("@Song_Title", Song.Song_Title);
                        command.Parameters.AddWithValue("@Song_Artist", Song.Song_Artist);
                        command.Parameters.AddWithValue("@Song_PlayTime", Song.Song_PlayTime);
                        command.Parameters.AddWithValue("@Song_Rating", Song.Song_Rating);
                        command.Parameters.AddWithValue("@Song_Date", Song.Song_Date);
                        command.Parameters.AddWithValue("@Song_Owned", Song.Song_Owned);
                        command.Parameters.AddWithValue("@Artist_Email", Song.Artist_Email);
                        command.Parameters.AddWithValue("@Artist_Website", Song.Artist_Website);

                        connection.Open();

                        Song.Feedback = command.ExecuteNonQuery().ToString() + "Record Added";

                        connection.Close();
                    }

                }
                catch (Exception err)
                {
                    Song.Feedback = "ERROR: " + err.Message;
                }
            }
        }

        public IEnumerable<SongModel> GetActiveRecords()
        {
            List<SongModel> lstSong = new List<SongModel>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSQL = "SELECT * FROM Songs ORDER BY Song_ID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.CommandType = CommandType.Text;

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        SongModel song = new SongModel();

                        song.Song_ID = Convert.ToInt32(rdr["Song_ID"]);
                        song.Song_Title = rdr["Song_Title"].ToString();
                        song.Song_Artist = rdr["Song_Artist"].ToString();
                        song.Song_PlayTime = rdr["Song_PlayTime"].ToString();
                        song.Song_Rating = Decimal.Parse(rdr["Song_Rating"].ToString());
                        song.Song_Date = DateTime.Parse(rdr["Song_Date"].ToString());
                        //DateTime.Parse(rdr["Song_Date"].ToString());
                        song.Song_Owned = Convert.ToBoolean(Convert.ToInt16(rdr["Song_Owned"].ToString()));
                        song.Artist_Email = rdr["Artist_Email"].ToString();
                        song.Artist_Website = rdr["Artist_Website"].ToString();

                        lstSong.Add(song);

                    }
                    con.Close();
                }
            }
            catch(Exception err)
            {
             
            }
            return lstSong;
        }

        public SongModel GetOneRecord(int? id)
        {
            SongModel song = new SongModel();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSQL = "SELECT * FROM Songs WHERE Song_ID = @Song_ID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.CommandType = CommandType.Text;

                    

                    cmd.Parameters.AddWithValue("@Song_ID", id);

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {

                        song.Song_ID = Convert.ToInt32(rdr["Song_ID"]);
                        song.Song_Title = rdr["Song_Title"].ToString();
                        song.Song_Artist = rdr["Song_Artist"].ToString();
                        song.Song_PlayTime = rdr["Song_PlayTime"].ToString();
                        song.Song_Rating = Decimal.Parse(rdr["Song_Rating"].ToString());
                        song.Song_Date = DateTime.Parse(rdr["Song_Date"].ToString());
                        song.Song_Owned = Convert.ToBoolean(Convert.ToInt16(rdr["Song_Owned"].ToString()));
                        song.Artist_Email = rdr["Artist_Email"].ToString();
                        song.Artist_Website = rdr["Artist_Website"].ToString();


                    }
                    con.Close();
                }
            }
            catch (Exception err)
            {
                song.Feedback = "ERROR: " + err.Message;
            }
            return song;
        }

        public void UpdateTicket(SongModel sSong)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();

                    string strSQL = "UPDATE Songs SET Song_Title = @Song_Title, Song_Artist = @Song_Artist, Song_PlayTime = @Song_PlayTime, Song_Rating = @Song_Rating, Song_Date = @Song_Date, Song_Owned = @Song_Owned, Artist_Email = @Artist_Email, Artist_Website = @Artist_Website WHERE Song_ID = @Song_ID;";

                    cmd.CommandText = strSQL;
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Song_Title", sSong.Song_Title);
                    cmd.Parameters.AddWithValue("@Song_Artist", sSong.Song_Artist);
                    cmd.Parameters.AddWithValue("@Song_PlayTime", sSong.Song_PlayTime);
                    cmd.Parameters.AddWithValue("@Song_Rating", sSong.Song_Rating);
                    cmd.Parameters.AddWithValue("@Song_Date", sSong.Song_Date);
                    cmd.Parameters.AddWithValue("@Song_Owned", sSong.Song_Owned);
                    cmd.Parameters.AddWithValue("@Artist_Email", sSong.Artist_Email);
                    cmd.Parameters.AddWithValue("@Artist_Website", sSong.Artist_Website);
                    cmd.Parameters.AddWithValue("@Song_ID", sSong.Song_ID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch(Exception err)
            {
                sSong.Feedback = "ERROR: " + err.Message;
            }
        }
        public SongModel DeleteTicket(int? id)
        {
            SongModel song = new SongModel();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSQL = "DELETE FROM Songs WHERE Song_ID = @Song_ID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@Song_ID", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch(Exception err)
            {
                song.Feedback = "ERROR: " + err.Message;
            }
            return song;
        }
    }
}
