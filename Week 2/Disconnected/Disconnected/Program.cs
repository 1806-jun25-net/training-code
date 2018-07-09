using System;
using System.Data;
using System.Data.SqlClient;

namespace Disconnected
{
    class Program
    {
        static void Main(string[] args)
        {
            // connected architecture with ADO.NET
            // needs nuget package System.Data.SqlClient
            var connectionString = "Server=tcp:escalona-1806.database.windows.net,1433;" +
                "Initial Catalog=MoviesDB;Persist Security Info=False;" +
                "User ID=escalona;Password={my_password};" +
                "MultipleActiveResultSets=False;Encrypt=True;" +
                "TrustServerCertificate=False;Connection Timeout=30;";

            var commandString = "SELECT * FROM Movies.Movie;";

            var dataSet = new DataSet();

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(commandString, connection))
                using (var adapter = new SqlDataAdapter(command))
                {
                    // we call Fill to get data from the db
                    // we call Update to push changes back to the db
                    adapter.Fill(dataSet);
                    // step 1 disconnected: open the connection
                    // step 2: execute query
                    // step 3: close the connection
                }
            }

            // step 4: process results
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                Console.WriteLine($"ID {row["ID"]}," +
                    $" Name {row["Name"]}");
            }
        }
    }
}
