using K_Accounting.Data;
using K_Accounting.Models;
using K_Accounting.Utilities;

namespace K_Accounting.Forms
{
    public partial class AddEditSourceForm : Form
    {
        private readonly AppDbContext _context;

        private Source _source;

        public int? SavedSourceId { get; private set; }

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

        public AddEditSourceForm(Source source, AppDbContext context) : this(context)
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
            string name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Название источника обязательно для заполнения");
                return false;
            }

            bool nameExists;

            if (isEditMode)
            {
                // Проверяем существование имени, исключая текущий редактируемый источник
                nameExists = _context.Sources.Any(s => s.Name == name && s.Id != _source.Id);
            }
            else
            {
                // Проверяем существование имени для нового источника
                nameExists = _context.Sources.Any(s => s.Name == name);
            }

            if (nameExists)
            {
                MessageBox.Show("Источник с таким названием уже существует.");
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
                    _source.Name = txtName.Text.Trim();
                    _source.Comment = txtComment.Text.Trim();
                }
                else
                {
                    _source = new Source(txtName.Text.Trim())
                    {
                        Comment = txtComment.Text.Trim()
                    };
                    _context.Sources.Add(_source);
                }

                _context.SaveChanges();
                SavedSourceId = _source.Id;

                DataUpdated?.Invoke(this, EventArgs.Empty);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
                SavedSourceId = null; // Сбрасываем ID при ошибке
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}