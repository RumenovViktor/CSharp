using System;
using System.Data.SqlClient;

namespace _01.NumberOfRowsInCategories
{
    public class Program
    {
        static void Main()
        {
            // Some existing database in SQL Server
            string connectionString = "Server=.\\SQLEXPRESS;" +
                                        "Database=Northwind;" +
                                        "Integrated Security=true";

            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            using (dbConnection)
            {
                PrintCategoryNames(dbConnection);
            }
        }

        private static void PrintCategoryNames(SqlConnection dbConnection) 
        {
            string commandString = "SELECT CategoryName, Description FROM Categories";

            SqlCommand command = new SqlCommand(commandString, dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    string categoryName = (string)reader["CategoryName"];
                    string description = (string)reader["Description"];

                    Console.WriteLine("CategoryName: {0}\n" + "Description: {1}\n", categoryName, description);
                }
            }
        }
    }
}
