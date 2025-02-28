using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using K_Accounting.Data;
using K_Accounting.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Data.Entity;
using System.Xml.Linq;

namespace K_Accounting.Forms
{
    public partial class AddEditCurrencyForm : Form
    {
        private readonly AppDbContext _context;

        private Currency _currency;

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
            _context = context;
            txtName.Focus();
        }

        public AddEditCurrencyForm()
        {
            InitializeComponent();
            txtName.Focus();
        }

        public AddEditCurrencyForm(Currency currency) : this()
        {
            _currency = currency;
            LoadCurrencyData();
        }

        private void LoadCurrencyData()
        {
            txtName.Text = _currency.Name;
            txtCode.Text = _currency.Code;
            txtSymbol.Text = _currency.Symbol;
            numRate.Value = _currency.Rate;
            txtComment.Text = _currency.Comment;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Название валюты обязательно для заполнения");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show("Код валюты обязателен для заполнения");
                return false;
            }

            if (numRate.Value <= 0)
            {
                MessageBox.Show("Курс должен быть больше нуля");
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
                        var existing = context.Currencies.Find(_currency.Id);
                        if (existing != null)
                        {
                            existing.Name = txtName.Text.Trim();
                            existing.Code = txtName.Text.Trim().ToUpper();
                            existing.Symbol = txtSymbol.Text.Trim();
                            existing.Rate = numRate.Value;
                            existing.Comment = txtComment.Text.Trim();
                        }
                    }
                    else
                    {
                        var newCurrency = new Currency(
                            txtName.Text.Trim(),
                            txtCode.Text.Trim().ToUpper(),
                            numRate.Value)
                        {
                            Symbol = txtSymbol.Text.Trim(),
                            Comment = txtComment.Text.Trim()
                        };
                        context.Currencies.Add(newCurrency);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
