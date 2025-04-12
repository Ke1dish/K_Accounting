namespace K_Accounting.Forms
{
    partial class AddEditGoalsForm
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
            label8 = new Label();
            label1 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            numTargetAmount = new NumericUpDown();
            label3 = new Label();
            cmbCurrency = new ComboBox();
            btnNewCurrency = new Button();
            label4 = new Label();
            dtpTargetDate = new DateTimePicker();
            label5 = new Label();
            numCurrentAmount = new NumericUpDown();
            label6 = new Label();
            cmbStatus = new ComboBox();
            label7 = new Label();
            dtpReminderDate = new DateTimePicker();
            chkReminder = new CheckBox();
            txtComment = new TextBox();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTargetAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCurrentAmount).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnOk);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 316);
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
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Отмена";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(215, 8);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 1;
            btnOk.Text = "Ок";
            btnOk.Click += btnOk_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(numTargetAmount, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(cmbCurrency, 1, 2);
            tableLayoutPanel1.Controls.Add(btnNewCurrency, 2, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(dtpTargetDate, 1, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(numCurrentAmount, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(cmbStatus, 1, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(dtpReminderDate, 1, 6);
            tableLayoutPanel1.Controls.Add(chkReminder, 2, 6);
            tableLayoutPanel1.Controls.Add(txtComment, 1, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(384, 316);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.Location = new Point(13, 213);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 17;
            label8.Text = "Комментарий:";
            // 
            // label1
            // 
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Название:";
            // 
            // txtTitle
            // 
            tableLayoutPanel1.SetColumnSpan(txtTitle, 2);
            txtTitle.Dock = DockStyle.Fill;
            txtTitle.Location = new Point(135, 13);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(236, 23);
            txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(13, 39);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 2;
            label2.Text = "Целевая сумма:";
            // 
            // numTargetAmount
            // 
            tableLayoutPanel1.SetColumnSpan(numTargetAmount, 2);
            numTargetAmount.DecimalPlaces = 2;
            numTargetAmount.Dock = DockStyle.Fill;
            numTargetAmount.Location = new Point(135, 42);
            numTargetAmount.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            numTargetAmount.Name = "numTargetAmount";
            numTargetAmount.Size = new Size(236, 23);
            numTargetAmount.TabIndex = 3;
            // 
            // label3
            // 
            label3.Location = new Point(13, 68);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            label3.Text = "Валюта:";
            // 
            // cmbCurrency
            // 
            cmbCurrency.Dock = DockStyle.Fill;
            cmbCurrency.Location = new Point(135, 71);
            cmbCurrency.Name = "cmbCurrency";
            cmbCurrency.Size = new Size(203, 23);
            cmbCurrency.TabIndex = 5;
            // 
            // btnNewCurrency
            // 
            btnNewCurrency.Location = new Point(344, 71);
            btnNewCurrency.Name = "btnNewCurrency";
            btnNewCurrency.Size = new Size(27, 23);
            btnNewCurrency.TabIndex = 6;
            btnNewCurrency.Text = "...";
            btnNewCurrency.Click += btnNewCurrency_Click;
            // 
            // label4
            // 
            label4.Location = new Point(13, 97);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 7;
            label4.Text = "Срок выполнения:";
            // 
            // dtpTargetDate
            // 
            tableLayoutPanel1.SetColumnSpan(dtpTargetDate, 2);
            dtpTargetDate.Dock = DockStyle.Fill;
            dtpTargetDate.Format = DateTimePickerFormat.Short;
            dtpTargetDate.Location = new Point(135, 100);
            dtpTargetDate.Name = "dtpTargetDate";
            dtpTargetDate.Size = new Size(236, 23);
            dtpTargetDate.TabIndex = 8;
            // 
            // label5
            // 
            label5.Location = new Point(13, 126);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 9;
            label5.Text = "Текущая сумма:";
            // 
            // numCurrentAmount
            // 
            tableLayoutPanel1.SetColumnSpan(numCurrentAmount, 2);
            numCurrentAmount.DecimalPlaces = 2;
            numCurrentAmount.Dock = DockStyle.Fill;
            numCurrentAmount.Location = new Point(135, 129);
            numCurrentAmount.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            numCurrentAmount.Name = "numCurrentAmount";
            numCurrentAmount.ReadOnly = true;
            numCurrentAmount.Size = new Size(236, 23);
            numCurrentAmount.TabIndex = 10;
            // 
            // label6
            // 
            label6.Location = new Point(13, 155);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 11;
            label6.Text = "Статус:";
            // 
            // cmbStatus
            // 
            tableLayoutPanel1.SetColumnSpan(cmbStatus, 2);
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.Items.AddRange(new object[] { "Активна", "Заморожена", "Выполнена" });
            cmbStatus.Location = new Point(135, 158);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(236, 23);
            cmbStatus.TabIndex = 12;
            // 
            // label7
            // 
            label7.Location = new Point(13, 184);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 13;
            label7.Text = "Напоминание:";
            // 
            // dtpReminderDate
            // 
            dtpReminderDate.Enabled = false;
            dtpReminderDate.Format = DateTimePickerFormat.Short;
            dtpReminderDate.Location = new Point(135, 187);
            dtpReminderDate.Name = "dtpReminderDate";
            dtpReminderDate.Size = new Size(200, 23);
            dtpReminderDate.TabIndex = 14;
            // 
            // chkReminder
            // 
            chkReminder.AutoSize = true;
            chkReminder.CheckAlign = ContentAlignment.MiddleCenter;
            chkReminder.Dock = DockStyle.Fill;
            chkReminder.Location = new Point(344, 187);
            chkReminder.Name = "chkReminder";
            chkReminder.Size = new Size(27, 23);
            chkReminder.TabIndex = 15;
            chkReminder.Click += chkReminder_CheckedChanged;
            // 
            // txtComment
            // 
            tableLayoutPanel1.SetColumnSpan(txtComment, 2);
            txtComment.Dock = DockStyle.Fill;
            txtComment.Location = new Point(135, 216);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.ScrollBars = ScrollBars.Vertical;
            txtComment.Size = new Size(236, 87);
            txtComment.TabIndex = 16;
            // 
            // AddEditGoalsForm
            // 
            AcceptButton = btnOk;
            CancelButton = btnCancel;
            ClientSize = new Size(384, 356);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddEditGoalsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Цель";
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTargetAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCurrentAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCancel;
        private Button btnOk;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox txtTitle;
        private Label label2;
        private NumericUpDown numTargetAmount;
        private Label label3;
        private ComboBox cmbCurrency;
        private Button btnNewCurrency;
        private Label label4;
        private DateTimePicker dtpTargetDate;
        private Label label5;
        private NumericUpDown numCurrentAmount;
        private Label label6;
        private ComboBox cmbStatus;
        private Label label7;
        private DateTimePicker dtpReminderDate;
        private CheckBox chkReminder;
        private TextBox txtComment;
        private Label label8;
    }
}