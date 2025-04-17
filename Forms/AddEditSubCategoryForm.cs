using System.Data;
using K_Accounting.Data;
using K_Accounting.Models;
using K_Accounting.Utilities;
using Microsoft.EntityFrameworkCore;

namespace K_Accounting.Forms
{
    public partial class AddEditSubCategoryForm : Form
    {
        private readonly AppDbContext _context;

        private SubCategory _subCategory;

        public int? SavedSubCategoryId { get; private set; }

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

        public event EventHandler DataUpdated;

        private List<Category> _categories;

        private readonly int? _preselectedCategoryId;

        private List<MeasurementUnit> _measurementUnits;

        private MeasurementUnit _selectedMeasurementUnit;

        private string toolTipText = "Здесь будет подсказка\n" +
        "Здесь будет подсказка\n" +
        "Здесь будет подсказка";

        public AddEditSubCategoryForm(int categoryId, AppDbContext context)
        {
            InitializeComponent();
            _context = context;
            _preselectedCategoryId = categoryId;
            LoadCategories();
            LoadMeasurementUnits();
            txtName.Focus();
            toolTip1.SetToolTip(pbDemandQuantityInfo, toolTipText);
            toolTip1.SetToolTip(pbQuantityRequirementInheritedInfo, toolTipText);
        }

        public AddEditSubCategoryForm(int categoryId, SubCategory subCategory, AppDbContext context) : this(categoryId, context)
        {
            _context = context;
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

                cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
                cmbCategory.DropDownStyle = ComboBoxStyle.DropDown;

                if (_preselectedCategoryId.HasValue)
                {
                    cmbCategory.SelectedValue = _preselectedCategoryId.Value;
                    cmbCategory.Text = _categories
                        .FirstOrDefault(c => c.Id == _preselectedCategoryId)?.Name;
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка загрузки категорий: {ex.Message}");
            }
        }

        private void LoadMeasurementUnits()
        {
            try
            {
                _measurementUnits = _context.MeasurementUnits
                    .Where(u => !u.IsDeleted)
                    .OrderBy(u => u.Name)
                    .ToList();

                cmbMeasurement.DataSource = _measurementUnits;
                cmbMeasurement.DisplayMember = "Name";
                cmbMeasurement.ValueMember = "Id";
                cmbMeasurement.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbMeasurement.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка загрузки единиц измерения: {ex.Message}");
            }
        }

        private void LoadSubCategoryData()
        {
            txtName.Text = _subCategory.Name;
            cmbCategory.SelectedValue = _subCategory.CategoryId;
            txtComment.Text = _subCategory.Comment;
            cmbCategory.Text = ((Category)cmbCategory.SelectedItem)?.Name;
            UpdateQuantityControls();
            cmbMeasurement.SelectedValue = _subCategory.MeasurementUnitId;
            UpdateQuantityControls();
        }

        private void cbDemandQuantity_CheckedChanged(object sender, EventArgs e)
        {
            UpdateQuantityControls();
        }

