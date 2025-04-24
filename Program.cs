using K_Accounting.Utilities;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace K_Accounting
{
    internal static class Program
    {
        private const string MutexName = "Global\\{391F52F9-C878-43CD-BCE6-1E9948799D4B}";
        private static Mutex _mutex;

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        private const int SW_RESTORE = 9;
        private const int SW_SHOW = 5;

        [STAThread]
        static void Main()
        {
            bool createdNew;
            _mutex = new Mutex(true, MutexName, out createdNew);

            if (!createdNew)
            {
                ActivateExistingInstance();
                return;
            }

            ConfigureExceptionHandling();
            InitializeApplication();

            try
            {
                Application.Run(new MainForm());
            }
            finally
            {
                ReleaseMutex();
            }
        }

        private static void ConfigureExceptionHandling()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (s, e) => HandleGlobalException(e.Exception);
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
                HandleGlobalException(e.ExceptionObject as Exception);
        }

        private static void InitializeApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
        }

        private static void ReleaseMutex()
        {
            _mutex?.ReleaseMutex();
            _mutex?.Close();
            _mutex = null;
        }

        private static void ActivateExistingInstance()
        {
            // Вариант 1: Поиск по заголовку окна
            IntPtr hWnd = FindWindow(null, "Мои финансы");

            // Вариант 2: Поиск через процессы
            if (hWnd == IntPtr.Zero)
            {
                var process = Process.GetProcessesByName("K_Accounting")
                    .FirstOrDefault(p => p.MainWindowHandle != IntPtr.Zero);

                hWnd = process?.MainWindowHandle ?? IntPtr.Zero;
            }

            if (hWnd != IntPtr.Zero)
            {
                ShowWindow(hWnd, SW_RESTORE);
                ShowWindow(hWnd, SW_SHOW);
                SetForegroundWindow(hWnd);
            }
        }

        private static void HandleGlobalException(Exception ex)
        {
            string errorMessage = $"Произошла критическая ошибка:\n{ex?.Message}\n\nStack Trace:\n{ex?.StackTrace}";
            Logger.Log(ex, "Глобальный обработчик");
            MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
    }
}