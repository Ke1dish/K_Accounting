using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_Accounting.Utilities
{
    public static class Logger
    {
        //Пример использования в коде
        //try 
        //{
        //    // Ваш код
        //}
        //catch (Exception ex)
        //{
        //    // Автоматическое получение имени метода
        //    Logger.Log(ex); 

        //    // Или ручное указание (если нужно уточнить контекст)
        //    Logger.Log(ex, nameof(btnSave_Click));

        //    MessageBox.Show("Ошибка ХХХХХХХХХ. Лог записан.");
        //}

        private static readonly string LogPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "K_Accounting",
            "error_log.txt"
        );

        private static readonly object LockObject = new object();

        // Автоматическое получение имени метода
        public static void Log(Exception ex)
        {
            var stackTrace = new StackTrace(ex, fNeedFileInfo: true);
            var frame = stackTrace.GetFrame(0);
            var methodName = frame?.GetMethod()?.Name ?? "Unknown";

            Log(ex, methodName);
        }

        // Ручное указание метода
        public static void Log(Exception ex, string methodName)
        {
            lock (LockObject)
            {
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(LogPath));

                    string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] " +
                                      $"Метод: {methodName}\n" +
                                      $"Ошибка: {ex.Message}\n" +
                                      $"Stack Trace:\n{ex.StackTrace}\n" +
                                      "----------------------------------------\n";

                    File.AppendAllText(LogPath, logEntry);
                }
                catch (Exception logEx)
                {
                    MessageBox.Show($"Ошибка логирования: {logEx.Message}");
                }
            }
        }
    }
}
