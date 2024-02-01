using System.Data.SQLite;

namespace Fibonacci.Helpers
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Data Source=users.db;Version=3;";

        // Инициализация базы данных SQLite и создание таблицы Users.
        public static void InitializeDatabase()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createTableQuery = "CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY AUTOINCREMENT, Username TEXT, Password TEXT)";
                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // Добавление нового пользователя в базу данных.
        public static bool CreateUser(string username, string password)
        {
            var passHash = SecurityHelper.EncryptPassword(password);
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertUserQuery = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
                using (SQLiteCommand command = new SQLiteCommand(insertUserQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", passHash);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        // Проверка учетных данных пользователя в базе данных.
        public static bool ValidateUser(string username, string password)
        {
            var passHash = SecurityHelper.EncryptPassword(password);
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectUserQuery = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                using (SQLiteCommand command = new SQLiteCommand(selectUserQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", passHash);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        return reader.Read();
                    }
                }
            }
        }
    }
}