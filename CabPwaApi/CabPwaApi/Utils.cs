// Utils.cs
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
    }
}
