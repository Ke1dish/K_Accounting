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
    public partial class AddEditSubCategoryForm : Form
    {
        private readonly AppDbContext _context;

        private SubCategory _subCategory;
        private List<Category> _categories;
        private bool _isEditMode;
        public bool isEditMode
        {
            get => _isEditMode;
            set
            {
                _isEditMode = value;
                Text = value ? "Редактирование подкатегории" : "Добавление подкатегории";
                btnOk.Text = value ? "Сохранить" : "Создать";
            }
        }

        public int SavedSubCategoryId { get; private set; }

        public event EventHandler CategoryAdded;

        public event EventHandler SubCategoryAddedOrUpdated;

        // Добавляем унифицированное событие
        public event EventHandler DataUpdated;

        private readonly int? _preselectedCategoryId;

        public AddEditSubCategoryForm(AppDbContext context, int? categoryId = null)
        {
            InitializeComponent();
            _context = context;
            _preselectedCategoryId = categoryId;
            // Настройки ComboBox
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems; // Используем элементы из DataSource
            //cmbCategory.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            //cmbCategory.AutoCompleteCustomSource.AddRange(
            //    _context.Categories
            //        .Where(c => !c.IsDeleted)
            //        .Select(c => c.Name)
            //        .ToArray()
            //        );
            _context = context;
            _preselectedCategoryId = categoryId;
            LoadCategories();
            txtName.Focus();
        }

        //public AddEditSubCategoryForm(AppDbContext context, int? categoryId)
        //{
        //    InitializeComponent();
        //    _context = context;
        //    // Загрузка данных
        //    txtName.Focus();
        //}

        public AddEditSubCategoryForm()
        {
            InitializeComponent();
            LoadCategories();
            txtName.Focus();
        }

        public AddEditSubCategoryForm(SubCategory subCategory) : this()
        {
            _subCategory = subCategory;
            LoadSubCategoryData();
        }

        private void LoadCategories()
        {
            //using (var context = new AppDbContext())
            //{
            //    _categories = context.Categories
            //        .Where(c => !c.IsDeleted)
            //        .OrderBy(c => c.Name)
            //    .ToList();

            //    cmbCategory.DataSource = _categories;
            //    cmbCategory.DisplayMember = "Name";
            //    cmbCategory.ValueMember = "Id";
            //}

            try
            {
                _categories = _context.Categories
                    .Where(c => !c.IsDeleted)
                    .OrderBy(c => c.Name)
                    .ToList();

                cmbCategory.DataSource = _categories;
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "Id";

                // Настройки автодополнения
                cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
                cmbCategory.DropDownStyle = ComboBoxStyle.DropDown;

                // Установка предвыбранной категории
                if (_preselectedCategoryId.HasValue)
                {
                    cmbCategory.SelectedValue = _preselectedCategoryId.Value;
                    cmbCategory.Text = _categories
                        .FirstOrDefault(c => c.Id == _preselectedCategoryId)?.Name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки категорий: {ex.Message}");
            }
        }

        private void LoadSubCategoryData()
        {
            txtName.Text = _subCategory.Name;
            cmbCategory.SelectedValue = _subCategory.CategoryId;
            txtComment.Text = _subCategory.Comment;
            cmbCategory.Text = ((Category)cmbCategory.SelectedItem)?.Name;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Название подкатегории обязательно для заполнения");
                return false;
            }

            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать категорию");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Название подкатегории обязательно для заполнения");
                return false;
            }

            // Проверка корректности выбранной категории
            if (cmbCategory.SelectedItem == null ||
                cmbCategory.Text != ((Category)cmbCategory.SelectedItem).Name)
            {
                MessageBox.Show("Выберите существующую категорию из списка");
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
                        var existing = context.SubCategories.Find(_subCategory.Id);
                        if (existing != null)
                        {
                            existing.Name = txtName.Text.Trim();
                            existing.CategoryId = (int)cmbCategory.SelectedValue;
                            existing.Comment = txtComment.Text.Trim();
                            SavedSubCategoryId = existing.Id;
                        }
                    }
                    else
                    {
                        var newSubCategory = new SubCategory(
                        txtName.Text.Trim(),
                            (int)cmbCategory.SelectedValue)
                        {
                            Comment = txtComment.Text.Trim()
                        };
                        SavedSubCategoryId = newSubCategory.Id;
                        context.SubCategories.Add(newSubCategory);
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

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            //            using (var form = new AddEditCategoryForm())
            using (var form = new AddEditCategoryForm(_context)) // Передаем контекст
            {
                form.DataUpdated += (s, args) =>
                {
                    LoadCategories();
                    CategoryAdded?.Invoke(this, EventArgs.Empty);

                    // Автовыбор новой категории
                    if (form.SavedCategoryId > 0)
                        cmbCategory.SelectedValue = form.SavedCategoryId;
                };

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadCategories();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cmbCategory_TextChanged(object sender, EventArgs e)
        {
            var searchText = cmbCategory.Text.ToLower();
            var filtered = _categories
                .Where(c => c.Name.ToLower().Contains(searchText))
                .ToList();

            cmbCategory.DataSource = filtered;
        }
    }
}
