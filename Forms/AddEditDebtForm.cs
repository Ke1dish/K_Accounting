using System;
using System.Linq;
using System.Windows.Forms;
using K_Accounting.Data;
using K_Accounting.Models;
using K_Accounting.Utilities;
using Microsoft.EntityFrameworkCore;

namespace K_Accounting.Forms
{
    public partial class AddEditDebtForm : Form
    {
        private readonly AppDbContext _context;
        private Debt _debt;
        private DebtType _debtType;
        private bool _isEditMode;

        public int? SavedDebtId { get; private set; }
        public event EventHandler DataUpdated;

        public AddEditDebtForm(AppDbContext context, DebtType debtType, Debt debt = null)
        {
            InitializeComponent();
            _context = context;
            _debtType = debtType;
            _isEditMode = debt != null;
            _debt = debt ?? new Debt();

            ConfigureFormTitle();
            InitializeControls();
            LoadData();
        }

        private void ConfigureFormTitle()
        {
            var typeName = _debtType == DebtType.Given ? "выданного" : "полученного";
            Text = _isEditMode ?
                $"Редактирование {typeName.ToLower()} долга" :
                $"Добавление {typeName.ToLower()} долга";
        }

        private void InitializeControls()
        {
            // Настройка формата дат
            dtpLoanDate.Format = DateTimePickerFormat.Short;
            dtpDueDate.Format = DateTimePickerFormat.Short;

            // Настройка числовых полей
            numAmount.DecimalPlaces = 2;
            numAmount.Minimum = 0.01m;
            numAmount.Maximum = decimal.MaxValue;

            // Запрет редактирования статуса при создании
            if (!_isEditMode) cmbStatus.Enabled = false;
        }

        private void LoadData()
        {
            // Загрузка счетов с валютами
            cmbAccount.DataSource = _context.Accounts
                .Where(a => !a.IsDeleted)
                .Include(a => a.Currency)
                .ToList();
            cmbAccount.DisplayMember = "Name";
            cmbAccount.ValueMember = "Id";

            // Настройка автодополнения для счетов
            cmbAccount.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbAccount.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Загрузка контрагентов
            LoadCounterparties();

            // Загрузка статусов
            cmbStatus.DataSource = Enum.GetValues(typeof(DebtStatus));

            if (_isEditMode) LoadDebtData();
        }

        private void LoadDebtData()
        {
            cmbAccount.SelectedValue = _debt.AccountId;
            numAmount.Value = _debt.InitialAmount;
            dtpLoanDate.Value = _debt.LoanDate;
            dtpDueDate.Value = _debt.DueDate;

            // Установка контрагента
            if (_debt.CounterpartyId != null)
            {
                cmbCounterparty.SelectedValue = _debt.CounterpartyId;
            }

            cmbStatus.SelectedItem = _debt.Status;
            txtComment.Text = _debt.Comment;
        }

