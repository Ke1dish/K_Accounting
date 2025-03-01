namespace K_Accounting.Forms
{
    partial class TemplateExpensesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCancel = new Button();
            btnOk = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvTemplates = new DataGridView();
            label1 = new Label();
            txtFilter = new TextBox();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTemplates).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnOk);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 268);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(384, 40);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(296, 8);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(215, 8);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "Выбрать";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnSelect_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.5555573F));
            tableLayoutPanel1.Controls.Add(dgvTemplates, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtFilter, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(384, 268);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvTemplates
            // 
            dgvTemplates.AllowUserToAddRows = false;
            dgvTemplates.AllowUserToDeleteRows = false;
            dgvTemplates.AllowUserToResizeRows = false;
            dgvTemplates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dgvTemplates, 2);
            dgvTemplates.Dock = DockStyle.Fill;
            dgvTemplates.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvTemplates.Location = new Point(13, 41);
            dgvTemplates.Margin = new Padding(3, 2, 3, 2);
            dgvTemplates.MultiSelect = false;
            dgvTemplates.Name = "dgvTemplates";
            dgvTemplates.RowHeadersVisible = false;
            dgvTemplates.RowHeadersWidth = 51;
            dgvTemplates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTemplates.Size = new Size(358, 215);
            dgvTemplates.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Поиск";
            // 
            // txtFilter
            // 
            txtFilter.Dock = DockStyle.Fill;
            txtFilter.Location = new Point(174, 13);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(197, 23);
            txtFilter.TabIndex = 0;
            txtFilter.TextChanged += TxtFilter_TextChanged;
            // 
            // TemplateExpensesForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(384, 308);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "TemplateExpensesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Выбор из шаблонов";
            Load += TemplateExpensesForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTemplates).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCancel;
        private Button btnOk;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvTemplates;
        private Label label1;
        private TextBox txtFilter;
    }
}