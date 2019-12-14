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
    public partial class frm_modifyrecords : Form
    {
        public frm_modifyrecords()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new frm_recordsadmin();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_recordid.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (cbox_productname.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (txt_date.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (cbox_location.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (txt_nameofsupplier.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (mtxt_quantity.Text == "")
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
                    int handledby;
                    int.TryParse(cbox_handledby.Text, out handledby);
                    tbl_recordsTableAdapter1.InsertQueryForRecords(cbox_productname.Text, date, cbox_location.Text, txt_nameofsupplier.Text, quantity, handledby);
                    this.lbl_insertedrecord.Show();
                    dataGridView1.DataSource = tbl_recordsTableAdapter1.GetData(); ;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_recordid.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (cbox_productname.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (txt_date.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (cbox_location.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (txt_nameofsupplier.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (mtxt_quantity.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else if (cbox_handledby.Text == "")
                {
                    lbl_modifyerror.Show();
                }
                else
                {

                    
                        int recordid;
                        int.TryParse(txt_recordid.Text, out recordid);
                        tbl_recordsTableAdapter1.DeleteQueryForRecords(recordid);

                        this.lbl_deletedrecord.Show();
                        dataGridView1.DataSource = tbl_recordsTableAdapter1.GetData();
                    
                }

            }

            catch (Exception)
            {

                throw;
            }
        }
              
        

        private void button2_Click(object sender, EventArgs e)
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
                    MaskedTextBox d = (MaskedTextBox)item;
                    d.Clear();
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
                        this.lbl_modifyerror.Hide();
                        this.lbl_insertedrecord.Hide();
                        this.lbl_deletedrecord.Hide();
                        this.lbl_updatedrecord.Hide();

                        
                    }
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            {       
                try
                {
                    if (txt_recordid.Text == "")
                    {
                        lbl_modifyerror.Show();
                    }
                    else if (cbox_productname.Text == "")
                    {
                        lbl_modifyerror.Show();
                    }
                    else if (txt_date.Text == "")
                    {
                        lbl_modifyerror.Show();
                    }
                    else if (cbox_location.Text == "")
                    {
                        lbl_modifyerror.Show();
                    }
                    else if (txt_nameofsupplier.Text == "")
                    {
                        lbl_modifyerror.Show();
                    }
                    else if (mtxt_quantity.Text == "")
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
                        int handledby;
                        int.TryParse(cbox_handledby.Text, out handledby);
                        int recordid;
                        int.TryParse(txt_recordid.Text, out recordid);
                        tbl_recordsTableAdapter1.UpdateQueryForRecords(recordid, cbox_productname.Text, date, cbox_location.Text, txt_nameofsupplier.Text, quantity, handledby);
                        this.lbl_updatedrecord.Show();
                        dataGridView1.DataSource = tbl_recordsTableAdapter1.GetData();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
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

        private void frm_modifyrecords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tbl_stocks' table. You can move, or remove it, as needed.
            this.tbl_stocksTableAdapter.Fill(this.dataSet1.tbl_stocks);
            // TODO: This line of code loads data into the 'aryastarkhashiqcsd55DataSet1.tbl_user_details' table. You can move, or remove it, as needed.
            this.tbl_user_detailsTableAdapter.Fill(this.aryastarkhashiqcsd55DataSet1.tbl_user_details);
            this.tbl_recordsTableAdapter1.Fill(this.dataSet1.tbl_records);
            txt_recordid.Enabled = false;
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dataGridView1.SelectionMode =
            DataGridViewSelectionMode.RowHeaderSelect;
            this.dataGridView1.Rows[e.RowIndex].Selected = true;

            txt_recordid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_recordid.Enabled = false;
            cbox_productname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_date.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbox_location.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_nameofsupplier.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            mtxt_quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbox_handledby.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void txt_nameofsupplier_TextChanged(object sender, EventArgs e)
        {
            if (txt_nameofsupplier.TextLength > 45)
            {
                errorProvider2.SetError(txt_nameofsupplier, "Supplier Name Should Not Exceed 45 Characters!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }


        private void mtxt_quantity_TextChanged(object sender, EventArgs e)
        {
            int quantity;
            int.TryParse(mtxt_quantity.Text, out quantity);
            if(quantity > 100)
            {
                errorProvider3.SetError(mtxt_quantity, "Quantity Should Not Exceed More than 100");
            }
            else
            {
                errorProvider3.Clear();
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
