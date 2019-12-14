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
    public partial class frm_userstocks : Form
    {
        public frm_userstocks()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_homeuser();
            frm.Show();
            frm.Hide();
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_userclient();
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

        private void frm_userstocks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tbl_stocks' table. You can move, or remove it, as needed.
            this.tbl_stocksTableAdapter.Fill(this.dataSet1.tbl_stocks);

        }

        

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm = new frm_homeuser();
            frm.Show();
            this.Hide();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_userstocks();
            frm.Show();
            this.Hide();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_modifytransactionsuser();
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(txt_searchstock.TextLength > 0)
            {
                dataGridView1.DataSource = tbl_stocksTableAdapter.GetDataBySearchStock(txt_searchstock.Text + "%");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_searchstock.Clear();
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            txt_searchstock.Clear();
            dataGridView1.DataSource = tbl_stocksTableAdapter.GetData();
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            if (txt_searchstock.TextLength > 0)
            {
                dataGridView1.DataSource = tbl_stocksTableAdapter.GetDataBySearchStock(txt_searchstock.Text + "%");
            }
        }

        private void btn_modifyrecord_Click(object sender, EventArgs e)
        {
            Form frm = new frm_validatestocks();
            frm.Show();
            this.Hide();
        }

        private void modifyClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_validateclients();
            frm.Show();
            this.Hide();
        }

        private void modifyTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_modifytransactionsuser();
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
        }

        private void showChartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_chart();
            frm.Show();
            this.Hide();
        }
    }
}
