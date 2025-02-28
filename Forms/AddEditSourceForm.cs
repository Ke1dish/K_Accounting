using K_Accounting.Models;
using K_Accounting.Data;
using System;
using System.Windows.Forms;

namespace K_Accounting.Forms
{
    public partial class AddEditSourceForm : Form
    {
        private readonly AppDbContext _context;

        private Source _source;
        private bool _isEditMode;
        public bool isEditMode
        {
            get => _isEditMode;
            set
            {
                _isEditMode = value;
                Text = value ? "Редактирование источника" : "Добавление источника";
                btnOk.Text = value ? "Сохранить" : "Создать";
            }
        }

        // Добавляем унифицированное событие
        public event EventHandler DataUpdated;

        public AddEditSourceForm(AppDbContext context) // Новый конструктор
        {
            InitializeComponent();
            _context = context;
            txtName.Focus();
        }

        public AddEditSourceForm()
        {
            InitializeComponent();
            txtName.Focus();
        }

        public AddEditSourceForm(Source source) : this()
        {
            _source = source;
            LoadSourceData();
        }

        private void LoadSourceData()
        {
            txtName.Text = _source.Name;
            txtComment.Text = _source.Comment;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Название источника обязательно для заполнения");
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
                        var existing = context.Sources.Find(_source.Id);
                        if (existing != null)
                        {
                            existing.Name = txtName.Text.Trim();
                            existing.Comment = txtComment.Text.Trim();
                        }
                    }
                    else
                    {
                        var newSource = new Source(txtName.Text.Trim())
                        {
                            Comment = txtComment.Text.Trim()
                        };
                        context.Sources.Add(newSource);
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