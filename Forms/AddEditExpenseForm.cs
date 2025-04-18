using System.Data;
using K_Accounting.Data;
using K_Accounting.Models;
using K_Accounting.Utilities;
using Microsoft.EntityFrameworkCore;

namespace K_Accounting.Forms
{
    public partial class AddEditExpenseForm : Form
    {
        private readonly AppDbContext _context;

        private Expense _expense;
        private decimal _originalAmount;
        private int _originalAccountId;

        private MeasurementUnit _selectedMeasurementUnit;

        private bool _isEditMode;
        public bool isEditMode
        {
            get => _isEditMode;
            set
            {
                _isEditMode = value;
                Text = value ? "Редактирование расхода" : "Добавление рахода";
                btnOk.Text = value ? "Сохранить" : "Создать";
                btnAdd.Visible = value ? false : true;
            }
        }

        // Добавляем унифицированное событие
        public event EventHandler DataUpdated;

        public AddEditExpenseForm(AppDbContext context)
        {
            InitializeComponent();
            numAmount.Value = 1;
            numAmount.Controls[0].Visible = false;
            numQuantity.Controls[0].Visible = false;
            _context = context;
            InitializeData();
            dtpDate.Focus();

            _expense = new Expense
            {
                Quantity = 1,
                IsAutoUnit = true
            };
        }

