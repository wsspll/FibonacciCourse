using System;
using System.Security.Cryptography;
using System.Text;

namespace Fibonacci.Helpers
{
    public static class SecurityHelper
    {

        // Шифрование пароля с использованием SHA256.
        public static string EncryptPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Преобразование байтов в строку
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2")); // Преобразование байта в двузначное шестнадцатеричное число
                }

                return builder.ToString();
            }
        }
    }
}