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
    public class DataBase
    {
        private IDbConnection _connection;
        
        public DataBase(string connectionStr)
        {
            _connection = new SqlConnection(connectionStr);
        }

        public IEnumerable<Employees> GetEmployees()
        {
            return _connection.Query<Employees>("SELECT*FROM Employees");
        }
        
        public Employees GetEmployeesByID(int id)
        {
            return _connection.QuerySingleOrDefault<Employees>("SELECT*FROM Employees WHERE EmployeeID = @Id", new {Id = id});
        }
        
        public bool AddEmployees(Employees employees)
        {
            var result = _connection.Execute("INSERT INTO Employees(LastName, FirstName) VALUES (@lastName, @firstName)", 
                new {lastName = employees.LastName, firstName = employees.FirstName});
            return result == 1;
        }
        
        public Employees DropEmployees(int id)
        {
            var result = _connection.QuerySingleOrDefault<Employees>("DELETE Employees WHERE EmployeeID = @Id", new { Id = id });
            _connection.Execute($"DBCC CHECKIDENT ( 'Employees', reseed , {id - 1})"); // reset auto increment
            return result;
        }
        
        public Employees UpdateEmpoyee(int id, string employeeName)
        {

            return _connection.QuerySingleOrDefault<Employees>("UPDATE Employees SET FirstName = @firstName WHERE EmployeeID = @Id", new { Id = id, firstName = employeeName });

        }
    }
}