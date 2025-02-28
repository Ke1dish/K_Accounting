using System.Data;
using K_Accounting.Data;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;

namespace K_Accounting.Forms
{
    public partial class AddEditExpenseForm : Form
    {
        private readonly AppDbContext _context;

        private Expense _expense;
        private decimal _originalAmount;
        private int _originalAccountId;
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
            _context = context;
            InitializeData();
            dtpDate.Focus();
        }

        public AddEditExpenseForm(AppDbContext context, Expense expense) : this(context)
        {
            _expense = expense;
            LoadExpenseData();
            dtpDate.Focus();
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

            // Загрузка категорий
            cmbCategory.DataSource = _context.Categories
                .Where(c => !c.IsDeleted)
                .ToList();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";

            // Загрузка подкатегорий
            cmbSubCategory.DataSource = _context.SubCategories
                .Where(s => !s.IsDeleted)
                .ToList();
            cmbSubCategory.DisplayMember = "Name";
            cmbSubCategory.ValueMember = "Id";

            // Загрузка дополнений
            cmbAdditional.DataSource = _context.Additionals
                .Where(a => !a.IsDeleted)
                .ToList();
            cmbAdditional.DisplayMember = "Name";
            cmbAdditional.ValueMember = "Id";

            // Убрать предзагрузку всех подкатегорий
            cmbSubCategory.DataSource = null;
            cmbCategory_SelectedIndexChanged(null, EventArgs.Empty);

        }

        private void LoadExpenseData()
        {
            if (_expense == null) return;

            // Сохраняем оригинальные значения
            _originalAmount = _expense.Amount;
            _originalAccountId = _expense.AccountId;

            // Заполняем контролы
            dtpDate.Value = _expense.Date;
            numAmount.Value = _expense.Amount;
            cmbAccount.SelectedValue = _expense.AccountId;
            cmbCategory.SelectedValue = _expense.CategoryId;
            cmbSubCategory.SelectedValue = _expense.SubCategoryId;
            cmbAdditional.SelectedValue = _expense.AdditionalId;
            txtComment.Text = _expense.Comment;
            chkIsTemplate.Checked = _expense.IsTemplate;

            // Установить категорию (это вызовет событие SelectedIndexChanged)
            cmbCategory.SelectedValue = _expense.CategoryId;

            // Установить подкатегорию после загрузки списка
            cmbSubCategory.SelectedValue = _expense.SubCategoryId;
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
                            IsTemplate = chkIsTemplate.Checked
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
                    DataUpdated?.Invoke(this, EventArgs.Empty);
                    transaction.Commit();

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}");
                }
            }
        }

        private bool ValidateForm()
        {
            if (cmbAccount.SelectedItem == null)
            {
                MessageBox.Show("Выберите счет");
                return false;
            }

            if (numAmount.Value <= 0)
            {
                MessageBox.Show("Сумма должна быть больше нуля");
                return false;
            }

            if (cmbSubCategory.SelectedItem == null)
            {
                MessageBox.Show("Выберите подкатегорию");
                return false;
            }

            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать категорию");
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
            using (var form = new AddEditAccountForm(_context)) // Теперь корректно
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
                    LoadCategories();
                    if (form.SavedCategoryId > 0)
                        cmbCategory.SelectedValue = form.SavedCategoryId;
                };
                form.ShowDialog();
            }
        }

        private void btnNewSubcategory_Click(object sender, EventArgs e)
        {
            //var selectedCategoryId = cmbCategory.SelectedValue as int?;

            //using (var form = new AddEditSubCategoryForm(_context, selectedCategoryId)) // Исправлено
            //{
            //    form.SubCategoryAddedOrUpdated += (s, args) =>
            //    {
            //        LoadSubCategories();
            //        if (form.SavedSubCategoryId > 0)
            //            cmbSubCategory.SelectedValue = form.SavedSubCategoryId;
            //    };
            //    form.ShowDialog();
            //}

            var selectedCategory = cmbCategory.SelectedItem as Category;
            int? categoryId = selectedCategory?.Id;

            using (var form = new AddEditSubCategoryForm(_context, categoryId))
            {
                form.SubCategoryAddedOrUpdated += (s, args) =>
                {
                    // Обновляем список подкатегорий для текущей категории
                    if (categoryId.HasValue)
                    {
                        cmbSubCategory.DataSource = _context.SubCategories
                            .Where(s => s.CategoryId == categoryId && !s.IsDeleted)
                            .ToList();
                        cmbSubCategory.SelectedValue = form.SavedSubCategoryId;
                    }
                };
                form.ShowDialog();
            }
        }

        private void btnNewAdditional_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditAdditionalForm(_context)) // Корректно
            {
                form.DataUpdated += (s, args) =>
                {
                    LoadAdditionals();
                    if (form.SavedAdditionalId > 0)
                        cmbAdditional.SelectedValue = form.SavedAdditionalId;
                };
                form.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SaveExpense())
            {
                NotifyDataUpdated(); // Уведомляем сразу после сохранения
                ResetFormFields();
                MessageBox.Show("Расход добавлен. Можно добавить следующий.");
            }
        }

        private bool SaveExpense()
        {
            try
            {
                var expense = new Expense
                {
                    Date = dtpDate.Value,
                    Amount = numAmount.Value,
                    AccountId = (int)cmbAccount.SelectedValue,
                    CategoryId = (int)cmbCategory.SelectedValue,
                    SubCategoryId = (int)cmbSubCategory.SelectedValue,
                    AdditionalId = (int)cmbAdditional.SelectedValue,
                    Comment = txtComment.Text,
                    IsTemplate = chkIsTemplate.Checked
                };

                // Списание средств
                var account = _context.Accounts.Find(expense.AccountId);
                account.Balance -= expense.Amount;

                _context.Expenses.Add(expense);
                _context.SaveChanges();
                _context.ChangeTracker.Entries().Where(e => e.Entity != null).ToList().ForEach(e => e.Reload());
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                return false;
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

        private void LoadCategories()
        {
            cmbCategory.DataSource = _context.Categories
                .Where(c => !c.IsDeleted)
                .ToList();
        }

        private void LoadSubCategories()
        {
            cmbSubCategory.DataSource = _context.SubCategories
                .Include(s => s.Category)
                .Where(s => !s.IsDeleted)
                .ToList();
        }

        private void LoadAdditionals()
        {
            cmbAdditional.DataSource = _context.Additionals
                .Where(a => !a.IsDeleted)
                .ToList();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem is Category selectedCategory)
            {
                // Фильтрация подкатегорий по выбранной категории
                cmbSubCategory.DataSource = _context.SubCategories
                    .Where(s => s.CategoryId == selectedCategory.Id && !s.IsDeleted)
                    .ToList();
            }
            else
            {
                // Если категория не выбрана, очищаем подкатегории
                cmbSubCategory.DataSource = null;
            }
            cmbSubCategory.DisplayMember = "Name";
            cmbSubCategory.ValueMember = "Id";
        }
    }
}
