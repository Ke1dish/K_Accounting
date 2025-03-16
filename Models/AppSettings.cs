namespace K_Accounting.Models
{
    class AppSettings
    {
        // Основные настройки окна
        public Point WindowLocation { get; set; }
        public Size WindowSize { get; set; }
        public FormWindowState WindowState { get; set; }

        // Пример дополнительных настроек
        public string Theme { get; set; } = "Light";
        public int FontSize { get; set; } = 12;
        public bool NotificationsEnabled { get; set; } = true;
        public bool AutoSaveEnabled { get; set; } = true;
        public TimeSpan AutoSaveInterval { get; set; } = TimeSpan.FromMinutes(5);

        // Добавлю другие настройки приложения здесь
    }
}
