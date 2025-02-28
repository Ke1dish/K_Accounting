namespace K_Accounting.Forms
{
    partial class AddEditSubCategoryForm
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
            label3 = new Label();
            txtComment = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            cmbCategory = new ComboBox();
            btnNewCategory = new Button();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnOk);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 171);
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
            btnOk.Text = "Ок";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(txtComment, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(txtName, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(cmbCategory, 1, 1);
            tableLayoutPanel1.Controls.Add(btnNewCategory, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(384, 171);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 39);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 12;
            label3.Text = "Категория";
            // 
            // txtComment
            // 
            tableLayoutPanel1.SetColumnSpan(txtComment, 2);
            txtComment.Dock = DockStyle.Fill;
            txtComment.Location = new Point(145, 69);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(226, 97);
            txtComment.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 66);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 10;
            label2.Text = "Комментарий";
            // 
            // txtName
            // 
            tableLayoutPanel1.SetColumnSpan(txtName, 2);
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(145, 13);
            txtName.Name = "txtName";
            txtName.Size = new Size(226, 23);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 7;
            label1.Text = "Название";
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(145, 41);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(193, 23);
            cmbCategory.TabIndex = 1;
            // 
            // btnNewCategory
            // 
            btnNewCategory.Dock = DockStyle.Fill;
            btnNewCategory.Location = new Point(344, 41);
            btnNewCategory.Margin = new Padding(3, 2, 3, 2);
            btnNewCategory.Name = "btnNewCategory";
            btnNewCategory.Size = new Size(27, 23);
            btnNewCategory.TabIndex = 2;
            btnNewCategory.Text = "...";
            btnNewCategory.UseVisualStyleBackColor = true;
            btnNewCategory.Click += btnNewCategory_Click;
            // 
            // AddEditSubCategoryForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(384, 211);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddEditSubCategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEditSubCategoryForm";
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCancel;
        private Button btnOk;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private TextBox txtComment;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private ComboBox cmbCategory;
        private Button btnNewCategory;
    }
}