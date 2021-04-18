using System;
using System.Data.Common;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Lab._2
{
    public class Employees
    {
        public int EmployeeID { set; get; }
        public string LastName { set; get; }
        public string FirstName { set; get; }
    }
}