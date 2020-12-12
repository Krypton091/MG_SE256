using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using SE256_RazorLab_MattG.Models;

using Microsoft.Extensions.Configuration;

namespace SE256_RazorLab_MattG.Models
{
    public class MonitorDataAccessLayer
    {
        string connectionString;

        private readonly IConfiguration _configuration;

        public MonitorDataAccessLayer(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public void Create(MonitorModel monitor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Monitors (Monitor_Name, Monitor_Price, Monitor_Panel, Monitor_RefreshRate, Monitor_Brand,  Monitor_Size) VALUES (@Monitor_Name, @Monitor_Price, @Monitor_Panel, @Monitor_RefreshRate, @Monitor_Brand, @Monitor_Size)";

                monitor.Feedback = "";

                try
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.Text; 

                       
                        command.Parameters.AddWithValue("@Monitor_Name", monitor.Monitor_Name);
                        command.Parameters.AddWithValue("@Monitor_Price", monitor.Monitor_Price);
                        command.Parameters.AddWithValue("@Monitor_Panel", monitor.Monitor_Panel);
                        command.Parameters.AddWithValue("@Monitor_RefreshRate", monitor.Monitor_RefreshRate);
                        command.Parameters.AddWithValue("@Monitor_Brand", monitor.Monitor_Brand);
                        command.Parameters.AddWithValue("@Monitor_Size", monitor.Monitor_Size);

                        connection.Open();

                        monitor.Feedback = command.ExecuteNonQuery().ToString() + "Record Added";

                        connection.Close();
                    }
                    
                }
                catch (Exception err)
                {
                    monitor.Feedback = "ERROR: " + err.Message;
                }
            }
        }
    }
}
