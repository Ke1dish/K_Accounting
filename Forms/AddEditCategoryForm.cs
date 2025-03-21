using K_Accounting.Data;
using K_Accounting.Models;

namespace K_Accounting.Forms
{
    public partial class AddEditCategoryForm : Form
    {
        private readonly AppDbContext _context;

        public int SavedCategoryId { get; private set; }

        private Category _category;

        private string toolTipText = "Здесь будет подсказка\n" +
                "Здесь будет подсказка\n" +
                "Здесь будет подсказка";

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


        public AddEditCategoryForm(AppDbContext context)
        {
            InitializeComponent();
            toolTip1.SetToolTip(pbRequireQuantityInfo, toolTipText);
            _context = context;
            txtName.Focus();
        }

        public AddEditCategoryForm()
        {
            InitializeComponent();
            toolTip1.SetToolTip(pbRequireQuantityInfo, toolTipText);
            txtName.Focus();
        }

        public AddEditCategoryForm(Category category) : this()
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
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Название категории обязательно для заполнения");
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
                        var existing = context.Categories.Find(_category.Id);
                        if (existing != null)
                        {
                            existing.Name = txtName.Text.Trim();
                            existing.Comment = txtComment.Text.Trim();
                            existing.RequireQuantity = cbRequireQuantity.Checked;
                            context.SaveChanges();
                            SavedCategoryId = existing.Id;
                        }
                    }
                    else
                    {
                        var newCategory = new Category(txtName.Text.Trim())
                        {
                            Comment = txtComment.Text.Trim(),
                            RequireQuantity = cbRequireQuantity.Checked
                        };
                        context.Categories.Add(newCategory);
                        context.SaveChanges();
                        SavedCategoryId = newCategory.Id; // Сохраняем ID
                    }
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