        private bool ValidateForm()
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Название подкатегории обязательно для заполнения");
                return false;
            }

            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Выберите категорию");
                return false;
            }

            int currentCategoryId = (int)cmbCategory.SelectedValue;
            bool nameExists;

            if (isEditMode)
            {
                nameExists = _context.SubCategories.Any(s =>
                    s.Name == name
                    && s.CategoryId == currentCategoryId
                    && s.Id != _subCategory.Id);
            }
            else
            {
                nameExists = _context.SubCategories.Any(s =>
                    s.Name == name
                    && s.CategoryId == currentCategoryId);
            }

            if (nameExists)
            {
                MessageBox.Show("Подкатегория с таким названием уже существует в выбранной категории.");
                return false;
            }

            if (cmbCategory.SelectedItem == null ||
                cmbCategory.Text != ((Category)cmbCategory.SelectedItem).Name)
            {
                MessageBox.Show("Выберите существующую категорию из списка");
                return false;
            }

            //if ((cbDemandQuantity.Checked || (category?.RequireQuantity == true)))
            if (cbDemandQuantity.Checked )
                {
                    if (cmbMeasurement.SelectedValue == null)
                {
                    MessageBox.Show("Выберите единицу измерения");
                    return false;
                }
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
                    _subCategory.Name = txtName.Text.Trim();
                    _subCategory.CategoryId = (int)cmbCategory.SelectedValue;
                    _subCategory.Comment = txtComment.Text.Trim();
                    _subCategory.MeasurementUnitId = (int?)cmbMeasurement.SelectedValue;

                    if (_subCategory.RequireQuantity)
                    {
                        _subCategory.InheritQuantityRequirement = true;
                        _subCategory.RequireQuantity = true;
                    }
                    else
                    {
                        _subCategory.InheritQuantityRequirement = false;
                        _subCategory.RequireQuantity = cbDemandQuantity.Checked;
                    }

                }
                else
                {
                    _subCategory = new SubCategory(
                        txtName.Text.Trim(),
                        (int)cmbCategory.SelectedValue)
                    {
                        Comment = txtComment.Text.Trim(),
                        InheritQuantityRequirement = category.RequireQuantity,
                        RequireQuantity = category.RequireQuantity ? true : cbDemandQuantity.Checked,
                        MeasurementUnitId = (int?)cmbMeasurement.SelectedValue
                    };
                    _context.SubCategories.Add(_subCategory);
                }

                _context.SaveChanges();
                SavedSubCategoryId = _subCategory.Id;

                DataUpdated?.Invoke(this, EventArgs.Empty);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
                SavedSubCategoryId = null;
            }
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditCategoryForm(_context))
            {
                form.DataUpdated += (s, args) =>
                {
                    var categories = _context.Categories
                        .Where(c => !c.IsDeleted)
                        .AsNoTracking()
                        .ToList();

                    cmbCategory.BeginUpdate();
                    cmbCategory.DataSource = null;
                    cmbCategory.DataSource = categories;
                    cmbCategory.DisplayMember = "Name";
                    cmbCategory.ValueMember = "Id";
                    cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
                    cmbCategory.DropDownStyle = ComboBoxStyle.DropDown;
                    cmbCategory.EndUpdate();

                    if (form.SavedCategoryId > 0)
                    {
                        cmbCategory.Refresh();
                        cmbCategory.SelectedValue = form.SavedCategoryId;
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

        private void btnNewMeasurement_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditMeasurementUnitForm(_context))
            {
                form.DataUpdated += (s, args) =>
                {
                    LoadMeasurementUnits();
                    if (form.SavedUnitId.HasValue)
                    {
                        cmbMeasurement.SelectedValue = form.SavedUnitId.Value;
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

        private void UpdateQuantityControls()
        {
            var category = cmbCategory.SelectedItem as Category;
            if (category == null) return;

            bool showMeasurement = false;

            if (category.RequireQuantity)
            {
                txtQuantityRequirementInherited.Visible = true;
                pbQuantityRequirementInheritedInfo.Visible = true;
                showMeasurement = true;
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
                showMeasurement = cbDemandQuantity.Checked;
                pbDemandQuantityInfo.Visible = true;
                cbDemandQuantity.Visible = true;
                if (_subCategory != null)
                {
                    cbDemandQuantity.Checked = _subCategory?.RequireQuantity ?? false;
                    _subCategory.InheritQuantityRequirement = false;
                }
            }

            lblMeasurement.Visible = showMeasurement;
            cmbMeasurement.Visible = showMeasurement;
            btnNewMeasurement.Visible = showMeasurement;

            if (showMeasurement)
            {
                if (_subCategory?.MeasurementUnitId != null)
                {
                    cmbMeasurement.SelectedValue = _subCategory.MeasurementUnitId;
                }
            }
        }
    }
}