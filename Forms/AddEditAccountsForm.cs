using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using K_Accounting.Data;
using K_Accounting.Models;

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
                var currencies = _context.Currencies
                    .Where(c => !c.IsDeleted)
                    .OrderBy(c => c.Name)
                    .ToList();

                cmbCurrency.DataSource = currencies;
                cmbCurrency.DisplayMember = "Name";
                cmbCurrency.ValueMember = "Id";
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

            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            using (var context = new AppDbContext())
            {
                try
                {
                    if (_isEditMode)
                    {
                        var existing = context.Accounts.Find(_account.Id);
                        if (existing != null)
                        {
                            existing.Name = txtName.Text.Trim();
                            existing.Balance = numBalance.Value;
                            existing.CurrencyId = (int)cmbCurrency.SelectedValue;
                            existing.Comment = txtComment.Text.Trim();
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
                        SavedAccountId = newAccount.Id;
                        context.Accounts.Add(newAccount);
                    }

                    context.SaveChanges();
                    DataUpdated?.Invoke(this, EventArgs.Empty);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}");
                }
            }
        }

        private void btnNewCurrency_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditCurrencyForm(_context)) // Передаем контекст
            {
                form.DataUpdated += (s, args) =>
                {
                    LoadCurrencies();
                    DataUpdated?.Invoke(this, EventArgs.Empty);
                };
                form.ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
