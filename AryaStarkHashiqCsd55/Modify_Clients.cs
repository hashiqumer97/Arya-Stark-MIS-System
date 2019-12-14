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
    public partial class frm_modifyclients : Form
    {
        public frm_modifyclients()
        {
            InitializeComponent();

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


                else
                {
                    if (item.Controls.Count > 0)
                    {
                        ClearAll(item);
                        
                        this.lbl_modifyerror.Hide();
                        this.lbl_recordinserted.Hide();
                        this.lbl_updatedrecord.Hide();
                        this.lbl_deletedrecord.Hide();
                    }

                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int clientid;
            int.TryParse(txt_clientid.Text, out clientid);
            deleterecord(clientid);
        }

        private void btn_update_Click(object sender, EventArgs e)
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
                    int clientid;
                    int.TryParse(txt_clientid.Text, out clientid);
                    tbl_clientTableAdapter.UpdateQueryForClient(txt_clientname.Text, txt_officeaddress.Text, mtxt_telno.Text, handledby, clientid);
                    this.lbl_updatedrecord.Show();
                    dataGridView1.DataSource = tbl_clientTableAdapter.GetData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }




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

        private void btn_insert_Click_1(object sender, EventArgs e)
        {
            int handledby;
            int.TryParse(cbox_handledby.SelectedItem.ToString(), out handledby);
           
            insertrecord(txt_clientname.Text, txt_officeaddress.Text, mtxt_telno.Text, handledby); ;
        }


        private void frm_modifyclients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.tbl_client' table. You can move, or remove it, as needed.
            this.tbl_clientTableAdapter.Fill(this.dataSet11.tbl_client);
            // TODO: This line of code loads data into the 'aryastarkhashiqcsd55DataSet.tbl_user_details' table. You can move, or remove it, as needed.
            this.tbl_user_detailsTableAdapter.Fill(this.aryastarkhashiqcsd55DataSet.tbl_user_details);
            // TODO: This line of code loads data into the 'dataSet11.tbl_stocks' table. You can move, or remove it, as needed.
            
            this.tbl_clientTableAdapter.Fill(this.dataSet11.tbl_client);
            txt_clientid.Enabled = false;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_homeadmin();
            frm.Show();
            this.Hide();
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            Form frm = new frm_adminclients();
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

        public void insertrecord(string clientname, string officeaddress, string telno, int handledby)
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
                    int handledby1;
                    int.TryParse(cbox_handledby.Text, out handledby1);

                    tbl_clientTableAdapter.InsertQueryForClients(txt_clientname.Text, txt_officeaddress.Text, mtxt_telno.Text, handledby1);

                    dataGridView1.DataSource = tbl_clientTableAdapter.GetData();
                    this.lbl_recordinserted.Show();
                    
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;

            }

        }
        public void deleterecord(int clientid)
        {
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
                        int clientid1;
                        int.TryParse(txt_clientid.Text, out clientid1);

                        tbl_clientTableAdapter.DeleteQueryForClients(clientid1);

                        this.lbl_deletedrecord.Show();

                        dataGridView1.DataSource = tbl_clientTableAdapter.GetData();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void txt_clientname_TextChanged(object sender, EventArgs e)
        {
            if(txt_clientname.TextLength > 45)
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
            if(txt_officeaddress.TextLength > 100)
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
            Form frm = new frm_admincharts();
            frm.Show();
            this.Hide();
        }
    }
}

    


