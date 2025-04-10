using K_Accounting.Data;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace K_Accounting.Forms
{
    public partial class AddEditPaymentForm : Form
    {
        private readonly AppDbContext _context;
        private readonly DebtPayment _payment;
        private readonly int? _debtId;

        public AddEditPaymentForm(AppDbContext context, int debtId)
        {
            InitializeComponent();
            _context = context;
            _debtId = debtId;
            _payment = new DebtPayment { DebtId = debtId };
            InitializeControls();
        }

        public AddEditPaymentForm(AppDbContext context, DebtPayment payment)
        {
            InitializeComponent();
            _context = context;
            _payment = payment;
            InitializeControls();
            LoadPaymentData();
        }

        private void InitializeControls()
        {
            dtpPaymentDate.Format = DateTimePickerFormat.Short;
            numPaymentAmount.DecimalPlaces = 2;
            numPaymentAmount.Minimum = 0.01m;
            numPaymentAmount.Maximum = decimal.MaxValue;
        }

        private void LoadPaymentData()
        {
            dtpPaymentDate.Value = _payment.PaymentDate;
            numPaymentAmount.Value = _payment.Amount;
            txtComment.Text = _payment.Comment;
        }

        private bool ValidateForm()
        {
            if (numPaymentAmount.Value <= 0)
            {
                MessageBox.Show("Сумма платежа должна быть больше нуля!");
                return false;
            }

            var debt = _context.Debts
                .AsNoTracking()
                .FirstOrDefault(d => d.Id == _payment.DebtId);

            if (debt == null)
            {
                MessageBox.Show("Долг не найден!");
                return false;
            }

            decimal maxAllowed = debt.RemainingAmount;

            if (_payment.Id != 0) // Для редактирования существующего платежа
            {
                var originalAmount = _context.DebtPayments
                    .AsNoTracking()
                    .Where(p => p.Id == _payment.Id)
                    .Select(p => p.Amount)
                    .FirstOrDefault();

                maxAllowed += originalAmount;
            }

            if (numPaymentAmount.Value > maxAllowed)
            {
                MessageBox.Show($"Сумма платежа не может превышать {maxAllowed:N2}!");
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var debt = _context.Debts
                        .Include(d => d.Account)
                        .First(d => d.Id == _payment.DebtId);

                    decimal oldAmount = _payment.Id != 0
                        ? _context.DebtPayments
                            .AsNoTracking()
                            .First(p => p.Id == _payment.Id).Amount
                        : 0;

                    // Обновление платежа
                    _payment.PaymentDate = dtpPaymentDate.Value;
                    _payment.Amount = numPaymentAmount.Value;
                    _payment.Comment = txtComment.Text;

                    // Корректировка баланса
                    UpdateAccountBalance(debt, oldAmount);

                    // Обновление статуса долга
                    UpdateDebtStatus(debt, oldAmount);

                    if (_payment.Id == 0)
                        _context.DebtPayments.Add(_payment);
                    else
                        _context.Entry(_payment).State = EntityState.Modified;

                    _context.SaveChanges();
                    transaction.Commit();

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Ошибка: {ex.Message}\n\nДетали:\n{ex.InnerException?.Message}");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void UpdateAccountBalance(Debt debt, decimal oldAmount)
        {
            decimal difference = _payment.Amount - oldAmount;

            if (debt.Type == DebtType.Given)
                debt.Account.Balance += difference;
            else
                debt.Account.Balance -= difference;

            _context.Entry(debt.Account).State = EntityState.Modified;
        }

        private void UpdateDebtStatus(Debt debt, decimal oldAmount)
        {
            debt.RemainingAmount += oldAmount;
            debt.RemainingAmount -= _payment.Amount;

            if (debt.RemainingAmount <= 0)
            {
                debt.RemainingAmount = 0;
                debt.Status = DebtStatus.Repaid;
            }
            else if (debt.Status == DebtStatus.Repaid)
            {
                debt.Status = DebtStatus.Active;
            }

            _context.Entry(debt).State = EntityState.Modified;
        }
    }
}