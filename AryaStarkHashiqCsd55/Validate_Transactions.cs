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
    public partial class frm_validatetransactions : Form
    {
        public frm_validatetransactions()
        {
            InitializeComponent();
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbl_user_detailsTableAdapter1.GetDataForPassword(txt_password.Text).Rows.Count == 1)
                {
                    string role = tbl_user_detailsTableAdapter1.GetDataForPassword(txt_password.Text).Rows[0]["User_role"].ToString();

                    switch (role)
                    {

                        case "Economy":
                            MessageBox.Show("You are not allowed to Modify Transactions Details");
                            txt_password.Clear();
                            break;
                        case "Premium":
                            frm_modifytransactionspremium frmp = new frm_modifytransactionspremium();
                            frmp.Show();
                            this.Hide();
                            txt_password.Clear();
                            break;
                        case "VIP":
                            frm_modifytransactionsvip frmv = new frm_modifytransactionsvip();
                            frmv.Show();
                            this.Hide();
                            txt_password.Clear();
                            break;

                        default:
                            MessageBox.Show("Invalid Role. Please contact the administrator");
                            txt_password.Clear();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Authentication Failed!");
                    txt_password.Clear();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_usertransactions frm = new frm_usertransactions();
            frm.Show();
        }
    }
}
