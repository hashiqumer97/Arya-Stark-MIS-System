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
    public partial class frm_modifytransactionsuser : Form
    {
        public frm_modifytransactionsuser()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {


                if (cbox_nameoftransaction.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (txt_date.Text == "")
                {
                    lbl_modifyerror.Show();
                }

                else if (mtxt_quantity.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (txt_perproductprice.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (lbl_total.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (cbox_paymentmadein.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (cbox_methodofsending.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (cbox_handledby.Text == "")
                {
                    lbl_modifyerror.Show();
                }

                else
                {
                    DateTime date;
                    DateTime.TryParse(txt_date.Text, out date);
                    int quantity;
                    int.TryParse(mtxt_quantity.Text, out quantity);
                    decimal perproductprice;
                    decimal.TryParse(txt_perproductprice.Text, out perproductprice);
                    decimal total;
                    decimal.TryParse(lbl_total.Text, out total);
                    int handledby;
                    int.TryParse(cbox_handledby.Text, out handledby);
                    int num1 = Convert.ToInt32(mtxt_quantity.Text);
                    decimal num2 = Convert.ToDecimal(txt_perproductprice.Text);
                    decimal totalamount = num1 * num2;
                    lbl_total.Text = totalamount.ToString();
                    //tbl_transactionsTableAdapter1.InsertQueryForTransactions(cbox_nameoftransaction.Text, date, lbl_time.Text, quantity, totalamount, cbox_paymentmadein.SelectedItem.ToString(), cbox_methodofsending.SelectedItem.ToString(), handledby, perproductprice);


                    // dataGridView1.DataSource = tbl_transactionsTableAdapter1.GetData();

                    dataGridView1.Rows.Add(cbox_nameoftransaction.Text, txt_date.Text, mtxt_quantity.Text, cbox_paymentmadein.Text, cbox_methodofsending.Text, lbl_total.Text);

                    decimal num3 = Convert.ToDecimal(lbl_total.Text);
                    decimal num4 = Convert.ToDecimal(lbl_totalpayableamount.Text);

                    decimal tot = num3 + num4;
                    lbl_totalpayableamount.Text = tot.ToString();
                    lbl_totalpayableamount.Show();
                    mtxt_quantity.Clear();
                    lbl_insertedrecord.Show();
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
                        lbl_modifyerror.Hide();
                        lbl_insertedrecord.Hide();
                        lbl_updatedrecord.Hide();
                        lbl_deletedrecord.Hide();

                        txt_perproductprice.Text = (".00");
                        lbl_total.Text = ("0");
                        dataGridView1.Rows.Clear();
                        lbl_totalpayableamount.Text = ("0");


                    }
                }
            }
        }

 

        private void frm_modifytransactionsVIP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tbl_stocks' table. You can move, or remove it, as needed.
            this.tbl_stocksTableAdapter.Fill(this.dataSet1.tbl_stocks);
            // TODO: This line of code loads data into the 'aryastarkhashiqcsd55DataSet1.tbl_user_details' table. You can move, or remove it, as needed.
            this.tbl_user_detailsTableAdapter.Fill(this.aryastarkhashiqcsd55DataSet1.tbl_user_details);
            this.tbl_transactionsTableAdapter1.Fill(this.dataSet1.tbl_transactions);
            txt_transactionid.Enabled = false;



            lbl_total.Text = ("0");

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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dataGridView1.SelectionMode =
            DataGridViewSelectionMode.RowHeaderSelect;
            this.dataGridView1.Rows[e.RowIndex].Selected = true;


            cbox_nameoftransaction.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_date.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            mtxt_quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbox_paymentmadein.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbox_methodofsending.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            lbl_total.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mtxt_quantity_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxt_total_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_printpreview_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.Document = printDocument1;

                printPreviewDialog1.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.OK == printDialog1.ShowDialog())
                {
                    printDocument1.Print();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bm, new Rectangle(0, 0, panel1.Width, panel1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        

        private void mtxt_quantity_TextChanged(object sender, EventArgs e)
        {
            int quantity;
            int.TryParse(mtxt_quantity.Text, out quantity);
            decimal perproductprice;
            decimal.TryParse(txt_perproductprice.Text, out perproductprice);

            if (quantity > 10)
            {
                errorProvider2.SetError(mtxt_quantity, "Quantity Should Not Exceed More Than 10!");
            }
            else
            {
                errorProvider2.Clear();
            }
            if (quantity > 0)
            {
                int num1 = Convert.ToInt32(quantity);
                decimal num2 = Convert.ToDecimal(perproductprice);

                decimal totalamount = num1 * num2;
                lbl_total.Text = totalamount.ToString();
                lbl_total.Show();
            }
        }

        private void txt_perproductprice_TextChanged(object sender, EventArgs e)
        {
            if (!txt_perproductprice.Text.Contains("."))
            {
                errorProvider3.SetError(txt_perproductprice, "Incorrect Pricing Format, Please Check Again!");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbox_nameoftransaction.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (txt_date.Text == "")
                {
                    lbl_modifyerror.Show();
                }

                else if (mtxt_quantity.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (txt_perproductprice.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (lbl_total.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (cbox_paymentmadein.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (cbox_methodofsending.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (cbox_handledby.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else
                {
                    int transactionid;
                    int.TryParse(txt_transactionid.Text, out transactionid);
                    //tbl_transactionsTableAdapter1.DeleteQueryForTransactions(transactionid);

                    // lbl_deletedrecord.Show();


                    // dataGridView1.DataSource = tbl_transactionsTableAdapter1.GetData();
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);


                    decimal num5 = Convert.ToDecimal(lbl_total.Text);
                    decimal num6 = Convert.ToDecimal(lbl_totalpayableamount.Text);

                    decimal tot = num6 - num5;
                    lbl_totalpayableamount.Text = tot.ToString();
                    lbl_totalpayableamount.Show();
                    cbox_nameoftransaction.ResetText();
                    mtxt_quantity.Clear();
                    txt_perproductprice.Text = (".00");
                    cbox_paymentmadein.ResetText();
                    cbox_methodofsending.ResetText();
                    cbox_handledby.ResetText();
                    lbl_total.Text = ("0");
                    lbl_deletedrecord.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_printpreview_Click_1(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.Document = printDocument1;

                printPreviewDialog1.ShowDialog();
            }
            catch (Exception)
            {

                throw;
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
