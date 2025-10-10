// Utils.cs
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System.Security.Cryptography;
using System.Text;

namespace CabPwaApi
{
    public static class Utils
    {        
        // Название строки подключения к офисной БД
        public const string OfficeDBConnectionStringName = "officeDB";

        // Получение пути файла для логирования
        public static string GetLogFileName()
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, "logs", "log-.txt");
            return filePath;
        }

        // Применение хэш-функции MD5 к строке
        public static string ComputeMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Преобразуем байты хэша в hex-строку
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("x2"));
                }
                return stringBuilder.ToString();
            }
        }
    }
}
