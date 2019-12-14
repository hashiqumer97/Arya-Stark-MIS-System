namespace AryaStarkHashiqCsd55
{
    partial class frm_modifyrecordsvip
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
            this.btn_update = new MetroFramework.Controls.MetroButton();
            this.btn_clear = new MetroFramework.Controls.MetroButton();
            this.btn_insert = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofReminderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationofSupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofSupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityNeededDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handledByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblrecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AryaStarkHashiqCsd55.DataSet1();
            this.txt_nameofsupplier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_recordsTableAdapter1 = new AryaStarkHashiqCsd55.DataSet1TableAdapters.tbl_recordsTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showChartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_recordid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.cbox_location = new System.Windows.Forms.ComboBox();
            this.mtxt_quantity = new System.Windows.Forms.MaskedTextBox();
            this.cbox_handledby = new System.Windows.Forms.ComboBox();
            this.tbluserdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aryastarkhashiqcsd55DataSet1 = new AryaStarkHashiqCsd55.aryastarkhashiqcsd55DataSet1();
            this.tbl_user_detailsTableAdapter = new AryaStarkHashiqCsd55.aryastarkhashiqcsd55DataSet1TableAdapters.tbl_user_detailsTableAdapter();
            this.lbl_modifyerror = new System.Windows.Forms.Label();
            this.lbl_insertedrecord = new System.Windows.Forms.Label();
            this.lbl_updatedrecord = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbox_productname = new System.Windows.Forms.ComboBox();
            this.tblstocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_stocksTableAdapter = new AryaStarkHashiqCsd55.DataSet1TableAdapters.tbl_stocksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aryastarkhashiqcsd55DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstocksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(500, 507);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(122, 23);
            this.btn_back.TabIndex = 34;
            this.btn_back.Text = "Back";
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(356, 507);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(122, 23);
            this.btn_update.TabIndex = 32;
            this.btn_update.Text = "Update";
            this.btn_update.UseSelectable = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(213, 507);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(122, 23);
            this.btn_clear.TabIndex = 31;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseSelectable = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(66, 507);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(122, 23);
            this.btn_insert.TabIndex = 30;
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
            this.recordIDDataGridViewTextBoxColumn,
            this.nameofProductDataGridViewTextBoxColumn,
            this.dateofReminderDataGridViewTextBoxColumn,
            this.locationofSupplierDataGridViewTextBoxColumn,
            this.nameofSupplierDataGridViewTextBoxColumn,
            this.quantityNeededDataGridViewTextBoxColumn,
            this.handledByDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblrecordsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(561, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(601, 341);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // recordIDDataGridViewTextBoxColumn
            // 
            this.recordIDDataGridViewTextBoxColumn.DataPropertyName = "Record_ID";
            this.recordIDDataGridViewTextBoxColumn.HeaderText = "Record ID";
            this.recordIDDataGridViewTextBoxColumn.Name = "recordIDDataGridViewTextBoxColumn";
            // 
            // nameofProductDataGridViewTextBoxColumn
            // 
            this.nameofProductDataGridViewTextBoxColumn.DataPropertyName = "Name_of_Product";
            this.nameofProductDataGridViewTextBoxColumn.HeaderText = "Name of Product";
            this.nameofProductDataGridViewTextBoxColumn.Name = "nameofProductDataGridViewTextBoxColumn";
            // 
            // dateofReminderDataGridViewTextBoxColumn
            // 
            this.dateofReminderDataGridViewTextBoxColumn.DataPropertyName = "Date_of_Reminder";
            this.dateofReminderDataGridViewTextBoxColumn.HeaderText = "Date of Reminder";
            this.dateofReminderDataGridViewTextBoxColumn.Name = "dateofReminderDataGridViewTextBoxColumn";
            // 
            // locationofSupplierDataGridViewTextBoxColumn
            // 
            this.locationofSupplierDataGridViewTextBoxColumn.DataPropertyName = "Location_of_Supplier";
            this.locationofSupplierDataGridViewTextBoxColumn.HeaderText = "Location of Supplier";
            this.locationofSupplierDataGridViewTextBoxColumn.Name = "locationofSupplierDataGridViewTextBoxColumn";
            // 
            // nameofSupplierDataGridViewTextBoxColumn
            // 
            this.nameofSupplierDataGridViewTextBoxColumn.DataPropertyName = "Name_of_Supplier";
            this.nameofSupplierDataGridViewTextBoxColumn.HeaderText = "Name of Supplier";
            this.nameofSupplierDataGridViewTextBoxColumn.Name = "nameofSupplierDataGridViewTextBoxColumn";
            // 
            // quantityNeededDataGridViewTextBoxColumn
            // 
            this.quantityNeededDataGridViewTextBoxColumn.DataPropertyName = "Quantity_Needed";
            this.quantityNeededDataGridViewTextBoxColumn.HeaderText = "Quantity Needed";
            this.quantityNeededDataGridViewTextBoxColumn.Name = "quantityNeededDataGridViewTextBoxColumn";
            // 
            // handledByDataGridViewTextBoxColumn
            // 
            this.handledByDataGridViewTextBoxColumn.DataPropertyName = "Handled_By";
            this.handledByDataGridViewTextBoxColumn.HeaderText = "Handled By";
            this.handledByDataGridViewTextBoxColumn.Name = "handledByDataGridViewTextBoxColumn";
            // 
            // tblrecordsBindingSource
            // 
            this.tblrecordsBindingSource.DataMember = "tbl_records";
            this.tblrecordsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_nameofsupplier
            // 
            this.txt_nameofsupplier.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblstocksBindingSource, "Name_of_Supplier", true));
            this.txt_nameofsupplier.Location = new System.Drawing.Point(221, 289);
            this.txt_nameofsupplier.Name = "txt_nameofsupplier";
            this.txt_nameofsupplier.Size = new System.Drawing.Size(276, 20);
            this.txt_nameofsupplier.TabIndex = 26;
            this.txt_nameofsupplier.TextChanged += new System.EventHandler(this.txt_nameofsupplier_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Handled By";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Quantity Needed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Name of Supplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Location of Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date of Reminder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name of Product";
            // 
            // tbl_recordsTableAdapter1
            // 
            this.tbl_recordsTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 35;
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
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showChartsToolStripMenuItem});
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.recordsToolStripMenuItem.Text = "Records";
            this.recordsToolStripMenuItem.Click += new System.EventHandler(this.recordsToolStripMenuItem_Click);
            // 
            // showChartsToolStripMenuItem
            // 
            this.showChartsToolStripMenuItem.Name = "showChartsToolStripMenuItem";
            this.showChartsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.showChartsToolStripMenuItem.Text = "Show Charts";
            this.showChartsToolStripMenuItem.Click += new System.EventHandler(this.showChartsToolStripMenuItem_Click);
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
            // txt_recordid
            // 
            this.txt_recordid.Location = new System.Drawing.Point(221, 65);
            this.txt_recordid.Name = "txt_recordid";
            this.txt_recordid.Size = new System.Drawing.Size(275, 20);
            this.txt_recordid.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "Record ID";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(221, 175);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(275, 20);
            this.txt_date.TabIndex = 56;
            // 
            // cbox_location
            // 
            this.cbox_location.FormattingEnabled = true;
            this.cbox_location.Items.AddRange(new object[] {
            "Colombo",
            "Kandy",
            "Kurunegala",
            "Trincomalee",
            "Galle",
            "Jaffna",
            "Kandy",
            "Hambantota",
            "Chilaw",
            "Batticoloa"});
            this.cbox_location.Location = new System.Drawing.Point(221, 232);
            this.cbox_location.Name = "cbox_location";
            this.cbox_location.Size = new System.Drawing.Size(276, 21);
            this.cbox_location.TabIndex = 57;
            // 
            // mtxt_quantity
            // 
            this.mtxt_quantity.Location = new System.Drawing.Point(221, 342);
            this.mtxt_quantity.Mask = "000";
            this.mtxt_quantity.Name = "mtxt_quantity";
            this.mtxt_quantity.Size = new System.Drawing.Size(276, 20);
            this.mtxt_quantity.TabIndex = 60;
            this.mtxt_quantity.TextChanged += new System.EventHandler(this.mtxt_quantity_TextChanged);
            // 
            // cbox_handledby
            // 
            this.cbox_handledby.DataSource = this.tbluserdetailsBindingSource;
            this.cbox_handledby.DisplayMember = "User_ID";
            this.cbox_handledby.FormattingEnabled = true;
            this.cbox_handledby.Location = new System.Drawing.Point(220, 399);
            this.cbox_handledby.Name = "cbox_handledby";
            this.cbox_handledby.Size = new System.Drawing.Size(277, 21);
            this.cbox_handledby.TabIndex = 59;
            // 
            // tbluserdetailsBindingSource
            // 
            this.tbluserdetailsBindingSource.DataMember = "tbl_user_details";
            this.tbluserdetailsBindingSource.DataSource = this.aryastarkhashiqcsd55DataSet1;
            // 
            // aryastarkhashiqcsd55DataSet1
            // 
            this.aryastarkhashiqcsd55DataSet1.DataSetName = "aryastarkhashiqcsd55DataSet1";
            this.aryastarkhashiqcsd55DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_user_detailsTableAdapter
            // 
            this.tbl_user_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_modifyerror
            // 
            this.lbl_modifyerror.AutoSize = true;
            this.lbl_modifyerror.BackColor = System.Drawing.Color.Transparent;
            this.lbl_modifyerror.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modifyerror.ForeColor = System.Drawing.Color.Red;
            this.lbl_modifyerror.Location = new System.Drawing.Point(275, 452);
            this.lbl_modifyerror.Name = "lbl_modifyerror";
            this.lbl_modifyerror.Size = new System.Drawing.Size(329, 23);
            this.lbl_modifyerror.TabIndex = 61;
            this.lbl_modifyerror.Text = "INCORRECT DETAILS! PLS. CHECK AGAIN!";
            this.lbl_modifyerror.Visible = false;
            // 
            // lbl_insertedrecord
            // 
            this.lbl_insertedrecord.AutoSize = true;
            this.lbl_insertedrecord.BackColor = System.Drawing.Color.Transparent;
            this.lbl_insertedrecord.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_insertedrecord.ForeColor = System.Drawing.Color.Green;
            this.lbl_insertedrecord.Location = new System.Drawing.Point(304, 452);
            this.lbl_insertedrecord.Name = "lbl_insertedrecord";
            this.lbl_insertedrecord.Size = new System.Drawing.Size(280, 23);
            this.lbl_insertedrecord.TabIndex = 62;
            this.lbl_insertedrecord.Text = "RECORD SUCCESSFULLY INSERTED!";
            this.lbl_insertedrecord.Visible = false;
            // 
            // lbl_updatedrecord
            // 
            this.lbl_updatedrecord.AutoSize = true;
            this.lbl_updatedrecord.BackColor = System.Drawing.Color.Transparent;
            this.lbl_updatedrecord.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_updatedrecord.ForeColor = System.Drawing.Color.Green;
            this.lbl_updatedrecord.Location = new System.Drawing.Point(304, 452);
            this.lbl_updatedrecord.Name = "lbl_updatedrecord";
            this.lbl_updatedrecord.Size = new System.Drawing.Size(278, 23);
            this.lbl_updatedrecord.TabIndex = 63;
            this.lbl_updatedrecord.Text = "RECORD SUCCESSFULLY UPDATED!";
            this.lbl_updatedrecord.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // cbox_productname
            // 
            this.cbox_productname.DataSource = this.tblstocksBindingSource;
            this.cbox_productname.DisplayMember = "Name_of_Product";
            this.cbox_productname.FormattingEnabled = true;
            this.cbox_productname.Location = new System.Drawing.Point(220, 116);
            this.cbox_productname.Name = "cbox_productname";
            this.cbox_productname.Size = new System.Drawing.Size(277, 21);
            this.cbox_productname.TabIndex = 114;
            // 
            // tblstocksBindingSource
            // 
            this.tblstocksBindingSource.DataMember = "tbl_stocks";
            this.tblstocksBindingSource.DataSource = this.dataSet1;
            // 
            // tbl_stocksTableAdapter
            // 
            this.tbl_stocksTableAdapter.ClearBeforeFill = true;
            // 
            // frm_modifyrecordsvip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AryaStarkHashiqCsd55.Properties.Resources.pic_white_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.cbox_productname);
            this.Controls.Add(this.lbl_updatedrecord);
            this.Controls.Add(this.lbl_insertedrecord);
            this.Controls.Add(this.lbl_modifyerror);
            this.Controls.Add(this.mtxt_quantity);
            this.Controls.Add(this.cbox_handledby);
            this.Controls.Add(this.cbox_location);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_recordid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_nameofsupplier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_modifyrecordsvip";
            this.Text = "Modify Records VIP";
            this.Load += new System.EventHandler(this.frm_modifyrecordsVIP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aryastarkhashiqcsd55DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstocksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_back;
        private MetroFramework.Controls.MetroButton btn_update;
        private MetroFramework.Controls.MetroButton btn_clear;
        private MetroFramework.Controls.MetroButton btn_insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofReminderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationofSupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofSupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityNeededDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handledByDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblrecordsBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.TextBox txt_nameofsupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DataSet1TableAdapters.tbl_recordsTableAdapter tbl_recordsTableAdapter1;
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
        private System.Windows.Forms.TextBox txt_recordid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.ComboBox cbox_location;
        private System.Windows.Forms.MaskedTextBox mtxt_quantity;
        private System.Windows.Forms.ComboBox cbox_handledby;
        private aryastarkhashiqcsd55DataSet1 aryastarkhashiqcsd55DataSet1;
        private System.Windows.Forms.BindingSource tbluserdetailsBindingSource;
        private aryastarkhashiqcsd55DataSet1TableAdapters.tbl_user_detailsTableAdapter tbl_user_detailsTableAdapter;
        private System.Windows.Forms.Label lbl_modifyerror;
        private System.Windows.Forms.Label lbl_insertedrecord;
        private System.Windows.Forms.Label lbl_updatedrecord;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ToolStripMenuItem showChartsToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbox_productname;
        private System.Windows.Forms.BindingSource tblstocksBindingSource;
        private DataSet1TableAdapters.tbl_stocksTableAdapter tbl_stocksTableAdapter;
    }
}