using System;
using System.Data.SqlClient;

namespace _02.CategoryAndName
{
    class Program
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
                string sqlCommand = "SELECT p.ProductName AS Name, c.CategoryName " +
                                      "FROM Products p " +
                                        "INNER JOIN Categories c " +
                                            "ON p.CategoryID = c.CategoryID " +
                                                "ORDER BY c.CategoryName";

                SqlCommand command = new SqlCommand(sqlCommand, dbConnection);
                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string productName = (string)reader["Name"];
                        string category = (string)reader["CategoryName"];

                        Console.WriteLine("Name: {0}\nCategory: {1}\n", productName, category);
                    }
                }
            }
        }
    }
}
