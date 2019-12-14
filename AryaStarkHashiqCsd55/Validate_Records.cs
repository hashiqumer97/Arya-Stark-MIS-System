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
    public partial class frm_validaterecords : Form
    {
        public frm_validaterecords()
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
                            MessageBox.Show("You are not allowed to Modify Records Details");
                            txt_password.Clear();
                            break;
                        case "Premium":
                            frm_modifyrecordspremium frmp = new frm_modifyrecordspremium();
                            frmp.Show();
                            this.Hide();
                            txt_password.Clear();
                            break;
                        case "VIP":
                            frm_modifyrecordsvip frmv = new frm_modifyrecordsvip();
                            frmv.Show();
                            this.Hide();
                            txt_password.Clear();
                            break;

                        default:
                            lbl_passworderror.Show();
                            txt_password.Clear();
                            break;
                    }
                }
                else
                {
                    lbl_passworderror.Show();
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
            frm_userrecords frm = new frm_userrecords();
            frm.Show();
        }
    }
}
