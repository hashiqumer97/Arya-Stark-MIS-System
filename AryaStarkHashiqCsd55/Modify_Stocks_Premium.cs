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
    public partial class frm_modifystockspremium : Form
    {
        public frm_modifystockspremium()
        {
            InitializeComponent();
        }

        private void Modify_Stocks_Premium_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aryastarkhashiqcsd55DataSet1.tbl_client' table. You can move, or remove it, as needed.
            this.tbl_clientTableAdapter.Fill(this.aryastarkhashiqcsd55DataSet1.tbl_client);
            // TODO: This line of code loads data into the 'dataSet1.tbl_stocks' table. You can move, or remove it, as needed.
            this.tbl_stocksTableAdapter1.Fill(this.dataSet1.tbl_stocks);
            txt_stockid.Enabled = false;

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_stockid.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (txt_productname.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (txt_perproductprice.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (txt_date.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (txt_nameofsupplier.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (cbox_clientid.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else
                {
                    decimal perproductprice;
                    decimal.TryParse(txt_perproductprice.Text, out perproductprice);
                    DateTime date;
                    DateTime.TryParse(txt_date.Text, out date);
                    int clientid;
                    int.TryParse(cbox_clientid.Text, out clientid);
                    tbl_stocksTableAdapter1.InsertQueryForStocks(txt_productname.Text, date, txt_nameofsupplier.Text, clientid, perproductprice);
                    lbl_insertedrecord.Show();
                    dataGridView1.DataSource = tbl_stocksTableAdapter1.GetData();
                }
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
                else if (item is MaskedTextBox)
                {
                    MaskedTextBox m = (MaskedTextBox)item;
                    m.Clear();
                }
                else if (item is ComboBox)
                {
                    ComboBox c = (ComboBox)item;
                    c.SelectedIndex = -1;
                }
                else
                {
                    if (item.Controls.Count > 0)
                    {
                        ClearAll(item);
                        lbl_modifyerror.Hide();
                        lbl_insertedrecord.Hide();
                    }
                }
            }
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form frm = new frm_userstocks();
            frm.Show();
            this.Hide();
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

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dataGridView1.SelectionMode =
            DataGridViewSelectionMode.RowHeaderSelect;
            this.dataGridView1.Rows[e.RowIndex].Selected = true;

            txt_stockid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_stockid.Enabled = false;
            txt_productname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_perproductprice.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_date.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_nameofsupplier.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbox_clientid.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void txt_productname_TextChanged(object sender, EventArgs e)
        {
            if (txt_productname.TextLength > 45)
            {
                errorProvider1.SetError(txt_productname, "Product Name Should Not Exceed More Than 45 Characters!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void mtxt_quantity_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_nameofsupplier_TextChanged(object sender, EventArgs e)
        {
            if (txt_nameofsupplier.TextLength > 45)
            {
                errorProvider3.SetError(txt_nameofsupplier, "Supplier Name Should Not Exceed More Than 45 Characters");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void txt_perproductprice_TextChanged(object sender, EventArgs e)
        {
            if (!txt_perproductprice.Text.Contains("."))
            {
                errorProvider2.SetError(txt_perproductprice, "Incorrect Pricing Format, Please Check Again!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void showChartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_chart();
            frm.Show();
            this.Hide();
        }
    }
}
