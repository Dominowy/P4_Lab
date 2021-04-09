using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace Lab._1
{
    class Program
    {
        static void Main(string[] args)
        {
            using SqlConnection connection = new SqlConnection(ConnStr.conn());
            
            connection.Open();
            
            Polecenia.Drop(connection);

            connection.Close();

        }
    }
}