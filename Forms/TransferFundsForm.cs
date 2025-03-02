using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using K_Accounting.Data;
using K_Accounting.Models;
using System.Security.Principal;

namespace K_Accounting.Forms
{
    public partial class TransferFundsForm : Form
    {
        private readonly AppDbContext _context;

        private BindingList<Account> _accounts;

        // Добавляем унифицированное событие
        public event EventHandler DataUpdated;

        public TransferFundsForm(AppDbContext context)
        {
            InitializeComponent();
            numAmount.Controls[0].Visible = false;
            _context = context;
            LoadAccounts();
            cmbFromAccount.Focus();
        }

        private void LoadAccounts()
        {
            var accounts = _context.Accounts
                .Include(a => a.Currency)
                .Where(a => !a.IsDeleted)
                .OrderBy(a => a.Name)
                .AsNoTracking()
                .ToList();

            _accounts = new BindingList<Account>(accounts);

            cmbFromAccount.DataSource = _accounts;
            cmbFromAccount.DisplayMember = "Name";
            cmbFromAccount.ValueMember = "Id";
            cmbFromAccount.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbFromAccount.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbFromAccount.DropDownStyle = ComboBoxStyle.DropDown;

            // Создаем новую BindingList с теми же элементами
            cmbToAccount.DataSource = new BindingList<Account>(accounts);
            cmbToAccount.DisplayMember = "Name";
            cmbToAccount.ValueMember = "Id";
            cmbToAccount.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbToAccount.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbToAccount.DropDownStyle = ComboBoxStyle.DropDown;

            // Обновление форматирования
            cmbFromAccount.Format += cmbFormat;
            cmbToAccount.Format += cmbFormat;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            var fromAccount = (Account)cmbFromAccount.SelectedItem;
            var toAccount = (Account)cmbToAccount.SelectedItem;
            var amount = numAmount.Value;

            try
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    // Проверка баланса
                    if (fromAccount.Balance < amount)
                    {
                        MessageBox.Show("Недостаточно средств на исходном счете");
                        return;
                    }

                    // Конвертация валюты
                    var convertedAmount = ConvertCurrency(
                        amount,
                        fromAccount.Currency,
                        toAccount.Currency);

                    // Обновление балансов
                    fromAccount.Balance -= amount;
                    toAccount.Balance += convertedAmount;

                    _context.SaveChanges();
                    transaction.Commit();
                    DataUpdated?.Invoke(this, EventArgs.Empty);

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}\n\nДетали:\n{ex.InnerException?.Message}",
                              "Ошибка перевода",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private decimal ConvertCurrency(decimal amount, Currency fromCurrency, Currency toCurrency)
        {
            if (fromCurrency == null || toCurrency == null)
                throw new ArgumentNullException("Валюты не должны быть null");

            if (fromCurrency.Rate <= 0 || toCurrency.Rate <= 0)
                throw new InvalidOperationException("Некорректный курс валюты");

            if (fromCurrency.Id == toCurrency.Id)
                return amount;

            return amount * fromCurrency.Rate / toCurrency.Rate;
        }

        private bool ValidateForm()
        {
            if (cmbFromAccount.SelectedItem == null ||
                cmbToAccount.SelectedItem == null)
            {
                MessageBox.Show("Выберите исходный и целевой счета");
                return false;
            }

            if (cmbFromAccount.SelectedItem == cmbToAccount.SelectedItem)
            {
                MessageBox.Show("Нельзя переводить на тот же счет");
                return false;
            }

            if (numAmount.Value <= 0)
            {
                MessageBox.Show("Сумма должна быть больше нуля");
                return false;
            }

            // Проверка исходного счета
            if (cmbFromAccount.SelectedItem == null ||
                !_accounts.Any(a => a.Id == (int)cmbFromAccount.SelectedValue))
            {
                MessageBox.Show("Выберите корректный исходный счет из списка");
                return false;
            }

            // Проверка целевого счета
            var toAccounts = cmbToAccount.DataSource as BindingList<Account>;
            if (cmbToAccount.SelectedItem == null ||
                (toAccounts != null && !toAccounts.Any(a => a.Id == (int)cmbToAccount.SelectedValue)))
            {
                MessageBox.Show("Выберите корректный целевой счет из списка");
                return false;
            }

            if (cmbFromAccount.SelectedValue.Equals(cmbToAccount.SelectedValue))
            {
                MessageBox.Show("Нельзя переводить на тот же счет");
                return false;
            }

            if (numAmount.Value <= 0)
            {
                MessageBox.Show("Сумма должна быть больше нуля");
                return false;
            }

            return true;
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditAccountsForm(_context))
            {
                form.DataUpdated += (s, args) =>
                {
                    LoadAccounts(); // Полная перезагрузка данных
                    UpdateCurrencyInfo(); // Обновление курса валют
                };

                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Автовыбор нового счета при создании
                    cmbToAccount.SelectedValue = form.SavedAccountId;
                }
            }
        }

        private void TransferFundsForm_Load(object sender, EventArgs e)
        {
            numAmount.Controls[0].Visible = false; // Скрыть стрелки у NumericUpDown
        }

        private void cmbFormat(object sender, ListControlConvertEventArgs e)
        {
            var account = e.ListItem as Account;
            if (account != null)
            {
                e.Value = $"{account.Name} ({account.Balance:N2})";
            }
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCurrencyInfo();
        }

        private void UpdateCurrencyInfo()
        {
            var from = cmbFromAccount.SelectedItem as Account;
            var to = cmbToAccount.SelectedItem as Account;

            lblConversionRate.Text = from?.Currency != null && to?.Currency != null
                 //                ? $"1 {from.Currency.Code} = {(to.Currency.Rate / from.Currency.Rate):N4} {to.Currency.Code}"
                 ? $"1 {from.Currency.Symbol} = {(to.Currency.Rate / from.Currency.Rate):N4} {to.Currency.Symbol}"
                 : "Выберите оба счета для отображения курса";
        }

        private void numAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем только цифры и управляющие символы
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void cmbFromAccount_TextUpdate(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            var searchText = combo.Text.ToLower();
            combo.SelectedItem = _accounts.FirstOrDefault(a =>
                a.Name.ToLower().Contains(searchText)
            );
        }

        private void cmbToAccount_TextUpdate(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            var searchText = combo.Text.ToLower();
            var accounts = combo.DataSource as BindingList<Account>;
            combo.SelectedItem = accounts?.FirstOrDefault(a =>
                a.Name.ToLower().Contains(searchText)
            );
        }
    }
}