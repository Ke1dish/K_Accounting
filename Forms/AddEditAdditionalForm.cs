using K_Accounting.Models;
using K_Accounting.Data;
using System;
using System.Windows.Forms;

namespace K_Accounting.Forms
{
    public partial class AddEditAdditionalForm : Form
    {
        private readonly AppDbContext _context;

        private Additional _additional;
        private bool _isEditMode;
        public bool isEditMode
        {
            get => _isEditMode;
            set
            {
                _isEditMode = value;
                Text = value ? "Редактирование дополнительного" : "Добавление дополнительного";
                btnOk.Text = value ? "Сохранить" : "Создать";
            }
        }

        public int SavedAdditionalId { get; private set; }

        // Добавляем унифицированное событие
        public event EventHandler DataUpdated;

        public AddEditAdditionalForm(AppDbContext context)
        {
            //InitializeComponent();
            //_context = context;

            InitializeComponent();
            _context = context;
            txtName.Focus();
        }

        public AddEditAdditionalForm()
        {
            InitializeComponent();
            txtName.Focus();
        }

        public AddEditAdditionalForm(Additional additional) : this()
        {
            _additional = additional;
            LoadAdditionalData();
        }

        private void LoadAdditionalData()
        {
            txtName.Text = _additional.Name;
            txtComment.Text = _additional.Comment;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Название обязательно для заполнения");
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
                        var existing = context.Additionals.Find(_additional.Id);
                        if (existing != null)
                        {
                            existing.Name = txtName.Text.Trim();
                            existing.Comment = txtComment.Text.Trim();
                            SavedAdditionalId = existing.Id;
                        }
                    }
                    else
                    {
                        var newAdditional = new Additional(
                            txtName.Text.Trim())
                        {
                            Comment = txtComment.Text.Trim()
                        };

                        SavedAdditionalId = newAdditional.Id;
                        context.Additionals.Add(newAdditional);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}