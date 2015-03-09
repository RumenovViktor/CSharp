using System;
using System.Data.SqlClient;

namespace InsertWithADO.NET
{
    class Program
    {
        static void Main()
        {
            // Some existing database in SQL Server
            string connestionString = "Server=.\\SQLEXPRESS;" +
                                        "Database=Northwind;" +
                                        "Integrated Security=true";

            SqlConnection dbConnection = new SqlConnection(connestionString);
            dbConnection.Open();

            using (dbConnection)
            {
                InsertNewProduct(dbConnection,"Pesho", 1, 1, "Sharo e pich", 20M, 1, 1, 1, 0);

            }
            
        }

        private static void InsertNewProduct(SqlConnection dbConnection, string name, int supplier, int category, 
            string quantityPerUnit, decimal unitPrice, int unitsInStock, int unitsOnOrder, int recordLevel, int discontinued)
        {
            string sqlCommand = "INSERT INTO Products " +
                "(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued)" +
                "VALUES (@name, @supplier, @category, @quantityPerUnit, @unitPrice, @unitsInStock, @unitsOnOrder, @recordLevel, @discontinued)";

            SqlCommand command = new SqlCommand(sqlCommand, dbConnection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@supplier", supplier);
            command.Parameters.AddWithValue("@category", category);
            command.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
            command.Parameters.AddWithValue("@unitPrice", unitPrice);
            command.Parameters.AddWithValue("@unitsInStock", unitsInStock);
            command.Parameters.AddWithValue("@unitsOnOrder", unitsOnOrder);
            command.Parameters.AddWithValue("@recordLevel", recordLevel);
            command.Parameters.AddWithValue("@discontinued", discontinued);

            command.ExecuteNonQuery();
        }
    }
}
