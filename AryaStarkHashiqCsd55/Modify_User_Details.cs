using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AryaStarkHashiqCsd55
{
    public partial class frm_modifyuserdetails : Form
    {
        public frm_modifyuserdetails()
        {
            InitializeComponent();

            
        }
        

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_userdetails();
            frm.Show();
            this.Hide();
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

        

       

        private void btn_insert_Click_1(object sender, EventArgs e)
        {

            string gender;

            if (rb_male.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            try
            {
                if (txt_password.Text == "")
                {
                    errorProvider9.SetError(txt_password, "Please Enter The Password To Insert The Record!");
                }
                else
                {
                    errorProvider9.Clear();
                    tbl_user_detailsTableAdapter1.InsertQueryForUserDetails(txt_firstname.Text, txt_lastname.Text, txt_address.Text, mtxt_nic.Text, mtxt_telno.Text, gender, cbox_urole.SelectedItem.ToString(), txt_username.Text, txt_password.Text);
                    lbl_insertedrecord.Show();
                    dataGridView1.DataSource = tbl_user_detailsTableAdapter1.GetData();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_clearall_Click(object sender, EventArgs e)
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
                else if (item is RadioButton)
                {
                    RadioButton b = (RadioButton)item;
                    b.Checked = false;
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
                        
                    }

                }

            }
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            { 
                try
                {
                        
                    if (txt_password.Text == "") 
                    {
                        errorProvider8.SetError(txt_password, "Please Enter The Password To Update The Record!");
                    }
                    else
                   

                    {
                        errorProvider8.Clear();

                        string gender = "Other";

                        if (rb_male.Checked)
                        {
                            gender = "Male";
                        }
                        else
                        {
                            gender = "Female";
                        }
                        int userid;
                        int.TryParse(txt_userid.Text, out userid);

                        tbl_user_detailsTableAdapter1.UpdateQueryForUserDetails(txt_firstname.Text, txt_lastname.Text, txt_address.Text, mtxt_nic.Text, mtxt_telno.Text, gender, cbox_urole.SelectedItem.ToString(), txt_username.Text, txt_password.Text, userid);
                        lbl_updatedrecord.Show();
                        dataGridView1.DataSource = tbl_user_detailsTableAdapter1.GetData();
                    }

                }
                catch (Exception)
                {

                    throw;
                }
                
            }
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            
            try
            { 
              
                
                {
                    
                    int userid;
                    int.TryParse(txt_userid.Text, out userid);

                    tbl_user_detailsTableAdapter1.DeleteQueryForUserDetails(userid);

                    lbl_deletedrecord.Show();
                    

                    dataGridView1.DataSource = tbl_user_detailsTableAdapter1.GetData();
                }


            }

            catch (Exception)
            {

                throw;
            }
        
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            Form frm = new frm_userdetails();
            frm.Show();
            this.Hide();
        }

        private void frm_modifyuserdetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tbl_user_details' table. You can move, or remove it, as needed.
            this.tbl_user_detailsTableAdapter1.Fill(this.dataSet1.tbl_user_details);
            txt_userid.Enabled = false;
            txt_password.Show();
            

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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dataGridView1.SelectionMode =
            DataGridViewSelectionMode.RowHeaderSelect;
            this.dataGridView1.Rows[e.RowIndex].Selected = true;


            string gender;
            if(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "Male")
            {
                rb_male.Checked = true;
            }
            else
            {
                rb_female.Checked = true;
            }
            

           
            txt_userid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_userid.Enabled = false;
            txt_firstname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_lastname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_address.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            mtxt_nic.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            mtxt_telno.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            gender = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbox_urole.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_username.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
           // txt_password.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();           
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_firstname_TextChanged(object sender, EventArgs e)
        {
            if(txt_firstname.TextLength > 45)
            {
                errorProvider1.SetError(txt_firstname, "First Name Should Not Exceed More Than 45 Characters");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_lastname_TextChanged(object sender, EventArgs e)
        {
            if(txt_lastname.TextLength > 45)
            {
                errorProvider2.SetError(txt_lastname, "Last Name Should Not Exceed More Than 45 Characters!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {
            if(txt_address.TextLength > 100)
            {
                errorProvider3.SetError(txt_address, "Address Should Not Exceed More Than 100 Characters!");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void groupBox1_TextChanged(object sender, EventArgs e)
        {
            if(rb_male.Checked == false | rb_female.Checked == false)
            {
                errorProvider4.SetError(groupBox1, "Please Provide the Gender!");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            if(txt_username.TextLength > 15)
            {
                errorProvider5.SetError(txt_username, "Username Should Not Exceed More Than 15 Characters!");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if(txt_password.TextLength > 15)
            {
                errorProvider6.SetError(txt_password, "Password Should Not Exceed More Than 15 Characters!");
            }
            else
            {
                errorProvider6.Clear();
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