        public AddEditExpenseForm(AppDbContext context, Expense template) : this(context)
        {
            _expense = context.Expenses
                .Include(e => e.Account)
                .Include(e => e.Category)
                .Include(e => e.SubCategory)
                .Include(e => e.Additional)
                .FirstOrDefault(e => e.Id == template.Id);

            if (_expense == null)
            {
                MessageBox.Show("Расход не найден в базе данных");
                this.Close();
                return;
            }

            // Загрузка данных с учетом возможных удаленных связей
            try
            {
                LoadExpenseData();
                cmbCategory_SelectedIndexChanged(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show("Некоторые связанные элементы шаблона были удалены");
                this.Close();
            }
        }

        private void NotifyDataUpdated()
        {
            DataUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void InitializeData()
        {
            // Загрузка счетов
            cmbAccount.DataSource = _context.Accounts
                .Where(a => !a.IsDeleted)
                .ToList();
            cmbAccount.DisplayMember = "Name";
            cmbAccount.ValueMember = "Id";
            cmbAccount.AutoCompleteMode = AutoCompleteMode.SuggestAppend; // Добавить
            cmbAccount.AutoCompleteSource = AutoCompleteSource.ListItems; // Добавить
            cmbAccount.DropDownStyle = ComboBoxStyle.DropDown; // Добавить

            // Загрузка категорий
            cmbCategory.DataSource = _context.Categories
                .Where(c => !c.IsDeleted)
                .ToList();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend; // Добавить
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems; // Добавить
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDown; // Добавить

            // Загрузка подкатегорий
            cmbSubCategory.DataSource = null;
            cmbSubCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSubCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSubCategory.DropDownStyle = ComboBoxStyle.DropDown;

            // Загрузка дополнений
            cmbAdditional.DataSource = _context.Additionals
                .Where(a => !a.IsDeleted)
                .ToList();
            cmbAdditional.DisplayMember = "Name";
            cmbAdditional.ValueMember = "Id";
            cmbAdditional.AutoCompleteMode = AutoCompleteMode.SuggestAppend; // Добавить
            cmbAdditional.AutoCompleteSource = AutoCompleteSource.ListItems; // Добавить
            cmbAdditional.DropDownStyle = ComboBoxStyle.DropDown; // Добавить

            cmbCategory_SelectedIndexChanged(null, EventArgs.Empty);

            cmbMeasurement.DataSource = _context.MeasurementUnits
                .Where(u => !u.IsDeleted)
                .ToList();
            cmbMeasurement.DisplayMember = "Name";
            cmbMeasurement.ValueMember = "Id";
            cmbMeasurement.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMeasurement.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadExpenseData()
        {
            if (_expense == null) return;

            try
            {
                // Проверка существования связанных объектов
                var accountExists = _context.Accounts.Any(a => a.Id == _expense.AccountId);
                var categoryExists = _context.Categories.Any(c => c.Id == _expense.CategoryId);
                var subCategoryExists = _context.SubCategories.Any(s => s.Id == _expense.SubCategoryId);

                if (!accountExists || !categoryExists || !subCategoryExists)
                    throw new Exception("Связанные данные не найдены");

                // Заполнение полей
                dtpDate.Value = _expense.Date;
                numAmount.Value = _expense.Amount;
                cmbAccount.SelectedValue = _expense.AccountId;
                cmbCategory.SelectedValue = _expense.CategoryId;
                cmbSubCategory.SelectedValue = _expense.SubCategoryId;
                cmbAdditional.SelectedValue = _expense.AdditionalId;
                txtComment.Text = _expense.Comment;
                chkIsTemplate.Checked = _expense.IsTemplate;
                _originalAmount = _expense.Amount;                     //////////////////
                _originalAccountId = _expense.AccountId; // Важно!     //////////////////

                // Новая: Загрузка количества
                numQuantity.Value = _expense.Quantity;

                // Новая: Проверка видимости
                var subCategory = cmbSubCategory.SelectedItem as SubCategory;
                bool showQuantity = (subCategory?.RequireQuantity == true) ||
                                   (subCategory?.InheritQuantityRequirement == true &&
                                    subCategory?.Category?.RequireQuantity == true);
                ShowQuantity(showQuantity);

                // Новая логика - загрузка количества
                numQuantity.Value = _expense.Quantity;

                // Принудительно вызываем проверку видимости
                cmbSubCategory_SelectedIndexChanged(null, EventArgs.Empty);

                if (_expense.MeasurementUnitId != null)
                    cmbMeasurement.SelectedValue = _expense.MeasurementUnitId;
                else
                    LoadDefaultMeasurementUnit();
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка загрузки шаблона: {ex.Message}");
                this.Close();
            }

            // Новая: Инициализация для новых записей
            if (_expense == null)
            {
                _expense = new Expense
                {
                    Quantity = 1,
                    IsAutoUnit = true
                };
            }
        }

        private void LoadDefaultMeasurementUnit()
        {
            var subCategory = cmbSubCategory.SelectedItem as SubCategory;
            if (subCategory?.MeasurementUnitId != null)
                cmbMeasurement.SelectedValue = subCategory.MeasurementUnitId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var account = (Account)cmbAccount.SelectedItem;
                    var newAmount = numAmount.Value;
                    var newAccountId = (int)cmbAccount.SelectedValue;

                    // Новая: Получаем требования к количеству
                    var subCategory = cmbSubCategory.SelectedItem as SubCategory;
                    bool requireQuantity = (subCategory?.RequireQuantity == true) ||
                                         (subCategory?.InheritQuantityRequirement == true &&
                                          subCategory?.Category?.RequireQuantity == true);

                    if (_isEditMode)
                    {
                        // Возвращаем старую сумму
                        var originalAccount = _context.Accounts.Find(_originalAccountId);
                        originalAccount.Balance += _originalAmount;

                        // Обновляем расход
                        _expense.Date = dtpDate.Value;
                        _expense.Amount = newAmount;
                        _expense.AccountId = newAccountId;
                        _expense.CategoryId = (int)cmbCategory.SelectedValue;
                        _expense.SubCategoryId = (int)cmbSubCategory.SelectedValue;
                        _expense.AdditionalId = (int)cmbAdditional.SelectedValue;
                        _expense.Comment = txtComment.Text;
                        _expense.IsTemplate = chkIsTemplate.Checked;
                        _expense.MeasurementUnitId = (int)cmbMeasurement.SelectedValue;

                        // Новая: Сохранение количества
                        _expense.Quantity = requireQuantity ? numQuantity.Value : 1;
                        _expense.IsAutoUnit = (numQuantity.Value == 1) || !requireQuantity;
                    }
                    else
                    {
                        // Создаем новый расход
                        _expense = new Expense
                        {
                            Date = dtpDate.Value,
                            Amount = newAmount,
                            AccountId = newAccountId,
                            CategoryId = (int)cmbCategory.SelectedValue,
                            SubCategoryId = (int)cmbSubCategory.SelectedValue,
                            AdditionalId = (int)cmbAdditional.SelectedValue,
                            Comment = txtComment.Text,
                            IsTemplate = chkIsTemplate.Checked,
                            MeasurementUnitId = (int)cmbMeasurement.SelectedValue,

                            // Новая: Инициализация количества
                            Quantity = requireQuantity ? numQuantity.Value : 1,
                            IsAutoUnit = (numQuantity.Value == 1) || !requireQuantity
                        };
                        _context.Expenses.Add(_expense);
                    }

                    // Вычитаем новую сумму
                    account.Balance -= newAmount;

                    // Проверка отрицательного баланса
                    if (account.Balance < 0)
                    {
                        MessageBox.Show("Недостаточно средств на счете");
                        transaction.Rollback();
                        return;
                    }

                    _context.SaveChanges();

                    transaction.Commit();
                    _context.Entry(_expense).Reload(); // Важно!
                    DataUpdated?.Invoke(this, EventArgs.Empty);

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                    transaction.Rollback();
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}");
                }
            }
        }

