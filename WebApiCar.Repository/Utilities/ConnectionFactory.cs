using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace WebApiCar.Repository.Utilities
{
    public class ConnectionFactory
    {
        private static string _sqlConnection =
            "server=191.234.179.75;database=DeveloperDB03;user=developers;password=dev123DEV123";


        public static SqlConnection GetConnection()
        {
            var conn = new SqlConnection(_sqlConnection);

            conn.Open();

            return conn;
        }
    }
}
