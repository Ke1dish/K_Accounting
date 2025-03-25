using K_Accounting.Data;
using K_Accounting.Models;

namespace K_Accounting.Forms
{
    public partial class AddEditCategoryForm : Form
    {
        private readonly AppDbContext _context;

        private Category _category;

        public int? SavedCategoryId { get; private set; }

        private bool _isEditMode;
        public bool isEditMode
        {
            get => _isEditMode;
            set
            {
                _isEditMode = value;
                Text = value ? "Редактирование категории" : "Добавление категории";
                btnOk.Text = value ? "Сохранить" : "Создать";
            }
        }

        // Добавляем унифицированное событие
        public event EventHandler DataUpdated;

        private string toolTipText = "Здесь будет подсказка\n" +
                "Здесь будет подсказка\n" +
                "Здесь будет подсказка";

        public AddEditCategoryForm(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
            txtName.Focus();
            toolTip1.SetToolTip(pbRequireQuantityInfo, toolTipText);
        }

        public AddEditCategoryForm(Category category, AppDbContext context) : this(context)
        {
            _category = category;
            LoadCategoryData();
        }

        private void LoadCategoryData()
        {
            txtName.Text = _category.Name;
            txtComment.Text = _category.Comment;
            cbRequireQuantity.Checked = _category.RequireQuantity;
        }

        private bool ValidateForm()
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Название категории обязательно для заполнения");
                return false;
            }

            bool nameExists;

            if (isEditMode)
            {
                nameExists = _context.Categories.Any(s => s.Name == name && s.Id != _category.Id);
            }
            else
            {
                nameExists = _context.Categories.Any(s => s.Name == name);
            }

            if (nameExists)
            {
                MessageBox.Show("Категория с таким названием уже существует.");
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
                    _category.Name = txtName.Text.Trim();
                    _category.Comment = txtComment.Text.Trim();
                    _category.RequireQuantity = cbRequireQuantity.Checked;
                }
                else
                {
                    _category = new Category(txtName.Text.Trim())
                    {
                        Comment = txtComment.Text.Trim(),
                        RequireQuantity = cbRequireQuantity.Checked
                    };
                    _context.Categories.Add(_category);
                }

                _context.SaveChanges();
                SavedCategoryId = _category.Id;

                DataUpdated?.Invoke(this, EventArgs.Empty);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
                SavedCategoryId = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}