        private bool ValidateForm()
        {

            if (numAmount.Value <= 0)
            {
                MessageBox.Show("Сумма должна быть больше нуля");
                return false;
            }

            // Проверка счета
            if (cmbAccount.SelectedValue == null || !(cmbAccount.SelectedItem is Account))
            {
                MessageBox.Show("Выберите существующий счет из списка");
                return false;
            }

            // Проверка категории
            if (cmbCategory.SelectedValue == null || !(cmbCategory.SelectedItem is Category))
            {
                MessageBox.Show("Выберите существующую категорию из списка");
                return false;
            }

            // Проверка подкатегории
            if (cmbSubCategory.SelectedValue == null || !(cmbSubCategory.SelectedItem is SubCategory))
            {
                MessageBox.Show("Выберите существующую подкатегорию из списка");
                return false;
            }

            // Проверка единицы измерения (если требуется)
            if (cmbMeasurement.Visible && (cmbMeasurement.SelectedValue == null || !(cmbMeasurement.SelectedItem is MeasurementUnit)))
            {
                MessageBox.Show("Выберите единицу измерения");
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditAccountsForm(_context)) // Теперь корректно
            {
                form.DataUpdated += (s, args) =>
                {
                    LoadAccounts();
                    if (form.SavedAccountId > 0)
                        cmbAccount.SelectedValue = form.SavedAccountId;
                };
                form.ShowDialog();
            }
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditCategoryForm(_context)) // Корректный вызов
            {
                form.DataUpdated += (s, args) =>
                {
                    // Обновляем список категорий
                    var categories = _context.Categories
                        .Where(c => !c.IsDeleted)
                        .ToList();

                    cmbCategory.BeginUpdate();
                    cmbCategory.DataSource = null;
                    cmbCategory.DataSource = categories;
                    cmbCategory.DisplayMember = "Name";
                    cmbCategory.ValueMember = "Id";
                    cmbCategory.EndUpdate();

                    // Устанавливаем новую категорию
                    if (form.SavedCategoryId > 0)
                    {
                        cmbCategory.SelectedValue = form.SavedCategoryId;
                        cmbCategory.Text = categories.FirstOrDefault(c => c.Id == form.SavedCategoryId)?.Name;
                    }
                };
                form.ShowDialog();
            }
        }

        private void btnNewSubcategory_Click(object sender, EventArgs e)
        {
            var selectedCategoryId = (int?)cmbCategory.SelectedValue;

            using (var form = new AddEditSubCategoryForm((int)selectedCategoryId, _context))
            {
                form.DataUpdated += (s, args) =>
                {
                    // Обновляем подкатегории только для текущей категории
                    if (selectedCategoryId.HasValue)
                    {
                        var subCategories = _context.SubCategories
                            .Where(s => s.CategoryId == selectedCategoryId && !s.IsDeleted)
                            .ToList();

                        cmbSubCategory.BeginUpdate();
                        cmbSubCategory.DataSource = null;
                        cmbSubCategory.DataSource = subCategories;
                        cmbSubCategory.DisplayMember = "Name";
                        cmbSubCategory.ValueMember = "Id";
                        cmbSubCategory.EndUpdate();

                        // Устанавливаем новую подкатегорию
                        if (form.SavedSubCategoryId > 0)
                        {
                            cmbSubCategory.SelectedValue = form.SavedSubCategoryId;
                            cmbSubCategory.Text = subCategories
                                .FirstOrDefault(s => s.Id == form.SavedSubCategoryId)?.Name;
                        }
                    }
                };

                form.ShowDialog();
            }
        }

