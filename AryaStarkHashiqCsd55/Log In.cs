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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void welcomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_welcome();
            frm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_loginuser_Load(object sender, EventArgs e)
        {


        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.pic7;
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.pic9;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.pic8;
        }

        

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            login(txt_username.Text, txt_password.Text);

        }

        private void btn_reset_Click_1(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            this.lbl_loginerror.Hide();
            this.lbl_invalidrole.Hide();
        }

        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frm_aboutus();
            frm.Show();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void login(string username, string password)
        {
            try
            {
                if (tbl_user_detailsTableAdapter1.GetDataForLogin(username, password).Rows.Count == 1)
                {
                    string role = tbl_user_detailsTableAdapter1.GetDataForLogin(username, password).Rows[0]["User_role"].ToString();

                    switch (role)
                  {
                          case "Admin":
                            frm_homeadmin frm = new frm_homeadmin();
                            frm.Show();
                            this.Hide();
                            notifyIcon1.ShowBalloonTip(100000, "Login Success!", "You are Logged In as an Admin User!", ToolTipIcon.Info);


                            break;
                        case "Economy":
                            frm_homeuser frme = new frm_homeuser();
                            frme.Show();
                            this.Hide();

                            notifyIcon1.ShowBalloonTip(100000, "Login Success!", "You are Logged In as an Economy User!", ToolTipIcon.Info);

                            break;
                        case "Premium":
                            frm_homeuser frmp = new frm_homeuser();
                            frmp.Show();
                            this.Hide();

                            notifyIcon1.ShowBalloonTip(100000, "Login Success!", "You are Logged In as a Premium User!", ToolTipIcon.Info);

                            break;
                        case "VIP":
                            frm_homeuser frmv = new frm_homeuser();
                            frmv.Show();
                            this.Hide();

                            notifyIcon1.ShowBalloonTip(100000, "Login Success!", "You are Logged In as a VIP User!", ToolTipIcon.Info);

                            break;

                        default:
                            this.lbl_invalidrole.Show();
                            txt_username.Clear();
                            txt_password.Clear();
                            break;
                    }
                }
                else
                {
                    this.lbl_loginerror.Show();
                    txt_username.Clear();
                    txt_password.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                throw;
            }
            finally
            {

                notifyIcon1.Icon = null;

            }
        }
    }

    }

        
