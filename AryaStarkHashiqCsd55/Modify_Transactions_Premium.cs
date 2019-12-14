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
    public partial class frm_modifytransactionspremium : Form
    {
        public frm_modifytransactionspremium()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date;
                DateTime.TryParse(mtxt_dateoftransaction.Text, out date);
                int quantity;
                int.TryParse(txt_quantity.Text, out quantity);
                int total;
                int.TryParse(txt_total.Text, out total);
                int handledby;
                int.TryParse(txt_handledby.Text, out handledby);
                tbl_transactionsTableAdapter1.InsertQueryForTransactions(txt_nameoftransaction.Text, date, cbox_time.SelectedItem.ToString(), quantity, total, cbox_paymentmadein.SelectedItem.ToString(), cbox_methodofsending.SelectedItem.ToString(), handledby);
                MessageBox.Show("Record is Successfully Inserted!");
                dataGridView1.DataSource = tbl_transactionsTableAdapter1.GetData();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearAll(this);

        }

        public void ClearAll(Control ctrl)
        {
            foreach (Control item in ctrl.Controls)
            {
                if (item is TextBox)
                {
                    TextBox a = (TextBox)item;
                    a.Clear();
                }
                else if (item is ComboBox)
                {
                    ComboBox c = (ComboBox)item;
                    c.SelectedIndex = -1;
                }
                else if (item is MaskedTextBox)
                {
                    MaskedTextBox d = (MaskedTextBox)item;
                    d.Clear();
                }
                else
                {
                    if (item.Controls.Count > 0)
                    {
                        ClearAll(item);
                        txt_transactionid.Enabled = true;
                    }
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form frm = new frm_usertransactions();
            frm.Show();
            this.Hide();
        }

        private void frm_modifytransactionspremium_Load(object sender, EventArgs e)
        {
            this.tbl_transactionsTableAdapter1.Fill(this.dataSet1.tbl_transactions);
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

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_userstocks();
            frm.Show();
            this.Hide();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_usertransactions();
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

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_aboutus();
            frm.Show();
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

        private void modifyTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_validatetransactions();
            frm.Show();
            this.Hide();
        }

        private void modifyRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_validaterecords();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dataGridView1.SelectionMode =
            DataGridViewSelectionMode.RowHeaderSelect;
            this.dataGridView1.Rows[e.RowIndex].Selected = true;

            txt_transactionid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_transactionid.Enabled = false;
            txt_nameoftransaction.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            mtxt_dateoftransaction.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbox_time.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_total.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbox_paymentmadein.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbox_methodofsending.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_handledby.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
