using System;
using System.Data.OleDb;

namespace _05.DisconnectedModel
{
    public class Program
    {
        static void Main()
        {
            // Some existing database
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                                            @"Data Source=C:\Users\Viktor\Desktop\Base.xlsx;Extended Properties=Excel 12.0;";

            OleDbConnection dbConnetion = new OleDbConnection(connectionString);
            dbConnetion.Open();

            using (dbConnetion)
            {
                string oleCommand = "SELECT * FROM [Sheet1$]";
                OleDbCommand command = new OleDbCommand(oleCommand, dbConnetion);

                OleDbDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string name = (string) reader["N"];
                        string nums = (string)reader["Z"];

                        Console.WriteLine(name);
                        Console.WriteLine(nums);
                    }
                }
            }
        }
    }
}
