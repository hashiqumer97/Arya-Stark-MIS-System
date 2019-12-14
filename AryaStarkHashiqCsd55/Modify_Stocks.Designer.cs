namespace AryaStarkHashiqCsd55
{
    partial class frm_modifystocks
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.txt_nameofsupplier = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showChartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_insert = new MetroFramework.Controls.MetroButton();
            this.btn_clear = new MetroFramework.Controls.MetroButton();
            this.btn_update = new MetroFramework.Controls.MetroButton();
            this.btn_delete = new MetroFramework.Controls.MetroButton();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet11 = new AryaStarkHashiqCsd55.DataSet1();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_stockid = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.tblclientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aryastarkhashiqcsd55DataSet1 = new AryaStarkHashiqCsd55.aryastarkhashiqcsd55DataSet1();
            this.tbl_clientTableAdapter = new AryaStarkHashiqCsd55.aryastarkhashiqcsd55DataSet1TableAdapters.tbl_clientTableAdapter();
            this.lbl_insertedrecord = new System.Windows.Forms.Label();
            this.lbl_updatedrecord = new System.Windows.Forms.Label();
            this.lbl_deletedrecord = new System.Windows.Forms.Label();
            this.lbl_modifyerror = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_perproductprice = new System.Windows.Forms.TextBox();
            this.tbl_stocksTableAdapter1 = new AryaStarkHashiqCsd55.DataSet1TableAdapters.tbl_stocksTableAdapter();
            this.cbox_clientid = new System.Windows.Forms.ComboBox();
            this.tblstocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofArrivalStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofSupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aryastarkhashiqcsd55DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstocksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Per Product Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Arrival Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name of Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Client ID";
            // 
            // txt_productname
            // 
            this.txt_productname.Location = new System.Drawing.Point(244, 157);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(261, 20);
            this.txt_productname.TabIndex = 5;
            this.txt_productname.TextChanged += new System.EventHandler(this.txt_productname_TextChanged);
            // 
            // txt_nameofsupplier
            // 
            this.txt_nameofsupplier.Location = new System.Drawing.Point(244, 311);
            this.txt_nameofsupplier.Name = "txt_nameofsupplier";
            this.txt_nameofsupplier.Size = new System.Drawing.Size(261, 20);
            this.txt_nameofsupplier.TabIndex = 8;
            this.txt_nameofsupplier.TextChanged += new System.EventHandler(this.txt_nameofsupplier_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.userDetailsToolStripMenuItem,
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
            // userDetailsToolStripMenuItem
            // 
            this.userDetailsToolStripMenuItem.Name = "userDetailsToolStripMenuItem";
            this.userDetailsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.userDetailsToolStripMenuItem.Text = "User Details";
            this.userDetailsToolStripMenuItem.Click += new System.EventHandler(this.userDetailsToolStripMenuItem_Click);
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
            this.modifyRecordsToolStripMenuItem,
            this.showChartsToolStripMenuItem});
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
            // showChartsToolStripMenuItem
            // 
            this.showChartsToolStripMenuItem.Name = "showChartsToolStripMenuItem";
            this.showChartsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
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
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(43, 496);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(108, 23);
            this.btn_insert.TabIndex = 15;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseSelectable = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click_1);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(168, 496);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(105, 23);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseSelectable = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(290, 496);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(109, 23);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "Update";
            this.btn_update.UseSelectable = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(421, 496);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(104, 23);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseSelectable = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(548, 496);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(115, 23);
            this.btn_back.TabIndex = 19;
            this.btn_back.Text = "Back";
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn,
            this.nameofProductDataGridViewTextBoxColumn,
            this.pricePerProductDataGridViewTextBoxColumn,
            this.dateofArrivalStockDataGridViewTextBoxColumn,
            this.nameofSupplierDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblstocksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(535, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 282);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Stock ID";
            // 
            // txt_stockid
            // 
            this.txt_stockid.Location = new System.Drawing.Point(244, 105);
            this.txt_stockid.Name = "txt_stockid";
            this.txt_stockid.Size = new System.Drawing.Size(261, 20);
            this.txt_stockid.TabIndex = 5;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(244, 253);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(261, 20);
            this.txt_date.TabIndex = 62;
            // 
            // tblclientBindingSource
            // 
            this.tblclientBindingSource.DataMember = "tbl_client";
            this.tblclientBindingSource.DataSource = this.aryastarkhashiqcsd55DataSet1;
            // 
            // aryastarkhashiqcsd55DataSet1
            // 
            this.aryastarkhashiqcsd55DataSet1.DataSetName = "aryastarkhashiqcsd55DataSet1";
            this.aryastarkhashiqcsd55DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_clientTableAdapter
            // 
            this.tbl_clientTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_insertedrecord
            // 
            this.lbl_insertedrecord.AutoSize = true;
            this.lbl_insertedrecord.BackColor = System.Drawing.Color.Transparent;
            this.lbl_insertedrecord.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_insertedrecord.ForeColor = System.Drawing.Color.Green;
            this.lbl_insertedrecord.Location = new System.Drawing.Point(301, 433);
            this.lbl_insertedrecord.Name = "lbl_insertedrecord";
            this.lbl_insertedrecord.Size = new System.Drawing.Size(280, 23);
            this.lbl_insertedrecord.TabIndex = 65;
            this.lbl_insertedrecord.Text = "RECORD SUCCESSFULLY INSERTED!";
            this.lbl_insertedrecord.Visible = false;
            // 
            // lbl_updatedrecord
            // 
            this.lbl_updatedrecord.AutoSize = true;
            this.lbl_updatedrecord.BackColor = System.Drawing.Color.Transparent;
            this.lbl_updatedrecord.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_updatedrecord.ForeColor = System.Drawing.Color.Green;
            this.lbl_updatedrecord.Location = new System.Drawing.Point(301, 433);
            this.lbl_updatedrecord.Name = "lbl_updatedrecord";
            this.lbl_updatedrecord.Size = new System.Drawing.Size(278, 23);
            this.lbl_updatedrecord.TabIndex = 66;
            this.lbl_updatedrecord.Text = "RECORD SUCCESSFULLY UPDATED!";
            this.lbl_updatedrecord.Visible = false;
            // 
            // lbl_deletedrecord
            // 
            this.lbl_deletedrecord.AutoSize = true;
            this.lbl_deletedrecord.BackColor = System.Drawing.Color.Transparent;
            this.lbl_deletedrecord.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deletedrecord.ForeColor = System.Drawing.Color.Green;
            this.lbl_deletedrecord.Location = new System.Drawing.Point(303, 433);
            this.lbl_deletedrecord.Name = "lbl_deletedrecord";
            this.lbl_deletedrecord.Size = new System.Drawing.Size(271, 23);
            this.lbl_deletedrecord.TabIndex = 67;
            this.lbl_deletedrecord.Text = "RECORD SUCCESSFULLY DELETED!";
            this.lbl_deletedrecord.Visible = false;
            // 
            // lbl_modifyerror
            // 
            this.lbl_modifyerror.AutoSize = true;
            this.lbl_modifyerror.BackColor = System.Drawing.Color.Transparent;
            this.lbl_modifyerror.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modifyerror.ForeColor = System.Drawing.Color.Red;
            this.lbl_modifyerror.Location = new System.Drawing.Point(270, 433);
            this.lbl_modifyerror.Name = "lbl_modifyerror";
            this.lbl_modifyerror.Size = new System.Drawing.Size(329, 23);
            this.lbl_modifyerror.TabIndex = 64;
            this.lbl_modifyerror.Text = "INCORRECT DETAILS! PLS. CHECK AGAIN!";
            this.lbl_modifyerror.Visible = false;
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
            // txt_perproductprice
            // 
            this.txt_perproductprice.Location = new System.Drawing.Point(244, 202);
            this.txt_perproductprice.Name = "txt_perproductprice";
            this.txt_perproductprice.Size = new System.Drawing.Size(260, 20);
            this.txt_perproductprice.TabIndex = 108;
            this.txt_perproductprice.Text = ".00";
            this.txt_perproductprice.TextChanged += new System.EventHandler(this.txt_perproductprice_TextChanged);
            // 
            // tbl_stocksTableAdapter1
            // 
            this.tbl_stocksTableAdapter1.ClearBeforeFill = true;
            // 
            // cbox_clientid
            // 
            this.cbox_clientid.DataSource = this.tblclientBindingSource;
            this.cbox_clientid.DisplayMember = "Client_id";
            this.cbox_clientid.FormattingEnabled = true;
            this.cbox_clientid.Location = new System.Drawing.Point(244, 365);
            this.cbox_clientid.Name = "cbox_clientid";
            this.cbox_clientid.Size = new System.Drawing.Size(261, 21);
            this.cbox_clientid.TabIndex = 63;
            // 
            // tblstocksBindingSource
            // 
            this.tblstocksBindingSource.DataMember = "tbl_stocks";
            this.tblstocksBindingSource.DataSource = this.dataSet11;
            // 
            // stockIDDataGridViewTextBoxColumn
            // 
            this.stockIDDataGridViewTextBoxColumn.DataPropertyName = "Stock_ID";
            this.stockIDDataGridViewTextBoxColumn.HeaderText = "Stock ID";
            this.stockIDDataGridViewTextBoxColumn.Name = "stockIDDataGridViewTextBoxColumn";
            // 
            // nameofProductDataGridViewTextBoxColumn
            // 
            this.nameofProductDataGridViewTextBoxColumn.DataPropertyName = "Name_of_Product";
            this.nameofProductDataGridViewTextBoxColumn.HeaderText = "Name of Product";
            this.nameofProductDataGridViewTextBoxColumn.Name = "nameofProductDataGridViewTextBoxColumn";
            // 
            // pricePerProductDataGridViewTextBoxColumn
            // 
            this.pricePerProductDataGridViewTextBoxColumn.DataPropertyName = "Price_Per_Product";
            this.pricePerProductDataGridViewTextBoxColumn.HeaderText = "Price Per Product";
            this.pricePerProductDataGridViewTextBoxColumn.Name = "pricePerProductDataGridViewTextBoxColumn";
            // 
            // dateofArrivalStockDataGridViewTextBoxColumn
            // 
            this.dateofArrivalStockDataGridViewTextBoxColumn.DataPropertyName = "Date_of_Arrival_Stock";
            this.dateofArrivalStockDataGridViewTextBoxColumn.HeaderText = "Date of Arrival Stock";
            this.dateofArrivalStockDataGridViewTextBoxColumn.Name = "dateofArrivalStockDataGridViewTextBoxColumn";
            // 
            // nameofSupplierDataGridViewTextBoxColumn
            // 
            this.nameofSupplierDataGridViewTextBoxColumn.DataPropertyName = "Name_of_Supplier";
            this.nameofSupplierDataGridViewTextBoxColumn.HeaderText = "Name of Supplier";
            this.nameofSupplierDataGridViewTextBoxColumn.Name = "nameofSupplierDataGridViewTextBoxColumn";
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "Client ID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // frm_modifystocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AryaStarkHashiqCsd55.Properties.Resources.pic_white_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.txt_perproductprice);
            this.Controls.Add(this.lbl_deletedrecord);
            this.Controls.Add(this.lbl_updatedrecord);
            this.Controls.Add(this.lbl_insertedrecord);
            this.Controls.Add(this.lbl_modifyerror);
            this.Controls.Add(this.cbox_clientid);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_nameofsupplier);
            this.Controls.Add(this.txt_stockid);
            this.Controls.Add(this.txt_productname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_modifystocks";
            this.Text = "Modify Stocks";
            this.Load += new System.EventHandler(this.frm_modifystocks_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aryastarkhashiqcsd55DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstocksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.TextBox txt_nameofsupplier;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btn_insert;
        private MetroFramework.Controls.MetroButton btn_clear;
        private MetroFramework.Controls.MetroButton btn_update;
        private MetroFramework.Controls.MetroButton btn_delete;
        private MetroFramework.Controls.MetroButton btn_back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem modifyClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyRecordsToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_stockid;
        private System.Windows.Forms.DateTimePicker txt_date;
        private aryastarkhashiqcsd55DataSet1 aryastarkhashiqcsd55DataSet1;
        private System.Windows.Forms.BindingSource tblclientBindingSource;
        private aryastarkhashiqcsd55DataSet1TableAdapters.tbl_clientTableAdapter tbl_clientTableAdapter;
        private System.Windows.Forms.Label lbl_insertedrecord;
        private System.Windows.Forms.Label lbl_updatedrecord;
        private System.Windows.Forms.Label lbl_deletedrecord;
        private System.Windows.Forms.Label lbl_modifyerror;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.TextBox txt_perproductprice;
        private DataSet1TableAdapters.tbl_stocksTableAdapter tbl_stocksTableAdapter1;
        private System.Windows.Forms.ComboBox cbox_clientid;
        private System.Windows.Forms.ToolStripMenuItem showChartsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofArrivalStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofSupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblstocksBindingSource;
    }
}