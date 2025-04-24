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
            TreeNode treeNode19 = new TreeNode("Главная", 5, 5);
            TreeNode treeNode20 = new TreeNode("Счета", 9, 9);
            TreeNode treeNode21 = new TreeNode("Расходы", 8, 8);
            TreeNode treeNode22 = new TreeNode("Приходы", 7, 7);
            TreeNode treeNode23 = new TreeNode("Цели", 12, 12);
            TreeNode treeNode24 = new TreeNode("Полученые", 11, 11);
            TreeNode treeNode25 = new TreeNode("Выданные", 13, 13);
            TreeNode treeNode26 = new TreeNode("Долги", 11, 11, new TreeNode[] { treeNode24, treeNode25 });
            TreeNode treeNode27 = new TreeNode("Категории", 2, 2);
            TreeNode treeNode28 = new TreeNode("Источники", 1, 1);
            TreeNode treeNode29 = new TreeNode("Упоминания", 10, 10);
            TreeNode treeNode30 = new TreeNode("Контрагенты", 15, 15);
            TreeNode treeNode31 = new TreeNode("Валюты", 3, 3);
            TreeNode treeNode32 = new TreeNode("Единицы", 14, 14);
            TreeNode treeNode33 = new TreeNode("Справочники", 2, 2, new TreeNode[] { treeNode27, treeNode28, treeNode29, treeNode30, treeNode31, treeNode32 });
            TreeNode treeNode34 = new TreeNode("Отчеты", 6, 6);
            TreeNode treeNode35 = new TreeNode("Настройки", 4, 4);
            TreeNode treeNode36 = new TreeNode("О программе", 0, 0);
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
            flowLayoutPanel20 = new FlowLayoutPanel();
            accountPanel = new Panel();
            tableLayoutPanel41 = new TableLayoutPanel();
            label51 = new Label();
            label52 = new Label();
            lblYesterdayIncome = new Label();
            lblYesterdayExpense = new Label();
            lblTodayIncome = new Label();
            lblTodayExpense = new Label();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            flowLayoutPanel21 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            lblTotalBalance = new Label();
            additionalPanel = new Panel();
            tableLayoutPanel42 = new TableLayoutPanel();
            lblAdditional1Name = new Label();
            lblAdditional2Name = new Label();
            lblAdditional3Name = new Label();
            lblAdditional1Value = new Label();
            lblAdditional2Value = new Label();
            lblAdditional3Value = new Label();
            flowLayoutPanel22 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            label27 = new Label();
            budgetPanel = new Panel();
            tableLayoutPanel43 = new TableLayoutPanel();
            label67 = new Label();
            label68 = new Label();
            label69 = new Label();
            label70 = new Label();
            label71 = new Label();
            label72 = new Label();
            lblBudgetTopCategory = new Label();
            lblBudgetLimit = new Label();
            lblBudgetSpent = new Label();
            lblBudgetRemaining = new Label();
            lblBudgetProgress = new Label();
            flowLayoutPanel23 = new FlowLayoutPanel();
            pictureBox4 = new PictureBox();
            label44 = new Label();
            profitPanel = new Panel();
            tableLayoutPanel44 = new TableLayoutPanel();
            label78 = new Label();
            lblTotalIncome = new Label();
            label80 = new Label();
            lblIncomeChange = new Label();
            label82 = new Label();
            lblTotalExpense = new Label();
            label84 = new Label();
            lblExpenseChange = new Label();
            label86 = new Label();
            label87 = new Label();
            lblBestDay = new Label();
            lblWorstDay = new Label();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            flowLayoutPanel24 = new FlowLayoutPanel();
            pictureBox5 = new PictureBox();
            label45 = new Label();
            expensePanel = new Panel();
            tableLayoutPanel45 = new TableLayoutPanel();
            lblExpense1Name = new Label();
            lblExpense2Name = new Label();
            lblExpense3Name = new Label();
            lblExpense1Value = new Label();
            lblExpense2Value = new Label();
            lblExpense3Value = new Label();
            pictureBox17 = new PictureBox();
            pictureBox18 = new PictureBox();
            pictureBox19 = new PictureBox();
            flowLayoutPanel25 = new FlowLayoutPanel();
            pictureBox6 = new PictureBox();
            label46 = new Label();
            incomePanel = new Panel();
            tableLayoutPanel46 = new TableLayoutPanel();
            lblIncome1Name = new Label();
            lblIncome2Name = new Label();
            lblIncome3Name = new Label();
            lblIncome1Value = new Label();
            lblIncome2Value = new Label();
            lblIncome3Value = new Label();
            pictureBox20 = new PictureBox();
            pictureBox21 = new PictureBox();
            pictureBox22 = new PictureBox();
            flowLayoutPanel26 = new FlowLayoutPanel();
            pictureBox7 = new PictureBox();
            label47 = new Label();
            goalPanel = new Panel();
            tableLayoutPanel47 = new TableLayoutPanel();
            label132 = new Label();
            label131 = new Label();
            label130 = new Label();
            lblGoal1Name = new Label();
            lblGoal2Name = new Label();
            lblGoal3Name = new Label();
            lblNearestGoalName = new Label();
            lblGoal1Progress = new Label();
            lblGoal2Progress = new Label();
            lblGoal3Progress = new Label();
            lblNearestGoalDate = new Label();
            flowLayoutPanel27 = new FlowLayoutPanel();
            pictureBox8 = new PictureBox();
            label48 = new Label();
            debtPanel = new Panel();
            tableLayoutPanel48 = new TableLayoutPanel();
            label110 = new Label();
            label111 = new Label();
            label112 = new Label();
            label113 = new Label();
            label114 = new Label();
            label115 = new Label();
            lblTotalGivenDebt = new Label();
            lblOverdueGivenDebt = new Label();
            lblNextGivenDueDate = new Label();
            lblTotalReceivedDebt = new Label();
            lblOverdueReceivedDebt = new Label();
            lblNextReceivedDueDate = new Label();
            pictureBox27 = new PictureBox();
            pictureBox28 = new PictureBox();
            flowLayoutPanel28 = new FlowLayoutPanel();
            pictureBox9 = new PictureBox();
            label49 = new Label();
            progressPanel = new Panel();
            tableLayoutPanel49 = new TableLayoutPanel();
            label122 = new Label();
            label123 = new Label();
            label124 = new Label();
            label125 = new Label();
            label126 = new Label();
            label127 = new Label();
            label128 = new Label();
            label129 = new Label();
            pictureBox23 = new PictureBox();
            pictureBox24 = new PictureBox();
            pictureBox25 = new PictureBox();
            pictureBox26 = new PictureBox();
            flowLayoutPanel29 = new FlowLayoutPanel();
            pictureBox10 = new PictureBox();
            label50 = new Label();
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            checkBox1 = new CheckBox();
            tabPage2 = new TabPage();
            checkedListBox1 = new CheckedListBox();
            btnDown = new Button();
            btnUp = new Button();
            tpAbout = new TabPage();
            tableLayoutPanel27 = new TableLayoutPanel();
            tbVersionHistory = new TextBox();
            label10 = new Label();
            tableLayoutPanel28 = new TableLayoutPanel();
            tbAbout = new TextBox();
            pictureBox1 = new PictureBox();
            flowLayoutPanel18 = new FlowLayoutPanel();
            button2 = new Button();
            button4 = new Button();
            tpDebtGiven = new TabPage();
            tableLayoutPanel33 = new TableLayoutPanel();
            dgwGivenDebts = new DataGridView();
            lblGivenDebtsTotal = new Label();
            flowLayoutPanel15 = new FlowLayoutPanel();
            btnAddGivenDebt = new Button();
            btnEditGivenDebt = new Button();
            btnDeleteGivenDebt = new Button();
            button12 = new Button();
            cmbGivenDebtStatusFilter = new ComboBox();
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
            cmbReceivedDebtStatusFilter = new ComboBox();
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
            tbGoals = new TabPage();
            tableLayoutPanel38 = new TableLayoutPanel();
            dgwGoals = new DataGridView();
            label26 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAddGoal = new Button();
            btnFundGoal = new Button();
            btnEditGoal = new Button();
            btnDeleteGoal = new Button();
            btnPrintGoal = new Button();
            cmbGoalFilter = new ComboBox();
            btnGoalTransfer = new Button();
            tableLayoutPanel37 = new TableLayoutPanel();
            label25 = new Label();
            tbDetailsGoal = new TextBox();
            tbMeasurements = new TabPage();
            tableLayoutPanel40 = new TableLayoutPanel();
            dgwMeasurement = new DataGridView();
            label42 = new Label();
            flowLayoutPanel19 = new FlowLayoutPanel();
            btnAddMeasurement = new Button();
            btnEditMeasurement = new Button();
            btnDeleteMeasurement = new Button();
            tableLayoutPanel39 = new TableLayoutPanel();
            label41 = new Label();
            tbDetailsMeasurement = new TextBox();
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
            flowLayoutPanel20.SuspendLayout();
            accountPanel.SuspendLayout();
            tableLayoutPanel41.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            flowLayoutPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            additionalPanel.SuspendLayout();
            tableLayoutPanel42.SuspendLayout();
            flowLayoutPanel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            budgetPanel.SuspendLayout();
            tableLayoutPanel43.SuspendLayout();
            flowLayoutPanel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            profitPanel.SuspendLayout();
            tableLayoutPanel44.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            flowLayoutPanel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            expensePanel.SuspendLayout();
            tableLayoutPanel45.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            flowLayoutPanel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            incomePanel.SuspendLayout();
            tableLayoutPanel46.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).BeginInit();
            flowLayoutPanel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            goalPanel.SuspendLayout();
            tableLayoutPanel47.SuspendLayout();
            flowLayoutPanel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            debtPanel.SuspendLayout();
            tableLayoutPanel48.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox28).BeginInit();
            flowLayoutPanel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            progressPanel.SuspendLayout();
            tableLayoutPanel49.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).BeginInit();
            flowLayoutPanel29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
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
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tpAbout.SuspendLayout();
            tableLayoutPanel27.SuspendLayout();
            tableLayoutPanel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel18.SuspendLayout();
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
            tbGoals.SuspendLayout();
            tableLayoutPanel38.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwGoals).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel37.SuspendLayout();
            tbMeasurements.SuspendLayout();
            tableLayoutPanel40.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMeasurement).BeginInit();
            flowLayoutPanel19.SuspendLayout();
            tableLayoutPanel39.SuspendLayout();
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
            splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tcPage);
            splitContainer1.Panel2MinSize = 400;
            splitContainer1.Size = new Size(1104, 707);
            splitContainer1.SplitterDistance = 150;
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
            tvMenuPanel.Location = new Point(5, 5);
            tvMenuPanel.Name = "tvMenuPanel";
            treeNode19.ImageIndex = 5;
            treeNode19.Name = "tnStart";
            treeNode19.SelectedImageIndex = 5;
            treeNode19.Tag = "0";
            treeNode19.Text = "Главная";
            treeNode20.ImageIndex = 9;
            treeNode20.Name = "tnAccounts";
            treeNode20.SelectedImageIndex = 9;
            treeNode20.Tag = "1";
            treeNode20.Text = "Счета";
            treeNode21.ImageIndex = 8;
            treeNode21.Name = "tnExpenses";
            treeNode21.SelectedImageIndex = 8;
            treeNode21.Tag = "2";
            treeNode21.Text = "Расходы";
            treeNode22.ImageIndex = 7;
            treeNode22.Name = "tnIncome";
            treeNode22.SelectedImageIndex = 7;
            treeNode22.Tag = "3";
            treeNode22.Text = "Приходы";
            treeNode23.ImageIndex = 12;
            treeNode23.Name = "tnGoals";
            treeNode23.SelectedImageIndex = 12;
            treeNode23.Tag = "14";
            treeNode23.Text = "Цели";
            treeNode24.ImageIndex = 11;
            treeNode24.Name = "tnDebtReceived";
            treeNode24.SelectedImageIndex = 11;
            treeNode24.Tag = "12";
            treeNode24.Text = "Полученые";
            treeNode25.ImageIndex = 13;
            treeNode25.Name = "tnDebtGiven";
            treeNode25.SelectedImageIndex = 13;
            treeNode25.Tag = "11";
            treeNode25.Text = "Выданные";
            treeNode26.ImageIndex = 11;
            treeNode26.Name = "tnDebt";
            treeNode26.SelectedImageIndex = 11;
            treeNode26.Tag = "12";
            treeNode26.Text = "Долги";
            treeNode27.ImageIndex = 2;
            treeNode27.Name = "tnCategory";
            treeNode27.SelectedImageIndex = 2;
            treeNode27.Tag = "4";
            treeNode27.Text = "Категории";
            treeNode28.ImageIndex = 1;
            treeNode28.Name = "tnSource";
            treeNode28.SelectedImageIndex = 1;
            treeNode28.Tag = "5";
            treeNode28.Text = "Источники";
            treeNode29.ImageIndex = 10;
            treeNode29.Name = "tnAdditionally";
            treeNode29.SelectedImageIndex = 10;
            treeNode29.Tag = "6";
            treeNode29.Text = "Упоминания";
            treeNode30.ImageIndex = 15;
            treeNode30.Name = "tnCounterparties";
            treeNode30.SelectedImageIndex = 15;
            treeNode30.Tag = "13";
            treeNode30.Text = "Контрагенты";
            treeNode31.ImageIndex = 3;
            treeNode31.Name = "tnCurrencies";
            treeNode31.SelectedImageIndex = 3;
            treeNode31.Tag = "7";
            treeNode31.Text = "Валюты";
            treeNode32.ImageIndex = 14;
            treeNode32.Name = "tnMeasurements";
            treeNode32.SelectedImageIndex = 14;
            treeNode32.Tag = "15";
            treeNode32.Text = "Единицы";
            treeNode33.ImageIndex = 2;
            treeNode33.Name = "tnDirectory";
            treeNode33.SelectedImageIndex = 2;
            treeNode33.Tag = "4";
            treeNode33.Text = "Справочники";
            treeNode34.ImageIndex = 6;
            treeNode34.Name = "tnReports";
            treeNode34.SelectedImageIndex = 6;
            treeNode34.Tag = "8";
            treeNode34.Text = "Отчеты";
            treeNode35.ImageIndex = 4;
            treeNode35.Name = "tnSettings";
            treeNode35.SelectedImageIndex = 4;
            treeNode35.Tag = "9";
            treeNode35.Text = "Настройки";
            treeNode36.ImageIndex = 0;
            treeNode36.Name = "tnAbout";
            treeNode36.SelectedImageIndex = 0;
            treeNode36.Tag = "10";
            treeNode36.Text = "О программе";
            tvMenuPanel.Nodes.AddRange(new TreeNode[] { treeNode19, treeNode20, treeNode21, treeNode22, treeNode23, treeNode26, treeNode33, treeNode34, treeNode35, treeNode36 });
            tvMenuPanel.SelectedImageIndex = 0;
            tvMenuPanel.ShowLines = false;
            tvMenuPanel.Size = new Size(140, 697);
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
            imageList1.Images.SetKeyName(11, "debt.png");
            imageList1.Images.SetKeyName(12, "target.png");
            imageList1.Images.SetKeyName(13, "time-to-pay.png");
            imageList1.Images.SetKeyName(14, "Measurement.png");
            imageList1.Images.SetKeyName(15, "meeting-room.png");
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
            tcPage.Controls.Add(tbGoals);
            tcPage.Controls.Add(tbMeasurements);
            tcPage.Dock = DockStyle.Fill;
            tcPage.Location = new Point(0, 0);
            tcPage.Name = "tcPage";
            tcPage.SelectedIndex = 0;
            tcPage.Size = new Size(950, 707);
            tcPage.TabIndex = 0;
            tcPage.SelectedIndexChanged += tcPage_SelectedIndexChanged;
            // 
            // tpStart
            // 
            tpStart.Controls.Add(tableLayoutPanel30);
            tpStart.Location = new Point(4, 24);
            tpStart.Name = "tpStart";
            tpStart.Padding = new Padding(3);
            tpStart.Size = new Size(942, 679);
            tpStart.TabIndex = 0;
            tpStart.Text = "Стартовая";
            tpStart.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel30
            // 
            tableLayoutPanel30.ColumnCount = 1;
            tableLayoutPanel30.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel30.Controls.Add(label12, 0, 0);
            tableLayoutPanel30.Controls.Add(flowLayoutPanel20, 0, 1);
            tableLayoutPanel30.Dock = DockStyle.Fill;
            tableLayoutPanel30.Location = new Point(3, 3);
            tableLayoutPanel30.Name = "tableLayoutPanel30";
            tableLayoutPanel30.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel30.RowCount = 2;
            tableLayoutPanel30.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel30.RowStyles.Add(new RowStyle());
            tableLayoutPanel30.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel30.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel30.Size = new Size(936, 673);
            tableLayoutPanel30.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.ForeColor = Color.FromArgb(0, 37, 118, 8);
            label12.Location = new Point(8, 5);
            label12.Name = "label12";
            label12.Size = new Size(920, 26);
            label12.TabIndex = 0;
            label12.Text = "День недели и дата";
            // 
            // flowLayoutPanel20
            // 
            flowLayoutPanel20.Controls.Add(accountPanel);
            flowLayoutPanel20.Controls.Add(additionalPanel);
            flowLayoutPanel20.Controls.Add(budgetPanel);
            flowLayoutPanel20.Controls.Add(profitPanel);
            flowLayoutPanel20.Controls.Add(expensePanel);
            flowLayoutPanel20.Controls.Add(incomePanel);
            flowLayoutPanel20.Controls.Add(goalPanel);
            flowLayoutPanel20.Controls.Add(debtPanel);
            flowLayoutPanel20.Controls.Add(progressPanel);
            flowLayoutPanel20.Dock = DockStyle.Fill;
            flowLayoutPanel20.Location = new Point(8, 34);
            flowLayoutPanel20.Name = "flowLayoutPanel20";
            flowLayoutPanel20.Size = new Size(920, 636);
            flowLayoutPanel20.TabIndex = 1;
            // 
            // accountPanel
            // 
            accountPanel.BorderStyle = BorderStyle.FixedSingle;
            accountPanel.Controls.Add(tableLayoutPanel41);
            accountPanel.Controls.Add(flowLayoutPanel21);
            accountPanel.Location = new Point(3, 3);
            accountPanel.Name = "accountPanel";
            accountPanel.Size = new Size(300, 200);
            accountPanel.TabIndex = 0;
            accountPanel.Tag = "Счета";
            // 
            // tableLayoutPanel41
            // 
            tableLayoutPanel41.ColumnCount = 3;
            tableLayoutPanel41.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel41.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel41.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel41.Controls.Add(label51, 0, 0);
            tableLayoutPanel41.Controls.Add(label52, 0, 3);
            tableLayoutPanel41.Controls.Add(lblYesterdayIncome, 2, 0);
            tableLayoutPanel41.Controls.Add(lblYesterdayExpense, 2, 1);
            tableLayoutPanel41.Controls.Add(lblTodayIncome, 2, 3);
            tableLayoutPanel41.Controls.Add(lblTodayExpense, 2, 4);
            tableLayoutPanel41.Controls.Add(pictureBox11, 1, 0);
            tableLayoutPanel41.Controls.Add(pictureBox12, 1, 1);
            tableLayoutPanel41.Controls.Add(pictureBox13, 1, 3);
            tableLayoutPanel41.Controls.Add(pictureBox14, 1, 4);
            tableLayoutPanel41.Dock = DockStyle.Fill;
            tableLayoutPanel41.Location = new Point(0, 27);
            tableLayoutPanel41.Name = "tableLayoutPanel41";
            tableLayoutPanel41.RowCount = 8;
            tableLayoutPanel41.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel41.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel41.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel41.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel41.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel41.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel41.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel41.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel41.Size = new Size(298, 171);
            tableLayoutPanel41.TabIndex = 2;
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Dock = DockStyle.Left;
            label51.Location = new Point(3, 0);
            label51.Name = "label51";
            label51.Size = new Size(43, 20);
            label51.TabIndex = 0;
            label51.Text = "Вчера:";
            label51.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Dock = DockStyle.Left;
            label52.Location = new Point(3, 60);
            label52.Name = "label52";
            label52.Size = new Size(55, 20);
            label52.TabIndex = 1;
            label52.Text = "Сегодня:";
            label52.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblYesterdayIncome
            // 
            lblYesterdayIncome.AutoSize = true;
            lblYesterdayIncome.Dock = DockStyle.Left;
            lblYesterdayIncome.Location = new Point(189, 0);
            lblYesterdayIncome.Name = "lblYesterdayIncome";
            lblYesterdayIncome.Size = new Size(44, 20);
            lblYesterdayIncome.TabIndex = 2;
            lblYesterdayIncome.Text = "label53";
            lblYesterdayIncome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblYesterdayExpense
            // 
            lblYesterdayExpense.AutoSize = true;
            lblYesterdayExpense.Dock = DockStyle.Left;
            lblYesterdayExpense.Location = new Point(189, 20);
            lblYesterdayExpense.Name = "lblYesterdayExpense";
            lblYesterdayExpense.Size = new Size(44, 20);
            lblYesterdayExpense.TabIndex = 3;
            lblYesterdayExpense.Text = "label54";
            lblYesterdayExpense.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTodayIncome
            // 
            lblTodayIncome.AutoSize = true;
            lblTodayIncome.Dock = DockStyle.Left;
            lblTodayIncome.Location = new Point(189, 60);
            lblTodayIncome.Name = "lblTodayIncome";
            lblTodayIncome.Size = new Size(44, 20);
            lblTodayIncome.TabIndex = 4;
            lblTodayIncome.Text = "label55";
            lblTodayIncome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTodayExpense
            // 
            lblTodayExpense.AutoSize = true;
            lblTodayExpense.Dock = DockStyle.Left;
            lblTodayExpense.Location = new Point(189, 80);
            lblTodayExpense.Name = "lblTodayExpense";
            lblTodayExpense.Size = new Size(44, 20);
            lblTodayExpense.TabIndex = 5;
            lblTodayExpense.Text = "label56";
            lblTodayExpense.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox11
            // 
            pictureBox11.Location = new Point(169, 3);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(14, 14);
            pictureBox11.TabIndex = 6;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Location = new Point(169, 23);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(14, 14);
            pictureBox12.TabIndex = 7;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Location = new Point(169, 63);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(14, 14);
            pictureBox13.TabIndex = 8;
            pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.Location = new Point(169, 83);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(14, 14);
            pictureBox14.TabIndex = 9;
            pictureBox14.TabStop = false;
            // 
            // flowLayoutPanel21
            // 
            flowLayoutPanel21.BackColor = Color.FromArgb(37, 118, 8);
            flowLayoutPanel21.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel21.Controls.Add(pictureBox2);
            flowLayoutPanel21.Controls.Add(lblTotalBalance);
            flowLayoutPanel21.Dock = DockStyle.Top;
            flowLayoutPanel21.Location = new Point(0, 0);
            flowLayoutPanel21.Name = "flowLayoutPanel21";
            flowLayoutPanel21.Padding = new Padding(3);
            flowLayoutPanel21.Size = new Size(298, 27);
            flowLayoutPanel21.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Image = Properties.Resources.EditIcon;
            pictureBox2.Location = new Point(6, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 16);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblTotalBalance
            // 
            lblTotalBalance.AutoSize = true;
            lblTotalBalance.Dock = DockStyle.Left;
            lblTotalBalance.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTotalBalance.ForeColor = Color.White;
            lblTotalBalance.Location = new Point(28, 3);
            lblTotalBalance.Name = "lblTotalBalance";
            lblTotalBalance.Size = new Size(101, 22);
            lblTotalBalance.TabIndex = 3;
            lblTotalBalance.Text = "Счета - ХХХХ.ХХ";
            lblTotalBalance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // additionalPanel
            // 
            additionalPanel.BorderStyle = BorderStyle.FixedSingle;
            additionalPanel.Controls.Add(tableLayoutPanel42);
            additionalPanel.Controls.Add(flowLayoutPanel22);
            additionalPanel.Location = new Point(309, 3);
            additionalPanel.Name = "additionalPanel";
            additionalPanel.Size = new Size(300, 200);
            additionalPanel.TabIndex = 1;
            additionalPanel.Tag = "Упоминания";
            // 
            // tableLayoutPanel42
            // 
            tableLayoutPanel42.ColumnCount = 3;
            tableLayoutPanel42.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel42.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel42.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel42.Controls.Add(lblAdditional1Name, 0, 0);
            tableLayoutPanel42.Controls.Add(lblAdditional2Name, 0, 1);
            tableLayoutPanel42.Controls.Add(lblAdditional3Name, 0, 2);
            tableLayoutPanel42.Controls.Add(lblAdditional1Value, 2, 0);
            tableLayoutPanel42.Controls.Add(lblAdditional2Value, 2, 1);
            tableLayoutPanel42.Controls.Add(lblAdditional3Value, 2, 2);
            tableLayoutPanel42.Dock = DockStyle.Fill;
            tableLayoutPanel42.Location = new Point(0, 27);
            tableLayoutPanel42.Name = "tableLayoutPanel42";
            tableLayoutPanel42.RowCount = 8;
            tableLayoutPanel42.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel42.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel42.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel42.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel42.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel42.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel42.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel42.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel42.Size = new Size(298, 171);
            tableLayoutPanel42.TabIndex = 2;
            // 
            // lblAdditional1Name
            // 
            lblAdditional1Name.AutoSize = true;
            lblAdditional1Name.Dock = DockStyle.Left;
            lblAdditional1Name.Location = new Point(3, 0);
            lblAdditional1Name.Name = "lblAdditional1Name";
            lblAdditional1Name.Size = new Size(44, 20);
            lblAdditional1Name.TabIndex = 0;
            lblAdditional1Name.Text = "label57";
            lblAdditional1Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAdditional2Name
            // 
            lblAdditional2Name.AutoSize = true;
            lblAdditional2Name.Dock = DockStyle.Left;
            lblAdditional2Name.Location = new Point(3, 20);
            lblAdditional2Name.Name = "lblAdditional2Name";
            lblAdditional2Name.Size = new Size(44, 20);
            lblAdditional2Name.TabIndex = 1;
            lblAdditional2Name.Text = "label58";
            lblAdditional2Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAdditional3Name
            // 
            lblAdditional3Name.AutoSize = true;
            lblAdditional3Name.Dock = DockStyle.Left;
            lblAdditional3Name.Location = new Point(3, 40);
            lblAdditional3Name.Name = "lblAdditional3Name";
            lblAdditional3Name.Size = new Size(44, 20);
            lblAdditional3Name.TabIndex = 2;
            lblAdditional3Name.Text = "label59";
            lblAdditional3Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAdditional1Value
            // 
            lblAdditional1Value.AutoSize = true;
            lblAdditional1Value.Dock = DockStyle.Left;
            lblAdditional1Value.Location = new Point(189, 0);
            lblAdditional1Value.Name = "lblAdditional1Value";
            lblAdditional1Value.Size = new Size(44, 20);
            lblAdditional1Value.TabIndex = 5;
            lblAdditional1Value.Text = "label62";
            lblAdditional1Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAdditional2Value
            // 
            lblAdditional2Value.AutoSize = true;
            lblAdditional2Value.Dock = DockStyle.Left;
            lblAdditional2Value.Location = new Point(189, 20);
            lblAdditional2Value.Name = "lblAdditional2Value";
            lblAdditional2Value.Size = new Size(44, 20);
            lblAdditional2Value.TabIndex = 6;
            lblAdditional2Value.Text = "label63";
            lblAdditional2Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAdditional3Value
            // 
            lblAdditional3Value.AutoSize = true;
            lblAdditional3Value.Dock = DockStyle.Left;
            lblAdditional3Value.Location = new Point(189, 40);
            lblAdditional3Value.Name = "lblAdditional3Value";
            lblAdditional3Value.Size = new Size(44, 20);
            lblAdditional3Value.TabIndex = 7;
            lblAdditional3Value.Text = "label64";
            lblAdditional3Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel22
            // 
            flowLayoutPanel22.BackColor = Color.FromArgb(37, 118, 8);
            flowLayoutPanel22.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel22.Controls.Add(pictureBox3);
            flowLayoutPanel22.Controls.Add(label27);
            flowLayoutPanel22.Dock = DockStyle.Top;
            flowLayoutPanel22.Location = new Point(0, 0);
            flowLayoutPanel22.Name = "flowLayoutPanel22";
            flowLayoutPanel22.Padding = new Padding(3);
            flowLayoutPanel22.Size = new Size(298, 27);
            flowLayoutPanel22.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Bottom;
            pictureBox3.Image = Properties.Resources.EditIcon;
            pictureBox3.Location = new Point(6, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(16, 16);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Dock = DockStyle.Left;
            label27.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label27.ForeColor = Color.White;
            label27.Location = new Point(28, 3);
            label27.Name = "label27";
            label27.Size = new Size(80, 22);
            label27.TabIndex = 3;
            label27.Text = "Упоминания";
            label27.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // budgetPanel
            // 
            budgetPanel.BorderStyle = BorderStyle.FixedSingle;
            budgetPanel.Controls.Add(tableLayoutPanel43);
            budgetPanel.Controls.Add(flowLayoutPanel23);
            budgetPanel.Location = new Point(615, 3);
            budgetPanel.Name = "budgetPanel";
            budgetPanel.Size = new Size(300, 200);
            budgetPanel.TabIndex = 2;
            budgetPanel.Tag = "Бюджет";
            // 
            // tableLayoutPanel43
            // 
            tableLayoutPanel43.ColumnCount = 3;
            tableLayoutPanel43.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel43.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel43.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel43.Controls.Add(label67, 0, 0);
            tableLayoutPanel43.Controls.Add(label68, 0, 1);
            tableLayoutPanel43.Controls.Add(label69, 0, 2);
            tableLayoutPanel43.Controls.Add(label70, 0, 3);
            tableLayoutPanel43.Controls.Add(label71, 0, 5);
            tableLayoutPanel43.Controls.Add(label72, 0, 6);
            tableLayoutPanel43.Controls.Add(lblBudgetTopCategory, 2, 6);
            tableLayoutPanel43.Controls.Add(lblBudgetLimit, 2, 0);
            tableLayoutPanel43.Controls.Add(lblBudgetSpent, 2, 1);
            tableLayoutPanel43.Controls.Add(lblBudgetRemaining, 2, 2);
            tableLayoutPanel43.Controls.Add(lblBudgetProgress, 2, 3);
            tableLayoutPanel43.Dock = DockStyle.Fill;
            tableLayoutPanel43.Location = new Point(0, 27);
            tableLayoutPanel43.Name = "tableLayoutPanel43";
            tableLayoutPanel43.RowCount = 8;
            tableLayoutPanel43.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel43.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel43.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel43.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel43.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel43.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel43.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel43.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel43.Size = new Size(298, 171);
            tableLayoutPanel43.TabIndex = 2;
            // 
            // label67
            // 
            label67.AutoSize = true;
            label67.Dock = DockStyle.Left;
            label67.Location = new Point(3, 0);
            label67.Name = "label67";
            label67.Size = new Size(89, 20);
            label67.TabIndex = 0;
            label67.Text = "Общий лимит:";
            label67.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label68
            // 
            label68.AutoSize = true;
            label68.Dock = DockStyle.Left;
            label68.Location = new Point(3, 20);
            label68.Name = "label68";
            label68.Size = new Size(71, 20);
            label68.TabIndex = 1;
            label68.Text = "Потрачено:";
            label68.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.Dock = DockStyle.Left;
            label69.Location = new Point(3, 40);
            label69.Name = "label69";
            label69.Size = new Size(54, 20);
            label69.TabIndex = 2;
            label69.Text = "Остаток:";
            label69.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label70
            // 
            label70.AutoSize = true;
            label70.Dock = DockStyle.Left;
            label70.Location = new Point(3, 60);
            label70.Name = "label70";
            label70.Size = new Size(63, 20);
            label70.TabIndex = 3;
            label70.Text = "Прогресс:";
            label70.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label71
            // 
            label71.AutoSize = true;
            label71.Dock = DockStyle.Left;
            label71.Location = new Point(3, 100);
            label71.Name = "label71";
            label71.Size = new Size(160, 20);
            label71.TabIndex = 4;
            label71.Text = "Перерасход по категориям:";
            label71.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label72
            // 
            label72.AutoSize = true;
            label72.Dock = DockStyle.Left;
            label72.Location = new Point(3, 120);
            label72.Name = "label72";
            label72.Size = new Size(44, 20);
            label72.TabIndex = 5;
            label72.Text = "label72";
            label72.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBudgetTopCategory
            // 
            lblBudgetTopCategory.AutoSize = true;
            lblBudgetTopCategory.Dock = DockStyle.Left;
            lblBudgetTopCategory.Location = new Point(189, 120);
            lblBudgetTopCategory.Name = "lblBudgetTopCategory";
            lblBudgetTopCategory.Size = new Size(44, 20);
            lblBudgetTopCategory.TabIndex = 6;
            lblBudgetTopCategory.Text = "label73";
            lblBudgetTopCategory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBudgetLimit
            // 
            lblBudgetLimit.AutoSize = true;
            lblBudgetLimit.Dock = DockStyle.Left;
            lblBudgetLimit.Location = new Point(189, 0);
            lblBudgetLimit.Name = "lblBudgetLimit";
            lblBudgetLimit.Size = new Size(44, 20);
            lblBudgetLimit.TabIndex = 7;
            lblBudgetLimit.Text = "label74";
            lblBudgetLimit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBudgetSpent
            // 
            lblBudgetSpent.AutoSize = true;
            lblBudgetSpent.Dock = DockStyle.Left;
            lblBudgetSpent.Location = new Point(189, 20);
            lblBudgetSpent.Name = "lblBudgetSpent";
            lblBudgetSpent.Size = new Size(44, 20);
            lblBudgetSpent.TabIndex = 8;
            lblBudgetSpent.Text = "label75";
            lblBudgetSpent.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBudgetRemaining
            // 
            lblBudgetRemaining.AutoSize = true;
            lblBudgetRemaining.Dock = DockStyle.Left;
            lblBudgetRemaining.Location = new Point(189, 40);
            lblBudgetRemaining.Name = "lblBudgetRemaining";
            lblBudgetRemaining.Size = new Size(44, 20);
            lblBudgetRemaining.TabIndex = 9;
            lblBudgetRemaining.Text = "label76";
            lblBudgetRemaining.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBudgetProgress
            // 
            lblBudgetProgress.AutoSize = true;
            lblBudgetProgress.Dock = DockStyle.Left;
            lblBudgetProgress.Location = new Point(189, 60);
            lblBudgetProgress.Name = "lblBudgetProgress";
            lblBudgetProgress.Size = new Size(44, 20);
            lblBudgetProgress.TabIndex = 10;
            lblBudgetProgress.Text = "label77";
            lblBudgetProgress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel23
            // 
            flowLayoutPanel23.BackColor = Color.FromArgb(37, 118, 8);
            flowLayoutPanel23.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel23.Controls.Add(pictureBox4);
            flowLayoutPanel23.Controls.Add(label44);
            flowLayoutPanel23.Dock = DockStyle.Top;
            flowLayoutPanel23.Location = new Point(0, 0);
            flowLayoutPanel23.Name = "flowLayoutPanel23";
            flowLayoutPanel23.Padding = new Padding(3);
            flowLayoutPanel23.Size = new Size(298, 27);
            flowLayoutPanel23.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Bottom;
            pictureBox4.Image = Properties.Resources.EditIcon;
            pictureBox4.Location = new Point(6, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(16, 16);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Dock = DockStyle.Left;
            label44.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label44.ForeColor = Color.White;
            label44.Location = new Point(28, 3);
            label44.Name = "label44";
            label44.Size = new Size(55, 22);
            label44.TabIndex = 3;
            label44.Text = "Бюджет";
            label44.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // profitPanel
            // 
            profitPanel.BorderStyle = BorderStyle.FixedSingle;
            profitPanel.Controls.Add(tableLayoutPanel44);
            profitPanel.Controls.Add(flowLayoutPanel24);
            profitPanel.Location = new Point(3, 209);
            profitPanel.Name = "profitPanel";
            profitPanel.Size = new Size(300, 200);
            profitPanel.TabIndex = 3;
            profitPanel.Tag = "Доход";
            // 
            // tableLayoutPanel44
            // 
            tableLayoutPanel44.ColumnCount = 3;
            tableLayoutPanel44.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel44.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel44.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel44.Controls.Add(label78, 0, 0);
            tableLayoutPanel44.Controls.Add(lblTotalIncome, 2, 0);
            tableLayoutPanel44.Controls.Add(label80, 0, 1);
            tableLayoutPanel44.Controls.Add(lblIncomeChange, 2, 1);
            tableLayoutPanel44.Controls.Add(label82, 0, 2);
            tableLayoutPanel44.Controls.Add(lblTotalExpense, 2, 2);
            tableLayoutPanel44.Controls.Add(label84, 0, 3);
            tableLayoutPanel44.Controls.Add(lblExpenseChange, 2, 3);
            tableLayoutPanel44.Controls.Add(label86, 0, 5);
            tableLayoutPanel44.Controls.Add(label87, 0, 6);
            tableLayoutPanel44.Controls.Add(lblBestDay, 2, 5);
            tableLayoutPanel44.Controls.Add(lblWorstDay, 2, 6);
            tableLayoutPanel44.Controls.Add(pictureBox15, 1, 5);
            tableLayoutPanel44.Controls.Add(pictureBox16, 1, 6);
            tableLayoutPanel44.Dock = DockStyle.Fill;
            tableLayoutPanel44.Location = new Point(0, 27);
            tableLayoutPanel44.Name = "tableLayoutPanel44";
            tableLayoutPanel44.RowCount = 8;
            tableLayoutPanel44.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel44.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel44.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel44.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel44.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel44.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel44.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel44.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel44.Size = new Size(298, 171);
            tableLayoutPanel44.TabIndex = 2;
            // 
            // label78
            // 
            label78.AutoSize = true;
            label78.Dock = DockStyle.Left;
            label78.Location = new Point(3, 0);
            label78.Name = "label78";
            label78.Size = new Size(58, 20);
            label78.TabIndex = 0;
            label78.Text = "Приходы";
            label78.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Dock = DockStyle.Left;
            lblTotalIncome.Location = new Point(189, 0);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(44, 20);
            lblTotalIncome.TabIndex = 1;
            lblTotalIncome.Text = "label79";
            lblTotalIncome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label80
            // 
            label80.AutoSize = true;
            label80.Dock = DockStyle.Left;
            label80.Location = new Point(3, 20);
            label80.Name = "label80";
            label80.Size = new Size(134, 20);
            label80.TabIndex = 2;
            label80.Text = "  с прошлым месяцем:";
            label80.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIncomeChange
            // 
            lblIncomeChange.AutoSize = true;
            lblIncomeChange.Dock = DockStyle.Left;
            lblIncomeChange.Location = new Point(189, 20);
            lblIncomeChange.Name = "lblIncomeChange";
            lblIncomeChange.Size = new Size(44, 20);
            lblIncomeChange.TabIndex = 3;
            lblIncomeChange.Text = "label81";
            lblIncomeChange.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label82
            // 
            label82.AutoSize = true;
            label82.Dock = DockStyle.Left;
            label82.Location = new Point(3, 40);
            label82.Name = "label82";
            label82.Size = new Size(54, 20);
            label82.TabIndex = 4;
            label82.Text = "Расходы";
            label82.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalExpense
            // 
            lblTotalExpense.AutoSize = true;
            lblTotalExpense.Dock = DockStyle.Left;
            lblTotalExpense.Location = new Point(189, 40);
            lblTotalExpense.Name = "lblTotalExpense";
            lblTotalExpense.Size = new Size(44, 20);
            lblTotalExpense.TabIndex = 5;
            lblTotalExpense.Text = "label83";
            lblTotalExpense.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label84
            // 
            label84.AutoSize = true;
            label84.Dock = DockStyle.Left;
            label84.Location = new Point(3, 60);
            label84.Name = "label84";
            label84.Size = new Size(134, 20);
            label84.TabIndex = 6;
            label84.Text = "  с прошлым месяцем:";
            label84.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblExpenseChange
            // 
            lblExpenseChange.AutoSize = true;
            lblExpenseChange.Dock = DockStyle.Left;
            lblExpenseChange.Location = new Point(189, 60);
            lblExpenseChange.Name = "lblExpenseChange";
            lblExpenseChange.Size = new Size(44, 20);
            lblExpenseChange.TabIndex = 7;
            lblExpenseChange.Text = "label85";
            lblExpenseChange.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label86
            // 
            label86.AutoSize = true;
            label86.Dock = DockStyle.Left;
            label86.Location = new Point(3, 100);
            label86.Name = "label86";
            label86.Size = new Size(37, 20);
            label86.TabIndex = 8;
            label86.Text = "День:";
            label86.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label87
            // 
            label87.AutoSize = true;
            label87.Dock = DockStyle.Left;
            label87.Location = new Point(3, 120);
            label87.Name = "label87";
            label87.Size = new Size(37, 20);
            label87.TabIndex = 9;
            label87.Text = "День:";
            label87.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBestDay
            // 
            lblBestDay.AutoSize = true;
            lblBestDay.Dock = DockStyle.Left;
            lblBestDay.Location = new Point(189, 100);
            lblBestDay.Name = "lblBestDay";
            lblBestDay.Size = new Size(44, 20);
            lblBestDay.TabIndex = 10;
            lblBestDay.Text = "label88";
            lblBestDay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblWorstDay
            // 
            lblWorstDay.AutoSize = true;
            lblWorstDay.Dock = DockStyle.Left;
            lblWorstDay.Location = new Point(189, 120);
            lblWorstDay.Name = "lblWorstDay";
            lblWorstDay.Size = new Size(44, 20);
            lblWorstDay.TabIndex = 11;
            lblWorstDay.Text = "label89";
            lblWorstDay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox15
            // 
            pictureBox15.Location = new Point(169, 103);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(14, 14);
            pictureBox15.TabIndex = 12;
            pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.Location = new Point(169, 123);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(14, 14);
            pictureBox16.TabIndex = 13;
            pictureBox16.TabStop = false;
            // 
            // flowLayoutPanel24
            // 
            flowLayoutPanel24.BackColor = Color.FromArgb(37, 118, 8);
            flowLayoutPanel24.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel24.Controls.Add(pictureBox5);
            flowLayoutPanel24.Controls.Add(label45);
            flowLayoutPanel24.Dock = DockStyle.Top;
            flowLayoutPanel24.Location = new Point(0, 0);
            flowLayoutPanel24.Name = "flowLayoutPanel24";
            flowLayoutPanel24.Padding = new Padding(3);
            flowLayoutPanel24.Size = new Size(298, 27);
            flowLayoutPanel24.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Bottom;
            pictureBox5.Image = Properties.Resources.EditIcon;
            pictureBox5.Location = new Point(6, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(16, 16);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Dock = DockStyle.Left;
            label45.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label45.ForeColor = Color.White;
            label45.Location = new Point(28, 3);
            label45.Name = "label45";
            label45.Size = new Size(54, 22);
            label45.TabIndex = 3;
            label45.Text = "Доходы";
            label45.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // expensePanel
            // 
            expensePanel.BorderStyle = BorderStyle.FixedSingle;
            expensePanel.Controls.Add(tableLayoutPanel45);
            expensePanel.Controls.Add(flowLayoutPanel25);
            expensePanel.Location = new Point(309, 209);
            expensePanel.Name = "expensePanel";
            expensePanel.Size = new Size(300, 200);
            expensePanel.TabIndex = 4;
            expensePanel.Tag = "Расходы";
            // 
            // tableLayoutPanel45
            // 
            tableLayoutPanel45.ColumnCount = 3;
            tableLayoutPanel45.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel45.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel45.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel45.Controls.Add(lblExpense1Name, 0, 0);
            tableLayoutPanel45.Controls.Add(lblExpense2Name, 0, 1);
            tableLayoutPanel45.Controls.Add(lblExpense3Name, 0, 2);
            tableLayoutPanel45.Controls.Add(lblExpense1Value, 2, 0);
            tableLayoutPanel45.Controls.Add(lblExpense2Value, 2, 1);
            tableLayoutPanel45.Controls.Add(lblExpense3Value, 2, 2);
            tableLayoutPanel45.Controls.Add(pictureBox17, 1, 0);
            tableLayoutPanel45.Controls.Add(pictureBox18, 1, 1);
            tableLayoutPanel45.Controls.Add(pictureBox19, 1, 2);
            tableLayoutPanel45.Dock = DockStyle.Fill;
            tableLayoutPanel45.Location = new Point(0, 27);
            tableLayoutPanel45.Name = "tableLayoutPanel45";
            tableLayoutPanel45.RowCount = 8;
            tableLayoutPanel45.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel45.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel45.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel45.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel45.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel45.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel45.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel45.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel45.Size = new Size(298, 171);
            tableLayoutPanel45.TabIndex = 2;
            // 
            // lblExpense1Name
            // 
            lblExpense1Name.AutoSize = true;
            lblExpense1Name.Dock = DockStyle.Left;
            lblExpense1Name.Location = new Point(3, 0);
            lblExpense1Name.Name = "lblExpense1Name";
            lblExpense1Name.Size = new Size(44, 20);
            lblExpense1Name.TabIndex = 0;
            lblExpense1Name.Text = "label90";
            lblExpense1Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblExpense2Name
            // 
            lblExpense2Name.AutoSize = true;
            lblExpense2Name.Dock = DockStyle.Left;
            lblExpense2Name.Location = new Point(3, 20);
            lblExpense2Name.Name = "lblExpense2Name";
            lblExpense2Name.Size = new Size(44, 20);
            lblExpense2Name.TabIndex = 1;
            lblExpense2Name.Text = "label91";
            lblExpense2Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblExpense3Name
            // 
            lblExpense3Name.AutoSize = true;
            lblExpense3Name.Dock = DockStyle.Left;
            lblExpense3Name.Location = new Point(3, 40);
            lblExpense3Name.Name = "lblExpense3Name";
            lblExpense3Name.Size = new Size(44, 20);
            lblExpense3Name.TabIndex = 2;
            lblExpense3Name.Text = "label92";
            lblExpense3Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblExpense1Value
            // 
            lblExpense1Value.AutoSize = true;
            lblExpense1Value.Dock = DockStyle.Left;
            lblExpense1Value.Location = new Point(189, 0);
            lblExpense1Value.Name = "lblExpense1Value";
            lblExpense1Value.Size = new Size(44, 20);
            lblExpense1Value.TabIndex = 3;
            lblExpense1Value.Text = "label93";
            lblExpense1Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblExpense2Value
            // 
            lblExpense2Value.AutoSize = true;
            lblExpense2Value.Dock = DockStyle.Left;
            lblExpense2Value.Location = new Point(189, 20);
            lblExpense2Value.Name = "lblExpense2Value";
            lblExpense2Value.Size = new Size(44, 20);
            lblExpense2Value.TabIndex = 4;
            lblExpense2Value.Text = "label94";
            lblExpense2Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblExpense3Value
            // 
            lblExpense3Value.AutoSize = true;
            lblExpense3Value.Dock = DockStyle.Left;
            lblExpense3Value.Location = new Point(189, 40);
            lblExpense3Value.Name = "lblExpense3Value";
            lblExpense3Value.Size = new Size(44, 20);
            lblExpense3Value.TabIndex = 5;
            lblExpense3Value.Text = "label95";
            lblExpense3Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox17
            // 
            pictureBox17.Location = new Point(169, 3);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(14, 14);
            pictureBox17.TabIndex = 6;
            pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            pictureBox18.Location = new Point(169, 23);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(14, 14);
            pictureBox18.TabIndex = 7;
            pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            pictureBox19.Location = new Point(169, 43);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(14, 14);
            pictureBox19.TabIndex = 8;
            pictureBox19.TabStop = false;
            // 
            // flowLayoutPanel25
            // 
            flowLayoutPanel25.BackColor = Color.FromArgb(37, 118, 8);
            flowLayoutPanel25.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel25.Controls.Add(pictureBox6);
            flowLayoutPanel25.Controls.Add(label46);
            flowLayoutPanel25.Dock = DockStyle.Top;
            flowLayoutPanel25.Location = new Point(0, 0);
            flowLayoutPanel25.Name = "flowLayoutPanel25";
            flowLayoutPanel25.Padding = new Padding(3);
            flowLayoutPanel25.Size = new Size(298, 27);
            flowLayoutPanel25.TabIndex = 1;
            // 
            // pictureBox6
            // 
            pictureBox6.Dock = DockStyle.Bottom;
            pictureBox6.Image = Properties.Resources.EditIcon;
            pictureBox6.Location = new Point(6, 6);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(16, 16);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Dock = DockStyle.Left;
            label46.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label46.ForeColor = Color.White;
            label46.Location = new Point(28, 3);
            label46.Name = "label46";
            label46.Size = new Size(57, 22);
            label46.TabIndex = 3;
            label46.Text = "Расходы";
            label46.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // incomePanel
            // 
            incomePanel.BorderStyle = BorderStyle.FixedSingle;
            incomePanel.Controls.Add(tableLayoutPanel46);
            incomePanel.Controls.Add(flowLayoutPanel26);
            incomePanel.Location = new Point(615, 209);
            incomePanel.Name = "incomePanel";
            incomePanel.Size = new Size(300, 200);
            incomePanel.TabIndex = 5;
            incomePanel.Tag = "Приходы";
            // 
            // tableLayoutPanel46
            // 
            tableLayoutPanel46.ColumnCount = 3;
            tableLayoutPanel46.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel46.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel46.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel46.Controls.Add(lblIncome1Name, 0, 0);
            tableLayoutPanel46.Controls.Add(lblIncome2Name, 0, 1);
            tableLayoutPanel46.Controls.Add(lblIncome3Name, 0, 2);
            tableLayoutPanel46.Controls.Add(lblIncome1Value, 2, 0);
            tableLayoutPanel46.Controls.Add(lblIncome2Value, 2, 1);
            tableLayoutPanel46.Controls.Add(lblIncome3Value, 2, 2);
            tableLayoutPanel46.Controls.Add(pictureBox20, 1, 0);
            tableLayoutPanel46.Controls.Add(pictureBox21, 1, 1);
            tableLayoutPanel46.Controls.Add(pictureBox22, 1, 2);
            tableLayoutPanel46.Dock = DockStyle.Fill;
            tableLayoutPanel46.Location = new Point(0, 27);
            tableLayoutPanel46.Name = "tableLayoutPanel46";
            tableLayoutPanel46.RowCount = 8;
            tableLayoutPanel46.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel46.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel46.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel46.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel46.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel46.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel46.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel46.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel46.Size = new Size(298, 171);
            tableLayoutPanel46.TabIndex = 2;
            // 
            // lblIncome1Name
            // 
            lblIncome1Name.AutoSize = true;
            lblIncome1Name.Dock = DockStyle.Left;
            lblIncome1Name.Location = new Point(3, 0);
            lblIncome1Name.Name = "lblIncome1Name";
            lblIncome1Name.Size = new Size(44, 20);
            lblIncome1Name.TabIndex = 0;
            lblIncome1Name.Text = "label96";
            lblIncome1Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIncome2Name
            // 
            lblIncome2Name.AutoSize = true;
            lblIncome2Name.Dock = DockStyle.Left;
            lblIncome2Name.Location = new Point(3, 20);
            lblIncome2Name.Name = "lblIncome2Name";
            lblIncome2Name.Size = new Size(44, 20);
            lblIncome2Name.TabIndex = 1;
            lblIncome2Name.Text = "label97";
            lblIncome2Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIncome3Name
            // 
            lblIncome3Name.AutoSize = true;
            lblIncome3Name.Dock = DockStyle.Left;
            lblIncome3Name.Location = new Point(3, 40);
            lblIncome3Name.Name = "lblIncome3Name";
            lblIncome3Name.Size = new Size(44, 20);
            lblIncome3Name.TabIndex = 2;
            lblIncome3Name.Text = "label98";
            lblIncome3Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIncome1Value
            // 
            lblIncome1Value.AutoSize = true;
            lblIncome1Value.Dock = DockStyle.Left;
            lblIncome1Value.Location = new Point(189, 0);
            lblIncome1Value.Name = "lblIncome1Value";
            lblIncome1Value.Size = new Size(44, 20);
            lblIncome1Value.TabIndex = 3;
            lblIncome1Value.Text = "label99";
            lblIncome1Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIncome2Value
            // 
            lblIncome2Value.AutoSize = true;
            lblIncome2Value.Dock = DockStyle.Left;
            lblIncome2Value.Location = new Point(189, 20);
            lblIncome2Value.Name = "lblIncome2Value";
            lblIncome2Value.Size = new Size(50, 20);
            lblIncome2Value.TabIndex = 4;
            lblIncome2Value.Text = "label100";
            lblIncome2Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIncome3Value
            // 
            lblIncome3Value.AutoSize = true;
            lblIncome3Value.Dock = DockStyle.Left;
            lblIncome3Value.Location = new Point(189, 40);
            lblIncome3Value.Name = "lblIncome3Value";
            lblIncome3Value.Size = new Size(50, 20);
            lblIncome3Value.TabIndex = 5;
            lblIncome3Value.Text = "label101";
            lblIncome3Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox20
            // 
            pictureBox20.Location = new Point(169, 3);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(14, 14);
            pictureBox20.TabIndex = 6;
            pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            pictureBox21.Location = new Point(169, 23);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(14, 14);
            pictureBox21.TabIndex = 7;
            pictureBox21.TabStop = false;
            // 
            // pictureBox22
            // 
            pictureBox22.Location = new Point(169, 43);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(14, 14);
            pictureBox22.TabIndex = 8;
            pictureBox22.TabStop = false;
            // 
            // flowLayoutPanel26
            // 
            flowLayoutPanel26.BackColor = Color.FromArgb(37, 118, 8);
            flowLayoutPanel26.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel26.Controls.Add(pictureBox7);
            flowLayoutPanel26.Controls.Add(label47);
            flowLayoutPanel26.Dock = DockStyle.Top;
            flowLayoutPanel26.Location = new Point(0, 0);
            flowLayoutPanel26.Name = "flowLayoutPanel26";
            flowLayoutPanel26.Padding = new Padding(3);
            flowLayoutPanel26.Size = new Size(298, 27);
            flowLayoutPanel26.TabIndex = 1;
            // 
            // pictureBox7
            // 
            pictureBox7.Dock = DockStyle.Bottom;
            pictureBox7.Image = Properties.Resources.EditIcon;
            pictureBox7.Location = new Point(6, 6);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(16, 16);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 2;
            pictureBox7.TabStop = false;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Dock = DockStyle.Left;
            label47.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label47.ForeColor = Color.White;
            label47.Location = new Point(28, 3);
            label47.Name = "label47";
            label47.Size = new Size(62, 22);
            label47.TabIndex = 3;
            label47.Text = "Приходы";
            label47.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // goalPanel
            // 
            goalPanel.BorderStyle = BorderStyle.FixedSingle;
            goalPanel.Controls.Add(tableLayoutPanel47);
            goalPanel.Controls.Add(flowLayoutPanel27);
            goalPanel.Location = new Point(3, 415);
            goalPanel.Name = "goalPanel";
            goalPanel.Size = new Size(300, 200);
            goalPanel.TabIndex = 6;
            goalPanel.Tag = "Цели";
            // 
            // tableLayoutPanel47
            // 
            tableLayoutPanel47.ColumnCount = 3;
            tableLayoutPanel47.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel47.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel47.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel47.Controls.Add(label132, 1, 2);
            tableLayoutPanel47.Controls.Add(label131, 1, 1);
            tableLayoutPanel47.Controls.Add(label130, 1, 0);
            tableLayoutPanel47.Controls.Add(lblGoal1Name, 0, 0);
            tableLayoutPanel47.Controls.Add(lblGoal2Name, 0, 1);
            tableLayoutPanel47.Controls.Add(lblGoal3Name, 0, 2);
            tableLayoutPanel47.Controls.Add(lblNearestGoalName, 0, 4);
            tableLayoutPanel47.Controls.Add(lblGoal1Progress, 2, 0);
            tableLayoutPanel47.Controls.Add(lblGoal2Progress, 2, 1);
            tableLayoutPanel47.Controls.Add(lblGoal3Progress, 2, 2);
            tableLayoutPanel47.Controls.Add(lblNearestGoalDate, 2, 4);
            tableLayoutPanel47.Dock = DockStyle.Fill;
            tableLayoutPanel47.Location = new Point(0, 27);
            tableLayoutPanel47.Name = "tableLayoutPanel47";
            tableLayoutPanel47.RowCount = 8;
            tableLayoutPanel47.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel47.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel47.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel47.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel47.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel47.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel47.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel47.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel47.Size = new Size(298, 171);
            tableLayoutPanel47.TabIndex = 2;
            // 
            // label132
            // 
            label132.AutoSize = true;
            label132.Dock = DockStyle.Left;
            label132.Location = new Point(169, 40);
            label132.Name = "label132";
            label132.Size = new Size(14, 20);
            label132.TabIndex = 10;
            label132.Text = "%";
            label132.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label131
            // 
            label131.AutoSize = true;
            label131.Dock = DockStyle.Left;
            label131.Location = new Point(169, 20);
            label131.Name = "label131";
            label131.Size = new Size(14, 20);
            label131.TabIndex = 9;
            label131.Text = "%";
            label131.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label130
            // 
            label130.AutoSize = true;
            label130.Dock = DockStyle.Left;
            label130.Location = new Point(169, 0);
            label130.Name = "label130";
            label130.Size = new Size(14, 20);
            label130.TabIndex = 8;
            label130.Text = "%";
            label130.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGoal1Name
            // 
            lblGoal1Name.AutoSize = true;
            lblGoal1Name.Dock = DockStyle.Left;
            lblGoal1Name.Location = new Point(3, 0);
            lblGoal1Name.Name = "lblGoal1Name";
            lblGoal1Name.Size = new Size(50, 20);
            lblGoal1Name.TabIndex = 0;
            lblGoal1Name.Text = "label102";
            lblGoal1Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGoal2Name
            // 
            lblGoal2Name.AutoSize = true;
            lblGoal2Name.Dock = DockStyle.Left;
            lblGoal2Name.Location = new Point(3, 20);
            lblGoal2Name.Name = "lblGoal2Name";
            lblGoal2Name.Size = new Size(50, 20);
            lblGoal2Name.TabIndex = 1;
            lblGoal2Name.Text = "label103";
            lblGoal2Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGoal3Name
            // 
            lblGoal3Name.AutoSize = true;
            lblGoal3Name.Dock = DockStyle.Left;
            lblGoal3Name.Location = new Point(3, 40);
            lblGoal3Name.Name = "lblGoal3Name";
            lblGoal3Name.Size = new Size(50, 20);
            lblGoal3Name.TabIndex = 2;
            lblGoal3Name.Text = "label104";
            lblGoal3Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNearestGoalName
            // 
            lblNearestGoalName.AutoSize = true;
            lblNearestGoalName.Dock = DockStyle.Left;
            lblNearestGoalName.Location = new Point(3, 80);
            lblNearestGoalName.Name = "lblNearestGoalName";
            lblNearestGoalName.Size = new Size(105, 20);
            lblNearestGoalName.TabIndex = 3;
            lblNearestGoalName.Text = "Ближайшая цель:";
            lblNearestGoalName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGoal1Progress
            // 
            lblGoal1Progress.AutoSize = true;
            lblGoal1Progress.Dock = DockStyle.Left;
            lblGoal1Progress.Location = new Point(189, 0);
            lblGoal1Progress.Name = "lblGoal1Progress";
            lblGoal1Progress.Size = new Size(50, 20);
            lblGoal1Progress.TabIndex = 4;
            lblGoal1Progress.Text = "label106";
            lblGoal1Progress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGoal2Progress
            // 
            lblGoal2Progress.AutoSize = true;
            lblGoal2Progress.Dock = DockStyle.Left;
            lblGoal2Progress.Location = new Point(189, 20);
            lblGoal2Progress.Name = "lblGoal2Progress";
            lblGoal2Progress.Size = new Size(50, 20);
            lblGoal2Progress.TabIndex = 5;
            lblGoal2Progress.Text = "label107";
            lblGoal2Progress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGoal3Progress
            // 
            lblGoal3Progress.AutoSize = true;
            lblGoal3Progress.Dock = DockStyle.Left;
            lblGoal3Progress.Location = new Point(189, 40);
            lblGoal3Progress.Name = "lblGoal3Progress";
            lblGoal3Progress.Size = new Size(50, 20);
            lblGoal3Progress.TabIndex = 6;
            lblGoal3Progress.Text = "label108";
            lblGoal3Progress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNearestGoalDate
            // 
            lblNearestGoalDate.AutoSize = true;
            lblNearestGoalDate.Dock = DockStyle.Left;
            lblNearestGoalDate.Location = new Point(189, 80);
            lblNearestGoalDate.Name = "lblNearestGoalDate";
            lblNearestGoalDate.Size = new Size(50, 20);
            lblNearestGoalDate.TabIndex = 7;
            lblNearestGoalDate.Text = "label109";
            lblNearestGoalDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel27
            // 
            flowLayoutPanel27.BackColor = Color.FromArgb(37, 118, 8);
            flowLayoutPanel27.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel27.Controls.Add(pictureBox8);
            flowLayoutPanel27.Controls.Add(label48);
            flowLayoutPanel27.Dock = DockStyle.Top;
            flowLayoutPanel27.Location = new Point(0, 0);
            flowLayoutPanel27.Name = "flowLayoutPanel27";
            flowLayoutPanel27.Padding = new Padding(3);
            flowLayoutPanel27.Size = new Size(298, 27);
            flowLayoutPanel27.TabIndex = 1;
            // 
            // pictureBox8
            // 
            pictureBox8.Dock = DockStyle.Bottom;
            pictureBox8.Image = Properties.Resources.EditIcon;
            pictureBox8.Location = new Point(6, 6);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(16, 16);
            pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox8.TabIndex = 2;
            pictureBox8.TabStop = false;
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Dock = DockStyle.Left;
            label48.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label48.ForeColor = Color.White;
            label48.Location = new Point(28, 3);
            label48.Name = "label48";
            label48.Size = new Size(39, 22);
            label48.TabIndex = 3;
            label48.Text = "Цели";
            label48.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // debtPanel
            // 
            debtPanel.BorderStyle = BorderStyle.FixedSingle;
            debtPanel.Controls.Add(tableLayoutPanel48);
            debtPanel.Controls.Add(flowLayoutPanel28);
            debtPanel.Location = new Point(309, 415);
            debtPanel.Name = "debtPanel";
            debtPanel.Size = new Size(300, 200);
            debtPanel.TabIndex = 7;
            debtPanel.Tag = "Долги";
            // 
            // tableLayoutPanel48
            // 
            tableLayoutPanel48.ColumnCount = 3;
            tableLayoutPanel48.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel48.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel48.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel48.Controls.Add(label110, 0, 0);
            tableLayoutPanel48.Controls.Add(label111, 0, 1);
            tableLayoutPanel48.Controls.Add(label112, 0, 2);
            tableLayoutPanel48.Controls.Add(label113, 0, 4);
            tableLayoutPanel48.Controls.Add(label114, 0, 5);
            tableLayoutPanel48.Controls.Add(label115, 0, 6);
            tableLayoutPanel48.Controls.Add(lblTotalGivenDebt, 2, 0);
            tableLayoutPanel48.Controls.Add(lblOverdueGivenDebt, 2, 1);
            tableLayoutPanel48.Controls.Add(lblNextGivenDueDate, 2, 2);
            tableLayoutPanel48.Controls.Add(lblTotalReceivedDebt, 2, 4);
            tableLayoutPanel48.Controls.Add(lblOverdueReceivedDebt, 2, 5);
            tableLayoutPanel48.Controls.Add(lblNextReceivedDueDate, 2, 6);
            tableLayoutPanel48.Controls.Add(pictureBox27, 1, 0);
            tableLayoutPanel48.Controls.Add(pictureBox28, 1, 4);
            tableLayoutPanel48.Dock = DockStyle.Fill;
            tableLayoutPanel48.Location = new Point(0, 27);
            tableLayoutPanel48.Name = "tableLayoutPanel48";
            tableLayoutPanel48.RowCount = 8;
            tableLayoutPanel48.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel48.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel48.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel48.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel48.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel48.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel48.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel48.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel48.Size = new Size(298, 171);
            tableLayoutPanel48.TabIndex = 2;
            // 
            // label110
            // 
            label110.AutoSize = true;
            label110.Dock = DockStyle.Left;
            label110.Location = new Point(3, 0);
            label110.Name = "label110";
            label110.Size = new Size(52, 20);
            label110.TabIndex = 0;
            label110.Text = "Выдано:";
            label110.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label111
            // 
            label111.AutoSize = true;
            label111.Dock = DockStyle.Left;
            label111.Location = new Point(3, 20);
            label111.Name = "label111";
            label111.Size = new Size(80, 20);
            label111.TabIndex = 1;
            label111.Text = "Просрочено:";
            label111.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label112
            // 
            label112.AutoSize = true;
            label112.Dock = DockStyle.Left;
            label112.Location = new Point(3, 40);
            label112.Name = "label112";
            label112.Size = new Size(78, 20);
            label112.TabIndex = 2;
            label112.Text = "Ближайший:";
            label112.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label113
            // 
            label113.AutoSize = true;
            label113.Dock = DockStyle.Left;
            label113.Location = new Point(3, 80);
            label113.Name = "label113";
            label113.Size = new Size(66, 20);
            label113.TabIndex = 3;
            label113.Text = "Получено:";
            label113.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label114
            // 
            label114.AutoSize = true;
            label114.Dock = DockStyle.Left;
            label114.Location = new Point(3, 100);
            label114.Name = "label114";
            label114.Size = new Size(80, 20);
            label114.TabIndex = 4;
            label114.Text = "Просрочено:";
            label114.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label115
            // 
            label115.AutoSize = true;
            label115.Dock = DockStyle.Left;
            label115.Location = new Point(3, 120);
            label115.Name = "label115";
            label115.Size = new Size(78, 20);
            label115.TabIndex = 5;
            label115.Text = "Ближайший:";
            label115.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalGivenDebt
            // 
            lblTotalGivenDebt.AutoSize = true;
            lblTotalGivenDebt.Dock = DockStyle.Left;
            lblTotalGivenDebt.Location = new Point(189, 0);
            lblTotalGivenDebt.Name = "lblTotalGivenDebt";
            lblTotalGivenDebt.Size = new Size(50, 20);
            lblTotalGivenDebt.TabIndex = 6;
            lblTotalGivenDebt.Text = "label116";
            lblTotalGivenDebt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOverdueGivenDebt
            // 
            lblOverdueGivenDebt.AutoSize = true;
            lblOverdueGivenDebt.Dock = DockStyle.Left;
            lblOverdueGivenDebt.Location = new Point(189, 20);
            lblOverdueGivenDebt.Name = "lblOverdueGivenDebt";
            lblOverdueGivenDebt.Size = new Size(50, 20);
            lblOverdueGivenDebt.TabIndex = 7;
            lblOverdueGivenDebt.Text = "label117";
            lblOverdueGivenDebt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNextGivenDueDate
            // 
            lblNextGivenDueDate.AutoSize = true;
            lblNextGivenDueDate.Dock = DockStyle.Left;
            lblNextGivenDueDate.Location = new Point(189, 40);
            lblNextGivenDueDate.Name = "lblNextGivenDueDate";
            lblNextGivenDueDate.Size = new Size(50, 20);
            lblNextGivenDueDate.TabIndex = 8;
            lblNextGivenDueDate.Text = "label118";
            lblNextGivenDueDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalReceivedDebt
            // 
            lblTotalReceivedDebt.AutoSize = true;
            lblTotalReceivedDebt.Dock = DockStyle.Left;
            lblTotalReceivedDebt.Location = new Point(189, 80);
            lblTotalReceivedDebt.Name = "lblTotalReceivedDebt";
            lblTotalReceivedDebt.Size = new Size(50, 20);
            lblTotalReceivedDebt.TabIndex = 9;
            lblTotalReceivedDebt.Text = "label119";
            lblTotalReceivedDebt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOverdueReceivedDebt
            // 
            lblOverdueReceivedDebt.AutoSize = true;
            lblOverdueReceivedDebt.Dock = DockStyle.Left;
            lblOverdueReceivedDebt.Location = new Point(189, 100);
            lblOverdueReceivedDebt.Name = "lblOverdueReceivedDebt";
            lblOverdueReceivedDebt.Size = new Size(50, 20);
            lblOverdueReceivedDebt.TabIndex = 10;
            lblOverdueReceivedDebt.Text = "label120";
            lblOverdueReceivedDebt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNextReceivedDueDate
            // 
            lblNextReceivedDueDate.AutoSize = true;
            lblNextReceivedDueDate.Dock = DockStyle.Left;
            lblNextReceivedDueDate.Location = new Point(189, 120);
            lblNextReceivedDueDate.Name = "lblNextReceivedDueDate";
            lblNextReceivedDueDate.Size = new Size(50, 20);
            lblNextReceivedDueDate.TabIndex = 11;
            lblNextReceivedDueDate.Text = "label121";
            lblNextReceivedDueDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox27
            // 
            pictureBox27.Location = new Point(169, 3);
            pictureBox27.Name = "pictureBox27";
            pictureBox27.Size = new Size(14, 14);
            pictureBox27.TabIndex = 12;
            pictureBox27.TabStop = false;
            // 
            // pictureBox28
            // 
            pictureBox28.Location = new Point(169, 83);
            pictureBox28.Name = "pictureBox28";
            pictureBox28.Size = new Size(14, 14);
            pictureBox28.TabIndex = 13;
            pictureBox28.TabStop = false;
            // 
            // flowLayoutPanel28
            // 
            flowLayoutPanel28.BackColor = Color.FromArgb(37, 118, 8);
            flowLayoutPanel28.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel28.Controls.Add(pictureBox9);
            flowLayoutPanel28.Controls.Add(label49);
            flowLayoutPanel28.Dock = DockStyle.Top;
            flowLayoutPanel28.Location = new Point(0, 0);
            flowLayoutPanel28.Name = "flowLayoutPanel28";
            flowLayoutPanel28.Padding = new Padding(3);
            flowLayoutPanel28.Size = new Size(298, 27);
            flowLayoutPanel28.TabIndex = 1;
            // 
            // pictureBox9
            // 
            pictureBox9.Dock = DockStyle.Bottom;
            pictureBox9.Image = Properties.Resources.EditIcon;
            pictureBox9.Location = new Point(6, 6);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(16, 16);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 2;
            pictureBox9.TabStop = false;
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Dock = DockStyle.Left;
            label49.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label49.ForeColor = Color.White;
            label49.Location = new Point(28, 3);
            label49.Name = "label49";
            label49.Size = new Size(43, 22);
            label49.TabIndex = 3;
            label49.Text = "Долги";
            label49.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // progressPanel
            // 
            progressPanel.BorderStyle = BorderStyle.FixedSingle;
            progressPanel.Controls.Add(tableLayoutPanel49);
            progressPanel.Controls.Add(flowLayoutPanel29);
            progressPanel.Location = new Point(615, 415);
            progressPanel.Name = "progressPanel";
            progressPanel.Size = new Size(300, 200);
            progressPanel.TabIndex = 8;
            progressPanel.Tag = "Достижения";
            // 
            // tableLayoutPanel49
            // 
            tableLayoutPanel49.ColumnCount = 3;
            tableLayoutPanel49.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel49.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel49.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel49.Controls.Add(label122, 0, 0);
            tableLayoutPanel49.Controls.Add(label123, 0, 1);
            tableLayoutPanel49.Controls.Add(label124, 0, 3);
            tableLayoutPanel49.Controls.Add(label125, 0, 4);
            tableLayoutPanel49.Controls.Add(label126, 2, 0);
            tableLayoutPanel49.Controls.Add(label127, 2, 1);
            tableLayoutPanel49.Controls.Add(label128, 2, 3);
            tableLayoutPanel49.Controls.Add(label129, 2, 4);
            tableLayoutPanel49.Controls.Add(pictureBox23, 1, 0);
            tableLayoutPanel49.Controls.Add(pictureBox24, 1, 1);
            tableLayoutPanel49.Controls.Add(pictureBox25, 1, 3);
            tableLayoutPanel49.Controls.Add(pictureBox26, 1, 4);
            tableLayoutPanel49.Dock = DockStyle.Fill;
            tableLayoutPanel49.Location = new Point(0, 27);
            tableLayoutPanel49.Name = "tableLayoutPanel49";
            tableLayoutPanel49.RowCount = 8;
            tableLayoutPanel49.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel49.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel49.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel49.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel49.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel49.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel49.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel49.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel49.Size = new Size(298, 171);
            tableLayoutPanel49.TabIndex = 2;
            // 
            // label122
            // 
            label122.AutoSize = true;
            label122.Dock = DockStyle.Left;
            label122.Location = new Point(3, 0);
            label122.Name = "label122";
            label122.Size = new Size(96, 20);
            label122.TabIndex = 0;
            label122.Text = "Удачный месяц:";
            label122.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label123
            // 
            label123.AutoSize = true;
            label123.Dock = DockStyle.Left;
            label123.Location = new Point(3, 20);
            label123.Name = "label123";
            label123.Size = new Size(113, 20);
            label123.TabIndex = 1;
            label123.Text = "Экономный месяц:";
            label123.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label124
            // 
            label124.AutoSize = true;
            label124.Dock = DockStyle.Left;
            label124.Location = new Point(3, 60);
            label124.Name = "label124";
            label124.Size = new Size(118, 20);
            label124.TabIndex = 2;
            label124.Text = "Провальный месяц:";
            label124.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label125
            // 
            label125.AutoSize = true;
            label125.Dock = DockStyle.Left;
            label125.Location = new Point(3, 80);
            label125.Name = "label125";
            label125.Size = new Size(106, 20);
            label125.TabIndex = 3;
            label125.Text = "Затратный месяц:";
            label125.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label126
            // 
            label126.AutoSize = true;
            label126.Dock = DockStyle.Left;
            label126.Location = new Point(189, 0);
            label126.Name = "label126";
            label126.Size = new Size(50, 20);
            label126.TabIndex = 4;
            label126.Text = "label126";
            label126.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label127
            // 
            label127.AutoSize = true;
            label127.Dock = DockStyle.Left;
            label127.Location = new Point(189, 20);
            label127.Name = "label127";
            label127.Size = new Size(50, 20);
            label127.TabIndex = 5;
            label127.Text = "label127";
            label127.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label128
            // 
            label128.AutoSize = true;
            label128.Dock = DockStyle.Left;
            label128.Location = new Point(189, 60);
            label128.Name = "label128";
            label128.Size = new Size(50, 20);
            label128.TabIndex = 6;
            label128.Text = "label128";
            label128.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label129
            // 
            label129.AutoSize = true;
            label129.Dock = DockStyle.Left;
            label129.Location = new Point(189, 80);
            label129.Name = "label129";
            label129.Size = new Size(50, 20);
            label129.TabIndex = 7;
            label129.Text = "label129";
            label129.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox23
            // 
            pictureBox23.Location = new Point(169, 3);
            pictureBox23.Name = "pictureBox23";
            pictureBox23.Size = new Size(14, 14);
            pictureBox23.TabIndex = 8;
            pictureBox23.TabStop = false;
            // 
            // pictureBox24
            // 
            pictureBox24.Location = new Point(169, 23);
            pictureBox24.Name = "pictureBox24";
            pictureBox24.Size = new Size(14, 14);
            pictureBox24.TabIndex = 9;
            pictureBox24.TabStop = false;
            // 
            // pictureBox25
            // 
            pictureBox25.Location = new Point(169, 63);
            pictureBox25.Name = "pictureBox25";
            pictureBox25.Size = new Size(14, 14);
            pictureBox25.TabIndex = 10;
            pictureBox25.TabStop = false;
            // 
            // pictureBox26
            // 
            pictureBox26.Location = new Point(169, 83);
            pictureBox26.Name = "pictureBox26";
            pictureBox26.Size = new Size(14, 14);
            pictureBox26.TabIndex = 11;
            pictureBox26.TabStop = false;
            // 
            // flowLayoutPanel29
            // 
            flowLayoutPanel29.BackColor = Color.FromArgb(37, 118, 8);
            flowLayoutPanel29.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel29.Controls.Add(pictureBox10);
            flowLayoutPanel29.Controls.Add(label50);
            flowLayoutPanel29.Dock = DockStyle.Top;
            flowLayoutPanel29.Location = new Point(0, 0);
            flowLayoutPanel29.Name = "flowLayoutPanel29";
            flowLayoutPanel29.Padding = new Padding(3);
            flowLayoutPanel29.Size = new Size(298, 27);
            flowLayoutPanel29.TabIndex = 1;
            // 
            // pictureBox10
            // 
            pictureBox10.Dock = DockStyle.Bottom;
            pictureBox10.Image = Properties.Resources.EditIcon;
            pictureBox10.Location = new Point(6, 6);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(16, 16);
            pictureBox10.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox10.TabIndex = 2;
            pictureBox10.TabStop = false;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Dock = DockStyle.Left;
            label50.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label50.ForeColor = Color.White;
            label50.Location = new Point(28, 3);
            label50.Name = "label50";
            label50.Size = new Size(81, 22);
            label50.TabIndex = 3;
            label50.Text = "Достижения";
            label50.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tpAccounts
            // 
            tpAccounts.Controls.Add(tableLayoutPanel18);
            tpAccounts.Controls.Add(tableLayoutPanel2);
            tpAccounts.Location = new Point(4, 24);
            tpAccounts.Name = "tpAccounts";
            tpAccounts.Size = new Size(942, 679);
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
            tableLayoutPanel18.Size = new Size(942, 579);
            tableLayoutPanel18.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.FromArgb(0, 37, 118, 8);
            label9.Location = new Point(8, 5);
            label9.Name = "label9";
            label9.Size = new Size(926, 26);
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
            flowLayoutPanel3.Size = new Size(926, 40);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // btnAddAccounts
            // 
            btnAddAccounts.Image = Properties.Resources.PlusIcon;
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
            btnTransferAccount.Image = Properties.Resources.TransferIcon;
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
            btnEditAccount.Image = Properties.Resources.EditIcon;
            btnEditAccount.Location = new Point(228, 8);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(23, 23);
            btnEditAccount.TabIndex = 1;
            btnEditAccount.UseVisualStyleBackColor = true;
            btnEditAccount.Click += btnEditAccounts_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Image = Properties.Resources.MinusIcon;
            btnDeleteAccount.Location = new Point(257, 8);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(23, 23);
            btnDeleteAccount.TabIndex = 2;
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccounts_Click;
            // 
            // btnPrintAccounts
            // 
            btnPrintAccounts.Image = Properties.Resources.PrintIcon;
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
            dgwAccounts.AllowUserToOrderColumns = true;
            dgwAccounts.AllowUserToResizeRows = false;
            dgwAccounts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwAccounts.ContextMenuStrip = contextMenu;
            dgwAccounts.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwAccounts.Location = new Point(8, 80);
            dgwAccounts.MultiSelect = false;
            dgwAccounts.Name = "dgwAccounts";
            dgwAccounts.RowHeadersVisible = false;
            dgwAccounts.RowHeadersWidth = 51;
            dgwAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwAccounts.Size = new Size(926, 491);
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
            contextMenu.Closing += Menu_Closing;
            contextMenu.Opening += contextMenu_Opening;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(tbDetailsAccount, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 579);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(942, 100);
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
            tbDetailsAccount.Size = new Size(826, 89);
            tbDetailsAccount.TabIndex = 1;
            // 
            // tpExpenses
            // 
            tpExpenses.Controls.Add(tableLayoutPanel19);
            tpExpenses.Controls.Add(tableLayoutPanel3);
            tpExpenses.Location = new Point(4, 24);
            tpExpenses.Name = "tpExpenses";
            tpExpenses.Size = new Size(942, 679);
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
            tableLayoutPanel19.Name = "tableLayoutPanel19";
            tableLayoutPanel19.Padding = new Padding(5);
            tableLayoutPanel19.RowCount = 3;
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel19.RowStyles.Add(new RowStyle());
            tableLayoutPanel19.RowStyles.Add(new RowStyle());
            tableLayoutPanel19.RowStyles.Add(new RowStyle());
            tableLayoutPanel19.Size = new Size(942, 579);
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
            dgwExpenses.Location = new Point(8, 80);
            dgwExpenses.MultiSelect = false;
            dgwExpenses.Name = "dgwExpenses";
            dgwExpenses.RowHeadersVisible = false;
            dgwExpenses.RowHeadersWidth = 51;
            dgwExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwExpenses.Size = new Size(926, 491);
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
            lblPageExpensesCaption.ForeColor = Color.FromArgb(0, 37, 118, 8);
            lblPageExpensesCaption.Location = new Point(8, 5);
            lblPageExpensesCaption.Name = "lblPageExpensesCaption";
            lblPageExpensesCaption.Size = new Size(926, 26);
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
            flowLayoutPanel6.Location = new Point(8, 34);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Padding = new Padding(5);
            flowLayoutPanel6.Size = new Size(926, 40);
            flowLayoutPanel6.TabIndex = 1;
            // 
            // btnAddExpenses
            // 
            btnAddExpenses.Image = Properties.Resources.PlusIcon;
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
            btnEditExpenses1.Image = Properties.Resources.StarIcon;
            btnEditExpenses1.Location = new Point(118, 8);
            btnEditExpenses1.Name = "btnEditExpenses1";
            btnEditExpenses1.Size = new Size(104, 23);
            btnEditExpenses1.TabIndex = 1;
            btnEditExpenses1.Text = "Шаблоны";
            btnEditExpenses1.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditExpenses1.UseVisualStyleBackColor = true;
            btnEditExpenses1.Click += btnEditExpenses1_Click;
            // 
            // btnEditExpenses
            // 
            btnEditExpenses.Image = Properties.Resources.EditIcon;
            btnEditExpenses.Location = new Point(228, 8);
            btnEditExpenses.Name = "btnEditExpenses";
            btnEditExpenses.Size = new Size(23, 23);
            btnEditExpenses.TabIndex = 2;
            btnEditExpenses.UseVisualStyleBackColor = true;
            btnEditExpenses.Click += btnEditExpenses_Click;
            // 
            // btnDeleteExpenses
            // 
            btnDeleteExpenses.Image = Properties.Resources.MinusIcon;
            btnDeleteExpenses.Location = new Point(257, 8);
            btnDeleteExpenses.Name = "btnDeleteExpenses";
            btnDeleteExpenses.Size = new Size(23, 23);
            btnDeleteExpenses.TabIndex = 3;
            btnDeleteExpenses.UseVisualStyleBackColor = true;
            btnDeleteExpenses.Click += btnDeleteExpenses_Click;
            // 
            // btnPrintExpenses
            // 
            btnPrintExpenses.Image = Properties.Resources.PrintIcon;
            btnPrintExpenses.Location = new Point(286, 8);
            btnPrintExpenses.Name = "btnPrintExpenses";
            btnPrintExpenses.Size = new Size(23, 23);
            btnPrintExpenses.TabIndex = 6;
            btnPrintExpenses.UseVisualStyleBackColor = true;
            // 
            // cmbExpenseMonths
            // 
            cmbExpenseMonths.FormattingEnabled = true;
            cmbExpenseMonths.Location = new Point(315, 8);
            cmbExpenseMonths.Name = "cmbExpenseMonths";
            cmbExpenseMonths.Size = new Size(84, 23);
            cmbExpenseMonths.TabIndex = 4;
            // 
            // cmbExpenseYears
            // 
            cmbExpenseYears.FormattingEnabled = true;
            cmbExpenseYears.Location = new Point(405, 8);
            cmbExpenseYears.Name = "cmbExpenseYears";
            cmbExpenseYears.Size = new Size(80, 23);
            cmbExpenseYears.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(tbDetailsExpenses, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(0, 579);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(942, 100);
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
            tbDetailsExpenses.Size = new Size(826, 90);
            tbDetailsExpenses.TabIndex = 1;
            // 
            // tpIncome
            // 
            tpIncome.Controls.Add(tableLayoutPanel20);
            tpIncome.Controls.Add(tableLayoutPanel6);
            tpIncome.Location = new Point(4, 24);
            tpIncome.Name = "tpIncome";
            tpIncome.Size = new Size(942, 679);
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
            tableLayoutPanel20.Name = "tableLayoutPanel20";
            tableLayoutPanel20.Padding = new Padding(5);
            tableLayoutPanel20.RowCount = 3;
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel20.RowStyles.Add(new RowStyle());
            tableLayoutPanel20.RowStyles.Add(new RowStyle());
            tableLayoutPanel20.RowStyles.Add(new RowStyle());
            tableLayoutPanel20.Size = new Size(942, 579);
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
            dgwIncomes.Location = new Point(8, 80);
            dgwIncomes.MultiSelect = false;
            dgwIncomes.Name = "dgwIncomes";
            dgwIncomes.RowHeadersVisible = false;
            dgwIncomes.RowHeadersWidth = 51;
            dgwIncomes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwIncomes.Size = new Size(926, 491);
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
            lblPageIncomesCaption.ForeColor = Color.FromArgb(0, 37, 118, 8);
            lblPageIncomesCaption.Location = new Point(8, 5);
            lblPageIncomesCaption.Name = "lblPageIncomesCaption";
            lblPageIncomesCaption.Size = new Size(926, 26);
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
            flowLayoutPanel8.Location = new Point(8, 34);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Padding = new Padding(5);
            flowLayoutPanel8.Size = new Size(926, 40);
            flowLayoutPanel8.TabIndex = 1;
            // 
            // btnAddIncomes
            // 
            btnAddIncomes.Image = Properties.Resources.PlusIcon;
            btnAddIncomes.Location = new Point(8, 8);
            btnAddIncomes.Name = "btnAddIncomes";
            btnAddIncomes.Size = new Size(104, 23);
            btnAddIncomes.TabIndex = 0;
            btnAddIncomes.Text = "Добавить";
            btnAddIncomes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddIncomes.UseVisualStyleBackColor = true;
            btnAddIncomes.Click += btnAddIncomes_Click;
            // 
            // btnEditIncomes
            // 
            btnEditIncomes.Image = Properties.Resources.EditIcon;
            btnEditIncomes.Location = new Point(118, 8);
            btnEditIncomes.Name = "btnEditIncomes";
            btnEditIncomes.Size = new Size(23, 23);
            btnEditIncomes.TabIndex = 1;
            btnEditIncomes.UseVisualStyleBackColor = true;
            btnEditIncomes.Click += btnEditIncomes_Click;
            // 
            // btnDeleteIncomes
            // 
            btnDeleteIncomes.Image = Properties.Resources.MinusIcon;
            btnDeleteIncomes.Location = new Point(147, 8);
            btnDeleteIncomes.Name = "btnDeleteIncomes";
            btnDeleteIncomes.Size = new Size(23, 23);
            btnDeleteIncomes.TabIndex = 2;
            btnDeleteIncomes.UseVisualStyleBackColor = true;
            btnDeleteIncomes.Click += btnDeleteIncomes_Click;
            // 
            // btnPrintIncomes
            // 
            btnPrintIncomes.Image = Properties.Resources.PrintIcon;
            btnPrintIncomes.Location = new Point(176, 8);
            btnPrintIncomes.Name = "btnPrintIncomes";
            btnPrintIncomes.Size = new Size(23, 23);
            btnPrintIncomes.TabIndex = 8;
            btnPrintIncomes.UseVisualStyleBackColor = true;
            // 
            // cmbIncomeMonths
            // 
            cmbIncomeMonths.FormattingEnabled = true;
            cmbIncomeMonths.Location = new Point(205, 8);
            cmbIncomeMonths.Name = "cmbIncomeMonths";
            cmbIncomeMonths.Size = new Size(100, 23);
            cmbIncomeMonths.TabIndex = 6;
            // 
            // cmbIncomeYears
            // 
            cmbIncomeYears.FormattingEnabled = true;
            cmbIncomeYears.Location = new Point(311, 8);
            cmbIncomeYears.Name = "cmbIncomeYears";
            cmbIncomeYears.Size = new Size(80, 23);
            cmbIncomeYears.TabIndex = 7;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label4, 0, 0);
            tableLayoutPanel6.Controls.Add(tbDetailsIncome, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Bottom;
            tableLayoutPanel6.Location = new Point(0, 579);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.Size = new Size(942, 100);
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
            tbDetailsIncome.Size = new Size(826, 90);
            tbDetailsIncome.TabIndex = 1;
            // 
            // tpCategory
            // 
            tpCategory.Controls.Add(tableLayoutPanel1);
            tpCategory.Location = new Point(4, 24);
            tpCategory.Name = "tpCategory";
            tpCategory.Size = new Size(942, 679);
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(942, 679);
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
            tableLayoutPanel25.Location = new Point(471, 0);
            tableLayoutPanel25.Margin = new Padding(0);
            tableLayoutPanel25.Name = "tableLayoutPanel25";
            tableLayoutPanel25.Padding = new Padding(5);
            tableLayoutPanel25.RowCount = 3;
            tableLayoutPanel25.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel25.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel25.RowStyles.Add(new RowStyle());
            tableLayoutPanel25.Size = new Size(471, 573);
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
            dgwSubCategories.Location = new Point(8, 80);
            dgwSubCategories.MultiSelect = false;
            dgwSubCategories.Name = "dgwSubCategories";
            dgwSubCategories.RowHeadersVisible = false;
            dgwSubCategories.RowHeadersWidth = 51;
            dgwSubCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwSubCategories.Size = new Size(455, 485);
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
            label33.ForeColor = Color.FromArgb(0, 37, 118, 8);
            label33.Location = new Point(8, 5);
            label33.Name = "label33";
            label33.Size = new Size(455, 26);
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
            flowLayoutPanel13.Size = new Size(455, 40);
            flowLayoutPanel13.TabIndex = 1;
            // 
            // btnAddSubCategories
            // 
            btnAddSubCategories.Image = Properties.Resources.PlusIcon;
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
            btnEditSubCategories.Image = Properties.Resources.EditIcon;
            btnEditSubCategories.Location = new Point(118, 8);
            btnEditSubCategories.Name = "btnEditSubCategories";
            btnEditSubCategories.Size = new Size(23, 23);
            btnEditSubCategories.TabIndex = 1;
            btnEditSubCategories.UseVisualStyleBackColor = true;
            btnEditSubCategories.Click += btnEditSubCategories_Click;
            // 
            // btnDeleteSubCategories
            // 
            btnDeleteSubCategories.Image = Properties.Resources.MinusIcon;
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
            tableLayoutPanel24.Size = new Size(471, 573);
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
            dgwCategorie.Location = new Point(8, 80);
            dgwCategorie.MultiSelect = false;
            dgwCategorie.Name = "dgwCategorie";
            dgwCategorie.RowHeadersVisible = false;
            dgwCategorie.RowHeadersWidth = 51;
            dgwCategorie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwCategorie.Size = new Size(455, 485);
            dgwCategorie.TabIndex = 3;
            dgwCategorie.CellDoubleClick += dgwCategorie_CellDoubleClick;
            dgwCategorie.SelectionChanged += dataGridViewCategories_SelectionChanged;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Dock = DockStyle.Fill;
            label32.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label32.ForeColor = Color.FromArgb(0, 37, 118, 8);
            label32.Location = new Point(8, 5);
            label32.Name = "label32";
            label32.Size = new Size(455, 26);
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
            flowLayoutPanel12.Size = new Size(455, 40);
            flowLayoutPanel12.TabIndex = 1;
            // 
            // btnAddCategories
            // 
            btnAddCategories.Image = Properties.Resources.PlusIcon;
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
            btnEditCategories.Image = Properties.Resources.EditIcon;
            btnEditCategories.Location = new Point(118, 8);
            btnEditCategories.Name = "btnEditCategories";
            btnEditCategories.Size = new Size(23, 23);
            btnEditCategories.TabIndex = 1;
            btnEditCategories.UseVisualStyleBackColor = true;
            btnEditCategories.Click += btnEditCategories_Click;
            // 
            // btnDeleteCategories
            // 
            btnDeleteCategories.Image = Properties.Resources.MinusIcon;
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
            tableLayoutPanel17.Location = new Point(474, 576);
            tableLayoutPanel17.Name = "tableLayoutPanel17";
            tableLayoutPanel17.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel17.RowCount = 1;
            tableLayoutPanel17.RowStyles.Add(new RowStyle());
            tableLayoutPanel17.Size = new Size(465, 100);
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
            tbDetailsSubCategory.Size = new Size(349, 92);
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
            tableLayoutPanel16.Location = new Point(3, 576);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel16.RowCount = 1;
            tableLayoutPanel16.RowStyles.Add(new RowStyle());
            tableLayoutPanel16.Size = new Size(465, 100);
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
            tbDetailsCategory.Size = new Size(349, 92);
            tbDetailsCategory.TabIndex = 1;
            // 
            // tpSource
            // 
            tpSource.Controls.Add(tableLayoutPanel21);
            tpSource.Controls.Add(tableLayoutPanel9);
            tpSource.Location = new Point(4, 24);
            tpSource.Name = "tpSource";
            tpSource.Size = new Size(942, 679);
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
            tableLayoutPanel21.Size = new Size(942, 579);
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
            dgwSource.Location = new Point(8, 80);
            dgwSource.MultiSelect = false;
            dgwSource.Name = "dgwSource";
            dgwSource.RowHeadersVisible = false;
            dgwSource.RowHeadersWidth = 51;
            dgwSource.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwSource.Size = new Size(926, 491);
            dgwSource.TabIndex = 3;
            dgwSource.CellDoubleClick += dgwSource_CellDoubleClick;
            dgwSource.SelectionChanged += dataGridViewSources_SelectionChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Dock = DockStyle.Fill;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label22.ForeColor = Color.FromArgb(0, 37, 118, 8);
            label22.Location = new Point(8, 5);
            label22.Name = "label22";
            label22.Size = new Size(926, 26);
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
            flowLayoutPanel9.Size = new Size(926, 40);
            flowLayoutPanel9.TabIndex = 1;
            // 
            // btnAddSources
            // 
            btnAddSources.Image = Properties.Resources.PlusIcon;
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
            btnEditSources.Image = Properties.Resources.EditIcon;
            btnEditSources.Location = new Point(118, 8);
            btnEditSources.Name = "btnEditSources";
            btnEditSources.Size = new Size(23, 23);
            btnEditSources.TabIndex = 1;
            btnEditSources.UseVisualStyleBackColor = true;
            btnEditSources.Click += btnEditSources_Click;
            // 
            // btnDeleteSources
            // 
            btnDeleteSources.Image = Properties.Resources.MinusIcon;
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
            tableLayoutPanel9.Location = new Point(0, 579);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle());
            tableLayoutPanel9.Size = new Size(942, 100);
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
            tbDetailsSource.Size = new Size(826, 90);
            tbDetailsSource.TabIndex = 1;
            // 
            // tpAdditionally
            // 
            tpAdditionally.Controls.Add(tableLayoutPanel22);
            tpAdditionally.Controls.Add(tableLayoutPanel11);
            tpAdditionally.Location = new Point(4, 24);
            tpAdditionally.Name = "tpAdditionally";
            tpAdditionally.Size = new Size(942, 679);
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
            tableLayoutPanel22.Name = "tableLayoutPanel22";
            tableLayoutPanel22.Padding = new Padding(5);
            tableLayoutPanel22.RowCount = 3;
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel22.RowStyles.Add(new RowStyle());
            tableLayoutPanel22.Size = new Size(942, 579);
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
            dgwAdditionals.Location = new Point(8, 80);
            dgwAdditionals.MultiSelect = false;
            dgwAdditionals.Name = "dgwAdditionals";
            dgwAdditionals.RowHeadersVisible = false;
            dgwAdditionals.RowHeadersWidth = 51;
            dgwAdditionals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwAdditionals.Size = new Size(926, 491);
            dgwAdditionals.TabIndex = 3;
            dgwAdditionals.CellDoubleClick += dgwAdditionals_CellDoubleClick;
            dgwAdditionals.SelectionChanged += dataGridViewAdditionals_SelectionChanged;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Dock = DockStyle.Fill;
            label29.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label29.ForeColor = Color.FromArgb(0, 37, 118, 8);
            label29.Location = new Point(8, 5);
            label29.Name = "label29";
            label29.Size = new Size(926, 26);
            label29.TabIndex = 0;
            label29.Text = "Упоминания";
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
            flowLayoutPanel10.Size = new Size(926, 40);
            flowLayoutPanel10.TabIndex = 1;
            // 
            // btnAddAdditionals
            // 
            btnAddAdditionals.Image = Properties.Resources.PlusIcon;
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
            btnEditAdditionals.Image = Properties.Resources.EditIcon;
            btnEditAdditionals.Location = new Point(118, 8);
            btnEditAdditionals.Name = "btnEditAdditionals";
            btnEditAdditionals.Size = new Size(23, 23);
            btnEditAdditionals.TabIndex = 1;
            btnEditAdditionals.UseVisualStyleBackColor = true;
            btnEditAdditionals.Click += btnEditAdditionals_Click;
            // 
            // btnDeleteAdditional
            // 
            btnDeleteAdditional.Image = Properties.Resources.MinusIcon;
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
            tableLayoutPanel11.Location = new Point(0, 579);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle());
            tableLayoutPanel11.Size = new Size(942, 100);
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
            tbDetailsAdditional.Size = new Size(826, 90);
            tbDetailsAdditional.TabIndex = 1;
            // 
            // tpCurrencies
            // 
            tpCurrencies.Controls.Add(tableLayoutPanel23);
            tpCurrencies.Controls.Add(tableLayoutPanel14);
            tpCurrencies.Location = new Point(4, 24);
            tpCurrencies.Name = "tpCurrencies";
            tpCurrencies.Size = new Size(942, 679);
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
            tableLayoutPanel23.Size = new Size(942, 579);
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
            dgwCurrencies.Location = new Point(8, 80);
            dgwCurrencies.MultiSelect = false;
            dgwCurrencies.Name = "dgwCurrencies";
            dgwCurrencies.RowHeadersVisible = false;
            dgwCurrencies.RowHeadersWidth = 51;
            dgwCurrencies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwCurrencies.Size = new Size(926, 491);
            dgwCurrencies.TabIndex = 3;
            dgwCurrencies.CellDoubleClick += dgwCurrencies_CellDoubleClick;
            dgwCurrencies.SelectionChanged += dataGridViewCurrencies_SelectionChanged;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Dock = DockStyle.Fill;
            label31.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label31.ForeColor = Color.FromArgb(0, 37, 118, 8);
            label31.Location = new Point(8, 5);
            label31.Name = "label31";
            label31.Size = new Size(926, 26);
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
            flowLayoutPanel11.Size = new Size(926, 40);
            flowLayoutPanel11.TabIndex = 1;
            // 
            // btnAddCurrency
            // 
            btnAddCurrency.Image = Properties.Resources.PlusIcon;
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
            btnEditCurrency.Image = Properties.Resources.EditIcon;
            btnEditCurrency.Location = new Point(118, 8);
            btnEditCurrency.Name = "btnEditCurrency";
            btnEditCurrency.Size = new Size(23, 23);
            btnEditCurrency.TabIndex = 1;
            btnEditCurrency.UseVisualStyleBackColor = true;
            btnEditCurrency.Click += btnEditCurrencie_Click;
            // 
            // btnDeleteCurrency
            // 
            btnDeleteCurrency.Image = Properties.Resources.MinusIcon;
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
            tableLayoutPanel14.Location = new Point(0, 579);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle());
            tableLayoutPanel14.Size = new Size(942, 100);
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
            tbDetailsCurrency.Size = new Size(826, 90);
            tbDetailsCurrency.TabIndex = 1;
            // 
            // tpReport
            // 
            tpReport.Controls.Add(tableLayoutPanel26);
            tpReport.Location = new Point(4, 24);
            tpReport.Name = "tpReport";
            tpReport.Size = new Size(942, 679);
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
            tableLayoutPanel26.Size = new Size(942, 679);
            tableLayoutPanel26.TabIndex = 4;
            // 
            // plotView1
            // 
            plotView1.Dock = DockStyle.Fill;
            plotView1.Location = new Point(8, 267);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(926, 404);
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
            label34.ForeColor = Color.FromArgb(0, 37, 118, 8);
            label34.Location = new Point(8, 5);
            label34.Name = "label34";
            label34.Size = new Size(926, 26);
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
            filterPanel.Location = new Point(8, 69);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(926, 27);
            filterPanel.TabIndex = 9;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Dock = DockStyle.Fill;
            label35.Location = new Point(3, 0);
            label35.Name = "label35";
            label35.Size = new Size(69, 29);
            label35.TabIndex = 0;
            label35.Text = "Период:  с-";
            label35.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpStartReportDate
            // 
            dtpStartReportDate.Location = new Point(78, 3);
            dtpStartReportDate.Name = "dtpStartReportDate";
            dtpStartReportDate.Size = new Size(129, 23);
            dtpStartReportDate.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Location = new Point(213, 0);
            label13.Name = "label13";
            label13.Size = new Size(32, 29);
            label13.TabIndex = 16;
            label13.Text = " по- ";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpEndReportDate
            // 
            dtpEndReportDate.Location = new Point(251, 3);
            dtpEndReportDate.Name = "dtpEndReportDate";
            dtpEndReportDate.Size = new Size(129, 23);
            dtpEndReportDate.TabIndex = 15;
            // 
            // pnlFilters
            // 
            pnlFilters.Controls.Add(label36);
            pnlFilters.Dock = DockStyle.Fill;
            pnlFilters.Location = new Point(8, 102);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(926, 27);
            pnlFilters.TabIndex = 10;
            pnlFilters.Visible = false;
            // 
            // label36
            // 
            label36.Location = new Point(3, 0);
            label36.Name = "label36";
            label36.Size = new Size(44, 29);
            label36.TabIndex = 0;
            label36.Text = "label36";
            label36.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flPanel3
            // 
            flPanel3.Controls.Add(label37);
            flPanel3.Dock = DockStyle.Fill;
            flPanel3.Location = new Point(8, 135);
            flPanel3.Name = "flPanel3";
            flPanel3.Size = new Size(926, 27);
            flPanel3.TabIndex = 11;
            flPanel3.Visible = false;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(3, 0);
            label37.Name = "label37";
            label37.Size = new Size(44, 15);
            label37.TabIndex = 0;
            label37.Text = "label37";
            // 
            // flPanel4
            // 
            flPanel4.Controls.Add(label38);
            flPanel4.Dock = DockStyle.Fill;
            flPanel4.Location = new Point(8, 168);
            flPanel4.Name = "flPanel4";
            flPanel4.Size = new Size(926, 27);
            flPanel4.TabIndex = 12;
            flPanel4.Visible = false;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(3, 0);
            label38.Name = "label38";
            label38.Size = new Size(44, 15);
            label38.TabIndex = 0;
            label38.Text = "label38";
            // 
            // flPanel5
            // 
            flPanel5.Controls.Add(label39);
            flPanel5.Dock = DockStyle.Fill;
            flPanel5.Location = new Point(8, 201);
            flPanel5.Name = "flPanel5";
            flPanel5.Size = new Size(926, 27);
            flPanel5.TabIndex = 13;
            flPanel5.Visible = false;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(3, 0);
            label39.Name = "label39";
            label39.Size = new Size(44, 15);
            label39.TabIndex = 0;
            label39.Text = "label39";
            // 
            // flPanel6
            // 
            flPanel6.Controls.Add(label40);
            flPanel6.Dock = DockStyle.Fill;
            flPanel6.Location = new Point(8, 234);
            flPanel6.Name = "flPanel6";
            flPanel6.Size = new Size(926, 27);
            flPanel6.TabIndex = 14;
            flPanel6.Visible = false;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(3, 0);
            label40.Name = "label40";
            label40.Size = new Size(44, 15);
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
            flowLayoutPanel14.Location = new Point(8, 34);
            flowLayoutPanel14.Name = "flowLayoutPanel14";
            flowLayoutPanel14.Size = new Size(926, 29);
            flowLayoutPanel14.TabIndex = 15;
            // 
            // cmbReports
            // 
            cmbReports.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReports.FormattingEnabled = true;
            cmbReports.Location = new Point(3, 3);
            cmbReports.Name = "cmbReports";
            cmbReports.Size = new Size(234, 23);
            cmbReports.TabIndex = 9;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = Properties.Resources.RefreshIcon;
            btnRefresh.Location = new Point(243, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(23, 23);
            btnRefresh.TabIndex = 14;
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.PrintIcon;
            button3.Location = new Point(272, 3);
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
            tpSettings.Size = new Size(942, 679);
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
            tableLayoutPanel29.Name = "tableLayoutPanel29";
            tableLayoutPanel29.Padding = new Padding(5);
            tableLayoutPanel29.RowCount = 2;
            tableLayoutPanel29.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel29.RowStyles.Add(new RowStyle());
            tableLayoutPanel29.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel29.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel29.Size = new Size(942, 679);
            tableLayoutPanel29.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.FromArgb(0, 37, 118, 8);
            label11.Location = new Point(8, 5);
            label11.Name = "label11";
            label11.Size = new Size(926, 26);
            label11.TabIndex = 0;
            label11.Text = "Настройки";
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(8, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 637);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(926, 637);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(918, 609);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Общие";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(17, 18);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(200, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Показывать поле комментарий";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(checkedListBox1);
            tabPage2.Controls.Add(btnDown);
            tabPage2.Controls.Add(btnUp);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(918, 609);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Главная страница";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Dock = DockStyle.Left;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(3, 3);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(199, 603);
            checkedListBox1.TabIndex = 3;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // btnDown
            // 
            btnDown.Location = new Point(224, 35);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(75, 23);
            btnDown.TabIndex = 2;
            btnDown.Text = "Ниже";
            btnDown.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            btnUp.Location = new Point(224, 6);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(75, 23);
            btnUp.TabIndex = 1;
            btnUp.Text = "Выше";
            btnUp.UseVisualStyleBackColor = true;
            // 
            // tpAbout
            // 
            tpAbout.Controls.Add(tableLayoutPanel27);
            tpAbout.Location = new Point(4, 24);
            tpAbout.Name = "tpAbout";
            tpAbout.Size = new Size(942, 679);
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
            tableLayoutPanel27.Controls.Add(flowLayoutPanel18, 0, 3);
            tableLayoutPanel27.Dock = DockStyle.Fill;
            tableLayoutPanel27.Location = new Point(0, 0);
            tableLayoutPanel27.Name = "tableLayoutPanel27";
            tableLayoutPanel27.Padding = new Padding(5);
            tableLayoutPanel27.RowCount = 4;
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel27.Size = new Size(942, 679);
            tableLayoutPanel27.TabIndex = 5;
            // 
            // tbVersionHistory
            // 
            tbVersionHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbVersionHistory.BackColor = SystemColors.Window;
            tbVersionHistory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbVersionHistory.Location = new Point(10, 136);
            tbVersionHistory.Margin = new Padding(5);
            tbVersionHistory.Multiline = true;
            tbVersionHistory.Name = "tbVersionHistory";
            tbVersionHistory.ReadOnly = true;
            tbVersionHistory.ScrollBars = ScrollBars.Both;
            tbVersionHistory.Size = new Size(922, 487);
            tbVersionHistory.TabIndex = 6;
            tbVersionHistory.Text = resources.GetString("tbVersionHistory.Text");
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.FromArgb(0, 37, 118, 8);
            label10.Location = new Point(8, 5);
            label10.Name = "label10";
            label10.Size = new Size(926, 26);
            label10.TabIndex = 0;
            label10.Text = "О программе";
            // 
            // tableLayoutPanel28
            // 
            tableLayoutPanel28.ColumnCount = 2;
            tableLayoutPanel28.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            tableLayoutPanel28.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel28.Controls.Add(tbAbout, 1, 0);
            tableLayoutPanel28.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel28.Dock = DockStyle.Fill;
            tableLayoutPanel28.Location = new Point(5, 31);
            tableLayoutPanel28.Margin = new Padding(0);
            tableLayoutPanel28.Name = "tableLayoutPanel28";
            tableLayoutPanel28.RowCount = 1;
            tableLayoutPanel28.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel28.Size = new Size(932, 100);
            tableLayoutPanel28.TabIndex = 4;
            // 
            // tbAbout
            // 
            tbAbout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbAbout.BackColor = SystemColors.Window;
            tbAbout.Location = new Point(99, 5);
            tbAbout.Margin = new Padding(5);
            tbAbout.Multiline = true;
            tbAbout.Name = "tbAbout";
            tbAbout.ReadOnly = true;
            tbAbout.ScrollBars = ScrollBars.Both;
            tbAbout.Size = new Size(828, 90);
            tbAbout.TabIndex = 6;
            tbAbout.Text = resources.GetString("tbAbout.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // flowLayoutPanel18
            // 
            flowLayoutPanel18.Controls.Add(button2);
            flowLayoutPanel18.Controls.Add(button4);
            flowLayoutPanel18.Dock = DockStyle.Fill;
            flowLayoutPanel18.Location = new Point(8, 631);
            flowLayoutPanel18.Name = "flowLayoutPanel18";
            flowLayoutPanel18.Padding = new Padding(5);
            flowLayoutPanel18.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel18.Size = new Size(926, 40);
            flowLayoutPanel18.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(763, 8);
            button2.Name = "button2";
            button2.Size = new Size(150, 23);
            button2.TabIndex = 0;
            button2.Text = "Обновить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += CheckForUpdatesButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(607, 8);
            button4.Name = "button4";
            button4.Size = new Size(150, 23);
            button4.TabIndex = 1;
            button4.Text = "Отправить отзыв";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tpDebtGiven
            // 
            tpDebtGiven.Controls.Add(tableLayoutPanel33);
            tpDebtGiven.Controls.Add(tableLayoutPanel31);
            tpDebtGiven.Location = new Point(4, 24);
            tpDebtGiven.Name = "tpDebtGiven";
            tpDebtGiven.Size = new Size(942, 679);
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
            tableLayoutPanel33.Name = "tableLayoutPanel33";
            tableLayoutPanel33.Padding = new Padding(5);
            tableLayoutPanel33.RowCount = 3;
            tableLayoutPanel33.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel33.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel33.RowStyles.Add(new RowStyle());
            tableLayoutPanel33.Size = new Size(942, 579);
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
            dgwGivenDebts.Location = new Point(8, 80);
            dgwGivenDebts.MultiSelect = false;
            dgwGivenDebts.Name = "dgwGivenDebts";
            dgwGivenDebts.RowHeadersVisible = false;
            dgwGivenDebts.RowHeadersWidth = 51;
            dgwGivenDebts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwGivenDebts.Size = new Size(926, 491);
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
            lblGivenDebtsTotal.ForeColor = Color.FromArgb(0, 37, 118, 8);
            lblGivenDebtsTotal.Location = new Point(8, 5);
            lblGivenDebtsTotal.Name = "lblGivenDebtsTotal";
            lblGivenDebtsTotal.Size = new Size(926, 26);
            lblGivenDebtsTotal.TabIndex = 0;
            lblGivenDebtsTotal.Text = "Долги выданные";
            // 
            // flowLayoutPanel15
            // 
            flowLayoutPanel15.Controls.Add(btnAddGivenDebt);
            flowLayoutPanel15.Controls.Add(btnEditGivenDebt);
            flowLayoutPanel15.Controls.Add(btnDeleteGivenDebt);
            flowLayoutPanel15.Controls.Add(button12);
            flowLayoutPanel15.Controls.Add(cmbGivenDebtStatusFilter);
            flowLayoutPanel15.Controls.Add(btnPaymentGivenDebt);
            flowLayoutPanel15.Dock = DockStyle.Fill;
            flowLayoutPanel15.Location = new Point(8, 34);
            flowLayoutPanel15.Name = "flowLayoutPanel15";
            flowLayoutPanel15.Padding = new Padding(5);
            flowLayoutPanel15.Size = new Size(926, 40);
            flowLayoutPanel15.TabIndex = 1;
            // 
            // btnAddGivenDebt
            // 
            btnAddGivenDebt.Image = Properties.Resources.PlusIcon;
            btnAddGivenDebt.Location = new Point(8, 8);
            btnAddGivenDebt.Name = "btnAddGivenDebt";
            btnAddGivenDebt.Size = new Size(104, 23);
            btnAddGivenDebt.TabIndex = 0;
            btnAddGivenDebt.Text = "Добавить";
            btnAddGivenDebt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddGivenDebt.UseVisualStyleBackColor = true;
            btnAddGivenDebt.Click += btnAddGivenDebt_Click;
            // 
            // btnEditGivenDebt
            // 
            btnEditGivenDebt.Image = Properties.Resources.EditIcon;
            btnEditGivenDebt.Location = new Point(118, 8);
            btnEditGivenDebt.Name = "btnEditGivenDebt";
            btnEditGivenDebt.Size = new Size(23, 23);
            btnEditGivenDebt.TabIndex = 1;
            btnEditGivenDebt.UseVisualStyleBackColor = true;
            btnEditGivenDebt.Click += btnEditGivenDebt_Click;
            // 
            // btnDeleteGivenDebt
            // 
            btnDeleteGivenDebt.Image = Properties.Resources.MinusIcon;
            btnDeleteGivenDebt.Location = new Point(147, 8);
            btnDeleteGivenDebt.Name = "btnDeleteGivenDebt";
            btnDeleteGivenDebt.Size = new Size(23, 23);
            btnDeleteGivenDebt.TabIndex = 2;
            btnDeleteGivenDebt.UseVisualStyleBackColor = true;
            btnDeleteGivenDebt.Click += btnDeleteGivenDebt_Click;
            // 
            // button12
            // 
            button12.Image = Properties.Resources.PrintIcon;
            button12.Location = new Point(176, 8);
            button12.Name = "button12";
            button12.Size = new Size(23, 23);
            button12.TabIndex = 9;
            button12.UseVisualStyleBackColor = true;
            // 
            // cmbGivenDebtStatusFilter
            // 
            cmbGivenDebtStatusFilter.FormattingEnabled = true;
            cmbGivenDebtStatusFilter.Items.AddRange(new object[] { "Все", "Активные", "Закрытые" });
            cmbGivenDebtStatusFilter.Location = new Point(205, 8);
            cmbGivenDebtStatusFilter.Name = "cmbGivenDebtStatusFilter";
            cmbGivenDebtStatusFilter.Size = new Size(100, 23);
            cmbGivenDebtStatusFilter.TabIndex = 10;
            // 
            // btnPaymentGivenDebt
            // 
            btnPaymentGivenDebt.Location = new Point(311, 8);
            btnPaymentGivenDebt.Name = "btnPaymentGivenDebt";
            btnPaymentGivenDebt.Size = new Size(75, 23);
            btnPaymentGivenDebt.TabIndex = 13;
            btnPaymentGivenDebt.Text = "Платежи";
            btnPaymentGivenDebt.UseVisualStyleBackColor = true;
            btnPaymentGivenDebt.Click += btnPaymentGivenDebt_Click;
            // 
            // tableLayoutPanel31
            // 
            tableLayoutPanel31.ColumnCount = 2;
            tableLayoutPanel31.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel31.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel31.Controls.Add(label15, 0, 0);
            tableLayoutPanel31.Controls.Add(tbDetailsGivenDebts, 1, 0);
            tableLayoutPanel31.Dock = DockStyle.Bottom;
            tableLayoutPanel31.Location = new Point(0, 579);
            tableLayoutPanel31.Name = "tableLayoutPanel31";
            tableLayoutPanel31.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel31.RowCount = 1;
            tableLayoutPanel31.RowStyles.Add(new RowStyle());
            tableLayoutPanel31.Size = new Size(942, 100);
            tableLayoutPanel31.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(8, 5);
            label15.Name = "label15";
            label15.Size = new Size(87, 15);
            label15.TabIndex = 0;
            label15.Text = "Комментарий:";
            // 
            // tbDetailsGivenDebts
            // 
            tbDetailsGivenDebts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsGivenDebts.Location = new Point(108, 8);
            tbDetailsGivenDebts.Multiline = true;
            tbDetailsGivenDebts.Name = "tbDetailsGivenDebts";
            tbDetailsGivenDebts.ReadOnly = true;
            tbDetailsGivenDebts.Size = new Size(826, 90);
            tbDetailsGivenDebts.TabIndex = 1;
            // 
            // tpDebtReceived
            // 
            tpDebtReceived.Controls.Add(tableLayoutPanel34);
            tpDebtReceived.Controls.Add(tableLayoutPanel32);
            tpDebtReceived.Location = new Point(4, 24);
            tpDebtReceived.Name = "tpDebtReceived";
            tpDebtReceived.Size = new Size(942, 679);
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
            tableLayoutPanel34.Name = "tableLayoutPanel34";
            tableLayoutPanel34.Padding = new Padding(5);
            tableLayoutPanel34.RowCount = 3;
            tableLayoutPanel34.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel34.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel34.RowStyles.Add(new RowStyle());
            tableLayoutPanel34.Size = new Size(942, 579);
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
            dgwReceivedDebts.Location = new Point(8, 80);
            dgwReceivedDebts.MultiSelect = false;
            dgwReceivedDebts.Name = "dgwReceivedDebts";
            dgwReceivedDebts.RowHeadersVisible = false;
            dgwReceivedDebts.RowHeadersWidth = 51;
            dgwReceivedDebts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwReceivedDebts.Size = new Size(926, 491);
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
            lblReceivedDebtsTotal.ForeColor = Color.FromArgb(0, 37, 118, 8);
            lblReceivedDebtsTotal.Location = new Point(8, 5);
            lblReceivedDebtsTotal.Name = "lblReceivedDebtsTotal";
            lblReceivedDebtsTotal.Size = new Size(926, 26);
            lblReceivedDebtsTotal.TabIndex = 0;
            lblReceivedDebtsTotal.Text = "Долги полученные";
            // 
            // flowLayoutPanel16
            // 
            flowLayoutPanel16.Controls.Add(btnAddReceivedDebt);
            flowLayoutPanel16.Controls.Add(btnEditReceivedDebt);
            flowLayoutPanel16.Controls.Add(btnDeleteReceivedDebt);
            flowLayoutPanel16.Controls.Add(button13);
            flowLayoutPanel16.Controls.Add(cmbReceivedDebtStatusFilter);
            flowLayoutPanel16.Controls.Add(btnPaymentReceivedDebt);
            flowLayoutPanel16.Dock = DockStyle.Fill;
            flowLayoutPanel16.Location = new Point(8, 34);
            flowLayoutPanel16.Name = "flowLayoutPanel16";
            flowLayoutPanel16.Padding = new Padding(5);
            flowLayoutPanel16.Size = new Size(926, 40);
            flowLayoutPanel16.TabIndex = 1;
            // 
            // btnAddReceivedDebt
            // 
            btnAddReceivedDebt.Image = Properties.Resources.PlusIcon;
            btnAddReceivedDebt.Location = new Point(8, 8);
            btnAddReceivedDebt.Name = "btnAddReceivedDebt";
            btnAddReceivedDebt.Size = new Size(104, 23);
            btnAddReceivedDebt.TabIndex = 0;
            btnAddReceivedDebt.Text = "Добавить";
            btnAddReceivedDebt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddReceivedDebt.UseVisualStyleBackColor = true;
            btnAddReceivedDebt.Click += btnAddReceivedDebt_Click;
            // 
            // btnEditReceivedDebt
            // 
            btnEditReceivedDebt.Image = Properties.Resources.EditIcon;
            btnEditReceivedDebt.Location = new Point(118, 8);
            btnEditReceivedDebt.Name = "btnEditReceivedDebt";
            btnEditReceivedDebt.Size = new Size(23, 23);
            btnEditReceivedDebt.TabIndex = 1;
            btnEditReceivedDebt.UseVisualStyleBackColor = true;
            btnEditReceivedDebt.Click += btnEditReceivedDebt_Click;
            // 
            // btnDeleteReceivedDebt
            // 
            btnDeleteReceivedDebt.Image = Properties.Resources.MinusIcon;
            btnDeleteReceivedDebt.Location = new Point(147, 8);
            btnDeleteReceivedDebt.Name = "btnDeleteReceivedDebt";
            btnDeleteReceivedDebt.Size = new Size(23, 23);
            btnDeleteReceivedDebt.TabIndex = 2;
            btnDeleteReceivedDebt.UseVisualStyleBackColor = true;
            btnDeleteReceivedDebt.Click += btnDeleteReceivedDebt_Click;
            // 
            // button13
            // 
            button13.Image = Properties.Resources.PrintIcon;
            button13.Location = new Point(176, 8);
            button13.Name = "button13";
            button13.Size = new Size(23, 23);
            button13.TabIndex = 9;
            button13.UseVisualStyleBackColor = true;
            // 
            // cmbReceivedDebtStatusFilter
            // 
            cmbReceivedDebtStatusFilter.FormattingEnabled = true;
            cmbReceivedDebtStatusFilter.Items.AddRange(new object[] { "Все", "Активные", "Закрытые" });
            cmbReceivedDebtStatusFilter.Location = new Point(205, 8);
            cmbReceivedDebtStatusFilter.Name = "cmbReceivedDebtStatusFilter";
            cmbReceivedDebtStatusFilter.Size = new Size(100, 23);
            cmbReceivedDebtStatusFilter.TabIndex = 12;
            // 
            // btnPaymentReceivedDebt
            // 
            btnPaymentReceivedDebt.Location = new Point(311, 8);
            btnPaymentReceivedDebt.Name = "btnPaymentReceivedDebt";
            btnPaymentReceivedDebt.Size = new Size(75, 23);
            btnPaymentReceivedDebt.TabIndex = 15;
            btnPaymentReceivedDebt.Text = "Платежи";
            btnPaymentReceivedDebt.UseVisualStyleBackColor = true;
            btnPaymentReceivedDebt.Click += btnPaymentReceivedDebt_Click;
            // 
            // tableLayoutPanel32
            // 
            tableLayoutPanel32.ColumnCount = 2;
            tableLayoutPanel32.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel32.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel32.Controls.Add(label17, 0, 0);
            tableLayoutPanel32.Controls.Add(tbDetailsReceivedDebts, 1, 0);
            tableLayoutPanel32.Dock = DockStyle.Bottom;
            tableLayoutPanel32.Location = new Point(0, 579);
            tableLayoutPanel32.Name = "tableLayoutPanel32";
            tableLayoutPanel32.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel32.RowCount = 1;
            tableLayoutPanel32.RowStyles.Add(new RowStyle());
            tableLayoutPanel32.Size = new Size(942, 100);
            tableLayoutPanel32.TabIndex = 2;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(8, 5);
            label17.Name = "label17";
            label17.Size = new Size(87, 15);
            label17.TabIndex = 0;
            label17.Text = "Комментарий:";
            // 
            // tbDetailsReceivedDebts
            // 
            tbDetailsReceivedDebts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsReceivedDebts.Location = new Point(108, 8);
            tbDetailsReceivedDebts.Multiline = true;
            tbDetailsReceivedDebts.Name = "tbDetailsReceivedDebts";
            tbDetailsReceivedDebts.ReadOnly = true;
            tbDetailsReceivedDebts.Size = new Size(826, 90);
            tbDetailsReceivedDebts.TabIndex = 1;
            // 
            // tbCounterparties
            // 
            tbCounterparties.Controls.Add(tableLayoutPanel36);
            tbCounterparties.Controls.Add(tableLayoutPanel35);
            tbCounterparties.Location = new Point(4, 24);
            tbCounterparties.Name = "tbCounterparties";
            tbCounterparties.Size = new Size(942, 679);
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
            tableLayoutPanel36.Name = "tableLayoutPanel36";
            tableLayoutPanel36.Padding = new Padding(5);
            tableLayoutPanel36.RowCount = 3;
            tableLayoutPanel36.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel36.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel36.RowStyles.Add(new RowStyle());
            tableLayoutPanel36.Size = new Size(942, 579);
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
            dgwCounterparties.Location = new Point(8, 80);
            dgwCounterparties.MultiSelect = false;
            dgwCounterparties.Name = "dgwCounterparties";
            dgwCounterparties.RowHeadersVisible = false;
            dgwCounterparties.RowHeadersWidth = 51;
            dgwCounterparties.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwCounterparties.Size = new Size(926, 491);
            dgwCounterparties.TabIndex = 3;
            dgwCounterparties.CellDoubleClick += dgwCounterparties_CellDoubleClick;
            dgwCounterparties.SelectionChanged += dgwCounterparties_SelectionChanged;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Dock = DockStyle.Fill;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label24.ForeColor = Color.FromArgb(0, 37, 118, 8);
            label24.Location = new Point(8, 5);
            label24.Name = "label24";
            label24.Size = new Size(926, 26);
            label24.TabIndex = 0;
            label24.Text = "Контрагенты";
            // 
            // flowLayoutPanel17
            // 
            flowLayoutPanel17.Controls.Add(btnAddCounterparties);
            flowLayoutPanel17.Controls.Add(btnEditCounterparties);
            flowLayoutPanel17.Controls.Add(btnDeleteCounterparties);
            flowLayoutPanel17.Dock = DockStyle.Fill;
            flowLayoutPanel17.Location = new Point(8, 34);
            flowLayoutPanel17.Name = "flowLayoutPanel17";
            flowLayoutPanel17.Padding = new Padding(5);
            flowLayoutPanel17.Size = new Size(926, 40);
            flowLayoutPanel17.TabIndex = 1;
            // 
            // btnAddCounterparties
            // 
            btnAddCounterparties.Image = Properties.Resources.PlusIcon;
            btnAddCounterparties.Location = new Point(8, 8);
            btnAddCounterparties.Name = "btnAddCounterparties";
            btnAddCounterparties.Size = new Size(104, 23);
            btnAddCounterparties.TabIndex = 0;
            btnAddCounterparties.Text = "Добавить";
            btnAddCounterparties.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddCounterparties.UseVisualStyleBackColor = true;
            btnAddCounterparties.Click += btnAddCounterparties_Click;
            // 
            // btnEditCounterparties
            // 
            btnEditCounterparties.Image = Properties.Resources.EditIcon;
            btnEditCounterparties.Location = new Point(118, 8);
            btnEditCounterparties.Name = "btnEditCounterparties";
            btnEditCounterparties.Size = new Size(23, 23);
            btnEditCounterparties.TabIndex = 1;
            btnEditCounterparties.UseVisualStyleBackColor = true;
            btnEditCounterparties.Click += btnEditCounterparties_Click;
            // 
            // btnDeleteCounterparties
            // 
            btnDeleteCounterparties.Image = Properties.Resources.MinusIcon;
            btnDeleteCounterparties.Location = new Point(147, 8);
            btnDeleteCounterparties.Name = "btnDeleteCounterparties";
            btnDeleteCounterparties.Size = new Size(23, 23);
            btnDeleteCounterparties.TabIndex = 2;
            btnDeleteCounterparties.UseVisualStyleBackColor = true;
            btnDeleteCounterparties.Click += btnDeleteCounterparties_Click;
            // 
            // tableLayoutPanel35
            // 
            tableLayoutPanel35.ColumnCount = 2;
            tableLayoutPanel35.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel35.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel35.Controls.Add(label20, 0, 0);
            tableLayoutPanel35.Controls.Add(tbDetailsCounterparties, 1, 0);
            tableLayoutPanel35.Dock = DockStyle.Bottom;
            tableLayoutPanel35.Location = new Point(0, 579);
            tableLayoutPanel35.Name = "tableLayoutPanel35";
            tableLayoutPanel35.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel35.RowCount = 1;
            tableLayoutPanel35.RowStyles.Add(new RowStyle());
            tableLayoutPanel35.Size = new Size(942, 100);
            tableLayoutPanel35.TabIndex = 2;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(8, 5);
            label20.Name = "label20";
            label20.Size = new Size(87, 15);
            label20.TabIndex = 0;
            label20.Text = "Комментарий:";
            // 
            // tbDetailsCounterparties
            // 
            tbDetailsCounterparties.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsCounterparties.Location = new Point(108, 8);
            tbDetailsCounterparties.Multiline = true;
            tbDetailsCounterparties.Name = "tbDetailsCounterparties";
            tbDetailsCounterparties.ReadOnly = true;
            tbDetailsCounterparties.Size = new Size(826, 90);
            tbDetailsCounterparties.TabIndex = 1;
            // 
            // tbGoals
            // 
            tbGoals.Controls.Add(tableLayoutPanel38);
            tbGoals.Controls.Add(tableLayoutPanel37);
            tbGoals.Location = new Point(4, 24);
            tbGoals.Name = "tbGoals";
            tbGoals.Size = new Size(942, 679);
            tbGoals.TabIndex = 14;
            tbGoals.Text = "Цели";
            tbGoals.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel38
            // 
            tableLayoutPanel38.ColumnCount = 1;
            tableLayoutPanel38.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel38.Controls.Add(dgwGoals, 0, 2);
            tableLayoutPanel38.Controls.Add(label26, 0, 0);
            tableLayoutPanel38.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel38.Dock = DockStyle.Fill;
            tableLayoutPanel38.Location = new Point(0, 0);
            tableLayoutPanel38.Name = "tableLayoutPanel38";
            tableLayoutPanel38.Padding = new Padding(5);
            tableLayoutPanel38.RowCount = 3;
            tableLayoutPanel38.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel38.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel38.RowStyles.Add(new RowStyle());
            tableLayoutPanel38.Size = new Size(942, 579);
            tableLayoutPanel38.TabIndex = 5;
            // 
            // dgwGoals
            // 
            dgwGoals.AllowUserToAddRows = false;
            dgwGoals.AllowUserToDeleteRows = false;
            dgwGoals.AllowUserToOrderColumns = true;
            dgwGoals.AllowUserToResizeRows = false;
            dgwGoals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwGoals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwGoals.ContextMenuStrip = contextMenu;
            dgwGoals.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwGoals.Location = new Point(8, 80);
            dgwGoals.MultiSelect = false;
            dgwGoals.Name = "dgwGoals";
            dgwGoals.RowHeadersVisible = false;
            dgwGoals.RowHeadersWidth = 51;
            dgwGoals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwGoals.Size = new Size(926, 491);
            dgwGoals.TabIndex = 3;
            dgwGoals.CellDoubleClick += dgvGoals_CellDoubleClick;
            dgwGoals.CellFormatting += dgvGoals_CellFormatting;
            dgwGoals.SelectionChanged += dgvGoals_SelectionChanged;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Dock = DockStyle.Fill;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label26.ForeColor = Color.FromArgb(0, 37, 118, 8);
            label26.Location = new Point(8, 5);
            label26.Name = "label26";
            label26.Size = new Size(926, 26);
            label26.TabIndex = 0;
            label26.Text = "Цели";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAddGoal);
            flowLayoutPanel1.Controls.Add(btnFundGoal);
            flowLayoutPanel1.Controls.Add(btnEditGoal);
            flowLayoutPanel1.Controls.Add(btnDeleteGoal);
            flowLayoutPanel1.Controls.Add(btnPrintGoal);
            flowLayoutPanel1.Controls.Add(cmbGoalFilter);
            flowLayoutPanel1.Controls.Add(btnGoalTransfer);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(8, 34);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(926, 40);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnAddGoal
            // 
            btnAddGoal.Image = Properties.Resources.PlusIcon;
            btnAddGoal.Location = new Point(8, 8);
            btnAddGoal.Name = "btnAddGoal";
            btnAddGoal.Size = new Size(104, 23);
            btnAddGoal.TabIndex = 0;
            btnAddGoal.Text = "Добавить";
            btnAddGoal.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddGoal.UseVisualStyleBackColor = true;
            btnAddGoal.Click += btnAddGoal_Click;
            // 
            // btnFundGoal
            // 
            btnFundGoal.Location = new Point(118, 8);
            btnFundGoal.Name = "btnFundGoal";
            btnFundGoal.Size = new Size(104, 23);
            btnFundGoal.TabIndex = 15;
            btnFundGoal.Text = "Пополнить";
            btnFundGoal.UseVisualStyleBackColor = true;
            btnFundGoal.Click += btnFundGoal_Click;
            // 
            // btnEditGoal
            // 
            btnEditGoal.Image = Properties.Resources.EditIcon;
            btnEditGoal.Location = new Point(228, 8);
            btnEditGoal.Name = "btnEditGoal";
            btnEditGoal.Size = new Size(23, 23);
            btnEditGoal.TabIndex = 1;
            btnEditGoal.UseVisualStyleBackColor = true;
            btnEditGoal.Click += btnEditGoal_Click;
            // 
            // btnDeleteGoal
            // 
            btnDeleteGoal.Image = Properties.Resources.MinusIcon;
            btnDeleteGoal.Location = new Point(257, 8);
            btnDeleteGoal.Name = "btnDeleteGoal";
            btnDeleteGoal.Size = new Size(23, 23);
            btnDeleteGoal.TabIndex = 2;
            btnDeleteGoal.UseVisualStyleBackColor = true;
            btnDeleteGoal.Click += btnDeleteGoal_Click;
            // 
            // btnPrintGoal
            // 
            btnPrintGoal.Image = Properties.Resources.PrintIcon;
            btnPrintGoal.Location = new Point(286, 8);
            btnPrintGoal.Name = "btnPrintGoal";
            btnPrintGoal.Size = new Size(23, 23);
            btnPrintGoal.TabIndex = 9;
            btnPrintGoal.UseVisualStyleBackColor = true;
            // 
            // cmbGoalFilter
            // 
            cmbGoalFilter.FormattingEnabled = true;
            cmbGoalFilter.Location = new Point(315, 8);
            cmbGoalFilter.Name = "cmbGoalFilter";
            cmbGoalFilter.Size = new Size(120, 23);
            cmbGoalFilter.TabIndex = 12;
            // 
            // btnGoalTransfer
            // 
            btnGoalTransfer.Location = new Point(441, 8);
            btnGoalTransfer.Name = "btnGoalTransfer";
            btnGoalTransfer.Size = new Size(104, 23);
            btnGoalTransfer.TabIndex = 16;
            btnGoalTransfer.Text = "Перевод";
            btnGoalTransfer.UseVisualStyleBackColor = true;
            btnGoalTransfer.Click += btnGoalTransfer_Click;
            // 
            // tableLayoutPanel37
            // 
            tableLayoutPanel37.ColumnCount = 2;
            tableLayoutPanel37.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel37.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel37.Controls.Add(label25, 0, 0);
            tableLayoutPanel37.Controls.Add(tbDetailsGoal, 1, 0);
            tableLayoutPanel37.Dock = DockStyle.Bottom;
            tableLayoutPanel37.Location = new Point(0, 579);
            tableLayoutPanel37.Name = "tableLayoutPanel37";
            tableLayoutPanel37.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel37.RowCount = 1;
            tableLayoutPanel37.RowStyles.Add(new RowStyle());
            tableLayoutPanel37.Size = new Size(942, 100);
            tableLayoutPanel37.TabIndex = 3;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(8, 5);
            label25.Name = "label25";
            label25.Size = new Size(87, 15);
            label25.TabIndex = 0;
            label25.Text = "Комментарий:";
            // 
            // tbDetailsGoal
            // 
            tbDetailsGoal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsGoal.Location = new Point(108, 8);
            tbDetailsGoal.Multiline = true;
            tbDetailsGoal.Name = "tbDetailsGoal";
            tbDetailsGoal.ReadOnly = true;
            tbDetailsGoal.Size = new Size(826, 90);
            tbDetailsGoal.TabIndex = 1;
            // 
            // tbMeasurements
            // 
            tbMeasurements.Controls.Add(tableLayoutPanel40);
            tbMeasurements.Controls.Add(tableLayoutPanel39);
            tbMeasurements.Location = new Point(4, 24);
            tbMeasurements.Name = "tbMeasurements";
            tbMeasurements.Size = new Size(942, 679);
            tbMeasurements.TabIndex = 15;
            tbMeasurements.Text = "Единицы";
            tbMeasurements.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel40
            // 
            tableLayoutPanel40.ColumnCount = 1;
            tableLayoutPanel40.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel40.Controls.Add(dgwMeasurement, 0, 2);
            tableLayoutPanel40.Controls.Add(label42, 0, 0);
            tableLayoutPanel40.Controls.Add(flowLayoutPanel19, 0, 1);
            tableLayoutPanel40.Dock = DockStyle.Fill;
            tableLayoutPanel40.Location = new Point(0, 0);
            tableLayoutPanel40.Name = "tableLayoutPanel40";
            tableLayoutPanel40.Padding = new Padding(5);
            tableLayoutPanel40.RowCount = 3;
            tableLayoutPanel40.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel40.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel40.RowStyles.Add(new RowStyle());
            tableLayoutPanel40.Size = new Size(942, 579);
            tableLayoutPanel40.TabIndex = 4;
            // 
            // dgwMeasurement
            // 
            dgwMeasurement.AllowUserToAddRows = false;
            dgwMeasurement.AllowUserToDeleteRows = false;
            dgwMeasurement.AllowUserToOrderColumns = true;
            dgwMeasurement.AllowUserToResizeRows = false;
            dgwMeasurement.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwMeasurement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMeasurement.ContextMenuStrip = contextMenu;
            dgwMeasurement.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgwMeasurement.Location = new Point(8, 80);
            dgwMeasurement.MultiSelect = false;
            dgwMeasurement.Name = "dgwMeasurement";
            dgwMeasurement.RowHeadersVisible = false;
            dgwMeasurement.RowHeadersWidth = 51;
            dgwMeasurement.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwMeasurement.Size = new Size(926, 491);
            dgwMeasurement.TabIndex = 3;
            dgwMeasurement.CellDoubleClick += dgwMeasurementUnits_CellDoubleClick;
            dgwMeasurement.SelectionChanged += dgwMeasurementUnits_SelectionChanged;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Dock = DockStyle.Fill;
            label42.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label42.ForeColor = Color.FromArgb(0, 37, 118, 8);
            label42.Location = new Point(8, 5);
            label42.Name = "label42";
            label42.Size = new Size(926, 26);
            label42.TabIndex = 0;
            label42.Text = "Единицы";
            // 
            // flowLayoutPanel19
            // 
            flowLayoutPanel19.Controls.Add(btnAddMeasurement);
            flowLayoutPanel19.Controls.Add(btnEditMeasurement);
            flowLayoutPanel19.Controls.Add(btnDeleteMeasurement);
            flowLayoutPanel19.Dock = DockStyle.Fill;
            flowLayoutPanel19.Location = new Point(8, 34);
            flowLayoutPanel19.Name = "flowLayoutPanel19";
            flowLayoutPanel19.Padding = new Padding(5);
            flowLayoutPanel19.Size = new Size(926, 40);
            flowLayoutPanel19.TabIndex = 1;
            // 
            // btnAddMeasurement
            // 
            btnAddMeasurement.Image = Properties.Resources.PlusIcon;
            btnAddMeasurement.Location = new Point(8, 8);
            btnAddMeasurement.Name = "btnAddMeasurement";
            btnAddMeasurement.Size = new Size(104, 23);
            btnAddMeasurement.TabIndex = 0;
            btnAddMeasurement.Text = "Добавить";
            btnAddMeasurement.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddMeasurement.UseVisualStyleBackColor = true;
            btnAddMeasurement.Click += btnAddMeasurementUnit_Click;
            // 
            // btnEditMeasurement
            // 
            btnEditMeasurement.Image = Properties.Resources.EditIcon;
            btnEditMeasurement.Location = new Point(118, 8);
            btnEditMeasurement.Name = "btnEditMeasurement";
            btnEditMeasurement.Size = new Size(23, 23);
            btnEditMeasurement.TabIndex = 1;
            btnEditMeasurement.UseVisualStyleBackColor = true;
            btnEditMeasurement.Click += btnEditMeasurementUnit_Click;
            // 
            // btnDeleteMeasurement
            // 
            btnDeleteMeasurement.Image = Properties.Resources.MinusIcon;
            btnDeleteMeasurement.Location = new Point(147, 8);
            btnDeleteMeasurement.Name = "btnDeleteMeasurement";
            btnDeleteMeasurement.Size = new Size(23, 23);
            btnDeleteMeasurement.TabIndex = 2;
            btnDeleteMeasurement.UseVisualStyleBackColor = true;
            btnDeleteMeasurement.Click += btnDeleteMeasurementUnit_Click;
            // 
            // tableLayoutPanel39
            // 
            tableLayoutPanel39.ColumnCount = 2;
            tableLayoutPanel39.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel39.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel39.Controls.Add(label41, 0, 0);
            tableLayoutPanel39.Controls.Add(tbDetailsMeasurement, 1, 0);
            tableLayoutPanel39.Dock = DockStyle.Bottom;
            tableLayoutPanel39.Location = new Point(0, 579);
            tableLayoutPanel39.Name = "tableLayoutPanel39";
            tableLayoutPanel39.Padding = new Padding(5, 5, 5, 0);
            tableLayoutPanel39.RowCount = 1;
            tableLayoutPanel39.RowStyles.Add(new RowStyle());
            tableLayoutPanel39.Size = new Size(942, 100);
            tableLayoutPanel39.TabIndex = 2;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(8, 5);
            label41.Name = "label41";
            label41.Size = new Size(87, 15);
            label41.TabIndex = 0;
            label41.Text = "Комментарий:";
            // 
            // tbDetailsMeasurement
            // 
            tbDetailsMeasurement.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDetailsMeasurement.Location = new Point(108, 8);
            tbDetailsMeasurement.Multiline = true;
            tbDetailsMeasurement.Name = "tbDetailsMeasurement";
            tbDetailsMeasurement.ReadOnly = true;
            tbDetailsMeasurement.Size = new Size(826, 90);
            tbDetailsMeasurement.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 707);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(800, 598);
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
            flowLayoutPanel20.ResumeLayout(false);
            accountPanel.ResumeLayout(false);
            tableLayoutPanel41.ResumeLayout(false);
            tableLayoutPanel41.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            flowLayoutPanel21.ResumeLayout(false);
            flowLayoutPanel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            additionalPanel.ResumeLayout(false);
            tableLayoutPanel42.ResumeLayout(false);
            tableLayoutPanel42.PerformLayout();
            flowLayoutPanel22.ResumeLayout(false);
            flowLayoutPanel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            budgetPanel.ResumeLayout(false);
            tableLayoutPanel43.ResumeLayout(false);
            tableLayoutPanel43.PerformLayout();
            flowLayoutPanel23.ResumeLayout(false);
            flowLayoutPanel23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            profitPanel.ResumeLayout(false);
            tableLayoutPanel44.ResumeLayout(false);
            tableLayoutPanel44.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            flowLayoutPanel24.ResumeLayout(false);
            flowLayoutPanel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            expensePanel.ResumeLayout(false);
            tableLayoutPanel45.ResumeLayout(false);
            tableLayoutPanel45.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            flowLayoutPanel25.ResumeLayout(false);
            flowLayoutPanel25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            incomePanel.ResumeLayout(false);
            tableLayoutPanel46.ResumeLayout(false);
            tableLayoutPanel46.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).EndInit();
            flowLayoutPanel26.ResumeLayout(false);
            flowLayoutPanel26.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            goalPanel.ResumeLayout(false);
            tableLayoutPanel47.ResumeLayout(false);
            tableLayoutPanel47.PerformLayout();
            flowLayoutPanel27.ResumeLayout(false);
            flowLayoutPanel27.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            debtPanel.ResumeLayout(false);
            tableLayoutPanel48.ResumeLayout(false);
            tableLayoutPanel48.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox28).EndInit();
            flowLayoutPanel28.ResumeLayout(false);
            flowLayoutPanel28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            progressPanel.ResumeLayout(false);
            tableLayoutPanel49.ResumeLayout(false);
            tableLayoutPanel49.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).EndInit();
            flowLayoutPanel29.ResumeLayout(false);
            flowLayoutPanel29.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
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
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tpAbout.ResumeLayout(false);
            tableLayoutPanel27.ResumeLayout(false);
            tableLayoutPanel27.PerformLayout();
            tableLayoutPanel28.ResumeLayout(false);
            tableLayoutPanel28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel18.ResumeLayout(false);
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
            tbGoals.ResumeLayout(false);
            tableLayoutPanel38.ResumeLayout(false);
            tableLayoutPanel38.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwGoals).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel37.ResumeLayout(false);
            tableLayoutPanel37.PerformLayout();
            tbMeasurements.ResumeLayout(false);
            tableLayoutPanel40.ResumeLayout(false);
            tableLayoutPanel40.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMeasurement).EndInit();
            flowLayoutPanel19.ResumeLayout(false);
            tableLayoutPanel39.ResumeLayout(false);
            tableLayoutPanel39.PerformLayout();
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
        private ComboBox cmbGivenDebtStatusFilter;
        private ComboBox cmbReceivedDebtStatusFilter;
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
        private TabPage tbGoals;
        private TableLayoutPanel tableLayoutPanel38;
        private DataGridView dgwGoals;
        private Label label26;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAddGoal;
        private Button btnFundGoal;
        private Button btnEditGoal;
        private Button btnDeleteGoal;
        private Button btnPrintGoal;
        private ComboBox cmbGoalFilter;
        private Button btnGoalTransfer;
        private TableLayoutPanel tableLayoutPanel37;
        private Label label25;
        private TextBox tbDetailsGoal;
        private FlowLayoutPanel flowLayoutPanel18;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel16;
        private Label label1;
        private TextBox tbDetailsCategory;
        private Button button4;
        private TabPage tbMeasurements;
        private TableLayoutPanel tableLayoutPanel40;
        private DataGridView dgwMeasurement;
        private Label label42;
        private FlowLayoutPanel flowLayoutPanel19;
        private Button btnAddMeasurement;
        private Button btnEditMeasurement;
        private Button btnDeleteMeasurement;
        private TableLayoutPanel tableLayoutPanel39;
        private Label label41;
        private TextBox tbDetailsMeasurement;
        private FlowLayoutPanel flowLayoutPanel20;
        private Panel accountPanel;
        private FlowLayoutPanel flowLayoutPanel21;
        private TableLayoutPanel tableLayoutPanel41;
        private PictureBox pictureBox2;
        private Label lblTotalBalance;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private CheckBox checkBox1;
        private TabPage tabPage2;
        private Button btnDown;
        private Button btnUp;
        private CheckedListBox checkedListBox1;
        private Panel additionalPanel;
        private TableLayoutPanel tableLayoutPanel42;
        private FlowLayoutPanel flowLayoutPanel22;
        private PictureBox pictureBox3;
        private Label label27;
        private Panel budgetPanel;
        private TableLayoutPanel tableLayoutPanel43;
        private FlowLayoutPanel flowLayoutPanel23;
        private PictureBox pictureBox4;
        private Label label44;
        private Panel profitPanel;
        private TableLayoutPanel tableLayoutPanel44;
        private FlowLayoutPanel flowLayoutPanel24;
        private PictureBox pictureBox5;
        private Label label45;
        private Panel expensePanel;
        private TableLayoutPanel tableLayoutPanel45;
        private FlowLayoutPanel flowLayoutPanel25;
        private PictureBox pictureBox6;
        private Label label46;
        private Panel incomePanel;
        private TableLayoutPanel tableLayoutPanel46;
        private FlowLayoutPanel flowLayoutPanel26;
        private PictureBox pictureBox7;
        private Label label47;
        private Panel goalPanel;
        private TableLayoutPanel tableLayoutPanel47;
        private FlowLayoutPanel flowLayoutPanel27;
        private PictureBox pictureBox8;
        private Label label48;
        private Panel debtPanel;
        private TableLayoutPanel tableLayoutPanel48;
        private FlowLayoutPanel flowLayoutPanel28;
        private PictureBox pictureBox9;
        private Label label49;
        private Panel progressPanel;
        private TableLayoutPanel tableLayoutPanel49;
        private FlowLayoutPanel flowLayoutPanel29;
        private PictureBox pictureBox10;
        private Label label50;
        private Label label51;
        private Label label52;
        private Label lblYesterdayIncome;
        private Label lblYesterdayExpense;
        private Label lblTodayIncome;
        private Label lblTodayExpense;
        private Label lblAdditional1Name;
        private Label lblAdditional2Name;
        private Label lblAdditional3Name;
        private Label lblAdditional1Value;
        private Label lblAdditional2Value;
        private Label lblAdditional3Value;
        private Label label67;
        private Label label68;
        private Label label69;
        private Label label70;
        private Label label71;
        private Label label72;
        private Label lblBudgetTopCategory;
        private Label lblBudgetLimit;
        private Label lblBudgetSpent;
        private Label lblBudgetRemaining;
        private Label lblBudgetProgress;
        private Label label78;
        private Label lblTotalIncome;
        private Label label80;
        private Label lblIncomeChange;
        private Label label82;
        private Label lblTotalExpense;
        private Label label84;
        private Label lblExpenseChange;
        private Label label86;
        private Label label87;
        private Label lblBestDay;
        private Label lblWorstDay;
        private Label lblExpense1Name;
        private Label lblExpense2Name;
        private Label lblExpense3Name;
        private Label lblExpense1Value;
        private Label lblExpense2Value;
        private Label lblExpense3Value;
        private Label lblIncome1Name;
        private Label lblIncome2Name;
        private Label lblIncome3Name;
        private Label lblIncome1Value;
        private Label lblIncome2Value;
        private Label lblIncome3Value;
        private Label lblGoal1Name;
        private Label lblGoal2Name;
        private Label lblGoal3Name;
        private Label lblNearestGoalName;
        private Label lblGoal1Progress;
        private Label lblGoal2Progress;
        private Label lblGoal3Progress;
        private Label lblNearestGoalDate;
        private Label label110;
        private Label label111;
        private Label label112;
        private Label label113;
        private Label label114;
        private Label label115;
        private Label lblTotalGivenDebt;
        private Label lblOverdueGivenDebt;
        private Label lblNextGivenDueDate;
        private Label lblTotalReceivedDebt;
        private Label lblOverdueReceivedDebt;
        private Label lblNextReceivedDueDate;
        private Label label122;
        private Label label123;
        private Label label124;
        private Label label125;
        private Label label126;
        private Label label127;
        private Label label128;
        private Label label129;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private PictureBox pictureBox27;
        private PictureBox pictureBox28;
        private PictureBox pictureBox23;
        private PictureBox pictureBox24;
        private PictureBox pictureBox25;
        private PictureBox pictureBox26;
        private Label label132;
        private Label label131;
        private Label label130;
    }
}
