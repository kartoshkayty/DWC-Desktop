using DWC_Desktop.Classes;
using DWC_Desktop.Database;
using System.Collections.Generic;
using System.Data.SQLite;

namespace DWC_Desktop.Utils
{
    public static class Users
    {
        public static List<LocalUser> GetUsers()
        {
            List<LocalUser> users = new List<LocalUser>();

            SQLiteConnection connection = DB.GetConnection();

            SQLiteCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM Users;";
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) 
            {
                string email = reader["email"].ToString();
                string token = reader["token"].ToString();

                LocalUser user = new LocalUser()
                {
                    Email = email,
                    Token = token,
                };

                users.Add(user);
            }

            return users;
        }

        public static LocalUser GetUser(string email)
        {
            SQLiteConnection connection = DB.GetConnection();
            SQLiteCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"SELECT * FROM Users WHERE email = \'{email}\';";
            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                LocalUser user = new LocalUser()
                {
                    Email = reader.GetString(0),
                    Token = reader.GetString(1),
                };

                return user;
            }

            return null;
        }

        public static void DeleteUser(string token)
        {
            SQLiteConnection connection = DB.GetConnection();
            SQLiteCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"DELETE FROM Users WHERE token = \'{token}\'";

            cmd.ExecuteNonQuery();
        }
    }
}
