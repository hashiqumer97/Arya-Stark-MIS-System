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
    public partial class frm_userdetails : Form
    {
        public frm_userdetails()
        {
            InitializeComponent();
        }

        private void frm_userdetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tbl_transactions' table. You can move, or remove it, as needed.
            this.tbl_transactionsTableAdapter.Fill(this.dataSet1.tbl_transactions);
            // TODO: This line of code loads data into the 'dataSet1.tbl_user_details' table. You can move, or remove it, as needed.
            this.tbl_user_detailsTableAdapter.Fill(this.dataSet1.tbl_user_details);

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(txt_userdetailssearch.TextLength > 0)
            {
                dataGridView1.DataSource = tbl_user_detailsTableAdapter.GetDataBySearchUser(txt_userdetailssearch.Text + "%");
            }
        }

        

        

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_homeadmin();
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

        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_recordsadmin();
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

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            txt_userdetailssearch.Clear();
            dataGridView1.DataSource = tbl_user_detailsTableAdapter.GetData();
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            if (txt_userdetailssearch.TextLength > 0)
            {
                dataGridView1.DataSource = tbl_user_detailsTableAdapter.GetDataBySearchUser(txt_userdetailssearch.Text + "%");
            }
        }

        private void btn_modifyrecord_Click(object sender, EventArgs e)
        {
            Form frm = new frm_modifyuserdetails();
            frm.Show();
            this.Hide();
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

        private void modifyRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_modifyrecords();
            frm.Show();
            this.Hide();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_aboutus();
            frm.Show();
        }

        private void showChartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_admincharts();
            frm.Show();
            this.Hide();
        }

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_validateusermenu();
            frm.Show();
            this.Hide();
        }
    }
}
