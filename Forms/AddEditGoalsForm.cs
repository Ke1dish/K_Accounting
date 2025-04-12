using System.Data;
using System.Windows.Forms;
using K_Accounting.Data;
using K_Accounting.Models;
using K_Accounting.Utilities;
using Microsoft.EntityFrameworkCore;

namespace K_Accounting.Forms
{
    public partial class AddEditGoalsForm : Form
    {
        private readonly AppDbContext _context;
        private Goal _goal;

        public int? SavedGoalId { get; private set; }
        public event EventHandler DataUpdated;

        private bool _isEditMode;
        public bool isEditMode
        {
            get => _isEditMode;
            set
            {
                _isEditMode = value;
                Text = value ? "Редактирование цели" : "Добавление цели";
                btnOk.Text = value ? "Сохранить" : "Создать";
            }
        }

        public AddEditGoalsForm(AppDbContext context)
        {
            InitializeComponent();
            numTargetAmount.Controls[0].Visible = false;
            numCurrentAmount.Controls[0].Visible = false;
            _context = context;
            LoadCurrencies();
            LoadStatuses();
            txtTitle.Focus();
        }

        public AddEditGoalsForm(Goal goal, AppDbContext context) : this(context)
        {
            _goal = goal;
            LoadGoalData();
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
                cmbCurrency.EndUpdate();
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка загрузки валют: {ex.Message}");
            }
        }

        private void LoadStatuses()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new object[] {
                GoalStatus.Active,
                GoalStatus.Frozen,
                GoalStatus.Completed
            });
        }

        private void LoadGoalData()
        {
            txtTitle.Text = _goal.Title;
            numTargetAmount.Value = _goal.TargetAmount;
            numCurrentAmount.Value = _goal.CurrentAmount;
            cmbCurrency.SelectedValue = _goal.CurrencyId;
            cmbStatus.SelectedItem = _goal.Status;
            dtpTargetDate.Value = _goal.TargetDate;
            txtComment.Text = _goal.Comment;

            if (_goal.ReminderDate.HasValue)
            {
                chkReminder.Checked = true;
                dtpReminderDate.Value = _goal.ReminderDate.Value;
            }
        }

        private bool ValidateForm()
        {
            string title = txtTitle.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Название цели обязательно для заполнения");
                return false;
            }

            bool titleExists = _isEditMode ?
                _context.Goals.Any(g => g.Title == title && g.Id != _goal.Id) :
                _context.Goals.Any(g => g.Title == title);

            if (titleExists)
            {
                MessageBox.Show("Цель с таким названием уже существует");
                return false;
            }

            if (cmbCurrency.SelectedItem == null ||
                cmbCurrency.Text != ((Currency)cmbCurrency.SelectedItem).Name)
            {
                MessageBox.Show("Выберите существующую валюту из списка");
                return false;
            }

            if (dtpTargetDate.Value < DateTime.Today)
            {
                MessageBox.Show("Дата цели не может быть в прошлом");
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
                    UpdateExistingGoal();
                }
                else
                {
                    CreateNewGoal();
                }

                _context.SaveChanges();
                DataUpdated?.Invoke(this, EventArgs.Empty);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
            }
        }

        private void UpdateExistingGoal()
        {
            _goal.Title = txtTitle.Text.Trim();
            _goal.TargetAmount = numTargetAmount.Value;
            _goal.CurrentAmount = numCurrentAmount.Value;
            _goal.CurrencyId = (int)cmbCurrency.SelectedValue;
            _goal.Status = (GoalStatus)cmbStatus.SelectedItem;
            _goal.TargetDate = dtpTargetDate.Value;
            _goal.Comment = txtComment.Text.Trim();
            _goal.ReminderDate = chkReminder.Checked ? dtpReminderDate.Value : (DateTime?)null;
        }

        private void CreateNewGoal()
        {
            _goal = new Goal
            {
                Title = txtTitle.Text.Trim(),
                TargetAmount = numTargetAmount.Value,
                CurrentAmount = numCurrentAmount.Value,
                CurrencyId = (int)cmbCurrency.SelectedValue,
                Status = (GoalStatus)cmbStatus.SelectedItem,
                TargetDate = dtpTargetDate.Value,
                Comment = txtComment.Text.Trim(),
                ReminderDate = chkReminder.Checked ? dtpReminderDate.Value : null
            };
            _context.Goals.Add(_goal);
        }

        private void btnNewCurrency_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditCurrencyForm(_context))
            {
                form.isEditMode = false;
                form.DataUpdated += (s, args) => LoadCurrencies();

                if (form.ShowDialog() == DialogResult.OK && form.SavedCurrencyId.HasValue)
                {
                    cmbCurrency.SelectedValue = form.SavedCurrencyId.Value;
                }
            }
        }

        private void chkReminder_CheckedChanged(object sender, EventArgs e)
        {
            dtpReminderDate.Enabled = chkReminder.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}