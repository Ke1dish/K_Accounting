using System.Data;
using System.Windows.Forms;
using K_Accounting.Data;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;

namespace K_Accounting.Forms
{
    public partial class AddEditAccountsForm : Form
    {
        private readonly AppDbContext _context;             // Ссылка на базу данных

        private Account _account;                           // Редактируемый счет
        private bool _isEditMode;                           // Режим редактирования/добавления
        public bool isEditMode
        {
            get => _isEditMode;
            set
            {
                _isEditMode = value;
                Text = value ? "Редактирование счета" : "Добавление счета";
                btnOk.Text = value ? "Сохранить" : "Создать";
            }
        }
        public int SavedAccountId { get; private set; }

        // Добавляем унифицированное событие
        public event EventHandler DataUpdated;


        public AddEditAccountsForm(AppDbContext context) // Новый конструктор
        {
            InitializeComponent();
            numBalance.Value = 0;
            numBalance.Controls[0].Visible = false;
            _context = context;
            LoadCurrencies();
            txtName.Focus();
        }

        public AddEditAccountsForm(AppDbContext context, Account account) : this(context)
        {
            _account = account;
            LoadAccountData();
        }

        private void LoadCurrencies()
        {
            try
            {
                cmbCurrency.BeginUpdate();
                var currencies = _context.Currencies
                    .Where(c => !c.IsDeleted)
                    .AsNoTracking()
                    .ToList();

                cmbCurrency.DataSource = null;
                cmbCurrency.DataSource = currencies;
                cmbCurrency.DisplayMember = "Name";
                cmbCurrency.ValueMember = "Id";
                cmbCurrency.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbCurrency.AutoCompleteSource = AutoCompleteSource.ListItems;
                cmbCurrency.DropDownStyle = ComboBoxStyle.DropDown;
                cmbCurrency.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки валют: {ex.Message}");
            }
        }

        private void LoadAccountData()
        {
            txtName.Text = _account.Name;
            numBalance.Value = _account.Balance;
            cmbCurrency.SelectedValue = _account.CurrencyId;
            txtComment.Text = _account.Comment;

            cmbCurrency.Text = ((Currency)cmbCurrency.SelectedItem)?.Name;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Название счета обязательно для заполнения");
                return false;
            }

            if (cmbCurrency.SelectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать валюту");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Название счета обязательно для заполнения");
                return false;
            }

            // Добавленная проверка для ComboBox
            if (cmbCurrency.SelectedItem == null ||
                cmbCurrency.Text != ((Currency)cmbCurrency.SelectedItem).Name)
            {
                MessageBox.Show("Выберите существующую валюту из списка");
                return false;
            }

            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                if (_isEditMode)
                {
                    // 1. Получаем сущность из текущего контекста
                    var existing = _context.Accounts
                        .FirstOrDefault(a => a.Id == _account.Id);

                    if (existing != null)
                    {
                        // 2. Вносим изменения напрямую в отслеживаемую сущность
                        existing.Name = txtName.Text.Trim();
                        existing.Balance = numBalance.Value;
                        existing.CurrencyId = (int)cmbCurrency.SelectedValue;
                        existing.Comment = txtComment.Text.Trim();

                        // 3. Сохраняем изменения в оригинальном контексте
                        _context.SaveChanges();
                        SavedAccountId = existing.Id;
                    }
                }
                else
                {
                    var newAccount = new Account(
                        txtName.Text.Trim(),
                        numBalance.Value,
                        (int)cmbCurrency.SelectedValue)
                    {
                        Comment = txtComment.Text.Trim()
                    };
                    _context.Accounts.Add(newAccount);
                    _context.SaveChanges(); // Сохраняем сразу
                    SavedAccountId = newAccount.Id; // Сохраняем ID нового счета
                }

                DataUpdated?.Invoke(this, EventArgs.Empty);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
            }
        }

        private void btnNewCurrency_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditCurrencyForm(_context))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Обновляем список валют с принудительным обновлением
                    var currencies = _context.Currencies
                        .Where(c => !c.IsDeleted)
                        .AsNoTracking() // Отключаем отслеживание
                        .ToList();

                    cmbCurrency.BeginUpdate();
                    cmbCurrency.DataSource = null;
                    cmbCurrency.DataSource = currencies;
                    cmbCurrency.DisplayMember = "Name";
                    cmbCurrency.ValueMember = "Id";
                    cmbCurrency.EndUpdate();

                    // Устанавливаем новую валюту
                    if (form.SavedCurrencyId > 0)
                    {
                        cmbCurrency.SelectedValue = form.SavedCurrencyId;
                        cmbCurrency.Text = currencies.FirstOrDefault(c => c.Id == form.SavedCurrencyId)?.Name;
                    }

                    DataUpdated?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}