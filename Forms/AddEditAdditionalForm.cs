using K_Accounting.Data;
using K_Accounting.Models;

namespace K_Accounting.Forms
{
    public partial class AddEditAdditionalForm : Form
    {
        private readonly AppDbContext _context;

        private Additional _additional;

        public int? SavedAdditionalId { get; private set; }

        private bool _isEditMode;
        public bool isEditMode
        {
            get => _isEditMode;
            set
            {
                _isEditMode = value;
                Text = value ? "Редактирование упоминания" : "Добавление упоминания";
                btnOk.Text = value ? "Сохранить" : "Создать";
            }
        }

        // Добавляем унифицированное событие
        public event EventHandler DataUpdated;

        public AddEditAdditionalForm(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
            txtName.Focus();
        }

        public AddEditAdditionalForm(Additional additional, AppDbContext context) : this(context)
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
            string name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Название обязательно для заполнения");
                return false;
            }

            bool nameExists;

            if (isEditMode)
            {
                // Проверяем существование имени, исключая текущий редактируемый источник
                nameExists = _context.Additionals.Any(s => s.Name == name && s.Id != _additional.Id);
            }
            else
            {
                // Проверяем существование имени для нового источника
                nameExists = _context.Additionals.Any(s => s.Name == name);
            }

            if (nameExists)
            {
                MessageBox.Show("Упоминание с таким именем уже существует.");
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
                    _additional.Name = txtName.Text.Trim();
                    _additional.Comment = txtComment.Text.Trim();
                }
                else
                {
                    _additional = new Additional(txtName.Text.Trim())
                    {
                        Comment = txtComment.Text.Trim()
                    };
                    _context.Additionals.Add(_additional);
                }

                _context.SaveChanges();
                SavedAdditionalId = _additional.Id;

                DataUpdated?.Invoke(this, EventArgs.Empty);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
                SavedAdditionalId = null; // Сбрасываем ID при ошибке
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}