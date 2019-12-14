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
    public partial class frm_userclient : Form
    {
        public frm_userclient()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_searchclient.TextLength > 0)
            {
                dataGridView1.DataSource = tbl_clientTableAdapter.GetDataBySearchClient(txt_searchclient.Text + "%");
            }
        }

        private void frm_userclient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.tbl_client' table. You can move, or remove it, as needed.
            this.tbl_clientTableAdapter.Fill(this.dataSet11.tbl_client);
            // TODO: This line of code loads data into the 'dataSet1.tbl_client' table. You can move, or remove it, as needed.
            this.tbl_clientTableAdapter.Fill(this.dataSet1.tbl_client);

        }

       

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_homeuser();
            frm.Show();
            this.Hide();
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
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

       

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            txt_searchclient.Clear();
            dataGridView1.DataSource = tbl_clientTableAdapter.GetData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_searchclient.TextLength > 0)
            {
                dataGridView1.DataSource = tbl_clientTableAdapter.GetDataBySearchClient(txt_searchclient.Text + "%");
            }
        }

        private void btn_modifyrecord_Click(object sender, EventArgs e)
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

        private void modifyTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_modifytransactionsadmin();
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

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showChartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_chart();
            frm.Show();
            this.Hide();
        }
    }
}
