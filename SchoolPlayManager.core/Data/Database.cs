using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;

namespace SchoolPlayManager.core.Data
{
    public class Database
    {
        private string connectionString = "Data Source=database.db";

        public SqliteConnection GetConnection()
        {
            return new SqliteConnection(connectionString);
        }

        public void Initialize()
        {
            using (var connection = GetConnection()) 
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL,
                        PasswordHash TEXT NOT NULL
                    );
                ";
                command.ExecuteNonQuery();
            }

        }
    }

}
