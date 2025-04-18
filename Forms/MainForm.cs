using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using K_Accounting.Data;
using K_Accounting.Extensions;
using K_Accounting.Forms;
using K_Accounting.Models;
using K_Accounting.Reports;
using K_Accounting.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using OxyPlot;
using OxyPlot.WindowsForms;
using ComboBox = System.Windows.Forms.ComboBox;
using Control = System.Windows.Forms.Control;
using VersionChecker = K_Accounting.Utilities.VersionChecker;

namespace K_Accounting
{
    // Создать и применить миграцию
    // dotnet ef migrations add НАЗВАНИЕ МИГРАЦИИ --context AppDbContext
    // dotnet ef database update --context AppDbContext

    public partial class MainForm : Form
    {
        private AppDbContext _context;
        private Currency _selectedCurrency;
        private Additional _selectedAdditional;
        private Source _selectedSource;
        private Category _selectedCategory;
        private SubCategory _selectedSubCategory;
        private Account _selectedAccount;
        private Expense _selectedExpense;
        private Income _selectedIncome;
        private Debt _selectedGivenDebt;
        private Debt _selectedReceivedDebt;
        private Counterparty _selectedCounterparties;
        private Goal _selectedGoal;
        private MeasurementUnit _selectedMeasurement;

        private AppSettings _settings;

        // шаманская фигня для изменения внешнего вида тривью
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);

        string appFolder, dbPath;

        private ToolStripItem _lastClickedItem; // Поле для хранения последнего кликнутого пункта

        private PlotView plotView;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private ReportBase currentReport;

        private int _clickCount = 0; // Счетчик кликов

        public MainForm()
        {
            appFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "K_Accounting");
            Directory.CreateDirectory(appFolder);  // Создаем папку, если её нет
            dbPath = Path.Combine(appFolder, "budget.db");

            InitializeComponent();

            _settings = SettingsManager.LoadSettings();

            //// <<<<<<<<<<<<<<<<<<<< начиная здесь
            InitializeDataGridViews();

            InitializeGoalFilter();

            InitializeDebtFilters();

            LoadPanelState();

            // инициализируем базу данных
            InitializeDatabase();
            _context = new AppDbContext();

            // проверка наличия файла базы данных
            if (!CheckDatabaseVersion())
            {
                MessageBox.Show("База данных повреждена. Будет создана новая.",
                               "Ошибка",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
            }

            // создаем резервную копию базы данных
            CreateBackup();

            //// <<<<<<<<<<<<<<<<<<<< заканчивая здесь нужно пересмотреть порядок вызова, по моему все напутано

            // загружаем данные из базы
            LoadAccounts();
            LoadAdditionals();
            LoadCategories();
            LoadCurrencies();
            LoadExpenses();
            LoadSources();
            LoadIncomes();
            LoadGivenDebts();
            LoadReceivedDebts();
            LoadCounterparties();
            LoadMeasurementUnits();

            // визуально убираем ярлыки закладок на пейджконтрол
            tcPage.Appearance = TabAppearance.FlatButtons;
            tcPage.ItemSize = new Size(0, 1); // Ширина = 0, Высота = 1
            tcPage.SizeMode = TabSizeMode.Fixed;
            tcPage.SelectedIndex = 18;

            // заполняем комбобоксы выбора месяцев и лет
            InitializeDateFilters();
            cmbExpenseMonths.SelectedIndexChanged += (s, e) => LoadExpenses();
            cmbExpenseYears.SelectedIndexChanged += (s, e) => LoadExpenses();
            cmbIncomeMonths.SelectedIndexChanged += (s, e) => LoadIncomes();
            cmbIncomeYears.SelectedIndexChanged += (s, e) => LoadIncomes();
            cmbExpenseMonths.SelectedIndex = DateTime.Now.Month;
            cmbIncomeMonths.SelectedIndex = DateTime.Now.Month;


            cmbGivenDebtStatusFilter.SelectedIndexChanged += (s, e) => LoadGivenDebts();
            cmbReceivedDebtStatusFilter.SelectedIndexChanged += (s, e) => LoadReceivedDebts();

            InitializeReportPage();

            //plotView.BackColor = Color.White;
            plotView1.Model = new PlotModel
            {
                PlotAreaBorderColor = OxyColors.LightGray,
                DefaultFont = "Segoe UI",
                TitleFont = "Segoe UI Bold",
                SubtitleFont = "Segoe UI"
            };

            // меняем внешний вид тривью
            SetWindowTheme(tvMenuPanel.Handle, "explorer", null);

            // пока не реализованна главная страница удаляем ссылку на нее и при старте переходим на страницу "счета"
            // Удалить следующие строки после реализации главной страницы
            tvMenuPanel.Nodes.RemoveAt(0);
            tvMenuPanel_AfterSelect(this, new TreeViewEventArgs(tvMenuPanel.Nodes[0]));
            // пока не реализованна печать скрываем кнопки 
            // Удалить следующие строки после реализации печати
            btnPrintAccounts.Visible = false;
            btnPrintExpenses.Visible = false;
            btnPrintIncomes.Visible = false;
            button3.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            btnPrintGoal.Visible = false;

        }






        #region MainFom
        /// <summary>Заполение комбобоксов месяцев и лет.</summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Загрузка настроек
            _settings = SettingsManager.LoadSettings();

            // Восстановление положения и размера
            RestoreWindowPosition();

