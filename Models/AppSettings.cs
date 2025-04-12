namespace K_Accounting.Models
{
    public class GridColumnSettings
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public bool Visible { get; set; }
        public int DisplayIndex { get; set; }
        public int MinimumWidth { get; set; }
    }

    public class GridSettings
    {
        public List<GridColumnSettings> Columns { get; set; } = new List<GridColumnSettings>();
    }

    public class SortSettings
    {
        public string SortColumn { get; set; }
        public bool SortAscending { get; set; }
    }

    class AppSettings
    {
        // Основные настройки окна
        public Point WindowLocation { get; set; }
        public Size WindowSize { get; set; }
        public FormWindowState WindowState { get; set; }

        public Dictionary<string, GridSettings> GridsSettings { get; set; } = new Dictionary<string, GridSettings>();

        public Dictionary<string, SortSettings> GridsSortSettings { get; set; } = new();

        public int SplitterDistance { get; set; } = 150; // Значение по умолчанию

        public string SelectedGoalFilter { get; set; } = "Все";

        public int SelectedGivenDebtFilter { get; set; } = 0;

        public int SelectedReceivedDebtFilter { get; set; } = 0;


        // Пример дополнительных настроек
        public string Theme { get; set; } = "Light";
        public int FontSize { get; set; } = 12;
        public bool NotificationsEnabled { get; set; } = true;
        public bool AutoSaveEnabled { get; set; } = true;
        public TimeSpan AutoSaveInterval { get; set; } = TimeSpan.FromMinutes(5);

        // Добавлю другие настройки приложения здесь
    }
}
