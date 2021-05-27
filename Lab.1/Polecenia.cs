using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace Lab._1
{
    public class Polecenia
    {
        public static void Show(SqlConnection connection)
        {
            var dbSelect = $"SELECT * FROM dbo.Klienci";
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
            var customerId = 10;
            string secondName = "katana";
            string name = "dominik";
            
            var dbInsert = $"INSERT INTO dbo.Pracownicy (IDpracownika, Nazwisko, Imię) VALUES (@Id, @SecondName, @Name)";
            var query = new SqlCommand(dbInsert, connection);
            query.Parameters.Add(new SqlParameter("@Id", customerId));
            query.Parameters.Add(new SqlParameter("@SecondName", secondName));
            query.Parameters.Add(new SqlParameter("@Name", name));
            query.ExecuteNonQuery();
        }
        
        public static void Update(SqlConnection connection)
        {
            var customerId = 10;
            string secondName = "Katana";
            string name = "Dominik";
            
            var dbUpdate = $"UPDATE dbo.Pracownicy SET Nazwisko = @CompanyName, Imię = @Imie WHERE IDpracownika = @Id";
            var query = new SqlCommand(dbUpdate, connection);
            query.Parameters.Add(new SqlParameter("@CompanyName", secondName));
            query.Parameters.Add(new SqlParameter("@Id", customerId));
            query.Parameters.Add(new SqlParameter("@Imie", name));
            query.ExecuteNonQuery();
        }

        public static void Drop(SqlConnection connection)
        {
            var customerId = 10;
            
            var dbDrop = $"DELETE FROM dbo.Pracownicy WHERE IDpracownika = @ID";
            var query = new SqlCommand(dbDrop, connection);
            query.Parameters.Add(new SqlParameter("@ID", customerId));
            query.ExecuteNonQuery();
        }
    }
}