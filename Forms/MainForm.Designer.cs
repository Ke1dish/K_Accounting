namespace K_Accounting
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Стартовая (Start)");
            TreeNode treeNode2 = new TreeNode("Счета (Accounts)");
            TreeNode treeNode3 = new TreeNode("Расходы (Expenses)");
            TreeNode treeNode4 = new TreeNode("Доходы (Income)");
            TreeNode treeNode5 = new TreeNode("Категории (Category)");
            TreeNode treeNode6 = new TreeNode("Источники (Source)");
            TreeNode treeNode7 = new TreeNode("Дополнительно (Additionally)");
            TreeNode treeNode8 = new TreeNode("Валюты (Currencies)");
            TreeNode treeNode9 = new TreeNode("Справочники (Directory)", new TreeNode[] { treeNode5, treeNode6, treeNode7, treeNode8 });
            TreeNode treeNode10 = new TreeNode("Отчеты (Reports)");
            TreeNode treeNode11 = new TreeNode("Настройки (Settings)");
            TreeNode treeNode12 = new TreeNode("О программе");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tableLayoutPanel5 = new TableLayoutPanel();
            label16 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnAddExpense = new Button();
            button1 = new Button();
            btnEditExpense = new Button();
            btnDeleteExpense = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            textBox2 = new TextBox();
            label14 = new Label();
            tableLayoutPanel15 = new TableLayoutPanel();
            label30 = new Label();
            flowLayoutPanel7 = new FlowLayoutPanel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            dataGridView8 = new DataGridView();
            tableLayoutPanel10 = new TableLayoutPanel();
            textBox7 = new TextBox();
            label21 = new Label();
            tableLayoutPanel13 = new TableLayoutPanel();
            label28 = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            btnAddOther = new Button();
            btnEditOther = new Button();
            btnDeleteOther = new Button();
            dataGridViewOthers = new DataGridView();
            tableLayoutPanel8 = new TableLayoutPanel();
            textOtherComment = new TextBox();
            label19 = new Label();
            tableLayoutPanel12 = new TableLayoutPanel();
            label23 = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            btnAddSource = new Button();
            btnEditSource = new Button();
            btnDeleteSource = new Button();
            dataGridViewSources = new DataGridView();
            tableLayoutPanel7 = new TableLayoutPanel();
            label18 = new Label();
            splitContainer1 = new SplitContainer();
            tvMenuPanel = new TreeView();
            tcPage = new TabControl();
            tpStart = new TabPage();
            tableLayoutPanel30 = new TableLayoutPanel();
            label12 = new Label();
            tpAccounts = new TabPage();
            tableLayoutPanel18 = new TableLayoutPanel();
            label9 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            btnAddAccounts = new Button();
            btnTransferAccount = new Button();
            btnEditAccount = new Button();
            btnDeleteAccount = new Button();
            btnPrintAccounts = new Button();
            dgwAccounts = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            tbDetailsAccount = new TextBox();
            tpExpenses = new TabPage();
            tableLayoutPanel19 = new TableLayoutPanel();
            dgwExpenses = new DataGridView();
            label17 = new Label();
            flowLayoutPanel6 = new FlowLayoutPanel();
            btnAddExpenses = new Button();
            btnEditExpenses1 = new Button();
            cmbExpenseMonths = new ComboBox();
            cmbExpenseYears = new ComboBox();
            btnEditExpenses = new Button();
            btnDeleteExpenses = new Button();
            btnPrintExpenses = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            tbDetailsExpenses = new TextBox();
            tpIncome = new TabPage();
            tableLayoutPanel20 = new TableLayoutPanel();
            dgwIncomes = new DataGridView();
            label20 = new Label();
            flowLayoutPanel8 = new FlowLayoutPanel();
            btnAddIncomes = new Button();
            cmbIncomeMonths = new ComboBox();
            cmbIncomeYears = new ComboBox();
            btnEditIncomes = new Button();
            btnDeleteIncomes = new Button();
            btnPrintIncomes = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            label4 = new Label();
            tbDetailsIncome = new TextBox();
            tpCategory = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel25 = new TableLayoutPanel();
            dgwSubCategories = new DataGridView();
            label33 = new Label();
            flowLayoutPanel13 = new FlowLayoutPanel();
            btnAddSubCategories = new Button();
            btnEditSubCategories = new Button();
            btnDeleteSubCategories = new Button();
            tableLayoutPanel24 = new TableLayoutPanel();
            dgwCategorie = new DataGridView();
            label32 = new Label();
            flowLayoutPanel12 = new FlowLayoutPanel();
            btnAddCategories = new Button();
            btnEditCategories = new Button();
            btnDeleteCategories = new Button();
            tableLayoutPanel17 = new TableLayoutPanel();
            label8 = new Label();
            tbDetailsSubCategory = new TextBox();
            tableLayoutPanel16 = new TableLayoutPanel();
            label1 = new Label();
            tbDetailsCategory = new TextBox();
            tpSource = new TabPage();
            tableLayoutPanel21 = new TableLayoutPanel();
            dgwSource = new DataGridView();
            label22 = new Label();
            flowLayoutPanel9 = new FlowLayoutPanel();
            btnAddSources = new Button();
            btnEditSources = new Button();
            btnDeleteSources = new Button();
            tableLayoutPanel9 = new TableLayoutPanel();
            label5 = new Label();
            tbDetailsSource = new TextBox();
            tpAdditionally = new TabPage();
            tableLayoutPanel22 = new TableLayoutPanel();
            dgwAdditionals = new DataGridView();
            label29 = new Label();
            flowLayoutPanel10 = new FlowLayoutPanel();
            btnAddAdditionals = new Button();
            btnEditAdditionals = new Button();
            btnDeleteAdditional = new Button();
            tableLayoutPanel11 = new TableLayoutPanel();
            label6 = new Label();
            tbDetailsAdditional = new TextBox();
            tpCurrencies = new TabPage();
            tableLayoutPanel23 = new TableLayoutPanel();
            dgwCurrencies = new DataGridView();
            label31 = new Label();
            flowLayoutPanel11 = new FlowLayoutPanel();
            btnAddCurrency = new Button();
            btnEditCurrency = new Button();
            btnDeleteCurrency = new Button();
            tableLayoutPanel14 = new TableLayoutPanel();
            label7 = new Label();
            tbDetailsCurrency = new TextBox();
            tpReport = new TabPage();
            tableLayoutPanel31 = new TableLayoutPanel();
            tbDetailsReport = new TextBox();
            tableLayoutPanel26 = new TableLayoutPanel();
            label34 = new Label();
            flPanel1 = new FlowLayoutPanel();
            flPanel2 = new FlowLayoutPanel();
            flPanel3 = new FlowLayoutPanel();
            flPanel4 = new FlowLayoutPanel();
            flPanel5 = new FlowLayoutPanel();
            flPanel6 = new FlowLayoutPanel();
            flowLayoutPanel14 = new FlowLayoutPanel();
            cmbReportTipe = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            tpSettings = new TabPage();
            tableLayoutPanel29 = new TableLayoutPanel();
            label11 = new Label();
            tpAbout = new TabPage();
            tableLayoutPanel27 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCheckUpdate = new Button();
            label10 = new Label();
            tbDedication = new TextBox();
            tableLayoutPanel28 = new TableLayoutPanel();
            tbVersionHistory = new TextBox();
            tbAbout = new TextBox();
            tableLayoutPanel5.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).BeginInit();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOthers).BeginInit();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSources).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tcPage.SuspendLayout();
            tpStart.SuspendLayout();
            tableLayoutPanel30.SuspendLayout();
            tpAccounts.SuspendLayout();
            tableLayoutPanel18.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwAccounts).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tpExpenses.SuspendLayout();
            tableLayoutPanel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwExpenses).BeginInit();
            flowLayoutPanel6.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tpIncome.SuspendLayout();
            tableLayoutPanel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwIncomes).BeginInit();
            flowLayoutPanel8.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tpCategory.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwSubCategories).BeginInit();
            flowLayoutPanel13.SuspendLayout();
            tableLayoutPanel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCategorie).BeginInit();
            flowLayoutPanel12.SuspendLayout();
            tableLayoutPanel17.SuspendLayout();
            tableLayoutPanel16.SuspendLayout();
            tpSource.SuspendLayout();
            tableLayoutPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwSource).BeginInit();
            flowLayoutPanel9.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tpAdditionally.SuspendLayout();
            tableLayoutPanel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwAdditionals).BeginInit();
            flowLayoutPanel10.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tpCurrencies.SuspendLayout();
            tableLayoutPanel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCurrencies).BeginInit();
            flowLayoutPanel11.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tpReport.SuspendLayout();
            tableLayoutPanel31.SuspendLayout();
            tableLayoutPanel26.SuspendLayout();
            flowLayoutPanel14.SuspendLayout();
            tpSettings.SuspendLayout();
            tableLayoutPanel29.SuspendLayout();
            tpAbout.SuspendLayout();
            tableLayoutPanel27.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel28.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.Controls.Add(label16, 0, 0);
            tableLayoutPanel5.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.Padding = new Padding(5);
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 138F));
            tableLayoutPanel5.Size = new Size(625, 432);
            tableLayoutPanel5.TabIndex = 12;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            tableLayoutPanel5.SetColumnSpan(label16, 2);
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label16.ForeColor = Color.Maroon;
            label16.Location = new Point(8, 5);
            label16.Name = "label16";
            label16.Size = new Size(609, 21);
            label16.TabIndex = 0;
            label16.Text = "Расходы";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            tableLayoutPanel5.SetColumnSpan(flowLayoutPanel2, 2);
            flowLayoutPanel2.Controls.Add(btnAddExpense);
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Controls.Add(btnEditExpense);
            flowLayoutPanel2.Controls.Add(btnDeleteExpense);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(8, 29);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(609, 26);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // btnAddExpense
            // 
            btnAddExpense.Location = new Point(3, 2);
            btnAddExpense.Margin = new Padding(3, 2, 3, 2);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(82, 22);
            btnAddExpense.TabIndex = 5;
            btnAddExpense.Text = "Добавить";
            btnAddExpense.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(91, 2);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(101, 22);
            button1.TabIndex = 8;
            button1.Text = "Из шаблонов";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnEditExpense
            // 
            btnEditExpense.Location = new Point(198, 2);
            btnEditExpense.Margin = new Padding(3, 2, 3, 2);
            btnEditExpense.Name = "btnEditExpense";
            btnEditExpense.Size = new Size(82, 22);
            btnEditExpense.TabIndex = 6;
            btnEditExpense.Text = "Изменить";
            btnEditExpense.UseVisualStyleBackColor = true;
            // 
            // btnDeleteExpense
            // 
            btnDeleteExpense.Location = new Point(286, 2);
            btnDeleteExpense.Margin = new Padding(3, 2, 3, 2);
            btnDeleteExpense.Name = "btnDeleteExpense";
            btnDeleteExpense.Size = new Size(82, 22);
            btnDeleteExpense.TabIndex = 7;
            btnDeleteExpense.Text = "Удалить";
            btnDeleteExpense.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel4.Controls.Add(label14, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(0, 432);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(5);
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(625, 66);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(108, 8);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(509, 50);
            textBox2.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(8, 5);
            label14.Name = "label14";
            label14.Size = new Size(87, 15);
            label14.TabIndex = 4;
            label14.Text = "Комментарий:";
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.ColumnCount = 2;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel15.Controls.Add(label30, 0, 0);
            tableLayoutPanel15.Controls.Add(flowLayoutPanel7, 0, 1);
            tableLayoutPanel15.Controls.Add(dataGridView8, 0, 2);
            tableLayoutPanel15.Dock = DockStyle.Fill;
            tableLayoutPanel15.Location = new Point(0, 0);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.Padding = new Padding(5);
            tableLayoutPanel15.RowCount = 3;
            tableLayoutPanel15.RowStyles.Add(new RowStyle());
            tableLayoutPanel15.RowStyles.Add(new RowStyle());
            tableLayoutPanel15.RowStyles.Add(new RowStyle());
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Absolute, 138F));
            tableLayoutPanel15.Size = new Size(625, 432);
            tableLayoutPanel15.TabIndex = 12;
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label30.AutoSize = true;
            tableLayoutPanel15.SetColumnSpan(label30, 2);
            label30.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label30.ForeColor = Color.Maroon;
            label30.Location = new Point(8, 5);
            label30.Name = "label30";
            label30.Size = new Size(892, 21);
            label30.TabIndex = 0;
            label30.Text = "Доходы";
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.AutoSize = true;
            tableLayoutPanel15.SetColumnSpan(flowLayoutPanel7, 2);
            flowLayoutPanel7.Controls.Add(button9);
            flowLayoutPanel7.Controls.Add(button8);
            flowLayoutPanel7.Controls.Add(button7);
            flowLayoutPanel7.Dock = DockStyle.Fill;
            flowLayoutPanel7.Location = new Point(8, 29);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(892, 26);
            flowLayoutPanel7.TabIndex = 1;
            // 
            // button9
            // 
            button9.Location = new Point(3, 2);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(82, 22);
            button9.TabIndex = 4;
            button9.Text = "Добавить";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(91, 2);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(82, 22);
            button8.TabIndex = 5;
            button8.Text = "Изменить";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(179, 2);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(82, 22);
            button7.TabIndex = 6;
            button7.Text = "Удалить";
            button7.UseVisualStyleBackColor = true;
            // 
            // dataGridView8
            // 
            dataGridView8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel15.SetColumnSpan(dataGridView8, 2);
            dataGridView8.Location = new Point(8, 61);
            dataGridView8.Name = "dataGridView8";
            dataGridView8.RowHeadersWidth = 51;
            dataGridView8.Size = new Size(892, 363);
            dataGridView8.TabIndex = 2;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Controls.Add(textBox7, 1, 0);
            tableLayoutPanel10.Controls.Add(label21, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Bottom;
            tableLayoutPanel10.Location = new Point(0, 432);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.Padding = new Padding(5);
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(625, 66);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // textBox7
            // 
            textBox7.Dock = DockStyle.Fill;
            textBox7.Location = new Point(108, 8);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(509, 50);
            textBox7.TabIndex = 5;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(8, 5);
            label21.Name = "label21";
            label21.Size = new Size(87, 15);
            label21.TabIndex = 4;
            label21.Text = "Комментарий:";
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel13.Controls.Add(label28, 0, 0);
            tableLayoutPanel13.Controls.Add(flowLayoutPanel5, 0, 1);
            tableLayoutPanel13.Controls.Add(dataGridViewOthers, 0, 2);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(0, 0);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.Padding = new Padding(5);
            tableLayoutPanel13.RowCount = 3;
            tableLayoutPanel13.RowStyles.Add(new RowStyle());
            tableLayoutPanel13.RowStyles.Add(new RowStyle());
            tableLayoutPanel13.RowStyles.Add(new RowStyle());
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 138F));
            tableLayoutPanel13.Size = new Size(625, 432);
            tableLayoutPanel13.TabIndex = 12;
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label28.AutoSize = true;
            tableLayoutPanel13.SetColumnSpan(label28, 2);
            label28.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label28.ForeColor = Color.Maroon;
            label28.Location = new Point(8, 5);
            label28.Name = "label28";
            label28.Size = new Size(892, 21);
            label28.TabIndex = 0;
            label28.Text = "Дополнительно для приходов";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            tableLayoutPanel13.SetColumnSpan(flowLayoutPanel5, 2);
            flowLayoutPanel5.Controls.Add(btnAddOther);
            flowLayoutPanel5.Controls.Add(btnEditOther);
            flowLayoutPanel5.Controls.Add(btnDeleteOther);
            flowLayoutPanel5.Dock = DockStyle.Fill;
            flowLayoutPanel5.Location = new Point(8, 29);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(892, 26);
            flowLayoutPanel5.TabIndex = 1;
            // 
            // btnAddOther
            // 
            btnAddOther.Location = new Point(3, 2);
            btnAddOther.Margin = new Padding(3, 2, 3, 2);
            btnAddOther.Name = "btnAddOther";
            btnAddOther.Size = new Size(82, 22);
            btnAddOther.TabIndex = 4;
            btnAddOther.Text = "Добавить";
            btnAddOther.UseVisualStyleBackColor = true;
            // 
            // btnEditOther
            // 
            btnEditOther.Location = new Point(91, 2);
            btnEditOther.Margin = new Padding(3, 2, 3, 2);
            btnEditOther.Name = "btnEditOther";
            btnEditOther.Size = new Size(82, 22);
            btnEditOther.TabIndex = 5;
            btnEditOther.Text = "Изменить";
            btnEditOther.UseVisualStyleBackColor = true;
            // 
            // btnDeleteOther
            // 
            btnDeleteOther.Location = new Point(179, 2);
            btnDeleteOther.Margin = new Padding(3, 2, 3, 2);
            btnDeleteOther.Name = "btnDeleteOther";
            btnDeleteOther.Size = new Size(82, 22);
            btnDeleteOther.TabIndex = 6;
            btnDeleteOther.Text = "Удалить";
            btnDeleteOther.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOthers
            // 
            dataGridViewOthers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOthers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel13.SetColumnSpan(dataGridViewOthers, 2);
            dataGridViewOthers.Location = new Point(8, 61);
            dataGridViewOthers.Name = "dataGridViewOthers";
            dataGridViewOthers.RowHeadersWidth = 51;
            dataGridViewOthers.Size = new Size(892, 363);
            dataGridViewOthers.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(textOtherComment, 1, 0);
            tableLayoutPanel8.Controls.Add(label19, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Bottom;
            tableLayoutPanel8.Location = new Point(0, 432);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.Padding = new Padding(5);
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(625, 66);
            tableLayoutPanel8.TabIndex = 3;
            // 
            // textOtherComment
            // 
            textOtherComment.Dock = DockStyle.Fill;
            textOtherComment.Location = new Point(108, 8);
            textOtherComment.Multiline = true;
            textOtherComment.Name = "textOtherComment";
            textOtherComment.Size = new Size(509, 50);
            textOtherComment.TabIndex = 5;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(8, 5);
            label19.Name = "label19";
            label19.Size = new Size(87, 15);
            label19.TabIndex = 4;
            label19.Text = "Комментарий:";
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel12.Controls.Add(label23, 0, 0);
            tableLayoutPanel12.Controls.Add(flowLayoutPanel4, 0, 1);
            tableLayoutPanel12.Controls.Add(dataGridViewSources, 0, 2);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(0, 0);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.Padding = new Padding(5);
            tableLayoutPanel12.RowCount = 3;
            tableLayoutPanel12.RowStyles.Add(new RowStyle());
            tableLayoutPanel12.RowStyles.Add(new RowStyle());
            tableLayoutPanel12.RowStyles.Add(new RowStyle());
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 138F));
            tableLayoutPanel12.Size = new Size(625, 432);
            tableLayoutPanel12.TabIndex = 12;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label23.AutoSize = true;
            tableLayoutPanel12.SetColumnSpan(label23, 2);
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label23.ForeColor = Color.Maroon;
            label23.Location = new Point(8, 5);
            label23.Name = "label23";
            label23.Size = new Size(892, 21);
            label23.TabIndex = 0;
            label23.Text = "Источники приходов";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            tableLayoutPanel12.SetColumnSpan(flowLayoutPanel4, 2);
            flowLayoutPanel4.Controls.Add(btnAddSource);
            flowLayoutPanel4.Controls.Add(btnEditSource);
            flowLayoutPanel4.Controls.Add(btnDeleteSource);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(8, 29);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(892, 26);
            flowLayoutPanel4.TabIndex = 1;
            // 
            // btnAddSource
            // 
            btnAddSource.Location = new Point(3, 2);
            btnAddSource.Margin = new Padding(3, 2, 3, 2);
            btnAddSource.Name = "btnAddSource";
            btnAddSource.Size = new Size(82, 22);
            btnAddSource.TabIndex = 4;
            btnAddSource.Text = "Добавить";
            btnAddSource.UseVisualStyleBackColor = true;
            // 
            // btnEditSource
            // 
            btnEditSource.Location = new Point(91, 2);
            btnEditSource.Margin = new Padding(3, 2, 3, 2);
            btnEditSource.Name = "btnEditSource";
            btnEditSource.Size = new Size(82, 22);
            btnEditSource.TabIndex = 5;
            btnEditSource.Text = "Изменить";
            btnEditSource.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSource
            // 
            btnDeleteSource.Location = new Point(179, 2);
            btnDeleteSource.Margin = new Padding(3, 2, 3, 2);
            btnDeleteSource.Name = "btnDeleteSource";
            btnDeleteSource.Size = new Size(82, 22);
            btnDeleteSource.TabIndex = 6;
            btnDeleteSource.Text = "Удалить";
            btnDeleteSource.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSources
            // 
            dataGridViewSources.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSources.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel12.SetColumnSpan(dataGridViewSources, 2);
            dataGridViewSources.Location = new Point(8, 61);
            dataGridViewSources.Name = "dataGridViewSources";
            dataGridViewSources.RowHeadersWidth = 51;
            dataGridViewSources.Size = new Size(892, 363);
            dataGridViewSources.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(label18, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Bottom;
            tableLayoutPanel7.Location = new Point(0, 432);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.Padding = new Padding(5);
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(625, 66);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(8, 5);
            label18.Name = "label18";
            label18.Size = new Size(87, 15);
            label18.TabIndex = 4;
            label18.Text = "Комментарий:";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvMenuPanel);
            splitContainer1.Panel1.Padding = new Padding(5);
            splitContainer1.Panel1MinSize = 205;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tcPage);
            splitContainer1.Panel2MinSize = 400;
            splitContainer1.Size = new Size(784, 561);
            splitContainer1.SplitterDistance = 205;
            splitContainer1.TabIndex = 0;
            // 
            // tvMenuPanel
            // 
            tvMenuPanel.Dock = DockStyle.Fill;
            tvMenuPanel.FullRowSelect = true;
            tvMenuPanel.HideSelection = false;
            tvMenuPanel.HotTracking = true;
            tvMenuPanel.Location = new Point(5, 5);
            tvMenuPanel.Name = "tvMenuPanel";
            treeNode1.Name = "tnStart";
            treeNode1.Tag = "0";
            treeNode1.Text = "Стартовая (Start)";
            treeNode2.Name = "tnAccounts";
            treeNode2.Tag = "1";
            treeNode2.Text = "Счета (Accounts)";
            treeNode3.Name = "tnExpenses";
            treeNode3.Tag = "2";
            treeNode3.Text = "Расходы (Expenses)";
            treeNode4.Name = "tnIncome";
            treeNode4.Tag = "3";
            treeNode4.Text = "Доходы (Income)";
            treeNode5.Name = "tnCategory";
            treeNode5.Tag = "4";
            treeNode5.Text = "Категории (Category)";
            treeNode6.Name = "tnSource";
            treeNode6.Tag = "5";
            treeNode6.Text = "Источники (Source)";
            treeNode7.Name = "tnAdditionally";
            treeNode7.Tag = "6";
            treeNode7.Text = "Дополнительно (Additionally)";
            treeNode8.Name = "tnCurrencies";
            treeNode8.Tag = "7";
            treeNode8.Text = "Валюты (Currencies)";
            treeNode9.Name = "tnDirectory";
            treeNode9.Tag = "4";
            treeNode9.Text = "Справочники (Directory)";
            treeNode10.Name = "tnReports";
            treeNode10.Tag = "8";
            treeNode10.Text = "Отчеты (Reports)";
            treeNode11.Name = "tnSettings";
            treeNode11.Tag = "9";
            treeNode11.Text = "Настройки (Settings)";
            treeNode12.Name = "tnAbout";
            treeNode12.Tag = "10";
            treeNode12.Text = "О программе";
            tvMenuPanel.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode9, treeNode10, treeNode11, treeNode12 });
            tvMenuPanel.ShowLines = false;
            tvMenuPanel.Size = new Size(195, 551);
            tvMenuPanel.TabIndex = 0;
            tvMenuPanel.AfterSelect += tvMenuPanel_AfterSelect;
            // 
            // tcPage
            // 
            tcPage.Controls.Add(tpStart);
            tcPage.Controls.Add(tpAccounts);
            tcPage.Controls.Add(tpExpenses);
            tcPage.Controls.Add(tpIncome);
            tcPage.Controls.Add(tpCategory);
            tcPage.Controls.Add(tpSource);
            tcPage.Controls.Add(tpAdditionally);
            tcPage.Controls.Add(tpCurrencies);
            tcPage.Controls.Add(tpReport);
            tcPage.Controls.Add(tpSettings);
            tcPage.Controls.Add(tpAbout);
            tcPage.Dock = DockStyle.Fill;
            tcPage.Location = new Point(0, 0);
            tcPage.Name = "tcPage";
            tcPage.SelectedIndex = 0;
            tcPage.Size = new Size(575, 561);
            tcPage.TabIndex = 0;
            tcPage.SelectedIndexChanged += tcPage_SelectedIndexChanged;
            // 
            // tpStart
            // 
            tpStart.Controls.Add(tableLayoutPanel30);
            tpStart.Location = new Point(4, 24);
            tpStart.Name = "tpStart";
            tpStart.Padding = new Padding(3);
            tpStart.Size = new Size(567, 533);
            tpStart.TabIndex = 0;
            tpStart.Text = "Стартовая";
            tpStart.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel30
            // 
            tableLayoutPanel30.ColumnCount = 1;
            tableLayoutPanel30.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel30.Controls.Add(label12, 0, 0);
            tableLayoutPanel30.Dock = DockStyle.Fill;
            tableLayoutPanel30.Location = new Point(3, 3);
            tableLayoutPanel30.Name = "tableLayoutPanel30";
            tableLayoutPanel30.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel30.RowCount = 2;
            tableLayoutPanel30.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel30.RowStyles.Add(new RowStyle());
            tableLayoutPanel30.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel30.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel30.Size = new Size(561, 527);
            tableLayoutPanel30.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.ForeColor = Color.Maroon;
            label12.Location = new Point(8, 5);
            label12.Name = "label12";
            label12.Size = new Size(545, 26);
            label12.TabIndex = 0;
            label12.Text = "День недели и дата";
            // 
            // tpAccounts
            // 
            tpAccounts.Controls.Add(tableLayoutPanel18);
            tpAccounts.Controls.Add(tableLayoutPanel2);
            tpAccounts.Location = new Point(4, 24);
            tpAccounts.Name = "tpAccounts";
            tpAccounts.Size = new Size(567, 533);
            tpAccounts.TabIndex = 1;
            tpAccounts.Text = "Счета";
            tpAccounts.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel18
            // 
            tableLayoutPanel18.ColumnCount = 1;
            tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel18.Controls.Add(label9, 0, 0);
            tableLayoutPanel18.Controls.Add(flowLayoutPanel3, 0, 1);
            tableLayoutPanel18.Controls.Add(dgwAccounts, 0, 2);
            tableLayoutPanel18.Dock = DockStyle.Fill;
            tableLayoutPanel18.Location = new Point(0, 0);
            tableLayoutPanel18.Name = "tableLayoutPanel18";
            tableLayoutPanel18.Padding = new Padding(5);
            tableLayoutPanel18.RowCount = 3;
            tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel18.RowStyles.Add(new RowStyle());
            tableLayoutPanel18.Size = new Size(567, 433);
            tableLayoutPanel18.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(8, 5);
            label9.Name = "label9";
            label9.Size = new Size(551, 26);
            label9.TabIndex = 0;
            label9.Text = "Счета";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(btnAddAccounts);
            flowLayoutPanel3.Controls.Add(btnTransferAccount);
            flowLayoutPanel3.Controls.Add(btnEditAccount);
            flowLayoutPanel3.Controls.Add(btnDeleteAccount);
            flowLayoutPanel3.Controls.Add(btnPrintAccounts);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(8, 34);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(5);
            flowLayoutPanel3.Size = new Size(551, 40);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // btnAddAccounts
            // 
            btnAddAccounts.Image = Properties.Resources.icons8_plus_16;
            btnAddAccounts.Location = new Point(8, 8);
            btnAddAccounts.Name = "btnAddAccounts";
            btnAddAccounts.Size = new Size(104, 23);
            btnAddAccounts.TabIndex = 0;
            btnAddAccounts.Text = "Добавить";
            btnAddAccounts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddAccounts.UseVisualStyleBackColor = true;
            btnAddAccounts.Click += btnAddAccounts_Click;
            // 
            // btnTransferAccount
            // 
            btnTransferAccount.Image = Properties.Resources.icons8_card_exchange_16;
            btnTransferAccount.Location = new Point(118, 8);
            btnTransferAccount.Name = "btnTransferAccount";
            btnTransferAccount.Size = new Size(104, 23);
            btnTransferAccount.TabIndex = 3;
            btnTransferAccount.Text = "Перевод";
            btnTransferAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransferAccount.UseVisualStyleBackColor = true;
            btnTransferAccount.Click += btnTransfer_Click;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Image = Properties.Resources.icons8_edit_16;
            btnEditAccount.Location = new Point(228, 8);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(23, 23);
            btnEditAccount.TabIndex = 1;
            btnEditAccount.UseVisualStyleBackColor = true;
            btnEditAccount.Click += btnEditAccounts_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Image = Properties.Resources.icons8_minus_sign_16;
            btnDeleteAccount.Location = new Point(257, 8);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(23, 23);
            btnDeleteAccount.TabIndex = 2;
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccounts_Click;
            // 
            // btnPrintAccounts
            // 
            btnPrintAccounts.Image = Properties.Resources.icons8_print_16_2;
            btnPrintAccounts.Location = new Point(286, 8);
            btnPrintAccounts.Name = "btnPrintAccounts";
            btnPrintAccounts.Size = new Size(23, 23);
            btnPrintAccounts.TabIndex = 4;
            btnPrintAccounts.UseVisualStyleBackColor = true;
            // 
            // dgwAccounts
            // 
            dgwAccounts.AllowUserToAddRows = false;
            dgwAccounts.AllowUserToDeleteRows = false;
            dgwAccounts.AllowUserToResizeRows = false;
            dgwAccounts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwAccounts.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwAccounts.Location = new Point(8, 80);
            dgwAccounts.MultiSelect = false;
            dgwAccounts.Name = "dgwAccounts";
            dgwAccounts.RowHeadersVisible = false;
            dgwAccounts.RowHeadersWidth = 51;
            dgwAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwAccounts.Size = new Size(551, 345);
            dgwAccounts.TabIndex = 2;
            dgwAccounts.CellFormatting += dataGridViewAccounts_CellFormatting;
            dgwAccounts.SelectionChanged += dataGridViewAccounts_SelectionChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(tbDetailsAccount, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 433);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(567, 100);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 5);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 0;
            label2.Text = "Комментарий:";
            // 
            // tbDetailsAccount
            // 
            tbDetailsAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsAccount.Location = new Point(108, 8);
            tbDetailsAccount.Multiline = true;
            tbDetailsAccount.Name = "tbDetailsAccount";
            tbDetailsAccount.ReadOnly = true;
            tbDetailsAccount.Size = new Size(451, 92);
            tbDetailsAccount.TabIndex = 1;
            // 
            // tpExpenses
            // 
            tpExpenses.Controls.Add(tableLayoutPanel19);
            tpExpenses.Controls.Add(tableLayoutPanel3);
            tpExpenses.Location = new Point(4, 24);
            tpExpenses.Name = "tpExpenses";
            tpExpenses.Size = new Size(567, 533);
            tpExpenses.TabIndex = 2;
            tpExpenses.Text = "Расходы";
            tpExpenses.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel19
            // 
            tableLayoutPanel19.ColumnCount = 1;
            tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel19.Controls.Add(dgwExpenses, 0, 2);
            tableLayoutPanel19.Controls.Add(label17, 0, 0);
            tableLayoutPanel19.Controls.Add(flowLayoutPanel6, 0, 1);
            tableLayoutPanel19.Dock = DockStyle.Fill;
            tableLayoutPanel19.Location = new Point(0, 0);
            tableLayoutPanel19.Name = "tableLayoutPanel19";
            tableLayoutPanel19.Padding = new Padding(5);
            tableLayoutPanel19.RowCount = 3;
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel19.RowStyles.Add(new RowStyle());
            tableLayoutPanel19.Size = new Size(567, 433);
            tableLayoutPanel19.TabIndex = 3;
            // 
            // dgwExpenses
            // 
            dgwExpenses.AllowUserToAddRows = false;
            dgwExpenses.AllowUserToDeleteRows = false;
            dgwExpenses.AllowUserToResizeRows = false;
            dgwExpenses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwExpenses.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwExpenses.Location = new Point(8, 80);
            dgwExpenses.MultiSelect = false;
            dgwExpenses.Name = "dgwExpenses";
            dgwExpenses.RowHeadersVisible = false;
            dgwExpenses.RowHeadersWidth = 51;
            dgwExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwExpenses.Size = new Size(551, 345);
            dgwExpenses.TabIndex = 3;
            dgwExpenses.CellFormatting += dataGridView3_CellFormatting;
            dgwExpenses.SelectionChanged += dataGridViewExpenses_SelectionChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Dock = DockStyle.Fill;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label17.ForeColor = Color.Maroon;
            label17.Location = new Point(8, 5);
            label17.Name = "label17";
            label17.Size = new Size(551, 26);
            label17.TabIndex = 0;
            label17.Text = "Расходы";
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(btnAddExpenses);
            flowLayoutPanel6.Controls.Add(btnEditExpenses1);
            flowLayoutPanel6.Controls.Add(cmbExpenseMonths);
            flowLayoutPanel6.Controls.Add(cmbExpenseYears);
            flowLayoutPanel6.Controls.Add(btnEditExpenses);
            flowLayoutPanel6.Controls.Add(btnDeleteExpenses);
            flowLayoutPanel6.Controls.Add(btnPrintExpenses);
            flowLayoutPanel6.Dock = DockStyle.Fill;
            flowLayoutPanel6.Location = new Point(8, 34);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Padding = new Padding(5);
            flowLayoutPanel6.Size = new Size(551, 40);
            flowLayoutPanel6.TabIndex = 1;
            // 
            // btnAddExpenses
            // 
            btnAddExpenses.Image = Properties.Resources.icons8_plus_16;
            btnAddExpenses.Location = new Point(8, 8);
            btnAddExpenses.Name = "btnAddExpenses";
            btnAddExpenses.Size = new Size(104, 23);
            btnAddExpenses.TabIndex = 0;
            btnAddExpenses.Text = "Добавить";
            btnAddExpenses.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddExpenses.UseVisualStyleBackColor = true;
            btnAddExpenses.Click += btnAddExpenses_Click;
            // 
            // btnEditExpenses1
            // 
            btnEditExpenses1.Image = Properties.Resources.icons8_star_16;
            btnEditExpenses1.Location = new Point(118, 8);
            btnEditExpenses1.Name = "btnEditExpenses1";
            btnEditExpenses1.Size = new Size(104, 23);
            btnEditExpenses1.TabIndex = 1;
            btnEditExpenses1.Text = "Шаблоны";
            btnEditExpenses1.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditExpenses1.UseVisualStyleBackColor = true;
            btnEditExpenses1.Click += btnEditExpenses1_Click;
            // 
            // cmbExpenseMonths
            // 
            cmbExpenseMonths.FormattingEnabled = true;
            cmbExpenseMonths.Location = new Point(228, 8);
            cmbExpenseMonths.Name = "cmbExpenseMonths";
            cmbExpenseMonths.Size = new Size(100, 23);
            cmbExpenseMonths.TabIndex = 4;
            // 
            // cmbExpenseYears
            // 
            cmbExpenseYears.FormattingEnabled = true;
            cmbExpenseYears.Location = new Point(334, 8);
            cmbExpenseYears.Name = "cmbExpenseYears";
            cmbExpenseYears.Size = new Size(80, 23);
            cmbExpenseYears.TabIndex = 5;
            // 
            // btnEditExpenses
            // 
            btnEditExpenses.Image = Properties.Resources.icons8_edit_16;
            btnEditExpenses.Location = new Point(420, 8);
            btnEditExpenses.Name = "btnEditExpenses";
            btnEditExpenses.Size = new Size(23, 23);
            btnEditExpenses.TabIndex = 2;
            btnEditExpenses.UseVisualStyleBackColor = true;
            btnEditExpenses.Click += btnEditExpenses_Click;
            // 
            // btnDeleteExpenses
            // 
            btnDeleteExpenses.Image = Properties.Resources.icons8_minus_sign_16;
            btnDeleteExpenses.Location = new Point(449, 8);
            btnDeleteExpenses.Name = "btnDeleteExpenses";
            btnDeleteExpenses.Size = new Size(23, 23);
            btnDeleteExpenses.TabIndex = 3;
            btnDeleteExpenses.UseVisualStyleBackColor = true;
            btnDeleteExpenses.Click += btnDeleteExpenses_Click;
            // 
            // btnPrintExpenses
            // 
            btnPrintExpenses.Image = Properties.Resources.icons8_print_16_2;
            btnPrintExpenses.Location = new Point(478, 8);
            btnPrintExpenses.Name = "btnPrintExpenses";
            btnPrintExpenses.Size = new Size(23, 23);
            btnPrintExpenses.TabIndex = 6;
            btnPrintExpenses.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(tbDetailsExpenses, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(0, 433);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(567, 100);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 5);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 0;
            label3.Text = "Комментарий:";
            // 
            // tbDetailsExpenses
            // 
            tbDetailsExpenses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsExpenses.Location = new Point(108, 8);
            tbDetailsExpenses.Multiline = true;
            tbDetailsExpenses.Name = "tbDetailsExpenses";
            tbDetailsExpenses.ReadOnly = true;
            tbDetailsExpenses.Size = new Size(451, 89);
            tbDetailsExpenses.TabIndex = 1;
            // 
            // tpIncome
            // 
            tpIncome.Controls.Add(tableLayoutPanel20);
            tpIncome.Controls.Add(tableLayoutPanel6);
            tpIncome.Location = new Point(4, 24);
            tpIncome.Name = "tpIncome";
            tpIncome.Size = new Size(567, 533);
            tpIncome.TabIndex = 3;
            tpIncome.Text = "Доходы";
            tpIncome.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel20
            // 
            tableLayoutPanel20.ColumnCount = 1;
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel20.Controls.Add(dgwIncomes, 0, 2);
            tableLayoutPanel20.Controls.Add(label20, 0, 0);
            tableLayoutPanel20.Controls.Add(flowLayoutPanel8, 0, 1);
            tableLayoutPanel20.Dock = DockStyle.Fill;
            tableLayoutPanel20.Location = new Point(0, 0);
            tableLayoutPanel20.Name = "tableLayoutPanel20";
            tableLayoutPanel20.Padding = new Padding(5);
            tableLayoutPanel20.RowCount = 3;
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel20.RowStyles.Add(new RowStyle());
            tableLayoutPanel20.Size = new Size(567, 433);
            tableLayoutPanel20.TabIndex = 3;
            // 
            // dgwIncomes
            // 
            dgwIncomes.AllowUserToAddRows = false;
            dgwIncomes.AllowUserToDeleteRows = false;
            dgwIncomes.AllowUserToResizeRows = false;
            dgwIncomes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwIncomes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwIncomes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwIncomes.Location = new Point(8, 80);
            dgwIncomes.MultiSelect = false;
            dgwIncomes.Name = "dgwIncomes";
            dgwIncomes.RowHeadersVisible = false;
            dgwIncomes.RowHeadersWidth = 51;
            dgwIncomes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwIncomes.Size = new Size(551, 345);
            dgwIncomes.TabIndex = 3;
            dgwIncomes.CellFormatting += dgwIncomes_CellFormatting;
            dgwIncomes.SelectionChanged += dataGridViewIncomes_SelectionChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Dock = DockStyle.Fill;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label20.ForeColor = Color.Maroon;
            label20.Location = new Point(8, 5);
            label20.Name = "label20";
            label20.Size = new Size(551, 26);
            label20.TabIndex = 0;
            label20.Text = "Доходы";
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Controls.Add(btnAddIncomes);
            flowLayoutPanel8.Controls.Add(cmbIncomeMonths);
            flowLayoutPanel8.Controls.Add(cmbIncomeYears);
            flowLayoutPanel8.Controls.Add(btnEditIncomes);
            flowLayoutPanel8.Controls.Add(btnDeleteIncomes);
            flowLayoutPanel8.Controls.Add(btnPrintIncomes);
            flowLayoutPanel8.Dock = DockStyle.Fill;
            flowLayoutPanel8.Location = new Point(8, 34);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Padding = new Padding(5);
            flowLayoutPanel8.Size = new Size(551, 40);
            flowLayoutPanel8.TabIndex = 1;
            // 
            // btnAddIncomes
            // 
            btnAddIncomes.Image = Properties.Resources.icons8_plus_16;
            btnAddIncomes.Location = new Point(8, 8);
            btnAddIncomes.Name = "btnAddIncomes";
            btnAddIncomes.Size = new Size(104, 23);
            btnAddIncomes.TabIndex = 0;
            btnAddIncomes.Text = "Добавить";
            btnAddIncomes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddIncomes.UseVisualStyleBackColor = true;
            btnAddIncomes.Click += btnAddIncomes_Click;
            // 
            // cmbIncomeMonths
            // 
            cmbIncomeMonths.FormattingEnabled = true;
            cmbIncomeMonths.Location = new Point(118, 8);
            cmbIncomeMonths.Name = "cmbIncomeMonths";
            cmbIncomeMonths.Size = new Size(100, 23);
            cmbIncomeMonths.TabIndex = 6;
            // 
            // cmbIncomeYears
            // 
            cmbIncomeYears.FormattingEnabled = true;
            cmbIncomeYears.Location = new Point(224, 8);
            cmbIncomeYears.Name = "cmbIncomeYears";
            cmbIncomeYears.Size = new Size(80, 23);
            cmbIncomeYears.TabIndex = 7;
            // 
            // btnEditIncomes
            // 
            btnEditIncomes.Image = Properties.Resources.icons8_edit_16;
            btnEditIncomes.Location = new Point(310, 8);
            btnEditIncomes.Name = "btnEditIncomes";
            btnEditIncomes.Size = new Size(23, 23);
            btnEditIncomes.TabIndex = 1;
            btnEditIncomes.UseVisualStyleBackColor = true;
            btnEditIncomes.Click += btnEditIncomes_Click;
            // 
            // btnDeleteIncomes
            // 
            btnDeleteIncomes.Image = Properties.Resources.icons8_minus_sign_16;
            btnDeleteIncomes.Location = new Point(339, 8);
            btnDeleteIncomes.Name = "btnDeleteIncomes";
            btnDeleteIncomes.Size = new Size(23, 23);
            btnDeleteIncomes.TabIndex = 2;
            btnDeleteIncomes.UseVisualStyleBackColor = true;
            btnDeleteIncomes.Click += btnDeleteIncomes_Click;
            // 
            // btnPrintIncomes
            // 
            btnPrintIncomes.Image = Properties.Resources.icons8_print_16_2;
            btnPrintIncomes.Location = new Point(368, 8);
            btnPrintIncomes.Name = "btnPrintIncomes";
            btnPrintIncomes.Size = new Size(23, 23);
            btnPrintIncomes.TabIndex = 8;
            btnPrintIncomes.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label4, 0, 0);
            tableLayoutPanel6.Controls.Add(tbDetailsIncome, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Bottom;
            tableLayoutPanel6.Location = new Point(0, 433);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.Size = new Size(567, 100);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 5);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 0;
            label4.Text = "Комментарий:";
            // 
            // tbDetailsIncome
            // 
            tbDetailsIncome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsIncome.Location = new Point(108, 8);
            tbDetailsIncome.Multiline = true;
            tbDetailsIncome.Name = "tbDetailsIncome";
            tbDetailsIncome.ReadOnly = true;
            tbDetailsIncome.Size = new Size(451, 89);
            tbDetailsIncome.TabIndex = 1;
            // 
            // tpCategory
            // 
            tpCategory.Controls.Add(tableLayoutPanel1);
            tpCategory.Location = new Point(4, 24);
            tpCategory.Name = "tpCategory";
            tpCategory.Size = new Size(567, 533);
            tpCategory.TabIndex = 4;
            tpCategory.Text = "Категории";
            tpCategory.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel25, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel24, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel17, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel16, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.Size = new Size(567, 533);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel25
            // 
            tableLayoutPanel25.ColumnCount = 1;
            tableLayoutPanel25.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel25.Controls.Add(dgwSubCategories, 0, 2);
            tableLayoutPanel25.Controls.Add(label33, 0, 0);
            tableLayoutPanel25.Controls.Add(flowLayoutPanel13, 0, 1);
            tableLayoutPanel25.Dock = DockStyle.Fill;
            tableLayoutPanel25.Location = new Point(283, 0);
            tableLayoutPanel25.Margin = new Padding(0);
            tableLayoutPanel25.Name = "tableLayoutPanel25";
            tableLayoutPanel25.Padding = new Padding(5);
            tableLayoutPanel25.RowCount = 3;
            tableLayoutPanel25.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel25.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel25.RowStyles.Add(new RowStyle());
            tableLayoutPanel25.Size = new Size(284, 427);
            tableLayoutPanel25.TabIndex = 4;
            // 
            // dgwSubCategories
            // 
            dgwSubCategories.AllowUserToAddRows = false;
            dgwSubCategories.AllowUserToDeleteRows = false;
            dgwSubCategories.AllowUserToResizeRows = false;
            dgwSubCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwSubCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwSubCategories.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwSubCategories.Location = new Point(8, 80);
            dgwSubCategories.MultiSelect = false;
            dgwSubCategories.Name = "dgwSubCategories";
            dgwSubCategories.RowHeadersVisible = false;
            dgwSubCategories.RowHeadersWidth = 51;
            dgwSubCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwSubCategories.Size = new Size(268, 339);
            dgwSubCategories.TabIndex = 3;
            dgwSubCategories.CellFormatting += dataGridViewSubCategories_CellFormatting;
            dgwSubCategories.SelectionChanged += dataGridViewSubCategories_SelectionChanged;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Dock = DockStyle.Fill;
            label33.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label33.ForeColor = Color.Maroon;
            label33.Location = new Point(8, 5);
            label33.Name = "label33";
            label33.Size = new Size(268, 26);
            label33.TabIndex = 0;
            label33.Text = "Подкатегории";
            // 
            // flowLayoutPanel13
            // 
            flowLayoutPanel13.Controls.Add(btnAddSubCategories);
            flowLayoutPanel13.Controls.Add(btnEditSubCategories);
            flowLayoutPanel13.Controls.Add(btnDeleteSubCategories);
            flowLayoutPanel13.Dock = DockStyle.Fill;
            flowLayoutPanel13.Location = new Point(8, 34);
            flowLayoutPanel13.Name = "flowLayoutPanel13";
            flowLayoutPanel13.Padding = new Padding(5);
            flowLayoutPanel13.Size = new Size(268, 40);
            flowLayoutPanel13.TabIndex = 1;
            // 
            // btnAddSubCategories
            // 
            btnAddSubCategories.Image = Properties.Resources.icons8_plus_16;
            btnAddSubCategories.Location = new Point(8, 8);
            btnAddSubCategories.Name = "btnAddSubCategories";
            btnAddSubCategories.Size = new Size(104, 23);
            btnAddSubCategories.TabIndex = 0;
            btnAddSubCategories.Text = "Добавить";
            btnAddSubCategories.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddSubCategories.UseVisualStyleBackColor = true;
            btnAddSubCategories.Click += btnAddSubCategories_Click;
            // 
            // btnEditSubCategories
            // 
            btnEditSubCategories.Image = Properties.Resources.icons8_edit_16;
            btnEditSubCategories.Location = new Point(118, 8);
            btnEditSubCategories.Name = "btnEditSubCategories";
            btnEditSubCategories.Size = new Size(23, 23);
            btnEditSubCategories.TabIndex = 1;
            btnEditSubCategories.UseVisualStyleBackColor = true;
            btnEditSubCategories.Click += btnEditSubCategories_Click;
            // 
            // btnDeleteSubCategories
            // 
            btnDeleteSubCategories.Image = Properties.Resources.icons8_minus_sign_16;
            btnDeleteSubCategories.Location = new Point(147, 8);
            btnDeleteSubCategories.Name = "btnDeleteSubCategories";
            btnDeleteSubCategories.Size = new Size(23, 23);
            btnDeleteSubCategories.TabIndex = 2;
            btnDeleteSubCategories.UseVisualStyleBackColor = true;
            btnDeleteSubCategories.Click += btnDeleteSubCategories_Click;
            // 
            // tableLayoutPanel24
            // 
            tableLayoutPanel24.ColumnCount = 1;
            tableLayoutPanel24.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel24.Controls.Add(dgwCategorie, 0, 2);
            tableLayoutPanel24.Controls.Add(label32, 0, 0);
            tableLayoutPanel24.Controls.Add(flowLayoutPanel12, 0, 1);
            tableLayoutPanel24.Dock = DockStyle.Fill;
            tableLayoutPanel24.Location = new Point(0, 0);
            tableLayoutPanel24.Margin = new Padding(0);
            tableLayoutPanel24.Name = "tableLayoutPanel24";
            tableLayoutPanel24.Padding = new Padding(5);
            tableLayoutPanel24.RowCount = 3;
            tableLayoutPanel24.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel24.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel24.RowStyles.Add(new RowStyle());
            tableLayoutPanel24.Size = new Size(283, 427);
            tableLayoutPanel24.TabIndex = 3;
            // 
            // dgwCategorie
            // 
            dgwCategorie.AllowUserToAddRows = false;
            dgwCategorie.AllowUserToDeleteRows = false;
            dgwCategorie.AllowUserToResizeRows = false;
            dgwCategorie.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwCategorie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCategorie.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwCategorie.Location = new Point(8, 80);
            dgwCategorie.MultiSelect = false;
            dgwCategorie.Name = "dgwCategorie";
            dgwCategorie.RowHeadersVisible = false;
            dgwCategorie.RowHeadersWidth = 51;
            dgwCategorie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwCategorie.Size = new Size(267, 339);
            dgwCategorie.TabIndex = 3;
            dgwCategorie.SelectionChanged += dataGridViewCategories_SelectionChanged;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Dock = DockStyle.Fill;
            label32.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label32.ForeColor = Color.Maroon;
            label32.Location = new Point(8, 5);
            label32.Name = "label32";
            label32.Size = new Size(267, 26);
            label32.TabIndex = 0;
            label32.Text = "Категории";
            // 
            // flowLayoutPanel12
            // 
            flowLayoutPanel12.Controls.Add(btnAddCategories);
            flowLayoutPanel12.Controls.Add(btnEditCategories);
            flowLayoutPanel12.Controls.Add(btnDeleteCategories);
            flowLayoutPanel12.Dock = DockStyle.Fill;
            flowLayoutPanel12.Location = new Point(8, 34);
            flowLayoutPanel12.Name = "flowLayoutPanel12";
            flowLayoutPanel12.Padding = new Padding(5);
            flowLayoutPanel12.Size = new Size(267, 40);
            flowLayoutPanel12.TabIndex = 1;
            // 
            // btnAddCategories
            // 
            btnAddCategories.Image = Properties.Resources.icons8_plus_16;
            btnAddCategories.Location = new Point(8, 8);
            btnAddCategories.Name = "btnAddCategories";
            btnAddCategories.Size = new Size(104, 23);
            btnAddCategories.TabIndex = 0;
            btnAddCategories.Text = "Добавить";
            btnAddCategories.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddCategories.UseVisualStyleBackColor = true;
            btnAddCategories.Click += btnAddCategories_Click;
            // 
            // btnEditCategories
            // 
            btnEditCategories.Image = Properties.Resources.icons8_edit_16;
            btnEditCategories.Location = new Point(118, 8);
            btnEditCategories.Name = "btnEditCategories";
            btnEditCategories.Size = new Size(23, 23);
            btnEditCategories.TabIndex = 1;
            btnEditCategories.UseVisualStyleBackColor = true;
            btnEditCategories.Click += btnEditCategories_Click;
            // 
            // btnDeleteCategories
            // 
            btnDeleteCategories.Image = Properties.Resources.icons8_minus_sign_16;
            btnDeleteCategories.Location = new Point(147, 8);
            btnDeleteCategories.Name = "btnDeleteCategories";
            btnDeleteCategories.Size = new Size(23, 23);
            btnDeleteCategories.TabIndex = 2;
            btnDeleteCategories.UseVisualStyleBackColor = true;
            btnDeleteCategories.Click += btnDeleteCategories_Click;
            // 
            // tableLayoutPanel17
            // 
            tableLayoutPanel17.ColumnCount = 2;
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel17.Controls.Add(label8, 0, 0);
            tableLayoutPanel17.Controls.Add(tbDetailsSubCategory, 1, 0);
            tableLayoutPanel17.Dock = DockStyle.Fill;
            tableLayoutPanel17.Location = new Point(286, 430);
            tableLayoutPanel17.Name = "tableLayoutPanel17";
            tableLayoutPanel17.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel17.RowCount = 1;
            tableLayoutPanel17.RowStyles.Add(new RowStyle());
            tableLayoutPanel17.Size = new Size(278, 100);
            tableLayoutPanel17.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 5);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 0;
            label8.Text = "Комментарий:";
            // 
            // tbDetailsSubCategory
            // 
            tbDetailsSubCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsSubCategory.Location = new Point(108, 8);
            tbDetailsSubCategory.Margin = new Padding(3, 3, 3, 0);
            tbDetailsSubCategory.Multiline = true;
            tbDetailsSubCategory.Name = "tbDetailsSubCategory";
            tbDetailsSubCategory.ReadOnly = true;
            tbDetailsSubCategory.Size = new Size(162, 92);
            tbDetailsSubCategory.TabIndex = 1;
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.ColumnCount = 2;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel16.Controls.Add(label1, 0, 0);
            tableLayoutPanel16.Controls.Add(tbDetailsCategory, 1, 0);
            tableLayoutPanel16.Dock = DockStyle.Fill;
            tableLayoutPanel16.Location = new Point(3, 430);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel16.RowCount = 1;
            tableLayoutPanel16.RowStyles.Add(new RowStyle());
            tableLayoutPanel16.Size = new Size(277, 100);
            tableLayoutPanel16.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 5);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Комментарий:";
            // 
            // tbDetailsCategory
            // 
            tbDetailsCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsCategory.Location = new Point(108, 8);
            tbDetailsCategory.Margin = new Padding(3, 3, 3, 0);
            tbDetailsCategory.Multiline = true;
            tbDetailsCategory.Name = "tbDetailsCategory";
            tbDetailsCategory.ReadOnly = true;
            tbDetailsCategory.Size = new Size(161, 92);
            tbDetailsCategory.TabIndex = 1;
            // 
            // tpSource
            // 
            tpSource.Controls.Add(tableLayoutPanel21);
            tpSource.Controls.Add(tableLayoutPanel9);
            tpSource.Location = new Point(4, 24);
            tpSource.Name = "tpSource";
            tpSource.Size = new Size(567, 533);
            tpSource.TabIndex = 5;
            tpSource.Text = "Источники";
            tpSource.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel21
            // 
            tableLayoutPanel21.ColumnCount = 1;
            tableLayoutPanel21.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel21.Controls.Add(dgwSource, 0, 2);
            tableLayoutPanel21.Controls.Add(label22, 0, 0);
            tableLayoutPanel21.Controls.Add(flowLayoutPanel9, 0, 1);
            tableLayoutPanel21.Dock = DockStyle.Fill;
            tableLayoutPanel21.Location = new Point(0, 0);
            tableLayoutPanel21.Name = "tableLayoutPanel21";
            tableLayoutPanel21.Padding = new Padding(5);
            tableLayoutPanel21.RowCount = 3;
            tableLayoutPanel21.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel21.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel21.RowStyles.Add(new RowStyle());
            tableLayoutPanel21.Size = new Size(567, 433);
            tableLayoutPanel21.TabIndex = 3;
            // 
            // dgwSource
            // 
            dgwSource.AllowUserToAddRows = false;
            dgwSource.AllowUserToDeleteRows = false;
            dgwSource.AllowUserToResizeRows = false;
            dgwSource.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwSource.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwSource.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwSource.Location = new Point(8, 80);
            dgwSource.MultiSelect = false;
            dgwSource.Name = "dgwSource";
            dgwSource.RowHeadersVisible = false;
            dgwSource.RowHeadersWidth = 51;
            dgwSource.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwSource.Size = new Size(551, 345);
            dgwSource.TabIndex = 3;
            dgwSource.SelectionChanged += dataGridViewSources_SelectionChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Dock = DockStyle.Fill;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label22.ForeColor = Color.Maroon;
            label22.Location = new Point(8, 5);
            label22.Name = "label22";
            label22.Size = new Size(551, 26);
            label22.TabIndex = 0;
            label22.Text = "Источники";
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.Controls.Add(btnAddSources);
            flowLayoutPanel9.Controls.Add(btnEditSources);
            flowLayoutPanel9.Controls.Add(btnDeleteSources);
            flowLayoutPanel9.Dock = DockStyle.Fill;
            flowLayoutPanel9.Location = new Point(8, 34);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Padding = new Padding(5);
            flowLayoutPanel9.Size = new Size(551, 40);
            flowLayoutPanel9.TabIndex = 1;
            // 
            // btnAddSources
            // 
            btnAddSources.Image = Properties.Resources.icons8_plus_16;
            btnAddSources.Location = new Point(8, 8);
            btnAddSources.Name = "btnAddSources";
            btnAddSources.Size = new Size(104, 23);
            btnAddSources.TabIndex = 0;
            btnAddSources.Text = "Добавить";
            btnAddSources.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddSources.UseVisualStyleBackColor = true;
            btnAddSources.Click += btnAddSources_Click;
            // 
            // btnEditSources
            // 
            btnEditSources.Image = Properties.Resources.icons8_edit_16;
            btnEditSources.Location = new Point(118, 8);
            btnEditSources.Name = "btnEditSources";
            btnEditSources.Size = new Size(23, 23);
            btnEditSources.TabIndex = 1;
            btnEditSources.UseVisualStyleBackColor = true;
            btnEditSources.Click += btnEditSources_Click;
            // 
            // btnDeleteSources
            // 
            btnDeleteSources.Image = Properties.Resources.icons8_minus_sign_16;
            btnDeleteSources.Location = new Point(147, 8);
            btnDeleteSources.Name = "btnDeleteSources";
            btnDeleteSources.Size = new Size(23, 23);
            btnDeleteSources.TabIndex = 2;
            btnDeleteSources.UseVisualStyleBackColor = true;
            btnDeleteSources.Click += btnDeleteSources_Click;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(label5, 0, 0);
            tableLayoutPanel9.Controls.Add(tbDetailsSource, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Bottom;
            tableLayoutPanel9.Location = new Point(0, 433);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle());
            tableLayoutPanel9.Size = new Size(567, 100);
            tableLayoutPanel9.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 5);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 0;
            label5.Text = "Комментарий:";
            // 
            // tbDetailsSource
            // 
            tbDetailsSource.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsSource.Location = new Point(108, 8);
            tbDetailsSource.Multiline = true;
            tbDetailsSource.Name = "tbDetailsSource";
            tbDetailsSource.ReadOnly = true;
            tbDetailsSource.Size = new Size(451, 89);
            tbDetailsSource.TabIndex = 1;
            // 
            // tpAdditionally
            // 
            tpAdditionally.Controls.Add(tableLayoutPanel22);
            tpAdditionally.Controls.Add(tableLayoutPanel11);
            tpAdditionally.Location = new Point(4, 24);
            tpAdditionally.Name = "tpAdditionally";
            tpAdditionally.Size = new Size(567, 533);
            tpAdditionally.TabIndex = 6;
            tpAdditionally.Text = "Дополнительно";
            tpAdditionally.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel22
            // 
            tableLayoutPanel22.ColumnCount = 1;
            tableLayoutPanel22.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel22.Controls.Add(dgwAdditionals, 0, 2);
            tableLayoutPanel22.Controls.Add(label29, 0, 0);
            tableLayoutPanel22.Controls.Add(flowLayoutPanel10, 0, 1);
            tableLayoutPanel22.Dock = DockStyle.Fill;
            tableLayoutPanel22.Location = new Point(0, 0);
            tableLayoutPanel22.Name = "tableLayoutPanel22";
            tableLayoutPanel22.Padding = new Padding(5);
            tableLayoutPanel22.RowCount = 3;
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel22.RowStyles.Add(new RowStyle());
            tableLayoutPanel22.Size = new Size(567, 433);
            tableLayoutPanel22.TabIndex = 3;
            // 
            // dgwAdditionals
            // 
            dgwAdditionals.AllowUserToAddRows = false;
            dgwAdditionals.AllowUserToDeleteRows = false;
            dgwAdditionals.AllowUserToResizeRows = false;
            dgwAdditionals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwAdditionals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwAdditionals.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwAdditionals.Location = new Point(8, 80);
            dgwAdditionals.MultiSelect = false;
            dgwAdditionals.Name = "dgwAdditionals";
            dgwAdditionals.RowHeadersVisible = false;
            dgwAdditionals.RowHeadersWidth = 51;
            dgwAdditionals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwAdditionals.Size = new Size(551, 345);
            dgwAdditionals.TabIndex = 3;
            dgwAdditionals.SelectionChanged += dataGridViewAdditionals_SelectionChanged;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Dock = DockStyle.Fill;
            label29.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label29.ForeColor = Color.Maroon;
            label29.Location = new Point(8, 5);
            label29.Name = "label29";
            label29.Size = new Size(551, 26);
            label29.TabIndex = 0;
            label29.Text = "Дополнительно";
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.Controls.Add(btnAddAdditionals);
            flowLayoutPanel10.Controls.Add(btnEditAdditionals);
            flowLayoutPanel10.Controls.Add(btnDeleteAdditional);
            flowLayoutPanel10.Dock = DockStyle.Fill;
            flowLayoutPanel10.Location = new Point(8, 34);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Padding = new Padding(5);
            flowLayoutPanel10.Size = new Size(551, 40);
            flowLayoutPanel10.TabIndex = 1;
            // 
            // btnAddAdditionals
            // 
            btnAddAdditionals.Image = Properties.Resources.icons8_plus_16;
            btnAddAdditionals.Location = new Point(8, 8);
            btnAddAdditionals.Name = "btnAddAdditionals";
            btnAddAdditionals.Size = new Size(104, 23);
            btnAddAdditionals.TabIndex = 0;
            btnAddAdditionals.Text = "Добавить";
            btnAddAdditionals.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddAdditionals.UseVisualStyleBackColor = true;
            btnAddAdditionals.Click += btnAddAdditionals_Click;
            // 
            // btnEditAdditionals
            // 
            btnEditAdditionals.Image = Properties.Resources.icons8_edit_16;
            btnEditAdditionals.Location = new Point(118, 8);
            btnEditAdditionals.Name = "btnEditAdditionals";
            btnEditAdditionals.Size = new Size(23, 23);
            btnEditAdditionals.TabIndex = 1;
            btnEditAdditionals.UseVisualStyleBackColor = true;
            btnEditAdditionals.Click += btnEditAdditionals_Click;
            // 
            // btnDeleteAdditional
            // 
            btnDeleteAdditional.Image = Properties.Resources.icons8_minus_sign_16;
            btnDeleteAdditional.Location = new Point(147, 8);
            btnDeleteAdditional.Name = "btnDeleteAdditional";
            btnDeleteAdditional.Size = new Size(23, 23);
            btnDeleteAdditional.TabIndex = 2;
            btnDeleteAdditional.UseVisualStyleBackColor = true;
            btnDeleteAdditional.Click += btnDeleteAdditionals_Click;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Controls.Add(label6, 0, 0);
            tableLayoutPanel11.Controls.Add(tbDetailsAdditional, 1, 0);
            tableLayoutPanel11.Dock = DockStyle.Bottom;
            tableLayoutPanel11.Location = new Point(0, 433);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle());
            tableLayoutPanel11.Size = new Size(567, 100);
            tableLayoutPanel11.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 5);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 0;
            label6.Text = "Комментарий:";
            // 
            // tbDetailsAdditional
            // 
            tbDetailsAdditional.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsAdditional.Location = new Point(108, 8);
            tbDetailsAdditional.Multiline = true;
            tbDetailsAdditional.Name = "tbDetailsAdditional";
            tbDetailsAdditional.ReadOnly = true;
            tbDetailsAdditional.Size = new Size(451, 89);
            tbDetailsAdditional.TabIndex = 1;
            // 
            // tpCurrencies
            // 
            tpCurrencies.Controls.Add(tableLayoutPanel23);
            tpCurrencies.Controls.Add(tableLayoutPanel14);
            tpCurrencies.Location = new Point(4, 24);
            tpCurrencies.Name = "tpCurrencies";
            tpCurrencies.Size = new Size(567, 533);
            tpCurrencies.TabIndex = 7;
            tpCurrencies.Text = "Валюты";
            tpCurrencies.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel23
            // 
            tableLayoutPanel23.ColumnCount = 1;
            tableLayoutPanel23.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel23.Controls.Add(dgwCurrencies, 0, 2);
            tableLayoutPanel23.Controls.Add(label31, 0, 0);
            tableLayoutPanel23.Controls.Add(flowLayoutPanel11, 0, 1);
            tableLayoutPanel23.Dock = DockStyle.Fill;
            tableLayoutPanel23.Location = new Point(0, 0);
            tableLayoutPanel23.Name = "tableLayoutPanel23";
            tableLayoutPanel23.Padding = new Padding(5);
            tableLayoutPanel23.RowCount = 3;
            tableLayoutPanel23.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel23.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel23.RowStyles.Add(new RowStyle());
            tableLayoutPanel23.Size = new Size(567, 433);
            tableLayoutPanel23.TabIndex = 3;
            // 
            // dgwCurrencies
            // 
            dgwCurrencies.AllowUserToAddRows = false;
            dgwCurrencies.AllowUserToDeleteRows = false;
            dgwCurrencies.AllowUserToResizeRows = false;
            dgwCurrencies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwCurrencies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCurrencies.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwCurrencies.Location = new Point(8, 80);
            dgwCurrencies.MultiSelect = false;
            dgwCurrencies.Name = "dgwCurrencies";
            dgwCurrencies.RowHeadersVisible = false;
            dgwCurrencies.RowHeadersWidth = 51;
            dgwCurrencies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwCurrencies.Size = new Size(551, 345);
            dgwCurrencies.TabIndex = 3;
            dgwCurrencies.SelectionChanged += dataGridViewCurrencies_SelectionChanged;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Dock = DockStyle.Fill;
            label31.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label31.ForeColor = Color.Maroon;
            label31.Location = new Point(8, 5);
            label31.Name = "label31";
            label31.Size = new Size(551, 26);
            label31.TabIndex = 0;
            label31.Text = "Валюты";
            // 
            // flowLayoutPanel11
            // 
            flowLayoutPanel11.Controls.Add(btnAddCurrency);
            flowLayoutPanel11.Controls.Add(btnEditCurrency);
            flowLayoutPanel11.Controls.Add(btnDeleteCurrency);
            flowLayoutPanel11.Dock = DockStyle.Fill;
            flowLayoutPanel11.Location = new Point(8, 34);
            flowLayoutPanel11.Name = "flowLayoutPanel11";
            flowLayoutPanel11.Padding = new Padding(5);
            flowLayoutPanel11.Size = new Size(551, 40);
            flowLayoutPanel11.TabIndex = 1;
            // 
            // btnAddCurrency
            // 
            btnAddCurrency.Image = Properties.Resources.icons8_plus_16;
            btnAddCurrency.Location = new Point(8, 8);
            btnAddCurrency.Name = "btnAddCurrency";
            btnAddCurrency.Size = new Size(104, 23);
            btnAddCurrency.TabIndex = 0;
            btnAddCurrency.Text = "Добавить";
            btnAddCurrency.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddCurrency.UseVisualStyleBackColor = true;
            btnAddCurrency.Click += btnAddCurrencie_Click;
            // 
            // btnEditCurrency
            // 
            btnEditCurrency.Image = Properties.Resources.icons8_edit_16;
            btnEditCurrency.Location = new Point(118, 8);
            btnEditCurrency.Name = "btnEditCurrency";
            btnEditCurrency.Size = new Size(23, 23);
            btnEditCurrency.TabIndex = 1;
            btnEditCurrency.UseVisualStyleBackColor = true;
            btnEditCurrency.Click += btnEditCurrencie_Click;
            // 
            // btnDeleteCurrency
            // 
            btnDeleteCurrency.Image = Properties.Resources.icons8_minus_sign_16;
            btnDeleteCurrency.Location = new Point(147, 8);
            btnDeleteCurrency.Name = "btnDeleteCurrency";
            btnDeleteCurrency.Size = new Size(23, 23);
            btnDeleteCurrency.TabIndex = 2;
            btnDeleteCurrency.UseVisualStyleBackColor = true;
            btnDeleteCurrency.Click += btnDeleteCurrencie_Click;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 2;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.Controls.Add(label7, 0, 0);
            tableLayoutPanel14.Controls.Add(tbDetailsCurrency, 1, 0);
            tableLayoutPanel14.Dock = DockStyle.Bottom;
            tableLayoutPanel14.Location = new Point(0, 433);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle());
            tableLayoutPanel14.Size = new Size(567, 100);
            tableLayoutPanel14.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 5);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 0;
            label7.Text = "Комментарий:";
            // 
            // tbDetailsCurrency
            // 
            tbDetailsCurrency.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsCurrency.Location = new Point(108, 8);
            tbDetailsCurrency.Multiline = true;
            tbDetailsCurrency.Name = "tbDetailsCurrency";
            tbDetailsCurrency.ReadOnly = true;
            tbDetailsCurrency.Size = new Size(451, 89);
            tbDetailsCurrency.TabIndex = 1;
            // 
            // tpReport
            // 
            tpReport.Controls.Add(tableLayoutPanel31);
            tpReport.Controls.Add(tableLayoutPanel26);
            tpReport.Location = new Point(4, 24);
            tpReport.Name = "tpReport";
            tpReport.Size = new Size(567, 533);
            tpReport.TabIndex = 8;
            tpReport.Text = "Отчеты";
            tpReport.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel31
            // 
            tableLayoutPanel31.ColumnCount = 1;
            tableLayoutPanel31.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel31.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel31.Controls.Add(tbDetailsReport, 0, 0);
            tableLayoutPanel31.Dock = DockStyle.Bottom;
            tableLayoutPanel31.Location = new Point(0, 433);
            tableLayoutPanel31.Name = "tableLayoutPanel31";
            tableLayoutPanel31.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel31.RowCount = 1;
            tableLayoutPanel31.RowStyles.Add(new RowStyle());
            tableLayoutPanel31.Size = new Size(567, 100);
            tableLayoutPanel31.TabIndex = 5;
            // 
            // tbDetailsReport
            // 
            tbDetailsReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsReport.Location = new Point(8, 8);
            tbDetailsReport.Multiline = true;
            tbDetailsReport.Name = "tbDetailsReport";
            tbDetailsReport.ReadOnly = true;
            tbDetailsReport.Size = new Size(551, 89);
            tbDetailsReport.TabIndex = 1;
            // 
            // tableLayoutPanel26
            // 
            tableLayoutPanel26.ColumnCount = 1;
            tableLayoutPanel26.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel26.Controls.Add(label34, 0, 0);
            tableLayoutPanel26.Controls.Add(flPanel1, 0, 2);
            tableLayoutPanel26.Controls.Add(flPanel2, 0, 3);
            tableLayoutPanel26.Controls.Add(flPanel3, 0, 4);
            tableLayoutPanel26.Controls.Add(flPanel4, 0, 5);
            tableLayoutPanel26.Controls.Add(flPanel5, 0, 6);
            tableLayoutPanel26.Controls.Add(flPanel6, 0, 7);
            tableLayoutPanel26.Controls.Add(flowLayoutPanel14, 0, 1);
            tableLayoutPanel26.Dock = DockStyle.Fill;
            tableLayoutPanel26.Location = new Point(0, 0);
            tableLayoutPanel26.Name = "tableLayoutPanel26";
            tableLayoutPanel26.Padding = new Padding(5);
            tableLayoutPanel26.RowCount = 9;
            tableLayoutPanel26.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel26.RowStyles.Add(new RowStyle());
            tableLayoutPanel26.RowStyles.Add(new RowStyle());
            tableLayoutPanel26.RowStyles.Add(new RowStyle());
            tableLayoutPanel26.RowStyles.Add(new RowStyle());
            tableLayoutPanel26.RowStyles.Add(new RowStyle());
            tableLayoutPanel26.RowStyles.Add(new RowStyle());
            tableLayoutPanel26.RowStyles.Add(new RowStyle());
            tableLayoutPanel26.RowStyles.Add(new RowStyle());
            tableLayoutPanel26.Size = new Size(567, 533);
            tableLayoutPanel26.TabIndex = 4;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Dock = DockStyle.Fill;
            label34.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label34.ForeColor = Color.Maroon;
            label34.Location = new Point(8, 5);
            label34.Name = "label34";
            label34.Size = new Size(551, 26);
            label34.TabIndex = 0;
            label34.Text = "Отчеты";
            // 
            // flPanel1
            // 
            flPanel1.Dock = DockStyle.Fill;
            flPanel1.Location = new Point(8, 69);
            flPanel1.Name = "flPanel1";
            flPanel1.Size = new Size(551, 27);
            flPanel1.TabIndex = 9;
            // 
            // flPanel2
            // 
            flPanel2.Dock = DockStyle.Fill;
            flPanel2.Location = new Point(8, 102);
            flPanel2.Name = "flPanel2";
            flPanel2.Size = new Size(551, 27);
            flPanel2.TabIndex = 10;
            // 
            // flPanel3
            // 
            flPanel3.Dock = DockStyle.Fill;
            flPanel3.Location = new Point(8, 135);
            flPanel3.Name = "flPanel3";
            flPanel3.Size = new Size(551, 27);
            flPanel3.TabIndex = 11;
            // 
            // flPanel4
            // 
            flPanel4.Dock = DockStyle.Fill;
            flPanel4.Location = new Point(8, 168);
            flPanel4.Name = "flPanel4";
            flPanel4.Size = new Size(551, 27);
            flPanel4.TabIndex = 12;
            // 
            // flPanel5
            // 
            flPanel5.Dock = DockStyle.Fill;
            flPanel5.Location = new Point(8, 201);
            flPanel5.Name = "flPanel5";
            flPanel5.Size = new Size(551, 27);
            flPanel5.TabIndex = 13;
            // 
            // flPanel6
            // 
            flPanel6.Dock = DockStyle.Fill;
            flPanel6.Location = new Point(8, 234);
            flPanel6.Name = "flPanel6";
            flPanel6.Size = new Size(551, 27);
            flPanel6.TabIndex = 14;
            // 
            // flowLayoutPanel14
            // 
            flowLayoutPanel14.AutoSize = true;
            flowLayoutPanel14.Controls.Add(cmbReportTipe);
            flowLayoutPanel14.Controls.Add(button2);
            flowLayoutPanel14.Controls.Add(button3);
            flowLayoutPanel14.Dock = DockStyle.Fill;
            flowLayoutPanel14.Location = new Point(8, 34);
            flowLayoutPanel14.Name = "flowLayoutPanel14";
            flowLayoutPanel14.Size = new Size(551, 29);
            flowLayoutPanel14.TabIndex = 15;
            // 
            // cmbReportTipe
            // 
            cmbReportTipe.FormattingEnabled = true;
            cmbReportTipe.Items.AddRange(new object[] { "Баланс счетов", "Динамика баланса", "Топ расходов/приходов", "Приходы по источникам", "Конверсия доходов в сбережения", "Распределение расходов", "Расходы по категориям", "Расходы по дополнительному", "Доходы vs Расходы", "Распределение сумм", "Календарь трат", "Финансовый профиль", "Зависимость расходов от доходов", "Сравнение периодов" });
            cmbReportTipe.Location = new Point(3, 3);
            cmbReportTipe.Name = "cmbReportTipe";
            cmbReportTipe.Size = new Size(378, 23);
            cmbReportTipe.TabIndex = 9;
            cmbReportTipe.SelectedIndexChanged += cmbReportTipe_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.icons8_refresh_16;
            button2.Location = new Point(387, 3);
            button2.Name = "button2";
            button2.Size = new Size(23, 23);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.icons8_print_16_2;
            button3.Location = new Point(416, 3);
            button3.Name = "button3";
            button3.Size = new Size(23, 23);
            button3.TabIndex = 11;
            button3.UseVisualStyleBackColor = true;
            // 
            // tpSettings
            // 
            tpSettings.Controls.Add(tableLayoutPanel29);
            tpSettings.Location = new Point(4, 24);
            tpSettings.Name = "tpSettings";
            tpSettings.Size = new Size(567, 533);
            tpSettings.TabIndex = 9;
            tpSettings.Text = "Настройки";
            tpSettings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel29
            // 
            tableLayoutPanel29.ColumnCount = 1;
            tableLayoutPanel29.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel29.Controls.Add(label11, 0, 0);
            tableLayoutPanel29.Dock = DockStyle.Fill;
            tableLayoutPanel29.Location = new Point(0, 0);
            tableLayoutPanel29.Name = "tableLayoutPanel29";
            tableLayoutPanel29.Padding = new Padding(5);
            tableLayoutPanel29.RowCount = 2;
            tableLayoutPanel29.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel29.RowStyles.Add(new RowStyle());
            tableLayoutPanel29.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel29.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel29.Size = new Size(567, 533);
            tableLayoutPanel29.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.Maroon;
            label11.Location = new Point(8, 5);
            label11.Name = "label11";
            label11.Size = new Size(551, 26);
            label11.TabIndex = 0;
            label11.Text = "Настройки";
            // 
            // tpAbout
            // 
            tpAbout.Controls.Add(tableLayoutPanel27);
            tpAbout.Location = new Point(4, 24);
            tpAbout.Name = "tpAbout";
            tpAbout.Size = new Size(567, 533);
            tpAbout.TabIndex = 10;
            tpAbout.Text = "О программе";
            tpAbout.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel27
            // 
            tableLayoutPanel27.ColumnCount = 1;
            tableLayoutPanel27.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel27.Controls.Add(flowLayoutPanel1, 0, 3);
            tableLayoutPanel27.Controls.Add(label10, 0, 0);
            tableLayoutPanel27.Controls.Add(tbDedication, 0, 1);
            tableLayoutPanel27.Controls.Add(tableLayoutPanel28, 0, 2);
            tableLayoutPanel27.Dock = DockStyle.Fill;
            tableLayoutPanel27.Location = new Point(0, 0);
            tableLayoutPanel27.Name = "tableLayoutPanel27";
            tableLayoutPanel27.Padding = new Padding(5);
            tableLayoutPanel27.RowCount = 4;
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Absolute, 185F));
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel27.Size = new Size(567, 533);
            tableLayoutPanel27.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCheckUpdate);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(8, 485);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(551, 40);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnCheckUpdate
            // 
            btnCheckUpdate.Image = Properties.Resources.icons8_refresh_16;
            btnCheckUpdate.Location = new Point(414, 8);
            btnCheckUpdate.Name = "btnCheckUpdate";
            btnCheckUpdate.Size = new Size(124, 23);
            btnCheckUpdate.TabIndex = 6;
            btnCheckUpdate.Text = "Обновление";
            btnCheckUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCheckUpdate.UseVisualStyleBackColor = true;
            btnCheckUpdate.Click += btnCheckUpdate_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.Maroon;
            label10.Location = new Point(8, 5);
            label10.Name = "label10";
            label10.Size = new Size(551, 26);
            label10.TabIndex = 0;
            label10.Text = "О программе";
            // 
            // tbDedication
            // 
            tbDedication.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDedication.BackColor = SystemColors.Window;
            tbDedication.Location = new Point(10, 36);
            tbDedication.Margin = new Padding(5);
            tbDedication.Multiline = true;
            tbDedication.Name = "tbDedication";
            tbDedication.ReadOnly = true;
            tbDedication.ScrollBars = ScrollBars.Both;
            tbDedication.Size = new Size(547, 175);
            tbDedication.TabIndex = 1;
            tbDedication.Text = resources.GetString("tbDedication.Text");
            // 
            // tableLayoutPanel28
            // 
            tableLayoutPanel28.ColumnCount = 2;
            tableLayoutPanel28.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel28.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel28.Controls.Add(tbVersionHistory, 1, 0);
            tableLayoutPanel28.Controls.Add(tbAbout, 0, 0);
            tableLayoutPanel28.Dock = DockStyle.Fill;
            tableLayoutPanel28.Location = new Point(5, 216);
            tableLayoutPanel28.Margin = new Padding(0);
            tableLayoutPanel28.Name = "tableLayoutPanel28";
            tableLayoutPanel28.RowCount = 1;
            tableLayoutPanel28.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel28.Size = new Size(557, 266);
            tableLayoutPanel28.TabIndex = 4;
            // 
            // tbVersionHistory
            // 
            tbVersionHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbVersionHistory.BackColor = SystemColors.Window;
            tbVersionHistory.Location = new Point(283, 5);
            tbVersionHistory.Margin = new Padding(5);
            tbVersionHistory.Multiline = true;
            tbVersionHistory.Name = "tbVersionHistory";
            tbVersionHistory.ReadOnly = true;
            tbVersionHistory.ScrollBars = ScrollBars.Both;
            tbVersionHistory.Size = new Size(269, 256);
            tbVersionHistory.TabIndex = 5;
            tbVersionHistory.Text = "История версий:\r\n\r\n07.03.2025 (v1.0.0) - Первый релиз";
            // 
            // tbAbout
            // 
            tbAbout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbAbout.BackColor = SystemColors.Window;
            tbAbout.Location = new Point(5, 5);
            tbAbout.Margin = new Padding(5);
            tbAbout.Multiline = true;
            tbAbout.Name = "tbAbout";
            tbAbout.ReadOnly = true;
            tbAbout.ScrollBars = ScrollBars.Both;
            tbAbout.Size = new Size(268, 256);
            tbAbout.TabIndex = 4;
            tbAbout.Text = resources.GetString("tbAbout.Text");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(800, 600);
            Name = "MainForm";
            Text = "Form1";
            FormClosing += MainForm_FormClosing;
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView8).EndInit();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOthers).EndInit();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSources).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tcPage.ResumeLayout(false);
            tpStart.ResumeLayout(false);
            tableLayoutPanel30.ResumeLayout(false);
            tableLayoutPanel30.PerformLayout();
            tpAccounts.ResumeLayout(false);
            tableLayoutPanel18.ResumeLayout(false);
            tableLayoutPanel18.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwAccounts).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tpExpenses.ResumeLayout(false);
            tableLayoutPanel19.ResumeLayout(false);
            tableLayoutPanel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwExpenses).EndInit();
            flowLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tpIncome.ResumeLayout(false);
            tableLayoutPanel20.ResumeLayout(false);
            tableLayoutPanel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwIncomes).EndInit();
            flowLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tpCategory.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel25.ResumeLayout(false);
            tableLayoutPanel25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwSubCategories).EndInit();
            flowLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel24.ResumeLayout(false);
            tableLayoutPanel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCategorie).EndInit();
            flowLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel17.ResumeLayout(false);
            tableLayoutPanel17.PerformLayout();
            tableLayoutPanel16.ResumeLayout(false);
            tableLayoutPanel16.PerformLayout();
            tpSource.ResumeLayout(false);
            tableLayoutPanel21.ResumeLayout(false);
            tableLayoutPanel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwSource).EndInit();
            flowLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tpAdditionally.ResumeLayout(false);
            tableLayoutPanel22.ResumeLayout(false);
            tableLayoutPanel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwAdditionals).EndInit();
            flowLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tpCurrencies.ResumeLayout(false);
            tableLayoutPanel23.ResumeLayout(false);
            tableLayoutPanel23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCurrencies).EndInit();
            flowLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tpReport.ResumeLayout(false);
            tableLayoutPanel31.ResumeLayout(false);
            tableLayoutPanel31.PerformLayout();
            tableLayoutPanel26.ResumeLayout(false);
            tableLayoutPanel26.PerformLayout();
            flowLayoutPanel14.ResumeLayout(false);
            tpSettings.ResumeLayout(false);
            tableLayoutPanel29.ResumeLayout(false);
            tableLayoutPanel29.PerformLayout();
            tpAbout.ResumeLayout(false);
            tableLayoutPanel27.ResumeLayout(false);
            tableLayoutPanel27.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel28.ResumeLayout(false);
            tableLayoutPanel28.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox labelAccountComment;
        private Label label7;
        private Label label6;
        private Label label8;
        private TextBox labelSubcategoryComment;
        private Label label9;
        private DataGridView dgwCategorie;
        private DataGridView dataGridViewOthers;
        private DataGridView dataGridViewSources;
        private DataGridView dgwCurrencies;
        private TextBox tbDetailsCurrency;
        private TextBox tbDetailsSubCategory;
        private TabPage tpStart;
        private DataGridView dgwAccounts;
        private TabPage tpIncome;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label16;
        private FlowLayoutPanel flowLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox textBox2;
        private Label label14;
        private TabPage tpCategory;
        private TableLayoutPanel tableLayoutPanel15;
        private Label label30;
        private FlowLayoutPanel flowLayoutPanel7;
        private DataGridView dataGridView8;
        private TableLayoutPanel tableLayoutPanel10;
        private TextBox textBox7;
        private Label label21;
        private TabPage tpSource;
        private TabPage tpAdditionally;
        private TableLayoutPanel tableLayoutPanel13;
        private Label label28;
        private FlowLayoutPanel flowLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel8;
        private TextBox textOtherComment;
        private Label label19;
        private TabPage tpCurrencies;
        private TableLayoutPanel tableLayoutPanel12;
        private Label label23;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button btnEditAccount;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox tbDetailsIncome;
        private Label label18;
        private Button btnAddAccounts;
        private Button btnAddSource;
        private Button btnEditSource;
        private Button btnDeleteSource;
        private Button btnAddOther;
        private Button btnEditOther;
        private Button btnDeleteOther;
        private Button btnAddExpense;
        private Button button1;
        private Button btnEditExpense;
        private Button btnDeleteExpense;
        private Button button9;
        private Button button8;
        private Button button7;
        private TextBox tbDetailsExpenses;
        private TextBox tbDetailsAccount;
        private SplitContainer splitContainer1;
        private TreeView tvMenuPanel;
        private TabControl tcPage;
        private TabPage tpAccounts;
        private TabPage tpExpenses;
        private TabPage tpReport;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel16;
        private Label label1;
        private TextBox tbDetailsCategory;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label5;
        private TextBox tbDetailsSource;
        private TableLayoutPanel tableLayoutPanel11;
        private TextBox tbDetailsAdditional;
        private TableLayoutPanel tableLayoutPanel14;
        private TableLayoutPanel tableLayoutPanel18;
        private FlowLayoutPanel flowLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel17;
        private TableLayoutPanel tableLayoutPanel19;
        private DataGridView dgwExpenses;
        private Label label17;
        private FlowLayoutPanel flowLayoutPanel6;
        private Button btnAddExpenses;
        private Button btnEditExpenses1;
        private TableLayoutPanel tableLayoutPanel20;
        private DataGridView dgwIncomes;
        private Label label20;
        private FlowLayoutPanel flowLayoutPanel8;
        private Button btnAddIncomes;
        private Button btnEditIncomes;
        private TableLayoutPanel tableLayoutPanel25;
        private DataGridView dgwSubCategories;
        private Label label33;
        private FlowLayoutPanel flowLayoutPanel13;
        private Button btnAddSubCategories;
        private Button btnEditSubCategories;
        private TableLayoutPanel tableLayoutPanel24;
        private Label label32;
        private FlowLayoutPanel flowLayoutPanel12;
        private Button btnAddCategories;
        private Button btnEditCategories;
        private TableLayoutPanel tableLayoutPanel21;
        private DataGridView dgwSource;
        private Label label22;
        private FlowLayoutPanel flowLayoutPanel9;
        private Button btnAddSources;
        private Button btnEditSources;
        private TableLayoutPanel tableLayoutPanel22;
        private DataGridView dgwAdditionals;
        private Label label29;
        private FlowLayoutPanel flowLayoutPanel10;
        private Button btnAddAdditionals;
        private Button btnEditAdditionals;
        private TableLayoutPanel tableLayoutPanel23;
        private Label label31;
        private FlowLayoutPanel flowLayoutPanel11;
        private Button btnAddCurrency;
        private Button btnEditCurrency;
        private Button btnDeleteAccount;
        private Button btnTransferAccount;
        private Button btnEditExpenses;
        private Button btnDeleteExpenses;
        private Button btnDeleteIncomes;
        private Button btnDeleteSubCategories;
        private Button btnDeleteCategories;
        private Button btnDeleteSources;
        private Button btnDeleteAdditional;
        private Button btnDeleteCurrency;
        private TabPage tpSettings;
        private ComboBox cmbExpenseMonths;
        private ComboBox cmbExpenseYears;
        private ComboBox cmbIncomeMonths;
        private ComboBox cmbIncomeYears;
        private TableLayoutPanel tableLayoutPanel26;
        private Label label34;
        private Button btnPrintAccounts;
        private Button btnPrintExpenses;
        private Button btnPrintIncomes;
        private TabPage tpAbout;
        private TableLayoutPanel tableLayoutPanel27;
        private Label label10;
        private TextBox tbDedication;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCheckUpdate;
        private TableLayoutPanel tableLayoutPanel28;
        private TextBox tbVersionHistory;
        private TextBox tbAbout;
        private TableLayoutPanel tableLayoutPanel30;
        private Label label12;
        private TableLayoutPanel tableLayoutPanel29;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel31;
        private TextBox tbDetailsReport;
        private FlowLayoutPanel flPanel1;
        private FlowLayoutPanel flPanel2;
        private FlowLayoutPanel flPanel3;
        private FlowLayoutPanel flPanel4;
        private FlowLayoutPanel flPanel5;
        private FlowLayoutPanel flPanel6;
        private FlowLayoutPanel flowLayoutPanel14;
        private ComboBox cmbReportTipe;
        private Button button2;
        private Button button3;
    }
}
