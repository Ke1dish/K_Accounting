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

namespace K_Accounting.Forms
{
    public partial class AddEditCategoryForm : Form
    {
        private readonly AppDbContext _context;

        private Category _category;
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

        public int SavedCategoryId { get; private set; }

        // Добавляем унифицированное событие
        public event EventHandler DataUpdated;


        public AddEditCategoryForm(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
            txtName.Focus();
        }

        public AddEditCategoryForm()
        {
            InitializeComponent();
            txtName.Focus();
        }

        public AddEditCategoryForm(Category category) : this()
        {
            _category = category;
            LoadCategoryData();
        }

        private void InitializeForm()
        {
            Text = _isEditMode ? "Редактирование категории" : "Добавление категории";
            btnOk.Text = _isEditMode ? "Сохранить" : "Добавить";
        }

        private void LoadCategoryData()
        {
            txtName.Text = _category.Name;
            txtComment.Text = _category.Comment;
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
                            SavedCategoryId = existing.Id;
                        }
                    }
                    else
                    {
                        var newCategory = new Category(txtName.Text.Trim())
                        {
                            Comment = txtComment.Text.Trim()
                        };
                        SavedCategoryId = newCategory.Id;
                        context.Categories.Add(newCategory);
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
