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
    public partial class frm_validateusermenu : Form
    {
        public frm_validateusermenu()
        {
            InitializeComponent();
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbl_user_detailsTableAdapter1.GetDataForLogin(txt_username.Text, txt_password.Text).Rows.Count == 1)
                {
                    string role = tbl_user_detailsTableAdapter1.GetDataForLogin(txt_username.Text, txt_password.Text).Rows[0]["User_role"].ToString();

                    switch (role)
                    {
                        case "Admin":
                            frm_userdetails frm = new frm_userdetails();
                            frm.Show();
                            this.Hide();
                           
                            break;
                        case "Economy":
                            MessageBox.Show("You are not allowed to Enter the User Details Section");
                            txt_username.Clear();
                            txt_password.Clear();
                            break;
                        case "Premium":
                            MessageBox.Show("You are not allowed to Enter the User Details Section");
                            txt_username.Clear();
                            txt_password.Clear();
                            break;

                        case "VIP":
                            MessageBox.Show("You are not allowed to Enter the User Details Section");
                            break;
                        default:
                            lbl_verifyerror.Show();
                            txt_username.Clear();
                            txt_password.Clear();
                            break;
                            
                    }
                }
                else
                {
                    lbl_verifyerror.Show();
                    txt_username.Clear();
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
            frm_homeadmin frm = new frm_homeadmin();
            frm.Show();
        }
    }
}
