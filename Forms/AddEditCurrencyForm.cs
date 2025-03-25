using K_Accounting.Data;
using K_Accounting.Models;

namespace K_Accounting.Forms
{
    public partial class AddEditCurrencyForm : Form
    {
        private readonly AppDbContext _context;

        private Currency _currency;

        public int? SavedCurrencyId { get; private set; }

        private bool _isEditMode;
        public bool isEditMode
        {
            get => _isEditMode;
            set
            {
                _isEditMode = value;
                Text = value ? "Редактирование валюты" : "Добавление валюты";
                btnOk.Text = value ? "Сохранить" : "Создать";
            }
        }

        // Добавляем унифицированное событие
        public event EventHandler DataUpdated;

        public AddEditCurrencyForm(AppDbContext context) // Новый конструктор
        {
            InitializeComponent();
            numRate.Value = 1;
            numRate.Controls[0].Visible = false;
            _context = context;
            txtName.Focus();
        }

        public AddEditCurrencyForm(Currency currency, AppDbContext context) : this(context)
        {
            _currency = currency;
            LoadCurrencyData();
        }

        //public AddEditCurrencyForm()
        //{
        //    InitializeComponent();
        //    numRate.Controls[0].Visible = false;
        //    txtName.Focus();
        //}

        //public AddEditCurrencyForm(Currency currency) : this()
        //{
        //    _currency = currency;
        //    LoadCurrencyData();
        //}

        private void LoadCurrencyData()
        {
            txtName.Text = _currency.Name;
            txtSymbol.Text = _currency.Symbol;
            numRate.Value = _currency.Rate;
            txtComment.Text = _currency.Comment;
        }

        private bool ValidateForm()
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Название валюты обязательно для заполнения");
                return false;
            }

            if (numRate.Value <= 0)
            {
                MessageBox.Show("Курс должен быть больше нуля");
                return false;
            }

            bool nameExists;

            if (isEditMode)
            {
                // Проверяем существование имени, исключая текущий редактируемый источник
                nameExists = _context.Currencies.Any(s => s.Name == name && s.Id != _currency.Id);
            }
            else
            {
                // Проверяем существование имени для нового источника
                nameExists = _context.Currencies.Any(s => s.Name == name);
            }

            if (nameExists)
            {
                MessageBox.Show("Валюта с таким названием уже существует.");
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
                    _currency.Name = txtName.Text.Trim();
                    _currency.Symbol = txtSymbol.Text.Trim();
                    _currency.Rate = numRate.Value;
                    _currency.Comment = txtComment.Text.Trim();
                }
                else
                {
                    _currency = new Currency(txtName.Text.Trim(), numRate.Value)
                    {
                        Symbol = txtSymbol.Text.Trim(),
                        Comment = txtComment.Text.Trim()
                    };
                    _context.Currencies.Add(_currency);
                }

                _context.SaveChanges();
                SavedCurrencyId = _currency.Id;

                DataUpdated?.Invoke(this, EventArgs.Empty);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
                SavedCurrencyId = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}