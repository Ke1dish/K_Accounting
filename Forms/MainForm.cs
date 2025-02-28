using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using K_Accounting.Data;
using K_Accounting.Forms;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;

namespace K_Accounting
{
    // Создать и применить миграцию
    // EntityFrameworkCore\Add-Migration InitialCreate
    // EntityFrameworkCore\Update-Database

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

        public MainForm()
        {
            InitializeComponent();

            InitializeDatabase();

            _context = new AppDbContext();

            InitializeDateFilters();
            cmbExpenseMonths.SelectedIndexChanged += (s, e) => LoadExpenses();
            cmbExpenseYears.SelectedIndexChanged += (s, e) => LoadExpenses();
            cmbIncomeMonths.SelectedIndexChanged += (s, e) => LoadIncomes();
            cmbIncomeYears.SelectedIndexChanged += (s, e) => LoadIncomes();

            if (!CheckDatabaseVersion())
            {
                MessageBox.Show("База данных повреждена. Будет создана новая.",
                               "Ошибка",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
            }

            CreateBackup();

            LoadAccounts();
            LoadAdditionals();
            LoadCategories();
            LoadCurrencies();
            LoadExpenses();
            LoadSources();
            LoadSubCategories();
            LoadIncomes();

            tcPage.Appearance = TabAppearance.FlatButtons;
            tcPage.ItemSize = new Size(0, 1); // Ширина = 0, Высота = 1
            tcPage.SizeMode = TabSizeMode.Fixed;
            tcPage.SelectedIndex = 18;

            cmbExpenseMonths.SelectedIndex = DateTime.Now.Month;
            cmbIncomeMonths.SelectedIndex = DateTime.Now.Month;
        }

        #region MainFom
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

        private void btnCheckUpdate_Click(object sender, EventArgs e)
        {
            const string url = "https://github.com/your_repo";

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
                // Ошибка "No application is associated with the specified file"
                MessageBox.Show("Не найдено приложение для открытия ссылок",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Общая ошибка
                MessageBox.Show($"Не удалось открыть ссылку: {ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

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

            var allYears = expenseYears.Union(incomeYears).OrderBy(y => y).ToList();
            allYears.Insert(0, 0); // Добавляем "Все годы"

            cmbExpenseYears.DataSource = allYears.ToList();
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

        private bool CheckDatabaseVersion()
        {
            var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "finance.db");
            if (!File.Exists(dbPath)) return true;

            try
            {
                using var db = new AppDbContext();
                return db.Database.CanConnect();
            }
            catch
            {
                return false;
            }
        }

        private void CreateBackup()
        {
            var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "finance.db");
            var backupPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                                         $"backup_{DateTime.Now:yyyyMMdd_HHmmss}.db");

            if (File.Exists(dbPath))
            {
                try
                {
                    File.Copy(dbPath, backupPath);
                }
                catch
                {
                    // Логирование ошибки
                }
            }
        }

        private void InitializeDatabase()
        {
            var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "finance.db");

            // Если базы нет - создаем
            if (!File.Exists(dbPath))
            {
                try
                {
                    using (var db = new AppDbContext())
                    {
                        db.Database.EnsureCreated();
                        SeedInitialData(db);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка создания базы данных: {ex.Message}");
                }
            }
        }

        private void SeedInitialData(AppDbContext db)
        {
            //// Добавляем системные записи
            //if (!db.Currencies.Any())
            //{
            //    db.Currencies.Add(new Currency
            //    {
            //        Name = "Рубль",
            //        Rate = 1.0m,
            //        Comment = "рубль"
            //    });
            //}

            db.SaveChanges();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context?.Dispose();
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
                case 4: // Категории и Подкатегории
                    LoadCategories();
                    LoadSubCategories();
                    break;
                case 5: // Источники
                    LoadSources();
                    break;
                case 6: // Дополнительно
                    LoadAdditionals();
                    break;
                case 7: // Валюты
                    LoadCurrencies();
                    break;
                case 8: // Отчеты
                    break;
                case 9: // Настройки
                    break;
                case 10: // О программе
                    var assembly = Assembly.GetEntryAssembly();

                    var replacements = new Dictionary<string, string>
                    {
                        { "{Version}", assembly?.GetName().Version?.ToString() ?? "1.0.0" },
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

        private void cmbReportTipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "";
            switch (cmbReportTipe.SelectedIndex)
            {
                case 0: // Счета
                    s = "Отображает текущие остатки на всех счетах (наличные, карты, вклады).";
                    break;
                case 1: // Счета
                    s = "Изменение общего баланса с течением времени.";
                    break;
                case 2: // Расходы
                    s = "Основные статьи расходов или источники доходов за период.";
                    break;
                case 3: // Доходы
                    s = "Основные источники поступлений за выбранный период.";
                    break;
                case 4: // Категории и Подкатегории
                    s = "Показывает, какая часть доходов сохраняется после обязательных трат.";
                    break;
                case 5: // Источники
                    s = "Визуализирует доли трат по категориям за выбранный период. Позволяет быстро определить самые затратные статьи.";
                    break;
                case 6: // Дополнительно
                    s = "Распределение трат по основным категориям.";
                    break;
                case 7: // Валюты
                    s = "Распределение трат по дополнительным параметрам (например, член семьи).";
                    break;
                case 8: // Отчеты
                    s = "Сравнение доходов и расходов по месяцам.";
                    break;
                case 9: // Настройки
                    s = "Частота операций в разных ценовых диапазонах.";
                    break;
                case 10: // О программе
                    s = "Активность операций по дням.";
                    break;
                case 11: // О программе
                    s = "Оценивает баланс между ключевыми финансовыми показателями (сбережения, долги, доходы и т.д.).";
                    break;
                case 12: // О программе
                    s = "Анализирует, как траты растут/падают в зависимости от уровня доходов.";
                    break;
                case 13: // О программе
                    s = "Анализ доходов/расходов за разные периоды.";
                    break;
                default:
                    break;
            }
            tbDetailsReport.Text = s;
        }

        #endregion

        #region Счета (Account)
        private void LoadAccounts()
        {
            if (dgwAccounts == null) return;

            if (dgwAccounts.Columns.Count == 0)
            {
                dgwAccounts.AutoGenerateColumns = false;
                dgwAccounts.Columns.AddRange(
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colName",
                        DataPropertyName = "Name",
                        HeaderText = "Название",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    },
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colBalance",
                        DataPropertyName = "Balance",
                        HeaderText = "Баланс",
                        DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
                    },
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colCurrency",
                        DataPropertyName = "Currency.Name",
                        HeaderText = "Валюта",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    }
                );
            }

