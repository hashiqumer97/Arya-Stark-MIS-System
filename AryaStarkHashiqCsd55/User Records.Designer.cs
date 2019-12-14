namespace AryaStarkHashiqCsd55
{
    partial class frm_userrecords
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
            this.txt_searchrecords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tbl_recordsTableAdapter = new AryaStarkHashiqCsd55.DataSet1TableAdapters.tbl_recordsTableAdapter();
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
            this.btn_clear = new MetroFramework.Controls.MetroButton();
            this.btn_search = new MetroFramework.Controls.MetroButton();
            this.btn_modifyrecord = new MetroFramework.Controls.MetroButton();
            this.btn_charts = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_searchrecords
            // 
            this.txt_searchrecords.Location = new System.Drawing.Point(97, 41);
            this.txt_searchrecords.Name = "txt_searchrecords";
            this.txt_searchrecords.Size = new System.Drawing.Size(418, 20);
            this.txt_searchrecords.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
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
            this.dataGridView1.Location = new System.Drawing.Point(16, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 301);
            this.dataGridView1.TabIndex = 3;
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
            // tbl_recordsTableAdapter
            // 
            this.tbl_recordsTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 5;
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
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyClientsToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.stocksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showChartsToolStripMenuItem});
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.recordsToolStripMenuItem.Text = "Records";
            this.recordsToolStripMenuItem.Click += new System.EventHandler(this.recordsToolStripMenuItem_Click);
            // 
            // showChartsToolStripMenuItem
            // 
            this.showChartsToolStripMenuItem.Name = "showChartsToolStripMenuItem";
            this.showChartsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showChartsToolStripMenuItem.Text = "Show Charts";
            this.showChartsToolStripMenuItem.Click += new System.EventHandler(this.showChartsToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(661, 37);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(111, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseSelectable = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(535, 37);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(120, 23);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "Search";
            this.btn_search.UseSelectable = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // btn_modifyrecord
            // 
            this.btn_modifyrecord.Location = new System.Drawing.Point(411, 480);
            this.btn_modifyrecord.Name = "btn_modifyrecord";
            this.btn_modifyrecord.Size = new System.Drawing.Size(166, 23);
            this.btn_modifyrecord.TabIndex = 8;
            this.btn_modifyrecord.Text = "Modify Record";
            this.btn_modifyrecord.UseSelectable = true;
            this.btn_modifyrecord.Click += new System.EventHandler(this.btn_modifyrecord_Click);
            // 
            // btn_charts
            // 
            this.btn_charts.Location = new System.Drawing.Point(210, 480);
            this.btn_charts.Name = "btn_charts";
            this.btn_charts.Size = new System.Drawing.Size(164, 23);
            this.btn_charts.TabIndex = 9;
            this.btn_charts.Text = "Show Charts";
            this.btn_charts.UseSelectable = true;
            this.btn_charts.Click += new System.EventHandler(this.btn_charts_Click);
            // 
            // frm_userrecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AryaStarkHashiqCsd55.Properties.Resources.pic_white_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_charts);
            this.Controls.Add(this.btn_modifyrecord);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_searchrecords);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_userrecords";
            this.Text = "Records";
            this.Load += new System.EventHandler(this.btn_records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_searchrecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tblrecordsBindingSource;
        private DataSet1TableAdapters.tbl_recordsTableAdapter tbl_recordsTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btn_clear;
        private MetroFramework.Controls.MetroButton btn_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofReminderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationofSupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofSupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityNeededDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handledByDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btn_modifyrecord;
        private System.Windows.Forms.ToolStripMenuItem modifyClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyStocksToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btn_charts;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showChartsToolStripMenuItem;
    }
}