namespace K_Accounting.Forms
{
    partial class PaymentsForm
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
            btnClose = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvPayments = new DataGridView();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnAddPayment = new Button();
            btnEditPayment = new Button();
            btnDeletePayment = new Button();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnClose);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 258);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(384, 40);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(296, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.5555573F));
            tableLayoutPanel1.Controls.Add(dgvPayments, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(384, 258);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.AllowUserToResizeRows = false;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Dock = DockStyle.Fill;
            dgvPayments.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPayments.Location = new Point(13, 58);
            dgvPayments.Margin = new Padding(3, 2, 3, 2);
            dgvPayments.MultiSelect = false;
            dgvPayments.Name = "dgvPayments";
            dgvPayments.RowHeadersVisible = false;
            dgvPayments.RowHeadersWidth = 51;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(358, 195);
            dgvPayments.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnAddPayment);
            flowLayoutPanel2.Controls.Add(btnEditPayment);
            flowLayoutPanel2.Controls.Add(btnDeletePayment);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(13, 13);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(5);
            flowLayoutPanel2.Size = new Size(358, 40);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // btnAddPayment
            // 
            btnAddPayment.Image = Properties.Resources.PlusIcon;
            btnAddPayment.Location = new Point(8, 8);
            btnAddPayment.Name = "btnAddPayment";
            btnAddPayment.Size = new Size(104, 23);
            btnAddPayment.TabIndex = 3;
            btnAddPayment.Text = "Добавить";
            btnAddPayment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddPayment.UseVisualStyleBackColor = true;
            btnAddPayment.Click += btnAddPayment_Click;
            // 
            // btnEditPayment
            // 
            btnEditPayment.Image = Properties.Resources.EditIcon;
            btnEditPayment.Location = new Point(118, 8);
            btnEditPayment.Name = "btnEditPayment";
            btnEditPayment.Size = new Size(23, 23);
            btnEditPayment.TabIndex = 4;
            btnEditPayment.UseVisualStyleBackColor = true;
            btnEditPayment.Click += btnEditPayment_Click;
            // 
            // btnDeletePayment
            // 
            btnDeletePayment.Image = Properties.Resources.MinusIcon;
            btnDeletePayment.Location = new Point(147, 8);
            btnDeletePayment.Name = "btnDeletePayment";
            btnDeletePayment.Size = new Size(23, 23);
            btnDeletePayment.TabIndex = 5;
            btnDeletePayment.UseVisualStyleBackColor = true;
            btnDeletePayment.Click += btnDeletePayment_Click;
            // 
            // PaymentsForm
            // 
            AcceptButton = btnClose;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(384, 298);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "PaymentsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Платежи";
            Load += PaymentsForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnClose;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvPayments;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnAddPayment;
        private Button btnEditPayment;
        private Button btnDeletePayment;
    }
}