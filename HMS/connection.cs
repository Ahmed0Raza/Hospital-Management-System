using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace HMS
{
    class connection
    {
        public static SqlConnection GetConnection()
        {
            string query = "Data Source=DESKTOP-AR8IVMB;Initial Catalog=Project_HMS;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(query);
            connection.Open();
            return connection;
        }

        static public SqlDataReader SqlReader(string query)
        {
            SqlCommand cmd = new SqlCommand(query, GetConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        static public SqlCommand SqlCmd(string query)
        {
            return new SqlCommand(query, GetConnection());
        }
    }
}
