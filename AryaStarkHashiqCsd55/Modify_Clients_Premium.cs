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
    public partial class frm_modifyclientpremium : Form
    {
        public frm_modifyclientpremium()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
       
                try
                {
                if (txt_clientname.Text == "")
                {
                    this.lbl_modifyerror.Show();
                }
                else if (txt_officeaddress.Text == "")
                {
                    this.lbl_modifyerror.Show();
                }
                else if (mtxt_telno.Text == "")
                {
                    this.lbl_modifyerror.Show();
                }
                else if (cbox_handledby.Text == "")
                {
                    this.lbl_modifyerror.Show();
                }
                else
                {
                    int handledby;
                    int.TryParse(cbox_handledby.Text, out handledby);

                    tbl_clientTableAdapter1.InsertQueryForClients(txt_clientname.Text, txt_officeaddress.Text, mtxt_telno.Text, handledby);
                    this.lbl_insertedrecord.Show();
                    dataGridView1.DataSource = tbl_clientTableAdapter1.GetData();
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

                else if(item is ComboBox)
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
                    }

                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form frm = new frm_userclient();
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

            txt_clientid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_clientid.Enabled = false;
            txt_clientname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_officeaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            mtxt_telno.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbox_handledby.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_modifyclientpremium_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aryastarkhashiqcsd55DataSet11.tbl_user_details' table. You can move, or remove it, as needed.
            this.tbl_user_detailsTableAdapter.Fill(this.aryastarkhashiqcsd55DataSet11.tbl_user_details);
            // TODO: This line of code loads data into the 'aryastarkhashiqcsd55DataSet1.tbl_user_details' table. You can move, or remove it, as needed.

            this.tbl_clientTableAdapter1.Fill(this.dataSet1.tbl_client);
            txt_clientid.Enabled = false;
        }

        private void txt_clientname_TextChanged(object sender, EventArgs e)
        {
            if (txt_clientname.TextLength > 45)
            {
                errorProvider1.SetError(txt_clientname, "Client Name Should Not Exceed 45 Characters!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_officeaddress_TextChanged(object sender, EventArgs e)
        {
            if (txt_officeaddress.TextLength > 100)
            {
                errorProvider2.SetError(txt_officeaddress, "Client Office Address Should Not Exceed 100 Characters!");
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
