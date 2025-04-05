﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace SafeSharp
{
    public static class DatabaseHelper
    {
        private static string dbPath = "safesharp.db";
        private static string connectionString = $"Data Source={dbPath};Version=3;";

        // Create the DB file and table if they don't exist
        public static void InitializeDatabase()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string createTableQuery = @"
                    CREATE TABLE Passwords (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Date TEXT NOT NULL,
                        Website TEXT NOT NULL,
                        Username TEXT NOT NULL,
                        Password TEXT NOT NULL
                    );";
                    using (var cmd = new SQLiteCommand(createTableQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        // Save a password entry to the database
        public static void SavePassword(string date, string website, string username, string password)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Passwords (Date, Website, Username, Password) VALUES (@date, @website, @username, @password)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@website", website);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // You can encrypt here later
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Load all password entries from the database
        public static List<(string Date, string Website, string Username, string Password)> LoadPasswords()
        {
            var list = new List<(string, string, string, string)>();
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Date, Website, Username, Password FROM Passwords";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add((
                            reader["Date"].ToString(),
                            reader["Website"].ToString(),
                            reader["Username"].ToString(),
                            reader["Password"].ToString()
                        ));
                    }
                }
            }
            return list;
        }
    }
}
