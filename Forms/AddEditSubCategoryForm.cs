using System.Data;
using K_Accounting.Data;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;

namespace K_Accounting.Forms
{
    public partial class AddEditSubCategoryForm : Form
    {
        private readonly AppDbContext _context;

        public int SavedSubCategoryId { get; private set; }

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

        public event EventHandler CategoryAdded;

        public event EventHandler SubCategoryAddedOrUpdated;

        // Добавляем унифицированное событие
        public event EventHandler DataUpdated;

        private readonly int? _preselectedCategoryId;

        // Конструктор для добавления новой подкатегории
        public AddEditSubCategoryForm(AppDbContext context, int? categoryId = null)
        {
            InitializeComponent();
            _context = context ?? new AppDbContext(); // Если контекст null, создаем новый
            _preselectedCategoryId = categoryId;
            LoadCategories();
            txtName.Focus();

            toolTip1.SetToolTip(pbDemandQuantityInfo, 
                "Включите, если для этой подкатегории\nтребуется указывать количество");
            toolTip1.SetToolTip(pbQuantityRequirementInheritedInfo,
                "Настройка унаследована от категории\n'Требовать количество'");

        }

        // Конструктор для редактирования существующей подкатегории
        public AddEditSubCategoryForm(AppDbContext context, SubCategory subCategory)
            : this(context, subCategory.CategoryId) // Используем основной конструктор
        {
            _subCategory = subCategory;
            LoadSubCategoryData();
        }

        private void LoadCategories()
        {
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
            UpdateQuantityControls();
        }

        private void UpdateQuantityControls()
        {
            var category = cmbCategory.SelectedItem as Category;
            if (category == null) return;

            if (category.RequireQuantity)
            {
                txtQuantityRequirementInherited.Visible = true;
                pbQuantityRequirementInheritedInfo.Visible = true;
                cbDemandQuantity.Visible = false;
                pbDemandQuantityInfo.Visible = false;
                if (_subCategory != null)
                {
                    _subCategory.InheritQuantityRequirement = true;
                    _subCategory.RequireQuantity = true;
                }
            }
            else
            {
                txtQuantityRequirementInherited.Visible = false;
                pbQuantityRequirementInheritedInfo.Visible = false;
                pbDemandQuantityInfo.Visible = true;
                cbDemandQuantity.Visible = true;
                if (_subCategory != null)
                {
                    cbDemandQuantity.Checked = _subCategory?.RequireQuantity ?? false;
                    _subCategory.InheritQuantityRequirement = false;
                }
            }
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


            try
            {
                var category = cmbCategory.SelectedItem as Category;

                if (_isEditMode)
                {
                    // Редактирование существующей записи
                    var existing = _context.SubCategories.Find(_subCategory.Id);
                    if (existing != null)
                    {
                        existing.Name = txtName.Text.Trim();
                        existing.CategoryId = (int)cmbCategory.SelectedValue;
                        existing.Comment = txtComment.Text.Trim();

                        // Добавляем логику сохранения настроек количества
                        if (category.RequireQuantity)
                        {
                            existing.InheritQuantityRequirement = true;
                            existing.RequireQuantity = true;
                        }
                        else
                        {
                            existing.InheritQuantityRequirement = false;
                            existing.RequireQuantity = cbDemandQuantity.Checked;
                        }

                        _context.SaveChanges();
                        SavedSubCategoryId = existing.Id;
                    }
                }
                else
                {
                    // Создание новой записи
                    var newSubCategory = new SubCategory(
                        txtName.Text.Trim(),
                        (int)cmbCategory.SelectedValue)
                    {
                        Comment = txtComment.Text.Trim(),

                        // Добавляем логику инициализации настроек количества
                        InheritQuantityRequirement = category.RequireQuantity,
                        RequireQuantity = category.RequireQuantity ? true : cbDemandQuantity.Checked
                    };

                    _context.SubCategories.Add(newSubCategory);
                    _context.SaveChanges();
                    SavedSubCategoryId = newSubCategory.Id;
                }

                DataUpdated?.Invoke(this, EventArgs.Empty);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
            }

            //try
            //{
            //    var category = cmbCategory.SelectedItem as Category;

            //    if (_isEditMode)
            //    {
            //        // Редактирование существующей записи
            //        var existing = _context.SubCategories.Find(_subCategory.Id);
            //        if (existing != null)
            //        {
            //            existing.Name = txtName.Text.Trim();
            //            existing.CategoryId = (int)cmbCategory.SelectedValue;
            //            existing.Comment = txtComment.Text.Trim();
            //            if (category.RequireQuantity)
            //            {
            //                existing.InheritQuantityRequirement = true;
            //                existing.RequireQuantity = true;
            //            }
            //            else
            //            {
            //                existing.InheritQuantityRequirement = false;
            //                existing.RequireQuantity = cbDemandQuantity.Checked;
            //            }
            //            _context.SaveChanges();
            //            SavedSubCategoryId = existing.Id;
            //        }
            //    }
            //    else
            //    {
            //        // Создание новой записи
            //        var newSubCategory = new SubCategory(
            //            txtName.Text.Trim(),
            //            (int)cmbCategory.SelectedValue)
            //        {
            //            Comment = txtComment.Text.Trim()
            //        };

            //        if (category.RequireQuantity)
            //        {
            //            newSubCategory.InheritQuantityRequirement = true;
            //            newSubCategory.RequireQuantity = true;
            //        }
            //        else
            //        {
            //            newSubCategory.InheritQuantityRequirement = false;
            //            newSubCategory.RequireQuantity = cbDemandQuantity.Checked;
            //        }

            //        _context.SubCategories.Add(newSubCategory);
            //        _context.SaveChanges(); // Сохраняем для генерации ID
            //        SavedSubCategoryId = newSubCategory.Id; // Сохраняем ID новой записи
            //    }

            //    // Сохраняем изменения в переданном контексте
            //    DataUpdated?.Invoke(this, EventArgs.Empty);
            //    DialogResult = DialogResult.OK;
            //    Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Ошибка сохранения: {ex.Message}");
            //}
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditCategoryForm(_context))
            {
                form.DataUpdated += (s, args) =>
                {
                    // 1. Обновляем список категорий с новыми данными
                    var categories = _context.Categories
                        .Where(c => !c.IsDeleted)
                        .AsNoTracking()
                        .ToList();

                    // 2. Полная перезагрузка комбобокса
                    cmbCategory.BeginUpdate();
                    cmbCategory.DataSource = null;
                    cmbCategory.DataSource = categories;
                    cmbCategory.DisplayMember = "Name";
                    cmbCategory.ValueMember = "Id";
                    cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
                    cmbCategory.DropDownStyle = ComboBoxStyle.DropDown;
                    cmbCategory.EndUpdate();

                    // 3. Установка новой категории
                    if (form.SavedCategoryId > 0)
                    {
                        // 4. Принудительное обновление перед выбором
                        cmbCategory.Refresh();

                        // 5. Установка значения через SelectedValue
                        cmbCategory.SelectedValue = form.SavedCategoryId;

                        // 6. Ручная установка текста при необходимости
                        var newCategory = categories.FirstOrDefault(c => c.Id == form.SavedCategoryId);
                        if (newCategory != null)
                        {
                            cmbCategory.Text = newCategory.Name;
                        }
                    }
                };

                form.ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateQuantityControls();
        }

        private void AddEditSubCategoryForm_Load(object sender, EventArgs e)
        {
            UpdateQuantityControls();
        }
    }
}