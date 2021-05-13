using System;
using System.Data.Common;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab._2
{
    public class ConnStr
    {
        public static string conn()
        {
            var connect = @"Data Source = ServerAddress; Initial Catalog = NORTHWND; User ID = SA; Password = ***********";
            return connect;
        }
    }
}