namespace K_Accounting.Forms
{
    partial class GoalTransferForm
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
            btnTransfer = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            cmbSourceGoal = new ComboBox();
            label3 = new Label();
            cmbTarget = new ComboBox();
            label5 = new Label();
            numAmount = new NumericUpDown();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnTransfer);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 102);
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
            // btnTransfer
            // 
            btnTransfer.Location = new Point(215, 8);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(75, 23);
            btnTransfer.TabIndex = 1;
            btnTransfer.Text = "Перевести";
            btnTransfer.Click += btnTransfer_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(cmbSourceGoal, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(cmbTarget, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(numAmount, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(384, 102);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Из цели:";
            // 
            // cmbSourceGoal
            // 
            cmbSourceGoal.Dock = DockStyle.Fill;
            cmbSourceGoal.Location = new Point(140, 13);
            cmbSourceGoal.Name = "cmbSourceGoal";
            cmbSourceGoal.Size = new Size(231, 23);
            cmbSourceGoal.TabIndex = 1;
            // 
            // label3
            // 
            label3.Location = new Point(13, 39);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            label3.Text = "Куда:";
            // 
            // cmbTarget
            // 
            cmbTarget.Dock = DockStyle.Fill;
            cmbTarget.Location = new Point(140, 42);
            cmbTarget.Name = "cmbTarget";
            cmbTarget.Size = new Size(231, 23);
            cmbTarget.TabIndex = 5;
            // 
            // label5
            // 
            label5.Location = new Point(13, 68);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 8;
            label5.Text = "Сумма перевода:";
            // 
            // numAmount
            // 
            numAmount.DecimalPlaces = 2;
            numAmount.Dock = DockStyle.Fill;
            numAmount.Location = new Point(140, 71);
            numAmount.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(231, 23);
            numAmount.TabIndex = 9;
            numAmount.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // GoalTransferForm
            // 
            AcceptButton = btnTransfer;
            CancelButton = btnCancel;
            ClientSize = new Size(384, 142);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "GoalTransferForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Перевод между целями";
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCancel;
        private Button btnTransfer;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ComboBox cmbSourceGoal;
        private Label label3;
        private ComboBox cmbTarget;
        private Label label5;
        private NumericUpDown numAmount;
    }
}