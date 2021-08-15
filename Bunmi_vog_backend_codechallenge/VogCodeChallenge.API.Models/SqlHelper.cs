using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace VogCodeChallenge.API.Models
{
    public class SqlHelper
    {
        //this field gets initialized at Startup.cs
        public static string connectionString;

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
