using K_Accounting.Utilities;

namespace K_Accounting
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (s, e) => HandleGlobalException(e.Exception);
            AppDomain.CurrentDomain.UnhandledException += (s, e) => HandleGlobalException(e.ExceptionObject as Exception);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }

        private static void HandleGlobalException(Exception ex)
        {
            string errorMessage = $"Произошла критическая ошибка:\n{ex.Message}\n\nStack Trace:\n{ex.StackTrace}";

            // Логирование
            Logger.Log(ex, "Глобальный обработчик");

            // Показ сообщения пользователю
            MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Завершение работы (опционально)
            Application.Exit();
        }
    }
}