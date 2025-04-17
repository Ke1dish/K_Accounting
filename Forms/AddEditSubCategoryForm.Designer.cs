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
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCancel = new Button();
            btnOk = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnNewMeasurement = new Button();
            cmbMeasurement = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtComment = new TextBox();
            lblMeasurement = new Label();
            txtName = new TextBox();
            label1 = new Label();
            cmbCategory = new ComboBox();
            btnNewCategory = new Button();
            txtQuantityRequirementInherited = new Label();
            cbDemandQuantity = new CheckBox();
            pbDemandQuantityInfo = new PictureBox();
            pbQuantityRequirementInheritedInfo = new PictureBox();
            toolTip1 = new ToolTip(components);
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDemandQuantityInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuantityRequirementInheritedInfo).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnOk);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 221);
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
            tableLayoutPanel1.Controls.Add(btnNewMeasurement, 2, 4);
            tableLayoutPanel1.Controls.Add(cmbMeasurement, 1, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 5);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(txtComment, 1, 5);
            tableLayoutPanel1.Controls.Add(lblMeasurement, 0, 4);
            tableLayoutPanel1.Controls.Add(txtName, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(cmbCategory, 1, 1);
            tableLayoutPanel1.Controls.Add(btnNewCategory, 2, 1);
            tableLayoutPanel1.Controls.Add(txtQuantityRequirementInherited, 1, 3);
            tableLayoutPanel1.Controls.Add(cbDemandQuantity, 1, 2);
            tableLayoutPanel1.Controls.Add(pbDemandQuantityInfo, 2, 2);
            tableLayoutPanel1.Controls.Add(pbQuantityRequirementInheritedInfo, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(384, 221);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNewMeasurement
            // 
            btnNewMeasurement.Dock = DockStyle.Fill;
            btnNewMeasurement.Location = new Point(344, 127);
            btnNewMeasurement.Margin = new Padding(3, 2, 3, 2);
            btnNewMeasurement.Name = "btnNewMeasurement";
            btnNewMeasurement.Size = new Size(27, 23);
            btnNewMeasurement.TabIndex = 19;
            btnNewMeasurement.Text = "...";
            btnNewMeasurement.UseVisualStyleBackColor = true;
            btnNewMeasurement.Click += btnNewMeasurement_Click;
            // 
            // cmbMeasurement
            // 
            cmbMeasurement.Dock = DockStyle.Fill;
            cmbMeasurement.FormattingEnabled = true;
            cmbMeasurement.Location = new Point(145, 127);
            cmbMeasurement.Margin = new Padding(3, 2, 3, 2);
            cmbMeasurement.Name = "cmbMeasurement";
            cmbMeasurement.Size = new Size(193, 23);
            cmbMeasurement.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 152);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 17;
            label4.Text = "Комментарий";
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
            txtComment.Location = new Point(145, 155);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(226, 53);
            txtComment.TabIndex = 3;
            // 
            // lblMeasurement
            // 
            lblMeasurement.AutoSize = true;
            lblMeasurement.Location = new Point(13, 125);
            lblMeasurement.Name = "lblMeasurement";
            lblMeasurement.Size = new Size(119, 15);
            lblMeasurement.TabIndex = 10;
            lblMeasurement.Text = "Единицы измерения";
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
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
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
            // txtQuantityRequirementInherited
            // 
            txtQuantityRequirementInherited.AutoSize = true;
            txtQuantityRequirementInherited.Dock = DockStyle.Fill;
            txtQuantityRequirementInherited.Location = new Point(145, 95);
            txtQuantityRequirementInherited.Name = "txtQuantityRequirementInherited";
            txtQuantityRequirementInherited.Size = new Size(193, 30);
            txtQuantityRequirementInherited.TabIndex = 13;
            txtQuantityRequirementInherited.Text = "Требование количества унаследованно от категории";
            // 
            // cbDemandQuantity
            // 
            cbDemandQuantity.AutoSize = true;
            cbDemandQuantity.Dock = DockStyle.Fill;
            cbDemandQuantity.Location = new Point(145, 69);
            cbDemandQuantity.Name = "cbDemandQuantity";
            cbDemandQuantity.Size = new Size(193, 23);
            cbDemandQuantity.TabIndex = 14;
            cbDemandQuantity.Text = "Требовать количество";
            cbDemandQuantity.UseVisualStyleBackColor = true;
            cbDemandQuantity.CheckedChanged += cbDemandQuantity_CheckedChanged;
            // 
            // pbDemandQuantityInfo
            // 
            pbDemandQuantityInfo.Image = Properties.Resources.icons8_info_16;
            pbDemandQuantityInfo.Location = new Point(344, 69);
            pbDemandQuantityInfo.Name = "pbDemandQuantityInfo";
            pbDemandQuantityInfo.Size = new Size(27, 23);
            pbDemandQuantityInfo.SizeMode = PictureBoxSizeMode.CenterImage;
            pbDemandQuantityInfo.TabIndex = 15;
            pbDemandQuantityInfo.TabStop = false;
            // 
            // pbQuantityRequirementInheritedInfo
            // 
            pbQuantityRequirementInheritedInfo.Image = Properties.Resources.icons8_info_16;
            pbQuantityRequirementInheritedInfo.Location = new Point(344, 98);
            pbQuantityRequirementInheritedInfo.Name = "pbQuantityRequirementInheritedInfo";
            pbQuantityRequirementInheritedInfo.Size = new Size(27, 23);
            pbQuantityRequirementInheritedInfo.SizeMode = PictureBoxSizeMode.CenterImage;
            pbQuantityRequirementInheritedInfo.TabIndex = 16;
            pbQuantityRequirementInheritedInfo.TabStop = false;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Информация";
            // 
            // AddEditSubCategoryForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(384, 261);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddEditSubCategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEditSubCategoryForm";
            Load += AddEditSubCategoryForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDemandQuantityInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQuantityRequirementInheritedInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCancel;
        private Button btnOk;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private TextBox txtComment;
        private Label lblMeasurement;
        private TextBox txtName;
        private Label label1;
        private ComboBox cmbCategory;
        private Button btnNewCategory;
        private Label txtQuantityRequirementInherited;
        private CheckBox cbDemandQuantity;
        private ToolTip toolTip1;
        private PictureBox pbDemandQuantityInfo;
        private PictureBox pbQuantityRequirementInheritedInfo;
        private Button btnNewMeasurement;
        private ComboBox cmbMeasurement;
        private Label label4;
    }
}