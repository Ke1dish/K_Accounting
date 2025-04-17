using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using System.Web;

namespace K_Accounting.Utilities
{
    public static class FeedbackSender
    {
        private static readonly string LogPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "K_Accounting",
            "error_log.txt"
        );

        public static void OpenEmailClient(string dbVersion)
        {
            try
            {
                bool hasErrors = File.Exists(LogPath) && new FileInfo(LogPath).Length > 0;

                var version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "1.0.0";

                string body = $"""
                    Дата: {DateTime.Now:dd.MM.yyyy HH:mm}
                    Версия программы: {version}
                    Версия базы данных: {dbVersion}
                    Операционная система: {Environment.OSVersion}
                    Память: {GC.GetTotalMemory(false) / 1024 / 1024} MB
                    Пожалуйста, опишите вашу проблему или предложение:
                    ____________________________________________________
                    


                    ____________________________________________________
                    {(hasErrors ? "⚠️ Обнаружен файл с ошибками - не забудьте прикречить его к письму!\n" +
                    $"Он находится здесь:\n{LogPath}": "")}
                    """;

                string mailtoUri = $"mailto:a9090644833@gmail.com" +
                                   $"?subject=Обратная связь K_Accounting {version}" +
                                   $"&body={Uri.EscapeDataString(body)}";

                Process.Start(new ProcessStartInfo
                {
                    FileName = mailtoUri,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Logger.Log(ex, nameof(OpenEmailClient));
                MessageBox.Show("Ошибка при открытии почтового клиента");
            }
        }
    }
}
