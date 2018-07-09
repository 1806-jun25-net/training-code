using System;
using System.Data.SqlClient;

namespace Connected
{
    class Program
    {
        static void Main(string[] args)
        {
            //connected architecture with ADO.Net
            //needs nuget package System.Data.SqlClient;
            var connectionString = "Server = tcp:knain - 1806.database.windows.net,1433; Initial Catalog = MoviesDB; Persist Security Info = False; " +
                "User ID = knain; Password = Wayne24620; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";

            var commandString = "Select * from MoviesDB.Movie;";
            var userInput = "Wayne";
            //var malicious = "Wayne\"); Drop DataBase MoviesDB;";
            var CommandString2 = "Insert into Movies.Genre $Values(\"" + userInput + "\")";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open(); //step 1: open connection
                using (var command = new SqlCommand(commandString, connection))
                //step 2: execute query
                //if a select statement use ExecuteReader
                //otherwise use ExecuteNonquery
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        //step 3: process results
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["ID"]}, Name: {reader["Name"]}");
                        };
                    }
                }
                connection.Close();
            }
        }
    }
}
