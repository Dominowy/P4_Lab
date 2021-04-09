using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace Lab._1
{
    public class Polecenia
    {
        public static void Show(SqlConnection connection)
        {
            var dbSelect = $"SELECT * FROM dbo.Customers";
            var query = new SqlCommand(dbSelect, connection);
            var inReturn = query.ExecuteReader();
            
            foreach (DbDataRecord item in inReturn)
            {
                Console.WriteLine(item.GetString(0) + " " + item.GetString(1));
            }
            Console.WriteLine();
        }

        public static void Insert(SqlConnection connection)
        {
            string customerId = "DOMI";
            string companyName = "Domino";
            
            var dbInsert = $"INSERT INTO dbo.Customers (CustomerID, CompanyName) VALUES (@ID, @CompanyName)";
            var query = new SqlCommand(dbInsert, connection);
            query.Parameters.Add(new SqlParameter("@ID", customerId));
            query.Parameters.Add(new SqlParameter("@CompanyName", companyName));
            query.ExecuteNonQuery();
        }
        
        public static void Update(SqlConnection connection)
        {
            string customerId = "DOMI";
            string companyName = "Domino2";
            
            var dbUpdate = $"UPDATE dbo.Customers SET CompanyName = @CompanyName WHERE CustomerID = @ID";
            var query = new SqlCommand(dbUpdate, connection);
            query.Parameters.Add(new SqlParameter("@CompanyName", companyName));
            query.Parameters.Add(new SqlParameter("@ID", "DOMI"));
            query.ExecuteNonQuery();
        }

        public static void Drop(SqlConnection connection)
        {
            string customerId = "DOMI";
            
            var dbDrop = $"DELETE FROM dbo.Customers WHERE CustomerID = @ID";
            var query = new SqlCommand(dbDrop, connection);
            query.Parameters.Add(new SqlParameter("@ID", customerId));
            query.ExecuteNonQuery();
        }
    }
}