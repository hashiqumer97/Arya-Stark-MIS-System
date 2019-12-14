using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AryaStarkHashiqCsd55
{
    public partial class frm_usertransactions : Form
    {
        public frm_usertransactions()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_homeuser();
            frm.Show();
            this.Hide();
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_userclient();
            frm.Show();
            this.Hide();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_userstocks();
            frm.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_welcome();
            frm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_usertransactions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.tbl_transactions' table. You can move, or remove it, as needed.
            this.tbl_transactionsTableAdapter1.Fill(this.dataSet11.tbl_transactions);
            // TODO: This line of code loads data into the 'dataSet1.tbl_transactions' table. You can move, or remove it, as needed.
            this.tbl_transactionsTableAdapter1.Fill(this.dataSet11.tbl_transactions);

        }

       

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_homeuser();
            frm.Show();
            this.Hide();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_userclient();
            frm.Show();
            this.Hide();
        }

        private void stocksToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm = new frm_userstocks();
            frm.Show();
            this.Hide();
        }

        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_userrecords();
            frm.Show();
            this.Hide();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_usercontact();
            frm.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm = new Frm_welcome();
            frm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_searchtransactions.Clear();
        }

        private void btn_chart_Click(object sender, EventArgs e)
        {
            Form frm = new frm_chart();
            frm.Show();
            this.Hide();
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            txt_searchtransactions.Clear();
            dataGridView1.DataSource = tbl_transactionsTableAdapter1.GetData();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txt_searchtransactions.TextLength > 0)
            {
                dataGridView1.DataSource = tbl_transactionsTableAdapter.GetDataBySearchTransactions(txt_searchtransactions.Text + "%");
            }
        }

        private void btn_showcharts_Click(object sender, EventArgs e)
        {
            Form frm = new frm_chart();
            frm.Show();
            this.Hide();
        }

        private void btn_modifyrecord_Click(object sender, EventArgs e)
        {
            Form frm = new frm_validatetransactions();
            frm.Show();
            this.Hide();
        }

        private void modifyClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_validateclients();
            frm.Show();
            this.Hide();
        }

        private void modifyStocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_validatestocks();
            frm.Show();
            this.Hide();
        }

        private void modifyRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_validaterecords();
            frm.Show();
            this.Hide();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_aboutus();
            frm.Show();
            this.Hide();
        }
    }
}
