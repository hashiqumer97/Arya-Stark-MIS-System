namespace AryaStarkHashiqCsd55
{
    partial class frm_modifyclientpremium
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientOfficeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handledByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblclientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AryaStarkHashiqCsd55.DataSet1();
            this.btn_clear = new MetroFramework.Controls.MetroButton();
            this.btn_insert = new MetroFramework.Controls.MetroButton();
            this.mtxt_telno = new System.Windows.Forms.MaskedTextBox();
            this.txt_officeaddress = new System.Windows.Forms.TextBox();
            this.txt_clientname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbl_clientTableAdapter1 = new AryaStarkHashiqCsd55.DataSet1TableAdapters.tbl_clientTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_clientid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_user_detailsTableAdapter1 = new AryaStarkHashiqCsd55.DataSet1TableAdapters.tbl_user_detailsTableAdapter();
            this.tblclientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbox_handledby = new System.Windows.Forms.ComboBox();
            this.tbluserdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aryastarkhashiqcsd55DataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aryastarkhashiqcsd55DataSet11 = new AryaStarkHashiqCsd55.aryastarkhashiqcsd55DataSet1();
            this.tbl_user_detailsTableAdapter = new AryaStarkHashiqCsd55.aryastarkhashiqcsd55DataSet1TableAdapters.tbl_user_detailsTableAdapter();
            this.lbl_modifyerror = new System.Windows.Forms.Label();
            this.lbl_insertedrecord = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.showChartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblclientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aryastarkhashiqcsd55DataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aryastarkhashiqcsd55DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(314, 457);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(106, 23);
            this.btn_back.TabIndex = 46;
            this.btn_back.Text = "Back";
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientidDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientOfficeAddressDataGridViewTextBoxColumn,
            this.telephonenumberDataGridViewTextBoxColumn,
            this.handledByDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblclientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(550, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 274);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "Client_id";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "Client ID";
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Client Name";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            // 
            // clientOfficeAddressDataGridViewTextBoxColumn
            // 
            this.clientOfficeAddressDataGridViewTextBoxColumn.DataPropertyName = "Client_Office_Address";
            this.clientOfficeAddressDataGridViewTextBoxColumn.HeaderText = "Client Office Address";
            this.clientOfficeAddressDataGridViewTextBoxColumn.Name = "clientOfficeAddressDataGridViewTextBoxColumn";
            // 
            // telephonenumberDataGridViewTextBoxColumn
            // 
            this.telephonenumberDataGridViewTextBoxColumn.DataPropertyName = "Telephone_number";
            this.telephonenumberDataGridViewTextBoxColumn.HeaderText = "Telephone Number";
            this.telephonenumberDataGridViewTextBoxColumn.Name = "telephonenumberDataGridViewTextBoxColumn";
            // 
            // handledByDataGridViewTextBoxColumn
            // 
            this.handledByDataGridViewTextBoxColumn.DataPropertyName = "Handled_By";
            this.handledByDataGridViewTextBoxColumn.HeaderText = "Handled By";
            this.handledByDataGridViewTextBoxColumn.Name = "handledByDataGridViewTextBoxColumn";
            // 
            // tblclientBindingSource
            // 
            this.tblclientBindingSource.DataMember = "tbl_client";
            this.tblclientBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(173, 457);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(106, 23);
            this.btn_clear.TabIndex = 43;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseSelectable = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(37, 457);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(103, 23);
            this.btn_insert.TabIndex = 42;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseSelectable = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // mtxt_telno
            // 
            this.mtxt_telno.Location = new System.Drawing.Point(284, 265);
            this.mtxt_telno.Mask = "(000)0000000 ";
            this.mtxt_telno.Name = "mtxt_telno";
            this.mtxt_telno.Size = new System.Drawing.Size(249, 20);
            this.mtxt_telno.TabIndex = 41;
            // 
            // txt_officeaddress
            // 
            this.txt_officeaddress.Location = new System.Drawing.Point(284, 198);
            this.txt_officeaddress.Name = "txt_officeaddress";
            this.txt_officeaddress.Size = new System.Drawing.Size(249, 20);
            this.txt_officeaddress.TabIndex = 39;
            this.txt_officeaddress.TextChanged += new System.EventHandler(this.txt_officeaddress_TextChanged);
            // 
            // txt_clientname
            // 
            this.txt_clientname.Location = new System.Drawing.Point(284, 137);
            this.txt_clientname.Name = "txt_clientname";
            this.txt_clientname.Size = new System.Drawing.Size(249, 20);
            this.txt_clientname.TabIndex = 38;
            this.txt_clientname.TextChanged += new System.EventHandler(this.txt_clientname_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Handled By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Client Telephone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "Client Office Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Client Name";
            // 
            // tbl_clientTableAdapter1
            // 
            this.tbl_clientTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 47;
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
            this.modifyRecordsToolStripMenuItem,
            this.showChartsToolStripMenuItem});
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // txt_clientid
            // 
            this.txt_clientid.Location = new System.Drawing.Point(284, 82);
            this.txt_clientid.Name = "txt_clientid";
            this.txt_clientid.Size = new System.Drawing.Size(249, 20);
            this.txt_clientid.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 48;
            this.label1.Text = "Client ID";
            // 
            // tbl_user_detailsTableAdapter1
            // 
            this.tbl_user_detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // tblclientBindingSource1
            // 
            this.tblclientBindingSource1.DataMember = "tbl_client";
            // 
            // cbox_handledby
            // 
            this.cbox_handledby.DataSource = this.tbluserdetailsBindingSource;
            this.cbox_handledby.DisplayMember = "User_ID";
            this.cbox_handledby.FormattingEnabled = true;
            this.cbox_handledby.Location = new System.Drawing.Point(284, 331);
            this.cbox_handledby.Name = "cbox_handledby";
            this.cbox_handledby.Size = new System.Drawing.Size(249, 21);
            this.cbox_handledby.TabIndex = 50;
            // 
            // tbluserdetailsBindingSource
            // 
            this.tbluserdetailsBindingSource.DataMember = "tbl_user_details";
            this.tbluserdetailsBindingSource.DataSource = this.aryastarkhashiqcsd55DataSet11BindingSource;
            // 
            // aryastarkhashiqcsd55DataSet11BindingSource
            // 
            this.aryastarkhashiqcsd55DataSet11BindingSource.DataSource = this.aryastarkhashiqcsd55DataSet11;
            this.aryastarkhashiqcsd55DataSet11BindingSource.Position = 0;
            // 
            // aryastarkhashiqcsd55DataSet11
            // 
            this.aryastarkhashiqcsd55DataSet11.DataSetName = "aryastarkhashiqcsd55DataSet1";
            this.aryastarkhashiqcsd55DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.lbl_modifyerror.Location = new System.Drawing.Point(218, 401);
            this.lbl_modifyerror.Name = "lbl_modifyerror";
            this.lbl_modifyerror.Size = new System.Drawing.Size(329, 23);
            this.lbl_modifyerror.TabIndex = 51;
            this.lbl_modifyerror.Text = "INCORRECT DETAILS! PLS. CHECK AGAIN!";
            this.lbl_modifyerror.Visible = false;
            // 
            // lbl_insertedrecord
            // 
            this.lbl_insertedrecord.AutoSize = true;
            this.lbl_insertedrecord.BackColor = System.Drawing.Color.Transparent;
            this.lbl_insertedrecord.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_insertedrecord.ForeColor = System.Drawing.Color.Green;
            this.lbl_insertedrecord.Location = new System.Drawing.Point(246, 401);
            this.lbl_insertedrecord.Name = "lbl_insertedrecord";
            this.lbl_insertedrecord.Size = new System.Drawing.Size(280, 23);
            this.lbl_insertedrecord.TabIndex = 52;
            this.lbl_insertedrecord.Text = "RECORD SUCCESSFULLY INSERTED!";
            this.lbl_insertedrecord.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // showChartsToolStripMenuItem
            // 
            this.showChartsToolStripMenuItem.Name = "showChartsToolStripMenuItem";
            this.showChartsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.showChartsToolStripMenuItem.Text = "Show Charts";
            this.showChartsToolStripMenuItem.Click += new System.EventHandler(this.showChartsToolStripMenuItem_Click);
            // 
            // frm_modifyclientpremium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AryaStarkHashiqCsd55.Properties.Resources.pic_white_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.lbl_insertedrecord);
            this.Controls.Add(this.lbl_modifyerror);
            this.Controls.Add(this.cbox_handledby);
            this.Controls.Add(this.txt_clientid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.mtxt_telno);
            this.Controls.Add(this.txt_officeaddress);
            this.Controls.Add(this.txt_clientname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_modifyclientpremium";
            this.Text = "Modify Clients Premium";
            this.Load += new System.EventHandler(this.frm_modifyclientpremium_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblclientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aryastarkhashiqcsd55DataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aryastarkhashiqcsd55DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientOfficeAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handledByDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblclientBindingSource;
        private DataSet1 dataSet1;
        private MetroFramework.Controls.MetroButton btn_clear;
        private MetroFramework.Controls.MetroButton btn_insert;
        private System.Windows.Forms.MaskedTextBox mtxt_telno;
        private System.Windows.Forms.TextBox txt_officeaddress;
        private System.Windows.Forms.TextBox txt_clientname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DataSet1TableAdapters.tbl_clientTableAdapter tbl_clientTableAdapter1;
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
        private System.Windows.Forms.ToolStripMenuItem modifyRecordsToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_clientid;
        private System.Windows.Forms.Label label1;
        private DataSet1TableAdapters.tbl_user_detailsTableAdapter tbl_user_detailsTableAdapter1;
        private System.Windows.Forms.BindingSource tblclientBindingSource1;
        private System.Windows.Forms.ComboBox cbox_handledby;
        private aryastarkhashiqcsd55DataSet1 aryastarkhashiqcsd55DataSet1;
        private System.Windows.Forms.BindingSource aryastarkhashiqcsd55DataSet11BindingSource;
        private aryastarkhashiqcsd55DataSet1 aryastarkhashiqcsd55DataSet11;
        private System.Windows.Forms.BindingSource tbluserdetailsBindingSource;
        private aryastarkhashiqcsd55DataSet1TableAdapters.tbl_user_detailsTableAdapter tbl_user_detailsTableAdapter;
        private System.Windows.Forms.Label lbl_modifyerror;
        private System.Windows.Forms.Label lbl_insertedrecord;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ToolStripMenuItem showChartsToolStripMenuItem;
    }
}