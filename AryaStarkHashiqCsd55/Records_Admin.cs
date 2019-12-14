﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AryaStarkHashiqCsd55
{
    public partial class frm_recordsadmin : Form
    {
        public frm_recordsadmin()
        {
            InitializeComponent();
        }

        private void frm_recordsadmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tbl_records' table. You can move, or remove it, as needed.
            this.tbl_recordsTableAdapter.Fill(this.dataSet1.tbl_records);

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_homeadmin();
            frm.Show();
            this.Hide();
        }

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_validateusermenu();
            frm.Show();
            this.Hide();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_adminclients();
            frm.Show();
            this.Hide();
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_stocksadmin();
            frm.Show();
            this.Hide();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_modifytransactionsadmin();
            frm.Show();
            this.Hide();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_contactadmin();
            frm.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_welcome();
            frm.Show();
            this.Hide();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            Form frm = new frm_modifyrecords();
            frm.Show();
            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(txt_searchtransactions.TextLength > 0)
            {
                try
                {
                    dataGridView1.DataSource = tbl_recordsTableAdapter.GetDataBySearchRecords(txt_searchtransactions.Text + "%");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_searchtransactions.Clear();
            dataGridView1.DataSource = tbl_recordsTableAdapter.GetData();
        }

        

        private void modifyClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_modifyclients();
            frm.Show();
            this.Hide();
        }

        private void modifyStocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_modifystocks();
            frm.Show();
            this.Hide();
        }

        private void modifyTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_modifytransactionsadmin();
            frm.Show();
            this.Hide();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_aboutus();
            frm.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_charts_Click(object sender, EventArgs e)
        {
            Form frm = new frm_admincharts();
            frm.Show();
            this.Hide();
        }

        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_recordsadmin();
            frm.Show();
            this.Hide();
        }

        private void modifyRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_modifyrecords();
            frm.Show();
            this.Hide();
        }

        private void showChartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_admincharts();
            frm.Show();
            this.Hide();
        }
    }
}
