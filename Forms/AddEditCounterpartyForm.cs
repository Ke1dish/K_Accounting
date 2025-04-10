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
    public partial class AddEditCounterpartyForm : Form
    {
        private readonly AppDbContext _context;

        private Counterparty _counterparty;

        public int? SavedCounterpartyId { get; private set; }

        private bool _isEditMode;
        public bool isEditMode
        {
            get => _isEditMode;
            set
            {
                _isEditMode = value;
                Text = value ? "Редактирование контрагента" : "Добавление контрагента";
                btnOk.Text = value ? "Сохранить" : "Создать";
            }
        }

        public event EventHandler DataUpdated;

        public AddEditCounterpartyForm(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
            txtName.Focus();
        }

        public AddEditCounterpartyForm(Counterparty counterparty, AppDbContext context) : this(context)
        {
            _counterparty = counterparty;
            LoadCounterpartyData();
        }

        private void LoadCounterpartyData()
        {
            txtName.Text = _counterparty.Name;
            txtPhone.Text = _counterparty.Phone;
            txtEmail.Text = _counterparty.Email;
            txtAddress.Text = _counterparty.Address;
            txtComment.Text = _counterparty.Comment;
        }

        private bool ValidateForm()
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Название обязательно для заполнения");
                return false;
            }

            bool nameExists;

            if (isEditMode)
            {
                nameExists = _context.Counterparties.Any(c => c.Name == name && c.Id != _counterparty.Id);
            }
            else
            {
                nameExists = _context.Counterparties.Any(c => c.Name == name);
            }

            if (nameExists)
            {
                MessageBox.Show("Клнтрагент с таким названием уже существует.");
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                if (_isEditMode)
                {
                    _counterparty.Name = txtName.Text.Trim();
                    _counterparty.Phone = txtPhone.Text.Trim();
                    _counterparty.Email = txtEmail.Text.Trim();
                    _counterparty.Address = txtAddress.Text.Trim();
                    _counterparty.Comment = txtComment.Text.Trim();
                }
                else
                {
                    _counterparty = new Counterparty
                    {
                        Name = txtName.Text.Trim(),
                        Phone = txtPhone.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Address = txtAddress.Text.Trim(),
                        Comment = txtComment.Text.Trim()
                    };
                    _context.Counterparties.Add(_counterparty);
                }

                _context.SaveChanges();
                SavedCounterpartyId = _counterparty.Id;

                DataUpdated?.Invoke(this, EventArgs.Empty);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
                SavedCounterpartyId = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
