using K_Accounting.Data;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace K_Accounting.Forms
{
    public partial class PaymentsForm : Form
    {
        private readonly AppDbContext _context;
        private readonly int? _debtId;
        public bool DataUpdated { get; private set; }

        public PaymentsForm(AppDbContext context, int? debtId = null)
        {
            InitializeComponent();
            _context = context;
            _debtId = debtId;
            DataUpdated = false;
        }

        private void PaymentsForm_Load(object sender, EventArgs e)
        {
            LoadPayments();
            ConfigureGrid();
        }

        private void LoadPayments()
        {
            if (_debtId == null)
            {
                MessageBox.Show("Долг не выбран!");
                return;
            }

            // Загрузить платежи и связанный долг
            var payments = _context.DebtPayments
                .Include(p => p.Debt)
                .Where(p => p.DebtId == _debtId)
                .OrderByDescending(p => p.PaymentDate)
                .ToList();

            dgvPayments.DataSource = payments;
        }

        private void ConfigureGrid()
        {
            dgvPayments.AutoGenerateColumns = false;
            dgvPayments.Columns.Clear();

            dgvPayments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PaymentDate",
                HeaderText = "Дата",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy" }
            });

            dgvPayments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Amount",
                HeaderText = "Сумма",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvPayments.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Comment",
                HeaderText = "Комментарий"
            });
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditPaymentForm(_context, _debtId.Value))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadPayments();
                    DataUpdated = true;
                }
            }
        }

        private void btnEditPayment_Click(object sender, EventArgs e)
        {
            if (dgvPayments.CurrentRow?.DataBoundItem is DebtPayment payment)
            {
                using (var form = new AddEditPaymentForm(_context, payment))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadPayments();
                        DataUpdated = true;
                    }
                }
            }
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            if (dgvPayments.CurrentRow?.DataBoundItem is DebtPayment payment)
            {
                var result = MessageBox.Show(
                    "Удалить этот платеж?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    using (var transaction = _context.Database.BeginTransaction())
                    {
                        try
                        {
                            var debt = _context.Debts
                                .Include(d => d.Account)
                                .First(d => d.Id == payment.DebtId);

                            // Восстановление баланса
                            if (debt.Type == DebtType.Given)
                                debt.Account.Balance += payment.Amount;
                            else
                                debt.Account.Balance -= payment.Amount;

                            // Обновление остатка долга
                            debt.RemainingAmount += payment.Amount;
                            debt.Status = debt.RemainingAmount > 0 ?
                                DebtStatus.Active :
                                DebtStatus.Repaid;

                            _context.DebtPayments.Remove(payment);
                            _context.SaveChanges();
                            transaction.Commit();

                            LoadPayments();
                            DataUpdated = true;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Ошибка удаления: {ex.Message}");
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}