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
            components = new System.ComponentModel.Container();
            TreeNode treeNode1 = new TreeNode("Главная", 5, 5);
            TreeNode treeNode2 = new TreeNode("Счета", 9, 9);
            TreeNode treeNode3 = new TreeNode("Расходы", 8, 8);
            TreeNode treeNode4 = new TreeNode("Приходы", 7, 7);
            TreeNode treeNode5 = new TreeNode("Категории", 2, 2);
            TreeNode treeNode6 = new TreeNode("Источники", 1, 1);
            TreeNode treeNode7 = new TreeNode("Упоминания", 10, 10);
            TreeNode treeNode8 = new TreeNode("Контрагенты");
            TreeNode treeNode9 = new TreeNode("Валюты", 3, 3);
            TreeNode treeNode10 = new TreeNode("Справочники", 2, 2, new TreeNode[] { treeNode5, treeNode6, treeNode7, treeNode8, treeNode9 });
            TreeNode treeNode11 = new TreeNode("Выданные");
            TreeNode treeNode12 = new TreeNode("Полученые");
            TreeNode treeNode13 = new TreeNode("Долги", new TreeNode[] { treeNode11, treeNode12 });
            TreeNode treeNode14 = new TreeNode("Отчеты", 6, 6);
            TreeNode treeNode15 = new TreeNode("Настройки", 4, 4);
            TreeNode treeNode16 = new TreeNode("О программе", 0, 0);
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
            imageList1 = new ImageList(components);
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
            contextMenu = new ContextMenuStrip(components);
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            tbDetailsAccount = new TextBox();
            tpExpenses = new TabPage();
            tableLayoutPanel19 = new TableLayoutPanel();
            dgwExpenses = new DataGridView();
            lblPageExpensesCaption = new Label();
            flowLayoutPanel6 = new FlowLayoutPanel();
            btnAddExpenses = new Button();
            btnEditExpenses1 = new Button();
            btnEditExpenses = new Button();
            btnDeleteExpenses = new Button();
            btnPrintExpenses = new Button();
            cmbExpenseMonths = new ComboBox();
            cmbExpenseYears = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            tbDetailsExpenses = new TextBox();
            tpIncome = new TabPage();
            tableLayoutPanel20 = new TableLayoutPanel();
            dgwIncomes = new DataGridView();
            lblPageIncomesCaption = new Label();
            flowLayoutPanel8 = new FlowLayoutPanel();
            btnAddIncomes = new Button();
            btnEditIncomes = new Button();
            btnDeleteIncomes = new Button();
            btnPrintIncomes = new Button();
            cmbIncomeMonths = new ComboBox();
            cmbIncomeYears = new ComboBox();
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
            tableLayoutPanel26 = new TableLayoutPanel();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            label34 = new Label();
            filterPanel = new FlowLayoutPanel();
            label35 = new Label();
            dtpStartReportDate = new DateTimePicker();
            label13 = new Label();
            dtpEndReportDate = new DateTimePicker();
            pnlFilters = new FlowLayoutPanel();
            label36 = new Label();
            flPanel3 = new FlowLayoutPanel();
            label37 = new Label();
            flPanel4 = new FlowLayoutPanel();
            label38 = new Label();
            flPanel5 = new FlowLayoutPanel();
            label39 = new Label();
            flPanel6 = new FlowLayoutPanel();
            label40 = new Label();
            flowLayoutPanel14 = new FlowLayoutPanel();
            cmbReports = new ComboBox();
            btnRefresh = new Button();
            button3 = new Button();
            tpSettings = new TabPage();
            tableLayoutPanel29 = new TableLayoutPanel();
            label11 = new Label();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            tpAbout = new TabPage();
            tableLayoutPanel27 = new TableLayoutPanel();
            tbVersionHistory = new TextBox();
            label10 = new Label();
            tableLayoutPanel28 = new TableLayoutPanel();
            tbAbout = new TextBox();
            pictureBox1 = new PictureBox();
            tpDebtGiven = new TabPage();
            tableLayoutPanel33 = new TableLayoutPanel();
            dgwGivenDebts = new DataGridView();
            lblGivenDebtsTotal = new Label();
            flowLayoutPanel15 = new FlowLayoutPanel();
            btnAddGivenDebt = new Button();
            btnEditGivenDebt = new Button();
            btnDeleteGivenDebt = new Button();
            button12 = new Button();
            cmbGivenDebtMonths = new ComboBox();
            cmbGivenDebtYears = new ComboBox();
            btnPaymentGivenDebt = new Button();
            tableLayoutPanel31 = new TableLayoutPanel();
            label15 = new Label();
            tbDetailsGivenDebts = new TextBox();
            tpDebtReceived = new TabPage();
            tableLayoutPanel34 = new TableLayoutPanel();
            dgwReceivedDebts = new DataGridView();
            lblReceivedDebtsTotal = new Label();
            flowLayoutPanel16 = new FlowLayoutPanel();
            btnAddReceivedDebt = new Button();
            btnEditReceivedDebt = new Button();
            btnDeleteReceivedDebt = new Button();
            button13 = new Button();
            cmbReceivedDebtMonths = new ComboBox();
            cmbReceivedDebtYears = new ComboBox();
            btnPaymentReceivedDebt = new Button();
            tableLayoutPanel32 = new TableLayoutPanel();
            label17 = new Label();
            tbDetailsReceivedDebts = new TextBox();
            tbCounterparties = new TabPage();
            tableLayoutPanel36 = new TableLayoutPanel();
            dgwCounterparties = new DataGridView();
            label24 = new Label();
            flowLayoutPanel17 = new FlowLayoutPanel();
            btnAddCounterparties = new Button();
            btnEditCounterparties = new Button();
            btnDeleteCounterparties = new Button();
            tableLayoutPanel35 = new TableLayoutPanel();
            label20 = new Label();
            tbDetailsCounterparties = new TextBox();
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
            tableLayoutPanel26.SuspendLayout();
            filterPanel.SuspendLayout();
            pnlFilters.SuspendLayout();
            flPanel3.SuspendLayout();
            flPanel4.SuspendLayout();
            flPanel5.SuspendLayout();
            flPanel6.SuspendLayout();
            flowLayoutPanel14.SuspendLayout();
            tpSettings.SuspendLayout();
            tableLayoutPanel29.SuspendLayout();
            panel1.SuspendLayout();
            tpAbout.SuspendLayout();
            tableLayoutPanel27.SuspendLayout();
            tableLayoutPanel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tpDebtGiven.SuspendLayout();
            tableLayoutPanel33.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwGivenDebts).BeginInit();
            flowLayoutPanel15.SuspendLayout();
            tableLayoutPanel31.SuspendLayout();
            tpDebtReceived.SuspendLayout();
            tableLayoutPanel34.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwReceivedDebts).BeginInit();
            flowLayoutPanel16.SuspendLayout();
            tableLayoutPanel32.SuspendLayout();
            tbCounterparties.SuspendLayout();
            tableLayoutPanel36.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCounterparties).BeginInit();
            flowLayoutPanel17.SuspendLayout();
            tableLayoutPanel35.SuspendLayout();
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
            label16.Size = new Size(609, 28);
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
            flowLayoutPanel2.Location = new Point(8, 36);
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
            label14.Size = new Size(89, 40);
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
            label30.Size = new Size(892, 28);
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
            flowLayoutPanel7.Location = new Point(8, 36);
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
            dataGridView8.Location = new Point(8, 68);
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
            label21.Size = new Size(89, 40);
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
            label28.Size = new Size(892, 28);
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
            flowLayoutPanel5.Location = new Point(8, 36);
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
            dataGridViewOthers.Location = new Point(8, 68);
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
            label19.Size = new Size(89, 40);
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
            label23.Size = new Size(892, 28);
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
            flowLayoutPanel4.Location = new Point(8, 36);
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
            dataGridViewSources.Location = new Point(8, 68);
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
            label18.Size = new Size(89, 40);
            label18.TabIndex = 4;
            label18.Text = "Комментарий:";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvMenuPanel);
            splitContainer1.Panel1.Padding = new Padding(6, 7, 6, 7);
            splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tcPage);
            splitContainer1.Panel2MinSize = 400;
            splitContainer1.Size = new Size(896, 748);
            splitContainer1.SplitterDistance = 171;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // tvMenuPanel
            // 
            tvMenuPanel.Dock = DockStyle.Fill;
            tvMenuPanel.FullRowSelect = true;
            tvMenuPanel.HideSelection = false;
            tvMenuPanel.HotTracking = true;
            tvMenuPanel.ImageIndex = 0;
            tvMenuPanel.ImageList = imageList1;
            tvMenuPanel.Location = new Point(6, 7);
            tvMenuPanel.Margin = new Padding(3, 4, 3, 4);
            tvMenuPanel.Name = "tvMenuPanel";
            treeNode1.ImageIndex = 5;
            treeNode1.Name = "tnStart";
            treeNode1.SelectedImageIndex = 5;
            treeNode1.Tag = "0";
            treeNode1.Text = "Главная";
            treeNode2.ImageIndex = 9;
            treeNode2.Name = "tnAccounts";
            treeNode2.SelectedImageIndex = 9;
            treeNode2.Tag = "1";
            treeNode2.Text = "Счета";
            treeNode3.ImageIndex = 8;
            treeNode3.Name = "tnExpenses";
            treeNode3.SelectedImageIndex = 8;
            treeNode3.Tag = "2";
            treeNode3.Text = "Расходы";
            treeNode4.ImageIndex = 7;
            treeNode4.Name = "tnIncome";
            treeNode4.SelectedImageIndex = 7;
            treeNode4.Tag = "3";
            treeNode4.Text = "Приходы";
            treeNode5.ImageIndex = 2;
            treeNode5.Name = "tnCategory";
            treeNode5.SelectedImageIndex = 2;
            treeNode5.Tag = "4";
            treeNode5.Text = "Категории";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "tnSource";
            treeNode6.SelectedImageIndex = 1;
            treeNode6.Tag = "5";
            treeNode6.Text = "Источники";
            treeNode7.ImageIndex = 10;
            treeNode7.Name = "tnAdditionally";
            treeNode7.SelectedImageIndex = 10;
            treeNode7.Tag = "6";
            treeNode7.Text = "Упоминания";
            treeNode8.Name = "tnCounterparties";
            treeNode8.Tag = "13";
            treeNode8.Text = "Контрагенты";
            treeNode9.ImageIndex = 3;
            treeNode9.Name = "tnCurrencies";
            treeNode9.SelectedImageIndex = 3;
            treeNode9.Tag = "7";
            treeNode9.Text = "Валюты";
            treeNode10.ImageIndex = 2;
            treeNode10.Name = "tnDirectory";
            treeNode10.SelectedImageIndex = 2;
            treeNode10.Tag = "4";
            treeNode10.Text = "Справочники";
            treeNode11.Name = "tnDebtGiven";
            treeNode11.Tag = "11";
            treeNode11.Text = "Выданные";
            treeNode12.Name = "tnDebtReceived";
            treeNode12.Tag = "12";
            treeNode12.Text = "Полученые";
            treeNode13.Name = "tnDebt";
            treeNode13.Tag = "11";
            treeNode13.Text = "Долги";
            treeNode14.ImageIndex = 6;
            treeNode14.Name = "tnReports";
            treeNode14.SelectedImageIndex = 6;
            treeNode14.Tag = "8";
            treeNode14.Text = "Отчеты";
            treeNode15.ImageIndex = 4;
            treeNode15.Name = "tnSettings";
            treeNode15.SelectedImageIndex = 4;
            treeNode15.Tag = "9";
            treeNode15.Text = "Настройки";
            treeNode16.ImageIndex = 0;
            treeNode16.Name = "tnAbout";
            treeNode16.SelectedImageIndex = 0;
            treeNode16.Tag = "10";
            treeNode16.Text = "О программе";
            tvMenuPanel.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode10, treeNode13, treeNode14, treeNode15, treeNode16 });
            tvMenuPanel.SelectedImageIndex = 0;
            tvMenuPanel.ShowLines = false;
            tvMenuPanel.Size = new Size(159, 734);
            tvMenuPanel.TabIndex = 0;
            tvMenuPanel.AfterSelect += tvMenuPanel_AfterSelect;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "about.png");
            imageList1.Images.SetKeyName(1, "source.png");
            imageList1.Images.SetKeyName(2, "category.png");
            imageList1.Images.SetKeyName(3, "currency.png");
            imageList1.Images.SetKeyName(4, "settings.png");
            imageList1.Images.SetKeyName(5, "start.png");
            imageList1.Images.SetKeyName(6, "report.png");
            imageList1.Images.SetKeyName(7, "income.png");
            imageList1.Images.SetKeyName(8, "expence.png");
            imageList1.Images.SetKeyName(9, "Account.png");
            imageList1.Images.SetKeyName(10, "additional.png");
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
            tcPage.Controls.Add(tpDebtGiven);
            tcPage.Controls.Add(tpDebtReceived);
            tcPage.Controls.Add(tbCounterparties);
            tcPage.Dock = DockStyle.Fill;
            tcPage.Location = new Point(0, 0);
            tcPage.Margin = new Padding(3, 4, 3, 4);
            tcPage.Name = "tcPage";
            tcPage.SelectedIndex = 0;
            tcPage.Size = new Size(720, 748);
            tcPage.TabIndex = 0;
            tcPage.SelectedIndexChanged += tcPage_SelectedIndexChanged;
            // 
            // tpStart
            // 
            tpStart.Controls.Add(tableLayoutPanel30);
            tpStart.Location = new Point(4, 29);
            tpStart.Margin = new Padding(3, 4, 3, 4);
            tpStart.Name = "tpStart";
            tpStart.Padding = new Padding(3, 4, 3, 4);
            tpStart.Size = new Size(712, 715);
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
            tableLayoutPanel30.Location = new Point(3, 4);
            tableLayoutPanel30.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel30.Name = "tableLayoutPanel30";
            tableLayoutPanel30.Padding = new Padding(6, 7, 6, 0);
            tableLayoutPanel30.RowCount = 2;
            tableLayoutPanel30.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel30.RowStyles.Add(new RowStyle());
            tableLayoutPanel30.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel30.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel30.Size = new Size(706, 707);
            tableLayoutPanel30.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.ForeColor = Color.Maroon;
            label12.Location = new Point(9, 7);
            label12.Name = "label12";
            label12.Size = new Size(688, 35);
            label12.TabIndex = 0;
            label12.Text = "День недели и дата";
            // 
            // tpAccounts
            // 
            tpAccounts.Controls.Add(tableLayoutPanel18);
            tpAccounts.Controls.Add(tableLayoutPanel2);
            tpAccounts.Location = new Point(4, 29);
            tpAccounts.Margin = new Padding(3, 4, 3, 4);
            tpAccounts.Name = "tpAccounts";
            tpAccounts.Size = new Size(712, 715);
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
            tableLayoutPanel18.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel18.Name = "tableLayoutPanel18";
            tableLayoutPanel18.Padding = new Padding(6, 7, 6, 7);
            tableLayoutPanel18.RowCount = 3;
            tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel18.RowStyles.Add(new RowStyle());
            tableLayoutPanel18.Size = new Size(712, 582);
            tableLayoutPanel18.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(9, 7);
            label9.Name = "label9";
            label9.Size = new Size(694, 35);
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
            flowLayoutPanel3.Location = new Point(9, 46);
            flowLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(6, 7, 6, 7);
            flowLayoutPanel3.Size = new Size(694, 53);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // btnAddAccounts
            // 
            btnAddAccounts.Image = Properties.Resources.PlusIcon;
            btnAddAccounts.Location = new Point(9, 11);
            btnAddAccounts.Margin = new Padding(3, 4, 3, 4);
            btnAddAccounts.Name = "btnAddAccounts";
            btnAddAccounts.Size = new Size(119, 31);
            btnAddAccounts.TabIndex = 0;
            btnAddAccounts.Text = "Добавить";
            btnAddAccounts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddAccounts.UseVisualStyleBackColor = true;
            btnAddAccounts.Click += btnAddAccounts_Click;
            // 
            // btnTransferAccount
            // 
            btnTransferAccount.Image = Properties.Resources.TransferIcon;
            btnTransferAccount.Location = new Point(134, 11);
            btnTransferAccount.Margin = new Padding(3, 4, 3, 4);
            btnTransferAccount.Name = "btnTransferAccount";
            btnTransferAccount.Size = new Size(119, 31);
            btnTransferAccount.TabIndex = 3;
            btnTransferAccount.Text = "Перевод";
            btnTransferAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransferAccount.UseVisualStyleBackColor = true;
            btnTransferAccount.Click += btnTransfer_Click;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Image = Properties.Resources.EditIcon;
            btnEditAccount.Location = new Point(259, 11);
            btnEditAccount.Margin = new Padding(3, 4, 3, 4);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(26, 31);
            btnEditAccount.TabIndex = 1;
            btnEditAccount.UseVisualStyleBackColor = true;
            btnEditAccount.Click += btnEditAccounts_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Image = Properties.Resources.MinusIcon;
            btnDeleteAccount.Location = new Point(291, 11);
            btnDeleteAccount.Margin = new Padding(3, 4, 3, 4);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(26, 31);
            btnDeleteAccount.TabIndex = 2;
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccounts_Click;
            // 
            // btnPrintAccounts
            // 
            btnPrintAccounts.Image = Properties.Resources.PrintIcon;
            btnPrintAccounts.Location = new Point(323, 11);
            btnPrintAccounts.Margin = new Padding(3, 4, 3, 4);
            btnPrintAccounts.Name = "btnPrintAccounts";
            btnPrintAccounts.Size = new Size(26, 31);
            btnPrintAccounts.TabIndex = 4;
            btnPrintAccounts.UseVisualStyleBackColor = true;
            // 
            // dgwAccounts
            // 
            dgwAccounts.AllowUserToAddRows = false;
            dgwAccounts.AllowUserToDeleteRows = false;
            dgwAccounts.AllowUserToOrderColumns = true;
            dgwAccounts.AllowUserToResizeRows = false;
            dgwAccounts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwAccounts.ContextMenuStrip = contextMenu;
            dgwAccounts.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwAccounts.Location = new Point(9, 107);
            dgwAccounts.Margin = new Padding(3, 4, 3, 4);
            dgwAccounts.MultiSelect = false;
            dgwAccounts.Name = "dgwAccounts";
            dgwAccounts.RowHeadersVisible = false;
            dgwAccounts.RowHeadersWidth = 51;
            dgwAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwAccounts.Size = new Size(694, 464);
            dgwAccounts.TabIndex = 2;
            dgwAccounts.CellDoubleClick += dgwAccounts_CellDoubleClick;
            dgwAccounts.CellFormatting += dataGridViewAccounts_CellFormatting;
            dgwAccounts.SelectionChanged += dataGridViewAccounts_SelectionChanged;
            // 
            // contextMenu
            // 
            contextMenu.ImageScalingSize = new Size(20, 20);
            contextMenu.Name = "contextMenu";
            contextMenu.Size = new Size(61, 4);
            contextMenu.Opening += contextMenu_Opening;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(tbDetailsAccount, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 582);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(6, 7, 6, 0);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(712, 133);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 7);
            label2.Name = "label2";
            label2.Size = new Size(107, 40);
            label2.TabIndex = 0;
            label2.Text = "Комментарий:";
            // 
            // tbDetailsAccount
            // 
            tbDetailsAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsAccount.Location = new Point(123, 11);
            tbDetailsAccount.Margin = new Padding(3, 4, 3, 4);
            tbDetailsAccount.Multiline = true;
            tbDetailsAccount.Name = "tbDetailsAccount";
            tbDetailsAccount.ReadOnly = true;
            tbDetailsAccount.Size = new Size(580, 121);
            tbDetailsAccount.TabIndex = 1;
            // 
            // tpExpenses
            // 
            tpExpenses.Controls.Add(tableLayoutPanel19);
            tpExpenses.Controls.Add(tableLayoutPanel3);
            tpExpenses.Location = new Point(4, 29);
            tpExpenses.Margin = new Padding(3, 4, 3, 4);
            tpExpenses.Name = "tpExpenses";
            tpExpenses.Size = new Size(712, 715);
            tpExpenses.TabIndex = 2;
            tpExpenses.Text = "Расходы";
            tpExpenses.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel19
            // 
            tableLayoutPanel19.ColumnCount = 1;
            tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel19.Controls.Add(dgwExpenses, 0, 2);
            tableLayoutPanel19.Controls.Add(lblPageExpensesCaption, 0, 0);
            tableLayoutPanel19.Controls.Add(flowLayoutPanel6, 0, 1);
            tableLayoutPanel19.Dock = DockStyle.Fill;
            tableLayoutPanel19.Location = new Point(0, 0);
            tableLayoutPanel19.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel19.Name = "tableLayoutPanel19";
            tableLayoutPanel19.Padding = new Padding(6, 7, 6, 7);
            tableLayoutPanel19.RowCount = 3;
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel19.RowStyles.Add(new RowStyle());
            tableLayoutPanel19.RowStyles.Add(new RowStyle());
            tableLayoutPanel19.RowStyles.Add(new RowStyle());
            tableLayoutPanel19.Size = new Size(712, 582);
            tableLayoutPanel19.TabIndex = 3;
            // 
            // dgwExpenses
            // 
            dgwExpenses.AllowUserToAddRows = false;
            dgwExpenses.AllowUserToDeleteRows = false;
            dgwExpenses.AllowUserToOrderColumns = true;
            dgwExpenses.AllowUserToResizeRows = false;
            dgwExpenses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwExpenses.ContextMenuStrip = contextMenu;
            dgwExpenses.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwExpenses.Location = new Point(9, 107);
            dgwExpenses.Margin = new Padding(3, 4, 3, 4);
            dgwExpenses.MultiSelect = false;
            dgwExpenses.Name = "dgwExpenses";
            dgwExpenses.RowHeadersVisible = false;
            dgwExpenses.RowHeadersWidth = 51;
            dgwExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwExpenses.Size = new Size(694, 464);
            dgwExpenses.TabIndex = 3;
            dgwExpenses.CellDoubleClick += dgwExpenses_CellDoubleClick;
            dgwExpenses.CellFormatting += dataGridView3_CellFormatting;
            dgwExpenses.SelectionChanged += dataGridViewExpenses_SelectionChanged;
            // 
            // lblPageExpensesCaption
            // 
            lblPageExpensesCaption.AutoSize = true;
            lblPageExpensesCaption.Dock = DockStyle.Fill;
            lblPageExpensesCaption.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPageExpensesCaption.ForeColor = Color.Maroon;
            lblPageExpensesCaption.Location = new Point(9, 7);
            lblPageExpensesCaption.Name = "lblPageExpensesCaption";
            lblPageExpensesCaption.Size = new Size(694, 35);
            lblPageExpensesCaption.TabIndex = 0;
            lblPageExpensesCaption.Text = "Расходы";
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(btnAddExpenses);
            flowLayoutPanel6.Controls.Add(btnEditExpenses1);
            flowLayoutPanel6.Controls.Add(btnEditExpenses);
            flowLayoutPanel6.Controls.Add(btnDeleteExpenses);
            flowLayoutPanel6.Controls.Add(btnPrintExpenses);
            flowLayoutPanel6.Controls.Add(cmbExpenseMonths);
            flowLayoutPanel6.Controls.Add(cmbExpenseYears);
            flowLayoutPanel6.Dock = DockStyle.Fill;
            flowLayoutPanel6.Location = new Point(9, 46);
            flowLayoutPanel6.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Padding = new Padding(6, 7, 6, 7);
            flowLayoutPanel6.Size = new Size(694, 53);
            flowLayoutPanel6.TabIndex = 1;
            // 
            // btnAddExpenses
            // 
            btnAddExpenses.Image = Properties.Resources.PlusIcon;
            btnAddExpenses.Location = new Point(9, 11);
            btnAddExpenses.Margin = new Padding(3, 4, 3, 4);
            btnAddExpenses.Name = "btnAddExpenses";
            btnAddExpenses.Size = new Size(119, 31);
            btnAddExpenses.TabIndex = 0;
            btnAddExpenses.Text = "Добавить";
            btnAddExpenses.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddExpenses.UseVisualStyleBackColor = true;
            btnAddExpenses.Click += btnAddExpenses_Click;
            // 
            // btnEditExpenses1
            // 
            btnEditExpenses1.Image = Properties.Resources.StarIcon;
            btnEditExpenses1.Location = new Point(134, 11);
            btnEditExpenses1.Margin = new Padding(3, 4, 3, 4);
            btnEditExpenses1.Name = "btnEditExpenses1";
            btnEditExpenses1.Size = new Size(119, 31);
            btnEditExpenses1.TabIndex = 1;
            btnEditExpenses1.Text = "Шаблоны";
            btnEditExpenses1.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditExpenses1.UseVisualStyleBackColor = true;
            btnEditExpenses1.Click += btnEditExpenses1_Click;
            // 
            // btnEditExpenses
            // 
            btnEditExpenses.Image = Properties.Resources.EditIcon;
            btnEditExpenses.Location = new Point(259, 11);
            btnEditExpenses.Margin = new Padding(3, 4, 3, 4);
            btnEditExpenses.Name = "btnEditExpenses";
            btnEditExpenses.Size = new Size(26, 31);
            btnEditExpenses.TabIndex = 2;
            btnEditExpenses.UseVisualStyleBackColor = true;
            btnEditExpenses.Click += btnEditExpenses_Click;
            // 
            // btnDeleteExpenses
            // 
            btnDeleteExpenses.Image = Properties.Resources.MinusIcon;
            btnDeleteExpenses.Location = new Point(291, 11);
            btnDeleteExpenses.Margin = new Padding(3, 4, 3, 4);
            btnDeleteExpenses.Name = "btnDeleteExpenses";
            btnDeleteExpenses.Size = new Size(26, 31);
            btnDeleteExpenses.TabIndex = 3;
            btnDeleteExpenses.UseVisualStyleBackColor = true;
            btnDeleteExpenses.Click += btnDeleteExpenses_Click;
            // 
            // btnPrintExpenses
            // 
            btnPrintExpenses.Image = Properties.Resources.PrintIcon;
            btnPrintExpenses.Location = new Point(323, 11);
            btnPrintExpenses.Margin = new Padding(3, 4, 3, 4);
            btnPrintExpenses.Name = "btnPrintExpenses";
            btnPrintExpenses.Size = new Size(26, 31);
            btnPrintExpenses.TabIndex = 6;
            btnPrintExpenses.UseVisualStyleBackColor = true;
            // 
            // cmbExpenseMonths
            // 
            cmbExpenseMonths.FormattingEnabled = true;
            cmbExpenseMonths.Location = new Point(355, 11);
            cmbExpenseMonths.Margin = new Padding(3, 4, 3, 4);
            cmbExpenseMonths.Name = "cmbExpenseMonths";
            cmbExpenseMonths.Size = new Size(95, 28);
            cmbExpenseMonths.TabIndex = 4;
            // 
            // cmbExpenseYears
            // 
            cmbExpenseYears.FormattingEnabled = true;
            cmbExpenseYears.Location = new Point(456, 11);
            cmbExpenseYears.Margin = new Padding(3, 4, 3, 4);
            cmbExpenseYears.Name = "cmbExpenseYears";
            cmbExpenseYears.Size = new Size(91, 28);
            cmbExpenseYears.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(tbDetailsExpenses, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(0, 582);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(6, 7, 6, 0);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(712, 133);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 7);
            label3.Name = "label3";
            label3.Size = new Size(107, 40);
            label3.TabIndex = 0;
            label3.Text = "Комментарий:";
            // 
            // tbDetailsExpenses
            // 
            tbDetailsExpenses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsExpenses.Location = new Point(123, 11);
            tbDetailsExpenses.Margin = new Padding(3, 4, 3, 4);
            tbDetailsExpenses.Multiline = true;
            tbDetailsExpenses.Name = "tbDetailsExpenses";
            tbDetailsExpenses.ReadOnly = true;
            tbDetailsExpenses.Size = new Size(580, 118);
            tbDetailsExpenses.TabIndex = 1;
            // 
            // tpIncome
            // 
            tpIncome.Controls.Add(tableLayoutPanel20);
            tpIncome.Controls.Add(tableLayoutPanel6);
            tpIncome.Location = new Point(4, 29);
            tpIncome.Margin = new Padding(3, 4, 3, 4);
            tpIncome.Name = "tpIncome";
            tpIncome.Size = new Size(712, 715);
            tpIncome.TabIndex = 3;
            tpIncome.Text = "Доходы";
            tpIncome.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel20
            // 
            tableLayoutPanel20.ColumnCount = 1;
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel20.Controls.Add(dgwIncomes, 0, 2);
            tableLayoutPanel20.Controls.Add(lblPageIncomesCaption, 0, 0);
            tableLayoutPanel20.Controls.Add(flowLayoutPanel8, 0, 1);
            tableLayoutPanel20.Dock = DockStyle.Fill;
            tableLayoutPanel20.Location = new Point(0, 0);
            tableLayoutPanel20.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel20.Name = "tableLayoutPanel20";
            tableLayoutPanel20.Padding = new Padding(6, 7, 6, 7);
            tableLayoutPanel20.RowCount = 3;
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel20.RowStyles.Add(new RowStyle());
            tableLayoutPanel20.RowStyles.Add(new RowStyle());
            tableLayoutPanel20.RowStyles.Add(new RowStyle());
            tableLayoutPanel20.Size = new Size(712, 582);
            tableLayoutPanel20.TabIndex = 3;
            // 
            // dgwIncomes
            // 
            dgwIncomes.AllowUserToAddRows = false;
            dgwIncomes.AllowUserToDeleteRows = false;
            dgwIncomes.AllowUserToOrderColumns = true;
            dgwIncomes.AllowUserToResizeRows = false;
            dgwIncomes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwIncomes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwIncomes.ContextMenuStrip = contextMenu;
            dgwIncomes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwIncomes.Location = new Point(9, 107);
            dgwIncomes.Margin = new Padding(3, 4, 3, 4);
            dgwIncomes.MultiSelect = false;
            dgwIncomes.Name = "dgwIncomes";
            dgwIncomes.RowHeadersVisible = false;
            dgwIncomes.RowHeadersWidth = 51;
            dgwIncomes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwIncomes.Size = new Size(694, 464);
            dgwIncomes.TabIndex = 3;
            dgwIncomes.CellDoubleClick += dgwIncomes_CellDoubleClick;
            dgwIncomes.CellFormatting += dgwIncomes_CellFormatting;
            dgwIncomes.SelectionChanged += dataGridViewIncomes_SelectionChanged;
            // 
            // lblPageIncomesCaption
            // 
            lblPageIncomesCaption.AutoSize = true;
            lblPageIncomesCaption.Dock = DockStyle.Fill;
            lblPageIncomesCaption.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPageIncomesCaption.ForeColor = Color.Maroon;
            lblPageIncomesCaption.Location = new Point(9, 7);
            lblPageIncomesCaption.Name = "lblPageIncomesCaption";
            lblPageIncomesCaption.Size = new Size(694, 35);
            lblPageIncomesCaption.TabIndex = 0;
            lblPageIncomesCaption.Text = "Доходы";
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Controls.Add(btnAddIncomes);
            flowLayoutPanel8.Controls.Add(btnEditIncomes);
            flowLayoutPanel8.Controls.Add(btnDeleteIncomes);
            flowLayoutPanel8.Controls.Add(btnPrintIncomes);
            flowLayoutPanel8.Controls.Add(cmbIncomeMonths);
            flowLayoutPanel8.Controls.Add(cmbIncomeYears);
            flowLayoutPanel8.Dock = DockStyle.Fill;
            flowLayoutPanel8.Location = new Point(9, 46);
            flowLayoutPanel8.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Padding = new Padding(6, 7, 6, 7);
            flowLayoutPanel8.Size = new Size(694, 53);
            flowLayoutPanel8.TabIndex = 1;
            // 
            // btnAddIncomes
            // 
            btnAddIncomes.Image = Properties.Resources.PlusIcon;
            btnAddIncomes.Location = new Point(9, 11);
            btnAddIncomes.Margin = new Padding(3, 4, 3, 4);
            btnAddIncomes.Name = "btnAddIncomes";
            btnAddIncomes.Size = new Size(119, 31);
            btnAddIncomes.TabIndex = 0;
            btnAddIncomes.Text = "Добавить";
            btnAddIncomes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddIncomes.UseVisualStyleBackColor = true;
            btnAddIncomes.Click += btnAddIncomes_Click;
            // 
            // btnEditIncomes
            // 
            btnEditIncomes.Image = Properties.Resources.EditIcon;
            btnEditIncomes.Location = new Point(134, 11);
            btnEditIncomes.Margin = new Padding(3, 4, 3, 4);
            btnEditIncomes.Name = "btnEditIncomes";
            btnEditIncomes.Size = new Size(26, 31);
            btnEditIncomes.TabIndex = 1;
            btnEditIncomes.UseVisualStyleBackColor = true;
            btnEditIncomes.Click += btnEditIncomes_Click;
            // 
            // btnDeleteIncomes
            // 
            btnDeleteIncomes.Image = Properties.Resources.MinusIcon;
            btnDeleteIncomes.Location = new Point(166, 11);
            btnDeleteIncomes.Margin = new Padding(3, 4, 3, 4);
            btnDeleteIncomes.Name = "btnDeleteIncomes";
            btnDeleteIncomes.Size = new Size(26, 31);
            btnDeleteIncomes.TabIndex = 2;
            btnDeleteIncomes.UseVisualStyleBackColor = true;
            btnDeleteIncomes.Click += btnDeleteIncomes_Click;
            // 
            // btnPrintIncomes
            // 
            btnPrintIncomes.Image = Properties.Resources.PrintIcon;
            btnPrintIncomes.Location = new Point(198, 11);
            btnPrintIncomes.Margin = new Padding(3, 4, 3, 4);
            btnPrintIncomes.Name = "btnPrintIncomes";
            btnPrintIncomes.Size = new Size(26, 31);
            btnPrintIncomes.TabIndex = 8;
            btnPrintIncomes.UseVisualStyleBackColor = true;
            // 
            // cmbIncomeMonths
            // 
            cmbIncomeMonths.FormattingEnabled = true;
            cmbIncomeMonths.Location = new Point(230, 11);
            cmbIncomeMonths.Margin = new Padding(3, 4, 3, 4);
            cmbIncomeMonths.Name = "cmbIncomeMonths";
            cmbIncomeMonths.Size = new Size(114, 28);
            cmbIncomeMonths.TabIndex = 6;
            // 
            // cmbIncomeYears
            // 
            cmbIncomeYears.FormattingEnabled = true;
            cmbIncomeYears.Location = new Point(350, 11);
            cmbIncomeYears.Margin = new Padding(3, 4, 3, 4);
            cmbIncomeYears.Name = "cmbIncomeYears";
            cmbIncomeYears.Size = new Size(91, 28);
            cmbIncomeYears.TabIndex = 7;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label4, 0, 0);
            tableLayoutPanel6.Controls.Add(tbDetailsIncome, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Bottom;
            tableLayoutPanel6.Location = new Point(0, 582);
            tableLayoutPanel6.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.Padding = new Padding(6, 7, 6, 0);
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.Size = new Size(712, 133);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 7);
            label4.Name = "label4";
            label4.Size = new Size(107, 40);
            label4.TabIndex = 0;
            label4.Text = "Комментарий:";
            // 
            // tbDetailsIncome
            // 
            tbDetailsIncome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsIncome.Location = new Point(123, 11);
            tbDetailsIncome.Margin = new Padding(3, 4, 3, 4);
            tbDetailsIncome.Multiline = true;
            tbDetailsIncome.Name = "tbDetailsIncome";
            tbDetailsIncome.ReadOnly = true;
            tbDetailsIncome.Size = new Size(580, 118);
            tbDetailsIncome.TabIndex = 1;
            // 
            // tpCategory
            // 
            tpCategory.Controls.Add(tableLayoutPanel1);
            tpCategory.Location = new Point(4, 29);
            tpCategory.Margin = new Padding(3, 4, 3, 4);
            tpCategory.Name = "tpCategory";
            tpCategory.Size = new Size(712, 715);
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 141F));
            tableLayoutPanel1.Size = new Size(712, 715);
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
            tableLayoutPanel25.Location = new Point(356, 0);
            tableLayoutPanel25.Margin = new Padding(0);
            tableLayoutPanel25.Name = "tableLayoutPanel25";
            tableLayoutPanel25.Padding = new Padding(6, 7, 6, 7);
            tableLayoutPanel25.RowCount = 3;
            tableLayoutPanel25.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel25.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel25.RowStyles.Add(new RowStyle());
            tableLayoutPanel25.Size = new Size(356, 574);
            tableLayoutPanel25.TabIndex = 4;
            // 
            // dgwSubCategories
            // 
            dgwSubCategories.AllowUserToAddRows = false;
            dgwSubCategories.AllowUserToDeleteRows = false;
            dgwSubCategories.AllowUserToOrderColumns = true;
            dgwSubCategories.AllowUserToResizeRows = false;
            dgwSubCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwSubCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwSubCategories.ContextMenuStrip = contextMenu;
            dgwSubCategories.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwSubCategories.Location = new Point(9, 107);
            dgwSubCategories.Margin = new Padding(3, 4, 3, 4);
            dgwSubCategories.MultiSelect = false;
            dgwSubCategories.Name = "dgwSubCategories";
            dgwSubCategories.RowHeadersVisible = false;
            dgwSubCategories.RowHeadersWidth = 51;
            dgwSubCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwSubCategories.Size = new Size(338, 456);
            dgwSubCategories.TabIndex = 3;
            dgwSubCategories.CellDoubleClick += dgwSubCategories_CellDoubleClick;
            dgwSubCategories.CellFormatting += dataGridViewSubCategories_CellFormatting;
            dgwSubCategories.SelectionChanged += dataGridViewSubCategories_SelectionChanged;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Dock = DockStyle.Fill;
            label33.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label33.ForeColor = Color.Maroon;
            label33.Location = new Point(9, 7);
            label33.Name = "label33";
            label33.Size = new Size(338, 35);
            label33.TabIndex = 0;
            label33.Text = "Подкатегории";
            // 
            // flowLayoutPanel13
            // 
            flowLayoutPanel13.Controls.Add(btnAddSubCategories);
            flowLayoutPanel13.Controls.Add(btnEditSubCategories);
            flowLayoutPanel13.Controls.Add(btnDeleteSubCategories);
            flowLayoutPanel13.Dock = DockStyle.Fill;
            flowLayoutPanel13.Location = new Point(9, 46);
            flowLayoutPanel13.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel13.Name = "flowLayoutPanel13";
            flowLayoutPanel13.Padding = new Padding(6, 7, 6, 7);
            flowLayoutPanel13.Size = new Size(338, 53);
            flowLayoutPanel13.TabIndex = 1;
            // 
            // btnAddSubCategories
            // 
            btnAddSubCategories.Image = Properties.Resources.PlusIcon;
            btnAddSubCategories.Location = new Point(9, 11);
            btnAddSubCategories.Margin = new Padding(3, 4, 3, 4);
            btnAddSubCategories.Name = "btnAddSubCategories";
            btnAddSubCategories.Size = new Size(119, 31);
            btnAddSubCategories.TabIndex = 0;
            btnAddSubCategories.Text = "Добавить";
            btnAddSubCategories.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddSubCategories.UseVisualStyleBackColor = true;
            btnAddSubCategories.Click += btnAddSubCategories_Click;
            // 
            // btnEditSubCategories
            // 
            btnEditSubCategories.Image = Properties.Resources.EditIcon;
            btnEditSubCategories.Location = new Point(134, 11);
            btnEditSubCategories.Margin = new Padding(3, 4, 3, 4);
            btnEditSubCategories.Name = "btnEditSubCategories";
            btnEditSubCategories.Size = new Size(26, 31);
            btnEditSubCategories.TabIndex = 1;
            btnEditSubCategories.UseVisualStyleBackColor = true;
            btnEditSubCategories.Click += btnEditSubCategories_Click;
            // 
            // btnDeleteSubCategories
            // 
            btnDeleteSubCategories.Image = Properties.Resources.MinusIcon;
            btnDeleteSubCategories.Location = new Point(166, 11);
            btnDeleteSubCategories.Margin = new Padding(3, 4, 3, 4);
            btnDeleteSubCategories.Name = "btnDeleteSubCategories";
            btnDeleteSubCategories.Size = new Size(26, 31);
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
            tableLayoutPanel24.Padding = new Padding(6, 7, 6, 7);
            tableLayoutPanel24.RowCount = 3;
            tableLayoutPanel24.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel24.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel24.RowStyles.Add(new RowStyle());
            tableLayoutPanel24.Size = new Size(356, 574);
            tableLayoutPanel24.TabIndex = 3;
            // 
            // dgwCategorie
            // 
            dgwCategorie.AllowUserToAddRows = false;
            dgwCategorie.AllowUserToDeleteRows = false;
            dgwCategorie.AllowUserToOrderColumns = true;
            dgwCategorie.AllowUserToResizeRows = false;
            dgwCategorie.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwCategorie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCategorie.ContextMenuStrip = contextMenu;
            dgwCategorie.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwCategorie.Location = new Point(9, 107);
            dgwCategorie.Margin = new Padding(3, 4, 3, 4);
            dgwCategorie.MultiSelect = false;
            dgwCategorie.Name = "dgwCategorie";
            dgwCategorie.RowHeadersVisible = false;
            dgwCategorie.RowHeadersWidth = 51;
            dgwCategorie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwCategorie.Size = new Size(338, 456);
            dgwCategorie.TabIndex = 3;
            dgwCategorie.CellDoubleClick += dgwCategorie_CellDoubleClick;
            dgwCategorie.SelectionChanged += dataGridViewCategories_SelectionChanged;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Dock = DockStyle.Fill;
            label32.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label32.ForeColor = Color.Maroon;
            label32.Location = new Point(9, 7);
            label32.Name = "label32";
            label32.Size = new Size(338, 35);
            label32.TabIndex = 0;
            label32.Text = "Категории";
            // 
            // flowLayoutPanel12
            // 
            flowLayoutPanel12.Controls.Add(btnAddCategories);
            flowLayoutPanel12.Controls.Add(btnEditCategories);
            flowLayoutPanel12.Controls.Add(btnDeleteCategories);
            flowLayoutPanel12.Dock = DockStyle.Fill;
            flowLayoutPanel12.Location = new Point(9, 46);
            flowLayoutPanel12.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel12.Name = "flowLayoutPanel12";
            flowLayoutPanel12.Padding = new Padding(6, 7, 6, 7);
            flowLayoutPanel12.Size = new Size(338, 53);
            flowLayoutPanel12.TabIndex = 1;
            // 
            // btnAddCategories
            // 
            btnAddCategories.Image = Properties.Resources.PlusIcon;
            btnAddCategories.Location = new Point(9, 11);
            btnAddCategories.Margin = new Padding(3, 4, 3, 4);
            btnAddCategories.Name = "btnAddCategories";
            btnAddCategories.Size = new Size(119, 31);
            btnAddCategories.TabIndex = 0;
            btnAddCategories.Text = "Добавить";
            btnAddCategories.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddCategories.UseVisualStyleBackColor = true;
            btnAddCategories.Click += btnAddCategories_Click;
            // 
            // btnEditCategories
            // 
            btnEditCategories.Image = Properties.Resources.EditIcon;
            btnEditCategories.Location = new Point(134, 11);
            btnEditCategories.Margin = new Padding(3, 4, 3, 4);
            btnEditCategories.Name = "btnEditCategories";
            btnEditCategories.Size = new Size(26, 31);
            btnEditCategories.TabIndex = 1;
            btnEditCategories.UseVisualStyleBackColor = true;
            btnEditCategories.Click += btnEditCategories_Click;
            // 
            // btnDeleteCategories
            // 
            btnDeleteCategories.Image = Properties.Resources.MinusIcon;
            btnDeleteCategories.Location = new Point(166, 11);
            btnDeleteCategories.Margin = new Padding(3, 4, 3, 4);
            btnDeleteCategories.Name = "btnDeleteCategories";
            btnDeleteCategories.Size = new Size(26, 31);
            btnDeleteCategories.TabIndex = 2;
            btnDeleteCategories.UseVisualStyleBackColor = true;
            btnDeleteCategories.Click += btnDeleteCategories_Click;
            // 
            // tableLayoutPanel17
            // 
            tableLayoutPanel17.ColumnCount = 2;
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel17.Controls.Add(label8, 0, 0);
            tableLayoutPanel17.Controls.Add(tbDetailsSubCategory, 1, 0);
            tableLayoutPanel17.Dock = DockStyle.Fill;
            tableLayoutPanel17.Location = new Point(359, 578);
            tableLayoutPanel17.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel17.Name = "tableLayoutPanel17";
            tableLayoutPanel17.Padding = new Padding(6, 7, 6, 0);
            tableLayoutPanel17.RowCount = 1;
            tableLayoutPanel17.RowStyles.Add(new RowStyle());
            tableLayoutPanel17.Size = new Size(350, 133);
            tableLayoutPanel17.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 7);
            label8.Name = "label8";
            label8.Size = new Size(107, 40);
            label8.TabIndex = 0;
            label8.Text = "Комментарий:";
            // 
            // tbDetailsSubCategory
            // 
            tbDetailsSubCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsSubCategory.Location = new Point(123, 11);
            tbDetailsSubCategory.Margin = new Padding(3, 4, 3, 0);
            tbDetailsSubCategory.Multiline = true;
            tbDetailsSubCategory.Name = "tbDetailsSubCategory";
            tbDetailsSubCategory.ReadOnly = true;
            tbDetailsSubCategory.Size = new Size(218, 122);
            tbDetailsSubCategory.TabIndex = 1;
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.ColumnCount = 2;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel16.Controls.Add(label1, 0, 0);
            tableLayoutPanel16.Controls.Add(tbDetailsCategory, 1, 0);
            tableLayoutPanel16.Dock = DockStyle.Fill;
            tableLayoutPanel16.Location = new Point(3, 578);
            tableLayoutPanel16.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.Padding = new Padding(6, 7, 6, 0);
            tableLayoutPanel16.RowCount = 1;
            tableLayoutPanel16.RowStyles.Add(new RowStyle());
            tableLayoutPanel16.Size = new Size(350, 133);
            tableLayoutPanel16.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 7);
            label1.Name = "label1";
            label1.Size = new Size(107, 40);
            label1.TabIndex = 0;
            label1.Text = "Комментарий:";
            // 
            // tbDetailsCategory
            // 
            tbDetailsCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsCategory.Location = new Point(123, 11);
            tbDetailsCategory.Margin = new Padding(3, 4, 3, 0);
            tbDetailsCategory.Multiline = true;
            tbDetailsCategory.Name = "tbDetailsCategory";
            tbDetailsCategory.ReadOnly = true;
            tbDetailsCategory.Size = new Size(218, 122);
            tbDetailsCategory.TabIndex = 1;
            // 
            // tpSource
            // 
            tpSource.Controls.Add(tableLayoutPanel21);
            tpSource.Controls.Add(tableLayoutPanel9);
            tpSource.Location = new Point(4, 29);
            tpSource.Margin = new Padding(3, 4, 3, 4);
            tpSource.Name = "tpSource";
            tpSource.Size = new Size(712, 715);
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
            tableLayoutPanel21.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel21.Name = "tableLayoutPanel21";
            tableLayoutPanel21.Padding = new Padding(6, 7, 6, 7);
            tableLayoutPanel21.RowCount = 3;
            tableLayoutPanel21.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel21.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel21.RowStyles.Add(new RowStyle());
            tableLayoutPanel21.Size = new Size(712, 582);
            tableLayoutPanel21.TabIndex = 3;
            // 
            // dgwSource
            // 
            dgwSource.AllowUserToAddRows = false;
            dgwSource.AllowUserToDeleteRows = false;
            dgwSource.AllowUserToOrderColumns = true;
            dgwSource.AllowUserToResizeRows = false;
            dgwSource.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwSource.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwSource.ContextMenuStrip = contextMenu;
            dgwSource.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwSource.Location = new Point(9, 107);
            dgwSource.Margin = new Padding(3, 4, 3, 4);
            dgwSource.MultiSelect = false;
            dgwSource.Name = "dgwSource";
            dgwSource.RowHeadersVisible = false;
            dgwSource.RowHeadersWidth = 51;
            dgwSource.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwSource.Size = new Size(694, 464);
            dgwSource.TabIndex = 3;
            dgwSource.CellDoubleClick += dgwSource_CellDoubleClick;
            dgwSource.SelectionChanged += dataGridViewSources_SelectionChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Dock = DockStyle.Fill;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label22.ForeColor = Color.Maroon;
            label22.Location = new Point(9, 7);
            label22.Name = "label22";
            label22.Size = new Size(694, 35);
            label22.TabIndex = 0;
            label22.Text = "Источники";
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.Controls.Add(btnAddSources);
            flowLayoutPanel9.Controls.Add(btnEditSources);
            flowLayoutPanel9.Controls.Add(btnDeleteSources);
            flowLayoutPanel9.Dock = DockStyle.Fill;
            flowLayoutPanel9.Location = new Point(9, 46);
            flowLayoutPanel9.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Padding = new Padding(6, 7, 6, 7);
            flowLayoutPanel9.Size = new Size(694, 53);
            flowLayoutPanel9.TabIndex = 1;
            // 
            // btnAddSources
            // 
            btnAddSources.Image = Properties.Resources.PlusIcon;
            btnAddSources.Location = new Point(9, 11);
            btnAddSources.Margin = new Padding(3, 4, 3, 4);
            btnAddSources.Name = "btnAddSources";
            btnAddSources.Size = new Size(119, 31);
            btnAddSources.TabIndex = 0;
            btnAddSources.Text = "Добавить";
            btnAddSources.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddSources.UseVisualStyleBackColor = true;
            btnAddSources.Click += btnAddSources_Click;
            // 
            // btnEditSources
            // 
            btnEditSources.Image = Properties.Resources.EditIcon;
            btnEditSources.Location = new Point(134, 11);
            btnEditSources.Margin = new Padding(3, 4, 3, 4);
            btnEditSources.Name = "btnEditSources";
            btnEditSources.Size = new Size(26, 31);
            btnEditSources.TabIndex = 1;
            btnEditSources.UseVisualStyleBackColor = true;
            btnEditSources.Click += btnEditSources_Click;
            // 
            // btnDeleteSources
            // 
            btnDeleteSources.Image = Properties.Resources.MinusIcon;
            btnDeleteSources.Location = new Point(166, 11);
            btnDeleteSources.Margin = new Padding(3, 4, 3, 4);
            btnDeleteSources.Name = "btnDeleteSources";
            btnDeleteSources.Size = new Size(26, 31);
            btnDeleteSources.TabIndex = 2;
            btnDeleteSources.UseVisualStyleBackColor = true;
            btnDeleteSources.Click += btnDeleteSources_Click;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(label5, 0, 0);
            tableLayoutPanel9.Controls.Add(tbDetailsSource, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Bottom;
            tableLayoutPanel9.Location = new Point(0, 582);
            tableLayoutPanel9.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.Padding = new Padding(6, 7, 6, 0);
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle());
            tableLayoutPanel9.Size = new Size(712, 133);
            tableLayoutPanel9.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 7);
            label5.Name = "label5";
            label5.Size = new Size(107, 40);
            label5.TabIndex = 0;
            label5.Text = "Комментарий:";
            // 
            // tbDetailsSource
            // 
            tbDetailsSource.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsSource.Location = new Point(123, 11);
            tbDetailsSource.Margin = new Padding(3, 4, 3, 4);
            tbDetailsSource.Multiline = true;
            tbDetailsSource.Name = "tbDetailsSource";
            tbDetailsSource.ReadOnly = true;
            tbDetailsSource.Size = new Size(580, 118);
            tbDetailsSource.TabIndex = 1;
            // 
            // tpAdditionally
            // 
            tpAdditionally.Controls.Add(tableLayoutPanel22);
            tpAdditionally.Controls.Add(tableLayoutPanel11);
            tpAdditionally.Location = new Point(4, 29);
            tpAdditionally.Margin = new Padding(3, 4, 3, 4);
            tpAdditionally.Name = "tpAdditionally";
            tpAdditionally.Size = new Size(712, 715);
            tpAdditionally.TabIndex = 6;
            tpAdditionally.Text = "Упоминания";
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
            tableLayoutPanel22.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel22.Name = "tableLayoutPanel22";
            tableLayoutPanel22.Padding = new Padding(6, 7, 6, 7);
            tableLayoutPanel22.RowCount = 3;
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel22.RowStyles.Add(new RowStyle());
            tableLayoutPanel22.Size = new Size(712, 582);
            tableLayoutPanel22.TabIndex = 3;
            // 
            // dgwAdditionals
            // 
            dgwAdditionals.AllowUserToAddRows = false;
            dgwAdditionals.AllowUserToDeleteRows = false;
            dgwAdditionals.AllowUserToOrderColumns = true;
            dgwAdditionals.AllowUserToResizeRows = false;
            dgwAdditionals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwAdditionals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwAdditionals.ContextMenuStrip = contextMenu;
            dgwAdditionals.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwAdditionals.Location = new Point(9, 107);
            dgwAdditionals.Margin = new Padding(3, 4, 3, 4);
            dgwAdditionals.MultiSelect = false;
            dgwAdditionals.Name = "dgwAdditionals";
            dgwAdditionals.RowHeadersVisible = false;
            dgwAdditionals.RowHeadersWidth = 51;
            dgwAdditionals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwAdditionals.Size = new Size(694, 464);
            dgwAdditionals.TabIndex = 3;
            dgwAdditionals.CellDoubleClick += dgwAdditionals_CellDoubleClick;
            dgwAdditionals.SelectionChanged += dataGridViewAdditionals_SelectionChanged;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Dock = DockStyle.Fill;
            label29.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label29.ForeColor = Color.Maroon;
            label29.Location = new Point(9, 7);
            label29.Name = "label29";
            label29.Size = new Size(694, 35);
            label29.TabIndex = 0;
            label29.Text = "Упоминания";
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.Controls.Add(btnAddAdditionals);
            flowLayoutPanel10.Controls.Add(btnEditAdditionals);
            flowLayoutPanel10.Controls.Add(btnDeleteAdditional);
            flowLayoutPanel10.Dock = DockStyle.Fill;
            flowLayoutPanel10.Location = new Point(9, 46);
            flowLayoutPanel10.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Padding = new Padding(6, 7, 6, 7);
            flowLayoutPanel10.Size = new Size(694, 53);
            flowLayoutPanel10.TabIndex = 1;
            // 
            // btnAddAdditionals
            // 
            btnAddAdditionals.Image = Properties.Resources.PlusIcon;
            btnAddAdditionals.Location = new Point(9, 11);
            btnAddAdditionals.Margin = new Padding(3, 4, 3, 4);
            btnAddAdditionals.Name = "btnAddAdditionals";
            btnAddAdditionals.Size = new Size(119, 31);
            btnAddAdditionals.TabIndex = 0;
            btnAddAdditionals.Text = "Добавить";
            btnAddAdditionals.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddAdditionals.UseVisualStyleBackColor = true;
            btnAddAdditionals.Click += btnAddAdditionals_Click;
            // 
            // btnEditAdditionals
            // 
            btnEditAdditionals.Image = Properties.Resources.EditIcon;
            btnEditAdditionals.Location = new Point(134, 11);
            btnEditAdditionals.Margin = new Padding(3, 4, 3, 4);
            btnEditAdditionals.Name = "btnEditAdditionals";
            btnEditAdditionals.Size = new Size(26, 31);
            btnEditAdditionals.TabIndex = 1;
            btnEditAdditionals.UseVisualStyleBackColor = true;
            btnEditAdditionals.Click += btnEditAdditionals_Click;
            // 
            // btnDeleteAdditional
            // 
            btnDeleteAdditional.Image = Properties.Resources.MinusIcon;
            btnDeleteAdditional.Location = new Point(166, 11);
            btnDeleteAdditional.Margin = new Padding(3, 4, 3, 4);
            btnDeleteAdditional.Name = "btnDeleteAdditional";
            btnDeleteAdditional.Size = new Size(26, 31);
            btnDeleteAdditional.TabIndex = 2;
            btnDeleteAdditional.UseVisualStyleBackColor = true;
            btnDeleteAdditional.Click += btnDeleteAdditionals_Click;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Controls.Add(label6, 0, 0);
            tableLayoutPanel11.Controls.Add(tbDetailsAdditional, 1, 0);
            tableLayoutPanel11.Dock = DockStyle.Bottom;
            tableLayoutPanel11.Location = new Point(0, 582);
            tableLayoutPanel11.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.Padding = new Padding(6, 7, 6, 0);
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle());
            tableLayoutPanel11.Size = new Size(712, 133);
            tableLayoutPanel11.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 7);
            label6.Name = "label6";
            label6.Size = new Size(107, 40);
            label6.TabIndex = 0;
            label6.Text = "Комментарий:";
            // 
            // tbDetailsAdditional
            // 
            tbDetailsAdditional.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsAdditional.Location = new Point(123, 11);
            tbDetailsAdditional.Margin = new Padding(3, 4, 3, 4);
            tbDetailsAdditional.Multiline = true;
            tbDetailsAdditional.Name = "tbDetailsAdditional";
            tbDetailsAdditional.ReadOnly = true;
            tbDetailsAdditional.Size = new Size(580, 118);
            tbDetailsAdditional.TabIndex = 1;
            // 
            // tpCurrencies
            // 
            tpCurrencies.Controls.Add(tableLayoutPanel23);
            tpCurrencies.Controls.Add(tableLayoutPanel14);
            tpCurrencies.Location = new Point(4, 29);
            tpCurrencies.Margin = new Padding(3, 4, 3, 4);
            tpCurrencies.Name = "tpCurrencies";
            tpCurrencies.Size = new Size(712, 715);
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
            tableLayoutPanel23.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel23.Name = "tableLayoutPanel23";
            tableLayoutPanel23.Padding = new Padding(6, 7, 6, 7);
            tableLayoutPanel23.RowCount = 3;
            tableLayoutPanel23.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel23.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel23.RowStyles.Add(new RowStyle());
            tableLayoutPanel23.Size = new Size(712, 582);
            tableLayoutPanel23.TabIndex = 3;
            // 
            // dgwCurrencies
            // 
            dgwCurrencies.AllowUserToAddRows = false;
            dgwCurrencies.AllowUserToDeleteRows = false;
            dgwCurrencies.AllowUserToOrderColumns = true;
            dgwCurrencies.AllowUserToResizeRows = false;
            dgwCurrencies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwCurrencies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCurrencies.ContextMenuStrip = contextMenu;
            dgwCurrencies.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwCurrencies.Location = new Point(9, 107);
            dgwCurrencies.Margin = new Padding(3, 4, 3, 4);
            dgwCurrencies.MultiSelect = false;
            dgwCurrencies.Name = "dgwCurrencies";
            dgwCurrencies.RowHeadersVisible = false;
            dgwCurrencies.RowHeadersWidth = 51;
            dgwCurrencies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwCurrencies.Size = new Size(694, 464);
            dgwCurrencies.TabIndex = 3;
            dgwCurrencies.CellDoubleClick += dgwCurrencies_CellDoubleClick;
            dgwCurrencies.SelectionChanged += dataGridViewCurrencies_SelectionChanged;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Dock = DockStyle.Fill;
            label31.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label31.ForeColor = Color.Maroon;
            label31.Location = new Point(9, 7);
            label31.Name = "label31";
            label31.Size = new Size(694, 35);
            label31.TabIndex = 0;
            label31.Text = "Валюты";
            // 
            // flowLayoutPanel11
            // 
            flowLayoutPanel11.Controls.Add(btnAddCurrency);
            flowLayoutPanel11.Controls.Add(btnEditCurrency);
            flowLayoutPanel11.Controls.Add(btnDeleteCurrency);
            flowLayoutPanel11.Dock = DockStyle.Fill;
            flowLayoutPanel11.Location = new Point(9, 46);
            flowLayoutPanel11.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel11.Name = "flowLayoutPanel11";
            flowLayoutPanel11.Padding = new Padding(6, 7, 6, 7);
            flowLayoutPanel11.Size = new Size(694, 53);
            flowLayoutPanel11.TabIndex = 1;
            // 
            // btnAddCurrency
            // 
            btnAddCurrency.Image = Properties.Resources.PlusIcon;
            btnAddCurrency.Location = new Point(9, 11);
            btnAddCurrency.Margin = new Padding(3, 4, 3, 4);
            btnAddCurrency.Name = "btnAddCurrency";
            btnAddCurrency.Size = new Size(119, 31);
            btnAddCurrency.TabIndex = 0;
            btnAddCurrency.Text = "Добавить";
            btnAddCurrency.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddCurrency.UseVisualStyleBackColor = true;
            btnAddCurrency.Click += btnAddCurrencie_Click;
            // 
            // btnEditCurrency
            // 
            btnEditCurrency.Image = Properties.Resources.EditIcon;
            btnEditCurrency.Location = new Point(134, 11);
            btnEditCurrency.Margin = new Padding(3, 4, 3, 4);
            btnEditCurrency.Name = "btnEditCurrency";
            btnEditCurrency.Size = new Size(26, 31);
            btnEditCurrency.TabIndex = 1;
            btnEditCurrency.UseVisualStyleBackColor = true;
            btnEditCurrency.Click += btnEditCurrencie_Click;
            // 
            // btnDeleteCurrency
            // 
            btnDeleteCurrency.Image = Properties.Resources.MinusIcon;
            btnDeleteCurrency.Location = new Point(166, 11);
            btnDeleteCurrency.Margin = new Padding(3, 4, 3, 4);
            btnDeleteCurrency.Name = "btnDeleteCurrency";
            btnDeleteCurrency.Size = new Size(26, 31);
            btnDeleteCurrency.TabIndex = 2;
            btnDeleteCurrency.UseVisualStyleBackColor = true;
            btnDeleteCurrency.Click += btnDeleteCurrencie_Click;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 2;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.Controls.Add(label7, 0, 0);
            tableLayoutPanel14.Controls.Add(tbDetailsCurrency, 1, 0);
            tableLayoutPanel14.Dock = DockStyle.Bottom;
            tableLayoutPanel14.Location = new Point(0, 582);
            tableLayoutPanel14.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.Padding = new Padding(6, 7, 6, 0);
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle());
            tableLayoutPanel14.Size = new Size(712, 133);
            tableLayoutPanel14.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 7);
            label7.Name = "label7";
            label7.Size = new Size(107, 40);
            label7.TabIndex = 0;
            label7.Text = "Комментарий:";
            // 
            // tbDetailsCurrency
            // 
            tbDetailsCurrency.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsCurrency.Location = new Point(123, 11);
            tbDetailsCurrency.Margin = new Padding(3, 4, 3, 4);
            tbDetailsCurrency.Multiline = true;
            tbDetailsCurrency.Name = "tbDetailsCurrency";
            tbDetailsCurrency.ReadOnly = true;
            tbDetailsCurrency.Size = new Size(580, 118);
            tbDetailsCurrency.TabIndex = 1;
            // 
            // tpReport
            // 
            tpReport.Controls.Add(tableLayoutPanel26);
            tpReport.Location = new Point(4, 29);
            tpReport.Margin = new Padding(3, 4, 3, 4);
            tpReport.Name = "tpReport";
            tpReport.Size = new Size(712, 715);
            tpReport.TabIndex = 8;
            tpReport.Text = "Отчеты";
            tpReport.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel26
            // 
            tableLayoutPanel26.ColumnCount = 1;
            tableLayoutPanel26.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel26.Controls.Add(plotView1, 0, 8);
            tableLayoutPanel26.Controls.Add(label34, 0, 0);
            tableLayoutPanel26.Controls.Add(filterPanel, 0, 2);
            tableLayoutPanel26.Controls.Add(pnlFilters, 0, 3);
            tableLayoutPanel26.Controls.Add(flPanel3, 0, 4);
            tableLayoutPanel26.Controls.Add(flPanel4, 0, 5);
            tableLayoutPanel26.Controls.Add(flPanel5, 0, 6);
            tableLayoutPanel26.Controls.Add(flPanel6, 0, 7);
            tableLayoutPanel26.Controls.Add(flowLayoutPanel14, 0, 1);
            tableLayoutPanel26.Dock = DockStyle.Fill;
            tableLayoutPanel26.Location = new Point(0, 0);
            tableLayoutPanel26.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel26.Name = "tableLayoutPanel26";
            tableLayoutPanel26.Padding = new Padding(6, 7, 6, 7);
            tableLayoutPanel26.RowCount = 9;
            tableLayoutPanel26.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel26.RowStyles.Add(new RowStyle());
            tableLayoutPanel26.RowStyles.Add(new RowStyle());
            tableLayoutPanel26.RowStyles.Add(new RowStyle());
            tableLayoutPanel26.RowStyles.Add(new RowStyle());
            tableLayoutPanel26.RowStyles.Add(new RowStyle());
            tableLayoutPanel26.RowStyles.Add(new RowStyle());
            tableLayoutPanel26.RowStyles.Add(new RowStyle());
            tableLayoutPanel26.RowStyles.Add(new RowStyle());
            tableLayoutPanel26.Size = new Size(712, 715);
            tableLayoutPanel26.TabIndex = 4;
            // 
            // plotView1
            // 
            plotView1.Dock = DockStyle.Fill;
            plotView1.Location = new Point(9, 357);
            plotView1.Margin = new Padding(3, 4, 3, 4);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(694, 347);
            plotView1.TabIndex = 18;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Dock = DockStyle.Fill;
            label34.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label34.ForeColor = Color.Maroon;
            label34.Location = new Point(9, 7);
            label34.Name = "label34";
            label34.Size = new Size(694, 35);
            label34.TabIndex = 0;
            label34.Text = "Отчеты";
            // 
            // filterPanel
            // 
            filterPanel.Controls.Add(label35);
            filterPanel.Controls.Add(dtpStartReportDate);
            filterPanel.Controls.Add(label13);
            filterPanel.Controls.Add(dtpEndReportDate);
            filterPanel.Dock = DockStyle.Fill;
            filterPanel.Location = new Point(9, 93);
            filterPanel.Margin = new Padding(3, 4, 3, 4);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(694, 36);
            filterPanel.TabIndex = 9;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Dock = DockStyle.Fill;
            label35.Location = new Point(3, 0);
            label35.Name = "label35";
            label35.Size = new Size(87, 35);
            label35.TabIndex = 0;
            label35.Text = "Период:  с-";
            label35.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpStartReportDate
            // 
            dtpStartReportDate.Location = new Point(96, 4);
            dtpStartReportDate.Margin = new Padding(3, 4, 3, 4);
            dtpStartReportDate.Name = "dtpStartReportDate";
            dtpStartReportDate.Size = new Size(147, 27);
            dtpStartReportDate.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Location = new Point(249, 0);
            label13.Name = "label13";
            label13.Size = new Size(41, 35);
            label13.TabIndex = 16;
            label13.Text = " по- ";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpEndReportDate
            // 
            dtpEndReportDate.Location = new Point(296, 4);
            dtpEndReportDate.Margin = new Padding(3, 4, 3, 4);
            dtpEndReportDate.Name = "dtpEndReportDate";
            dtpEndReportDate.Size = new Size(147, 27);
            dtpEndReportDate.TabIndex = 15;
            // 
            // pnlFilters
            // 
            pnlFilters.Controls.Add(label36);
            pnlFilters.Dock = DockStyle.Fill;
            pnlFilters.Location = new Point(9, 137);
            pnlFilters.Margin = new Padding(3, 4, 3, 4);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(694, 36);
            pnlFilters.TabIndex = 10;
            pnlFilters.Visible = false;
            // 
            // label36
            // 
            label36.Location = new Point(3, 0);
            label36.Name = "label36";
            label36.Size = new Size(50, 39);
            label36.TabIndex = 0;
            label36.Text = "label36";
            label36.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flPanel3
            // 
            flPanel3.Controls.Add(label37);
            flPanel3.Dock = DockStyle.Fill;
            flPanel3.Location = new Point(9, 181);
            flPanel3.Margin = new Padding(3, 4, 3, 4);
            flPanel3.Name = "flPanel3";
            flPanel3.Size = new Size(694, 36);
            flPanel3.TabIndex = 11;
            flPanel3.Visible = false;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(3, 0);
            label37.Name = "label37";
            label37.Size = new Size(58, 20);
            label37.TabIndex = 0;
            label37.Text = "label37";
            // 
            // flPanel4
            // 
            flPanel4.Controls.Add(label38);
            flPanel4.Dock = DockStyle.Fill;
            flPanel4.Location = new Point(9, 225);
            flPanel4.Margin = new Padding(3, 4, 3, 4);
            flPanel4.Name = "flPanel4";
            flPanel4.Size = new Size(694, 36);
            flPanel4.TabIndex = 12;
            flPanel4.Visible = false;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(3, 0);
            label38.Name = "label38";
            label38.Size = new Size(58, 20);
            label38.TabIndex = 0;
            label38.Text = "label38";
            // 
            // flPanel5
            // 
            flPanel5.Controls.Add(label39);
            flPanel5.Dock = DockStyle.Fill;
            flPanel5.Location = new Point(9, 269);
            flPanel5.Margin = new Padding(3, 4, 3, 4);
            flPanel5.Name = "flPanel5";
            flPanel5.Size = new Size(694, 36);
            flPanel5.TabIndex = 13;
            flPanel5.Visible = false;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(3, 0);
            label39.Name = "label39";
            label39.Size = new Size(58, 20);
            label39.TabIndex = 0;
            label39.Text = "label39";
            // 
            // flPanel6
            // 
            flPanel6.Controls.Add(label40);
            flPanel6.Dock = DockStyle.Fill;
            flPanel6.Location = new Point(9, 313);
            flPanel6.Margin = new Padding(3, 4, 3, 4);
            flPanel6.Name = "flPanel6";
            flPanel6.Size = new Size(694, 36);
            flPanel6.TabIndex = 14;
            flPanel6.Visible = false;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(3, 0);
            label40.Name = "label40";
            label40.Size = new Size(58, 20);
            label40.TabIndex = 0;
            label40.Text = "label40";
            // 
            // flowLayoutPanel14
            // 
            flowLayoutPanel14.AutoSize = true;
            flowLayoutPanel14.Controls.Add(cmbReports);
            flowLayoutPanel14.Controls.Add(btnRefresh);
            flowLayoutPanel14.Controls.Add(button3);
            flowLayoutPanel14.Dock = DockStyle.Fill;
            flowLayoutPanel14.Location = new Point(9, 46);
            flowLayoutPanel14.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel14.Name = "flowLayoutPanel14";
            flowLayoutPanel14.Size = new Size(694, 39);
            flowLayoutPanel14.TabIndex = 15;
            // 
            // cmbReports
            // 
            cmbReports.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReports.FormattingEnabled = true;
            cmbReports.Location = new Point(3, 4);
            cmbReports.Margin = new Padding(3, 4, 3, 4);
            cmbReports.Name = "cmbReports";
            cmbReports.Size = new Size(267, 28);
            cmbReports.TabIndex = 9;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = Properties.Resources.RefreshIcon;
            btnRefresh.Location = new Point(276, 4);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(26, 31);
            btnRefresh.TabIndex = 14;
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.PrintIcon;
            button3.Location = new Point(308, 4);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(26, 31);
            button3.TabIndex = 11;
            button3.UseVisualStyleBackColor = true;
            // 
            // tpSettings
            // 
            tpSettings.Controls.Add(tableLayoutPanel29);
            tpSettings.Location = new Point(4, 29);
            tpSettings.Margin = new Padding(3, 4, 3, 4);
            tpSettings.Name = "tpSettings";
            tpSettings.Size = new Size(712, 715);
            tpSettings.TabIndex = 9;
            tpSettings.Text = "Настройки";
            tpSettings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel29
            // 
            tableLayoutPanel29.ColumnCount = 1;
            tableLayoutPanel29.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel29.Controls.Add(label11, 0, 0);
            tableLayoutPanel29.Controls.Add(panel1, 0, 1);
            tableLayoutPanel29.Dock = DockStyle.Fill;
            tableLayoutPanel29.Location = new Point(0, 0);
            tableLayoutPanel29.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel29.Name = "tableLayoutPanel29";
            tableLayoutPanel29.Padding = new Padding(6, 7, 6, 7);
            tableLayoutPanel29.RowCount = 2;
            tableLayoutPanel29.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel29.RowStyles.Add(new RowStyle());
            tableLayoutPanel29.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel29.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel29.Size = new Size(712, 715);
            tableLayoutPanel29.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.Maroon;
            label11.Location = new Point(9, 7);
            label11.Name = "label11";
            label11.Size = new Size(694, 35);
            label11.TabIndex = 0;
            label11.Text = "Настройки";
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox1);
            panel1.Location = new Point(9, 46);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 407);
            panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(26, 31);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(252, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Показывать поле комментарий";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // tpAbout
            // 
            tpAbout.Controls.Add(tableLayoutPanel27);
            tpAbout.Location = new Point(4, 29);
            tpAbout.Margin = new Padding(3, 4, 3, 4);
            tpAbout.Name = "tpAbout";
            tpAbout.Size = new Size(712, 715);
            tpAbout.TabIndex = 10;
            tpAbout.Text = "О программе";
            tpAbout.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel27
            // 
            tableLayoutPanel27.ColumnCount = 1;
            tableLayoutPanel27.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel27.Controls.Add(tbVersionHistory, 0, 2);
            tableLayoutPanel27.Controls.Add(label10, 0, 0);
            tableLayoutPanel27.Controls.Add(tableLayoutPanel28, 0, 1);
            tableLayoutPanel27.Dock = DockStyle.Fill;
            tableLayoutPanel27.Location = new Point(0, 0);
            tableLayoutPanel27.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel27.Name = "tableLayoutPanel27";
            tableLayoutPanel27.Padding = new Padding(6, 7, 6, 7);
            tableLayoutPanel27.RowCount = 4;
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Absolute, 133F));
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel27.Size = new Size(712, 715);
            tableLayoutPanel27.TabIndex = 5;
            // 
            // tbVersionHistory
            // 
            tbVersionHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbVersionHistory.BackColor = SystemColors.Window;
            tbVersionHistory.Location = new Point(12, 182);
            tbVersionHistory.Margin = new Padding(6, 7, 6, 7);
            tbVersionHistory.Multiline = true;
            tbVersionHistory.Name = "tbVersionHistory";
            tbVersionHistory.ReadOnly = true;
            tbVersionHistory.ScrollBars = ScrollBars.Both;
            tbVersionHistory.Size = new Size(688, 458);
            tbVersionHistory.TabIndex = 6;
            tbVersionHistory.Text = resources.GetString("tbVersionHistory.Text");
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.Maroon;
            label10.Location = new Point(9, 7);
            label10.Name = "label10";
            label10.Size = new Size(694, 35);
            label10.TabIndex = 0;
            label10.Text = "О программе";
            // 
            // tableLayoutPanel28
            // 
            tableLayoutPanel28.ColumnCount = 2;
            tableLayoutPanel28.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 107F));
            tableLayoutPanel28.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel28.Controls.Add(tbAbout, 1, 0);
            tableLayoutPanel28.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel28.Dock = DockStyle.Fill;
            tableLayoutPanel28.Location = new Point(6, 42);
            tableLayoutPanel28.Margin = new Padding(0);
            tableLayoutPanel28.Name = "tableLayoutPanel28";
            tableLayoutPanel28.RowCount = 1;
            tableLayoutPanel28.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel28.Size = new Size(700, 133);
            tableLayoutPanel28.TabIndex = 4;
            // 
            // tbAbout
            // 
            tbAbout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbAbout.BackColor = SystemColors.Window;
            tbAbout.Location = new Point(113, 7);
            tbAbout.Margin = new Padding(6, 7, 6, 7);
            tbAbout.Multiline = true;
            tbAbout.Name = "tbAbout";
            tbAbout.ReadOnly = true;
            tbAbout.ScrollBars = ScrollBars.Both;
            tbAbout.Size = new Size(581, 119);
            tbAbout.TabIndex = 6;
            tbAbout.Text = resources.GetString("tbAbout.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tpDebtGiven
            // 
            tpDebtGiven.Controls.Add(tableLayoutPanel33);
            tpDebtGiven.Controls.Add(tableLayoutPanel31);
            tpDebtGiven.Location = new Point(4, 29);
            tpDebtGiven.Margin = new Padding(3, 4, 3, 4);
            tpDebtGiven.Name = "tpDebtGiven";
            tpDebtGiven.Size = new Size(712, 715);
            tpDebtGiven.TabIndex = 11;
            tpDebtGiven.Text = "Долги мне";
            tpDebtGiven.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel33
            // 
            tableLayoutPanel33.ColumnCount = 1;
            tableLayoutPanel33.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel33.Controls.Add(dgwGivenDebts, 0, 2);
            tableLayoutPanel33.Controls.Add(lblGivenDebtsTotal, 0, 0);
            tableLayoutPanel33.Controls.Add(flowLayoutPanel15, 0, 1);
            tableLayoutPanel33.Dock = DockStyle.Fill;
            tableLayoutPanel33.Location = new Point(0, 0);
            tableLayoutPanel33.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel33.Name = "tableLayoutPanel33";
            tableLayoutPanel33.Padding = new Padding(6, 7, 6, 7);
            tableLayoutPanel33.RowCount = 3;
            tableLayoutPanel33.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel33.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel33.RowStyles.Add(new RowStyle());
            tableLayoutPanel33.Size = new Size(712, 582);
            tableLayoutPanel33.TabIndex = 4;
            // 
            // dgwGivenDebts
            // 
            dgwGivenDebts.AllowUserToAddRows = false;
            dgwGivenDebts.AllowUserToDeleteRows = false;
            dgwGivenDebts.AllowUserToOrderColumns = true;
            dgwGivenDebts.AllowUserToResizeRows = false;
            dgwGivenDebts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwGivenDebts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwGivenDebts.ContextMenuStrip = contextMenu;
            dgwGivenDebts.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwGivenDebts.Location = new Point(9, 107);
            dgwGivenDebts.Margin = new Padding(3, 4, 3, 4);
            dgwGivenDebts.MultiSelect = false;
            dgwGivenDebts.Name = "dgwGivenDebts";
            dgwGivenDebts.RowHeadersVisible = false;
            dgwGivenDebts.RowHeadersWidth = 51;
            dgwGivenDebts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwGivenDebts.Size = new Size(694, 464);
            dgwGivenDebts.TabIndex = 3;
            dgwGivenDebts.CellDoubleClick += dgwGivenDebts_CellDoubleClick;
            dgwGivenDebts.CellFormatting += dgwGivenDebts_CellFormatting;
            dgwGivenDebts.SelectionChanged += dgwGivenDebts_SelectionChanged;
            // 
            // lblGivenDebtsTotal
            // 
            lblGivenDebtsTotal.AutoSize = true;
            lblGivenDebtsTotal.Dock = DockStyle.Fill;
            lblGivenDebtsTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblGivenDebtsTotal.ForeColor = Color.Maroon;
            lblGivenDebtsTotal.Location = new Point(9, 7);
            lblGivenDebtsTotal.Name = "lblGivenDebtsTotal";
            lblGivenDebtsTotal.Size = new Size(694, 35);
            lblGivenDebtsTotal.TabIndex = 0;
            lblGivenDebtsTotal.Text = "Долги выданные";
            // 
            // flowLayoutPanel15
            // 
            flowLayoutPanel15.Controls.Add(btnAddGivenDebt);
            flowLayoutPanel15.Controls.Add(btnEditGivenDebt);
            flowLayoutPanel15.Controls.Add(btnDeleteGivenDebt);
            flowLayoutPanel15.Controls.Add(button12);
            flowLayoutPanel15.Controls.Add(cmbGivenDebtMonths);
            flowLayoutPanel15.Controls.Add(cmbGivenDebtYears);
            flowLayoutPanel15.Controls.Add(btnPaymentGivenDebt);
            flowLayoutPanel15.Dock = DockStyle.Fill;
            flowLayoutPanel15.Location = new Point(9, 46);
            flowLayoutPanel15.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel15.Name = "flowLayoutPanel15";
            flowLayoutPanel15.Padding = new Padding(6, 7, 6, 7);
            flowLayoutPanel15.Size = new Size(694, 53);
            flowLayoutPanel15.TabIndex = 1;
            // 
            // btnAddGivenDebt
            // 
            btnAddGivenDebt.Image = Properties.Resources.PlusIcon;
            btnAddGivenDebt.Location = new Point(9, 11);
            btnAddGivenDebt.Margin = new Padding(3, 4, 3, 4);
            btnAddGivenDebt.Name = "btnAddGivenDebt";
            btnAddGivenDebt.Size = new Size(119, 31);
            btnAddGivenDebt.TabIndex = 0;
            btnAddGivenDebt.Text = "Добавить";
            btnAddGivenDebt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddGivenDebt.UseVisualStyleBackColor = true;
            btnAddGivenDebt.Click += btnAddGivenDebt_Click;
            // 
            // btnEditGivenDebt
            // 
            btnEditGivenDebt.Image = Properties.Resources.EditIcon;
            btnEditGivenDebt.Location = new Point(134, 11);
            btnEditGivenDebt.Margin = new Padding(3, 4, 3, 4);
            btnEditGivenDebt.Name = "btnEditGivenDebt";
            btnEditGivenDebt.Size = new Size(26, 31);
            btnEditGivenDebt.TabIndex = 1;
            btnEditGivenDebt.UseVisualStyleBackColor = true;
            btnEditGivenDebt.Click += btnEditGivenDebt_Click;
            // 
            // btnDeleteGivenDebt
            // 
            btnDeleteGivenDebt.Image = Properties.Resources.MinusIcon;
            btnDeleteGivenDebt.Location = new Point(166, 11);
            btnDeleteGivenDebt.Margin = new Padding(3, 4, 3, 4);
            btnDeleteGivenDebt.Name = "btnDeleteGivenDebt";
            btnDeleteGivenDebt.Size = new Size(26, 31);
            btnDeleteGivenDebt.TabIndex = 2;
            btnDeleteGivenDebt.UseVisualStyleBackColor = true;
            btnDeleteGivenDebt.Click += btnDeleteGivenDebt_Click;
            // 
            // button12
            // 
            button12.Image = Properties.Resources.PrintIcon;
            button12.Location = new Point(198, 11);
            button12.Margin = new Padding(3, 4, 3, 4);
            button12.Name = "button12";
            button12.Size = new Size(26, 31);
            button12.TabIndex = 9;
            button12.UseVisualStyleBackColor = true;
            // 
            // cmbGivenDebtMonths
            // 
            cmbGivenDebtMonths.FormattingEnabled = true;
            cmbGivenDebtMonths.Location = new Point(230, 11);
            cmbGivenDebtMonths.Margin = new Padding(3, 4, 3, 4);
            cmbGivenDebtMonths.Name = "cmbGivenDebtMonths";
            cmbGivenDebtMonths.Size = new Size(114, 28);
            cmbGivenDebtMonths.TabIndex = 10;
            // 
            // cmbGivenDebtYears
            // 
            cmbGivenDebtYears.FormattingEnabled = true;
            cmbGivenDebtYears.Location = new Point(350, 11);
            cmbGivenDebtYears.Margin = new Padding(3, 4, 3, 4);
            cmbGivenDebtYears.Name = "cmbGivenDebtYears";
            cmbGivenDebtYears.Size = new Size(91, 28);
            cmbGivenDebtYears.TabIndex = 11;
            // 
            // btnPaymentGivenDebt
            // 
            btnPaymentGivenDebt.Location = new Point(447, 11);
            btnPaymentGivenDebt.Margin = new Padding(3, 4, 3, 4);
            btnPaymentGivenDebt.Name = "btnPaymentGivenDebt";
            btnPaymentGivenDebt.Size = new Size(86, 31);
            btnPaymentGivenDebt.TabIndex = 13;
            btnPaymentGivenDebt.Text = "Платежи";
            btnPaymentGivenDebt.UseVisualStyleBackColor = true;
            btnPaymentGivenDebt.Click += btnPaymentGivenDebt_Click;
            // 
            // tableLayoutPanel31
            // 
            tableLayoutPanel31.ColumnCount = 2;
            tableLayoutPanel31.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel31.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel31.Controls.Add(label15, 0, 0);
            tableLayoutPanel31.Controls.Add(tbDetailsGivenDebts, 1, 0);
            tableLayoutPanel31.Dock = DockStyle.Bottom;
            tableLayoutPanel31.Location = new Point(0, 582);
            tableLayoutPanel31.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel31.Name = "tableLayoutPanel31";
            tableLayoutPanel31.Padding = new Padding(6, 7, 6, 0);
            tableLayoutPanel31.RowCount = 1;
            tableLayoutPanel31.RowStyles.Add(new RowStyle());
            tableLayoutPanel31.Size = new Size(712, 133);
            tableLayoutPanel31.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(9, 7);
            label15.Name = "label15";
            label15.Size = new Size(107, 40);
            label15.TabIndex = 0;
            label15.Text = "Комментарий:";
            // 
            // tbDetailsGivenDebts
            // 
            tbDetailsGivenDebts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsGivenDebts.Location = new Point(123, 11);
            tbDetailsGivenDebts.Margin = new Padding(3, 4, 3, 4);
            tbDetailsGivenDebts.Multiline = true;
            tbDetailsGivenDebts.Name = "tbDetailsGivenDebts";
            tbDetailsGivenDebts.ReadOnly = true;
            tbDetailsGivenDebts.Size = new Size(580, 118);
            tbDetailsGivenDebts.TabIndex = 1;
            // 
            // tpDebtReceived
            // 
            tpDebtReceived.Controls.Add(tableLayoutPanel34);
            tpDebtReceived.Controls.Add(tableLayoutPanel32);
            tpDebtReceived.Location = new Point(4, 29);
            tpDebtReceived.Margin = new Padding(3, 4, 3, 4);
            tpDebtReceived.Name = "tpDebtReceived";
            tpDebtReceived.Size = new Size(712, 715);
            tpDebtReceived.TabIndex = 12;
            tpDebtReceived.Text = "Долги мои";
            tpDebtReceived.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel34
            // 
            tableLayoutPanel34.ColumnCount = 1;
            tableLayoutPanel34.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel34.Controls.Add(dgwReceivedDebts, 0, 2);
            tableLayoutPanel34.Controls.Add(lblReceivedDebtsTotal, 0, 0);
            tableLayoutPanel34.Controls.Add(flowLayoutPanel16, 0, 1);
            tableLayoutPanel34.Dock = DockStyle.Fill;
            tableLayoutPanel34.Location = new Point(0, 0);
            tableLayoutPanel34.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel34.Name = "tableLayoutPanel34";
            tableLayoutPanel34.Padding = new Padding(6, 7, 6, 7);
            tableLayoutPanel34.RowCount = 3;
            tableLayoutPanel34.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel34.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel34.RowStyles.Add(new RowStyle());
            tableLayoutPanel34.Size = new Size(712, 582);
            tableLayoutPanel34.TabIndex = 4;
            // 
            // dgwReceivedDebts
            // 
            dgwReceivedDebts.AllowUserToAddRows = false;
            dgwReceivedDebts.AllowUserToDeleteRows = false;
            dgwReceivedDebts.AllowUserToOrderColumns = true;
            dgwReceivedDebts.AllowUserToResizeRows = false;
            dgwReceivedDebts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwReceivedDebts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwReceivedDebts.ContextMenuStrip = contextMenu;
            dgwReceivedDebts.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwReceivedDebts.Location = new Point(9, 107);
            dgwReceivedDebts.Margin = new Padding(3, 4, 3, 4);
            dgwReceivedDebts.MultiSelect = false;
            dgwReceivedDebts.Name = "dgwReceivedDebts";
            dgwReceivedDebts.RowHeadersVisible = false;
            dgwReceivedDebts.RowHeadersWidth = 51;
            dgwReceivedDebts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwReceivedDebts.Size = new Size(694, 464);
            dgwReceivedDebts.TabIndex = 3;
            dgwReceivedDebts.CellDoubleClick += dgwReceivedDebts_CellDoubleClick;
            dgwReceivedDebts.CellFormatting += dgwReceivedDebts_CellFormatting;
            dgwReceivedDebts.SelectionChanged += dgwReceivedDebts_SelectionChanged;
            // 
            // lblReceivedDebtsTotal
            // 
            lblReceivedDebtsTotal.AutoSize = true;
            lblReceivedDebtsTotal.Dock = DockStyle.Fill;
            lblReceivedDebtsTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblReceivedDebtsTotal.ForeColor = Color.Maroon;
            lblReceivedDebtsTotal.Location = new Point(9, 7);
            lblReceivedDebtsTotal.Name = "lblReceivedDebtsTotal";
            lblReceivedDebtsTotal.Size = new Size(694, 35);
            lblReceivedDebtsTotal.TabIndex = 0;
            lblReceivedDebtsTotal.Text = "Долги полученные";
            // 
            // flowLayoutPanel16
            // 
            flowLayoutPanel16.Controls.Add(btnAddReceivedDebt);
            flowLayoutPanel16.Controls.Add(btnEditReceivedDebt);
            flowLayoutPanel16.Controls.Add(btnDeleteReceivedDebt);
            flowLayoutPanel16.Controls.Add(button13);
            flowLayoutPanel16.Controls.Add(cmbReceivedDebtMonths);
            flowLayoutPanel16.Controls.Add(cmbReceivedDebtYears);
            flowLayoutPanel16.Controls.Add(btnPaymentReceivedDebt);
            flowLayoutPanel16.Dock = DockStyle.Fill;
            flowLayoutPanel16.Location = new Point(9, 46);
            flowLayoutPanel16.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel16.Name = "flowLayoutPanel16";
            flowLayoutPanel16.Padding = new Padding(6, 7, 6, 7);
            flowLayoutPanel16.Size = new Size(694, 53);
            flowLayoutPanel16.TabIndex = 1;
            // 
            // btnAddReceivedDebt
            // 
            btnAddReceivedDebt.Image = Properties.Resources.PlusIcon;
            btnAddReceivedDebt.Location = new Point(9, 11);
            btnAddReceivedDebt.Margin = new Padding(3, 4, 3, 4);
            btnAddReceivedDebt.Name = "btnAddReceivedDebt";
            btnAddReceivedDebt.Size = new Size(119, 31);
            btnAddReceivedDebt.TabIndex = 0;
            btnAddReceivedDebt.Text = "Добавить";
            btnAddReceivedDebt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddReceivedDebt.UseVisualStyleBackColor = true;
            btnAddReceivedDebt.Click += btnAddReceivedDebt_Click;
            // 
            // btnEditReceivedDebt
            // 
            btnEditReceivedDebt.Image = Properties.Resources.EditIcon;
            btnEditReceivedDebt.Location = new Point(134, 11);
            btnEditReceivedDebt.Margin = new Padding(3, 4, 3, 4);
            btnEditReceivedDebt.Name = "btnEditReceivedDebt";
            btnEditReceivedDebt.Size = new Size(26, 31);
            btnEditReceivedDebt.TabIndex = 1;
            btnEditReceivedDebt.UseVisualStyleBackColor = true;
            btnEditReceivedDebt.Click += btnEditReceivedDebt_Click;
            // 
            // btnDeleteReceivedDebt
            // 
            btnDeleteReceivedDebt.Image = Properties.Resources.MinusIcon;
            btnDeleteReceivedDebt.Location = new Point(166, 11);
            btnDeleteReceivedDebt.Margin = new Padding(3, 4, 3, 4);
            btnDeleteReceivedDebt.Name = "btnDeleteReceivedDebt";
            btnDeleteReceivedDebt.Size = new Size(26, 31);
            btnDeleteReceivedDebt.TabIndex = 2;
            btnDeleteReceivedDebt.UseVisualStyleBackColor = true;
            btnDeleteReceivedDebt.Click += btnDeleteReceivedDebt_Click;
            // 
            // button13
            // 
            button13.Image = Properties.Resources.PrintIcon;
            button13.Location = new Point(198, 11);
            button13.Margin = new Padding(3, 4, 3, 4);
            button13.Name = "button13";
            button13.Size = new Size(26, 31);
            button13.TabIndex = 9;
            button13.UseVisualStyleBackColor = true;
            // 
            // cmbReceivedDebtMonths
            // 
            cmbReceivedDebtMonths.FormattingEnabled = true;
            cmbReceivedDebtMonths.Location = new Point(230, 11);
            cmbReceivedDebtMonths.Margin = new Padding(3, 4, 3, 4);
            cmbReceivedDebtMonths.Name = "cmbReceivedDebtMonths";
            cmbReceivedDebtMonths.Size = new Size(114, 28);
            cmbReceivedDebtMonths.TabIndex = 12;
            // 
            // cmbReceivedDebtYears
            // 
            cmbReceivedDebtYears.FormattingEnabled = true;
            cmbReceivedDebtYears.Location = new Point(350, 11);
            cmbReceivedDebtYears.Margin = new Padding(3, 4, 3, 4);
            cmbReceivedDebtYears.Name = "cmbReceivedDebtYears";
            cmbReceivedDebtYears.Size = new Size(91, 28);
            cmbReceivedDebtYears.TabIndex = 13;
            // 
            // btnPaymentReceivedDebt
            // 
            btnPaymentReceivedDebt.Location = new Point(447, 11);
            btnPaymentReceivedDebt.Margin = new Padding(3, 4, 3, 4);
            btnPaymentReceivedDebt.Name = "btnPaymentReceivedDebt";
            btnPaymentReceivedDebt.Size = new Size(86, 31);
            btnPaymentReceivedDebt.TabIndex = 15;
            btnPaymentReceivedDebt.Text = "Платежи";
            btnPaymentReceivedDebt.UseVisualStyleBackColor = true;
            btnPaymentReceivedDebt.Click += btnPaymentReceivedDebt_Click;
            // 
            // tableLayoutPanel32
            // 
            tableLayoutPanel32.ColumnCount = 2;
            tableLayoutPanel32.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel32.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel32.Controls.Add(label17, 0, 0);
            tableLayoutPanel32.Controls.Add(tbDetailsReceivedDebts, 1, 0);
            tableLayoutPanel32.Dock = DockStyle.Bottom;
            tableLayoutPanel32.Location = new Point(0, 582);
            tableLayoutPanel32.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel32.Name = "tableLayoutPanel32";
            tableLayoutPanel32.Padding = new Padding(6, 7, 6, 0);
            tableLayoutPanel32.RowCount = 1;
            tableLayoutPanel32.RowStyles.Add(new RowStyle());
            tableLayoutPanel32.Size = new Size(712, 133);
            tableLayoutPanel32.TabIndex = 2;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(9, 7);
            label17.Name = "label17";
            label17.Size = new Size(107, 40);
            label17.TabIndex = 0;
            label17.Text = "Комментарий:";
            // 
            // tbDetailsReceivedDebts
            // 
            tbDetailsReceivedDebts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsReceivedDebts.Location = new Point(123, 11);
            tbDetailsReceivedDebts.Margin = new Padding(3, 4, 3, 4);
            tbDetailsReceivedDebts.Multiline = true;
            tbDetailsReceivedDebts.Name = "tbDetailsReceivedDebts";
            tbDetailsReceivedDebts.ReadOnly = true;
            tbDetailsReceivedDebts.Size = new Size(580, 118);
            tbDetailsReceivedDebts.TabIndex = 1;
            // 
            // tbCounterparties
            // 
            tbCounterparties.Controls.Add(tableLayoutPanel36);
            tbCounterparties.Controls.Add(tableLayoutPanel35);
            tbCounterparties.Location = new Point(4, 29);
            tbCounterparties.Margin = new Padding(3, 4, 3, 4);
            tbCounterparties.Name = "tbCounterparties";
            tbCounterparties.Size = new Size(712, 715);
            tbCounterparties.TabIndex = 13;
            tbCounterparties.Text = "Контрагенты";
            tbCounterparties.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel36
            // 
            tableLayoutPanel36.ColumnCount = 1;
            tableLayoutPanel36.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel36.Controls.Add(dgwCounterparties, 0, 2);
            tableLayoutPanel36.Controls.Add(label24, 0, 0);
            tableLayoutPanel36.Controls.Add(flowLayoutPanel17, 0, 1);
            tableLayoutPanel36.Dock = DockStyle.Fill;
            tableLayoutPanel36.Location = new Point(0, 0);
            tableLayoutPanel36.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel36.Name = "tableLayoutPanel36";
            tableLayoutPanel36.Padding = new Padding(6, 7, 6, 7);
            tableLayoutPanel36.RowCount = 3;
            tableLayoutPanel36.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel36.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel36.RowStyles.Add(new RowStyle());
            tableLayoutPanel36.Size = new Size(712, 582);
            tableLayoutPanel36.TabIndex = 4;
            // 
            // dgwCounterparties
            // 
            dgwCounterparties.AllowUserToAddRows = false;
            dgwCounterparties.AllowUserToDeleteRows = false;
            dgwCounterparties.AllowUserToOrderColumns = true;
            dgwCounterparties.AllowUserToResizeRows = false;
            dgwCounterparties.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwCounterparties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCounterparties.ContextMenuStrip = contextMenu;
            dgwCounterparties.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwCounterparties.Location = new Point(9, 107);
            dgwCounterparties.Margin = new Padding(3, 4, 3, 4);
            dgwCounterparties.MultiSelect = false;
            dgwCounterparties.Name = "dgwCounterparties";
            dgwCounterparties.RowHeadersVisible = false;
            dgwCounterparties.RowHeadersWidth = 51;
            dgwCounterparties.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwCounterparties.Size = new Size(694, 464);
            dgwCounterparties.TabIndex = 3;
            dgwCounterparties.CellDoubleClick += dgwCounterparties_CellDoubleClick;
            dgwCounterparties.SelectionChanged += dgwCounterparties_SelectionChanged;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Dock = DockStyle.Fill;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label24.ForeColor = Color.Maroon;
            label24.Location = new Point(9, 7);
            label24.Name = "label24";
            label24.Size = new Size(694, 35);
            label24.TabIndex = 0;
            label24.Text = "Контрагенты";
            // 
            // flowLayoutPanel17
            // 
            flowLayoutPanel17.Controls.Add(btnAddCounterparties);
            flowLayoutPanel17.Controls.Add(btnEditCounterparties);
            flowLayoutPanel17.Controls.Add(btnDeleteCounterparties);
            flowLayoutPanel17.Dock = DockStyle.Fill;
            flowLayoutPanel17.Location = new Point(9, 46);
            flowLayoutPanel17.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel17.Name = "flowLayoutPanel17";
            flowLayoutPanel17.Padding = new Padding(6, 7, 6, 7);
            flowLayoutPanel17.Size = new Size(694, 53);
            flowLayoutPanel17.TabIndex = 1;
            // 
            // btnAddCounterparties
            // 
            btnAddCounterparties.Image = Properties.Resources.PlusIcon;
            btnAddCounterparties.Location = new Point(9, 11);
            btnAddCounterparties.Margin = new Padding(3, 4, 3, 4);
            btnAddCounterparties.Name = "btnAddCounterparties";
            btnAddCounterparties.Size = new Size(119, 31);
            btnAddCounterparties.TabIndex = 0;
            btnAddCounterparties.Text = "Добавить";
            btnAddCounterparties.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddCounterparties.UseVisualStyleBackColor = true;
            btnAddCounterparties.Click += btnAddCounterparties_Click;
            // 
            // btnEditCounterparties
            // 
            btnEditCounterparties.Image = Properties.Resources.EditIcon;
            btnEditCounterparties.Location = new Point(134, 11);
            btnEditCounterparties.Margin = new Padding(3, 4, 3, 4);
            btnEditCounterparties.Name = "btnEditCounterparties";
            btnEditCounterparties.Size = new Size(26, 31);
            btnEditCounterparties.TabIndex = 1;
            btnEditCounterparties.UseVisualStyleBackColor = true;
            btnEditCounterparties.Click += btnEditCounterparties_Click;
            // 
            // btnDeleteCounterparties
            // 
            btnDeleteCounterparties.Image = Properties.Resources.MinusIcon;
            btnDeleteCounterparties.Location = new Point(166, 11);
            btnDeleteCounterparties.Margin = new Padding(3, 4, 3, 4);
            btnDeleteCounterparties.Name = "btnDeleteCounterparties";
            btnDeleteCounterparties.Size = new Size(26, 31);
            btnDeleteCounterparties.TabIndex = 2;
            btnDeleteCounterparties.UseVisualStyleBackColor = true;
            btnDeleteCounterparties.Click += btnDeleteCounterparties_Click;
            // 
            // tableLayoutPanel35
            // 
            tableLayoutPanel35.ColumnCount = 2;
            tableLayoutPanel35.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel35.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel35.Controls.Add(label20, 0, 0);
            tableLayoutPanel35.Controls.Add(tbDetailsCounterparties, 1, 0);
            tableLayoutPanel35.Dock = DockStyle.Bottom;
            tableLayoutPanel35.Location = new Point(0, 582);
            tableLayoutPanel35.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel35.Name = "tableLayoutPanel35";
            tableLayoutPanel35.Padding = new Padding(6, 7, 6, 0);
            tableLayoutPanel35.RowCount = 1;
            tableLayoutPanel35.RowStyles.Add(new RowStyle());
            tableLayoutPanel35.Size = new Size(712, 133);
            tableLayoutPanel35.TabIndex = 2;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(9, 7);
            label20.Name = "label20";
            label20.Size = new Size(107, 40);
            label20.TabIndex = 0;
            label20.Text = "Комментарий:";
            // 
            // tbDetailsCounterparties
            // 
            tbDetailsCounterparties.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsCounterparties.Location = new Point(123, 11);
            tbDetailsCounterparties.Margin = new Padding(3, 4, 3, 4);
            tbDetailsCounterparties.Multiline = true;
            tbDetailsCounterparties.Name = "tbDetailsCounterparties";
            tbDetailsCounterparties.ReadOnly = true;
            tbDetailsCounterparties.Size = new Size(580, 118);
            tbDetailsCounterparties.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 748);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(912, 784);
            Name = "MainForm";
            Text = "Мои финансы";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
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
            tableLayoutPanel26.ResumeLayout(false);
            tableLayoutPanel26.PerformLayout();
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            pnlFilters.ResumeLayout(false);
            flPanel3.ResumeLayout(false);
            flPanel3.PerformLayout();
            flPanel4.ResumeLayout(false);
            flPanel4.PerformLayout();
            flPanel5.ResumeLayout(false);
            flPanel5.PerformLayout();
            flPanel6.ResumeLayout(false);
            flPanel6.PerformLayout();
            flowLayoutPanel14.ResumeLayout(false);
            tpSettings.ResumeLayout(false);
            tableLayoutPanel29.ResumeLayout(false);
            tableLayoutPanel29.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tpAbout.ResumeLayout(false);
            tableLayoutPanel27.ResumeLayout(false);
            tableLayoutPanel27.PerformLayout();
            tableLayoutPanel28.ResumeLayout(false);
            tableLayoutPanel28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tpDebtGiven.ResumeLayout(false);
            tableLayoutPanel33.ResumeLayout(false);
            tableLayoutPanel33.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwGivenDebts).EndInit();
            flowLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel31.ResumeLayout(false);
            tableLayoutPanel31.PerformLayout();
            tpDebtReceived.ResumeLayout(false);
            tableLayoutPanel34.ResumeLayout(false);
            tableLayoutPanel34.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwReceivedDebts).EndInit();
            flowLayoutPanel16.ResumeLayout(false);
            tableLayoutPanel32.ResumeLayout(false);
            tableLayoutPanel32.PerformLayout();
            tbCounterparties.ResumeLayout(false);
            tableLayoutPanel36.ResumeLayout(false);
            tableLayoutPanel36.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCounterparties).EndInit();
            flowLayoutPanel17.ResumeLayout(false);
            tableLayoutPanel35.ResumeLayout(false);
            tableLayoutPanel35.PerformLayout();
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
        private Label lblPageExpensesCaption;
        private FlowLayoutPanel flowLayoutPanel6;
        private Button btnAddExpenses;
        private Button btnEditExpenses1;
        private TableLayoutPanel tableLayoutPanel20;
        private DataGridView dgwIncomes;
        private Label lblPageIncomesCaption;
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
        private TableLayoutPanel tableLayoutPanel28;
        private TableLayoutPanel tableLayoutPanel30;
        private Label label12;
        private TableLayoutPanel tableLayoutPanel29;
        private Label label11;
        private FlowLayoutPanel filterPanel;
        private FlowLayoutPanel pnlFilters;
        private FlowLayoutPanel flPanel3;
        private FlowLayoutPanel flPanel4;
        private FlowLayoutPanel flPanel5;
        private FlowLayoutPanel flPanel6;
        private FlowLayoutPanel flowLayoutPanel14;
        private ComboBox cmbReports;
        private Button button3;
        private ImageList imageList1;
        private TextBox tbVersionHistory;
        private TextBox tbAbout;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenu;
        private Panel panel1;
        private CheckBox checkBox1;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private Button btnRefresh;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private DateTimePicker dtpStartReportDate;
        private DateTimePicker dtpEndReportDate;
        private Label label13;
        private TabPage tpDebtGiven;
        private TabPage tpDebtReceived;
        private TableLayoutPanel tableLayoutPanel33;
        private DataGridView dgwGivenDebts;
        private Label lblGivenDebtsTotal;
        private FlowLayoutPanel flowLayoutPanel15;
        private Button btnAddGivenDebt;
        private Button btnEditGivenDebt;
        private Button btnDeleteGivenDebt;
        private TableLayoutPanel tableLayoutPanel31;
        private Label label15;
        private TextBox tbDetailsGivenDebts;
        private TableLayoutPanel tableLayoutPanel34;
        private DataGridView dgwReceivedDebts;
        private Label lblReceivedDebtsTotal;
        private FlowLayoutPanel flowLayoutPanel16;
        private Button btnAddReceivedDebt;
        private Button btnEditReceivedDebt;
        private Button btnDeleteReceivedDebt;
        private TableLayoutPanel tableLayoutPanel32;
        private Label label17;
        private TextBox tbDetailsReceivedDebts;
        private Button button12;
        private Button button13;
        private ComboBox cmbGivenDebtMonths;
        private ComboBox cmbGivenDebtYears;
        private ComboBox cmbReceivedDebtMonths;
        private ComboBox cmbReceivedDebtYears;
        private TabPage tbCounterparties;
        private TableLayoutPanel tableLayoutPanel36;
        private DataGridView dgwCounterparties;
        private Label label24;
        private FlowLayoutPanel flowLayoutPanel17;
        private Button btnAddCounterparties;
        private Button btnEditCounterparties;
        private Button btnDeleteCounterparties;
        private TableLayoutPanel tableLayoutPanel35;
        private Label label20;
        private TextBox tbDetailsCounterparties;
        private Button btnPaymentGivenDebt;
        private Button btnPaymentReceivedDebt;
    }
}
