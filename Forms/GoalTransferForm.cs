using K_Accounting.Data;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace K_Accounting.Forms
{
    public partial class GoalTransferForm : Form
    {
        private readonly AppDbContext _context;
        private readonly int _sourceGoalId;
        private Goal _sourceGoal;

        public GoalTransferForm(AppDbContext context, int sourceGoalId)
        {
            InitializeComponent();
            _context = context;
            _sourceGoalId = sourceGoalId;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Загрузка исходной цели
                _sourceGoal = _context.Goals
                    .Include(g => g.Currency)
                    .FirstOrDefault(g => g.Id == _sourceGoalId);

                if (_sourceGoal == null)
                {
                    MessageBox.Show("Исходная цель не найдена!");
                    Close();
                    return;
                }

                // Настройка исходной цели
                cmbSourceGoal.DataSource = new[] { _sourceGoal };
                cmbSourceGoal.DisplayMember = "Title";
                cmbSourceGoal.Enabled = false;

                // Загрузка целей для перевода
                LoadTransferTargets();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}");
                Close();
            }
        }

        private void LoadTransferTargets()
        {
            // Загрузка активных целей (исключая текущую)
            var goals = _context.Goals
                .Where(g => !g.IsDeleted && g.Id != _sourceGoalId)
                .Include(g => g.Currency)
                .ToList();

            // Загрузка активных счетов
            var accounts = _context.Accounts
                .Where(a => !a.IsDeleted)
                .Include(a => a.Currency)
                .ToList();

            // Объединение в один список с метками
            var targets = goals
                .Select(g => new { Id = g.Id, Name = $"[Цель] {g.Title}", Type = "Goal", Entity = (object)g })
                .Concat(accounts.Select(a => new { Id = a.Id, Name = $"[Счет] {a.Name}", Type = "Account", Entity = (object)a }))
                .ToList();

            cmbTarget.DataSource = targets;
            cmbTarget.DisplayMember = "Name";
            cmbTarget.ValueMember = "Id";
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var selectedTarget = (dynamic)cmbTarget.SelectedItem;
                    decimal amount = numAmount.Value;

                    // 1. Снимаем средства с исходной цели
                    if (_sourceGoal.CurrentAmount < amount)
                    {
                        MessageBox.Show("Недостаточно средств в цели!");
                        return;
                    }

                    _sourceGoal.CurrentAmount -= amount;
                    _context.Entry(_sourceGoal).State = EntityState.Modified;

                    // 2. Зачисляем средства на выбранную цель/счет
                    if (selectedTarget.Type == "Goal")
                    {
                        var targetGoal = (Goal)selectedTarget.Entity;
                        targetGoal.CurrentAmount += ConvertCurrency(amount, _sourceGoal.Currency, targetGoal.Currency);
                        _context.Entry(targetGoal).State = EntityState.Modified;
                    }
                    else
                    {
                        var targetAccount = (Account)selectedTarget.Entity;
                        targetAccount.Balance += ConvertCurrency(amount, _sourceGoal.Currency, targetAccount.Currency);
                        _context.Entry(targetAccount).State = EntityState.Modified;
                    }

                    _context.SaveChanges();
                    transaction.Commit();

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Ошибка перевода: {ex.Message}");
                }
            }
        }

        private decimal ConvertCurrency(decimal amount, Currency fromCurrency, Currency toCurrency)
        {
            if (fromCurrency.Id == toCurrency.Id) return amount;
            return amount * fromCurrency.Rate / toCurrency.Rate;
        }

        private bool ValidateInput()
        {
            if (cmbTarget.SelectedItem == null)
            {
                MessageBox.Show("Выберите цель или счет для перевода!");
                return false;
            }

            if (numAmount.Value <= 0)
            {
                MessageBox.Show("Введите корректную сумму!");
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}