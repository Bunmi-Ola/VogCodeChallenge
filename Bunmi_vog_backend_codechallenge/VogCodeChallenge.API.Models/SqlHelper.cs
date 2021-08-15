using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace VogCodeChallenge.API.Models
{
    //Q6: part of database implementation process
    public class SqlHelper
    {
        //At the Startup.cs, ConfigurationExtensions.GetConnectionString is used
        //to get the sql connection. Then and it was assigned to SqlHelper.connectionString
        //Therefore, this field gets initialized at Startup.cs
        public static string connectionString;
        //SqlHelper.GetConnection() can now be used whenever there is a need for connection string
        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                return connection;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
