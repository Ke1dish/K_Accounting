namespace K_Accounting.Forms
{
    partial class AddEditDebtForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCancel = new Button();
            btnOk = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            cmbAccount = new ComboBox();
            btnNewAccount = new Button();
            label2 = new Label();
            numAmount = new NumericUpDown();
            label3 = new Label();
            dtpLoanDate = new DateTimePicker();
            label4 = new Label();
            dtpDueDate = new DateTimePicker();
            label5 = new Label();
            btnBrowseCounterparty = new Button();
            label6 = new Label();
            cmbStatus = new ComboBox();
            label7 = new Label();
            txtComment = new TextBox();
            cmbCounterparty = new ComboBox();
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
            flowLayoutPanel1.Location = new Point(0, 301);
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
            btnOk.Text = "Сохранить";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(cmbAccount, 1, 0);
            tableLayoutPanel1.Controls.Add(btnNewAccount, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(numAmount, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(dtpLoanDate, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(dtpDueDate, 1, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(btnBrowseCounterparty, 2, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(cmbStatus, 1, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(txtComment, 1, 6);
            tableLayoutPanel1.Controls.Add(cmbCounterparty, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(384, 301);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Счет:";
            // 
            // cmbAccount
            // 
            cmbAccount.Dock = DockStyle.Fill;
            cmbAccount.FormattingEnabled = true;
            cmbAccount.Location = new Point(123, 13);
            cmbAccount.Name = "cmbAccount";
            cmbAccount.Size = new Size(215, 23);
            cmbAccount.TabIndex = 0;
            // 
            // btnNewAccount
            // 
            btnNewAccount.Dock = DockStyle.Fill;
            btnNewAccount.Location = new Point(344, 13);
            btnNewAccount.Name = "btnNewAccount";
            btnNewAccount.Size = new Size(27, 23);
            btnNewAccount.TabIndex = 1;
            btnNewAccount.Text = "...";
            btnNewAccount.UseVisualStyleBackColor = true;
            btnNewAccount.Click += btnNewAccount_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 39);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Сумма:";
            // 
            // numAmount
            // 
            tableLayoutPanel1.SetColumnSpan(numAmount, 2);
            numAmount.DecimalPlaces = 2;
            numAmount.Dock = DockStyle.Fill;
            numAmount.Location = new Point(123, 42);
            numAmount.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(248, 23);
            numAmount.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 68);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 3;
            label3.Text = "Дата займа:";
            // 
            // dtpLoanDate
            // 
            tableLayoutPanel1.SetColumnSpan(dtpLoanDate, 2);
            dtpLoanDate.Dock = DockStyle.Fill;
            dtpLoanDate.Format = DateTimePickerFormat.Short;
            dtpLoanDate.Location = new Point(123, 71);
            dtpLoanDate.Name = "dtpLoanDate";
            dtpLoanDate.Size = new Size(248, 23);
            dtpLoanDate.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 97);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 4;
            label4.Text = "Дата возврата:";
            // 
            // dtpDueDate
            // 
            tableLayoutPanel1.SetColumnSpan(dtpDueDate, 2);
            dtpDueDate.Dock = DockStyle.Fill;
            dtpDueDate.Format = DateTimePickerFormat.Short;
            dtpDueDate.Location = new Point(123, 100);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(248, 23);
            dtpDueDate.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 126);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 5;
            label5.Text = "Контрагент:";
            // 
            // btnBrowseCounterparty
            // 
            btnBrowseCounterparty.Dock = DockStyle.Fill;
            btnBrowseCounterparty.Location = new Point(344, 129);
            btnBrowseCounterparty.Name = "btnBrowseCounterparty";
            btnBrowseCounterparty.Size = new Size(27, 23);
            btnBrowseCounterparty.TabIndex = 6;
            btnBrowseCounterparty.Text = "...";
            btnBrowseCounterparty.UseVisualStyleBackColor = true;
            btnBrowseCounterparty.Click += btnNewCounterparty_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 155);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 7;
            label6.Text = "Статус:";
            // 
            // cmbStatus
            // 
            tableLayoutPanel1.SetColumnSpan(cmbStatus, 2);
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Активен", "Погашен" });
            cmbStatus.Location = new Point(123, 158);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(248, 23);
            cmbStatus.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 184);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 8;
            label7.Text = "Комментарий:";
            // 
            // txtComment
            // 
            tableLayoutPanel1.SetColumnSpan(txtComment, 2);
            txtComment.Dock = DockStyle.Fill;
            txtComment.Location = new Point(123, 187);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.ScrollBars = ScrollBars.Vertical;
            txtComment.Size = new Size(248, 101);
            txtComment.TabIndex = 8;
            // 
            // cmbCounterparty
            // 
            cmbCounterparty.Dock = DockStyle.Fill;
            cmbCounterparty.FormattingEnabled = true;
            cmbCounterparty.Location = new Point(123, 129);
            cmbCounterparty.Name = "cmbCounterparty";
            cmbCounterparty.Size = new Size(215, 23);
            cmbCounterparty.TabIndex = 5;
            // 
            // AddEditDebtForm
            // 
            AcceptButton = btnOk;
            CancelButton = btnCancel;
            ClientSize = new Size(384, 341);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddEditDebtForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Долговая операция";
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
        private Label label1;
        private ComboBox cmbAccount;
        private Button btnNewAccount;
        private Label label2;
        private NumericUpDown numAmount;
        private Label label3;
        private DateTimePicker dtpLoanDate;
        private Label label4;
        private DateTimePicker dtpDueDate;
        private Label label5;
        private Button btnBrowseCounterparty;
        private Label label6;
        private ComboBox cmbStatus;
        private Label label7;
        private TextBox txtComment;
        private ComboBox cmbCounterparty;
    }
}