        private void btnNewAdditional_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditAdditionalForm(_context))
            {
                form.DataUpdated += (s, args) =>
                {
                    // Обновляем список дополнительных полей
                    var additionals = _context.Additionals
                        .Where(a => !a.IsDeleted)
                        .ToList();

                    cmbAdditional.BeginUpdate();
                    cmbAdditional.DataSource = null;
                    cmbAdditional.DataSource = additionals;
                    cmbAdditional.DisplayMember = "Name";
                    cmbAdditional.ValueMember = "Id";
                    cmbAdditional.EndUpdate();

                    // Устанавливаем новое значение
                    if (form.SavedAdditionalId > 0)
                    {
                        cmbAdditional.SelectedValue = form.SavedAdditionalId;
                        cmbAdditional.Text = additionals
                            .FirstOrDefault(a => a.Id == form.SavedAdditionalId)?.Name;
                    }
                };

                form.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    if (!ValidateForm())
                    {
                        transaction.Rollback();
                        return;
                    }

                    // Создание новой сущности
                    var expense = new Expense
                    {
                        Date = dtpDate.Value,
                        Amount = numAmount.Value,
                        AccountId = (int)cmbAccount.SelectedValue,
                        CategoryId = (int)cmbCategory.SelectedValue,
                        SubCategoryId = (int)cmbSubCategory.SelectedValue,
                        AdditionalId = (int)cmbAdditional.SelectedValue,
                        Comment = txtComment.Text,
                        IsTemplate = chkIsTemplate.Checked,
                        MeasurementUnitId = (int)cmbMeasurement.SelectedValue,
                        Quantity = numQuantity.Value,
                        IsAutoUnit = (numQuantity.Value == 1) || !numQuantity.Visible
                    };

                    // Списание средств
                    var account = _context.Accounts.Find(expense.AccountId);
                    account.Balance -= expense.Amount;

                    if (account.Balance < 0)
                    {
                        MessageBox.Show("Недостаточно средств на счете");
                        transaction.Rollback();
                        return;
                    }

                    _context.Expenses.Add(expense);
                    _context.SaveChanges();
                    transaction.Commit();

                    // Сброс полей и обновление данных
                    ResetFormFields();
                    _context.Entry(account).Reload(); // Обновляем состояние счета
                    NotifyDataUpdated();

                    MessageBox.Show("Расход добавлен. Можно добавить следующий.");
                    dtpDate.Focus();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Logger.Log(ex);
                    MessageBox.Show($"Ошибка: {ex.InnerException?.Message ?? ex.Message}");
                }
            }
        }

        private void ResetFormFields()
        {
            numAmount.Value = 0.01m;
            txtComment.Text = string.Empty;
            // Остальные поля остаются заполненными для удобства
        }

        // Обновленные методы загрузки данных
        private void LoadAccounts()
        {
            cmbAccount.DataSource = _context.Accounts
                .Include(a => a.Currency)
                .Where(a => !a.IsDeleted)
                .ToList();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem is Category selectedCategory)
            {
                cmbSubCategory.Text = "";
                // Фильтрация подкатегорий по выбранной категории
                var subCategories = _context.SubCategories
                    .Where(s => s.CategoryId == selectedCategory.Id && !s.IsDeleted)
                    .ToList();

                cmbSubCategory.DataSource = subCategories;
                cmbSubCategory.DisplayMember = "Name";
                cmbSubCategory.ValueMember = "Id";

                // Обновить автодополнение при изменении данных
                cmbSubCategory.AutoCompleteCustomSource.Clear();
                cmbSubCategory.AutoCompleteCustomSource.AddRange(
                    subCategories.Select(c => c.Name).ToArray()
                );
            }
            else
            {
                // Если категория не выбрана, очищаем подкатегории
                cmbSubCategory.DataSource = null;
            }

            // Новая: Проверка требований к количеству
            var subCategory = cmbSubCategory.SelectedItem as SubCategory;
            bool showQuantity = (subCategory?.RequireQuantity == true) ||
                               (subCategory?.InheritQuantityRequirement == true &&
                                subCategory?.Category?.RequireQuantity == true);
            ShowQuantity(showQuantity);

            // Новая: Установка значения по умолчанию
            if (!showQuantity) numQuantity.Value = 1;

            LoadDefaultMeasurementUnit();
        }

        private void ShowQuantity(bool show)
        {
            lblQuantity.Visible = show;
            numQuantity.Visible = show;
            lblMeasurement.Visible = show;
            cmbMeasurement.Visible = show;
            btnNewMeasurement.Visible = show;

        }

        private void btnNewMeasurement_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditMeasurementUnitForm(_context))
            {
                form.DataUpdated += (s, args) =>
                {
                    // Обновляем список единиц измерения
                    cmbMeasurement.DataSource = _context.MeasurementUnits
                        .Where(u => !u.IsDeleted)
                        .ToList();

                    if (form.SavedUnitId.HasValue)
                        cmbMeasurement.SelectedValue = form.SavedUnitId.Value;
                };
                form.ShowDialog();
            }
        }

        private void cmbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обработка видимости поля количества
            var subCategory = cmbSubCategory.SelectedItem as SubCategory;
            bool requireQuantity = false;

            if (subCategory != null)
            {
                // Проверяем требования подкатегории и категории
                requireQuantity = subCategory.RequireQuantity ||
                                 (subCategory.InheritQuantityRequirement &&
                                  subCategory.Category?.RequireQuantity == true);
            }

            // Управляем видимостью
            numQuantity.Visible = requireQuantity;
            lblQuantity.Visible = requireQuantity;

            // Устанавливаем значение по умолчанию только для новых записей
            if (!_isEditMode)
            {
                numQuantity.Value = requireQuantity ? 1 : 1; // Всегда 1, но можно настроить

                // Безопасная установка IsAutoUnit
                if (_expense == null) return;
                _expense.IsAutoUnit = !requireQuantity;
            }
            else if (_expense != null) // Для редактирования
            {
                _expense.IsAutoUnit = (numQuantity.Value == 1) && !requireQuantity;
            }
        }

        private void AddEditExpenseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick(); // Вызов клика по кнопке "Добавить"
                e.Handled = true; // Предотвращаем дальнейшую обработку
            }
        }
    }
}