            try
            {
                var accounts = _context.Accounts
                    .Include(a => a.Currency)
                    .Where(a => !a.IsDeleted)
                    .OrderBy(a => a.Name)
                    .ToList();

                dgwAccounts.DataSource = accounts;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки счетов: {ex.Message}");
            }
        }

        private void dataGridViewAccounts_SelectionChanged(object sender, EventArgs e)
        {
            _selectedAccount = dgwAccounts.CurrentRow?.DataBoundItem as Account;
            btnEditAccount.Enabled = _selectedAccount != null;
            btnDeleteAccount.Enabled = _selectedAccount != null;

            if (_selectedAccount == null)
                tbDetailsAccount.Text = "";
            else
                tbDetailsAccount.Text = _selectedAccount.Comment;
        }

        private void dataGridViewAccounts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgwAccounts.Columns["colCurrency"].Index)
            {
                var account = dgwAccounts.Rows[e.RowIndex].DataBoundItem as Account;
                e.Value = account?.Currency?.Name ?? "Валюта не указана";
            }
        }

        private void btnAddAccounts_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditAccountsForm(_context))
            {
                form.isEditMode = false;
                // Подписываемся на событие CurrencyAdded
                form.DataUpdated += (s, args) =>
                {
                    // Обновляем список валют и счетов
                    LoadCurrencies();
                    LoadAccounts();
                };

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadAccounts();
                }
            }
        }

        private void btnEditAccounts_Click(object sender, EventArgs e)
        {
            if (_selectedAccount == null) return;

            using (var form = new AddEditAccountsForm(_context, _selectedAccount))
            {
                form.isEditMode = true;
                form.DataUpdated += (s, args) =>
                {
                    LoadCurrencies();
                    LoadAccounts();
                };
                form.ShowDialog();
            }
        }

        private void btnDeleteAccounts_Click(object sender, EventArgs e)
        {
            if (_selectedAccount == null) return;

            int savedIndex = dgwAccounts.CurrentRow.Index;    //********************* пробуем сохранение позиции при удалении

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

                    if (dgwAccounts.Rows.Count > 0)    //********************* пробуем сохранение позиции при удалении
                    {
                        int newIndex = Math.Min(savedIndex, dgwAccounts.Rows.Count - 1);    //********************* пробуем сохранение позиции при удалении
                        dgwAccounts.CurrentCell = dgwAccounts.Rows[newIndex].Cells[0];    //********************* пробуем сохранение позиции при удалении
                    }
                }
                catch (Exception ex)
                {
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
                    LoadExpenses();
                    LoadIncomes();
                }
            }
        }


        #endregion

        #region Расходы (Expense)
        private void LoadExpenses()
        {
            if (dgwExpenses == null) return;

            if (dgwExpenses.Columns.Count == 0)
            {
                dgwExpenses.AutoGenerateColumns = false;
                dgwExpenses.Columns.AddRange(
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colDate",
                        DataPropertyName = "Date",
                        HeaderText = "Дата",
                        DefaultCellStyle = new DataGridViewCellStyle
                        {
                            Format = "dd.MM.yyyy HH:mm"
                        }
                    },
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colAmount",
                        DataPropertyName = "Amount",
                        HeaderText = "Сумма",
                        DefaultCellStyle = new DataGridViewCellStyle
                        {
                            Format = "N2"
                        }
                    },
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colAccount",
                        HeaderText = "Счет",
                        DataPropertyName = "Account.Name"
                    },
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colCategory",
                        HeaderText = "Категория",
                        DataPropertyName = "Category.Name"
                    },
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colSubCategory",
                        HeaderText = "Подкатегория",
                        DataPropertyName = "SubCategory.Name"
                    },
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colAdditional",
                        HeaderText = "Дополнительно",
                        DataPropertyName = "Additional.Name"
                    }
                );
            }

            try
            {
                var selectedMonth = (int)cmbExpenseMonths.SelectedValue;
                var selectedYear = (int)cmbExpenseYears.SelectedItem;

                var query = _context.Expenses
                    .Include(e => e.Account)
                    .Include(e => e.Category)
                    .Include(e => e.SubCategory)
                    .Include(e => e.Additional)
                    .Where(e => !e.IsDeleted);

                if (selectedMonth > 0)
                    query = query.Where(e => e.Date.Month == selectedMonth);

                if (selectedYear > 0)
                    query = query.Where(e => e.Date.Year == selectedYear);

                var expenses = query
                    .OrderByDescending(e => e.Date)
                    .ToList();

                dgwExpenses.DataSource = expenses;
            }
            catch (Exception ex)
            {
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
                tbDetailsExpenses.Text = _selectedAccount.Comment;
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
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshYearFilters();
                    LoadExpenses();
                    LoadAccounts(); // Обновляем балансы счетов
                }
            }
        }

        private void btnDeleteExpenses_Click(object sender, EventArgs e)
        {
            if (_selectedExpense == null) return;

            int savedIndex = dgwExpenses.CurrentRow.Index;    //********************* пробуем сохранение позиции при удалении

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

                    if (dgwExpenses.Rows.Count > 0)    //********************* пробуем сохранение позиции при удалении
                    {
                        int newIndex = Math.Min(savedIndex, dgwExpenses.Rows.Count - 1);    //********************* пробуем сохранение позиции при удалении
                        dgwExpenses.CurrentCell = dgwExpenses.Rows[newIndex].Cells[0];    //********************* пробуем сохранение позиции при удалении
                    }

                    MessageBox.Show("Расход успешно удален. Средства возвращены на счет.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}\n\nДетали:\n{ex.InnerException?.Message}");
            }
        }
        #endregion

        #region Доходы (Income)
        private void LoadIncomes()
        {
            if (dgwIncomes == null) return;

            if (dgwIncomes.Columns.Count == 0)
            {
                dgwIncomes.AutoGenerateColumns = false;
                dgwIncomes.Columns.AddRange(
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colDate",
                        DataPropertyName = "Date",
                        HeaderText = "Дата",
                        DefaultCellStyle = new DataGridViewCellStyle
                        {
                            Format = "dd.MM.yyyy HH:mm"
                        }
                    },
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colAmount",
                        DataPropertyName = "Amount",
                        HeaderText = "Сумма",
                        DefaultCellStyle = new DataGridViewCellStyle
                        {
                            Format = "N2"
                        }
                    },
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colAccount",
                        HeaderText = "Счет",
                        DataPropertyName = "Account.Name"
                    },
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colSource",
                        HeaderText = "Источник",
                        DataPropertyName = "Account.Source"
                    }
                );
            }

            try
            {
                var selectedMonth = (int)cmbIncomeMonths.SelectedValue;
                var selectedYear = (int)cmbIncomeYears.SelectedItem;

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
            }
            catch (Exception ex)
            {
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

            int savedIndex = dgwIncomes.CurrentRow.Index;    //********************* пробуем сохранение позиции при удалении

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
                    if (dgwIncomes.Rows.Count > 0)    //********************* пробуем сохранение позиции при удалении
                    {
                        int newIndex = Math.Min(savedIndex, dgwIncomes.Rows.Count - 1);    //********************* пробуем сохранение позиции при удалении
                        dgwIncomes.CurrentCell = dgwIncomes.Rows[newIndex].Cells[0];    //********************* пробуем сохранение позиции при удалении
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
        }
        #endregion

        #region Категории (Category)
        private void LoadCategories()
        {
            if (dgwCategorie == null) return;

            if (dgwCategorie.Columns.Count == 0)
            {
                dgwCategorie.AutoGenerateColumns = false;
                dgwCategorie.Columns.AddRange(
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colName",
                        DataPropertyName = "Name",
                        HeaderText = "Название",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    }
                );
            }

            try
            {
                var categories = _context.Categories
                    .Where(c => !c.IsDeleted)
                    .OrderBy(c => c.Name)
                    .ToList();

                dgwCategorie.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки категорий: {ex.Message}");
            }
        }

        private void dataGridViewCategories_SelectionChanged(object sender, EventArgs e)
        {
            _selectedCategory = dgwCategorie.CurrentRow?.DataBoundItem as Category;
            btnEditCategories.Enabled = _selectedCategory != null;
            btnDeleteCategories.Enabled = _selectedCategory != null;

            if (_selectedCategory == null)
                tbDetailsCategory.Text = "";
            else
                tbDetailsCategory.Text = _selectedCategory.Comment;

            LoadSubCategories(_selectedCategory?.Id);
        }

        private void btnAddCategories_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditCategoryForm())
            {
                form.isEditMode = false;
                form.DataUpdated += (s, args) =>
                {
                    LoadCategories();
                    LoadSubCategories(_selectedCategory?.Id);
                };

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadCategories();
                    LoadSubCategories(_selectedCategory?.Id);
                }
            }
        }

        private void btnEditCategories_Click(object sender, EventArgs e)
        {
            if (_selectedCategory == null) return;

            using (var tempContext = new AppDbContext())
            {
                var categoryToEdit = tempContext.Categories.Find(_selectedCategory.Id);

                using (var form = new AddEditCategoryForm(categoryToEdit))
                {
                    form.isEditMode = true;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _context.Entry(_selectedCategory).Reload();
                        LoadCategories();
                    }
                }
            }
        }

        private void btnDeleteCategories_Click(object sender, EventArgs e)
        {
            if (_selectedCategory == null) return;

            int savedIndex = dgwCategorie.CurrentRow.Index;    //********************* пробуем сохранение позиции при удалении

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

                    if (dgwCategorie.Rows.Count > 0)    //********************* пробуем сохранение позиции при удалении
                    {
                        int newIndex = Math.Min(savedIndex, dgwCategorie.Rows.Count - 1);    //********************* пробуем сохранение позиции при удалении
                        dgwCategorie.CurrentCell = dgwCategorie.Rows[newIndex].Cells[0];    //********************* пробуем сохранение позиции при удалении
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}");
                }
            }
        }
        #endregion

        #region Подкатегории (SubCategory)
        private void LoadSubCategories()
        {
            if (dgwSubCategories == null) return;

            if (dgwSubCategories.Columns.Count == 0)
            {
                dgwSubCategories.AutoGenerateColumns = false;
                dgwSubCategories.Columns.AddRange(
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colName",
                        DataPropertyName = "Name",
                        HeaderText = "Название",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    },
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colCategory",
                        HeaderText = "Категория",
                        DataPropertyName = "Category.Name", // Важное изменение
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    }
                );
            }

            try
            {
                // Явная загрузка связанных данных
                var subCategories = _context.SubCategories
                    .Include(s => s.Category) // Важно: подключаем категории
                    .Where(s => !s.IsDeleted)
                    .OrderBy(s => s.Name)
                    .ToList();

                dgwSubCategories.DataSource = subCategories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки подкатегорий: {ex.Message}");
            }
        }

        private void LoadSubCategories(int? categoryId = null)
        {
            if (dgwSubCategories == null) return;

            try
            {
                var query = _context.SubCategories
                    .Include(s => s.Category)
                    .Where(s => !s.IsDeleted);

                if (categoryId.HasValue)
                {
                    query = query.Where(s => s.CategoryId == categoryId);
                }

                dgwSubCategories.DataSource = query
                    .OrderBy(s => s.Name)
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки подкатегорий: {ex.Message}");
            }
        }

        private void dataGridViewSubCategories_SelectionChanged(object sender, EventArgs e)
        {
            _selectedSubCategory = dgwSubCategories.CurrentRow?.DataBoundItem as SubCategory;
            btnEditSubCategories.Enabled = _selectedSubCategory != null;
            btnDeleteSubCategories.Enabled = _selectedSubCategory != null;

            if (_selectedSubCategory == null)
                tbDetailsSubCategory.Text = "";
            else
                tbDetailsSubCategory.Text = _selectedSubCategory.Comment;
        }

        private void dataGridViewSubCategories_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgwSubCategories.Columns["colCategory"].Index)
            {
                var subCat = dgwSubCategories.Rows[e.RowIndex].DataBoundItem as SubCategory;
                e.Value = subCat?.Category?.Name ?? "Без категории";
            }
        }

        private void btnAddSubCategories_Click(object sender, EventArgs e)
        {
            int? selectedCategoryId = _selectedCategory?.Id;

            using (var form = new AddEditSubCategoryForm(_context, selectedCategoryId))
            {
                form.isEditMode = false;
                form.CategoryAdded += (s, args) =>
                {
                    LoadCategories();
                    LoadSubCategories(selectedCategoryId);
                };

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadSubCategories(selectedCategoryId);
                }
            }
        }

        private void btnEditSubCategories_Click(object sender, EventArgs e)
        {
            if (_selectedSubCategory == null) return;

            using (var tempContext = new AppDbContext())
            {
                var subCategoryToEdit = tempContext.SubCategories
                    .Include(s => s.Category)
                    .FirstOrDefault(s => s.Id == _selectedSubCategory.Id);

                using (var form = new AddEditSubCategoryForm(subCategoryToEdit))
                {
                    form.isEditMode = true;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _context.Entry(_selectedSubCategory).Reload();
                        LoadSubCategories();
                        LoadSubCategories(_selectedCategory?.Id);
                    }
                }
            }
        }

        private void btnDeleteSubCategories_Click(object sender, EventArgs e)
        {
            if (_selectedSubCategory == null) return;

            int savedIndex = dgwSubCategories.CurrentRow.Index;    //********************* пробуем сохранение позиции при удалении

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
                    LoadSubCategories();
                    if (dgwSubCategories.Rows.Count > 0)    //********************* пробуем сохранение позиции при удалении
                    {
                        int newIndex = Math.Min(savedIndex, dgwSubCategories.Rows.Count - 1);    //********************* пробуем сохранение позиции при удалении
                        dgwSubCategories.CurrentCell = dgwSubCategories.Rows[newIndex].Cells[0];    //********************* пробуем сохранение позиции при удалении
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}");
                }
            }
        }
        #endregion

        #region Дополнительно (Additionaly)
        private void LoadAdditionals()
        {
            if (dgwAdditionals == null) return;

            if (dgwAdditionals.Columns.Count == 0)
            {
                dgwAdditionals.AutoGenerateColumns = false;
                dgwAdditionals.Columns.AddRange(
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colName",
                        DataPropertyName = "Name",
                        HeaderText = "Название",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    }
                );
            }

            try
            {
                var additionals = _context.Additionals
                    .Where(a => !a.IsDeleted)
                    .OrderBy(a => a.Name)
                    .ToList();

                dgwAdditionals.DataSource = additionals;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}");
            }
        }

        private void dataGridViewAdditionals_SelectionChanged(object sender, EventArgs e)
        {
            _selectedAdditional = dgwAdditionals.CurrentRow?.DataBoundItem as Additional;
            btnEditAdditionals.Enabled = _selectedAdditional != null;
            btnDeleteAdditional.Enabled = _selectedAdditional != null;

            if (_selectedAdditional == null)
                tbDetailsAdditional.Text = "";
            else
                tbDetailsAdditional.Text = _selectedAdditional.Comment;
        }

        private void btnAddAdditionals_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditAdditionalForm())
            {
                form.isEditMode = false;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadAdditionals();
                }
            }
        }

        private void btnEditAdditionals_Click(object sender, EventArgs e)
        {
            if (_selectedAdditional == null) return;

            using (var tempContext = new AppDbContext())
            {
                var additionalToEdit = tempContext.Additionals.Find(_selectedAdditional.Id);

                using (var form = new AddEditAdditionalForm(additionalToEdit))
                {
                    form.isEditMode = true;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _context.Entry(_selectedAdditional).Reload();
                        LoadAdditionals();
                    }
                }
            }
        }

        private void btnDeleteAdditionals_Click(object sender, EventArgs e)
        {
            if (_selectedAdditional == null) return;

            int savedIndex = dgwAdditionals.CurrentRow.Index;    //********************* пробуем сохранение позиции при удалении

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
                    if (dgwAdditionals.Rows.Count > 0)    //********************* пробуем сохранение позиции при удалении
                    {
                        int newIndex = Math.Min(savedIndex, dgwAdditionals.Rows.Count - 1);    //********************* пробуем сохранение позиции при удалении
                        dgwAdditionals.CurrentCell = dgwAdditionals.Rows[newIndex].Cells[0];    //********************* пробуем сохранение позиции при удалении
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}");
                }
            }
        }
        #endregion

        #region Источники (Source)
        private void LoadSources()
        {
            if (dgwSource == null) return;

            if (dgwSource.Columns.Count == 0)
            {
                dgwSource.AutoGenerateColumns = false;
                dgwSource.Columns.AddRange(
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colName",
                        DataPropertyName = "Name",
                        HeaderText = "Название",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    }
                );
            }

            try
            {
                var sources = _context.Sources
                    .Where(s => !s.IsDeleted)
                    .OrderBy(s => s.Name)
                    .ToList();

                dgwSource.DataSource = sources;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки источников: {ex.Message}");
            }
        }

        private void dataGridViewSources_SelectionChanged(object sender, EventArgs e)
        {
            _selectedSource = dgwSource.CurrentRow?.DataBoundItem as Source;
            btnEditSource.Enabled = _selectedSource != null;
            btnDeleteSource.Enabled = _selectedSource != null;

            if (_selectedSource == null)
                tbDetailsSource.Text = "";
            else
                tbDetailsSource.Text = _selectedSource.Comment;
        }

        private void btnAddSources_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditSourceForm())
            {
                form.isEditMode = false;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadSources();
                }
            }
        }

        private void btnEditSources_Click(object sender, EventArgs e)
        {
            if (_selectedSource == null) return;

            using (var tempContext = new AppDbContext())
            {
                var sourceToEdit = tempContext.Sources.Find(_selectedSource.Id);

                using (var form = new AddEditSourceForm(sourceToEdit))
                {
                    form.isEditMode = true;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _context.Entry(_selectedSource).Reload();
                        LoadSources();
                    }
                }
            }
        }

        private void btnDeleteSources_Click(object sender, EventArgs e)
        {
            if (_selectedSource == null) return;

            int savedIndex = dgwSource.CurrentRow.Index;    //********************* пробуем сохранение позиции при удалении

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
                    if (dgwSource.Rows.Count > 0)    //********************* пробуем сохранение позиции при удалении
                    {
                        int newIndex = Math.Min(savedIndex, dgwSource.Rows.Count - 1);    //********************* пробуем сохранение позиции при удалении
                        dgwSource.CurrentCell = dgwSource.Rows[newIndex].Cells[0];    //********************* пробуем сохранение позиции при удалении
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}");
                }
            }
        }
        #endregion

        #region Валюты (Currency)
        private void LoadCurrencies()
        {
            if (dgwCurrencies == null) return;

            if (dgwCurrencies.Columns.Count == 0)
            {
                dgwCurrencies.AutoGenerateColumns = false;
                dgwCurrencies.Columns.AddRange(
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colName",
                        DataPropertyName = "Name",
                        HeaderText = "Название"
                    },
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colCode",
                        DataPropertyName = "Code",
                        HeaderText = "Код"
                    },
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colSymbol",
                        DataPropertyName = "Symbol",
                        HeaderText = "Символ"
                    },
                    new DataGridViewTextBoxColumn
                    {
                        Name = "colRate",
                        DataPropertyName = "Rate",
                        HeaderText = "Курс",
                        DefaultCellStyle = new DataGridViewCellStyle
                        {
                            Format = "N6"
                        }
                    }
                );
            }

            try
            {
                var currencies = _context.Currencies
                    .Where(c => !c.IsDeleted)
                    .OrderBy(c => c.Name)
                    .ToList();

                dgwCurrencies.DataSource = currencies;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки валют: {ex.Message}");
            }
        }

        private void dataGridViewCurrencies_SelectionChanged(object sender, EventArgs e)
        {
            _selectedCurrency = dgwCurrencies.CurrentRow?.DataBoundItem as Currency;
            btnEditCurrency.Enabled = _selectedCurrency != null;
            btnDeleteCurrency.Enabled = _selectedCurrency != null;

            if (_selectedCurrency == null)
                tbDetailsCurrency.Text = "";
            else
                tbDetailsCurrency.Text = _selectedCurrency.Comment;
        }

        private void btnAddCurrencie_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditCurrencyForm())
            {
                form.isEditMode = false;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadCurrencies();
                }
            }
        }

        private void btnEditCurrencie_Click(object sender, EventArgs e)
        {
            if (_selectedCurrency == null) return;

            // Важно: Создаем новый контекст для формы редактирования
            using (var tempContext = new AppDbContext())
            {
                var currencyToEdit = tempContext.Currencies.Find(_selectedCurrency.Id);

                using (var form = new AddEditCurrencyForm(currencyToEdit))
                {
                    form.isEditMode = true;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // Обновляем основной контекст
                        _context.Entry(_selectedCurrency).Reload();
                        LoadCurrencies();
                    }
                }
            }
        }

        private void btnDeleteCurrencie_Click(object sender, EventArgs e)
        {
            if (_selectedCurrency == null) return;

            int savedIndex = dgwCurrencies.CurrentRow.Index;    //********************* пробуем сохранение позиции при удалении

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
                    if (dgwCurrencies.Rows.Count > 0)    //********************* пробуем сохранение позиции при удалении
                    {
                        int newIndex = Math.Min(savedIndex, dgwCurrencies.Rows.Count - 1);    //********************* пробуем сохранение позиции при удалении
                        dgwCurrencies.CurrentCell = dgwCurrencies.Rows[newIndex].Cells[0];    //********************* пробуем сохранение позиции при удалении
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}");
                }
            }
        }

        #endregion

    }
}