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
    public class SongAdminDataAccessLayer
    {

        string connectionString;

        private readonly IConfiguration _configuration;

        public SongAdminDataAccessLayer(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IEnumerable<SongAdmin> GetAdminLogin(SongAdmin sAdmin)
        {
            List<SongAdmin> lstSongAdmin = new List<SongAdmin>();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSQL = "SELECT TOP 1 * FROM SongAdmin_Registry WHERE SongAdmin_Email = @SongAdmin_Email AND SongAdmin_PW = @SongAdmin_PW;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.CommandType = CommandType.Text;


                    cmd.Parameters.AddWithValue("@SongAdmin_Email", sAdmin.SongAdmin_Email);
                    cmd.Parameters.AddWithValue("@SongAdmin_PW", sAdmin.SongAdmin_PW);


                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        SongAdmin sMatch = new SongAdmin();

                        sMatch.SongAdmin_ID = Convert.ToInt32(rdr["SongAdmin_ID"]);
                        sMatch.SongAdmin_Email = rdr["SongAdmin_Email"].ToString();
                        sMatch.SongAdmin_PW = rdr["SongAdmin_PW"].ToString();

                        lstSongAdmin.Add(sMatch);
                    }

                    con.Close();
                }

            }
            catch (Exception err)
            {
                //
            }
            return lstSongAdmin;
        }
    }
}
