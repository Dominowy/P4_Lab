using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace Lab._1
{
    public class ConnStr
    {
        public static string conn()
        {
            var connect = @"Data Source = SERVER ADDRESS; Initial Catalog = ZNorthwind; User ID = SA; Password = *******";
            return connect;
        }
    }
}