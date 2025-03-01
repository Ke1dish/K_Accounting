namespace K_Accounting.Forms
{
    partial class AddEditIncomeForm
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
            txtComment = new TextBox();
            label2 = new Label();
            btnNewSource = new Button();
            cmbSource = new ComboBox();
            label8 = new Label();
            btnNewAccount = new Button();
            cmbAccount = new ComboBox();
            label7 = new Label();
            numAmount = new NumericUpDown();
            label6 = new Label();
            dtpDate = new DateTimePicker();
            label5 = new Label();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnOk);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 241);
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
            btnOk.Click += btnSave_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.Controls.Add(txtComment, 1, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 4);
            tableLayoutPanel1.Controls.Add(btnNewSource, 2, 3);
            tableLayoutPanel1.Controls.Add(cmbSource, 1, 3);
            tableLayoutPanel1.Controls.Add(label8, 0, 3);
            tableLayoutPanel1.Controls.Add(btnNewAccount, 2, 2);
            tableLayoutPanel1.Controls.Add(cmbAccount, 1, 2);
            tableLayoutPanel1.Controls.Add(label7, 0, 2);
            tableLayoutPanel1.Controls.Add(numAmount, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(dtpDate, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(384, 241);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtComment
            // 
            tableLayoutPanel1.SetColumnSpan(txtComment, 2);
            txtComment.Dock = DockStyle.Fill;
            txtComment.Location = new Point(145, 129);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(226, 99);
            txtComment.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 126);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 57;
            label2.Text = "Комментарий";
            // 
            // btnNewSource
            // 
            btnNewSource.Dock = DockStyle.Fill;
            btnNewSource.Location = new Point(344, 100);
            btnNewSource.Name = "btnNewSource";
            btnNewSource.Size = new Size(27, 23);
            btnNewSource.TabIndex = 5;
            btnNewSource.Text = "...";
            btnNewSource.UseVisualStyleBackColor = true;
            btnNewSource.Click += btnNewSource_Click;
            // 
            // cmbSource
            // 
            cmbSource.Dock = DockStyle.Fill;
            cmbSource.FormattingEnabled = true;
            cmbSource.Location = new Point(145, 100);
            cmbSource.Name = "cmbSource";
            cmbSource.Size = new Size(193, 23);
            cmbSource.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 97);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 48;
            label8.Text = "Источник";
            // 
            // btnNewAccount
            // 
            btnNewAccount.Dock = DockStyle.Fill;
            btnNewAccount.Location = new Point(344, 71);
            btnNewAccount.Name = "btnNewAccount";
            btnNewAccount.Size = new Size(27, 23);
            btnNewAccount.TabIndex = 3;
            btnNewAccount.Text = "...";
            btnNewAccount.UseVisualStyleBackColor = true;
            btnNewAccount.Click += btnNewAccount_Click;
            // 
            // cmbAccount
            // 
            cmbAccount.Dock = DockStyle.Fill;
            cmbAccount.FormattingEnabled = true;
            cmbAccount.Location = new Point(145, 71);
            cmbAccount.Name = "cmbAccount";
            cmbAccount.Size = new Size(193, 23);
            cmbAccount.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 68);
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
            numAmount.Location = new Point(145, 42);
            numAmount.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            numAmount.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(226, 23);
            numAmount.TabIndex = 1;
            numAmount.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 39);
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
            // AddEditIncomeForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(384, 281);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddEditIncomeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddEditIncomeForm";
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCancel;
        private Button btnOk;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtComment;
        private Label label2;
        private Button btnNewSource;
        private ComboBox cmbSource;
        private Label label8;
        private Button btnNewAccount;
        private ComboBox cmbAccount;
        private Label label7;
        private NumericUpDown numAmount;
        private Label label6;
        private DateTimePicker dtpDate;
        private Label label5;
    }
}