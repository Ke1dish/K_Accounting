using K_Accounting.Data;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace K_Accounting.Forms
{
    public partial class FundGoalForm : Form
    {
        private readonly AppDbContext _context;
        private readonly int _goalId;
        private Goal _goal;

        public FundGoalForm(AppDbContext context, int goalId)
        {
            InitializeComponent();
            _context = context;
            _goalId = goalId;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Загрузка цели
                _goal = _context.Goals
                    .Include(g => g.Currency)
                    .FirstOrDefault(g => g.Id == _goalId);

                // Загрузка счетов
                LoadAccounts();

                if (_goal == null)
                {
                    MessageBox.Show("Цель не найдена!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}");
                Close();
            }
        }

        private void LoadAccounts()
        {
            // Загрузка активных счетов с той же валютой, что и цель
            cmbAccount.DataSource = _context.Accounts
                .Where(a => !a.IsDeleted) // Только это условие
                .ToList();

            cmbAccount.DisplayMember = "Name";
            cmbAccount.ValueMember = "Id";
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            // Открытие формы создания счета
            using (var form = new AddEditAccountsForm(_context))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadAccounts(); // Обновление списка после создания
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var account = cmbAccount.SelectedItem as Account;
                    var amount = numAmount.Value;

                    // 1. Снимаем средства со счета
                    account.Balance -= amount;
                    _context.Entry(account).State = EntityState.Modified;

                    // 2. Пополняем цель
                    _goal.CurrentAmount += amount;
                    _context.Entry(_goal).State = EntityState.Modified;

                    // Сохранение изменений
                    _context.SaveChanges();
                    transaction.Commit();

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Ошибка операции: {ex.Message}");
                }
            }
        }

        private bool ValidateInput()
        {
            if (cmbAccount.SelectedItem == null)
            {
                MessageBox.Show("Выберите счет!");
                return false;
            }

            if (numAmount.Value <= 0)
            {
                MessageBox.Show("Введите сумму больше нуля!");
                return false;
            }

            var account = cmbAccount.SelectedItem as Account;
            if (account.Balance < numAmount.Value)
            {
                MessageBox.Show("Недостаточно средств на счете!");
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