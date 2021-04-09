using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace Lab._1
{
    public class ConnStr
    {
        public static string conn()
        {
            var connect = @"Data Source = localhost; Initial Catalog = NORTHWND; User ID = SA; Password = Polskatoja10";
            return connect;
        }
    }
}