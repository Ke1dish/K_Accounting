namespace K_Accounting.Forms
{
    partial class AddEditExpenseForm
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
            btnAdd = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnNewMeasurement = new Button();
            chkIsTemplate = new CheckBox();
            txtComment = new TextBox();
            label2 = new Label();
            btnNewAdditional = new Button();
            cmbAdditional = new ComboBox();
            label100 = new Label();
            cmbSubCategory = new ComboBox();
            label9 = new Label();
            btnNewCategory = new Button();
            cmbCategory = new ComboBox();
            label8 = new Label();
            btnNewAccount = new Button();
            cmbAccount = new ComboBox();
            label7 = new Label();
            numAmount = new NumericUpDown();
            label6 = new Label();
            dtpDate = new DateTimePicker();
            label5 = new Label();
            btnNewSubcategory = new Button();
            numQuantity = new NumericUpDown();
            lblQuantity = new Label();
            cmbMeasurement = new ComboBox();
            lblMeasurement = new Label();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnOk);
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 355);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(384, 40);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(296, 8);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(215, 8);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 1;
            btnOk.Text = "Ок";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(134, 8);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.Controls.Add(btnNewMeasurement, 2, 6);
            tableLayoutPanel1.Controls.Add(chkIsTemplate, 1, 8);
            tableLayoutPanel1.Controls.Add(txtComment, 1, 9);
            tableLayoutPanel1.Controls.Add(label2, 0, 9);
            tableLayoutPanel1.Controls.Add(btnNewAdditional, 2, 7);
            tableLayoutPanel1.Controls.Add(cmbAdditional, 1, 7);
            tableLayoutPanel1.Controls.Add(label100, 0, 7);
            tableLayoutPanel1.Controls.Add(cmbSubCategory, 1, 3);
            tableLayoutPanel1.Controls.Add(label9, 0, 3);
            tableLayoutPanel1.Controls.Add(btnNewCategory, 2, 2);
            tableLayoutPanel1.Controls.Add(cmbCategory, 1, 2);
            tableLayoutPanel1.Controls.Add(label8, 0, 2);
            tableLayoutPanel1.Controls.Add(btnNewAccount, 2, 1);
            tableLayoutPanel1.Controls.Add(cmbAccount, 1, 1);
            tableLayoutPanel1.Controls.Add(label7, 0, 1);
            tableLayoutPanel1.Controls.Add(numAmount, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(dtpDate, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Controls.Add(btnNewSubcategory, 2, 3);
            tableLayoutPanel1.Controls.Add(numQuantity, 1, 5);
            tableLayoutPanel1.Controls.Add(lblQuantity, 0, 5);
            tableLayoutPanel1.Controls.Add(cmbMeasurement, 1, 6);
            tableLayoutPanel1.Controls.Add(lblMeasurement, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(384, 355);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNewMeasurement
            // 
            btnNewMeasurement.Dock = DockStyle.Fill;
            btnNewMeasurement.Location = new Point(344, 187);
            btnNewMeasurement.Name = "btnNewMeasurement";
            btnNewMeasurement.Size = new Size(27, 23);
            btnNewMeasurement.TabIndex = 10;
            btnNewMeasurement.Text = "...";
            btnNewMeasurement.UseVisualStyleBackColor = true;
            btnNewMeasurement.Click += btnNewMeasurement_Click;
            // 
            // chkIsTemplate
            // 
            chkIsTemplate.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(chkIsTemplate, 2);
            chkIsTemplate.Location = new Point(145, 245);
            chkIsTemplate.Name = "chkIsTemplate";
            chkIsTemplate.Size = new Size(170, 19);
            chkIsTemplate.TabIndex = 13;
            chkIsTemplate.Text = "использовать как шаблон";
            chkIsTemplate.UseVisualStyleBackColor = true;
            // 
            // txtComment
            // 
            tableLayoutPanel1.SetColumnSpan(txtComment, 2);
            txtComment.Dock = DockStyle.Fill;
            txtComment.Location = new Point(145, 270);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(226, 72);
            txtComment.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 267);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 57;
            label2.Text = "Комментарий";
            // 
            // btnNewAdditional
            // 
            btnNewAdditional.Dock = DockStyle.Fill;
            btnNewAdditional.Location = new Point(344, 216);
            btnNewAdditional.Name = "btnNewAdditional";
            btnNewAdditional.Size = new Size(27, 23);
            btnNewAdditional.TabIndex = 12;
            btnNewAdditional.Text = "...";
            btnNewAdditional.UseVisualStyleBackColor = true;
            btnNewAdditional.Click += btnNewAdditional_Click;
            // 
            // cmbAdditional
            // 
            cmbAdditional.Dock = DockStyle.Fill;
            cmbAdditional.FormattingEnabled = true;
            cmbAdditional.Location = new Point(145, 216);
            cmbAdditional.Name = "cmbAdditional";
            cmbAdditional.Size = new Size(193, 23);
            cmbAdditional.TabIndex = 11;
            // 
            // label100
            // 
            label100.AutoSize = true;
            label100.Location = new Point(13, 213);
            label100.Name = "label100";
            label100.Size = new Size(77, 15);
            label100.TabIndex = 54;
            label100.Text = "Упоминание";
            // 
            // cmbSubCategory
            // 
            cmbSubCategory.Dock = DockStyle.Fill;
            cmbSubCategory.FormattingEnabled = true;
            cmbSubCategory.Location = new Point(145, 100);
            cmbSubCategory.Name = "cmbSubCategory";
            cmbSubCategory.Size = new Size(193, 23);
            cmbSubCategory.TabIndex = 5;
            cmbSubCategory.SelectedIndexChanged += cmbSubCategory_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 97);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 51;
            label9.Text = "Подкатегория";
            // 
            // btnNewCategory
            // 
            btnNewCategory.Dock = DockStyle.Fill;
            btnNewCategory.Location = new Point(344, 71);
            btnNewCategory.Name = "btnNewCategory";
            btnNewCategory.Size = new Size(27, 23);
            btnNewCategory.TabIndex = 4;
            btnNewCategory.Text = "...";
            btnNewCategory.UseVisualStyleBackColor = true;
            btnNewCategory.Click += btnNewCategory_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(145, 71);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(193, 23);
            cmbCategory.TabIndex = 3;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 68);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 48;
            label8.Text = "Категория";
            // 
            // btnNewAccount
            // 
            btnNewAccount.Dock = DockStyle.Fill;
            btnNewAccount.Location = new Point(344, 42);
            btnNewAccount.Name = "btnNewAccount";
            btnNewAccount.Size = new Size(27, 23);
            btnNewAccount.TabIndex = 2;
            btnNewAccount.Text = "...";
            btnNewAccount.UseVisualStyleBackColor = true;
            btnNewAccount.Click += btnNewAccount_Click;
            // 
            // cmbAccount
            // 
            cmbAccount.Dock = DockStyle.Fill;
            cmbAccount.FormattingEnabled = true;
            cmbAccount.Location = new Point(145, 42);
            cmbAccount.Name = "cmbAccount";
            cmbAccount.Size = new Size(193, 23);
            cmbAccount.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 39);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 45;
            label7.Text = "Счет";
            // 
            // numAmount
            // 
            tableLayoutPanel1.SetColumnSpan(numAmount, 2);
            numAmount.DecimalPlaces = 2;
            numAmount.Dock = DockStyle.Fill;
            numAmount.Location = new Point(145, 129);
            numAmount.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            numAmount.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(226, 23);
            numAmount.TabIndex = 7;
            numAmount.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 126);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 33;
            label6.Text = "Сумма";
            // 
            // dtpDate
            // 
            tableLayoutPanel1.SetColumnSpan(dtpDate, 2);
            dtpDate.Dock = DockStyle.Fill;
            dtpDate.Location = new Point(145, 13);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(226, 23);
            dtpDate.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 10);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 31;
            label5.Text = "Дата";
            // 
            // btnNewSubcategory
            // 
            btnNewSubcategory.Dock = DockStyle.Fill;
            btnNewSubcategory.Location = new Point(344, 100);
            btnNewSubcategory.Name = "btnNewSubcategory";
            btnNewSubcategory.Size = new Size(27, 23);
            btnNewSubcategory.TabIndex = 6;
            btnNewSubcategory.Text = "...";
            btnNewSubcategory.UseVisualStyleBackColor = true;
            btnNewSubcategory.Click += btnNewSubcategory_Click;
            // 
            // numQuantity
            // 
            tableLayoutPanel1.SetColumnSpan(numQuantity, 2);
            numQuantity.Dock = DockStyle.Fill;
            numQuantity.Location = new Point(145, 158);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(226, 23);
            numQuantity.TabIndex = 8;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(13, 155);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 15);
            lblQuantity.TabIndex = 59;
            lblQuantity.Text = "Количество";
            // 
            // cmbMeasurement
            // 
            cmbMeasurement.Dock = DockStyle.Fill;
            cmbMeasurement.FormattingEnabled = true;
            cmbMeasurement.Location = new Point(145, 187);
            cmbMeasurement.Name = "cmbMeasurement";
            cmbMeasurement.Size = new Size(193, 23);
            cmbMeasurement.TabIndex = 9;
            // 
            // lblMeasurement
            // 
            lblMeasurement.AutoSize = true;
            lblMeasurement.Location = new Point(13, 184);
            lblMeasurement.Name = "lblMeasurement";
            lblMeasurement.Size = new Size(116, 15);
            lblMeasurement.TabIndex = 61;
            lblMeasurement.Text = "Единица измерения";
            // 
            // AddEditExpenseForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(384, 395);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Name = "AddEditExpenseForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddEditExpenseForm";
            KeyDown += AddEditExpenseForm_KeyDown;
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCancel;
        private Button btnOk;
        private Button btnAdd;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtComment;
        private Label label2;
        private Button btnNewAdditional;
        private ComboBox cmbAdditional;
        private Label label100;
        private Button btnNewSubcategory;
        private ComboBox cmbSubCategory;
        private Label label9;
        private Button btnNewCategory;
        private ComboBox cmbCategory;
        private Label label8;
        private Button btnNewAccount;
        private ComboBox cmbAccount;
        private Label label7;
        private NumericUpDown numAmount;
        private Label label6;
        private DateTimePicker dtpDate;
        private Label label5;
        private CheckBox chkIsTemplate;
        private NumericUpDown numQuantity;
        private Label lblQuantity;
        private Button btnNewMeasurement;
        private ComboBox cmbMeasurement;
        private Label lblMeasurement;
    }
}