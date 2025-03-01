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
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;

namespace K_Accounting.Forms
{
    public partial class AddEditIncomeForm : Form
    {
        private readonly AppDbContext _context;

        private Income _income;
        private decimal _originalAmount;
        private int _originalAccountId;
        private bool _isEditMode;
        public bool isEditMode
        {
            get => _isEditMode;
            set
            {
                _isEditMode = value;
                Text = value ? "Редактирование прихода" : "Добавление прихода";
                btnOk.Text = value ? "Сохранить" : "Создать";
            }
        }

        public event EventHandler DataUpdated;

        public AddEditIncomeForm(AppDbContext context)
        {
            InitializeComponent();
            numAmount.Controls[0].Visible = false;
            _context = context;
            InitializeData();
            dtpDate.Focus();
        }

        public AddEditIncomeForm(AppDbContext context, Income income) : this(context)
        {
            _income = income;
            LoadIncomeData();
            dtpDate.Focus();
        }

        private void InitializeData()
        {
            // Загрузка счетов
            cmbAccount.DataSource = _context.Accounts
                .Where(a => !a.IsDeleted)
                .OrderBy(a => a.Name) // Сортировка по имени
                .ToList();
            cmbAccount.DisplayMember = "Name";
            cmbAccount.ValueMember = "Id";
            cmbAccount.AutoCompleteMode = AutoCompleteMode.SuggestAppend; // Автодополнение
            cmbAccount.AutoCompleteSource = AutoCompleteSource.ListItems; // Источник данных
            cmbAccount.DropDownStyle = ComboBoxStyle.DropDown; // Разрешить ручной ввод

            // Загрузка источников
            cmbSource.DataSource = _context.Sources
                .Where(s => !s.IsDeleted)
                .OrderBy(s => s.Name) // Сортировка по имени
                .ToList();
            cmbSource.DisplayMember = "Name";
            cmbSource.ValueMember = "Id";
            cmbSource.AutoCompleteMode = AutoCompleteMode.SuggestAppend; // Автодополнение
            cmbSource.AutoCompleteSource = AutoCompleteSource.ListItems; // Источник данных
            cmbSource.DropDownStyle = ComboBoxStyle.DropDown; // Разрешить ручной ввод
        }

        private void LoadIncomeData()
        {
            if (_income == null) return;

            _originalAmount = _income.Amount;
            _originalAccountId = _income.AccountId;

            dtpDate.Value = _income.Date;
            numAmount.Value = _income.Amount;
            cmbAccount.SelectedValue = _income.AccountId;
            cmbSource.SelectedValue = _income.SourceId;
            txtComment.Text = _income.Comment;

            // Установка текста для корректного отображения
            cmbAccount.Text = ((Account)cmbAccount.SelectedItem)?.Name;
            cmbSource.Text = ((Source)cmbSource.SelectedItem)?.Name;
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
                        if (originalAccount != null)
                        {
                            originalAccount.Balance -= _originalAmount;
                            _context.Entry(originalAccount).State = EntityState.Modified;
                        }

                        // Обновляем приход
                        _income.Date = dtpDate.Value;
                        _income.Amount = newAmount;
                        _income.AccountId = newAccountId;
                        _income.SourceId = (int)cmbSource.SelectedValue;
                        _income.Comment = txtComment.Text;
                    }
                    else
                    {
                        // Создаем новый приход
                        _income = new Income
                        {
                            Date = dtpDate.Value,
                            Amount = newAmount,
                            AccountId = newAccountId,
                            SourceId = (int)cmbSource.SelectedValue,
                            Comment = txtComment.Text
                        };
                        _context.Incomes.Add(_income);
                    }

                    // Добавляем новую сумму
                    account.Balance += newAmount;

                    // Проверка баланса
                    if (account.Balance < 0)
                    {
                        MessageBox.Show("Отрицательный баланс после операции!");
                        transaction.Rollback();
                        return;
                    }

                    _context.SaveChanges();
                    transaction.Commit();

                    DataUpdated?.Invoke(this, EventArgs.Empty);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Ошибка: {ex.Message}");
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

            // Проверка счета
            if (cmbAccount.SelectedItem == null ||
                cmbAccount.Text != ((Account)cmbAccount.SelectedItem).Name)
            {
                MessageBox.Show("Выберите существующий счет из списка");
                return false;
            }

            // Проверка источника
            if (cmbSource.SelectedItem == null ||
                cmbSource.Text != ((Source)cmbSource.SelectedItem).Name)
            {
                MessageBox.Show("Выберите существующий источник из списка");
                return false;
            }

            if (numAmount.Value <= 0)
            {
                MessageBox.Show("Сумма должна быть больше нуля");
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // Обработчики для кнопок добавления новых элементов
        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditAccountsForm(_context))
            {
                form.DataUpdated += (s, args) =>
                {
                    InitializeData(); // Обновляем список счетов
                    if (form.SavedAccountId > 0)
                        cmbAccount.SelectedValue = form.SavedAccountId;
                };
                form.ShowDialog();
            }
        }

        private void btnNewSource_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditSourceForm(_context))
            {
                form.DataUpdated += (s, args) =>
                {
                    InitializeData(); // Обновляем список источников
                    //if (form.SavedSourceId > 0)                             //это пока не работает нужно сделать
                    //    cmbSource.SelectedValue = form.SavedSourceId;       //это пока не работает нужно сделать
                };
                form.ShowDialog();
            }
        }
    }
}
