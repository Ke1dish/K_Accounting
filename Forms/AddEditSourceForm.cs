using K_Accounting.Data;
using K_Accounting.Models;

namespace K_Accounting.Forms
{
    public partial class AddEditSourceForm : Form
    {
        private readonly AppDbContext _context;

        public int SavedSourceId { get; private set; } // Новое свойство

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
                        // Редактирование существующего источника
                        var existing = context.Sources.Find(_source.Id);
                        existing.Name = txtName.Text.Trim();
                        existing.Comment = txtComment.Text.Trim();
                        SavedSourceId = existing.Id;
                    }
                    else
                    {
                        // Создание нового источника
                        var newSource = new Source(txtName.Text.Trim())
                        {
                            Comment = txtComment.Text.Trim()
                        };
                        context.Sources.Add(newSource);
                        context.SaveChanges(); // Сохраняем чтобы получить ID
                        SavedSourceId = newSource.Id; // Сохраняем ID нового источника
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