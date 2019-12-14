namespace AryaStarkHashiqCsd55
{
    partial class frm_chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_chart));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.barchart = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barchart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbltransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new AryaStarkHashiqCsd55.DataSet1();
            this.piechart = new System.Windows.Forms.TabPage();
            this.linechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tbl_transactionsTableAdapter1 = new AryaStarkHashiqCsd55.DataSet1TableAdapters.tbl_transactionsTableAdapter();
            this.btn_printpreview = new MetroFramework.Controls.MetroButton();
            this.btn_print = new MetroFramework.Controls.MetroButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.modifyClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.barchart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barchart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.piechart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linechart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.barchart);
            this.tabControl1.Controls.Add(this.piechart);
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // barchart
            // 
            this.barchart.Controls.Add(this.label2);
            this.barchart.Controls.Add(this.label1);
            this.barchart.Controls.Add(this.barchart1);
            this.barchart.Location = new System.Drawing.Point(4, 22);
            this.barchart.Name = "barchart";
            this.barchart.Padding = new System.Windows.Forms.Padding(3);
            this.barchart.Size = new System.Drawing.Size(752, 407);
            this.barchart.TabIndex = 0;
            this.barchart.Text = "Bar Chart";
            this.barchart.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y Axis - Quantity of Products Sold";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X Axis - Transaction ID";
            // 
            // barchart1
            // 
            chartArea9.Name = "ChartArea1";
            this.barchart1.ChartAreas.Add(chartArea9);
            this.barchart1.DataSource = this.tbltransactionsBindingSource;
            legend9.Name = "Legend1";
            this.barchart1.Legends.Add(legend9);
            this.barchart1.Location = new System.Drawing.Point(-4, 0);
            this.barchart1.Name = "barchart1";
            this.barchart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Transaction Bar Chart";
            series9.XValueMember = "Transaction_ID";
            series9.YValueMembers = "Quantity_of_products_sold";
            this.barchart1.Series.Add(series9);
            this.barchart1.Size = new System.Drawing.Size(753, 380);
            this.barchart1.TabIndex = 0;
            this.barchart1.Text = "barchart";
            // 
            // tbltransactionsBindingSource
            // 
            this.tbltransactionsBindingSource.DataMember = "tbl_transactions";
            this.tbltransactionsBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // piechart
            // 
            this.piechart.Controls.Add(this.linechart);
            this.piechart.Location = new System.Drawing.Point(4, 22);
            this.piechart.Name = "piechart";
            this.piechart.Padding = new System.Windows.Forms.Padding(3);
            this.piechart.Size = new System.Drawing.Size(752, 407);
            this.piechart.TabIndex = 1;
            this.piechart.Text = "Line Chart";
            this.piechart.UseVisualStyleBackColor = true;
            // 
            // linechart
            // 
            chartArea10.Name = "ChartArea1";
            this.linechart.ChartAreas.Add(chartArea10);
            this.linechart.DataSource = this.tbltransactionsBindingSource;
            legend10.Name = "Legend1";
            this.linechart.Legends.Add(legend10);
            this.linechart.Location = new System.Drawing.Point(-4, 0);
            this.linechart.Name = "linechart";
            this.linechart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.LegendText = "Quantity of Products Sold\\nDate of Transaction\\n";
            series10.Name = "Series1";
            series10.XValueMember = "Date_of_Transaction";
            series10.YValueMembers = "Quantity_of_products_sold";
            this.linechart.Series.Add(series10);
            this.linechart.Size = new System.Drawing.Size(750, 401);
            this.linechart.TabIndex = 0;
            this.linechart.Text = "piechart";
            title5.Name = "Pie Chart";
            this.linechart.Titles.Add(title5);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 2;
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
            // stocksToolStripMenuItem
            // 
            this.stocksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyStocksToolStripMenuItem});
            this.stocksToolStripMenuItem.Name = "stocksToolStripMenuItem";
            this.stocksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stocksToolStripMenuItem.Text = "Stocks";
            this.stocksToolStripMenuItem.Click += new System.EventHandler(this.stocksToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyTransactionsToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyRecordsToolStripMenuItem});
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.recordsToolStripMenuItem.Text = "Records";
            this.recordsToolStripMenuItem.Click += new System.EventHandler(this.recordsToolStripMenuItem_Click);
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
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // tbl_transactionsTableAdapter1
            // 
            this.tbl_transactionsTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_printpreview
            // 
            this.btn_printpreview.Location = new System.Drawing.Point(181, 516);
            this.btn_printpreview.Name = "btn_printpreview";
            this.btn_printpreview.Size = new System.Drawing.Size(116, 23);
            this.btn_printpreview.TabIndex = 3;
            this.btn_printpreview.Text = "Print Preview";
            this.btn_printpreview.UseSelectable = true;
            this.btn_printpreview.Click += new System.EventHandler(this.btn_printpreview_Click_1);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(303, 516);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(116, 23);
            this.btn_print.TabIndex = 4;
            this.btn_print.Text = "Print";
            this.btn_print.UseSelectable = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click_1);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(425, 516);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(112, 23);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // modifyClientsToolStripMenuItem
            // 
            this.modifyClientsToolStripMenuItem.Name = "modifyClientsToolStripMenuItem";
            this.modifyClientsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modifyClientsToolStripMenuItem.Text = "Modify Clients";
            this.modifyClientsToolStripMenuItem.Click += new System.EventHandler(this.modifyClientsToolStripMenuItem_Click);
            // 
            // modifyStocksToolStripMenuItem
            // 
            this.modifyStocksToolStripMenuItem.Name = "modifyStocksToolStripMenuItem";
            this.modifyStocksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modifyStocksToolStripMenuItem.Text = "Modify Stocks";
            this.modifyStocksToolStripMenuItem.Click += new System.EventHandler(this.modifyStocksToolStripMenuItem_Click);
            // 
            // modifyTransactionsToolStripMenuItem
            // 
            this.modifyTransactionsToolStripMenuItem.Name = "modifyTransactionsToolStripMenuItem";
            this.modifyTransactionsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.modifyTransactionsToolStripMenuItem.Text = "Modify Transactions";
            this.modifyTransactionsToolStripMenuItem.Click += new System.EventHandler(this.modifyTransactionsToolStripMenuItem_Click);
            // 
            // modifyRecordsToolStripMenuItem
            // 
            this.modifyRecordsToolStripMenuItem.Name = "modifyRecordsToolStripMenuItem";
            this.modifyRecordsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.modifyRecordsToolStripMenuItem.Text = "Modify Records";
            this.modifyRecordsToolStripMenuItem.Click += new System.EventHandler(this.modifyRecordsToolStripMenuItem_Click);
            // 
            // frm_chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AryaStarkHashiqCsd55.Properties.Resources.pic_white_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_printpreview);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_chart";
            this.Text = "Charts";
            this.Load += new System.EventHandler(this.frm_chart_Load);
            this.tabControl1.ResumeLayout(false);
            this.barchart.ResumeLayout(false);
            this.barchart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barchart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.piechart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.linechart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage barchart;
        private System.Windows.Forms.TabPage piechart;
        private System.Windows.Forms.DataVisualization.Charting.Chart barchart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart linechart;
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
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DataSet1TableAdapters.tbl_transactionsTableAdapter tbl_transactionsTableAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource tbltransactionsBindingSource;
        private MetroFramework.Controls.MetroButton btn_printpreview;
        private MetroFramework.Controls.MetroButton btn_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private MetroFramework.Controls.MetroButton btn_back;
        private System.Windows.Forms.ToolStripMenuItem modifyClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyRecordsToolStripMenuItem;
    }
}