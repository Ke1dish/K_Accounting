using K_Accounting.Data;
using K_Accounting.Models;
using K_Accounting.Utilities;

namespace K_Accounting.Forms
{
    public partial class AddEditMeasurementUnitForm : Form
    {
        private readonly AppDbContext _context;
        private MeasurementUnit _measurementUnit;
        public int? SavedUnitId { get; private set; }

        private bool _isEditMode;
        public bool IsEditMode
        {
            get => _isEditMode;
            set
            {
                _isEditMode = value;
                Text = value ? "Редактирование единицы" : "Добавление единицы";
                btnOk.Text = value ? "Сохранить" : "Создать";
            }
        }

        public event EventHandler DataUpdated;

        public AddEditMeasurementUnitForm(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
            txtName.Focus();
        }

        public AddEditMeasurementUnitForm(MeasurementUnit unit, AppDbContext context) : this(context)
        {
            _measurementUnit = unit;
            LoadUnitData();
        }

        private void LoadUnitData()
        {
            txtName.Text = _measurementUnit.Name;
            txtSymbol.Text = _measurementUnit.Symbol;
        }

        private bool ValidateForm()
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Название единицы обязательно для заполнения");
                return false;
            }

            bool nameExists = _isEditMode
                ? _context.MeasurementUnits.Any(u => u.Name == name && u.Id != _measurementUnit.Id)
                : _context.MeasurementUnits.Any(u => u.Name == name);

            if (nameExists)
            {
                MessageBox.Show("Единица с таким названием уже существует");
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
                    _measurementUnit.Name = txtName.Text.Trim();
                    _measurementUnit.Symbol = txtSymbol.Text.Trim();
                }
                else
                {
                    _measurementUnit = new MeasurementUnit
                    {
                        Name = txtName.Text.Trim(),
                        Symbol = txtSymbol.Text.Trim()
                    };
                    _context.MeasurementUnits.Add(_measurementUnit);
                }

                _context.SaveChanges();
                SavedUnitId = _measurementUnit.Id;

                DataUpdated?.Invoke(this, EventArgs.Empty);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
                SavedUnitId = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}