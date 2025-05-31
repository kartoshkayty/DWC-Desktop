using System;
using System.Data.SQLite;
using System.IO;

namespace DWC_Desktop.Database
{
    public static class DB
    {
        private static SQLiteConnection connection;
        private static bool inited = false;

        public static void Init()
        {
            if (inited) return;

            string appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appPath = Path.Combine(appdataPath, "DWC");

            if (!Directory.Exists(appPath)) 
            { 
                Directory.CreateDirectory(appPath);
            }

            string dbFilePath = Path.Combine(appPath, "dwc.db");

            if (!File.Exists(dbFilePath))
            {
                File.Create(dbFilePath).Close();
            }

            connection = new SQLiteConnection($"Data Source={dbFilePath}");
            connection.Open();

            SQLiteCommand cmd = connection.CreateCommand();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Users (email TEXT PRIMARY KEY, token TEXT);";
            cmd.ExecuteNonQuery();

            inited = true;
        }

        public static SQLiteConnection GetConnection()
        {
            if (!inited) throw new Exception("Connection not inited!");

            return connection;
        }
    }
}
