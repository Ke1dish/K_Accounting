using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Reflection;
using System.Diagnostics;

namespace K_Accounting.Utilities
{
    public static class VersionChecker
    {
        private const string VersionUrl = "https://github.com/Ke1dish/K_Accounting/releases/download/K_Accounting/version.json";

        public static bool IsUpdateAvailable(out string newVersion, out string changelog, out string downloadUrl)
        {
            newVersion = null;
            changelog = null;
            downloadUrl = null;
            
            try
            {
                using var client = new WebClient();
                client.Headers.Add("User-Agent", "MyApp Update Checker");

                var json = client.DownloadString(VersionUrl);
                var latest = JsonConvert.DeserializeObject<AppVersion>(json);

                var currentVersion = Assembly.GetExecutingAssembly().GetName().Version;
                var latestVersion = new Version(latest.Version);

                newVersion = latest.Version;
                changelog = latest.Changelog;
                downloadUrl = latest.Url;

                return latestVersion > currentVersion;
            }
            catch
            {
                return false;
            }
        }

        private class AppVersion
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("changelog")]
            public string Changelog { get; set; }
        }

    }

    public static class Updater
    {
        public static async Task PerformUpdate(string downloadUrl)
        {
            try
            {
                string tempFile = Path.Combine(Path.GetTempPath(), "UpdateInstaller.exe");

                // Скачивание установщика
                using (var client = new WebClient())
                {
                    await client.DownloadFileTaskAsync(downloadUrl, tempFile);
                }

                // Запуск установщика с параметрами Inno Setup
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = tempFile,
                    Arguments = "/VERYSILENT /SUPPRESSMSGBOXES /NORESTART /CLOSEAPPLICATIONS",
                    UseShellExecute = true
                };

                // Запуск и завершение текущего приложения
                Process.Start(psi);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}");
            }
        }
    }
}
