namespace K_Accounting.Forms
{
    partial class TransferFundsForm
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
            label5 = new Label();
            lblConversionRate = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtComment = new TextBox();
            label2 = new Label();
            numAmount = new NumericUpDown();
            label1 = new Label();
            btnNewAccount = new Button();
            cmbToAccount = new ComboBox();
            label3 = new Label();
            cmbFromAccount = new ComboBox();
            label4 = new Label();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnOk);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(lblConversionRate);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(193, 5);
            label5.Name = "label5";
            label5.Size = new Size(16, 15);
            label5.TabIndex = 15;
            label5.Text = "   ";
            // 
            // lblConversionRate
            // 
            lblConversionRate.Dock = DockStyle.Fill;
            lblConversionRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblConversionRate.ForeColor = Color.Maroon;
            lblConversionRate.Location = new Point(143, 5);
            lblConversionRate.Name = "lblConversionRate";
            lblConversionRate.Size = new Size(44, 29);
            lblConversionRate.TabIndex = 14;
            lblConversionRate.Text = "label5";
            lblConversionRate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.Controls.Add(txtComment, 1, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(numAmount, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(btnNewAccount, 2, 1);
            tableLayoutPanel1.Controls.Add(cmbToAccount, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(cmbFromAccount, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(384, 171);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtComment
            // 
            tableLayoutPanel1.SetColumnSpan(txtComment, 2);
            txtComment.Dock = DockStyle.Fill;
            txtComment.Location = new Point(145, 100);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(226, 65);
            txtComment.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 97);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 23;
            label2.Text = "Комментарий";
            // 
            // numAmount
            // 
            tableLayoutPanel1.SetColumnSpan(numAmount, 2);
            numAmount.DecimalPlaces = 2;
            numAmount.Dock = DockStyle.Fill;
            numAmount.Location = new Point(145, 71);
            numAmount.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numAmount.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(226, 23);
            numAmount.TabIndex = 3;
            numAmount.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            numAmount.KeyPress += numAmount_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 68);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 21;
            label1.Text = "Сумма";
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
            // cmbToAccount
            // 
            cmbToAccount.Dock = DockStyle.Fill;
            cmbToAccount.FormattingEnabled = true;
            cmbToAccount.Location = new Point(145, 42);
            cmbToAccount.Name = "cmbToAccount";
            cmbToAccount.Size = new Size(193, 23);
            cmbToAccount.TabIndex = 1;
            cmbToAccount.SelectedIndexChanged += cmb_SelectedIndexChanged;
            cmbToAccount.TextUpdate += cmbToAccount_TextUpdate;
            cmbToAccount.Format += cmbFormat;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 39);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 18;
            label3.Text = "на счет";
            // 
            // cmbFromAccount
            // 
            tableLayoutPanel1.SetColumnSpan(cmbFromAccount, 2);
            cmbFromAccount.Dock = DockStyle.Fill;
            cmbFromAccount.FormattingEnabled = true;
            cmbFromAccount.Location = new Point(145, 13);
            cmbFromAccount.Name = "cmbFromAccount";
            cmbFromAccount.Size = new Size(226, 23);
            cmbFromAccount.TabIndex = 0;
            cmbFromAccount.SelectedIndexChanged += cmb_SelectedIndexChanged;
            cmbFromAccount.TextUpdate += cmbFromAccount_TextUpdate;
            cmbFromAccount.Format += cmbFormat;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 10);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 13;
            label4.Text = "со счета";
            // 
            // TransferFundsForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(384, 211);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TransferFundsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TransferFundsForm";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
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
        private NumericUpDown numAmount;
        private Label label1;
        private Button btnNewAccount;
        private ComboBox cmbToAccount;
        private Label label3;
        private ComboBox cmbFromAccount;
        private Label label4;
        private Label lblConversionRate;
        private Label label5;
    }
}