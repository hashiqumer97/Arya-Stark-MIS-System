namespace AryaStarkHashiqCsd55
{
    partial class frm_modifytransactionspremium
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
            this.components = new System.ComponentModel.Container();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.btn_clear = new MetroFramework.Controls.MetroButton();
            this.btn_insert = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transactionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofTransactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeofTransactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityofproductssoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMadeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.methodofSendingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handledByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbltransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AryaStarkHashiqCsd55.DataSet1();
            this.tbl_transactionsTableAdapter1 = new AryaStarkHashiqCsd55.DataSet1TableAdapters.tbl_transactionsTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_handledby = new System.Windows.Forms.TextBox();
            this.cbox_methodofsending = new System.Windows.Forms.ComboBox();
            this.cbox_paymentmadein = new System.Windows.Forms.ComboBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.mtxt_dateoftransaction = new System.Windows.Forms.MaskedTextBox();
            this.txt_transactionid = new System.Windows.Forms.TextBox();
            this.txt_nameoftransaction = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_time = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(301, 488);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(108, 23);
            this.btn_back.TabIndex = 58;
            this.btn_back.Text = "Back";
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(171, 488);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(108, 23);
            this.btn_clear.TabIndex = 56;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseSelectable = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(40, 488);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(108, 23);
            this.btn_insert.TabIndex = 55;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseSelectable = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIDDataGridViewTextBoxColumn,
            this.transactionNameDataGridViewTextBoxColumn,
            this.dateofTransactionDataGridViewTextBoxColumn,
            this.timeofTransactionDataGridViewTextBoxColumn,
            this.quantityofproductssoldDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.paymentMadeInDataGridViewTextBoxColumn,
            this.methodofSendingDataGridViewTextBoxColumn,
            this.handledByDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbltransactionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(577, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 357);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // transactionIDDataGridViewTextBoxColumn
            // 
            this.transactionIDDataGridViewTextBoxColumn.DataPropertyName = "Transaction_ID";
            this.transactionIDDataGridViewTextBoxColumn.HeaderText = "Transaction ID";
            this.transactionIDDataGridViewTextBoxColumn.Name = "transactionIDDataGridViewTextBoxColumn";
            // 
            // transactionNameDataGridViewTextBoxColumn
            // 
            this.transactionNameDataGridViewTextBoxColumn.DataPropertyName = "Transaction_Name";
            this.transactionNameDataGridViewTextBoxColumn.HeaderText = "Transaction Name";
            this.transactionNameDataGridViewTextBoxColumn.Name = "transactionNameDataGridViewTextBoxColumn";
            // 
            // dateofTransactionDataGridViewTextBoxColumn
            // 
            this.dateofTransactionDataGridViewTextBoxColumn.DataPropertyName = "Date_of_Transaction";
            this.dateofTransactionDataGridViewTextBoxColumn.HeaderText = "Date of Transaction";
            this.dateofTransactionDataGridViewTextBoxColumn.Name = "dateofTransactionDataGridViewTextBoxColumn";
            // 
            // timeofTransactionDataGridViewTextBoxColumn
            // 
            this.timeofTransactionDataGridViewTextBoxColumn.DataPropertyName = "Time_of_Transaction";
            this.timeofTransactionDataGridViewTextBoxColumn.HeaderText = "Time of Transaction";
            this.timeofTransactionDataGridViewTextBoxColumn.Name = "timeofTransactionDataGridViewTextBoxColumn";
            // 
            // quantityofproductssoldDataGridViewTextBoxColumn
            // 
            this.quantityofproductssoldDataGridViewTextBoxColumn.DataPropertyName = "Quantity_of_products_sold";
            this.quantityofproductssoldDataGridViewTextBoxColumn.HeaderText = "Quantity of products sold";
            this.quantityofproductssoldDataGridViewTextBoxColumn.Name = "quantityofproductssoldDataGridViewTextBoxColumn";
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "Total_Amount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "Total Amount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            // 
            // paymentMadeInDataGridViewTextBoxColumn
            // 
            this.paymentMadeInDataGridViewTextBoxColumn.DataPropertyName = "Payment_Made_In";
            this.paymentMadeInDataGridViewTextBoxColumn.HeaderText = "Payment Made In";
            this.paymentMadeInDataGridViewTextBoxColumn.Name = "paymentMadeInDataGridViewTextBoxColumn";
            // 
            // methodofSendingDataGridViewTextBoxColumn
            // 
            this.methodofSendingDataGridViewTextBoxColumn.DataPropertyName = "Method_of_Sending";
            this.methodofSendingDataGridViewTextBoxColumn.HeaderText = "Method of Sending";
            this.methodofSendingDataGridViewTextBoxColumn.Name = "methodofSendingDataGridViewTextBoxColumn";
            // 
            // handledByDataGridViewTextBoxColumn
            // 
            this.handledByDataGridViewTextBoxColumn.DataPropertyName = "Handled_By";
            this.handledByDataGridViewTextBoxColumn.HeaderText = "Handled By";
            this.handledByDataGridViewTextBoxColumn.Name = "handledByDataGridViewTextBoxColumn";
            // 
            // tbltransactionsBindingSource
            // 
            this.tbltransactionsBindingSource.DataMember = "tbl_transactions";
            this.tbltransactionsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_transactionsTableAdapter1
            // 
            this.tbl_transactionsTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.stocksToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.recordsToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyClientsToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // modifyClientsToolStripMenuItem
            // 
            this.modifyClientsToolStripMenuItem.Name = "modifyClientsToolStripMenuItem";
            this.modifyClientsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.modifyClientsToolStripMenuItem.Text = "Modify Clients";
            this.modifyClientsToolStripMenuItem.Click += new System.EventHandler(this.modifyClientsToolStripMenuItem_Click);
            // 
            // stocksToolStripMenuItem
            // 
            this.stocksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyStocksToolStripMenuItem});
            this.stocksToolStripMenuItem.Name = "stocksToolStripMenuItem";
            this.stocksToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.stocksToolStripMenuItem.Text = "Stocks";
            this.stocksToolStripMenuItem.Click += new System.EventHandler(this.stocksToolStripMenuItem_Click);
            // 
            // modifyStocksToolStripMenuItem
            // 
            this.modifyStocksToolStripMenuItem.Name = "modifyStocksToolStripMenuItem";
            this.modifyStocksToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.modifyStocksToolStripMenuItem.Text = "Modify Stocks";
            this.modifyStocksToolStripMenuItem.Click += new System.EventHandler(this.modifyStocksToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyTransactionsToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // modifyTransactionsToolStripMenuItem
            // 
            this.modifyTransactionsToolStripMenuItem.Name = "modifyTransactionsToolStripMenuItem";
            this.modifyTransactionsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.modifyTransactionsToolStripMenuItem.Text = "Modify Transactions";
            this.modifyTransactionsToolStripMenuItem.Click += new System.EventHandler(this.modifyTransactionsToolStripMenuItem_Click);
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyRecordsToolStripMenuItem});
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.recordsToolStripMenuItem.Text = "Records";
            this.recordsToolStripMenuItem.Click += new System.EventHandler(this.recordsToolStripMenuItem_Click);
            // 
            // modifyRecordsToolStripMenuItem
            // 
            this.modifyRecordsToolStripMenuItem.Name = "modifyRecordsToolStripMenuItem";
            this.modifyRecordsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.modifyRecordsToolStripMenuItem.Text = "Modify Records";
            this.modifyRecordsToolStripMenuItem.Click += new System.EventHandler(this.modifyRecordsToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem});
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // txt_handledby
            // 
            this.txt_handledby.Location = new System.Drawing.Point(264, 407);
            this.txt_handledby.Name = "txt_handledby";
            this.txt_handledby.Size = new System.Drawing.Size(261, 20);
            this.txt_handledby.TabIndex = 77;
            // 
            // cbox_methodofsending
            // 
            this.cbox_methodofsending.FormattingEnabled = true;
            this.cbox_methodofsending.Items.AddRange(new object[] {
            "Post",
            "Delivery"});
            this.cbox_methodofsending.Location = new System.Drawing.Point(264, 354);
            this.cbox_methodofsending.Name = "cbox_methodofsending";
            this.cbox_methodofsending.Size = new System.Drawing.Size(261, 21);
            this.cbox_methodofsending.TabIndex = 76;
            this.cbox_methodofsending.Text = "Select";
            // 
            // cbox_paymentmadein
            // 
            this.cbox_paymentmadein.FormattingEnabled = true;
            this.cbox_paymentmadein.Items.AddRange(new object[] {
            "Card",
            "Cash"});
            this.cbox_paymentmadein.Location = new System.Drawing.Point(264, 298);
            this.cbox_paymentmadein.Name = "cbox_paymentmadein";
            this.cbox_paymentmadein.Size = new System.Drawing.Size(261, 21);
            this.cbox_paymentmadein.TabIndex = 75;
            this.cbox_paymentmadein.Text = "Select";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(264, 249);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(261, 20);
            this.txt_total.TabIndex = 74;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(264, 211);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(261, 20);
            this.txt_quantity.TabIndex = 73;
            // 
            // mtxt_dateoftransaction
            // 
            this.mtxt_dateoftransaction.Location = new System.Drawing.Point(264, 128);
            this.mtxt_dateoftransaction.Mask = "00/00/0000";
            this.mtxt_dateoftransaction.Name = "mtxt_dateoftransaction";
            this.mtxt_dateoftransaction.Size = new System.Drawing.Size(261, 20);
            this.mtxt_dateoftransaction.TabIndex = 71;
            this.mtxt_dateoftransaction.ValidatingType = typeof(System.DateTime);
            // 
            // txt_transactionid
            // 
            this.txt_transactionid.Location = new System.Drawing.Point(264, 51);
            this.txt_transactionid.Name = "txt_transactionid";
            this.txt_transactionid.Size = new System.Drawing.Size(261, 20);
            this.txt_transactionid.TabIndex = 70;
            // 
            // txt_nameoftransaction
            // 
            this.txt_nameoftransaction.Location = new System.Drawing.Point(264, 87);
            this.txt_nameoftransaction.Name = "txt_nameoftransaction";
            this.txt_nameoftransaction.Size = new System.Drawing.Size(261, 20);
            this.txt_nameoftransaction.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 67;
            this.label8.Text = "Handled By";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 23);
            this.label7.TabIndex = 66;
            this.label7.Text = "Method of Sending";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 23);
            this.label6.TabIndex = 65;
            this.label6.Text = "Payment Made In";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 64;
            this.label5.Text = "Total Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 23);
            this.label4.TabIndex = 63;
            this.label4.Text = "Quantity of Products Sold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 62;
            this.label3.Text = "Time of Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 61;
            this.label2.Text = "Date of Transaction";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 23);
            this.label9.TabIndex = 68;
            this.label9.Text = "Transaction ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 60;
            this.label1.Text = "Name of Transaction";
            // 
            // cbox_time
            // 
            this.cbox_time.FormattingEnabled = true;
            this.cbox_time.Items.AddRange(new object[] {
            "00:00",
            "00:30",
            "01:00",
            "01:30",
            "02:00",
            "02:30",
            "03:30",
            "04:00",
            "04:30",
            "05:00",
            "05:30",
            "06:00",
            "06:30",
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30\t",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            this.cbox_time.Location = new System.Drawing.Point(264, 168);
            this.cbox_time.Name = "cbox_time";
            this.cbox_time.Size = new System.Drawing.Size(259, 21);
            this.cbox_time.TabIndex = 78;
            // 
            // frm_modifytransactionspremium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AryaStarkHashiqCsd55.Properties.Resources.pic_white_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.cbox_time);
            this.Controls.Add(this.txt_handledby);
            this.Controls.Add(this.cbox_methodofsending);
            this.Controls.Add(this.cbox_paymentmadein);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.mtxt_dateoftransaction);
            this.Controls.Add(this.txt_transactionid);
            this.Controls.Add(this.txt_nameoftransaction);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_modifytransactionspremium";
            this.Text = "Modify Transactions Premium";
            this.Load += new System.EventHandler(this.frm_modifytransactionspremium_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_back;
        private MetroFramework.Controls.MetroButton btn_clear;
        private MetroFramework.Controls.MetroButton btn_insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofTransactionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeofTransactionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityofproductssoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMadeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn methodofSendingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handledByDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbltransactionsBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.tbl_transactionsTableAdapter tbl_transactionsTableAdapter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyRecordsToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_handledby;
        private System.Windows.Forms.ComboBox cbox_methodofsending;
        private System.Windows.Forms.ComboBox cbox_paymentmadein;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.MaskedTextBox mtxt_dateoftransaction;
        private System.Windows.Forms.TextBox txt_transactionid;
        private System.Windows.Forms.TextBox txt_nameoftransaction;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_time;
    }
}