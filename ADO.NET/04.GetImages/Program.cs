using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace _04.GetImages
{
    public class Program
    {
        // Some existing database in SQL Server
        private const string CONNECTION_STRING = "Server=.\\SQLEXPRESS;" +
                                      "Database=Northwind;" +
                                      "Integrated Security=true;";
        static void Main()
        {
            List<byte[]> images;
            ExtractImagesFromDB(out images);
            string imgDestination = @"..\..\logo-from";

            for (int i = 0; i < images.Count; i++)
            {
                string file = imgDestination + i + ".Jpeg";
                WriteBinaryFile(file, images[i]);
            }
        }

        private static void ExtractImagesFromDB(out List<byte[]> images)
        {
            SqlConnection dbConnection = new SqlConnection(CONNECTION_STRING);
            images = new List<byte[]>();

            dbConnection.Open();

            using (dbConnection)
            {
                string sqlCommand = "SELECT Picture FROM Categories";

                SqlCommand command = new SqlCommand(sqlCommand, dbConnection);
                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        images.Add((byte[])reader["Picture"]);
                    }
                }
            }
        }

        private static void WriteBinaryFile(string fileName, byte[] fileContents)
        {
            FileStream stream = File.OpenWrite(fileName);

            using (stream)
            {
                stream.Write(fileContents, 0, fileContents.Length);
            }
        }
    }
}
