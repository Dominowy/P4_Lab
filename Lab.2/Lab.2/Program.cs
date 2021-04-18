using System;
using System.Data.Common;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DataBase(ConnStr.conn());
            
            // db.AddEmployees(new Employees() {FirstName = "Maciej", LastName = "Katana"});
            //
            // db.DropEmployees(10);
            //
            // db.UpdateEmpoyee(10, "Maciej");
            //
            // Console.WriteLine();
            
            foreach (Employees employees in db.GetEmployees())
            {
                Console.WriteLine($"{employees.EmployeeID}: {employees.LastName}, {employees.FirstName}");
            }
            
            Console.WriteLine();
            
            var singleEmployees = db.GetEmployeesByID(10);
            Console.WriteLine($"{singleEmployees.EmployeeID}: {singleEmployees.LastName}, {singleEmployees.FirstName}");
        }
    }
}