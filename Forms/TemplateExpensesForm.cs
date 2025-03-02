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
using Microsoft.EntityFrameworkCore;

namespace K_Accounting.Forms
{
    public partial class TemplateExpensesForm : Form
    {
        private readonly AppDbContext _context;
        public Expense SelectedTemplate { get; private set; }

        public TemplateExpensesForm(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
            txtFilter.TextChanged += TxtFilter_TextChanged;
        }

        private void TemplateExpensesForm_Load(object sender, EventArgs e)
        {
            LoadTemplates();
            ConfigureGrid();
        }

        private void ConfigureGrid()
        {
            dgvTemplates.AutoGenerateColumns = false;
            dgvTemplates.Columns.Clear();

            dgvTemplates.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DisplayName",
                HeaderText = "Шаблон",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void LoadTemplates(string filter = "")
        {
            var query = _context.Expenses
                .Include(e => e.Category)
                .Include(e => e.SubCategory)
                .Where(e => e.IsTemplate && !e.IsDeleted);

            // Всегда материализуем данные перед фильтрацией
            var templates = query
                .AsEnumerable()
                .Select(e => new TemplateDisplayItem
                {
                    Expense = e,
                    DisplayName = $"{e.Category?.Name ?? ""} - {e.SubCategory?.Name ?? ""}"
                                .Trim('-', ' ') // Убираем лишние дефисы, если что-то удалено
                })
                .ToList();

            // Применяем фильтр к объединенной строке
            if (!string.IsNullOrWhiteSpace(filter))
            {
                filter = filter.Trim().ToLower();
                templates = templates
                    .Where(t => t.DisplayName.ToLower().Contains(filter))
                    .ToList();
            }

            dgvTemplates.DataSource = templates
                .OrderBy(t => t.DisplayName)
                .ToList();
        }

        private class TemplateDisplayItem
        {
            public Expense Expense { get; set; }
            public string DisplayName { get; set; }
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            LoadTemplates(txtFilter.Text);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvTemplates.CurrentRow == null) return;

            var selected = ((TemplateDisplayItem)dgvTemplates.CurrentRow.DataBoundItem).Expense;
            SelectedTemplate = selected;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}