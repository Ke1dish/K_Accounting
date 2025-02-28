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
            _context = context;
            LoadAccounts();
            cmbFromAccount.Focus();
        }

        private void LoadAccounts()
        {
            _accounts = new BindingList<Account>(_context.Accounts
                .Include(a => a.Currency)
                .Where(a => !a.IsDeleted)
                .OrderBy(a => a.Name)
                .ToList());

            cmbFromAccount.DataSource = _accounts;
            cmbFromAccount.DisplayMember = "Name";
            cmbFromAccount.ValueMember = "Id";

            // Создаем новую BindingList с теми же элементами
            cmbToAccount.DataSource = new BindingList<Account>(_accounts.ToList());
            cmbToAccount.DisplayMember = "Name";
            cmbToAccount.ValueMember = "Id";
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
                    /*
					при переводе добавлять в счет источник - расход, а счет приемник доход
					с автоматическим заполнением полей
					*/
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

            return true;
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditAccountsForm(_context))
            {
                form.DataUpdated += (s, args) => LoadAccounts();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadAccounts();
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
                e.Value = $"{account.Name} ({account.Balance:N2} {account.Currency?.Code})";
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

            if (from?.Currency != null && to?.Currency != null)
            {
                lblConversionRate.Text = $"1 {from.Currency.Code} = {to.Currency.Rate / from.Currency.Rate:N4} {to.Currency.Code}";
            }
        }
    }
}



/*
 
при переводе добавлять в счет источник - расход, а счет приемник доход
с автоматическим заполнением полей
 
 */