        private void LoadCounterparties()
        {
            // Загрузка полного списка контрагентов
            var counterparties = _context.Counterparties
                .Where(c => !c.IsDeleted)
                .OrderBy(c => c.Name)
                .ToList();

            cmbCounterparty.DataSource = counterparties;
            cmbCounterparty.DisplayMember = "Name";
            cmbCounterparty.ValueMember = "Id";

            // Настройка автодополнения
            cmbCounterparty.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCounterparty.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbCounterparty.AutoCompleteCustomSource.Clear();
            cmbCounterparty.AutoCompleteCustomSource.AddRange(
                counterparties.Select(c => c.Name).ToArray()
            );
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditAccountsForm(_context))
            {
                form.DataUpdated += (s, args) => LoadData();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    cmbAccount.SelectedValue = form.SavedAccountId;
                }
            }
        }

        private void btnNewCounterparty_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditCounterpartyForm(_context))
            {
                form.DataUpdated += (s, args) => LoadCounterparties();
                form.ShowDialog();
            }
        }

        private bool ValidateForm()
        {
            if (cmbAccount.SelectedValue == null || !(cmbAccount.SelectedValue is int accountId))
            {
                MessageBox.Show("Выберите счёт");
                return false;
            }

            if (cmbCounterparty.SelectedValue == null || !(cmbCounterparty.SelectedValue is int counterpartyId))
            {
                MessageBox.Show("Укажите контрагента");
                return false;
            }

            // Проверка существования счёта и контрагента в базе
            var accountExists = _context.Accounts.Any(a => a.Id == accountId && !a.IsDeleted);
            var counterpartyExists = _context.Counterparties.Any(c => c.Id == counterpartyId && !c.IsDeleted);

            if (!accountExists || !counterpartyExists)
            {
                MessageBox.Show("Выбранные счёт или контрагент не найдены или удалены");
                return false;
            }

            if (dtpDueDate.Value < dtpLoanDate.Value)
            {
                MessageBox.Show("Дата возврата не может быть раньше даты займа");
                return false;
            }

            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var accountId = (int)cmbAccount.SelectedValue;
                    var counterpartyId = (int)cmbCounterparty.SelectedValue;
                    var initialAmount = numAmount.Value;

                    // Загрузка текущего счёта
                    var account = _context.Accounts.Find(accountId);

                    // Для редактирования: загрузка старого долга
                    if (_isEditMode)
                    {
                        var oldDebt = _context.Debts
                            .Include(d => d.Account)
                            .First(d => d.Id == _debt.Id);

                        // Возврат старой суммы на предыдущий счёт
                        if (oldDebt.Type == DebtType.Given)
                            oldDebt.Account.Balance += oldDebt.InitialAmount;
                        else
                            oldDebt.Account.Balance -= oldDebt.InitialAmount;
                    }

                    // Обновление данных долга
                    _debt.AccountId = accountId;
                    _debt.CounterpartyId = counterpartyId;
                    _debt.InitialAmount = initialAmount;
                    _debt.RemainingAmount = initialAmount;
                    _debt.LoanDate = dtpLoanDate.Value;
                    _debt.DueDate = dtpDueDate.Value;
                    _debt.Status = (DebtStatus)cmbStatus.SelectedItem;
                    _debt.Comment = txtComment.Text;

                    // Корректировка баланса
                    if (_debt.Type == DebtType.Given)
                        account.Balance -= initialAmount;
                    else
                        account.Balance += initialAmount;

                    // Проверка отрицательного баланса для выданных долгов
                    if (_debt.Type == DebtType.Given && account.Balance < 0)
                    {
                        MessageBox.Show("Недостаточно средств на счете");
                        transaction.Rollback();
                        return;
                    }

                    // Сохранение изменений
                    if (!_isEditMode)
                        _context.Debts.Add(_debt);

                    _context.SaveChanges();
                    transaction.Commit();

                    SavedDebtId = _debt.Id;
                    DataUpdated?.Invoke(this, EventArgs.Empty);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Ошибка: {ex.InnerException?.Message ?? ex.Message}");
                }
            }
        }

        //private void btnOk_Click(object sender, EventArgs e)
        //{
        //    if (!ValidateForm()) return;

        //    try
        //    {
        //        var account = (Account)cmbAccount.SelectedItem;
        //        var originalAmount = _isEditMode ?
        //            _context.Debts.AsNoTracking().First(d => d.Id == _debt.Id).InitialAmount : 0;

        //        // Проверка баланса для выданных долгов
        //        if (_debt.Type == DebtType.Given &&
        //            account.Balance < _debt.InitialAmount)
        //        {
        //            MessageBox.Show("Недостаточно средств на счете для выдачи долга!");
        //            return;
        //        }

        //        using (var transaction = _context.Database.BeginTransaction())
        //        {
        //            // Корректировка баланса при редактировании
        //            if (_isEditMode)
        //            {
        //                var oldAccount = _context.Accounts.Find(_debt.AccountId);
        //                oldAccount.Balance += _debt.Type == DebtType.Given
        //                    ? originalAmount
        //                    : -originalAmount;
        //            }

        //            // Обновление баланса нового счета
        //            account.Balance += _debt.Type == DebtType.Given
        //                ? -_debt.InitialAmount
        //                : _debt.InitialAmount;

        //            // Сохранение изменений
        //            if (!_isEditMode)
        //                _context.Debts.Add(_debt);
        //            else
        //                _context.Entry(_debt).State = EntityState.Modified;

        //            _context.SaveChanges();
        //            SavedDebtId = _debt.Id;
        //            transaction.Commit();
        //        }

        //        SavedDebtId = _debt.Id;
        //        DataUpdated?.Invoke(this, EventArgs.Empty);
        //        DialogResult = DialogResult.OK;
        //        Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Ошибка сохранения: {ex.Message}");
        //    }
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}