            // Восстановление других настроек
            ApplyApplicationSettings();
        }

        private IEnumerable<Control> GetAllControls(Control control)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAllControls(ctrl)).Concat(controls);
        }

        private void RestoreWindowPosition()
        {
            // Проверка валидности сохраненной позиции
            if (IsVisibleOnAnyScreen(_settings.WindowLocation, _settings.WindowSize))
            {
                StartPosition = FormStartPosition.Manual;
                Location = _settings.WindowLocation;
                Size = _settings.WindowSize;
                WindowState = _settings.WindowState;
            }
            else
            {
                StartPosition = FormStartPosition.CenterScreen;
                Size = new Size(800, 600); // Размер по умолчанию
            }

            if (_settings.SplitterDistance > 0 && _settings.SplitterDistance < splitContainer1.Width)
            {
                splitContainer1.SplitterDistance = _settings.SplitterDistance;
            }
            else
            {
                splitContainer1.SplitterDistance = 150; // Значение по умолчанию
            }

            // Гарантия минимального размера
            MinimumSize = new Size(400, 300);
        }

        private bool IsVisibleOnAnyScreen(Point location, Size size)
        {
            var formRect = new Rectangle(location, size);
            foreach (var screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.IntersectsWith(formRect))
                    return true;
            }
            return false;
        }

        private void ApplyApplicationSettings()
        {
            // Пример применения других настроек
            //BackColor = _settings.Theme == "Dark" ? Color.DimGray : Color.White;
            //Font = new Font(Font.FontFamily, _settings.FontSize);

            // ЕЩЕ ПРИМЕР ИСПОЛЬЗОВАНИЯ НАСТРОЕК
            //timerAutoSave.Interval = (int)_settings.AutoSaveInterval.TotalMilliseconds;
            //timerAutoSave.Enabled = _settings.AutoSaveEnabled;

            // Примените здесь другие ваши настройки...
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Сохранение состояния окна
            if (WindowState == FormWindowState.Maximized)
            {
                _settings.WindowLocation = RestoreBounds.Location;
                _settings.WindowSize = RestoreBounds.Size;
                _settings.WindowState = FormWindowState.Maximized;
            }
            else
            {
                _settings.WindowLocation = Location;
                _settings.WindowSize = Size;
                _settings.WindowState = WindowState;
            }

            _settings.SplitterDistance = splitContainer1.SplitterDistance;

            _settings.SelectedGoalFilter = cmbGoalFilter.SelectedItem?.ToString() ?? "Все";
            _settings.SelectedGivenDebtFilter = (int)cmbGivenDebtStatusFilter.SelectedValue;
            _settings.SelectedReceivedDebtFilter = (int)cmbReceivedDebtStatusFilter.SelectedValue;
            _settings.IsPanelVisible = checkBox1.Checked;

            SettingsManager.SaveSettings(_settings);

            // Сохраняем настройки всех гридов
            foreach (var grid in GetAllControls(this).OfType<DataGridView>())
            {
                SettingsManager.SaveGridSettings(grid);
                var sortSettings = GridSorter.GetCurrentSortSettings(grid.Name);
                if (sortSettings != null)
                {
                    SettingsManager.SaveSortSettings(
                        grid,
                        sortSettings.SortColumn,
                        sortSettings.SortAscending
                    );
                }
            }

            // отключаемся от базы данных
            _context?.Dispose();
        }

        private void InitializeDateFilters()
        {
            // Заполнение месяцев
            var months = Enumerable.Range(1, 12)
                .Select(m => new { Value = m, Name = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(m) })
                .ToList();
            months.Insert(0, new { Value = 0, Name = "Все месяцы" });

            cmbExpenseMonths.DataSource = months.ToList();
            cmbExpenseMonths.DisplayMember = "Name";
            cmbExpenseMonths.ValueMember = "Value";

            cmbIncomeMonths.DataSource = months.ToList();
            cmbIncomeMonths.DisplayMember = "Name";
            cmbIncomeMonths.ValueMember = "Value";

            // Заполнение годов
            RefreshYearFilters();
        }

        // обновление вильтра годов
        private void RefreshYearFilters()
        {
            var expenseYears = _context.Expenses
                .Select(e => e.Date.Year)
                .Distinct()
                .OrderBy(y => y)
                .ToList();

            var incomeYears = _context.Incomes
                .Select(i => i.Date.Year)
                .Distinct()
                .OrderBy(y => y)
                .ToList();

            var allYears = expenseYears.Union(expenseYears).OrderBy(y => y).ToList();
            allYears.Insert(0, 0); // Добавляем "Все годы"
            cmbExpenseYears.DataSource = allYears.ToList();

            allYears = expenseYears.Union(incomeYears).OrderBy(y => y).ToList();
            allYears.Insert(0, 0); // Добавляем "Все годы"
            cmbIncomeYears.DataSource = allYears.ToList();

            // Установка текущего года по умолчанию
            var currentYear = DateTime.Now.Year;
            if (allYears.Contains(currentYear))
            {
                cmbExpenseYears.SelectedItem = currentYear;
                cmbIncomeYears.SelectedItem = currentYear;
            }
            else
            {
                cmbExpenseYears.SelectedIndex = 0;
                cmbIncomeYears.SelectedIndex = 0;
            }
        }

        private void InitializeDataGridViews()
        {
            InitializeGrid(dgwAccounts, "Accounts", new List<DataGridViewColumn>
            {
                CreateColumn("colName", "Название", "Name", "dd.MM.yyyy HH:mm"),
                CreateColumn("colBalance", "Баланс", "Balance", "N2", DataGridViewContentAlignment.MiddleRight),
                CreateColumn("colCurrency", "Валюта", "Currency.Name"),
                CreateColumn("colComment", "Комментарий", "Comment")
            });

            InitializeGrid(dgwExpenses, "Expenses", new List<DataGridViewColumn>
            {
                CreateColumn("colDate", "Дата", "Date", "dd.MM.yyyy HH:mm"),
                CreateColumn("colAmount", "Сумма", "Amount", "N2", DataGridViewContentAlignment.MiddleRight),
                CreateColumn("colAccount", "Счет", "Account.Name"),
                CreateColumn("colCategory", "Категория", "Category.Name"),
                CreateColumn("colSubCategory", "Подкатегория", "SubCategory.Name"),
                CreateColumn("colQuantity", "Кол-во", "Quantity", "N2", DataGridViewContentAlignment.MiddleRight),
                CreateColumn("colMeasurementUnit", "Единица", "MeasurementUnit.Name"),
                CreateColumn("colAdditional", "Упоминания", "Additional.Name"),
                CreateColumn("colComment", "Комментарий", "Comment")
            });

            InitializeGrid(dgwIncomes, "Incomes", new List<DataGridViewColumn>
            {
                CreateColumn("colDate", "Дата", "Date", "dd.MM.yyyy HH:mm"),
                CreateColumn("colAmount", "Сумма", "Amount", "N2", DataGridViewContentAlignment.MiddleRight),
                CreateColumn("colAccount", "Счет", "Account.Name"),
                CreateColumn("colSource", "Источник", "Source.Name"),
                CreateColumn("colComment", "Комментарий", "Comment")
            });

            InitializeGrid(dgwCategorie, "Categories", new List<DataGridViewColumn>
            {
                CreateColumn("colName", "Название", "Name"),
                CreateColumn("colComment", "Комментарий", "Comment")
            });

            InitializeGrid(dgwSubCategories, "SubCategories", new List<DataGridViewColumn>
            {
                CreateColumn("colName", "Название", "Name"),
                CreateColumn("colCategory", "Категория", "Category.Name"),
                CreateColumn("colMeasurementUnit", "Единица", "MeasurementUnit.Name"),
                CreateColumn("colComment", "Комментарий", "Comment")
            });

            InitializeGrid(dgwAdditionals, "Additionals", new List<DataGridViewColumn>
            {
                CreateColumn("colName", "Название", "Name"),
                CreateColumn("colComment", "Комментарий", "Comment")
            });

            InitializeGrid(dgwSource, "Source", new List<DataGridViewColumn>
            {
                CreateColumn("colName", "Название", "Name"),
                CreateColumn("colComment", "Комментарий", "Comment")
            });

            InitializeGrid(dgwCurrencies, "Currencies", new List<DataGridViewColumn>
            {
                CreateColumn("colName", "Название", "Name"),
                CreateColumn("colRate", "Курс", "Rate", "N6", DataGridViewContentAlignment.MiddleRight),
                CreateColumn("colSymbol", "Символ", "Symbol"),
                CreateColumn("colComment", "Комментарий", "Comment")
            });

            InitializeGrid(dgwGivenDebts, "GivenDebts", new List<DataGridViewColumn>
            {
                CreateColumn("colCounterparty", "Контрагент", "Counterparty.Name"),
                CreateColumn("colLoanDate", "Дата займа", "LoanDate", "dd.MM.yyyy"),
                CreateColumn("colDueDate", "Дата возврата", "DueDate", "dd.MM.yyyy"),
                CreateColumn("colAmount", "Сумма", "InitialAmount", "N2", DataGridViewContentAlignment.MiddleRight),
                CreateColumn("colRemaining", "Остаток", "RemainingAmount", "N2", DataGridViewContentAlignment.MiddleRight),
                CreateColumn("colStatus", "Статус", "Status")
            });

            InitializeGrid(dgwReceivedDebts, "ReceivedDebts", new List<DataGridViewColumn>
            {
                CreateColumn("colCounterparty", "Контрагент", "Counterparty.Name"),
                CreateColumn("colLoanDate", "Дата займа", "LoanDate", "dd.MM.yyyy"),
                CreateColumn("colDueDate", "Дата возврата", "DueDate", "dd.MM.yyyy"),
                CreateColumn("colAmount", "Сумма", "InitialAmount", "N2", DataGridViewContentAlignment.MiddleRight),
                CreateColumn("colRemaining", "Остаток", "RemainingAmount", "N2", DataGridViewContentAlignment.MiddleRight),
                CreateColumn("colStatus", "Статус", "Status")
            });

            InitializeGrid(dgwCounterparties, "Counterparties", new List<DataGridViewColumn>
            {
                CreateColumn("colName", "Название", "Name"),
                CreateColumn("colPhone", "Телефон", "Phone"),
                CreateColumn("colEmail", "Email", "Email"),
                CreateColumn("colAddress", "Адрес", "Address"),
                CreateColumn("colComment", "Комментарий", "Comment")
            });

            InitializeGrid(dgwGoals, "Goals", new List<DataGridViewColumn>
            {
                CreateColumn("colTitle", "Название", "Title"),
                CreateColumn("colTargetAmount", "Целевая сумма", "TargetAmount", "N2", DataGridViewContentAlignment.MiddleRight),
                CreateColumn("colCurrentAmount", "Накоплено", "CurrentAmount", "N2", DataGridViewContentAlignment.MiddleRight),
                CreateColumn("colCurrency", "Валюта", "Currency.Name"),
                CreateColumn("colTargetDate", "Срок", "TargetDate", "dd.MM.yyyy"),
                CreateColumn("colProgress", "Прогресс", "Progress", "P0", DataGridViewContentAlignment.MiddleRight),
                CreateColumn("colStatus", "Статус", "Status"),
                CreateColumn("colComment", "Комментарий", "Comment")
            });

            InitializeGrid(dgwMeasurement, "MeasurementUnits", new List<DataGridViewColumn>
            {
                CreateColumn("colName", "Название", "Name"),
                CreateColumn("colSymbol", "Символ", "Symbol")
            });
        }

        private DataGridViewColumn CreateColumn(string name, string header, string dataProperty, string format = null,
                                        DataGridViewContentAlignment alignment = DataGridViewContentAlignment.MiddleLeft)
        {
            var column = new DataGridViewTextBoxColumn
            {
                Name = name,
                HeaderText = header,
                DataPropertyName = dataProperty,
                DefaultCellStyle = new DataGridViewCellStyle()
            };

            if (!string.IsNullOrEmpty(format))
            {
                column.DefaultCellStyle.Format = format;
            }

            column.DefaultCellStyle.Alignment = alignment;

            return column;
        }

        private void InitializeGrid(DataGridView grid, string gridName, IEnumerable<DataGridViewColumn> columns)
        {
            grid.Name = gridName;
            grid.AutoGenerateColumns = false;

            if (grid.Columns.Count == 0)
            {
                grid.Columns.AddRange(columns.ToArray());
            }

            SettingsManager.LoadGridSettings(grid);

            // Загрузка настроек
            grid.ColumnHeaderMouseClick += Grid_ColumnHeaderMouseClick;
            grid.ColumnDisplayIndexChanged += (s, e) => SettingsManager.SaveGridSettings(grid);
            grid.ColumnWidthChanged += (s, e) => SettingsManager.SaveGridSettings(grid);
            grid.ColumnHeaderMouseClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                    SettingsManager.SaveGridSettings(grid);
            };
            grid.Sorted += (s, e) =>
            {
                SettingsManager.SaveGridSettings(grid);
            };

            // Принудительное применение стилей после загрузки
            grid.Refresh();
        }

        private void Grid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid?.DataSource == null) return;

            var currentData = ((IEnumerable<object>)grid.DataSource).ToList();
            GridSorter.HandleSorting(grid, e, currentData);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _clickCount++; // Увеличиваем счетчик

            if (_clickCount >= 5)
            {
                using (var form = new GratitudeForm()) { form.ShowDialog(); }
                _clickCount = 0; // Сбрасываем счетчик
            }
        }

        private void InitializeGoalFilter()
        {
            cmbGoalFilter.Items.AddRange(new[] { "Все", "Активные", "Достигнутые", "Замороженные" });
            var savedFilter = _settings?.SelectedGoalFilter;
            var defaultFilter = "Все";
            int index = cmbGoalFilter.Items.IndexOf(savedFilter);
            cmbGoalFilter.SelectedIndex = (index != -1) ? index : 0; // 0 = "Все"
            cmbGoalFilter.SelectedIndexChanged += (s, e) =>
            {
                if (cmbGoalFilter.SelectedItem != null)
                {
                    _settings.SelectedGoalFilter = cmbGoalFilter.SelectedItem.ToString();
                    LoadGoals();
                }
            };
        }

        private void InitializeDebtFilters()
        {
            // Для выданных долгов
            cmbGivenDebtStatusFilter.DataSource = new List<dynamic>
    {
        new { Text = "Все", Value = 0 },
        new { Text = "Активные", Value = 1 },
        new { Text = "Закрытые", Value = 2 }
    };
            cmbGivenDebtStatusFilter.DisplayMember = "Text";
            cmbGivenDebtStatusFilter.ValueMember = "Value";
            cmbGivenDebtStatusFilter.SelectedValue = _settings.SelectedGivenDebtFilter;

            // Для полученных долгов
            cmbReceivedDebtStatusFilter.DataSource = new List<dynamic>
    {
        new { Text = "Все", Value = 0 },
        new { Text = "Активные", Value = 1 },
        new { Text = "Закрытые", Value = 2 }
    };
            cmbReceivedDebtStatusFilter.DisplayMember = "Text";
            cmbReceivedDebtStatusFilter.ValueMember = "Value";
            cmbReceivedDebtStatusFilter.SelectedValue = _settings.SelectedReceivedDebtFilter;

            // Обработчики изменений
            cmbGivenDebtStatusFilter.SelectedIndexChanged += (s, e) =>
            {
                _settings.SelectedGivenDebtFilter = (int)cmbGivenDebtStatusFilter.SelectedValue;
                LoadGivenDebts();
            };

            cmbReceivedDebtStatusFilter.SelectedIndexChanged += (s, e) =>
            {
                _settings.SelectedReceivedDebtFilter = (int)cmbReceivedDebtStatusFilter.SelectedValue;
                LoadReceivedDebts();
            };
        }

        private void LoadPanelState()
        {
            bool isPanelVisible = SettingsManager.LoadPanelVisibility();

            checkBox1.Checked = isPanelVisible;
            tableLayoutPanel2.Visible = isPanelVisible;
            tableLayoutPanel3.Visible = isPanelVisible;
            tableLayoutPanel6.Visible = isPanelVisible;
            tableLayoutPanel16.Visible = isPanelVisible;
            tableLayoutPanel17.Visible = isPanelVisible;
            tableLayoutPanel9.Visible = isPanelVisible;
            tableLayoutPanel11.Visible = isPanelVisible;
            tableLayoutPanel14.Visible = isPanelVisible;
            tableLayoutPanel31.Visible = isPanelVisible;
            tableLayoutPanel32.Visible = isPanelVisible;
            tableLayoutPanel35.Visible = isPanelVisible;
            tableLayoutPanel37.Visible = isPanelVisible;
            tableLayoutPanel39.Visible = isPanelVisible;
        }

        private void checkBoxShowPanel_CheckedChanged(object sender, EventArgs e)
        {
            var isPanelVisible = checkBox1.Checked;
            tableLayoutPanel2.Visible = isPanelVisible;
            tableLayoutPanel2.Visible = isPanelVisible;
            tableLayoutPanel3.Visible = isPanelVisible;
            tableLayoutPanel6.Visible = isPanelVisible;
            tableLayoutPanel16.Visible = isPanelVisible;
            tableLayoutPanel17.Visible = isPanelVisible;
            tableLayoutPanel9.Visible = isPanelVisible;
            tableLayoutPanel11.Visible = isPanelVisible;
            tableLayoutPanel14.Visible = isPanelVisible;
            tableLayoutPanel31.Visible = isPanelVisible;
            tableLayoutPanel32.Visible = isPanelVisible;
            tableLayoutPanel35.Visible = isPanelVisible;
            tableLayoutPanel37.Visible = isPanelVisible;
            tableLayoutPanel39.Visible = isPanelVisible;
            SettingsManager.SavePanelVisibility(checkBox1.Checked);
        }

        #endregion

        #region База Данных
        //инициализация базы данных
        private void InitializeDatabase()
        {
            try
            {
                using var db = new AppDbContext();

                bool isNewDatabase = !db.Database.CanConnect();
                var pendingMigrations = db.Database.GetPendingMigrations().ToList();

                if (pendingMigrations.Any())
                {
                    CreateBackup();
                    db.Database.Migrate();
                }

                if (isNewDatabase)
                {
                    SeedInitialData(db);
                    LogDbVersion(db);
                }
                else if (!db.Categories.Any() || !db.SubCategories.Any())
                {
                    SeedInitialData(db);
                }

                // Передаем примененные миграции
                var appliedMigrations = db.Database.GetAppliedMigrations();
                UpdateDbVersions(db, appliedMigrations);
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка инициализации: {ex.Message}\n{ex.InnerException?.Message}");
                throw;
            }
        }

        private void LogDbVersion(AppDbContext db)
        {
            var firstMigration = db.Database.GetAppliedMigrations().FirstOrDefault();
            if (firstMigration == null) return;

            var version = ExtractVersionFromMigration(firstMigration);
            db.DbVersions.Add(new DbVersion
            {
                Version = version,
                ScriptName = "InitialCreate",
                AppliedAt = DateTime.UtcNow,
                MigrationId = firstMigration,
                IsDeleted = false
            });
            db.SaveChanges();
        }

        private void UpdateDbVersions(AppDbContext db, IEnumerable<string> migrations)
        {
            IDbContextTransaction transaction = null;
            try
            {
                transaction = db.Database.BeginTransaction();

                var existingMigrations = db.DbVersions
                    .Select(v => v.MigrationId)
                    .ToHashSet();

                foreach (var migration in migrations)
                {
                    if (existingMigrations.Contains(migration)) continue;

                    var version = ExtractVersionFromMigration(migration);

                    // Проверка уникальности версии
                    if (db.DbVersions.Any(v => v.Version == version))
                    {
                        continue; // или обработать конфликт
                    }

                    var dbVersion = new DbVersion
                    {
                        Version = version,
                        ScriptName = migration,
                        AppliedAt = DateTime.UtcNow,
                        MigrationId = migration,
                        IsDeleted = false
                    };

                    db.DbVersions.Add(dbVersion);
                }

                db.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                transaction?.Rollback();
                MessageBox.Show($"Ошибка обновления версий: {ex.Message}");
                throw;
            }
            finally
            {
                transaction?.Dispose();
            }
        }

        // Вспомогательный метод для извлечения версии
        private int ExtractVersionFromMigration(string migrationName)
        {
            var versionPart = migrationName.Split('_').FirstOrDefault();
            if (versionPart != null && versionPart.Length >= 14
                && int.TryParse(versionPart[..8], out int version))
            {
                return version;
            }
            throw new InvalidOperationException($"Невозможно извлечь версию из миграции: {migrationName}");
        }

        // проверка наличия файла базы данных
        private bool CheckDatabaseVersion()
        {
            if (!File.Exists(dbPath)) return true;

            try
            {
                using var db = new AppDbContext();
                return db.Database.CanConnect();
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                return false;
            }
        }

        // создаем резервную копию базы данных
        private void CreateBackup(int maxBackups = 3)
        {
            var backupDir = appFolder;
            var backupName = $"backup_{DateTime.Now:yyyyMMdd_HHmmss}.db";
            var backupPath = Path.Combine(backupDir, backupName);

            // 1. Создаем новую резервную копию
            if (File.Exists(dbPath))
            {
                try
                {
                    // если файл занят пробуем 3 раза
                    const int maxRetries = 3;
                    for (int i = 0; i < maxRetries; i++)
                    {
                        try
                        {
                            File.Copy(dbPath, backupPath);
                            break;
                        }
                        catch (IOException ex) when (i < maxRetries - 1)
                        {
                            Logger.Log(ex);
                            Thread.Sleep(1000);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                    Console.WriteLine($"Ошибка создания бэкапа: {ex.Message}");
                    return;
                }
            }

            // 2. Получаем список всех резервных копий
            var backups = Directory.GetFiles(backupDir, "backup_*.db")
                .Select(f => new FileInfo(f))
                .OrderBy(f => f.CreationTime) // Сортируем от старых к новым
                .ToList();

            // 3. Удаляем старые копии, если превышен лимит
            while (backups.Count > maxBackups)
            {
                var oldestBackup = backups.First();
                try
                {
                    File.Delete(oldestBackup.FullName);
                    Console.WriteLine($"Удален старый бэкап: {oldestBackup.Name}");
                    backups.Remove(oldestBackup);
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                    Console.WriteLine($"Ошибка удаления {oldestBackup.Name}: {ex.Message}");
                    break; // Прерываем цикл при ошибке
                }
            }
        }

        // предзаполнение базы данных при первом запуске
        private void SeedInitialData(AppDbContext db)
        {
            // Вызов метода для предзаполнения категорий и подкатегорий
            DataSeeder.SeedCategoriesAndSubCategories(db);

            // Вызов метода для предзаполнения упоминаний
            DataSeeder.SeedAdditionals(db);

            // Вызов метода для предзаполнения валют
            DataSeeder.SeedCurrency(db);

            db.SaveChanges();
        }

        // Метод для расчёта суммы
        private decimal CalculateTotal(DataGridView grid, string columnName)
        {
            if (!grid.Columns.Contains(columnName)) return 0;

            decimal total = 0;

            foreach (DataGridViewRow row in grid.Rows)
            {
                // Пропускаем пустые строки и строки-заголовки
                if (!row.IsNewRow && row.Visible)
                {
                    if (row.Cells[columnName].Value != null &&
                        decimal.TryParse(row.Cells[columnName].Value.ToString(), out decimal value))
                    {
                        total += value;
                    }
                }
            }

            return total;
        }

        private bool ColumnExists(DataGridView grid, string columnName)
        {
            return grid.Columns.Cast<DataGridViewColumn>()
                   .Any(c => c.Name == columnName);
        }
        #endregion

        #region Навигация
        private void tvMenuPanel_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Получаем выбранный узел
            TreeNode selectedNode = e.Node;

            // Проверяем, что у узла есть Tag
            if (selectedNode.Tag != null)
            {
                // Получаем номер страницы из Tag
                int pageIndex = Convert.ToInt32(selectedNode.Tag.ToString());

                // Устанавливаем выбранную вкладку в TabControl
                if (pageIndex >= 0 && pageIndex < tcPage.TabCount)
                {
                    tcPage.SelectedIndex = pageIndex;
                }
            }
        }

        private void tcPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcPage.SelectedIndex)
            {
                case 0: // Счета
                    LoadAccounts();
                    break;
                case 1: // Счета
                    LoadAccounts();
                    break;
                case 2: // Расходы
                    LoadExpenses();
                    break;
                case 3: // Доходы
                    LoadIncomes();
                    break;
                case 14: // Цели
                    LoadGoals();
                    break;
                case 11: // Долги выданные
                    LoadGivenDebts();
                    break;
                case 12: // Долги полученные
                    LoadReceivedDebts();
                    break;
                case 4: // Категории и Подкатегории
                    LoadCategories();
                    LoadSubCategories(_selectedCategory?.Id);
                    break;
                case 5: // Источники
                    LoadSources();
                    break;
                case 6: // Упоминание
                    LoadAdditionals();
                    break;
                case 13: // Контрагенты
                    LoadCounterparties();
                    break;
                case 7: // Валюты
                    LoadCurrencies();
                    break;
                case 15: // Единицы
                    LoadMeasurementUnits();
                    break;
                case 8: // Отчеты
                    break;
                case 9: // Настройки
                    break;
                case 10: // О программе
                    var assembly = Assembly.GetEntryAssembly();

                    var qw = _context.DbVersions.Max(v => (int?)v.Version).ToString();                //-----

                    var replacements = new Dictionary<string, string>
                    {
                        { "{AppVersion}", assembly?.GetName().Version?.ToString() ?? "1.0.0" },
                        { "{DBVersion}", qw ?? "Что-то пошло не так" },         //-----
                        { "{Author}", assembly?.GetCustomAttribute<AssemblyCompanyAttribute>()?.Company ?? "Что-то пошло не так" },
                        { "{Copyright}", assembly?.GetCustomAttribute<AssemblyCopyrightAttribute>()?.Copyright ?? "Что-то пошло не так" }
                    };

                    foreach (var kvp in replacements)
                    {
                        tbAbout.Text = tbAbout.Text.Replace(kvp.Key, kvp.Value);
                    }
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Контекстное меню
        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            var menu = sender as ContextMenuStrip;
            if (menu == null) return;

            var dgv = menu.SourceControl as DataGridView;
            if (dgv == null) return;

            try
            {
                menu.Items.Clear();

                var hitTest = GetHitTestInfo(dgv);

                if (hitTest.Type == DataGridViewHitTestType.ColumnHeader)
                {
                    // Сохраняем индекс столбца при открытии меню
                    Point clientPoint = dgv.PointToClient(Cursor.Position);
                    var hitTest1 = dgv.HitTest(clientPoint.X, clientPoint.Y);
                    menu.Tag = hitTest1.ColumnIndex; // Сохраняем индекс в Tag меню

                    CreateColumnVisibilityMenu(menu, dgv);
                    AddShowAllColumnsItem(menu, dgv);
                    //menu.Closing += Menu_Closing;
                }
                else
                {
                    CreateMainContextMenu(menu, dgv);
                    //menu.Closing -= Menu_Closing;
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                e.Cancel = true; // Отменяем открытие меню при ошибке
                MessageBox.Show("Ошибка при создании меню: " + ex.Message);
            }
        }

        private DataGridView.HitTestInfo GetHitTestInfo(DataGridView dgv)
        {
            Point clientPoint = dgv.PointToClient(Cursor.Position);
            return dgv.HitTest(clientPoint.X, clientPoint.Y);
        }

        private void CreateColumnVisibilityMenu(ContextMenuStrip menu, DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                var menuItem = CreateColumnMenuItem(column);
                menu.Items.Add(menuItem);
            }
        }

        private ToolStripMenuItem CreateColumnMenuItem(DataGridViewColumn column)
        {
            if (column == null) return null;

            var menuItem = new ToolStripMenuItem(column.HeaderText)
            {
                Checked = column.Visible,
                Tag = column
            };

            menuItem.Click += (s, args) =>
            {
                _lastClickedItem = (ToolStripMenuItem)s; // Сохраняем кликнутый пункт
                var clickedColumn = (s as ToolStripMenuItem)?.Tag as DataGridViewColumn;
                if (clickedColumn == null) return;

                clickedColumn.Visible = !clickedColumn.Visible;
                ((ToolStripMenuItem)s).Checked = clickedColumn.Visible;
                EnsureAtLeastOneColumnVisible(clickedColumn.DataGridView);
                SettingsManager.SaveGridSettings(clickedColumn.DataGridView);
            };

            return menuItem;
        }

        private void AddShowAllColumnsItem(ContextMenuStrip menu, DataGridView dgv)
        {
            if (menu.Items.Count > 0)
            {
                menu.Items.Add(new ToolStripSeparator());
            }

            var showAllItem = new ToolStripMenuItem("Показать все столбцы");
            showAllItem.Click += (s, e) =>
            {
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    col.Visible = true;
                }
                SettingsManager.SaveGridSettings(dgv);
                menu.Close();
            };

            menu.Items.Add(showAllItem);

            if (menu.Items.Count > 0)
            {
                menu.Items.Add(new ToolStripSeparator());
            }

            // Автоподбор ширины столбца
            var autoSizeItem = new ToolStripMenuItem("Автоподбор ширины");
            autoSizeItem.Click += (s, e) =>
            {
                if (menu.Tag is int columnIndex && columnIndex >= 0)
                {
                    if (columnIndex < 0 || columnIndex >= dgv.Columns.Count) return;

                    var column = dgv.Columns[columnIndex];
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    int width = column.Width;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    column.Width = Math.Min(width, 400); // Не шире 400px

                    SettingsManager.SaveGridSettings(dgv);
                    menu.Close();
                }
            };
            menu.Items.Add(autoSizeItem);

            // Сброс настроек
            var resetItem = new ToolStripMenuItem("Сбросить настройки");
            resetItem.Click += (s, e) =>
            {
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    column.Visible = true;
                    column.Width = GetDefaultWidth(dgv.Name + "_" + column.Name); // Индивидуальные настройки
                    column.DisplayIndex = GetOriginalIndex(dgv.Name + "_" + column.Name);
                }

                // Восстановление "резинового" столбца
                dgv.Columns[dgv.Columns.Count - 1].AutoSizeMode
                    = DataGridViewAutoSizeColumnMode.Fill;

                SettingsManager.SaveGridSettings(dgv); // Фиксируем сброс
                menu.Close();
            };
            menu.Items.Add(resetItem);
        }

        private int GetDefaultWidth(string columnName)
        {
            return columnName switch
            {
                "Accounts_colBalance" => 120,
                "Accounts_colCurrency" => 120,
                "Accounts_colComment" => 120,
                "Expenses_colDate" => 120,
                "Expenses_colAmount" => 120,
                "Expenses_colAccount" => 120,
                "Expenses_colCategory" => 120,
                "Expenses_colSubCategory" => 120,
                "Expenses_colQuantity" => 120,
                "Expenses_colMeasurementUnit" => 80,
                "Expenses_colAdditional" => 120,
                "Expenses_colComment" => 120,
                "Incomes_colDate" => 120,
                "Incomes_colAmount" => 120,
                "Incomes_colAccount" => 120,
                "Incomes_colSource" => 120,
                "Incomes_colComment" => 120,
                "Categories_colName" => 120,
                "Categories_colComment" => 120,
                "SubCategories_colName" => 120,
                "SubCategories_colCategory" => 120,
                "SubCategories_colMeasurementUnit" => 80,
                "SubCategories_colComment" => 120,
                "Additionals_colName" => 120,
                "Additionals_colComment" => 120,
                "Source_colName" => 120,
                "Source_colComment" => 120,
                "Currencies_colName" => 120,
                "Currencies_colRate" => 120,
                "Currencies_colSymbol" => 120,
                "Currencies_colComment" => 120,
                "GivenDebts_colCounterparty" => 120,
                "GivenDebts_colLoanDate" => 120,
                "GivenDebts_colDueDate" => 120,
                "GivenDebts_colAmount" => 120,
                "GivenDebts_colRemaining" => 120,
                "GivenDebts_colStatus" => 120,
                "ReceivedDebts_colCounterparty" => 120,
                "ReceivedDebts_colLoanDate" => 120,
                "ReceivedDebts_colDueDate" => 120,
                "ReceivedDebts_colAmount" => 120,
                "ReceivedDebts_colRemaining" => 120,
                "ReceivedDebts_colStatus" => 120,
                "Counterparties_colName" => 180,
                "Counterparties_colPhone" => 120,
                "Counterparties_colEmail" => 150,
                "Counterparties_colAddress" => 200,
                "Counterparties_colComment" => 250,
                "Goals_colTargetAmount" => 120,
                "Goals_colCurrentAmount" => 120,
                "Goals_colCurrency" => 100,
                "Goals_colTargetDate" => 100,
                "Goals_colProgress" => 80,
                "Goals_colStatus" => 100,
                "Goals_colComment" => 200,
                "MeasurementUnits_colName" => 180,
                "MeasurementUnits_colSymbol" => 100,
                "MeasurementUnits_colComment" => 250,
                _ => 200
            };
        }

        private int GetOriginalIndex(string columnName)
        {
            return columnName switch
            {
                "Accounts_colName" => 0,
                "Accounts_colBalance" => 1,
                "Accounts_colCurrency" => 2,
                "Accounts_colComment" => 3,
                "Expenses_colDate" => 0,
                "Expenses_colAmount" => 1,
                "Expenses_colAccount" => 2,
                "Expenses_colCategory" => 3,
                "Expenses_colSubCategory" => 4,
                "Expenses_colQuantity" => 5,
                "Expenses_colMeasurementUnit" => 6,
                "Expenses_colAdditional" => 7,
                "Expenses_colComment" => 8,
                "Incomes_colDate" => 0,
                "Incomes_colAmount" => 1,
                "Incomes_colAccount" => 2,
                "Incomes_colSource" => 3,
                "Incomes_colComment" => 4,
                "Categories_colName" => 0,
                "Categories_colComment" => 1,
                "SubCategories_colName" => 0,
                "SubCategories_colCategory" => 1,
                "SubCategories_colMeasurementUnit" => 2,
                "SubCategories_colComment" => 3,
                "Additionals_colName" => 0,
                "Additionals_colComment" => 1,
                "Source_colName" => 0,
                "Source_colComment" => 1,
                "Currencies_colName" => 0,
                "Currencies_colRate" => 1,
                "Currencies_colSymbol" => 2,
                "Currencies_colComment" => 3,
                "GivenDebts_colCounterparty" => 0,
                "GivenDebts_colLoanDate" => 1,
                "GivenDebts_colDueDate" => 2,
                "GivenDebts_colAmount" => 3,
                "GivenDebts_colRemaining" => 4,
                "GivenDebts_colStatus" => 5,
                "ReceivedDebts_colCounterparty" => 0,
                "ReceivedDebts_colLoanDate" => 1,
                "ReceivedDebts_colDueDate" => 2,
                "ReceivedDebts_colAmount" => 3,
                "ReceivedDebts_colRemaining" => 4,
                "ReceivedDebts_colStatus" => 5,
                "Counterparties_colName" => 0,
                "Counterparties_colPhone" => 1,
                "Counterparties_colEmail" => 2,
                "Counterparties_colAddress" => 3,
                "Counterparties_colComment" => 4,
                "Goals_colTitle" => 0,
                "Goals_colTargetAmount" => 1,
                "Goals_colCurrentAmount" => 2,
                "Goals_colCurrency" => 3,
                "Goals_colTargetDate" => 4,
                "Goals_colProgress" => 5,
                "Goals_colStatus" => 6,
                "Goals_colComment" => 7,
                "MeasurementUnits_colName" => 0,
                "MeasurementUnits_colSymbol" => 1,
                "MeasurementUnits_colComment" => 2,
                _ => 0
            };
        }

        private void CreateMainContextMenu(ContextMenuStrip menu, DataGridView dgv)
        {
            AddDefaultMenuItems(menu, dgv);
            AddSpecialMenuItems(menu, dgv);
            AddPrintMenuItems(menu, dgv);
        }

        private void Menu_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            var menu = sender as ContextMenuStrip;
            var dgv = menu?.SourceControl as DataGridView;

            // Запрещаем закрытие только при клике на пункт меню
            if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked)
            {
                // Проверяем последний кликнутый пункт
                if (_lastClickedItem?.Text != "Показать все столбцы")
                {
                    e.Cancel = true; // Блокируем закрытие
                    return;
                }
            }

            _lastClickedItem = null; // Сбрасываем значение
        }

        private void EnsureAtLeastOneColumnVisible(DataGridView dgv)
        {
            if (dgv?.Columns == null || dgv.Columns.Count == 0) return;

            // Проверяем, есть ли хотя бы один видимый столбец
            bool anyVisible = dgv.Columns.Cast<DataGridViewColumn>().Any(c => c.Visible);

            if (!anyVisible)
            {
                // Делаем первый столбец видимым
                dgv.Columns[0].Visible = true;
                SettingsManager.SaveGridSettings(dgv); // Сохраняем изменение
                MessageBox.Show("Должен быть виден хотя бы один столбец!");
            }
        }

        private void AddDefaultMenuItems(ContextMenuStrip menu, DataGridView dgv)
        {
            var items = new Dictionary<string, Action>
    {
        { "Добавить", GetAddHandler(dgv.Name) },
        { "Изменить", GetEditHandler(dgv.Name) },
        { "Удалить", GetDeleteHandler(dgv.Name) }
    };

            foreach (var item in items)
            {
                if (item.Value == null) continue;

                var menuItem = new ToolStripMenuItem(item.Key);
                menuItem.Click += (s, e) => item.Value();
                menu.Items.Add(menuItem);
            }
        }

        private Action GetAddHandler(string gridName) => gridName switch
        {
            "Accounts" => () => btnAddAccounts_Click(null, EventArgs.Empty),
            "Expenses" => () => btnAddExpenses_Click(null, EventArgs.Empty),
            "Incomes" => () => btnAddIncomes_Click(null, EventArgs.Empty),
            "Categories" => () => btnAddCategories_Click(null, EventArgs.Empty),
            "SubCategories" => () => btnAddSubCategories_Click(null, EventArgs.Empty),
            "Source" => () => btnAddSources_Click(null, EventArgs.Empty),
            "Additionals" => () => btnAddAdditionals_Click(null, EventArgs.Empty),
            "Currencies" => () => btnAddCurrencie_Click(null, EventArgs.Empty),
            "GivenDebts" => () => btnAddGivenDebt_Click(null, EventArgs.Empty),
            "ReceivedDebts" => () => btnAddReceivedDebt_Click(null, EventArgs.Empty),
            "Counterparties" => () => btnAddCounterparties_Click(null, EventArgs.Empty),
            "Goals" => () => btnAddGoal_Click(null, EventArgs.Empty),
            "MeasurementUnits" => () => btnAddMeasurementUnit_Click(null, EventArgs.Empty),
            _ => null
        };

        private Action GetEditHandler(string gridName) => gridName switch
        {
            "Accounts" => () => btnEditAccounts_Click(null, EventArgs.Empty),
            "Expenses" => () => btnEditExpenses_Click(null, EventArgs.Empty),
            "Incomes" => () => btnEditIncomes_Click(null, EventArgs.Empty),
            "Categories" => () => btnEditCategories_Click(null, EventArgs.Empty),
            "SubCategories" => () => btnEditSubCategories_Click(null, EventArgs.Empty),
            "Source" => () => btnEditSources_Click(null, EventArgs.Empty),
            "Additionals" => () => btnEditAdditionals_Click(null, EventArgs.Empty),
            "Currencies" => () => btnEditCurrencie_Click(null, EventArgs.Empty),
            "GivenDebts" => () => btnEditGivenDebt_Click(null, EventArgs.Empty),
            "ReceivedDebts" => () => btnEditReceivedDebt_Click(null, EventArgs.Empty),
            "Counterparties" => () => btnEditCounterparties_Click(null, EventArgs.Empty),
            "Goals" => () => btnEditGoal_Click(null, EventArgs.Empty),
            "MeasurementUnits" => () => btnEditMeasurementUnit_Click(null, EventArgs.Empty),
            _ => null
        };

        private Action GetDeleteHandler(string gridName) => gridName switch
        {
            "Accounts" => () => btnDeleteAccounts_Click(null, EventArgs.Empty),
            "Expenses" => () => btnDeleteExpenses_Click(null, EventArgs.Empty),
            "Incomes" => () => btnDeleteIncomes_Click(null, EventArgs.Empty),
            "Categories" => () => btnDeleteCategories_Click(null, EventArgs.Empty),
            "SubCategories" => () => btnDeleteSubCategories_Click(null, EventArgs.Empty),
            "Source" => () => btnDeleteSources_Click(null, EventArgs.Empty),
            "Additionals" => () => btnDeleteAdditionals_Click(null, EventArgs.Empty),
            "Currencies" => () => btnDeleteCurrencie_Click(null, EventArgs.Empty),
            "GivenDebts" => () => btnDeleteGivenDebt_Click(null, EventArgs.Empty),
            "ReceivedDebts" => () => btnDeleteReceivedDebt_Click(null, EventArgs.Empty),
            "Counterparties" => () => btnDeleteCounterparties_Click(null, EventArgs.Empty),
            "Goals" => () => btnDeleteGoal_Click(null, EventArgs.Empty),
            "MeasurementUnits" => () => btnDeleteMeasurementUnit_Click(null, EventArgs.Empty),
            _ => null
        };

        private void AddSpecialMenuItems(ContextMenuStrip menu, DataGridView dgv)
        {
            if (new[] { "Accounts", "Expenses", "ReceivedDebts", "GivenDebts" }.Contains(dgv.Name))
            {
                menu.Items.Add(new ToolStripSeparator());
            }

            var items = new Dictionary<string, (string Name, Action Handler)>
            {
                {
                    "Accounts",
                    ("Перевести", () => btnTransfer_Click(null, EventArgs.Empty))
                },
                {
                    "Expenses",
                    ("Шаблоны", () => btnEditExpenses1_Click(null, EventArgs.Empty))
                },
                {
                    "ReceivedDebts",
                    ("Добавить платеж", () => btnPaymentReceivedDebt_Click(null, EventArgs.Empty))  // изменить процедуру вызова AddPayment
                },
                {
                    "GivenDebts",
                    ("Добавить платеж", () => btnPaymentGivenDebt_Click(null, EventArgs.Empty))  // изменить процедуру вызова AddPayment
                },
            };

            if (items.TryGetValue(dgv.Name, out var menuItem))
            {
                var item = new ToolStripMenuItem(menuItem.Name);
                item.Click += (s, e) => menuItem.Handler();
                menu.Items.Add(item);
            }

            if (items.TryGetValue(dgv.Name + '1', out var menuItem1))
            {
                var item = new ToolStripMenuItem(menuItem1.Name);
                item.Click += (s, e) => menuItem1.Handler();
                menu.Items.Add(item);
            }

            if (dgv.Name == "Goals")
            {
                menu.Items.Add(new ToolStripSeparator());

                var UpGoalItem = new ToolStripMenuItem("Пополнить");
                UpGoalItem.Click += (s, e) => btnFundGoal_Click(null, EventArgs.Empty);
                menu.Items.Add(UpGoalItem);

                var DownGoalItem = new ToolStripMenuItem("Перевод");
                DownGoalItem.Click += (s, e) => btnGoalTransfer_Click(null, EventArgs.Empty);
                menu.Items.Add(DownGoalItem);

                menu.Items.Add(new ToolStripSeparator());

                var adviceItem = new ToolStripMenuItem("Совет");
                adviceItem.Click += (s, e) => ShowGoalAdvice();
                menu.Items.Add(adviceItem);
            }
        }

        private void AddPrintMenuItems(ContextMenuStrip menu, DataGridView dgv)
        {
            if (new[] { "Accounts", "Expenses", "Incomes", "GivenDebts", "ReceivedDebts" }.Contains(dgv.Name))
            {
                menu.Items.Add(new ToolStripSeparator());

                var printItem = new ToolStripMenuItem("Печать")
                {
                    Enabled = false
                };

                menu.Items.Add(printItem);
            }
        }
        #endregion

        #region Счета (Account)
        private void LoadAccounts()
        {
            try
            {
                var accounts = _context.Accounts
                    .Include(a => a.Currency)
                    .Where(a => !a.IsDeleted)
                    //.OrderBy(a => a.Name)
                    .ToList();

                dgwAccounts.DataSource = accounts;
                GridSorter.InitializeGrid(dgwAccounts, accounts.Cast<object>().ToList());
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка загрузки счетов: {ex.Message}");
            }
        }

        private void dataGridViewAccounts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwAccounts.CurrentRow == null) return;
            _selectedAccount = dgwAccounts.CurrentRow?.DataBoundItem as Account;
            btnEditAccount.Enabled = _selectedAccount != null;
            btnDeleteAccount.Enabled = _selectedAccount != null;
            tbDetailsAccount.Text = _selectedAccount?.Comment ?? "";
        }

        private void dataGridViewAccounts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgwAccounts.Columns["colCurrency"].Index)
            {
                var account = dgwAccounts.Rows[e.RowIndex].DataBoundItem as Account;
                e.Value = account?.Currency?.Name ?? "Валюта не указана";
            }
        }

        private void dgwAccounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgwAccounts.CurrentRow != null)
            {
                dgwAccounts.CurrentCell = dgwAccounts.Rows[e.RowIndex].Cells[0];
                btnEditAccount.PerformClick();
            }
        }

        private void btnAddAccounts_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditAccountsForm(_context))
            {
                form.DataUpdated += (s, args) =>
                {
                    LoadCurrencies();
                };

                form.isEditMode = false;
                if (form.ShowDialog() == DialogResult.OK && form.SavedAccountId.HasValue)
                {
                    LoadAccounts();
                    foreach (DataGridViewRow row in dgwAccounts.Rows)
                    {
                        var account = row.DataBoundItem as Account;
                        if (account?.Id == form.SavedAccountId.Value)
                        {
                            dgwAccounts.CurrentCell = row.Cells[0];
                            _selectedAccount = dgwAccounts.CurrentRow?.DataBoundItem as Account;
                            break;
                        }
                    }
                }
            }
        }

        private void btnEditAccounts_Click(object sender, EventArgs e)
        {
            if (_selectedAccount == null || dgwAccounts.CurrentRow == null || _selectedAccount.IsDeleted) return;

            int selectedId = _selectedAccount.Id;

            using (var form = new AddEditAccountsForm(_selectedAccount, _context))
            {
                form.DataUpdated += (s, args) =>
                {
                    LoadCurrencies();
                };

                form.isEditMode = true;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _context.Entry(_selectedAccount).Reload();
                    LoadAccounts();

                    foreach (DataGridViewRow row in dgwAccounts.Rows)
                    {
                        var account = row.DataBoundItem as Account;
                        if (account?.Id == selectedId)
                        {
                            dgwAccounts.CurrentCell = row.Cells[0];
                            break;
                        }
                    }
                }
            }
        }

        private void btnDeleteAccounts_Click(object sender, EventArgs e)
        {
            if (_selectedAccount == null || dgwAccounts.CurrentRow == null) return;

            int savedIndex = dgwAccounts.CurrentRow.Index;

            var result = MessageBox.Show(
                $"Вы уверены что хотите удалить счет '{_selectedAccount.Name}'?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _selectedAccount.IsDeleted = true;
                    _context.SaveChanges();
                    LoadAccounts();

                    if (dgwAccounts.Rows.Count > 0)
                    {
                        int newIndex = savedIndex >= dgwAccounts.Rows.Count ?
                            dgwAccounts.Rows.Count - 1
                            : savedIndex;
                        if (dgwAccounts.Rows.Count > 0 && newIndex >= 0)
                        {
                            dgwAccounts.CurrentCell = dgwAccounts.Rows[newIndex].Cells[0];
                            _selectedAccount = dgwAccounts.CurrentRow?.DataBoundItem as Account;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                    MessageBox.Show($"Ошибка удаления: {ex.Message}");
                }
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            using (var form = new TransferFundsForm(_context))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadAccounts();
                }
            }
        }


        #endregion

        #region Расходы (Expense)
        private void LoadExpenses()
        {
            try
            {
                var selectedMonth = cmbExpenseMonths.SelectedValue is int month ? month : 0;
                var selectedYear = cmbExpenseYears.SelectedItem is int year ? year : 0;

                var query = _context.Expenses
                    .Include(e => e.Account)
                    .Include(e => e.Category)
                    .Include(e => e.SubCategory)
                    .Include(e => e.Additional)
                    .Include(s => s.MeasurementUnit)
                    .Where(e => !e.IsDeleted);

                if (selectedMonth > 0)
                    query = query.Where(e => e.Date.Month == selectedMonth);

                if (selectedYear > 0)
                    query = query.Where(e => e.Date.Year == selectedYear);

                var expenses = query
                    .OrderByDescending(e => e.Date)
                    .ToList();
                GridSorter.InitializeGrid(dgwExpenses, expenses.Cast<object>().ToList());

                dgwExpenses.DataSource = expenses;
                dgwExpenses.Refresh();

                try
                {
                    if (ColumnExists(dgwExpenses, "colAmount"))
                    {
                        decimal total = CalculateTotal(dgwExpenses, "colAmount");
                        //                        lblPageExpensesCaption.Text = $"Расходы: {total:N2}";
                        lblPageExpensesCaption.Text = "Расходы: " + total.ToString("C2", CultureInfo.CurrentCulture);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                    lblPageExpensesCaption.Text = "Расходы";
                    Debug.WriteLine($"Ошибка расчёта суммы расходов: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка загрузки расходов: {ex.Message}");
            }
        }

        private void dataGridViewExpenses_SelectionChanged(object sender, EventArgs e)
        {
            _selectedExpense = dgwExpenses.CurrentRow?.DataBoundItem as Expense;
            btnEditExpenses.Enabled = _selectedExpense != null;
            btnDeleteExpenses.Enabled = _selectedExpense != null;

            if (_selectedExpense == null)
                tbDetailsExpenses.Text = "";
            else
                tbDetailsExpenses.Text = _selectedExpense.Comment;
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgwExpenses.Rows[e.RowIndex].DataBoundItem == null) return;

            var expense = dgwExpenses.Rows[e.RowIndex].DataBoundItem as Expense;

            // Обработка счета
            if (dgwExpenses.Columns[e.ColumnIndex].Name == "colAccount" && e.Value == null)
            {
                e.Value = _context.Accounts
                    .Find(expense?.AccountId)?
                    .Name ?? "Счет удален";
            }

            // Обработка категории
            if (dgwExpenses.Columns[e.ColumnIndex].Name == "colCategory" && e.Value == null)
            {
                e.Value = _context.Categories
                    .Find(expense?.CategoryId)?
                    .Name ?? "Категория удалена";
            }

            // Обработка подкатегории
            if (dgwExpenses.Columns[e.ColumnIndex].Name == "colSubCategory" && e.Value == null)
            {
                e.Value = _context.SubCategories
                    .Find(expense?.SubCategoryId)?
                    .Name ?? "Подкатегория удалена";
            }

            // Обработка дополнительного поля
            if (dgwExpenses.Columns[e.ColumnIndex].Name == "colAdditional" && e.Value == null)
            {
                e.Value = _context.Additionals
                    .Find(expense?.AdditionalId)?
                    .Name ?? "Дополнение удалено";
            }

            // Обработка единиц измерения
            if (dgwExpenses.Columns[e.ColumnIndex].Name == "colMeasurementUnit" && e.Value == null)
            {
                e.Value = expense?.MeasurementUnit?.Name ?? "БЕИ";
                e.FormattingApplied = true;
            }
        }

        private void dgwExpenses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что кликнули по строке, а не по заголовку
            if (e.RowIndex >= 0)
            {
                // Убеждаемся, что строка выбрана
                dgwExpenses.CurrentCell = dgwExpenses.Rows[e.RowIndex].Cells[0];

                // Вызываем метод кнопки "Изменить"
                btnEditExpenses.PerformClick();
            }
        }

        private void btnAddExpenses_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditExpenseForm(_context))
            {
                form.isEditMode = false;
                form.DataUpdated += (s, args) =>
                {
                    RefreshYearFilters();
                    LoadExpenses();
                    LoadAccounts();
                };
                form.ShowDialog();
            }
        }

        private void btnEditExpenses_Click(object sender, EventArgs e)
        {
            if (_selectedExpense == null) return;

            using (var form = new AddEditExpenseForm(_context, _selectedExpense))
            {
                form.isEditMode = true;
                form.DataUpdated += (s, args) =>
                {
                    RefreshYearFilters();
                    LoadExpenses(); // Явный вызов перезагрузки
                    LoadAccounts();
                };
                form.ShowDialog();
            }
        }

        private void btnDeleteExpenses_Click(object sender, EventArgs e)
        {
            if (_selectedExpense == null) return;

            int savedIndex = dgwExpenses.CurrentRow.Index;

            var result = MessageBox.Show(
                $"Вы уверены, что хотите удалить расход от {_selectedExpense.Date:dd.MM.yyyy} на сумму {_selectedExpense.Amount:N2}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            try
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    // Возвращаем сумму на счет
                    var account = _context.Accounts
                        .FirstOrDefault(a => a.Id == _selectedExpense.AccountId);

                    if (account != null)
                    {
                        account.Balance += _selectedExpense.Amount;
                        _context.Entry(account).State = EntityState.Modified;
                    }

                    // Помечаем расход как удаленный
                    _selectedExpense.IsDeleted = true;
                    _context.Entry(_selectedExpense).State = EntityState.Modified;

                    _context.SaveChanges();
                    transaction.Commit();

                    // Обновляем данные
                    LoadExpenses();
                    LoadAccounts(); // Важно обновить список счетов

                    if (dgwExpenses.Rows.Count > 0)
                    {
                        int newIndex = Math.Min(savedIndex, dgwExpenses.Rows.Count - 1);
                        dgwExpenses.CurrentCell = dgwExpenses.Rows[newIndex].Cells[0];
                        _selectedExpense = dgwExpenses.CurrentRow?.DataBoundItem as Expense;
                    }

                    MessageBox.Show("Расход успешно удален. Средства возвращены на счет.");
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка при удалении: {ex.Message}\n\nДетали:\n{ex.InnerException?.Message}");
            }
        }

        private void btnEditExpenses1_Click(object sender, EventArgs e)
        {
            using (var templateForm = new TemplateExpensesForm(_context))
            {
                if (templateForm.ShowDialog() == DialogResult.OK && templateForm.SelectedTemplate != null)
                {
                    using (var expenseForm = new AddEditExpenseForm(_context, templateForm.SelectedTemplate))
                    {
                        expenseForm.DataUpdated += (s, args) =>
                        {
                            RefreshYearFilters();
                            LoadExpenses();
                            LoadAccounts();
                        };

                        expenseForm.ShowDialog();
                    }
                }
            }
        }

        #endregion

        #region Доходы (Income)
        private void LoadIncomes()
        {
            try
            {
                var selectedMonth = cmbIncomeMonths.SelectedValue is int month ? month : 0;
                var selectedYear = cmbIncomeYears.SelectedItem is int year ? year : 0;

                var query = _context.Incomes
                    .Include(i => i.Account)
                    .Include(i => i.Source)
                    .Where(i => !i.IsDeleted);

                if (selectedMonth > 0)
                    query = query.Where(i => i.Date.Month == selectedMonth);

                if (selectedYear > 0)
                    query = query.Where(i => i.Date.Year == selectedYear);

                dgwIncomes.DataSource = query
                    .OrderByDescending(i => i.Date)
                    .ToList();
                GridSorter.InitializeGrid(dgwIncomes, query.Cast<object>().ToList());

                try
                {
                    if (ColumnExists(dgwIncomes, "colAmount"))
                    {
                        decimal total = CalculateTotal(dgwIncomes, "colAmount");
                        lblPageIncomesCaption.Text = "Приходы: " + total.ToString("C2", CultureInfo.CurrentCulture);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                    lblPageIncomesCaption.Text = "Приходы";
                    Debug.WriteLine($"Ошибка расчёта суммы расходов: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка загрузки доходов: {ex.Message}");
            }
        }

        private void dataGridViewIncomes_SelectionChanged(object sender, EventArgs e)
        {
            _selectedIncome = dgwIncomes.CurrentRow?.DataBoundItem as Income;
            btnEditIncomes.Enabled = _selectedIncome != null;
            btnDeleteIncomes.Enabled = _selectedIncome != null;

            if (_selectedIncome == null)
                tbDetailsIncome.Text = "";
            else
                tbDetailsIncome.Text = _selectedIncome.Comment;
        }

        private void dgwIncomes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgwIncomes.Rows[e.RowIndex].DataBoundItem == null) return;

            var income = dgwIncomes.Rows[e.RowIndex].DataBoundItem as Income;

            // Обработка счета
            if (dgwIncomes.Columns[e.ColumnIndex].Name == "colAccount" && e.Value == null)
            {
                e.Value = _context.Accounts
                    .Find(income?.AccountId)?
                    .Name ?? "Счет удален";
            }

            // Обработка источника
            if (dgwIncomes.Columns[e.ColumnIndex].Name == "colSource" && e.Value == null)
            {
                e.Value = _context.Sources
                    .Find(income?.SourceId)?
                    .Name ?? "Источник удален";
            }
        }

        private void dgwIncomes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что кликнули по строке, а не по заголовку
            if (e.RowIndex >= 0)
            {
                // Убеждаемся, что строка выбрана
                dgwIncomes.CurrentCell = dgwIncomes.Rows[e.RowIndex].Cells[0];

                // Вызываем метод кнопки "Изменить"
                btnEditIncomes.PerformClick();
            }
        }

        private void btnAddIncomes_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditIncomeForm(_context))
            {
                form.isEditMode = false;
                form.DataUpdated += (s, args) =>
                {
                    RefreshYearFilters();
                    LoadIncomes();
                    LoadAccounts();
                };
                form.ShowDialog();
            }
        }

        private void btnEditIncomes_Click(object sender, EventArgs e)
        {
            if (_selectedIncome == null) return;

            using (var form = new AddEditIncomeForm(_context, _selectedIncome))
            {
                form.isEditMode = true;
                form.DataUpdated += (s, args) =>
                {
                    RefreshYearFilters();
                    LoadIncomes();
                    LoadAccounts();
                };
                form.ShowDialog();
            }
        }

        private void btnDeleteIncomes_Click(object sender, EventArgs e)
        {
            if (_selectedIncome == null) return;

            int savedIndex = dgwIncomes.CurrentRow.Index;

            var result = MessageBox.Show(
                $"Удалить приход от {_selectedIncome.Date:dd.MM.yyyy} на сумму {_selectedIncome.Amount:N2}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes) return;

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var account = _context.Accounts.Find(_selectedIncome.AccountId);
                    if (account != null)
                    {
                        account.Balance -= _selectedIncome.Amount;
                        _context.Entry(account).State = EntityState.Modified;
                    }

                    _selectedIncome.IsDeleted = true;
                    _context.SaveChanges();
                    transaction.Commit();

                    LoadIncomes();
                    LoadAccounts();
                    if (dgwIncomes.Rows.Count > 0)
                    {
                        int newIndex = Math.Min(savedIndex, dgwIncomes.Rows.Count - 1);
                        dgwIncomes.CurrentCell = dgwIncomes.Rows[newIndex].Cells[0];
                        _selectedIncome = dgwIncomes.CurrentRow?.DataBoundItem as Income;
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
        }
        #endregion

        #region Категории (Category)
        private void LoadCategories()
        {
            try
            {
                var categories = _context.Categories
                    .Where(c => !c.IsDeleted)
                    //.OrderBy(c => c.Name)
                    .ToList();

                dgwCategorie.DataSource = categories;
                GridSorter.InitializeGrid(dgwCategorie, categories.Cast<object>().ToList());
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка загрузки категорий: {ex.Message}");
            }
        }

        private void dataGridViewCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwCategorie.CurrentRow == null) return;
            _selectedCategory = dgwCategorie.CurrentRow?.DataBoundItem as Category;
            btnEditCategories.Enabled = _selectedCategory != null;
            btnDeleteCategories.Enabled = _selectedCategory != null;
            tbDetailsCategory.Text = _selectedCategory?.Comment ?? "";

            LoadSubCategories(_selectedCategory?.Id);
        }

        private void dgwCategorie_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgwCategorie.CurrentRow != null)
            {
                dgwCategorie.CurrentCell = dgwCategorie.Rows[e.RowIndex].Cells[0];
                btnEditCategories.PerformClick();
            }
        }

        private void btnAddCategories_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditCategoryForm(_context))
            {
                form.isEditMode = false;
                form.DataUpdated += (s, args) =>
                {
                    LoadCategories();
                    LoadSubCategories(_selectedCategory?.Id);
                };

                if (form.ShowDialog() == DialogResult.OK && form.SavedCategoryId.HasValue)
                {
                    LoadCategories();
                    foreach (DataGridViewRow row in dgwCategorie.Rows)
                    {
                        var categories = row.DataBoundItem as Category;
                        if (categories?.Id == form.SavedCategoryId.Value)
                        {
                            dgwCategorie.CurrentCell = row.Cells[0];
                            _selectedCategory = dgwCategorie.CurrentRow?.DataBoundItem as Category;
                            break;
                        }
                    }
                    LoadSubCategories(_selectedCategory?.Id);
                }
            }
        }

        private void btnEditCategories_Click(object sender, EventArgs e)
        {
            if (_selectedCategory == null || dgwCategorie.CurrentRow == null || _selectedCategory.IsDeleted) return;

            int selectedId = _selectedCategory.Id;

            using (var form = new AddEditCategoryForm(_selectedCategory, _context))
            {
                form.isEditMode = true;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _context.Entry(_selectedCategory).Reload();
                    LoadCategories();

                    foreach (DataGridViewRow row in dgwCategorie.Rows)
                    {
                        var categories = row.DataBoundItem as Category;
                        if (categories?.Id == selectedId)
                        {
                            dgwCategorie.CurrentCell = row.Cells[0];
                            break;
                        }
                    }
                    LoadSubCategories(_selectedCategory?.Id);
                }
            }
        }

        private void btnDeleteCategories_Click(object sender, EventArgs e)
        {
            if (_selectedCategory == null || dgwCategorie.CurrentRow == null) return;

            int savedIndex = dgwCategorie.CurrentRow.Index;

            var result = MessageBox.Show(
                $"Вы уверены что хотите удалить категорию '{_selectedCategory.Name}'?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _selectedCategory.IsDeleted = true;
                    _context.SaveChanges();
                    LoadCategories();
                    LoadSubCategories(null); // Сбрасываем фильтр

                    if (dgwCategorie.Rows.Count > 0)
                    {
                        int newIndex = savedIndex >= dgwCategorie.Rows.Count ?
                            dgwCategorie.Rows.Count - 1
                            : savedIndex;

                        if (dgwCategorie.Rows.Count > 0 && newIndex >= 0)
                        {
                            dgwCategorie.CurrentCell = dgwCategorie.Rows[newIndex].Cells[0];
                            _selectedCategory = dgwCategorie.CurrentRow?.DataBoundItem as Category;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                    MessageBox.Show($"Ошибка удаления: {ex.Message}");
                }
            }
        }
        #endregion

        #region Подкатегории (SubCategory)
        private void LoadSubCategories(int? categoryId = null)
        {
            try
            {
                int? selectedSubCategoryId = _selectedSubCategory?.Id;

                var query = _context.SubCategories
                    .Include(s => s.Category)
                    .Include(s => s.MeasurementUnit)
                    .Where(s => !s.IsDeleted);

                if (categoryId.HasValue)
                {
                    query = query.Where(s => s.CategoryId == categoryId);
                }

                var subCategories = query
                    //.OrderBy(s => s.Name)
                    .ToList();

                dgwSubCategories.DataSource = subCategories;
                GridSorter.InitializeGrid(dgwSubCategories, subCategories.Cast<object>().ToList());

                if (selectedSubCategoryId.HasValue)
                {
                    var targetRow = dgwSubCategories.Rows
                        .Cast<DataGridViewRow>()
                        .FirstOrDefault(r => (r.DataBoundItem as SubCategory)?.Id == selectedSubCategoryId);

                    if (targetRow != null)
                    {
                        dgwSubCategories.CurrentCell = targetRow.Cells[0];
                        _selectedSubCategory = targetRow.DataBoundItem as SubCategory;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка загрузки подкатегорий: {ex.Message}");
            }
        }

        private void dataGridViewSubCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwSubCategories.CurrentRow == null) return;
            _selectedSubCategory = dgwSubCategories.CurrentRow?.DataBoundItem as SubCategory;
            btnEditSubCategories.Enabled = _selectedSubCategory != null;
            btnDeleteSubCategories.Enabled = _selectedSubCategory != null;
            tbDetailsSubCategory.Text = _selectedSubCategory?.Comment ?? "";
        }

        private void dataGridViewSubCategories_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = sender as DataGridView;

            var subCat = grid.Rows[e.RowIndex].DataBoundItem as SubCategory;

            if (e.ColumnIndex == grid.Columns["colCategory"].Index)
            {
                e.Value = subCat?.Category?.Name ?? "Без категории";
            }

            if (grid.Columns[e.ColumnIndex].Name == "colMeasurementUnit")
            {
                e.Value = subCat?.MeasurementUnit?.Name ??
                        (subCat?.RequireQuantity == true ? "Не указана" : "БЕИ");
                e.FormattingApplied = true;
            }
        }

        private void dgwSubCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgwSubCategories.CurrentCell = dgwSubCategories.Rows[e.RowIndex].Cells[0];
                btnEditSubCategories.PerformClick();
            }
        }

        private void btnAddSubCategories_Click(object sender, EventArgs e)
        {
            if (_selectedCategory == null) return;

            int parentCategoryId = _selectedCategory.Id;
            int? savedSubCategoryId = null;

            using (var form = new AddEditSubCategoryForm(parentCategoryId, _context))
            {
                form.isEditMode = false;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    savedSubCategoryId = form.SavedSubCategoryId;
                    LoadCategories();
                    SelectParentCategory(parentCategoryId);
                    LoadAndSelectSubCategory(savedSubCategoryId, parentCategoryId);
                }
            }
        }

        private void btnEditSubCategories_Click(object sender, EventArgs e)
        {
            if (_selectedSubCategory == null || dgwSubCategories.CurrentRow == null || _selectedSubCategory.IsDeleted) return;

            int originalParentId = (int)_selectedSubCategory.CategoryId;
            int selectedId = _selectedSubCategory.Id;

            using (var form = new AddEditSubCategoryForm(
                originalParentId,
                _selectedSubCategory,
                _context))
            {
                form.isEditMode = true;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _context.Entry(_selectedSubCategory).Reload();
                    int currentParentId = (int)_selectedSubCategory.CategoryId;
                    LoadCategories();
                    SelectParentCategory(currentParentId);
                    LoadAndSelectSubCategory(selectedId, currentParentId);
                }
            }
        }

        private void btnDeleteSubCategories_Click(object sender, EventArgs e)
        {
            if (_selectedSubCategory == null || dgwSubCategories.CurrentRow == null) return;

            int savedIndex = dgwSubCategories.CurrentRow.Index;

            var result = MessageBox.Show(
                $"Вы уверены что хотите удалить подкатегорию '{_selectedSubCategory.Name}'?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _selectedSubCategory.IsDeleted = true;
                    _context.SaveChanges();
                    LoadSubCategories(_selectedCategory?.Id);
                    if (dgwSubCategories.Rows.Count > 0)
                    {
                        int newIndex = savedIndex >= dgwSubCategories.Rows.Count ?
                        dgwSubCategories.Rows.Count - 1
                        : savedIndex;

                        if (dgwSubCategories.Rows.Count > 0 && newIndex >= 0)
                        {
                            dgwSubCategories.CurrentCell = dgwSubCategories.Rows[newIndex].Cells[0];
                            _selectedSubCategory = dgwSubCategories.CurrentRow?.DataBoundItem as SubCategory;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                    MessageBox.Show($"Ошибка удаления: {ex.Message}");
                }
            }
        }

        private void SelectParentCategory(int categoryId)
        {
            foreach (DataGridViewRow row in dgwCategorie.Rows)
            {
                var category = row.DataBoundItem as Category;
                if (category?.Id == categoryId)
                {
                    dgwCategorie.CurrentCell = row.Cells[0];
                    _selectedCategory = category;
                    break;
                }
            }
        }

        private void LoadAndSelectSubCategory(int? subCategoryId, int parentCategoryId)
        {
            LoadSubCategories(parentCategoryId);

            if (subCategoryId.HasValue)
            {
                foreach (DataGridViewRow row in dgwSubCategories.Rows)
                {
                    var subCat = row.DataBoundItem as SubCategory;
                    if (subCat?.Id == subCategoryId.Value)
                    {
                        dgwSubCategories.CurrentCell = row.Cells[0];
                        _selectedSubCategory = subCat;
                        break;
                    }
                }
            }
        }
        #endregion

        #region Дополнительно (Additionaly)
        private void LoadAdditionals()
        {
            try
            {
                var additionals = _context.Additionals
                    .Where(a => !a.IsDeleted)
                    //.OrderBy(a => a.Name)
                    .ToList();

                dgwAdditionals.DataSource = additionals;
                GridSorter.InitializeGrid(dgwAdditionals, additionals.Cast<object>().ToList());
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка загрузки: {ex.Message}");
            }
        }

        private void dataGridViewAdditionals_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwAdditionals.CurrentRow == null) return;
            _selectedAdditional = dgwAdditionals.CurrentRow?.DataBoundItem as Additional;
            btnEditAdditionals.Enabled = _selectedAdditional != null;
            btnDeleteAdditional.Enabled = _selectedAdditional != null;
            tbDetailsAdditional.Text = _selectedAdditional?.Comment ?? "";
        }

        private void dgwAdditionals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgwAdditionals.CurrentRow != null)
            {
                dgwAdditionals.CurrentCell = dgwAdditionals.Rows[e.RowIndex].Cells[0];
                btnEditAdditionals.PerformClick();
            }
        }

        private void btnAddAdditionals_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditAdditionalForm(_context))
            {
                form.isEditMode = false;
                if (form.ShowDialog() == DialogResult.OK && form.SavedAdditionalId.HasValue)
                {
                    LoadAdditionals();

                    foreach (DataGridViewRow row in dgwAdditionals.Rows)
                    {
                        var additional = row.DataBoundItem as Additional;
                        if (additional?.Id == form.SavedAdditionalId.Value)
                        {
                            dgwAdditionals.CurrentCell = row.Cells[0];
                            _selectedAdditional = dgwAdditionals.CurrentRow?.DataBoundItem as Additional;
                            break;
                        }
                    }
                }
            }
        }

        private void btnEditAdditionals_Click(object sender, EventArgs e)
        {
            if (_selectedAdditional == null || dgwAdditionals.CurrentRow == null || _selectedAdditional.IsDeleted) return;

            int selectedId = _selectedAdditional.Id;

            using (var form = new AddEditAdditionalForm(_selectedAdditional, _context))
            {
                form.isEditMode = true;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _context.Entry(_selectedAdditional).Reload();
                    LoadAdditionals();

                    // Восстанавливаем выделение
                    foreach (DataGridViewRow row in dgwAdditionals.Rows)
                    {
                        var source = row.DataBoundItem as Source;
                        if (source?.Id == selectedId)
                        {
                            dgwAdditionals.CurrentCell = row.Cells[0];
                            break;
                        }
                    }
                }
            }

        }

        private void btnDeleteAdditionals_Click(object sender, EventArgs e)
        {
            if (_selectedAdditional == null || dgwAdditionals.CurrentRow == null) return;

            int savedIndex = dgwAdditionals.CurrentRow.Index;

            var result = MessageBox.Show(
                $"Вы уверены что хотите удалить '{_selectedAdditional.Name}'?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _selectedAdditional.IsDeleted = true;
                    _context.SaveChanges();
                    LoadAdditionals();
                    if (dgwAdditionals.Rows.Count > 0)
                    {
                        int newIndex = savedIndex >= dgwAdditionals.Rows.Count ? dgwAdditionals.Rows.Count - 1 : savedIndex;
                        if (dgwAdditionals.Rows.Count > 0 && newIndex >= 0)
                        {
                            dgwAdditionals.CurrentCell = dgwAdditionals.Rows[newIndex].Cells[0];
                            _selectedAdditional = dgwAdditionals.CurrentRow?.DataBoundItem as Additional;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                    MessageBox.Show($"Ошибка удаления: {ex.Message}");
                }
            }
        }
        #endregion

        #region Цели (Goals)
        private void LoadGoals()
        {
            try
            {
                var goals = _context.Goals
                    .Include(g => g.Currency)
                    .Where(g => !g.IsDeleted);

                // Применение фильтра
                switch (cmbGoalFilter.SelectedItem?.ToString())
                {
                    case "Активные":
                        goals = goals.Where(g => g.Status == GoalStatus.Active);
                        break;
                    case "Достигнутые":
                        goals = goals.Where(g => g.Status == GoalStatus.Completed);
                        break;
                    case "Замороженные":
                        goals = goals.Where(g => g.Status == GoalStatus.Frozen);
                        break;
                }

                dgwGoals.DataSource = goals.ToList();
                GridSorter.InitializeGrid(dgwGoals, goals.Cast<object>().ToList());
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка загрузки целей: {ex.Message}");
            }
        }

        private void dgvGoals_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwGoals.CurrentRow == null) return;
            _selectedGoal = dgwGoals.CurrentRow?.DataBoundItem as Goal;
            btnEditGoal.Enabled = _selectedGoal != null;
            btnDeleteGoal.Enabled = _selectedGoal != null;
            tbDetailsGoal.Text = _selectedGoal?.Comment ?? "";
        }

        private void dgvGoals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedGoal = dgwGoals.Rows[e.RowIndex].DataBoundItem as Goal;
                if (_selectedGoal != null)
                {
                    btnEditGoal.PerformClick();
                }
            }
        }

        private void dgvGoals_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var grid = sender as DataGridView;
            var goal = grid.Rows[e.RowIndex].DataBoundItem as Goal;

            // Подсветка статусов
            if (grid.Columns[e.ColumnIndex].Name == "colStatus")
            {
                switch (goal.Status)
                {
                    case GoalStatus.Active:
                        e.CellStyle.BackColor = Color.LightGreen;
                        break;
                    case GoalStatus.Frozen:
                        e.CellStyle.BackColor = Color.LightGray;
                        break;
                    case GoalStatus.Completed:
                        e.CellStyle.BackColor = Color.LightBlue;
                        break;
                }
            }

            // Прогресс в %
            if (grid.Columns[e.ColumnIndex].Name == "colProgress")
            {
                var progress = goal.TargetAmount - goal.CurrentAmount;
                e.Value = $"{progress:N0}%";
            }

            if (dgwGoals.Columns[e.ColumnIndex].Name == "colCurrency" && e.Value == null)
            {
                e.Value = goal?.Currency?.Name ?? "Не указана";
            }
        }

        private void btnAddGoal_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditGoalsForm(_context))
            {
                form.DataUpdated += (s, args) =>
                {
                    LoadCurrencies();
                    LoadGoals();
                };

                form.isEditMode = false;
                if (form.ShowDialog() == DialogResult.OK && form.SavedGoalId.HasValue)
                {
                    LoadGoals();
                    foreach (DataGridViewRow row in dgwGoals.Rows)
                    {
                        var goal = row.DataBoundItem as Goal;
                        if (goal?.Id == form.SavedGoalId.Value)
                        {
                            dgwGoals.CurrentCell = row.Cells[0];
                            _selectedGoal = dgwGoals.CurrentRow?.DataBoundItem as Goal;
                            break;
                        }
                    }
                }
            }
        }

        private void btnEditGoal_Click(object sender, EventArgs e)
        {
            if (_selectedGoal == null || dgwGoals.CurrentRow == null || _selectedGoal.IsDeleted) return;

            int selectedId = _selectedGoal.Id;

            using (var form = new AddEditGoalsForm(_selectedGoal, _context))
            {
                form.DataUpdated += (s, args) =>
                {
                    LoadCurrencies();
                    LoadGoals();
                };

                form.isEditMode = true;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _context.Entry(_selectedGoal).Reload();
                    LoadGoals();

                    foreach (DataGridViewRow row in dgwGoals.Rows)
                    {
                        var goal = row.DataBoundItem as Goal;
                        if (goal?.Id == selectedId)
                        {
                            dgwGoals.CurrentCell = row.Cells[0];
                            _selectedGoal = dgwGoals.CurrentRow?.DataBoundItem as Goal;
                            break;
                        }
                    }
                }
            }
        }

        private void btnDeleteGoal_Click(object sender, EventArgs e)
        {
            if (_selectedGoal == null || dgwGoals.CurrentRow == null) return;

            int savedIndex = dgwGoals.CurrentRow.Index;

            var result = MessageBox.Show(
                $"Вы уверены что хотите удалить цель '{_selectedGoal.Title}'?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _selectedGoal.IsDeleted = true;
                    _context.SaveChanges();
                    LoadGoals();

                    if (dgwGoals.Rows.Count > 0)
                    {
                        int newIndex = savedIndex >= dgwGoals.Rows.Count
                            ? dgwGoals.Rows.Count - 1
                            : savedIndex;

                        if (dgwGoals.Rows.Count > 0 && newIndex >= 0)
                        {
                            dgwGoals.CurrentCell = dgwGoals.Rows[newIndex].Cells[0];
                            _selectedGoal = dgwGoals.CurrentRow?.DataBoundItem as Goal;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                    MessageBox.Show($"Ошибка удаления: {ex.Message}");
                }
            }
        }

        private void btnFundGoal_Click(object sender, EventArgs e)
        {
            if (_selectedGoal == null) return;

            var selectedId = _selectedGoal.Id; // Сохраняем ID

            using (var form = new FundGoalForm(_context, _selectedGoal.Id))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadGoals(); // Перезагружаем данные

                    // Восстанавливаем выделение
                    foreach (DataGridViewRow row in dgwGoals.Rows)
                    {
                        var goal = row.DataBoundItem as Goal;
                        if (goal?.Id == selectedId)
                        {
                            dgwGoals.CurrentCell = row.Cells[0];
                            break;
                        }
                    }
                }
            }
        }

        private void btnGoalTransfer_Click(object sender, EventArgs e)
        {
            if (_selectedGoal == null) return;

            var selectedId = _selectedGoal.Id; // Сохраняем ID

            using (var form = new GoalTransferForm(_context, _selectedGoal.Id))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadGoals(); // Перезагружаем данные

                    // Восстанавливаем выделение
                    foreach (DataGridViewRow row in dgwGoals.Rows)
                    {
                        var goal = row.DataBoundItem as Goal;
                        if (goal?.Id == selectedId)
                        {
                            dgwGoals.CurrentCell = row.Cells[0];
                            break;
                        }
                    }
                }
            }
        }

        private void ShowGoalAdvice()
        {
            if (_selectedGoal == null || dgwGoals.CurrentRow == null || _selectedGoal.IsDeleted) return;

            var goal = _context.Goals.FirstOrDefault(g => g.Id == _selectedGoal.Id);
            if (goal == null) return;

            var daysLeft = (goal.TargetDate - DateTime.Today).TotalDays;
            var amountLeft = goal.TargetAmount - goal.CurrentAmount;
            var monthly = daysLeft > 0 ? amountLeft / (decimal)(daysLeft / 30.0) : 0;

            var message = new StringBuilder();
            message.AppendLine($"Осталось дней: {Math.Ceiling(daysLeft)}");
            message.AppendLine($"Осталось накопить: {amountLeft:N2} {goal.Currency?.Symbol}");
            message.AppendLine($"Рекомендуемый ежемесячный взнос: {monthly:N2} {goal.Currency?.Symbol}");

            MessageBox.Show(message.ToString(), "Совет по цели", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Источники (Source)
        private void LoadSources()
        {
            try
            {
                var sources = _context.Sources
                    .Where(s => !s.IsDeleted)
                    //.OrderBy(s => s.Name)
                    .ToList();

                dgwSource.DataSource = sources;
                GridSorter.InitializeGrid(dgwSource, sources.Cast<object>().ToList());

            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка загрузки источников: {ex.Message}");
            }
        }

        private void dataGridViewSources_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwSource.CurrentRow == null) return;
            _selectedSource = dgwSource.CurrentRow?.DataBoundItem as Source;
            btnEditSource.Enabled = _selectedSource != null;
            btnDeleteSource.Enabled = _selectedSource != null;
            tbDetailsSource.Text = _selectedSource?.Comment ?? "";
        }

        private void dgwSource_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgwSource.CurrentRow != null)
            {
                dgwSource.CurrentCell = dgwSource.Rows[e.RowIndex].Cells[0];
                btnEditSources.PerformClick();
            }
        }

        private void btnAddSources_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditSourceForm(_context))
            {
                form.isEditMode = false;
                if (form.ShowDialog() == DialogResult.OK && form.SavedSourceId.HasValue)
                {
                    LoadSources();

                    foreach (DataGridViewRow row in dgwSource.Rows)
                    {
                        var source = row.DataBoundItem as Source;
                        if (source?.Id == form.SavedSourceId.Value)
                        {
                            dgwSource.CurrentCell = row.Cells[0];
                            _selectedSource = dgwSource.CurrentRow?.DataBoundItem as Source;
                            break;
                        }
                    }
                }
            }
        }

        private void btnEditSources_Click(object sender, EventArgs e)
        {
            if (_selectedSource == null || dgwSource.CurrentRow == null || _selectedSource.IsDeleted) return;

            int selectedId = _selectedSource.Id;

            using (var form = new AddEditSourceForm(_selectedSource, _context))
            {
                form.isEditMode = true;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _context.Entry(_selectedSource).Reload();
                    LoadSources();

                    // Восстанавливаем выделение
                    foreach (DataGridViewRow row in dgwSource.Rows)
                    {
                        var source = row.DataBoundItem as Source;
                        if (source?.Id == selectedId)
                        {
                            dgwSource.CurrentCell = row.Cells[0];
                            break;
                        }
                    }
                }
            }
        }

        private void btnDeleteSources_Click(object sender, EventArgs e)
        {
            if (_selectedSource == null || dgwSource.CurrentRow == null) return;

            int savedIndex = dgwSource.CurrentRow.Index;

            var result = MessageBox.Show(
                $"Вы уверены что хотите удалить источник '{_selectedSource.Name}'?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _selectedSource.IsDeleted = true;
                    _context.SaveChanges();
                    LoadSources();
                    if (dgwSource.Rows.Count > 0)
                    {
                        // Проверяем валидность индекса перед использованием
                        int newIndex = savedIndex >= dgwSource.Rows.Count
                            ? dgwSource.Rows.Count - 1
                            : savedIndex;

                        if (dgwSource.Rows.Count > 0 && newIndex >= 0)
                        {
                            dgwSource.CurrentCell = dgwSource.Rows[newIndex].Cells[0];
                            _selectedSource = dgwSource.CurrentRow?.DataBoundItem as Source;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                    MessageBox.Show($"Ошибка удаления: {ex.Message}");
                }
            }
        }
        #endregion

        #region Валюты (Currency)
        private void LoadCurrencies()
        {
            try
            {
                var currencies = _context.Currencies
                    .Where(c => !c.IsDeleted)
                    //.OrderBy(c => c.Name)
                    .ToList();

                dgwCurrencies.DataSource = currencies;
                GridSorter.InitializeGrid(dgwCurrencies, currencies.Cast<object>().ToList());
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка загрузки валют: {ex.Message}");
            }
        }

        private void dataGridViewCurrencies_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwCurrencies.CurrentCell == null) return;
            _selectedCurrency = dgwCurrencies.CurrentRow?.DataBoundItem as Currency;
            btnEditCurrency.Enabled = _selectedCurrency != null;
            btnDeleteCurrency.Enabled = _selectedCurrency != null;
            tbDetailsCurrency.Text = _selectedCurrency?.Comment ?? "";
        }

        private void dgwCurrencies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgwCurrencies.CurrentRow != null)
            {
                dgwCurrencies.CurrentCell = dgwCurrencies.Rows[e.RowIndex].Cells[0];
                btnEditCurrency.PerformClick();
            }
        }

        private void btnAddCurrencie_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditCurrencyForm(_context))
            {
                form.isEditMode = false;
                if (form.ShowDialog() == DialogResult.OK && form.SavedCurrencyId.HasValue)
                {
                    LoadCurrencies();

                    // ==================== Старый код (удалить) ====================
                    //foreach (DataGridViewRow row in dgwCurrencies.Rows)
                    //{
                    //    var currency = row.DataBoundItem as Currency;
                    //    if (currency?.Id == form.SavedCurrencyId.Value)
                    //    {
                    //        dgwCurrencies.CurrentCell = row.Cells[0];
                    //        _selectedCurrency = dgwCurrencies.CurrentRow?.DataBoundItem as Currency;
                    //        break;
                    //    }
                    //}

                    // ==================== Новый код (LINQ) ====================
                    var targetRow = dgwCurrencies.Rows
                        .Cast<DataGridViewRow>()
                        .FirstOrDefault(row =>
                            (row.DataBoundItem as Currency)?.Id == form.SavedCurrencyId.Value);

                    if (targetRow != null)
                    {
                        dgwCurrencies.CurrentCell = targetRow.Cells[0];
                        _selectedCurrency = targetRow.DataBoundItem as Currency;
                    }
                }
            }
        }

        private void btnEditCurrencie_Click(object sender, EventArgs e)
        {
            if (_selectedCurrency == null || dgwCurrencies.CurrentRow == null || _selectedCurrency.IsDeleted) return;

            int selectedId = _selectedCurrency.Id;

            using (var form = new AddEditCurrencyForm(_selectedCurrency, _context))
            {
                form.isEditMode = true;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Обновляем основной контекст
                    _context.Entry(_selectedCurrency).Reload();
                    LoadCurrencies();

                    // ==================== Старый код (удалить) ====================
                    //foreach (DataGridViewRow row in dgwCurrencies.Rows)
                    //{
                    //    var currency = row.DataBoundItem as Currency;
                    //    if (currency?.Id == selectedId)
                    //    {
                    //        dgwCurrencies.CurrentCell = row.Cells[0];
                    //        break;
                    //    }
                    //}

                    // ==================== Новый код (LINQ) ====================
                    var targetRow = dgwCurrencies.Rows
                        .Cast<DataGridViewRow>()
                        .FirstOrDefault(row =>
                            (row.DataBoundItem as Currency)?.Id == selectedId);

                    if (targetRow != null)
                    {
                        dgwCurrencies.CurrentCell = targetRow.Cells[0];
                        _selectedCurrency = targetRow.DataBoundItem as Currency;
                    }
                }
            }
        }

        private void btnDeleteCurrencie_Click(object sender, EventArgs e)
        {
            if (_selectedCurrency == null || dgwCurrencies.CurrentRow == null) return;

            int savedIndex = dgwCurrencies.CurrentRow.Index;

            var result = MessageBox.Show(
                $"Вы уверены что хотите удалить валюту {_selectedCurrency.Name}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _selectedCurrency.IsDeleted = true;
                    _context.SaveChanges();
                    LoadCurrencies();
                    if (dgwCurrencies.Rows.Count > 0)
                    {
                        // Проверяем валидность индекса перед использованием
                        int newIndex = savedIndex >= dgwCurrencies.Rows.Count
                            ? dgwCurrencies.Rows.Count - 1
                            : savedIndex;

                        if (dgwCurrencies.Rows.Count > 0 && newIndex >= 0)
                        {
                            dgwCurrencies.CurrentCell = dgwCurrencies.Rows[newIndex].Cells[0];
                            _selectedCurrency = dgwCurrencies.CurrentRow?.DataBoundItem as Currency;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                    MessageBox.Show($"Ошибка удаления: {ex.Message}");
                }
            }
        }

        #endregion

        #region Единицы измерения (MeasurementUnit)
        private void LoadMeasurementUnits()
        {
            try
            {
                var units = _context.MeasurementUnits
                    .Where(u => !u.IsDeleted)
                    .ToList();

                dgwMeasurement.DataSource = units;
                GridSorter.InitializeGrid(dgwMeasurement, units.Cast<object>().ToList());
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка загрузки единиц: {ex.Message}");
            }
        }

        private void dgwMeasurementUnits_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwMeasurement.CurrentCell == null) return;
            _selectedMeasurement = dgwMeasurement.CurrentRow?.DataBoundItem as MeasurementUnit;
            btnEditMeasurement.Enabled = _selectedMeasurement != null;
            btnDeleteMeasurement.Enabled = _selectedMeasurement != null;
        }

        private void dgwMeasurementUnits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgwMeasurement.CurrentRow != null)
            {
                dgwMeasurement.CurrentCell = dgwMeasurement.Rows[e.RowIndex].Cells[0];
                btnEditMeasurement.PerformClick();
            }
        }

        private void btnAddMeasurementUnit_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditMeasurementUnitForm(_context))
            {
                form.IsEditMode = false;
                if (form.ShowDialog() == DialogResult.OK && form.SavedUnitId.HasValue)
                {
                    LoadMeasurementUnits();

                    var targetRow = dgwMeasurement.Rows
                        .Cast<DataGridViewRow>()
                        .FirstOrDefault(row =>
                            (row.DataBoundItem as MeasurementUnit)?.Id == form.SavedUnitId.Value);

                    if (targetRow != null)
                    {
                        dgwMeasurement.CurrentCell = targetRow.Cells[0];
                        _selectedMeasurement = targetRow.DataBoundItem as MeasurementUnit;
                    }
                }
            }
        }

        private void btnEditMeasurementUnit_Click(object sender, EventArgs e)
        {
            if (_selectedMeasurement == null || _selectedMeasurement.IsDeleted) return;
            int selectedId = _selectedMeasurement.Id;

            using (var form = new AddEditMeasurementUnitForm(_selectedMeasurement, _context))
            {
                form.IsEditMode = true;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _context.Entry(_selectedMeasurement).Reload();
                    LoadMeasurementUnits();

                    var targetRow = dgwMeasurement.Rows
                        .Cast<DataGridViewRow>()
                        .FirstOrDefault(row =>
                            (row.DataBoundItem as MeasurementUnit)?.Id == selectedId);

                    if (targetRow != null)
                    {
                        dgwMeasurement.CurrentCell = targetRow.Cells[0];
                        _selectedMeasurement = targetRow.DataBoundItem as MeasurementUnit;
                    }
                }
            }
        }

        private void btnDeleteMeasurementUnit_Click(object sender, EventArgs e)
        {
            if (_selectedMeasurement == null) return;

            var result = MessageBox.Show(
                $"Удалить единицу измерения {_selectedMeasurement.Name}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _selectedMeasurement.IsDeleted = true;
                    _context.SaveChanges();
                    LoadMeasurementUnits();

                    if (dgwMeasurement.Rows.Count > 0)
                    {
                        int newIndex = Math.Min(dgwMeasurement.Rows.Count - 1, dgwMeasurement.CurrentRow.Index);
                        dgwMeasurement.CurrentCell = dgwMeasurement.Rows[newIndex].Cells[0];
                        _selectedMeasurement = dgwMeasurement.CurrentRow?.DataBoundItem as MeasurementUnit;
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                    MessageBox.Show($"Ошибка удаления: {ex.Message}");
                }
            }
        }
        #endregion

        #region Контрагенты (Counterparties)
        private void LoadCounterparties()
        {
            try
            {
                var counterparties = _context.Counterparties
                    .Where(c => !c.IsDeleted)
                    .OrderBy(c => c.Name)
                    .ToList();

                dgwCounterparties.DataSource = counterparties;
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка загрузки контрагентов: {ex.Message}");
            }
        }

        private void dgwCounterparties_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwCounterparties.CurrentCell == null) return;
            _selectedCounterparties = dgwCounterparties.CurrentRow?.DataBoundItem as Counterparty;
            btnEditCounterparties.Enabled = _selectedCounterparties != null;
            btnDeleteCounterparties.Enabled = _selectedCounterparties != null;
            tbDetailsCounterparties.Text = _selectedCounterparties?.Comment ?? "";
        }

        private void dgwCounterparties_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgwCounterparties.CurrentRow != null)
            {
                dgwCounterparties.CurrentCell = dgwCounterparties.Rows[e.RowIndex].Cells[0];
                btnEditCounterparties.PerformClick();
            }
        }

        private void btnAddCounterparties_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditCounterpartyForm(_context))
            {
                form.isEditMode = false;
                if (form.ShowDialog() == DialogResult.OK && form.SavedCounterpartyId.HasValue)
                {
                    LoadCounterparties();
                    foreach (DataGridViewRow row in dgwCounterparties.Rows)
                    {
                        var Counterparti = row.DataBoundItem as Counterparty;
                        if (Counterparti?.Id == form.SavedCounterpartyId.Value)
                        {
                            dgwCounterparties.CurrentCell = row.Cells[0];
                            _selectedCounterparties = dgwCounterparties.CurrentRow?.DataBoundItem as Counterparty;
                            break;
                        }
                    }
                }
            }
        }

        private void btnEditCounterparties_Click(object sender, EventArgs e)
        {
            if (_selectedCounterparties == null || dgwCounterparties.CurrentRow == null || _selectedCounterparties.IsDeleted) return;

            int selectedId = _selectedCounterparties.Id;

            using (var form = new AddEditCounterpartyForm(_selectedCounterparties, _context))
            {
                form.isEditMode = true;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _context.Entry(_selectedCounterparties).Reload();
                    LoadCounterparties();

                    foreach (DataGridViewRow row in dgwCounterparties.Rows)
                    {
                        var Counterparti = row.DataBoundItem as Counterparty;
                        if (Counterparti?.Id == selectedId)
                        {
                            dgwCounterparties.CurrentCell = row.Cells[0];
                            break;
                        }
                    }
                }
            }
        }

        private void btnDeleteCounterparties_Click(object sender, EventArgs e)
        {
            if (_selectedCounterparties == null || dgwCounterparties.CurrentRow == null) return;

            int savedIndex = dgwCounterparties.CurrentRow.Index;

            var result = MessageBox.Show(
                $"Вы уверены что хотите удалить источник'{_selectedCounterparties.Name}'?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    _selectedCounterparties.IsDeleted = true;
                    _context.SaveChanges();
                    LoadCounterparties();
                    if (dgwCounterparties.Rows.Count > 0)
                    {
                        int newIndex = savedIndex >= dgwCounterparties.Rows.Count
                            ? dgwCounterparties.Rows.Count - 1
                            : savedIndex;

                        if (dgwCounterparties.Rows.Count > 0 && newIndex >= 0)
                        {
                            dgwCounterparties.CurrentCell = dgwCounterparties.Rows[newIndex].Cells[0];
                            _selectedCounterparties = dgwCounterparties.CurrentRow?.DataBoundItem as Counterparty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления : {ex.Message}");
                }
            }
        }

        #endregion

        #region Долги выданные (Given Debts)
        private void LoadGivenDebts(int? preserveSelectionId = null)
        {
            try
            {
                var statusFilter = cmbGivenDebtStatusFilter.SelectedValue as int? ?? 0;

                var query = _context.Debts
                    .Include(d => d.Counterparty)
                    .Include(d => d.Account)
                    .Include(d => d.Payments)
                    .Where(d => !d.IsDeleted && d.Type == DebtType.Given);

                switch (statusFilter)
                {
                    case 1: // Активные
                        query = query.Where(d => d.Status == DebtStatus.Active);
                        break;
                    case 2: // Закрытые
                        query = query.Where(d => d.Status == DebtStatus.Repaid);
                        break;
                }

                var debts = query
                    .OrderByDescending(d => d.DueDate)
                    .ToList();

                dgwGivenDebts.DataSource = debts;
                UpdateGivenDebtTotals();
                RestoreGridSelection(dgwGivenDebts, preserveSelectionId);
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка загрузки выданных долгов: {ex.Message}");
            }
        }

        private void ApplyDateFilters(ref IQueryable<Debt> query, int month, int year)
        {
            if (month > 0) query = query.Where(d => d.LoanDate.Month == month);
            if (year > 0) query = query.Where(d => d.LoanDate.Year == year);
        }

        private void UpdateGivenDebtTotals()
        {
            var statusFilter = cmbGivenDebtStatusFilter.SelectedValue as int? ?? 0;

            var query = _context.Debts
                .Where(d => d.Type == DebtType.Given && !d.IsDeleted);

            switch (statusFilter)
            {
                case 1:
                    query = query.Where(d => d.Status == DebtStatus.Active);
                    break;
                case 2:
                    query = query.Where(d => d.Status == DebtStatus.Repaid);
                    break;
            }

            var givenTotal = query.Sum(d => d.RemainingAmount);
            lblGivenDebtsTotal.Text = $"Долги выданные: {givenTotal:N2}";
        }

        private void dgwGivenDebts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwGivenDebts.CurrentCell == null) return;
            _selectedGivenDebt = dgwGivenDebts.CurrentRow?.DataBoundItem as Debt;
            btnEditGivenDebt.Enabled = _selectedGivenDebt != null;
            btnDeleteGivenDebt.Enabled = _selectedGivenDebt != null;
            tbDetailsGivenDebts.Text = _selectedGivenDebt?.Comment ?? "";
        }

        private void dgwGivenDebts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var grid = sender as DataGridView;
            grid.CurrentCell = grid.Rows[e.RowIndex].Cells[0];
            btnEditGivenDebt.PerformClick();

        }

        private void dgwGivenDebts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid.Rows[e.RowIndex].DataBoundItem is Debt debt)
            {
                if (dgwGivenDebts.Columns[e.ColumnIndex].Name == "colCounterparty" && e.RowIndex >= 0)
                {
                    debt = dgwGivenDebts.Rows[e.RowIndex].DataBoundItem as Debt;
                    e.Value = debt?.Counterparty?.Name ?? "Контрагент не указан";
                }

                // Подсветка просроченных
                if (debt.DueDate < DateTime.Now && debt.Status == DebtStatus.Active)
                {
                    e.CellStyle.BackColor = Color.LightCoral;
                    e.CellStyle.Font = new Font(grid.Font, FontStyle.Bold);
                }

                // Форматирование статуса
                if (grid.Columns[e.ColumnIndex].Name == "colStatus")
                {
                    e.Value = debt.Status switch
                    {
                        DebtStatus.Active => "Активен",
                        DebtStatus.Repaid => "Погашен",
                        _ => e.Value
                    };
                }
            }
        }

        private void btnAddGivenDebt_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditDebtForm(_context, DebtType.Given))
            {
                form.DataUpdated += (s, args) =>
                {
                    LoadGivenDebts();
                    LoadAccounts();

                    if (form.SavedDebtId.HasValue)
                    {
                        SelectDebtInGrid(dgwGivenDebts, form.SavedDebtId.Value);
                    }
                };

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadGivenDebts(form.SavedDebtId); // Выделяем новую запись
                    LoadAccounts();
                }
            }
        }

        private void btnEditGivenDebt_Click(object sender, EventArgs e)
        {
            if (_selectedGivenDebt == null) return;

            int selectedId = _selectedGivenDebt.Id;

            using (var form = new AddEditDebtForm(_context, DebtType.Given, _selectedGivenDebt))
            {
                form.DataUpdated += (s, args) =>
                {
                    LoadGivenDebts(selectedId);
                    LoadAccounts();
                };

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadGivenDebts(selectedId);
                }
            }
        }

        private void btnDeleteGivenDebt_Click(object sender, EventArgs e)
        {
            if (_selectedGivenDebt == null) return;

            int savedIndex = dgwGivenDebts.CurrentRow.Index; // Сохраняем индекс

            var result = MessageBox.Show(
                $"Вы уверены что хотите удалить долг от {_selectedGivenDebt.LoanDate:d}?\nКонтрагент: {_selectedGivenDebt.Counterparty?.Name}",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            try
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    // ... существующий код удаления ...

                    _context.SaveChanges();
                    transaction.Commit();
                }

                LoadGivenDebts();
                LoadAccounts();

                // Восстанавливаем выделение
                RestoreGridSelection(dgwGivenDebts, savedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления: {ex.Message}");
            }
        }

        private void btnPaymentGivenDebt_Click(object sender, EventArgs e)
        {
            using (var paymentsForm = new PaymentsForm(_context, _selectedGivenDebt?.Id))
            {
                paymentsForm.ShowDialog();

                // Обновить данные после закрытия формы
                if (paymentsForm.DataUpdated)
                {
                    LoadGivenDebts();
                    LoadReceivedDebts();
                }
            }
        }

        private void SelectDebtInGrid(DataGridView grid, int debtId)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                var debt = row.DataBoundItem as Debt;
                if (debt?.Id == debtId)
                {
                    grid.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }

        private void RestoreGridSelection(DataGridView grid, int? originalIndex)
        {
            if (!originalIndex.HasValue || grid.Rows.Count == 0) return;

            int newIndex = originalIndex.Value >= grid.Rows.Count
                ? grid.Rows.Count - 1
                : originalIndex.Value;

            if (newIndex >= 0 && newIndex < grid.Rows.Count)
            {
                grid.Rows[newIndex].Selected = true;
                grid.CurrentCell = grid.Rows[newIndex].Cells[0];
                grid.FirstDisplayedScrollingRowIndex = newIndex;
            }
        }
        #endregion

        #region Долги полученные (Received Debts)
        private void LoadReceivedDebts(int? preserveSelectionId = null)
        {
            try
            {
                var statusFilter = cmbReceivedDebtStatusFilter.SelectedValue as int? ?? 0;

                var query = _context.Debts
                    .Include(d => d.Counterparty)
                    .Include(d => d.Account)
                    .Include(d => d.Payments)
                    .Where(d => !d.IsDeleted && d.Type == DebtType.Received);

                switch (statusFilter)
                {
                    case 1: // Активные
                        query = query.Where(d => d.Status == DebtStatus.Active);
                        break;
                    case 2: // Закрытые
                        query = query.Where(d => d.Status == DebtStatus.Repaid);
                        break;
                }

                var debts = query
                    .OrderByDescending(d => d.DueDate)
                    .ToList();

                dgwReceivedDebts.DataSource = debts;
                UpdateReceivedDebtTotals();
                RestoreGridSelection(dgwReceivedDebts, preserveSelectionId);
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка загрузки выданных долгов: {ex.Message}");
            }
        }

        private void UpdateReceivedDebtTotals()
        {
            var statusFilter = cmbReceivedDebtStatusFilter.SelectedValue as int? ?? 0;

            var query = _context.Debts
                .Where(d => d.Type == DebtType.Received && !d.IsDeleted);

            switch (statusFilter)
            {
                case 1:
                    query = query.Where(d => d.Status == DebtStatus.Active);
                    break;
                case 2:
                    query = query.Where(d => d.Status == DebtStatus.Repaid);
                    break;
            }

            var receivedTotal = query.Sum(d => d.RemainingAmount);
            lblReceivedDebtsTotal.Text = $"Долги полученные: {receivedTotal:N2}";
        }

        private void dgwReceivedDebts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwReceivedDebts.CurrentRow == null) return;
            _selectedReceivedDebt = dgwReceivedDebts.CurrentRow?.DataBoundItem as Debt;
            btnEditReceivedDebt.Enabled = _selectedReceivedDebt != null;
            btnDeleteReceivedDebt.Enabled = _selectedReceivedDebt != null;
        }

        private void dgwReceivedDebts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var grid = sender as DataGridView;
            grid.CurrentCell = grid.Rows[e.RowIndex].Cells[0];
            btnEditReceivedDebt.PerformClick();
        }

        private void dgwReceivedDebts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid.Rows[e.RowIndex].DataBoundItem is Debt debt)
            {

                if (dgwReceivedDebts.Columns[e.ColumnIndex].Name == "colCounterparty" && e.RowIndex >= 0)
                {
                    debt = dgwReceivedDebts.Rows[e.RowIndex].DataBoundItem as Debt;
                    e.Value = debt?.Counterparty?.Name ?? "Контрагент не указан";
                }

                // Подсветка просроченных
                if (debt.DueDate < DateTime.Now && debt.Status == DebtStatus.Active)
                {
                    e.CellStyle.BackColor = Color.LightCoral;
                    e.CellStyle.Font = new Font(grid.Font, FontStyle.Bold);
                }

                // Форматирование статуса
                if (grid.Columns[e.ColumnIndex].Name == "colStatus")
                {
                    e.Value = debt.Status switch
                    {
                        DebtStatus.Active => "Активен",
                        DebtStatus.Repaid => "Погашен",
                        _ => e.Value
                    };
                }
            }
        }

        private void btnAddReceivedDebt_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditDebtForm(_context, DebtType.Received))
            {
                form.DataUpdated += (s, args) =>
                {
                    LoadReceivedDebts();
                    LoadAccounts();

                    if (form.SavedDebtId.HasValue)
                    {
                        SelectDebtInGrid(dgwReceivedDebts, form.SavedDebtId.Value);
                    }
                };

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadReceivedDebts(form.SavedDebtId); // Выделяем новую запись
                    LoadAccounts();
                }
            }
        }

        private void btnEditReceivedDebt_Click(object sender, EventArgs e)
        {
            if (_selectedReceivedDebt == null) return;

            int selectedId = _selectedReceivedDebt.Id;

            using (var form = new AddEditDebtForm(_context, DebtType.Received, _selectedReceivedDebt))
            {
                form.DataUpdated += (s, args) =>
                {
                    LoadReceivedDebts(selectedId);
                    LoadAccounts();
                };

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadReceivedDebts(selectedId);
                }
            }
        }

        private void btnDeleteReceivedDebt_Click(object sender, EventArgs e)
        {
            if (_selectedReceivedDebt == null) return;

            int savedIndex = dgwReceivedDebts.CurrentRow.Index; // Сохраняем индекс

            var result = MessageBox.Show(
                $"Вы уверены что хотите удалить долг от {_selectedReceivedDebt.LoanDate:d}?\nКонтрагент: {_selectedReceivedDebt.Counterparty?.Name}",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            try
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    // ... существующий код удаления ...

                    _context.SaveChanges();
                    transaction.Commit();
                }

                LoadReceivedDebts();
                LoadAccounts();

                // Восстанавливаем выделение
                RestoreGridSelection(dgwReceivedDebts, savedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления: {ex.Message}");
            }
        }

        private void btnPaymentReceivedDebt_Click(object sender, EventArgs e)
        {
            using (var paymentsForm = new PaymentsForm(_context, _selectedReceivedDebt?.Id))
            {
                paymentsForm.ShowDialog();

                // Обновить данные после закрытия формы
                if (paymentsForm.DataUpdated)
                {
                    LoadGivenDebts();
                    LoadReceivedDebts();
                }
            }
        }
        #endregion

        #region Отчеты
        private void InitializeReportPage()
        {
            // Заполнение списка отчетов
            cmbReports.Items.AddRange(new object[]
            {
                new { Text = "Баланс счетов", Type = typeof(AccountsBalanceReport) },
                new { Text = "Динамика баланса", Type = typeof(BalanceDynamicReport) },
                new { Text = "Топ 5 расходов", Type = typeof(TopExpensesReport) },
                new { Text = "Топ 5 приходов", Type = typeof(TopIncomesReport) },
                new { Text = "Источники доходов", Type = typeof(IncomeSourcesReport) },
                new { Text = "Конверсия доходов в сбережения", Type = typeof(IncomeSavingsConversionReport) },
                new { Text = "Распределение расходов", Type = typeof(DistributionExpensesReport) },
                new { Text = "Расходы по категориям", Type = typeof(ExpenseByCategoryReport) },
                new { Text = "Расходы по упоминанию", Type = typeof(AdditionalExpensesReport) },
                new { Text = "Доходы vs Расходы", Type = typeof(IncomeVsExpensesReport) },
                new { Text = "Распределение сумм", Type = typeof(AmountDistributionReport) },
                new { Text = "Календарь трат", Type = typeof(SpendingCalendarReport)  },
                new { Text = "Финансовый профиль", Type = typeof(FinancialProfileReport) },
                new { Text = "Зависимость расходов от доходов", Type = typeof(ExpenseIncomeDependencyReport) },
                new { Text = "Сравнение периодов", Type = typeof(PeriodComparisonReport) },

                //График погашений по месяцам
                //Топ контрагентов
                //Просроченные долги (с подсветкой)
            });

            cmbReports.DisplayMember = "Text";
            cmbReports.ValueMember = "Type";
            cmbReports.SelectedIndexChanged += (s, e) => RefreshReport();

            btnRefresh.Click += (s, e) => RefreshReport();

            dtpStartReportDate.Format = DateTimePickerFormat.Short;
            dtpStartReportDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month - 1, 1);
            dtpStartReportDate.ValueChanged += (s, e) => RefreshReport();

            dtpEndReportDate.Format = DateTimePickerFormat.Short;
            dtpEndReportDate.Value = DateTime.Today;
            dtpEndReportDate.ValueChanged += (s, e) => RefreshReport();

        }

        private void RefreshReport()
        {
            if (cmbReports.SelectedItem == null) return;

            //// Сохраняем текущие фильтры
            var filters = currentReport?.GetFilterValues() ?? new Dictionary<string, object>();

            // Создаем новый отчет
            currentReport = (ReportBase)Activator.CreateInstance(
                (cmbReports.SelectedItem as dynamic).Type,
                _context,
                dtpStartReportDate.Value,
                dtpEndReportDate.Value);

            // Применяем фильтры
            currentReport?.ApplyFilters(filters);

            // Обновляем график
            plotView1.Model = currentReport?.CreatePlotModel();
            //plotView1.Model = currentReport.CreatePlotModel();
            plotView1.InvalidatePlot(true);

            // Обновляем элементы управления
            UpdateFilterControls();
        }

        private void UpdateFilterControls()
        {
            // Очищаем предыдущие фильтры
            pnlFilters.Controls.Clear();

            if (currentReport == null) return;

            // Получаем элементы управления фильтрами из отчета
            var filterControls = currentReport.GetFilterControls();

            // Добавляем элементы на панель с правильным порядком
            foreach (var control in filterControls)
            {
                control.Margin = new Padding(3, 0, 3, 5);
                control.Font = new Font("Segoe UI", 9F);
                pnlFilters.Controls.Add(control);
            }

            pnlFilters.Visible = filterControls != null;

            // Подписываемся на события изменения фильтров
            SubscribeToFilterEvents(filterControls);
        }

        private void SubscribeToFilterEvents(Control[] controls)
        {
            if (currentReport != null)
            {
                // Подписываемся через защищенное событие базового класса
                currentReport.FilterChanged += (s, e) => RefreshReport();
            }

            foreach (var control in controls)
            {
                if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndexChanged += (s, e) =>
                    {
                        // Сохраняем фильтры перед обновлением
                        var filters = currentReport?.GetFilterValues() ?? new Dictionary<string, object>();

                        if (comboBox.SelectedValue != null && comboBox.SelectedValue.GetType() == typeof(int))
                        {
                            filters["CategoryId"] = comboBox.SelectedValue;
                        }
                        else
                        {
                            filters.Remove("CategoryId");
                        }

                        // Принудительное обновление без пересоздания отчета
                        currentReport?.ApplyFilters(currentReport.GetFilterValues());
                        plotView1.Model = currentReport?.CreatePlotModel();
                        plotView1.InvalidatePlot(true);
                    };
                }
            }
        }
        #endregion

        #region О программе
        // проверка наличия обновлений программы
        private void btnCheckUpdate_Click(object sender, EventArgs e)
        {
            const string url = "https://github.com/Ke1dish/K_Accounting";

            try
            {
                // Проверяем валидность URL
                if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    MessageBox.Show("Некорректная ссылка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Современный способ для .NET Core/.NET 5+
                var psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Важно для работы с URL
                };
                Process.Start(psi);
            }
            catch (Win32Exception ex) when ((uint)ex.ErrorCode == 0x80004005)
            {
                Logger.Log(ex);
                // Ошибка "No application is associated with the specified file"
                MessageBox.Show("Не найдено приложение для открытия ссылок",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                // Общая ошибка
                MessageBox.Show($"Не удалось открыть ссылку: {ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private async void CheckForUpdatesButton_Click(object sender, EventArgs e)
        {
            if (VersionChecker.IsUpdateAvailable(out var newVersion,
                out var changelog,
                out var downloadUrl))
            {
                var result = MessageBox.Show(
                    $"Доступна новая версия {newVersion}\n\nИзменения:\n{changelog}\n\nОбновить сейчас?",
                    "Обновление доступно",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Cursor = Cursors.WaitCursor;
                        await Updater.PerformUpdate(downloadUrl);
                    }
                    finally
                    {
                        Cursor = Cursors.Default;
                    }
                }
            }
            else
            {
                MessageBox.Show("У вас установлена последняя версия", "Обновлений нет",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dbVersion = GetDatabaseVersion();
            FeedbackSender.OpenEmailClient(dbVersion);
        }

        private string GetDatabaseVersion()
        {
            using var db = new AppDbContext();
            var lastMigration = db.Database.GetAppliedMigrations().LastOrDefault();
            return lastMigration != null
                ? ExtractVersionFromMigration(lastMigration).ToString("D8") // Формат: 20231015
                : "0.0.0"; // Для новой БД
        }
        #endregion

    }
}


//универсальный способ востанавливать ранее выделенную строку

//private void RestoreGridSelection<T>(DataGridView grid, int? targetId) where T : class
//{
//    if (!targetId.HasValue) return;

//    foreach (DataGridViewRow row in grid.Rows)
//    {
//        var item = row.DataBoundItem as T;
//        if (item != null && (int)item.GetType().GetProperty("Id").GetValue(item) == targetId)
//        {
//            grid.CurrentCell = row.Cells[0];
//            break;
//        }
//    }
//}

//// Использование:
//RestoreGridSelection<Goal>(dgwGoals, _preservedGoalId);
