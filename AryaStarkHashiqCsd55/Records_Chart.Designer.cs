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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_chart));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.showChartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_printpreview = new MetroFramework.Controls.MetroButton();
            this.btn_print = new MetroFramework.Controls.MetroButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.tblrecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new AryaStarkHashiqCsd55.DataSet1();
            this.tbltransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_transactionsTableAdapter1 = new AryaStarkHashiqCsd55.DataSet1TableAdapters.tbl_transactionsTableAdapter();
            this.tbl_recordsTableAdapter = new AryaStarkHashiqCsd55.DataSet1TableAdapters.tbl_recordsTableAdapter();
            this.tblstocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_stocksTableAdapter = new AryaStarkHashiqCsd55.DataSet1TableAdapters.tbl_stocksTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.barchart = new System.Windows.Forms.TabPage();
            this.barchart_admin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.linechart = new System.Windows.Forms.TabPage();
            this.linechart_admin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblrecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstocksBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.barchart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barchart_admin)).BeginInit();
            this.linechart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linechart_admin)).BeginInit();
            this.SuspendLayout();
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
            // tblrecordsBindingSource
            // 
            this.tblrecordsBindingSource.DataMember = "tbl_records";
            this.tblrecordsBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbltransactionsBindingSource
            // 
            this.tbltransactionsBindingSource.DataMember = "tbl_transactions";
            this.tbltransactionsBindingSource.DataSource = this.dataSet11;
            // 
            // tbl_transactionsTableAdapter1
            // 
            this.tbl_transactionsTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_recordsTableAdapter
            // 
            this.tbl_recordsTableAdapter.ClearBeforeFill = true;
            // 
            // tblstocksBindingSource
            // 
            this.tblstocksBindingSource.DataMember = "tbl_stocks";
            this.tblstocksBindingSource.DataSource = this.dataSet11;
            // 
            // tbl_stocksTableAdapter
            // 
            this.tbl_stocksTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.barchart);
            this.tabControl1.Controls.Add(this.linechart);
            this.tabControl1.Location = new System.Drawing.Point(12, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 417);
            this.tabControl1.TabIndex = 6;
            // 
            // barchart
            // 
            this.barchart.Controls.Add(this.barchart_admin);
            this.barchart.Location = new System.Drawing.Point(4, 22);
            this.barchart.Name = "barchart";
            this.barchart.Padding = new System.Windows.Forms.Padding(3);
            this.barchart.Size = new System.Drawing.Size(752, 391);
            this.barchart.TabIndex = 0;
            this.barchart.Text = "Bar Chart";
            this.barchart.UseVisualStyleBackColor = true;
            // 
            // barchart_admin
            // 
            chartArea1.Name = "ChartArea1";
            this.barchart_admin.ChartAreas.Add(chartArea1);
            this.barchart_admin.DataSource = this.tblrecordsBindingSource;
            legend1.Name = "Legend1";
            this.barchart_admin.Legends.Add(legend1);
            this.barchart_admin.Location = new System.Drawing.Point(6, 6);
            this.barchart_admin.Name = "barchart_admin";
            this.barchart_admin.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Label = "#VAL";
            series1.Legend = "Legend1";
            series1.LegendText = "Quantity Needed";
            series1.Name = "Transaction Bar Chart";
            series1.XValueMember = "Name_of_Product";
            series1.YValueMembers = "Quantity_Needed";
            this.barchart_admin.Series.Add(series1);
            this.barchart_admin.Size = new System.Drawing.Size(743, 379);
            this.barchart_admin.TabIndex = 0;
            this.barchart_admin.Text = "barchart";
            // 
            // linechart
            // 
            this.linechart.Controls.Add(this.linechart_admin);
            this.linechart.Location = new System.Drawing.Point(4, 22);
            this.linechart.Name = "linechart";
            this.linechart.Padding = new System.Windows.Forms.Padding(3);
            this.linechart.Size = new System.Drawing.Size(752, 391);
            this.linechart.TabIndex = 1;
            this.linechart.Text = "Line Chart";
            this.linechart.UseVisualStyleBackColor = true;
            // 
            // linechart_admin
            // 
            chartArea2.Name = "ChartArea1";
            this.linechart_admin.ChartAreas.Add(chartArea2);
            this.linechart_admin.DataSource = this.tblrecordsBindingSource;
            legend2.Name = "Legend1";
            this.linechart_admin.Legends.Add(legend2);
            this.linechart_admin.Location = new System.Drawing.Point(3, 3);
            this.linechart_admin.Name = "linechart_admin";
            this.linechart_admin.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Label = "#VAL";
            series2.Legend = "Legend1";
            series2.LegendText = "Quantity Needed";
            series2.Name = "Transaction Line Chart";
            series2.XValueMember = "Name_of_Product";
            series2.YValueMembers = "Quantity_Needed";
            this.linechart_admin.Series.Add(series2);
            this.linechart_admin.Size = new System.Drawing.Size(743, 382);
            this.linechart_admin.TabIndex = 0;
            this.linechart_admin.Text = "linechart";
            // 
            // frm_chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AryaStarkHashiqCsd55.Properties.Resources.pic_white_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_printpreview);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_chart";
            this.Text = "Charts";
            this.Load += new System.EventHandler(this.frm_chart_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblrecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstocksBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.barchart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barchart_admin)).EndInit();
            this.linechart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.linechart_admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private DataSet1TableAdapters.tbl_transactionsTableAdapter tbl_transactionsTableAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource tbltransactionsBindingSource;
        private MetroFramework.Controls.MetroButton btn_printpreview;
        private MetroFramework.Controls.MetroButton btn_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private MetroFramework.Controls.MetroButton btn_back;
        private System.Windows.Forms.ToolStripMenuItem modifyClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyRecordsToolStripMenuItem;
        private System.Windows.Forms.BindingSource tblrecordsBindingSource;
        private DataSet1TableAdapters.tbl_recordsTableAdapter tbl_recordsTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem showChartsToolStripMenuItem;
        private System.Windows.Forms.BindingSource tblstocksBindingSource;
        private DataSet1TableAdapters.tbl_stocksTableAdapter tbl_stocksTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage barchart;
        private System.Windows.Forms.DataVisualization.Charting.Chart barchart_admin;
        private System.Windows.Forms.TabPage linechart;
        private System.Windows.Forms.DataVisualization.Charting.Chart linechart_admin;
    }
}